using Library.Data;
using Library.Data.UnitOfWork;
using Library.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service
{
    public class BorrowService:BaseService
    {
        public bool Borrow(List<BorrowDTO> obj)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                try
                {
                   
                    foreach (var item in obj)
                    {
                        item.BeginDate = DateTime.Now;
                        item.EndDate = DateTime.Now.AddDays(14);


                        var entity = Mapper.Map<BorrowDTO, Borrow>(item);

                        uow.Borrows.Save(entity);

                        var book = uow.Books.Get(item.BookId);

                        book.UnitsInStock -= 1;

                        uow.Books.Update(book);
                    }
                    return uow.Commit();
                }
                catch (Exception ex)
                {
                    uow.RollBack();
                    return false;
                }
            }
        }   

        public bool Return(int studentId ,decimal penalty)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                try
                {
                    var borrowEntity = uow.Borrows.Search(x => x.StudentId == studentId && x.ReturnDate == null);

                    if (borrowEntity.Count == 0)
                    {
                        return false;
                    }

                    foreach (var item in borrowEntity)
                    {
                        item.ReturnDate = DateTime.Now;
                        uow.Borrows.Update(item);

                        var bookEntity = uow.Books.Get(item.BookId);
                        bookEntity.UnitsInStock += 1;
                        uow.Books.Update(bookEntity);
                    }

                    Penalty penaltyEntity = new Penalty
                    {
                        BorrowId = borrowEntity[0].BorrowId,
                        TotalAmount = penalty
                    };

                    uow.Penalties.Save(penaltyEntity);

                    return uow.Commit();
                }
                catch (Exception ex)
                {
                    uow.RollBack();
                    return false;
                }
            }
        }

        public List<BorrowDTO> ListBorrows()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entities = uow.Borrows.Search( x => x.ReturnDate == null && x.EndDate < DateTime.Now);

                if (entities.Count>0)
                {
                    List<BorrowDTO> list = new List<BorrowDTO>();

                    foreach (var item in entities)
                    {
                        BorrowDTO borrowDTO = new BorrowDTO
                        {
                            StudentId = item.StudentId,
                            StudentName = item.Student.FirstName + " " + item.Student.LastName
                           
                        };
                        list.Add(borrowDTO);


                    }
                    list = list.GroupBy(x => new { StudentId = x.StudentId, StudentName = x.StudentName })
                        .Select(x => new BorrowDTO { StudentId = x.Key.StudentId, StudentName = x.Key.StudentName, NumberOfBooks = x.Count() })
                        .ToList();

                    return list;
                }
                else
                {
                    return null;
                }
            }
        }   

        public List<BookDTO> ListBorrowedBooks(int studentId)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var borrowEntities = uow.Borrows.Search(x=>x.StudentId == studentId && x.ReturnDate == null);

                List<BookDTO> list = new List<BookDTO>();

                foreach (var item in borrowEntities)
                {
                    var bookEntity = uow.Books.Get(item.BookId);
                    BookDTO bookDTO = new BookDTO
                    {
                        BookId = bookEntity.BookId,
                        BookName = bookEntity.BookName
                    };

                    list.Add(bookDTO);                  
                }
                return list;
            }
        }

        public InformationDTO GetBorrowDetails(int studentId)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var borrows = uow.Borrows.Search(
                    x =>
                    x.ReturnDate == null &&
                    x.EndDate < DateTime.Now);

                InformationDTO info = new InformationDTO
                {
                    EndDate = borrows[0].EndDate,
                    LateDays = (DateTime.Now - borrows[0].EndDate).Days,
                    NumberOfBooks = borrows.Count
                };
                return info;
            }
        }

    }
}

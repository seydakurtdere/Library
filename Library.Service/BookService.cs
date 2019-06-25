using Library.Data;
using Library.Data.UnitOfWork;
using Library.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service
{
    public class BookService :BaseService, IService<BookDTO>
    {
        public BookDTO Get(int id)
        {
            try
            {
                using (UnitOfWork uow = new UnitOfWork())
                {
                    var entity = uow.Books.Get(id);

                    BookDTO bookDTO = Mapper.Map<Book, BookDTO>(entity);
                    bookDTO.GenreName = entity.Genre.GenreName;
                    bookDTO.RecordStatusName = entity.RecordStatus.RecordStatusName;

                    return bookDTO;
                }

            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public List<BookDTO> List()
        {
            try
            {
                using (UnitOfWork uow = new UnitOfWork())
                {
                    var entities = uow.Books.List();

                    List<BookDTO> list = new List<BookDTO>();

                    foreach (var item in entities)
                    {
                        BookDTO book = new BookDTO
                        {
                            BookId = item.BookId,
                            BookName = item.BookName,
                            UnitsInStock = item.UnitsInStock
                        };

                        list.Add(book);
                    }
                    return list;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public BookDTO Save(BookDTO obj)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                try
                {
                    obj.CreatedDate = DateTime.Now;
                    obj.RecordStatusId = Convert.ToByte(Enums.RecordStatus.Aktif);
                    var entity = Mapper.Map<BookDTO, Book>(obj);

                   var book = uow.Books.Save(entity);
                    uow.Commit();

                    return Mapper.Map<Book, BookDTO>(book);

                }
                catch (Exception ex)
                {

                    uow.RollBack();
                    return null;
                }
            }
        }
        
        public bool Update(BookDTO obj)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                try
                {
                    var entity = Mapper.Map<BookDTO, Book>(obj);

                    uow.Books.Update(entity);

                    return uow.Commit();
                }
                catch (Exception ex)
                {
                    uow.RollBack();
                    return false;
                }
            }
        }

        public List<BookDTO> ListByGenre(byte genreId)
        {
        
                using (UnitOfWork uow = new UnitOfWork())
                {
                try
                {
                    var entities = uow.Books.Search(x=>x.GenreId == genreId);

                    List<BookDTO> list = new List<BookDTO>();

                    foreach (var item in entities)
                    {
                        BookDTO book = new BookDTO
                        {
                            BookId = item.BookId,
                            BookName = item.BookName,
                            UnitsInStock = item.UnitsInStock
                        };

                        list.Add(book);
                    }
                    return list;

                }
                catch (Exception)
                {
                    return null;
                }
            }
            
           
        }

    }
}

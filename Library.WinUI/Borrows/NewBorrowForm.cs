using Library.DTO;
using Library.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.WinUI.Borrows
{
    public partial class NewBorrowForm : Form
    {
        public NewBorrowForm()
        {
            InitializeComponent();
        }

        private void NewBorrowForm_Load(object sender, EventArgs e)
        {
            using (StudentService studentService = new StudentService())
            {
                cbStudents.DataSource = studentService.List();
                cbStudents.DisplayMember = "FullName";
                cbStudents.ValueMember = "StudentId";
            }

            using (DefinitionService definitionService = new DefinitionService())
            {
                cbGenres.DataSource = definitionService.GetGenres();
                cbGenres.DisplayMember = "GenreName";
                cbGenres.ValueMember = "GenreId";

            }
        }

        private void cbGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (BookService bookService = new BookService())
            {
                byte genreId = (cbGenres.SelectedItem as GenreDTO).GenreId;

                var books = bookService.ListByGenre(genreId);

                lbBooks.DataSource = books;
                lbBooks.DisplayMember = "DisplayString";
                lbBooks.ValueMember = "GenreId";

            }
        }

        List<BorrowDTO> list = new List<BorrowDTO>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var selectedBook = lbBooks.SelectedItem as BookDTO;

            //if (list.Count > 0)
            //{
            //    foreach (var item in list)
            //    {
            //        if (item.BookId == selectedBook.BookId)
            //        {
            //            MessageBox.Show("Bu kitabı zaten seçtiniz!");
            //            return;
            //        }
            //    }
            //}

            if (list.Any(x => x.BookId == selectedBook.BookId))
            {
                MessageBox.Show("Bu kitabı zaten seçtiniz!");
                return;
            }

            BorrowDTO borrowDTO = new BorrowDTO
            {
                StudentId = Convert.ToInt32(cbStudents.SelectedValue),
                BookId = selectedBook.BookId,
                BookName = selectedBook.BookName
            };

            list.Add(borrowDTO);

            lbSelectedBooks.DataSource = null;
            lbSelectedBooks.DataSource = list;
            lbSelectedBooks.DisplayMember = "BookName";
            lbSelectedBooks.ValueMember = "BookId";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (list.Count == 0)
            {
                MessageBox.Show("Hiç kitap seçmediniz.");
                return;
            }
            using (BorrowService borrowService = new BorrowService())
            {
                var result = borrowService.Borrow(list);

                if (result)
                {
                    lblSaveStatus.Text = "Kayıt işlemi başarılı";
                    lblSaveStatus.ForeColor = Color.Green;
                }
                else
                {
                    lblSaveStatus.Text = "Kayıt işlemi başarısız";
                    lblSaveStatus.ForeColor = Color.Red;
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (list.Count == 0)
            {
                MessageBox.Show("Hiç kitap eklemediniz.");
                return;
            }

            var selectedBook = lbSelectedBooks.SelectedItem as BorrowDTO;

            list.Remove(selectedBook);

            lbSelectedBooks.DataSource = null;
            lbSelectedBooks.DataSource = list;
            lbSelectedBooks.DisplayMember = "BookName";
            lbSelectedBooks.ValueMember = "BookId";
        }
    }
}

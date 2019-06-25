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

namespace Library.WinUI.Books
{
    public partial class UpdateBookForm : Form
    {
        public UpdateBookForm()
        {
            InitializeComponent();
        }

        private void UpdateBookForm_Load(object sender, EventArgs e)
        {
            using (DefinitionService definitionService = new DefinitionService())
            {
                cmbRecordStatus.DataSource = definitionService.GetRecordStatuses();
                cmbRecordStatus.DisplayMember = "RecordStatusName";
                cmbRecordStatus.ValueMember = "RecordStatusId";

                cmbGenres.DataSource = definitionService.GetGenres();
                cmbGenres.DisplayMember = "GenreName";
                cmbGenres.ValueMember = "GenreId";
            }
            using (BookService bookService = new BookService())
            {
                lbBooks.DataSource = bookService.List();
                lbBooks.DisplayMember = "BookName";
                lbBooks.ValueMember = "BookId";
            }
        }

        private void lbBooks_DoubleClick(object sender, EventArgs e)
        {
            using (BookService bookService = new BookService())
            {
                int bookId = Convert.ToInt32(lbBooks.SelectedValue);

                var book = bookService.Get(bookId);

                txtBookName.Text = book.BookName;
                cmbGenres.SelectedValue = book.GenreId;
                txtAuthor.Text = book.Author;
                dtpPublishDate.Value = book.PublishDate;
                nmQuantity.Value = book.UnitsInStock;
                cmbRecordStatus.SelectedValue = book.RecordStatusId;
                lblCreatedDate.Text = book.CreatedDate.ToShortDateString();
               
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBookName.Text) ||
                string.IsNullOrEmpty(txtAuthor.Text) ||
                nmQuantity.Value < 1)
            {
                lblSaveStatus.Text = "Tüm alanları doldurmanız gerekiyor.";
                lblSaveStatus.ForeColor = Color.Red;
                return;
            }
            using (BookService bookService = new BookService())
            {
                BookDTO book = new BookDTO
                {
                    BookId = Convert.ToInt32(lbBooks.SelectedValue),
                    BookName = txtBookName.Text,
                    GenreId = Convert.ToByte(cmbGenres.SelectedValue),
                    Author = txtAuthor.Text,
                    PublishDate = dtpPublishDate.Value,
                    UnitsInStock = Convert.ToInt32(nmQuantity.Value),
                    CreatedDate = Convert.ToDateTime(lblCreatedDate.Text),
                    RecordStatusId = Convert.ToByte(cmbRecordStatus.SelectedValue)
                };
                var result = bookService.Update(book);

                if (result)
                {
                    lblSaveStatus.Text = "Kitap güncelleme başarılı";
                    lblSaveStatus.ForeColor = Color.Green;
                }
                else
                {
                    lblSaveStatus.Text = "Kitap güncellemesi sırasında hata oluştu";
                    lblSaveStatus.ForeColor = Color.Red;
                }
            }
        }
    }
}

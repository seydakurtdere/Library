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
    public partial class NewBookForm : Form
    {
        public NewBookForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBookName.Text) ||
                string.IsNullOrEmpty(txtAuthor.Text)||
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
                    BookName = txtBookName.Text,
                    GenreId = Convert.ToByte(cmbGenres.SelectedValue),
                    Author = txtAuthor.Text,
                    PublishDate = dtpPublishDate.Value,
                    UnitsInStock = Convert.ToInt32(nmQuantity.Value)
                };

                var result = bookService.Save(book);

                if (result != null)
                {
                    lblSaveStatus.Text = "Kitap kaydı başarılı";
                    lblSaveStatus.ForeColor = Color.Green;
                }
                else
                {
                    lblSaveStatus.Text = "Kitap kaydında hata oluştu";
                    lblSaveStatus.ForeColor = Color.Red;
                }
            }
        }

        private void NewBookForm_Load(object sender, EventArgs e)
        {
            using (DefinitionService definitionService = new DefinitionService())
            {
                cmbGenres.DataSource = definitionService.GetGenres();
                cmbGenres.DisplayMember = "GenreName";
                cmbGenres.ValueMember = "GenreId";
            }
        }
    }
}

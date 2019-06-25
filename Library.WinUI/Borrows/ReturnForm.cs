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
    public partial class ReturnForm : Form
    {
        public ReturnForm()
        {
            InitializeComponent();
        }

        private void ReturnForm_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void LoadBooks()
        {
            using (BorrowService borrowService = new BorrowService())
            {
                var result = borrowService.ListBorrows();

                lbBorrows.DataSource = result;
                lbBorrows.DisplayMember = "DisplayString";
                lbBorrows.ValueMember = "StudentId";
            }
        }

        private void lbBorrows_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (BorrowService borrowService = new BorrowService())
            {
                int studentId = (lbBorrows.SelectedItem as BorrowDTO).StudentId;
                var result = borrowService.ListBorrowedBooks(studentId);

                lbBorrowBooks.DataSource = result;
                lbBorrowBooks.DisplayMember = "BookName";
                lbBorrowBooks.ValueMember = "BookId";

                var borrowInfo = borrowService.GetBorrowDetails(studentId);

                lblEndDate.Text = borrowInfo.EndDate.ToShortDateString();
                lblLateDays.Text = borrowInfo.LateDays + " Gün";
                lblPenalty.Text = borrowInfo.TotalAmount.ToString("C2");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbBorrows.SelectedItem == null)
            {
                MessageBox.Show("Kayıt seçmediniz");
                return;
            }
            
            int studentId = (lbBorrows.SelectedItem as BorrowDTO).StudentId;

            using (BorrowService borrowService = new BorrowService())
            {
                var result = borrowService.Return(studentId);

                if (result)
                {
                    LoadBooks();
                    MessageBox.Show("İade işlemleri tamamlandı");

                }
                else
                {
                    MessageBox.Show("İade işlemleri başarısız");
                }
            }
        }
    }
}

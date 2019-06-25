using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void yeniÖğrenciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Students.NewStudentForm newStudentForm = new Students.NewStudentForm();
            newStudentForm.MdiParent = this;
            newStudentForm.WindowState = FormWindowState.Maximized;
            newStudentForm.Show();
            
        }

        private void düzenlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Students.UpdateStudentForm updateStudentForm = new Students.UpdateStudentForm();
            updateStudentForm.MdiParent = this;
            updateStudentForm.WindowState = FormWindowState.Maximized;
            updateStudentForm.Show();
        }

        private void yeniKitapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books.NewBookForm newBookForm = new Books.NewBookForm();
            newBookForm.MdiParent = this;
            newBookForm.WindowState = FormWindowState.Maximized;
            newBookForm.Show();
        }

        private void düzenlemeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Books.UpdateBookForm updateBookForm = new Books.UpdateBookForm();
            updateBookForm.MdiParent = this;
            updateBookForm.WindowState = FormWindowState.Maximized;
            updateBookForm.Show();
        }

        private void yeniİşlemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrows.NewBorrowForm newBorrowForm = new Borrows.NewBorrowForm();
            newBorrowForm.MdiParent = this;
            newBorrowForm.WindowState = FormWindowState.Maximized;
            newBorrowForm.Show();
        }

        private void verilenKitaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrows.ReturnForm returnBorrowForm = new Borrows.ReturnForm();
            returnBorrowForm.MdiParent = this;
            returnBorrowForm.WindowState = FormWindowState.Maximized;
            returnBorrowForm.Show();
        }
    }
}

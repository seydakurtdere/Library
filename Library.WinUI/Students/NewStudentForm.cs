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

namespace Library.WinUI.Students
{
    public partial class NewStudentForm : Form
    {
        public NewStudentForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (StudentService studentService = new StudentService())
            {
                if (string.IsNullOrEmpty(txtFirstName.Text) ||
                    string.IsNullOrEmpty(txtLastName.Text) ||
                    string.IsNullOrEmpty(txtStudentNumber.Text) ||
                    string.IsNullOrEmpty(txtMobilePhone.Text) ||
                    string.IsNullOrEmpty(txtEmail.Text))
                {
                    lblSaveStatus.Text = "Tüm alanları doldurmanız gerekiyor.";
                    lblSaveStatus.ForeColor = Color.Red;
                    return;
                }
                StudentDTO student = new StudentDTO
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    StudentNumber = txtStudentNumber.Text,
                    MobilePhone = txtMobilePhone.Text,
                    EmailAddress = txtEmail.Text
                };
                var result = studentService.Save(student);

                if (result!= null)
                {
                    lblSaveStatus.Text = "Öğrenci kaydı başarılı";
                    lblSaveStatus.ForeColor = Color.Green;
                }
                else
                {
                    lblSaveStatus.Text = "Öğrenci kaydında hata oluştu!";
                    lblSaveStatus.ForeColor = Color.Red;
                }
            }
        }
    }
}

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
    public partial class UpdateStudentForm : Form
    {
        public UpdateStudentForm()
        {
            InitializeComponent();
        }

        private void UpdateStudentForm_Load(object sender, EventArgs e)
        {
            using (StudentService studentService = new StudentService())
            {
                var students = studentService.List();

                lbStudents.DataSource = students;
                lbStudents.DisplayMember = "FullName";
                lbStudents.ValueMember = "StudentId";
            }
            using (DefinitionService definitionService = new DefinitionService())
            {
                cbRecordStatus.DataSource = definitionService.GetRecordStatuses();
                cbRecordStatus.DisplayMember = "RecordStatusName";
                cbRecordStatus.ValueMember = "RecordStatusId";
            }
        }

        private void lbStudents_DoubleClick(object sender, EventArgs e)
        {
            using (StudentService studentService = new StudentService())
            {
                int studentId = Convert.ToInt32(lbStudents.SelectedValue);

                var student = studentService.Get(studentId);
                txtFirstName.Text = student.FirstName;
                txtLastName.Text = student.LastName;
                txtStudentNumber.Text = student.StudentNumber;
                txtMobilePhone.Text = student.MobilePhone;
                txtEmail.Text = student.EmailAddress;
                cbRecordStatus.SelectedValue = student.RecordStatusId;
                lblCreatedDate.Text = student.CreatedDate.ToString("dd/MM/yyyy");
             }
        }
         
        private void btnUpdate_Click(object sender, EventArgs e)
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
                    StudentId = Convert.ToInt32(lbStudents.SelectedValue),
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    StudentNumber = txtStudentNumber.Text,
                    MobilePhone = txtMobilePhone.Text,
                    EmailAddress = txtEmail.Text,
                    RecordStatusId = Convert.ToByte(cbRecordStatus.SelectedValue),
                    CreatedDate = Convert.ToDateTime(lblCreatedDate.Text)
                };

                var result = studentService.Update(student);

                if (result)
                {
                    lblSaveStatus.Text = "Öğrenci güncelleme başarılı";
                    lblSaveStatus.ForeColor = Color.Green;
                }
                else
                {
                    lblSaveStatus.Text = "Öğrenci güncellemesi sırasında hata oluştu";
                    lblSaveStatus.ForeColor = Color.Red;
                }
            }
        }
    }
}

using Salary34000.Forms;
using Salary34000.Models;

namespace Salary34000
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmPerson frm = new frmPerson();
            frm.Person = new Person
            {
                PersonelCode = "48",
                FirstName = "حامد",
                LastName = "وطنی",
                NationalCode = "0072779241",
                DocumentNumber = "118",
                DocumentSerial = "-",
            };
            frm.ShowDialog();
            Close();
        }
    }
}
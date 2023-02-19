using System.Globalization;
using Microsoft.Extensions.DependencyInjection;
using Salary34000.Data;
using Salary34000.Forms;
using Salary34000.Models;

namespace Salary34000
{
    public partial class Form1 : Form
    {
        private readonly SalaryContext _context;

        public Form1(SalaryContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var p = _context.Persons.FirstOrDefault(p => p.PersonelCode == "48");
            if (p == null)
            {
                p = new Person
                {
                    PersonelCode = "48",
                    FirstName = "حامد",
                    LastName = "وطنی",
                    NationalCode = "0072779241",
                    DocumentNumber = "118",
                    DocumentSerial = "-",
                    Gender = GenderEnum.Male,
                    ChildrenCount = 1,
                    DocumentDate = DateTime.Today,
                    DocumentCity = "تهران",
                    BirthDate = new DateTime(1977, 3, 22),
                    BirthCity = "تهران",
                    EmploymentDate = new PersianCalendar().ToDateTime(1382, 1, 1, 0, 0, 0, 0),
                    EmploymentTypeId = 3,
                    OrganizationUnitId = 9,
                    OrganizationPost = "سرپرست توسعه فنی",
                    ConsolidatedInsurance = 16.25,
                    EducationId = 5,
                    EducationField = "مهندسی کامپیوتر - معماری کامپیوتر",
                    EducationPlace = "دانشگاه تهران"
                };
                _context.Persons.Add(p);
                _context.SaveChanges();
            }
            var frm = Program.ServiceProvider.GetRequiredService<frmPerson>();
            frm.PersonId = p.Id;
            frm.ShowDialog();
            Close();
        }
    }
}
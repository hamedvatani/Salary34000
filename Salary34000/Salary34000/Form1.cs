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
                    EducationPlace = "دانشگاه تهران",
                    MilitaryServiceId = 5,
                    MaritalStatus = MaritalStatusEnum.Married,
                    MarriageDate = new PersianCalendar().ToDateTime(1382, 1, 21, 0, 0, 0, 0),
                    OldBaseSummery = 226735691,
                    OldHokmSummery = 255399341,
                    JobScore = 5347,
                    JobGroupId = 21,
                    OccupationId = 1,
                    EducationRelationStatusId = 1,
                    ProfessionalPathId = 2,
                    PerformanceId = 3,
                    SpecialActivities = 0,
                    DevelopmentPlan = 2,
                    RoleExtra = RoleExtraEnum.Negative,
                    BaseInsurance = "سازمان تامین اجتماعی",
                    InsuranceNumber = "12158457",
                    BankName = "ملی",
                    AccountNumber = "0100293068008",
                    Mobile = "09123118043",
                    Address = " تهران،  پونک، سردار جنگل، خ بهار شرقی، خ فجر، ک فجر 2، پلاک 21، واحد 1",
                    ManualJobIncreasePercent = 7.1428571,
                    ManualManagementExtraPercent = -5.5
                };
                _context.Persons.Add(p);
                _context.SaveChanges();
            }
            var frm = Program.ServiceProvider.GetRequiredService<PersonForm>();
            frm.PersonId = p.Id;
            frm.ShowDialog();
            Close();
        }
    }
}
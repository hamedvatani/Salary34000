using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Salary34000.Data;
using Salary34000.Models;
using Salary34000.Utils;
using Telerik.WinControls.UI;

namespace Salary34000.Forms
{
    public partial class PersonForm : Form
    {
        public int PersonId { get; set; }
        private Person? _person;
        private BindingSource _bsPerson = null!;
        private readonly SalaryContext _context;

        public PersonForm(SalaryContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void PersonForm_Load(object sender, EventArgs e)
        {
            FillCombos();
            _person = _context.Persons.FirstOrDefault(p => p.Id == PersonId);
            if (_person == null)
            {
                MessageBox.Show("فرد مورد نظر پیدا نشد", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            _person.SetContext(_context);
            _bsPerson = new BindingSource(_person, "");
            BindControls();
        }

        private void BindControls()
        {
            BindTextbox(txtPersonelCode);
            BindTextbox(txtFirstName);
            BindTextbox(txtLastName);
            BindTextbox(txtNationalCode);
            BindTextbox(txtDocumentNumber);
            BindTextbox(txtDocumentSerial);
            BindCombobox(cmbGender);
            BindTextbox(txtChildrenCount);
            BindDateTimePicker(dtpDocumentDate);
            BindTextbox(txtDocumentCity);
            BindDateTimePicker(dtpBirthDate);
            BindTextbox(txtBirthCity);
            BindTextbox(txtBirthYear);
            BindTextbox(txtAge);
            BindDateTimePicker(dtpEmploymentDate);
            BindCombobox(cmbEmploymentType, "Id");
            BindCombobox(cmbOrganizationUnit, "Id");
            BindTextbox(txtOrganizationPost);
            BindTextbox(txtConsolidatedInsurance);
            BindCombobox(cmbEducation, "Id");
            BindTextbox(txtEducationField);
            BindTextbox(txtEducationPlace);
            BindTextbox(txtEducationAverage);
            BindCombobox(cmbMilitaryService, "Id");
            BindCombobox(cmbMaritalStatus);
            BindDateTimePicker(dtpMarriageDate);
            BindTextbox(txtSuperCollectable);
            BindDateTimePicker(dtpEmploymentEndDate);
            BindTextbox(txtOldBaseSummery);
            BindTextbox(txtOldHokmSummery);
            BindTextbox(txtJobScore);
            BindCombobox(cmbJobGroup, "Id");
            BindCombobox(cmbOccupation, "Id");
            BindCombobox(cmbEducationRelationStatus, "Id");
            BindCombobox(cmbProfessionalPath, "Id");
            BindTextbox(txtEducationScore);
        }

        private void BindTextbox(TextBox textBox)
        {
            textBox.DataBindings.Add("Text", _bsPerson, textBox.Name.Substring(3));
        }

        private void BindCombobox(ComboBox comboBox, string postFix = "")
        {
            comboBox.DataBindings.Add("SelectedValue", _bsPerson, comboBox.Name.Substring(3) + postFix);
        }

        private void BindDateTimePicker(RadDateTimePicker radDateTimePicker)
        {
            radDateTimePicker.DataBindings.Add("Value", _bsPerson, radDateTimePicker.Name.Substring(3));
        }

        private void FillCombos()
        {
            cmbGender.DataSource = typeof(GenderEnum).GetComboItems();
            cmbGender.DisplayMember = "EnumDescription";
            cmbGender.ValueMember = "EnumValue";

            cmbEmploymentType.DataSource = _context.EmploymentTypes.ToArray();
            cmbEmploymentType.DisplayMember = "Description";
            cmbEmploymentType.ValueMember = "Id";

            cmbOrganizationUnit.DataSource = _context.OrganizationUnits.ToArray();
            cmbOrganizationUnit.DisplayMember = "Description";
            cmbOrganizationUnit.ValueMember = "Id";

            cmbEducation.DataSource = _context.Educations.ToArray();
            cmbEducation.DisplayMember = "Description";
            cmbEducation.ValueMember = "Id";

            cmbMilitaryService.DataSource = _context.MilitaryServices.ToArray();
            cmbMilitaryService.DisplayMember = "Description";
            cmbMilitaryService.ValueMember = "Id";

            cmbMaritalStatus.DataSource = typeof(MaritalStatusEnum).GetComboItems();
            cmbMaritalStatus.DisplayMember = "EnumDescription";
            cmbMaritalStatus.ValueMember = "EnumValue";

            cmbJobGroup.DataSource = _context.JobGroups.ToArray();
            cmbJobGroup.DisplayMember = "Description";
            cmbJobGroup.ValueMember = "Id";

            cmbOccupation.DataSource = _context.Occupations.ToArray();
            cmbOccupation.DisplayMember = "Description";
            cmbOccupation.ValueMember = "Id";

            cmbEducationRelationStatus.DataSource = _context.EducationRelationStatuses.ToArray();
            cmbEducationRelationStatus.DisplayMember = "Description";
            cmbEducationRelationStatus.ValueMember = "Id";

            cmbProfessionalPath.DataSource = _context.ProfessionalPaths.ToArray();
            cmbProfessionalPath.DisplayMember = "Description";
            cmbProfessionalPath.ValueMember = "Id";
        }
    }
}

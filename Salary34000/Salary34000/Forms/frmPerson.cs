using System;
using System.Collections;
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
    public partial class frmPerson : Form
    {
        public int PersonId { get; set; }
        private Person? _person;
        private BindingSource _bsPerson;
        private readonly SalaryContext _context;

        public frmPerson(SalaryContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void frmPerson_Load(object sender, EventArgs e)
        {
            FillCombos();
            _person = _context.Persons.FirstOrDefault(p => p.Id == PersonId);
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
        }

        private void LoadForm()
        {
            // if (_person == null)
            //     return;
            // txtPersonelCode.Text = _person.PersonelCode;
            // txtFirstName.Text = _person.FirstName;
            // txtLastName.Text = _person.LastName;
            // txtNationalCode.Text = _person.NationalCode;
            // txtDocumentNumber.Text = _person.DocumentNumber;
            // txtDocumentSerial.Text = _person.DocumentSerial;
            // cmbGender.SelectedValue = _person.Gender;
            // txtChildrenCount.Text = _person.ChildrenCount.ToString();
            // dtpDocumentDate.Value = _person.DocumentDate;
            // txtDocumentCity.Text = _person.DocumentCity;
            // dtpBirthDate.Value = _person.BirthDate;
            // txtBirthCity.Text = _person.BirthCity;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _person.FirstName = "احمد";
        }
    }
}

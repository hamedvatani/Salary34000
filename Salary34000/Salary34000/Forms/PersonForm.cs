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
using Telerik.Windows.Diagrams.Core;

namespace Salary34000.Forms;

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
        if (_person == null)
            return;

        var controls = this.GetAllControls();
        controls.Where(c => c is TextBox &&
                            c.Name.StartsWith("txt") &&
                            typeof(Person).GetProperty(c.Name[3..]) != null)
            .Cast<TextBox>()
            .ForEach(BindTextBox);
        controls.Where(c => c is RadDateTimePicker &&
                            c.Name.StartsWith("dtp") &&
                            typeof(Person).GetProperty(c.Name[3..]) != null)
            .Cast<RadDateTimePicker>()
            .ForEach(BindDateTimePicker);
        controls.Where(c => c is ComboBox &&
                            c.Name.StartsWith("cmb") &&
                            typeof(Person).GetProperty(c.Name[3..]) != null &&
                            typeof(Person).GetProperty(c.Name[3..])!.PropertyType.IsEnum)
            .Cast<ComboBox>()
            .ForEach(c => BindComboBox(c));
        controls.Where(c => c is ComboBox &&
                            c.Name.StartsWith("cmb") &&
                            typeof(Person).GetProperty(c.Name[3..]) != null &&
                            !typeof(Person).GetProperty(c.Name[3..])!.PropertyType.IsEnum)
            .Cast<ComboBox>()
            .ForEach(c => BindComboBox(c, "Id"));
        controls.Where(c => c is TextBox &&
                            typeof(Person).GetProperty(c.Name[3..]) != null &&
                            !typeof(Person).GetProperty(c.Name[3..])!.CanWrite)
            .Cast<TextBox>()
            .ForEach(c => c.ReadOnly = true);
        controls.Where(c => !(c is TextBox) &&
                            typeof(Person).GetProperty(c.Name[3..]) != null &&
                            !typeof(Person).GetProperty(c.Name[3..])!.CanWrite)
            .ForEach(c => c.Enabled = false);
    }

    private void BindTextBox(TextBox textBox)
    {
        textBox.DataBindings.Add("Text", _bsPerson, textBox.Name.Substring(3));
    }

    private void BindComboBox(ComboBox comboBox, string postFix = "")
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

        cmbPerformance.DataSource = _context.Performances.ToArray();
        cmbPerformance.DisplayMember = "Description";
        cmbPerformance.ValueMember = "Id";

        cmbRoleExtra.DataSource = typeof(RoleExtraEnum).GetComboItems();
        cmbRoleExtra.DisplayMember = "EnumDescription";
        cmbRoleExtra.ValueMember = "EnumValue";
    }
}
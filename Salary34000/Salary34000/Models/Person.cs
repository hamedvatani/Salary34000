using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Runtime.CompilerServices;
using Salary34000.Annotations;

namespace Salary34000.Models;

public class Person : BaseModel, INotifyPropertyChanged
{
    #region INotifyPropertyChanged Members

    public event PropertyChangedEventHandler? PropertyChanged;

    [NotifyPropertyChangedInvocator]
    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion

    #region Formula Properties

    [NotMapped] public int BirthYear => new PersianCalendar().GetYear(BirthDate);

    [NotMapped]
    public int Age => new PersianCalendar().GetYear(DateTime.Today) - new PersianCalendar().GetYear(BirthDate);

    #endregion

    #region Private Members

    private DateTime _birthDate;

    #endregion

    #region Public Members

    public string PersonelCode { get; set; } = "";
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string NationalCode { get; set; } = "";
    public string DocumentNumber { get; set; } = "";
    public string DocumentSerial { get; set; } = "";
    public GenderEnum Gender { get; set; }
    public int ChildrenCount { get; set; }
    public DateTime DocumentDate { get; set; }
    public string DocumentCity { get; set; } = "";

    public DateTime BirthDate
    {
        get => _birthDate;
        set
        {
            _birthDate = value;
            OnPropertyChanged();
        }
    }

    public string BirthCity { get; set; } = "";
    public DateTime EmploymentDate { get; set; }
    [ForeignKey(nameof(EmploymentType))] public int EmploymentTypeId { get; set; }
    [ForeignKey(nameof(OrganizationUnit))] public int OrganizationUnitId { get; set; }
    public string OrganizationPost { get; set; } = "";
    public double ConsolidatedInsurance { get; set; }
    [ForeignKey(nameof(Education))] public int EducationId { get; set; }
    public string EducationField { get; set; } = "";
    public string EducationPlace { get; set; } = "";
    public double EducationAverage { get; set; }

    #endregion

    #region Virtual Members

    public virtual EmploymentType EmploymentType { get; set; } = null!;
    public virtual OrganizationUnit OrganizationUnit { get; set; } = null!;
    public virtual Education Education { get; set; } = null!;

    #endregion
}
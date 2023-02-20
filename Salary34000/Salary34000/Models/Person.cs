using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Runtime.CompilerServices;
using Salary34000.Annotations;
using Salary34000.Data;

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

    [NotMapped] public int EducationScore => GetEducationScore();

    #endregion

    #region Private Members

    private SalaryContext? _context;
    private DateTime _birthDate;
    private int _educationId;
    
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

    [ForeignKey(nameof(Education))]
    public int EducationId
    {
        get => _educationId;
        set
        {
            _educationId = value;
            OnPropertyChanged();
        }
    }

    public string EducationField { get; set; } = "";
    public string EducationPlace { get; set; } = "";
    public double EducationAverage { get; set; }
    [ForeignKey(nameof(MilitaryService))] public int MilitaryServiceId { get; set; }
    public MaritalStatusEnum MaritalStatus { get; set; }
    public DateTime MarriageDate { get; set; }
    public long SuperCollectable { get; set; }
    public DateTime EmploymentEndDate { get; set; }
    public long OldBaseSummery { get; set; }
    public long OldHokmSummery { get; set; }
    public int JobScore { get; set; }
    [ForeignKey(nameof(JobGroup))] public int JobGroupId { get; set; }
    [ForeignKey(nameof(Occupation))] public int OccupationId { get; set; }

    [ForeignKey(nameof(EducationRelationStatus))]
    public int EducationRelationStatusId { get; set; }

    [ForeignKey(nameof(ProfessionalPath))] public int ProfessionalPathId { get; set; }

    #endregion

    #region Virtual Members

    public virtual EmploymentType EmploymentType { get; set; } = null!;
    public virtual OrganizationUnit OrganizationUnit { get; set; } = null!;
    public virtual Education Education { get; set; } = null!;
    public virtual MilitaryService MilitaryService { get; set; } = null!;
    public virtual JobGroup JobGroup { get; set; } = null!;
    public virtual Occupation Occupation { get; set; } = null!;
    public virtual EducationRelationStatus EducationRelationStatus { get; set; } = null!;
    public virtual ProfessionalPath ProfessionalPath { get; set; } = null!;

    #endregion

    public void SetContext(SalaryContext context)
    {
        _context = context;
    }

    private int GetEducationScore()
    {
        if (_context == null)
            return Education.Score;
        return _context.Educations.FirstOrDefault(e => e.Id == _educationId)?.Score ?? Education.Score;
    }
}
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
    [NotMapped] public double EducationRelationStatusCoefficient => GetEducationRelationStatusCoefficient();
    [NotMapped] public double EducationTotalScore => EducationScore * EducationRelationStatusCoefficient;
    [NotMapped] public double ExperimentScore => GetExperimentScore();
    [NotMapped] public int PerformanceScore => GetPerformanceScore();

    [NotMapped]
    public double PersonalGroupScore => EducationTotalScore +
                                        ExperimentScore +
                                        PerformanceScore +
                                        _specialActivities +
                                        _developmentPlan;

    [NotMapped] public string PersonalGroupName => GetPersonalGroupName();
    [NotMapped] public long JobWage1 => GetJobWage1();

    #endregion

    #region Private Members

    private SalaryContext? _context;
    private DateTime _birthDate;
    private int _educationId;
    private int _educationRelationStatusId;
    private double _consolidatedInsurance;
    private int _professionalPathId;
    private int _performanceId;
    private int _specialActivities;
    private int _developmentPlan;
    private int _jobGroupId;

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

    public double ConsolidatedInsurance
    {
        get => _consolidatedInsurance;
        set
        {
            _consolidatedInsurance = value;
            OnPropertyChanged();
        }
    }

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

    [ForeignKey(nameof(JobGroup))]
    public int JobGroupId
    {
        get => _jobGroupId;
        set
        {
            _jobGroupId = value;
            OnPropertyChanged();
        }
    }

    [ForeignKey(nameof(Occupation))] public int OccupationId { get; set; }

    [ForeignKey(nameof(EducationRelationStatus))]
    public int EducationRelationStatusId
    {
        get => _educationRelationStatusId;
        set
        {
            _educationRelationStatusId = value;
            OnPropertyChanged();
        }
    }

    [ForeignKey(nameof(ProfessionalPath))]
    public int ProfessionalPathId
    {
        get => _professionalPathId;
        set
        {
            _professionalPathId = value;
            OnPropertyChanged();
        }
    }

    [ForeignKey(nameof(Performance))]
    public int PerformanceId
    {
        get => _performanceId;
        set
        {
            _performanceId = value;
            OnPropertyChanged();
        }
    }

    public int SpecialActivities
    {
        get => _specialActivities;
        set
        {
            _specialActivities = value;
            OnPropertyChanged();
        }
    }

    public int DevelopmentPlan
    {
        get => _developmentPlan;
        set
        {
            _developmentPlan = value;
            OnPropertyChanged();
        }
    }

    public RoleExtraEnum RoleExtra { get; set; }
    public string BaseInsurance { get; set; } = "";
    public string InsuranceNumber { get; set; } = "";
    public string BankName { get; set; } = "";
    public string AccountNumber { get; set; } = "";
    public string Mobile { get; set; } = "";
    public string Address { get; set; } = "";

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
    public virtual Performance Performance { get; set; } = null!;

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

    private double GetEducationRelationStatusCoefficient()
    {
        if (_context == null)
            return EducationRelationStatus.Coefficient;
        return _context.EducationRelationStatuses.FirstOrDefault(e => e.Id == _educationRelationStatusId)
            ?.Coefficient ?? EducationRelationStatus.Coefficient;
        ;
    }

    private double GetExperimentScore()
    {
        if (_context == null)
            return 0;

        return _context.ExperienceScores
            .Where(e => e.ProfessionalPathId == _professionalPathId && e.WorkExperience <= _consolidatedInsurance)
            .OrderByDescending(e => e.WorkExperience)
            .FirstOrDefault()?.Score ?? 0;
    }

    private int GetPerformanceScore()
    {
        if (_context == null)
            return Performance.Score;
        return _context.Performances.FirstOrDefault(e => e.Id == _performanceId)
            ?.Score ?? Performance.Score;
    }

    private string GetPersonalGroupName()
    {
        if (_context == null)
            return "0";

        return _context.PersonalGroups
            .Where(p => p.ProfessionalPathId == _professionalPathId && p.Grade <= PersonalGroupScore)
            .OrderByDescending(e => e.Grade)
            .FirstOrDefault()?.Score ?? "";
    }

    private long GetJobWage1()
    {
        if (_context == null)
            return 0;

        var coefficient = _context.JobGroups
            .Where(j => j.Id <= _jobGroupId)
            .Select(x => x.ProportionIncrease - 1)
            .Sum() + 1;
        var baseSalary = _context.Parameters.FirstOrDefault(p => p.Key == "BaseSalary")?.Value ?? 0;
        return (long)(coefficient * baseSalary);
    }
}
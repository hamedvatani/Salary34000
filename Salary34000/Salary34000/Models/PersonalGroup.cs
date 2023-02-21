using System.ComponentModel.DataAnnotations.Schema;

namespace Salary34000.Models;

public class PersonalGroup : BaseModel, IHasInitialData
{
    private static readonly int[] Grades =
    {
        30,
        35,
        40,
        45,
        50,
        55,
        60,
        65,
        70,
        75,
        80,
        85,
        90,
        95,
        100
    };

    private static readonly string[] Scores1 = // مدیریتی
    {
        "A",
        "A+",
        "A++",
        "B",
        "B+",
        "B++",
        "C",
        "C+",
        "C++",
        "D",
        "D+",
        "D++",
        "E",
        "E+",
        "E++"
    };

    private static readonly string[] Scores2 = // کارشناسی
    {
        "16",
        "16+",
        "16++",
        "17",
        "17+",
        "17++",
        "18",
        "18+",
        "18++",
        "19",
        "19+",
        "19++",
        "20",
        "20+",
        "20++"
    };

    private static readonly string[] Scores3 = // کاردانی
    {
        "11",
        "11+",
        "11++",
        "12",
        "12+",
        "12++",
        "13",
        "13+",
        "13++",
        "14",
        "14+",
        "14++",
        "15",
        "15+",
        "15++"
    };

    private static readonly string[] Scores4 = // کارمندی
    {
        "6",
        "6+",
        "6++",
        "7",
        "7+",
        "7++",
        "8",
        "8+",
        "8++",
        "9",
        "9+",
        "9++",
        "10",
        "10+",
        "10++"
    };

    private static readonly string[] Scores5 = // کارگری
    {
        "1",
        "1+",
        "1++",
        "2",
        "2+",
        "2++",
        "3",
        "3+",
        "3++",
        "4",
        "4+",
        "4++",
        "5",
        "5+",
        "5++"
    };

    private static readonly string[][] Scores =
    {
        Scores1,
        Scores2,
        Scores3,
        Scores4,
        Scores5
    };

    public int Grade { get; set; }
    [ForeignKey(nameof(ProfessionalPath))] public int ProfessionalPathId { get; set; }
    public string Score { get; set; } = "";

    public virtual ProfessionalPath ProfessionalPath { get; set; } = null!;

    public Array GetInitialData()
    {
        return GetData();
    }

    private static PersonalGroup[] GetData()
    {
        var retVal = new PersonalGroup[Grades.Length * 5];
        for (var i = 0; i < 5; i++)
        {
            for (var j = 0; j < Grades.Length; j++)
            {
                retVal[i * Grades.Length + j] = new PersonalGroup
                {
                    Id = i * Grades.Length + j + 1,
                    Grade = Grades[j],
                    ProfessionalPathId = i + 1,
                    Score = Scores[i][j]
                };
            }
        }

        return retVal;
    }
}
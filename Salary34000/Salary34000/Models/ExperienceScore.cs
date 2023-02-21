using System.ComponentModel.DataAnnotations.Schema;

namespace Salary34000.Models;

public class ExperienceScore : BaseModel, IHasInitialData
{
    private static readonly int[] WorkExperiences =
    {
        0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30
    };

    private static readonly double[] Scores1 = // مدیریتی
    {
        25,
        25,
        25.17241379,
        25.34482759,
        25.51724138,
        25.68965517,
        25.86206897,
        26.03448276,
        26.20689655,
        26.37931034,
        26.55172414,
        26.72413793,
        26.89655172,
        27.06896552,
        27.24137931,
        27.4137931,
        27.5862069,
        27.75862069,
        27.93103448,
        28.10344828,
        28.27586207,
        28.44827586,
        28.62068966,
        28.79310345,
        28.96551724,
        29.13793103,
        29.31034483,
        29.48275862,
        29.65517241,
        29.82758621,
        30
    };

    private static readonly double[] Scores2 = // کارشناسی
    {
        20,
        20,
        20.17241379,
        20.34482759,
        20.51724138,
        20.68965517,
        20.86206897,
        21.03448276,
        21.20689655,
        21.37931034,
        21.55172414,
        21.72413793,
        21.89655172,
        22.06896552,
        22.24137931,
        22.4137931,
        22.5862069,
        22.75862069,
        22.93103448,
        23.10344828,
        23.27586207,
        23.44827586,
        23.62068966,
        23.79310345,
        23.96551724,
        24.13793103,
        24.31034483,
        24.48275862,
        24.65517241,
        24.82758621,
        25
    };

    private static readonly double[] Scores3 = // کاردانی
    {
        15,
        15,
        15.17241379,
        15.34482759,
        15.51724138,
        15.68965517,
        15.86206897,
        16.03448276,
        16.20689655,
        16.37931034,
        16.55172414,
        16.72413793,
        16.89655172,
        17.06896552,
        17.24137931,
        17.4137931,
        17.5862069,
        17.75862069,
        17.93103448,
        18.10344828,
        18.27586207,
        18.44827586,
        18.62068966,
        18.79310345,
        18.96551724,
        19.13793103,
        19.31034483,
        19.48275862,
        19.65517241,
        19.82758621,
        20
    };

    private static readonly double[] Scores4 = // کارمندی
    {
        10,
        10,
        10.17241379,
        10.34482759,
        10.51724138,
        10.68965517,
        10.86206897,
        11.03448276,
        11.20689655,
        11.37931034,
        11.55172414,
        11.72413793,
        11.89655172,
        12.06896552,
        12.24137931,
        12.4137931,
        12.5862069,
        12.75862069,
        12.93103448,
        13.10344828,
        13.27586207,
        13.44827586,
        13.62068966,
        13.79310345,
        13.96551724,
        14.13793103,
        14.31034483,
        14.48275862,
        14.65517241,
        14.82758621,
        15
    };

    private static readonly double[] Scores5 = // کارگری
    {
        5,
        5,
        5.172413793,
        5.344827586,
        5.517241379,
        5.689655172,
        5.862068966,
        6.034482759,
        6.206896552,
        6.379310345,
        6.551724138,
        6.724137931,
        6.896551724,
        7.068965517,
        7.24137931,
        7.413793103,
        7.586206897,
        7.75862069,
        7.931034483,
        8.103448276,
        8.275862069,
        8.448275862,
        8.620689655,
        8.793103448,
        8.965517241,
        9.137931034,
        9.310344828,
        9.482758621,
        9.655172414,
        9.827586207,
        10
    };

    private static readonly double[][] Scores =
    {
        Scores1,
        Scores2,
        Scores3,
        Scores4,
        Scores5
    };

    public int WorkExperience { get; set; }
    [ForeignKey(nameof(ProfessionalPath))] public int ProfessionalPathId { get; set; }
    public double Score { get; set; }

    public virtual ProfessionalPath ProfessionalPath { get; set; } = null!;

    public Array GetInitialData()
    {
        return GetData();
    }

    private static ExperienceScore[] GetData()
    {
        var retVal = new ExperienceScore[WorkExperiences.Length * 5];
        for (var i = 0; i < 5; i++)
        {
            for (var j = 0; j < WorkExperiences.Length; j++)
            {
                retVal[i * WorkExperiences.Length + j] = new ExperienceScore
                {
                    Id = i * WorkExperiences.Length + j + 1,
                    WorkExperience = WorkExperiences[j],
                    ProfessionalPathId = i + 1,
                    Score = Scores[i][j]
                };
            }
        }

        return retVal;
    }
}
namespace Salary34000.Models;

public class EducationRelationStatus : IdDescriptionModel, IHasInitialData
{
    private static readonly string[] Descriptions =
    {
        "مرتبط",
        "نیمه مرتبط",
        "غیر مرتبط"
    };

    private static readonly double[] Coefficients =
    {
        1,
        0.85,
        0.7
    };

    public double Coefficient { get; set; }

    public Array GetInitialData()
    {
        return GetData();
    }

    private static EducationRelationStatus[] GetData()
    {
        var retVal = new EducationRelationStatus[Descriptions.Length];
        for (var i = 0; i < retVal.Length; i++)
        {
            retVal[i] = new EducationRelationStatus
            {
                Id = i + 1,
                Description = Descriptions[i],
                Coefficient = Coefficients[i]
            };
        }

        return retVal;
    }
}
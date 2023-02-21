namespace Salary34000.Models;

public class Occupation : IdDescriptionModel, IHasInitialData
{
    private static readonly string[] Descriptions =
    {
        "صف تخصصی - فنی",
        "صف تخصصی - فنی 1",
        "صف تخصصی - فنی 2",
        "صف تخصصی - فنی 3",
        "صف تخصصی - پشتیبانی",
        "صف تخصصی - پشتیبانی 1",
        "صف تخصصی - پشتیبانی 2",
        "صف تخصصی - پشتیبانی 3",
        "ستاد تخصصی",
        "ستاد پشتیبانی",
        "ستاد خدماتی"
    };

    private static readonly double[] Coefficients =
    {
        2.8,
        2,
        1.5,
        1.2,
        2.5,
        1.7,
        1.25,
        1.2,
        1.1,
        1.05,
        1
    };

    public double Coefficient { get; set; }

    public Array GetInitialData()
    {
        return GetData();
    }

    private static Occupation[] GetData()
    {
        var retVal = new Occupation[Descriptions.Length];
        for (var i = 0; i < retVal.Length; i++)
        {
            retVal[i] = new Occupation
            {
                Id = i + 1,
                Description = Descriptions[i],
                Coefficient = Coefficients[i]
            };
        }

        return retVal;
    }
}
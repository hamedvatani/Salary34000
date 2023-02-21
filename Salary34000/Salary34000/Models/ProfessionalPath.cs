namespace Salary34000.Models;

public class ProfessionalPath : IdDescriptionModel, IHasInitialData
{
    private static readonly string[] Descriptions =
    {
        "مدیریتی",
        "کارشناسی",
        "کاردانی",
        "کارمندی",
        "کارگری"
    };

    private static readonly long[] Amounts =
    {
        33218504,
        16609252,
        11072835,
        8304626,
        6643701
    };

    private static readonly double[] Coefficients =
    {
        1,
        0.5,
        0.33,
        0.25,
        0.2
    };

    public long Amount { get; set; }
    public double Coefficient { get; set; }

    public Array GetInitialData()
    {
        return GetData();
    }

    private static ProfessionalPath[] GetData()
    {
        var retVal = new ProfessionalPath[Descriptions.Length];
        for (var i = 0; i < retVal.Length; i++)
        {
            retVal[i] = new ProfessionalPath
            {
                Id = i + 1,
                Description = Descriptions[i],
                Amount = Amounts[i],
                Coefficient = Coefficients[i]
            };
        }

        return retVal;
    }
}
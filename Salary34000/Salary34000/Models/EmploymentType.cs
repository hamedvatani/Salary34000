namespace Salary34000.Models;

public class EmploymentType : IdDescriptionModel, IHasInitialData
{
    private static readonly string[] Descriptions =
    {
        "رسمی",
        "قرارداد پاره‌وقت",
        "قرارداد تمام‌وقت"
    };

    public Array GetInitialData()
    {
        return GetData();
    }

    public static EmploymentType[] GetData()
    {
        var retVal = new EmploymentType[Descriptions.Length];
        for (var i = 0; i < retVal.Length; i++)
        {
            retVal[i] = new EmploymentType
            {
                Id = i + 1,
                Description = Descriptions[i]
            };
        }

        return retVal;
    }
}
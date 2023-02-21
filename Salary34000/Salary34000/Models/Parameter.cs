namespace Salary34000.Models;

public class Parameter : IdDescriptionModel, IHasInitialData
{
    private static readonly string[] Descriptions =
    {
        "پایه حقوق وزارت کار",
        "حق اولاد",
        "حق مسکن",
        "بن خواروبار",
        "ایاب و ذهاب",
        "پایه سنوات",
        "مزد ثابت کلیه سطوح"
    };

    private static readonly string[] Keys =
    {
        "BaseSalary",
        "Children",
        "Housing",
        "Grocery",
        "Transportation",
        "BaseYears",
        "ConstantSalary"
    };

    private static readonly long[] Values =
    {
        33218504,
        4179750,
        6500000,
        8500000,
        3000000,
        2100000,
        5151660
    };

    public int Year { get; set; }
    public string Key { get; set; } = "";
    public long Value { get; set; }

    public Array GetInitialData()
    {
        return GetData();
    }

    private static Parameter[] GetData()
    {
        var retVal = new Parameter[Descriptions.Length];
        for (var i = 0; i < retVal.Length; i++)
        {
            retVal[i] = new Parameter
            {
                Id = i + 1,
                Description = Descriptions[i],
                Year = 1401,
                Key = Keys[i],
                Value = Values[i]
            };
        }

        return retVal;
    }
}
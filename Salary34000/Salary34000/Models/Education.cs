namespace Salary34000.Models;

public class Education : IdDescriptionModel, IHasInitialData
{
    private static readonly string[] Descriptions =
    {
        "زیر دیپلم",
        "دیپلم",
        "فوق دیپلم",
        "کارشناسی",
        "کارشناسی ارشد",
        "دکتری"
    };

    private static readonly int[] Scors =
    {
        2,
        4,
        6,
        8,
        10,
        10,
    };

    public int Score { get; set; }

    public Array GetInitialData()
    {
        return GetData();
    }

    private static Education[] GetData()
    {
        var retVal = new Education[Descriptions.Length];
        for (var i = 0; i < retVal.Length; i++)
        {
            retVal[i] = new Education
            {
                Id = i + 1,
                Description = Descriptions[i],
                Score = Scors[i]
            };
        }

        return retVal;
    }
}
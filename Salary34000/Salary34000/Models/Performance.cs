namespace Salary34000.Models;

public class Performance : IdDescriptionModel, IHasInitialData
{
    private static readonly string[] Descriptions =
    {
        "عالی",
        "فراتر از انتظار",
        "در حد انتظار",
        "پایین تر از حد انتظار",
        "ضعیف"
    };

    private static readonly int[] Scors =
    {
        40,
        32,
        24,
        16,
        8
    };

    public int Score { get; set; }

    public Array GetInitialData()
    {
        return GetData();
    }

    private static Performance[] GetData()
    {
        var retVal = new Performance[Descriptions.Length];
        for (var i = 0; i < retVal.Length; i++)
        {
            retVal[i] = new Performance
            {
                Id = i + 1,
                Description = Descriptions[i],
                Score = Scors[i]
            };
        }

        return retVal;
    }
}
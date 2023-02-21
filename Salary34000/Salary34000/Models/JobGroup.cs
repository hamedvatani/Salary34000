namespace Salary34000.Models;

public class JobGroup : IdDescriptionModel, IHasInitialData
{
    private static readonly string[] Descriptions =
    {
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8",
        "9",
        "10",
        "11",
        "12",
        "13",
        "14",
        "15",
        "16",
        "17",
        "18",
        "19",
        "20",
        "A",
        "B",
        "C",
        "D",
        "E"
    };

    // public double ProportionIncrease { get; set; }
    // public double IncreaseCoefficient { get; set; }
    // public double CumulativeCoefficient { get; set; }
    // public double FinalCoefficient { get; set; }
    // public double JobExtra { get; set; }
    // public double ManagementExtra { get; set; }

    public Array GetInitialData()
    {
        return GetData();
    }

    private static JobGroup[] GetData()
    {
        var retVal = new JobGroup[Descriptions.Length];
        for (var i = 0; i < retVal.Length; i++)
        {
            retVal[i] = new JobGroup
            {
                Id = i + 1,
                Description = Descriptions[i]
            };
        }

        return retVal;
    }
}
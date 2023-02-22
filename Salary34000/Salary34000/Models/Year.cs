namespace Salary34000.Models;

public class Year : BaseModel, IHasInitialData
{
    public int Years { get; set; }
    public double Coefficient { get; set; }

    public Array GetInitialData()
    {
        return GetData();
    }

    private static Year[] GetData()
    {
        var retVal = new Year[35];
        for (int i = 0; i < 35; i++)
        {
            retVal[i] = new Year
            {
                Id = i + 1,
                Years = i + 1,
                Coefficient = 1 + (i + 1) / 100
            };
        }

        return retVal;
    }
}
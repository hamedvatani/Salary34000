namespace Salary34000.Models;

public class MilitaryService : IdDescriptionModel, IHasInitialData
{
    private static readonly string[] Descriptions =
    {
        "پروژه نخبه وظیفه",
        "در حال انجام",
        "کارت پایان خدمت",
        "کارت معافیت ",
        "معافیت پزشکی",
        "معافیت تحصیلی",
        "معافیت دائم",
        "معافیت زیر پرچم",
        "معافیت کفالت",
        "معافیت موارد خاص",
    };

    public Array GetInitialData()
    {
        return GetData();
    }

    private static MilitaryService[] GetData()
    {
        var retVal = new MilitaryService[Descriptions.Length];
        for (var i = 0; i < retVal.Length; i++)
        {
            retVal[i] = new MilitaryService
            {
                Id = i + 1,
                Description = Descriptions[i]
            };
        }

        return retVal;
    }
}
namespace Salary34000.Models;

public class OrganizationUnit : IdDescriptionModel, IHasInitialData
{
    private static readonly string[] Descriptions =
    {
        "مدیریت پشتیبانی و خدمات",
        "حوزه مدیر عامل",
        "مدیریت حراست",
        "مدیریت تدارکات",
        "گروه فناوین",
        "گروه پایش",
        "گروه جم",
        "گروه ارگ",
        "گروه حافظ",
        "مدیریت منابع انسانی ",
        "مدیریت مالی",
        "گروه بصیر",
        "مدیریت بازرگانی",
        "گروه آفاق",
        "مدیریت برنامه ریزی و نظارت",
        "گروه فناوری و شتابدهی برنا",
        "شیخ بهایی",
        "گروه پویش",
        "گروه ماهان",
        "مدیریت فاوا",
        "مدیریت تدارکات"
    };

    public Array GetInitialData()
    {
        return GetData();
    }

    private static OrganizationUnit[] GetData()
    {
        var retVal = new OrganizationUnit[Descriptions.Length];
        for (var i = 0; i < retVal.Length; i++)
        {
            retVal[i] = new OrganizationUnit
            {
                Id = i + 1,
                Description = Descriptions[i]
            };
        }

        return retVal;
    }
}
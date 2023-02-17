namespace Salary34000.Models;

public class Person : BaseModel
{
    public string PersonelCode { get; set; } = "";
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string NationalCode { get; set; } = "";
    public string DocumentNumber { get; set; } = "";
    public string DocumentSerial { get; set; } = "";
}
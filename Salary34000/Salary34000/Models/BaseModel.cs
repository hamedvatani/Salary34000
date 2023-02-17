using System.ComponentModel.DataAnnotations;

namespace Salary34000.Models;

public class BaseModel
{
    [Key]
    public int Id { get; set; }
}
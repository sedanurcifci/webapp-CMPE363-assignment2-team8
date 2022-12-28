using System.ComponentModel.DataAnnotations;

namespace GetDataFromAzureDb.Models
{
    public class TblEmployee
    {
        [Key]
        public int ID { get; set; }
        public string? EmpName { get; set; }

        public string? EmpSurname { get; set; }

        public string? EmpAddress { get; set; }

        public string? EmpPhone { get; set; }
    }

    public class EmployeeGeneralWrapper
    {
        public TblEmployee employeeGeneral { get; set; }
    }
}

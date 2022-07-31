namespace DesignPatterns.FacadePattern.HrExample.HrLib
{
    public class EmployeeService
    {
        public Employee GetById(int empId)
        {
            return new Employee
            {
                Id = empId,
                Salary = 500,
                FullName = "Ahmed Ali",
                DepartmentId = 29
            };
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int DepartmentId { get; set; }
        public double Salary { get; set; }
    }
}
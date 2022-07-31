using DesignPatterns.FacadePattern.HrExample.HrLib;

namespace DesignPatterns.FacadePattern.HrExample;

public class HrFacade
{
    public string GetPaySlipInfo(int empId, int year, int month)
    {
        var emp = new EmployeeService().GetById(empId);
        var worktimeSchedule = new WorktimeService().GetScheduleByEmpId(empId);

        var attendanceManager = new AttendanceManager();
        var totalLate = attendanceManager.CalcLate(empId, year, month, worktimeSchedule);
        var totalAbsent = attendanceManager.CalcAbsenceDays(empId, year, month, worktimeSchedule);

        var deductions = new DeductionsService().GetDeductions(emp, totalLate, totalAbsent);
        var overtime = attendanceManager.CalcOvertime(emp, year, month);
        var allowances = new AllowancesService().GetAllowances(emp, year, month);

        return $"Payslip for {emp.FullName} ({emp.Id}) for {year}-{month}:\n" +
            $"Basic Salary: {emp.Salary:0.##}\n" +
            $"Overtime: {overtime:0.##}\n" +
            $"Allowances: {allowances:0.##}\n" +
            $"Deductions: {deductions:0.##}";
    }
}
namespace DesignPatterns.FacadePattern.HrExample.HrLib;
public class AttendanceManager
{
    public int CalcLate(int empId, int year, int month, string worktimeSchedule)
    {
        return 100;
    }

    public int CalcAbsenceDays(int empId, int year, int month, string worktimeSchedule)
    {
        return 1;
    }

    internal object CalcOvertime(Employee emp, int year, int month)
    {
        return 50;
    }
}

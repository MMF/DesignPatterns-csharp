namespace DesignPatterns.FacadePattern.HrExample.HrLib;

public class WorktimeService
{
    public string GetScheduleByEmpId(int empId)
    {
        return $"WorkTime Schedule for {empId}";
    }
}
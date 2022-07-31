namespace DesignPatterns.FacadePattern.HrExample.HrLib;

public class DeductionsService
{
    public double GetDeductions(Employee emp, int totalLate, int totalAbsent)
    {
        var dayCost = emp.Salary / 26;
        var minuteCost = dayCost / 60;

        return (totalLate * minuteCost) + (totalAbsent * dayCost);
    }
}

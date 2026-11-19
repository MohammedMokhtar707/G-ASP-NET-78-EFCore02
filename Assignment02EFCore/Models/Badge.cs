namespace Assignment02EFCore.Models;
internal class Badge
{
    public int BadgeId { get; set; }
    public int BadgeNumber { get; set; }
    public DateTime DateIssued { get; set; }
    public string Tier { get; set; }

}
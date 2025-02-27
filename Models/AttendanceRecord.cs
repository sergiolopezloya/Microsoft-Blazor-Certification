namespace EventEase.Models
{
  public class AttendanceRecord
  {
    public string EventId { get; set; } = string.Empty;
    public string UserId { get; set; } = string.Empty;
    public string UserName { get; set; } = string.Empty;
    public DateTime CheckInTime { get; set; }
    public bool IsPresent { get; set; }
  }
}
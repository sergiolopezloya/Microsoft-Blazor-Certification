using EventEase.Models;

namespace EventEase.Services
{
  public class AttendanceService
  {
    private readonly Dictionary<string, List<AttendanceRecord>> _eventAttendance = new();

    public event Action? OnAttendanceChanged;

    public void RecordAttendance(string eventId, string userId, string userName)
    {
      if (!_eventAttendance.ContainsKey(eventId))
      {
        _eventAttendance[eventId] = new List<AttendanceRecord>();
      }

      var record = new AttendanceRecord
      {
        EventId = eventId,
        UserId = userId,
        UserName = userName,
        CheckInTime = DateTime.Now,
        IsPresent = true
      };

      _eventAttendance[eventId].Add(record);
      OnAttendanceChanged?.Invoke();
    }

    public IEnumerable<AttendanceRecord> GetEventAttendance(string eventId)
    {
      return _eventAttendance.TryGetValue(eventId, out var records)
          ? records
          : Enumerable.Empty<AttendanceRecord>();
    }

    public int GetAttendeeCount(string eventId)
    {
      return _eventAttendance.TryGetValue(eventId, out var records)
          ? records.Count
          : 0;
    }
  }
}
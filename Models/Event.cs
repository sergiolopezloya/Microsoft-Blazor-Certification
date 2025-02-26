namespace EventEase.Models;

public class Event
{
  public string Id { get; set; } = Guid.NewGuid().ToString();
  public string Name { get; set; } = string.Empty;
  public DateTime Date { get; set; }
  public string Location { get; set; } = string.Empty;
  public string Description { get; set; } = string.Empty;
}
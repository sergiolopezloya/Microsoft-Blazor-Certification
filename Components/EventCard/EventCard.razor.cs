namespace EventEase.Components.Cards;

using EventEase.Models;
using Microsoft.AspNetCore.Components;

public partial class EventCard
{
  [Parameter]
  public Event Event { get; set; } = new();

  [Parameter]
  public EventCallback<Event> OnEventSelected { get; set; }

  private bool ShowDescription { get; set; }

  private async Task OnEventClick()
  {
    ShowDescription = !ShowDescription;
    await OnEventSelected.InvokeAsync(Event);
  }
}
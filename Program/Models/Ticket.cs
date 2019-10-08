using csharp_ticketTracker.Interfaces;

namespace csharp_ticketTracker.Models
{
  public class Ticket : ITicket
  {

    public string Title { get; set; }
    public string Description { get; set; }

    // public string GetTemplate()
    // {


    // }
    public Ticket(string title, string description)
    {
      Title = title;
      Description = description;
    }
  }
}
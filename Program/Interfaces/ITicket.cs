namespace csharp_ticketTracker.Interfaces
{
  public interface ITicket
  {
    string Title { get; set; }
    string Description { get; set; }

    string GetTemplate();
  }
}
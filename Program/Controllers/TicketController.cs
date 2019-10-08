using System;
using csharp_ticketTracker.Services;

namespace csharp_ticketTracker.Controllers
{
  public class TicketController
  {
    private TicketService _ticketService = new TicketService();

    public void Run()
    {
      while (true)
      {
        Update();
        GetUserInput();
      }
    }

    private void Update()
    {
      Console.Clear();
      Console.WriteLine("--- Ticket Tracker ---");
      foreach (string message in _ticketService.Messages)
      {
        Console.WriteLine(message);
      }
      _ticketService.Messages.Clear();
    }

    private void GetUserInput()
    {
      Console.WriteLine("Please select an option: (view, new, quit)");
      string input = Console.ReadLine().ToLower();
      switch (input)
      {
        case "q":
        case "quit":
          Environment.Exit(0);
          break;
        case "view":
          _ticketService.Messages.Add("Please select one to view");
          break;
        case "new":
          _ticketService.Messages.Add("Please make a new one");
          break;

      }

    }

  }
}
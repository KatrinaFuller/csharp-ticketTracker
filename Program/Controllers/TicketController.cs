using System;
using csharp_ticketTracker.Models;
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
      Console.WriteLine("Number \t Title");
      Console.WriteLine("-----------------");
      foreach (string message in _ticketService.Messages)
      {
        Console.WriteLine(message);
      }
      _ticketService.Messages.Clear();
      foreach (Ticket ticket in _ticketService.Tickets)
      {
        Console.WriteLine($"{ticket.Title}");
      }
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
          ViewTicket();
          break;
        case "new":
          NewTicket();
          break;

      }

    }

    private void ViewTicket()
    {
      Console.WriteLine("Please select a ticket to view");
    }

    private void NewTicket()
    {
      Console.WriteLine("Title: ");
      string title = Console.ReadLine();
      Console.WriteLine("Description: ");
      string description = Console.ReadLine();
      _ticketService.CreateTicket(title, description);
    }

  }
}
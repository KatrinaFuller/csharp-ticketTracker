using System;
using System.Collections.Generic;
using csharp_ticketTracker.Models;

namespace csharp_ticketTracker.Services
{
  public class TicketService
  {
    public List<string> Messages { get; set; }
    public List<Ticket> Tickets { get; set; }

    internal void CreateTicket(string title, string description)
    {
      Tickets.Add(new Ticket(title, description));
      //   Messages.Add("Ticket was added!");
    }
    public TicketService()
    {
      Messages = new List<string>();
      Tickets = new List<Ticket>();
    }

  }
}
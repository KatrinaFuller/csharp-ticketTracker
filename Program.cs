using System;
using csharp_ticketTracker.Controllers;

namespace csharp_ticketTracker
{
  class Program
  {
    static void Main(string[] args)
    {
      new TicketController().Run();
    }
  }
}

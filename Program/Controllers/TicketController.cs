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

    }

    private void GetUserInput()
    {
      Console.WriteLine("It works!");
      if (Console.ReadLine() == "q")
      {
        Environment.Exit(0);
      }
    }

  }
}
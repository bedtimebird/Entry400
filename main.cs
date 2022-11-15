using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
      //Interface newSession = new Interface();
      //newSession.InitialGreeting();
      PermitOutput.PrintCoquitlamDP();
      LoginLogic login = new LoginLogic();
      login.ProgramStartup();
      Console.ReadLine();
        
    }
}

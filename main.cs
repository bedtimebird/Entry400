using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
      Interface newSession = new Interface();
      newSession.InitialGreeting();
      Console.ReadLine();
        
    }
}

// PHASE 2
// Focus on the ability to create a completed 'coquitlam development form'
// 1. Program login / create new account
// Q: Can only applicants login??? -> yes for now.

// PHASE 1
// substantially working - no error checking - some items not functioning properly
// 1. Edit Sites and Lot information
// 2. Complete and test options for Site
// 3. Complete and test options for Contact
// 4. Complete and test options for Lot
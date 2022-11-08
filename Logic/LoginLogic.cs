using System;
using System.Collections.Generic;
using System.Linq;

public class LoginLogic
{

  public List<ApplicantModel> applicants = new List<ApplicantModel>();
  
  public void ProgramStartup()
  {
    ConsoleOutput.PrintProgramWelcome();
    int rec = int.Parse(UserInput.GetInfo("Please selection #: "));
    if(rec == 1){
      Login();
    }
    else if(rec ==2)
    {
      
    }
    else
    {
      ProgramLogin();
    }
  }

  public void Login()
  {
    string email = UserInput.GetInfo("Enter email address: ");
    string password = UserInput.GetInfo("Enter password: ");

    
    // Confirm valid or invalid login/password
    // if invalid try again - limit 5x tries
    // if valid - proceed with Userdata - show only projects associated with that user/person
    Interface newSession = new Interface();
    newSession.SetupNewSession();
  }

  public void ProgramLogin()
  {
    
  }

  public void CreateNewApplicant()
  {
    
  }
  
}
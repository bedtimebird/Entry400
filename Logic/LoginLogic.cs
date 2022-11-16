using System;
using System.Collections.Generic;
using System.Linq;

public class LoginLogic
{
  int loginAttempt = 0;
  UserModel user = new UserModel();

  // TODO - create a list of UserModel then populate with static data
  // then create a method to check email and password against that static list
  
  public void Login()
  {
    string email = UserInput.GetInfo("Enter email address: ");
    string password = UserInput.GetInfo("Enter password: ");

    bool attempt = ConfirmLoginDetails(email, password);
    if(attempt == true)
    {
      MainMenu session = new MainMenu();
      session.MainMenuOptions(user);
    } 
    else if (attempt == false && loginAttempt < 5)
    {
      Login();
    } 
    else
    {
      ConsoleOutput.PrintTitle("Goodbye");
    }
    
  }

  public bool ConfirmLoginDetails(string email, string password)
  {
    bool loginAllowed = false;
    string DBEmail = "";
    string DBPassword = "";
    // confirm with database that details are correct
    if (DBEmail == email && DBPassword == password)
    {
      return loginAllowed = true;
    } else {
      loginAttempt +=0;
      return loginAllowed = false;
    }
    
  }

  public void NewAccount()
  {
    UserModel newUser = new UserModel();
    newUser.UserName = UserInput.GetInfo("Enter username: ");
    newUser.Password = UserInput.GetInfo("Enter password: ");
    newUser.FirstName = UserInput.GetInfo("Enter first name: ");
    newUser.LastName = UserInput.GetInfo("Enter last name: ");
    newUser.PriPhone = UserInput.GetInfo("Enter primary phone number: ");
    newUser.Email = UserInput.GetInfo("Enter email address: ");
    user = newUser;
  }

  public void RetrievePassword()
  {
    // Create method to retrieve password
  }
  
}
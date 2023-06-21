
using program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Bank
{
    private List<User> users;

    public Bank()
    {
        users = new List<User>();
    }

    public void AddUser(User user)
    {
        users.Add(user);
    }

    public void DisplayAccounts()
    {

        Console.Title = "shege App";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n\n......................................... Welcome to ShegeBank App........................\n\n\n");
        Console.WriteLine("press Enter to print");
        Console.ReadLine();
        Console.WriteLine("|-------------------|-------------------------------|--------------------------|---------------------|----------|");
        Console.WriteLine("|     FULL NAME     |        ACCOUNT NUMBER         |       ACCOUNT TYPE       |       AMOUNT BAL    |   NOTE   |");
        Console.WriteLine("|-------------------|-------------------------------|--------------------------|---------------------|----------|");

        foreach (User user in users)
        {
            foreach (Account account in user.Accounts)
            {
                Console.WriteLine($"| {user.FullName,-17} | {account.AccountNumber,-29} | {account.AccountType,-24} | {account.Balance.ToString("N0"),-19} | {account.Note,-8} |");
            }
            Console.WriteLine("|--------------------------------------------------------------------------------------------------------------|");
     
            }
            
           
        
    }
}

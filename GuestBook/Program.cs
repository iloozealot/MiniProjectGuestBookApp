
//Console application?
//Ask the user for their name and how many are in their party?
//Track how many people are at the party?
//Print Guest List and Total number of guests?

using GuestBook;
using static System.Console;

bool isRunning = false;

WriteLine("Welcome to the party!");
WriteLine("-------------------------------------------");

do
{
    Console.WriteLine();

    PartyAttendance.GetPartyNames();

    Console.WriteLine();

    PartyAttendance.GetPartyNumbers();

    Console.WriteLine();

    Write("Is there another party y/n: ");


    if (ReadLine() == "y")
    {
        isRunning = true;
    }
    else
    {
        isRunning = false;
    }

} while (isRunning == true);

WriteLine();

PartyAttendance.PartyNames();

WriteLine();

PartyAttendance.GuestNumbers();

WriteLine();

WriteLine("Thank you for coming!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using static System.Console;

namespace GuestBook
{
    public static class PartyAttendance
    {
        static List<string> guestBook = new();
        static List<int> partyNumbers = new();
        static string partyName;
        static int partyNumber;
        static bool anotherGroup = false;
        static int result = 0;
        public static void GetPartyNames()
        {
            Write("Please enter name of party: ");
            partyName = ReadLine();
            guestBook.Add(partyName);
        }
        public static void GetPartyNumbers()
        {
            Write("Please enter number in party: ");
            partyNumber = Convert.ToInt32(ReadLine());
            partyNumbers.Add(partyNumber);
        }
        public static void PartyNames()
        {
            foreach (string partyName in guestBook)
            {
                WriteLine($"Parties in attendance: {partyName}");
            }
        }
        public static void GuestNumbers()
        {
            foreach (int partyNumber in partyNumbers)
            {
                result += partyNumber;
            }

            WriteLine($"The number of people in attendance is {result}");
        }
    }
}

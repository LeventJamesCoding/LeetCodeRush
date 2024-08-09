using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Given a valid (IPv4) IP address, return a defanged version of that IP address.

//A defanged IP address replaces every period "." with "[.]".

 

//Example 1:

//Input: address = "1.1.1.1"
//Output: "1[.]1[.]1[.]1"
//Example 2:

//Input: address = "255.100.50.0"
//Output: "255[.]100[.]50[.]0"



//Constraints:

//The given address is a valid IPv4 address.
namespace Defanging_an_IP_Address
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.ReadLine();
        }
        public class Solution
        {
            private string address1 = "1.1.1.1";
            private string address2 = "255.100.50.0";
            public Solution()
            {
                Console.WriteLine($"address = \"{address1}\"; Output = {DefangIPaddr(address1)}, Expected: 1[.]1[.]1[.]1");
                Console.WriteLine($"address = \"{address2}\"; Output = {DefangIPaddr(address2)}, Expected: 255[.]100[.]50[.]0");
            }
            public string DefangIPaddr(string address)
            {
                return address.Replace(".", "[.]");
            }
        }
    }
}
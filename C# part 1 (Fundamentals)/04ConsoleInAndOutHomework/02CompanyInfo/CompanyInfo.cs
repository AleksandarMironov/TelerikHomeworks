using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02CompanyInfo
{
    class CompanyInfo
    {
        static void Main()
        {
            string companyName = Console.ReadLine();
            string companyAddress = Console.ReadLine();
            string phoneNumber = Console.ReadLine();
            string faxNumber = Console.ReadLine();
            if (faxNumber == "")
            {
                faxNumber = "(no fax)";
            }
            string webSite = Console.ReadLine();
            string managerFirstName = Console.ReadLine();
            string managerLastName = Console.ReadLine();
            string managerAge = Console.ReadLine();
            string managerPhone = Console.ReadLine();
            Console.WriteLine(
                "{0} \nAddress: {1} \nTel. {2} \nFax: {3} \nWeb site: {4} \nManager: {5} {6} (age: {7}, tel. {8})",
                companyName, companyAddress, phoneNumber, faxNumber, webSite, managerFirstName, managerLastName,
                managerAge, managerPhone);
        }    
    }
}

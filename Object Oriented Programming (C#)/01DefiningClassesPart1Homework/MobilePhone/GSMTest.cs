using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class GSMTest
    {

        public static void Test()
        {
            Console.WriteLine("07: GSM test" + Environment.NewLine);

            Gsm [] gsmMass  = new Gsm[]
            {
                Gsm.IPhone4S,
                new Gsm("M5", "Sony"),
                new Gsm("820", "HTC"),
                new Gsm("Broken", "Samsung", 12358999585, "unhappy man" , new Battery("Samsung", 24, 1, BatteryType.NiCd), new Display(5, 16000000)), 

            };

            gsmMass[2].Battery = new Battery("HTC820", 50, 15, BatteryType.VeryPowerfull);

            foreach (var gsm in gsmMass)
            {
                Console.WriteLine(gsm.ToString());
                Console.WriteLine("************* \n");
            }

            Console.WriteLine(Gsm.IPhone4S.ToString());
        }
    }
}

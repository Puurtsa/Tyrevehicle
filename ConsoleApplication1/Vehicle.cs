using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;
namespace ConsoleApplication1
{
    public class Vehicle : Tyre
    {
        private const int maxTyres = 4;
        private int countTyres = 0;
        public string Brand { get; set; }
        public string Model { get; set; }
        public Tyre[] Tyres { get; }

        public Vehicle()
        {
            Tyres = new Tyre[maxTyres];
        }
        public void AddTyre(Tyre Tyre)
        {
            if (countTyres < maxTyres)
            {
                Tyres[countTyres] = Tyre;
                countTyres++;
                Console.WriteLine("Rengas {0} lisätty ajoneuvoon {1}", Tyre.ToString(), this.Brand);
            }
            else
            {
                Console.WriteLine("Ei sovi enää uusia renkaita, sorry");

            }
        }
        public override string ToString()
        {
            string retval = "Ajoneuvo valmistaja: " + Brand + " malli: " + Model + "\nrenkaat:";
            foreach (Tyre tyre in Tyres)
            {
                if (tyre != null)
                {
                    retval += "\n" + tyre.ToString();
                }
            }
            return retval;
        }
    }
}



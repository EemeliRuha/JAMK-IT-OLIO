using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikkotehtavat
{
    class Program
    {
        static void Main(string[] args)
        {
            Tehtava1();
        }

    static void Tehtava1()
        {
            // Tee ohjelma, joka tulostaa käyttäjän antamaa lukua (1, 2 tai 3) vastaavan luvun sanana (yksi, kaksi tai kolme). Jos käyttäjä syöttää jonkin muun luvun, tulee näytölle tulostaa teksti: "joku muu luku".
            Console.WriteLine("Anna 1,2 tai 3 ja tulostan sen tekstinä");
            string retval = Console.ReadLine();
            int luku = int.Parse(retval);
            if (luku == 1)
            {
                retval = "Yksi";
            }
            else if (luku == 2)
            {
                retval = "Kaksi";
            }
            else if (luku == 3)
            {
                retval = "Kolme";
            }
            else
            {
                retval = "Joku muu luku";
            }
            //tulostus käyttäjälle
            Console.WriteLine(retval);
        }
    static void Tehtava2()
        {
            //Tee ohjelma, jossa annetaan oppilaalle koulunumero seuraavan taulukon mukaan (pistemäärä kysytään ja ohjelma tulostaa numeron)
            Console.WriteLine("Anna pistemäärä ja tulostan numeron");
            string score = Console.ReadLine();
            
        }
    }

}

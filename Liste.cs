using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marathon
{
    public class Liste
    {
        List<Laeufer> laeuferListe = new List<Laeufer>();

        public void AddLaeufer(Laeufer s)
        {
            laeuferListe.Add(s);
        }

        public string Title
        {
            get;
            private set;
        }
        public Liste(string name)
        {
            this.Title = name;
        }
        public void Print()
        {
            Console.WriteLine(Title);
            Console.WriteLine("====================\n");

            for (int i = 0; i < laeuferListe.Count; i++)
            {
                Console.WriteLine($"{laeuferListe[i].GetLaufnummer()} {laeuferListe[i].GetName()} {laeuferListe[i].GetZeit()}");
            }

            Console.WriteLine();
        }
    }
}

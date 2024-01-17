using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marathon
{
    public class Laeufer
    {
        string _vorname;
        string _nachname;
        int _laufnummer;
        int _zeit;

        public string GetName()
        {
            return $"{_vorname} {_nachname}";
        }

        public int GetLaufnummer()
        {
            return _laufnummer;
        }

        public int GetZeit()
        {
            return _zeit;
        }
        public Laeufer(int laufnummer, string vorname, string nachname, int zeit)
        {
            this._laufnummer = laufnummer;
            this._vorname = vorname;
            this._nachname = nachname;
            this._zeit = zeit;
        }
    }
}

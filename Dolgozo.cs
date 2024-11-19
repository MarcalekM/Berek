using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berek
{
    internal class Dolgozo
    {
        public string Nev {  get; set; }
        public bool Neme { get; set; }
        public string Reszleg { get; set; }
        public string BelepesiEv { get; set; }
        public int Ber {  get; set; }

        public override string ToString()
        {
            return $"Név: {Nev}\nNeme: {(Neme ? "férfi" : "nő")}\nRészleg: {Reszleg}\nBelépés éve: {BelepesiEv}\nBér: {Ber}";
        }

        public Dolgozo(string sor) {
            var temp = sor.Split(';');
            Nev = temp[0];
            Neme = temp[1] == "férfi";
            Reszleg = temp[2];
            BelepesiEv = temp[3];
            Ber = int.Parse(temp[4]);
        }
    }
}

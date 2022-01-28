using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2022_01_28_Opening_weekend
{
    class Film
    {
        public string eredeticim { get; set; }
        public string magyarCím { get; set; }
        public string Bemutató { get; set; }
        public string Forgalmazó { get; set; }
        public int Bevétel { get; set; }
        public int látogatók { get; set; }

        public Film(string sor)
        {
            string[] t = sor.Split(';');
            eredeticim = t[0];
            magyarCím = t[1];
            Bemutató = t[2];
            Forgalmazó = t[3];
            Bevétel = int.Parse(t[4]);
            látogatók = int.Parse(t[5]);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemoClean
{
    public class Pony
    {
        public string Name { get; set; }
        public string HairColor { get; set; }
        public string SkinColor { get; set; }
        public CutieMark CutieMark { get; set; }

        public Pony(string name, string hairColor, string skinColor, CutieMark cutieMark)
        {
            Name = name;
            HairColor = hairColor;
            SkinColor = skinColor;
            CutieMark = cutieMark;
        }

        public static List<Pony> GetListOfPonies()
        {
            List<Pony> allPonies = new List<Pony>();
            CutieMark mark = new CutieMark("Teddy Bear", 1, "yellow", "red");
            Pony pony = new Pony("Cuddles", "yellow", "blue", mark);
            allPonies.Add(pony);

            CutieMark mark2 = new CutieMark("Ice Cream Cone", 11, "purple", "pink");
            Pony pony2 = new Pony("Scoops", "purple", "white", mark2);
            allPonies.Add(pony2);

            CutieMark mark3 = new CutieMark("Balloon", 7, "pink", "purple");
            Pony pony3 = new Pony("Celebration", "pink", "aqua", mark2);
            allPonies.Add(pony3);

            CutieMark mark4 = new CutieMark("dot", 40, "white", null);
            Pony pony4 = new Pony("Cotton Candy", "pink", "pink", mark4);
            allPonies.Add(pony4);

            CutieMark mark5 = new CutieMark("Peach", 7, "orange", "green");
            Pony pony5 = new Pony("Apple Jack", "yellow", "orange", mark5);
            allPonies.Add(pony5);

            CutieMark mark6 = new CutieMark("Flower", 11, "white", null);
            Pony pony6 = new Pony("Lavender", "purple", "purple", mark6);
            allPonies.Add(pony6);

            return allPonies;
        }
    }
}

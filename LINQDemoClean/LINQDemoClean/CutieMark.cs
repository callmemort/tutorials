using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemoClean
{
    public class CutieMark
    {
        public string Mark { get; set; }
        public int Quantity { get; set; }
        public string PrimaryColor { get; set; }
        public string SecondaryColor { get; set; }
        public CutieMark(string mark, int quantity, string primaryColor, string secondaryColor)
        {
            Mark = mark;
            Quantity = quantity;
            PrimaryColor = primaryColor;
            SecondaryColor = secondaryColor;

        }
    }

}

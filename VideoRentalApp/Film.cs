using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRentalApp
{
    public class Film
    {
        public int Id { get; set; }
        public string Titlu { get; set; }
        public string Gen { get; set; }

        public override string ToString()
        {
            return $"{Id}. {Titlu} - {Gen}";
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRentalApp
{
    public class Client
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"{Id}. {Nume} ({Email})";
        }
    }

}

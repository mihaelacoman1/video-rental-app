using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRentalApp
{
    public class Inchiriere
    {
        public int Id { get; set; }
        public Client Client { get; set; }
        public Film Film { get; set; }
        public DateTime DataInchiriere { get; set; }
        public DateTime? DataReturnare { get; set; }

        public override string ToString()
        {
            return $"{Id}. {Client.Nume} -> {Film.Titlu} ({DataInchiriere.ToShortDateString()} - {(DataReturnare.HasValue ? DataReturnare.Value.ToShortDateString() : "nedefinit")})";
        }

    }


}

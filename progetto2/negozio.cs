using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace progetto2
{
    public static class Negozio
    {
        public static List<Carrello> negozio = new List<Carrello>()
        {
            new Carrello()
            {
                id= 1 ,
                Name = "Il Signore degli Anelli",
                Price = 19.99m,
                Description = "Un romanzo fantasy epico di J.R.R. Tolkien.",
                dattagli= "Il giovane mago Harry Potter scopre il suo retaggio magico e inizia la sua avventura alla Scuola di Magia e Stregoneria di Hogwarts.",
                foto ="IlSignoredegliAnelli.jpg"
            }
        };

        public static List<Carrello> carrello = new List<Carrello>();

        public static void addProducts(Carrello c)
        {
            carrello.Add(c);
        }
    }
}
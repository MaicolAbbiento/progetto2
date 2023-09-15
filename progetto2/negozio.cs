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
                foto ="ilsignoredeglianelli.jpg"
            },
            new Carrello()
            {
                id= 2 ,
                Name = "Harry Potter e la Pietra Filosofale",
                Price = 14.99m,
                Description = "Il primo libro della serie di Harry Potter scritta da J.K. Rowling.",
                dattagli = "Il giovane mago Harry Potter scopre il suo retaggio magico e inizia la sua avventura alla Scuola di Magia e Stregoneria di Hogwarts.",
                foto ="harryPotter.jpg"
            },
            new Carrello()
            {
                id= 3 ,
                Name = "Cronache di Narnia",
                Price = 17.49m,
                Description = "Una serie di sette romanzi fantasy di C.S. Lewis.",
                dattagli = "Un mondo incantato chiamato Narnia è il palcoscenico per le avventure dei fratelli Pevensie mentre scoprono la magia e il mistero.",
                foto ="Cronache-di-Narnia.jpg"
            },
            new Carrello()
            {
                id= 4 ,
                Name = "Il Piccolo Principe",
                Price = 12.99m,
                Description = "Un classico della letteratura scritto da Antoine de Saint-Exupéry.",
                dattagli= "La storia di un piccolo principe che visita vari pianeti e impara importanti lezioni di vita.",
                foto ="il-piccolo-principe-1.jpg"
            },
            new Carrello()
            {
                id= 5 ,
                Name = "1984",
                Price = 14.99m,
                Description = "Il famoso romanzo distopico di George Orwell.",
                dattagli = "La storia di Winston Smith in un mondo totalitario dominato dal Partito.",
                foto ="1984.jpg"
            },
            new Carrello()
            {
                id= 6 ,
                Name = "Orgoglio e Pregiudizio",
                Price = 9.99m,
                Description = "Un classico della letteratura inglese scritto da Jane Austen.",
                dattagli = "La storia di Elizabeth Bennet e Mr. Darcy mentre navigano tra l'amore e la società.",
                foto ="OrgoglioePregiudizio.jpg"
            }
        };

        public static List<Carrello> carrello = new List<Carrello>();

        public static void addProducts(Carrello c)
        {
            carrello.Add(c);
        }
    }
}
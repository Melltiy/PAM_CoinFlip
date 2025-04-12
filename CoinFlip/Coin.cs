using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
    public class Coin
    {
        private string LadoSorteado;

        public string LadoSorteado1 { get => LadoSorteado; set => LadoSorteado = value; }
        public Coin()
        {

        }



        public String Flip()
        {
            Random random = new Random();
            if (random.Next(2) == 0)
            {
                LadoSorteado = "Cara";
            }
            else
            {
                LadoSorteado = "Coroa";
            }

           // LadoSorteado = random.Next(2) == 0 ? "Cara" : "Coroa";


            return(LadoSorteado);
        }
    }
}


        


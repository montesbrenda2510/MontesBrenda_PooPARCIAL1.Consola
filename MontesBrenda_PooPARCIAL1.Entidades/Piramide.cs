using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontesBrenda_PooPARCIAL1.Entidades
{
    public class Piramide
    {

        private int ladodelabase;
        private int altura;
        
        public int Ladodelabase
        {
            get { return ladodelabase; }
            set { ladodelabase = value; }

        }
        
        public Piramide(int altura, int ladodelabase)
        {
            altura = altura;
            ladodelabase = ladodelabase;
            GetCalcularArista(); 
        }
       

        public double GetCalcularArista() => Math.Sqrt(Math.Pow(altura,2) + Math.Pow(ladodelabase,2));

        public double GetArea() => ladodelabase * (Ladodelabase + Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(ladodelabase, 2)));


        public double GetVolumen() => (Math.Pow(ladodelabase, 2) * altura) / 3;
        
        
        }
}


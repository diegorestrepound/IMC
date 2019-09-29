using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class IMC
    {
        private int estatura;
        private int peso;


        public void setPeso(int valor)
        {
            this.peso = valor;
        }

        public int getPeso()
        {
            return this.peso;
        }

        public void setEstatura(int valor)
        {
            this.estatura = valor;
        }
        
        public int getEstatura()
        {
            return this.estatura;
        }

        public int resultado()
        {
            return (peso / (estatura * estatura));
        }
    }
}

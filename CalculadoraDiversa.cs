using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploClasse1.RegrasDeNegocio
{
    internal class CalculadoraDiversa
    {
        //atributos
        private double valor1;
        private double valor2;
        private double valor3;
        private double percentual;
        private double total;

        //métod de acesso
        //Método SET
        public void SetPercentual(double percentual)
        {
            this.percentual = percentual/100;
        }

        public void SetValor1(double valor1)
        {
            this.valor1 = valor1;
        }
        public void SetValor2(double valor2)
        {
            this.valor2 = valor2;
        }
        public void SetValor3(double valor3)
        {
            this.valor3 = valor3;
        }
        //método GET

        public double GetPercentual()
        {
            return percentual;
        }

        public double GetValor1()
        {
            return valor1;
        }
        public double GetValor2()
        {
            return valor2;
        }
        public double GetValor3() { return valor3; }

        public double GetTotal()
        {
            return total;
        }

        //método
        public void SomarDoisValores()
        {
            this.total = this.valor1 + this.valor2;
        }


    }
}

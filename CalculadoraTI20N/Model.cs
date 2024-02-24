using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTI20N
{
    class Model
    {
        //Área de variaveis
        private double num1;
        private double num2;

        //Metodo Construtor = Instancia as variáveis
        public Model()
        {
            ConsultarNum1 = 0;
            num2 = 0;
        }//fim do Construtor


        //Metodo GET e SET
        public double ConsultarNum1
        {
            get { return num1; }
            set { num1 = value; }
        }//Fim do GET e SET

        public double consultarNum2
        {
            get { return num2; }
            set { num2 = value; }
        }//Fim do GET e SET

        public double Somar()
        {
            return ConsultarNum1 + consultarNum2;
        }//Fim do somar

        public double Subtrair()
        {
            return ConsultarNum1 - consultarNum2;
        }//Fim do metodo subtrair

        public double Multiplicar()
        {
            return ConsultarNum1 * consultarNum2;
        }//Fim do Multiplicar

        public double Dividir()
        {
            if (consultarNum2 <= 0)
            {
                return -1;
            }
            else
            {
                return ConsultarNum1 / consultarNum2;
            }
        }//Fim do dividir
    }//Fim da classe
}//Fim do projeto

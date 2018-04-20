using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        private string SetNumero
        {
            set
            {
                this.numero = this.ValidarNumero(value);          
            }
        }

        public Numero()
        {

        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string numero)
        {
            this.SetNumero = numero;
        }

        /// <summary>
        /// Convierte un string a double
        /// </summary>
        /// <param name="strNumero"> La cadena a convertir </param>
        /// <returns> El numero en formato double </returns>
        private double ValidarNumero(string strNumero)
        {
            double retorno = 0;

            if (double.TryParse(strNumero, out double auxiliarRetorno))
            {
                retorno = auxiliarRetorno;
            }

            return retorno;
        }

        /// <summary>
        /// Convierte un numero binario en formato string a un decimal en formato string
        /// </summary>
        /// <param name="binario"> El binario a convertir </param>
        /// <returns> Un string que contiene el numero en decimal </returns>
        public string BinarioDecimal(string binario)
        {
            double retorno = 0;
            bool flag = true;

            if (binario.Length > 1)
            {
                if (binario[0] == '-')
                {
                    binario = binario.Substring(3, binario.Length - 3);
                }
                else
                {
                    binario = binario.Substring(2, binario.Length - 2);
                }
            }
            
            for (int j = 0; j <= binario.Length - 1; j++)
            {
                if (binario[j].ToString() != "0" && binario[j].ToString() != "1")
                {
                    flag = false;
                    break;
                }
            }

            if (flag)
            {
                for (int i = 1; i <= binario.Length; i++)
                {
                    retorno += double.Parse(binario[i - 1].ToString()) * (double)Math.Pow(2, binario.Length - i);
                }
            }
            else
            {
                return "Valor inválido";
            }

            return retorno.ToString();
        }

        /// <summary>
        /// Convierte un decimal en formato double a binario
        /// </summary>
        /// <param name="numero"> Numero a convertir a binario </param>
        /// <returns> El numero binario en formato string </returns>
        public string DecimalBinario(double numero)
        {
            string retorno = "";
            int numeroEntero = (int)numero;

            if (numeroEntero < 0)
            {
                numeroEntero = numeroEntero * -1;
            }

            while (numeroEntero > 0)
            {
                retorno = (numeroEntero % 2).ToString() + retorno;
                numeroEntero = numeroEntero / 2;
            }

            if (numero >= 0)
            {
                retorno = "0b" + retorno;
            }
            else
            {
                retorno = "-0b" + retorno;
            }

            return retorno.ToString();
        }

        /// <summary>
        /// Convierte un decimal en formato string a binario
        /// </summary>
        /// <param name="numero"> Numero a convertir a bianario </param>
        /// <returns> El numero binario en formato string </returns>
        public string DecimalBinario(string numero)
        {
            string retorno = "";

            if (double.TryParse(numero, out double auxiliar))
            {
                retorno = this.DecimalBinario(auxiliar);
            }

            return retorno;
        }

        /// <summary>
        /// Permite que al sumar dos objetos numero no haga falta llamar a sus variables
        /// </summary>
        /// <param name="n1"> Primer numero a operar </param>
        /// <param name="n2"> Segundo numero a operar </param>
        /// <returns> El resultado de la operacion </returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Permite que al restar dos objetos numero no haga falta llamar a sus variables
        /// </summary>
        /// <param name="n1"> Primer numero a operar </param>
        /// <param name="n2"> Segundo numero a operar </param>
        /// <returns> El resultado de la operacion </returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Permite que al dividir dos objetos numero no haga falta llamar a sus variables
        /// </summary>
        /// <param name="n1"> Primer numero a operar </param>
        /// <param name="n2"> Segundo numero a operar </param>
        /// <returns> El resultado de la operacion </returns>
        public static double operator /(Numero n1, Numero n2)
        {
            return n1.numero / n2.numero;
        }

        /// <summary>
        /// Permite que al multiplicar dos objetos numero no haga falta llamar a sus variables
        /// </summary>
        /// <param name="n1"> Primer numero a operar </param>
        /// <param name="n2"> Segundo numero a operar </param>
        /// <returns> El resultado de la operacion </returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }
    }

        




}

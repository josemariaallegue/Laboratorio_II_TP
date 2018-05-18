using System;

namespace Entidades
{
    public class Calculadora
    {
        /// <summary>
        /// Suma 
        /// </summary>
        /// <param name="num1"> Primer numero a operar </param>
        /// <param name="num2"> Segundo numero a operar</param>
        /// <param name="operador"> Determina que cuenta se va a realizar </param>
        /// <returns> Devuelve el resultado de la operacion entre los dos numeros </returns>
        public double Operar(Numero num1, Numero num2, string operador)
        {
            double retorno = 0;

            switch (Calculadora.ValidarOperador(operador))
            {
                case "+":
                    retorno = num1 + num2;
                    break;

                case "-":
                    retorno = num1 - num2;
                    break;

                case "/":
                    retorno = num1 / num2;
                    break;

                case "*":
                    retorno = num1 * num2;
                    break;
            }

            return retorno;
        }

        /// <summary>
        /// Valida que operador sea +, - , / o *
        /// </summary>
        /// <param name="operador"> El string a comprobar </param>
        /// <returns> Si es distinto a alguna de las 4 opciones devuelve + si no el correspondiente</returns>
        private static string ValidarOperador(string operador)
        {
            string retorno = "+";

            if (operador == "-" || operador == "*" || operador == "/")
            {
                retorno = operador;
            }

            return retorno;
        }
    }
}

using System;
using System.Text;

namespace Codility
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine(Program.Ejercicio2("Abbcc", new int[] { 1, 2, 3, 1, 5 }));

        }


        public static int Ejercicio2(string cadena1,int[] costo)
        {
        
            string cadena2 = (string)cadena1.Clone();
        
            int u = 0;
            int suma = 0;

            for (int i = 0; i < cadena1.Length; i++)
            {

                if (cadena1[i] == cadena2[i])
                {
                    u++;

                    if (u > 1)
                    {
                        suma += Convert.ToInt32(costo[i]);
                        u = 0;
                    }

                }

            }

            return suma;
        }

        public static int Ejericio1(string s)
        {
            var mayuscula = new StringBuilder();
            var minuscula = new StringBuilder();
            var minuscula2 = new StringBuilder();
            int con = 0;
            int valor = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsUpper(s[i]))
                {
                    mayuscula.Append(Convert.ToString(s[i]));

                }
                else
                {
                    minuscula.Append(Convert.ToString(s[i]));
                    minuscula2.Append(Convert.ToString(s[i]).ToUpper());
                }

            }

            var may = mayuscula.Length;

            var min = minuscula.Length;


            for (int i = 0; i < min; i++)
            {
                for (int j = 0; j < may; j++)
                {

                    if (minuscula2[i] == mayuscula[j])
                    {
                        con++;
                    }
                }
            }

            if (con > 1)
            {
                if (may == min)
                {
                    valor = may + min;
                }
                else
                {
                    valor = con;
                }
            }
            else
            {
                valor = -1;
            }

            return valor;

        }


    }



}





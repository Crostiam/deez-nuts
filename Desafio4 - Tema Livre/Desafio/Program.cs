using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
          case1:{
                int a,b,c;

                Console.WriteLine("====================================================");
                Console.WriteLine("Que Tipo de Calculo quer Fazer?");
                Console.WriteLine("1- Geometricos 2- Economicos");
                c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("===================================================");




                if (c == 1)
                {
                    Console.WriteLine("===================================================");
                    Console.WriteLine("Que Tipo de Calculo quer Fazer?");
                    Console.WriteLine("1- Area do Quadrado/Retângulo 2- Area do Triangulo 3- Area do Circulo");
                    Console.WriteLine("===================================================");
                    a = Convert.ToInt32(Console.ReadLine());

                    if (a == 1)
                    {
                        double Base, Altura, Area;

                        Console.WriteLine("\nDigite a Base e depois a Altura. (em centimetros)");
                        Base = Convert.ToDouble(Console.ReadLine());
                        Altura = Convert.ToDouble(Console.ReadLine());

                        Area = Base * Altura;

                        Console.WriteLine("A Area do Quadrado/Retangulo é " + Area + "cm²");

                    }

                    if (a == 2)
                    {
                        double Base2, Altura2, Area2;

                        Console.WriteLine("\nDigite a Base e depois a Altura. (em centimetros)");
                        Base2 = Convert.ToDouble(Console.ReadLine());
                        Altura2 = Convert.ToDouble(Console.ReadLine());

                        Area2 = (Base2 * Altura2) / 2;

                        Console.WriteLine("A Area do Triângulo é " + Area2 + "cm²");

                    }

                    if (a == 3)
                    {
                        double raio, pi, Area3;
                        pi = Math.PI;

                        Console.WriteLine("\nDigite o raio. (em centimetros)");
                        raio = Convert.ToDouble(Console.ReadLine());

                        raio = Math.Pow(raio, 2);
                        Area3 = pi * raio;

                        Console.WriteLine("A Area do Circulo é " + Math.Round(Area3, 2) + "cm²");
                    }

                    if (a < 1 || a > 3)
                    {
                        Console.WriteLine("\nNumero fora da Escala Indicada");

                        goto case1;
                    }

                }

                if (c == 2)
                {
                    Console.WriteLine("===================================================");
                    Console.WriteLine("Que Tipo de Calculo quer Fazer?");
                    Console.WriteLine("1- Media Aritmética 2- Media Geométrica 3- Media Harmônica ");
                    Console.WriteLine("===================================================");
                    a = Convert.ToInt32(Console.ReadLine());

                    if (a == 1)
                    {
                        int i, Val;
                        double numero, soma, Media;
                        Console.WriteLine("Quantos Valores deseja na sua media?");
                        Val = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite " + Val + " os valores.");
                        soma = 0;
                        i = 0;
                        while (i < Val) {
                            numero = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Numero Escrito = " + numero);
                            i++;
                            soma = numero + soma;
                          }

                        Media = soma / Val;
                        Console.WriteLine("A Sua Media Aritmetica é " + Media);
                    }
                 

                    if (a == 2)
                    {
                        int i, Val;
                        double numero, soma, Media1, Raiz;
                        Console.WriteLine("Quantos Valores deseja na sua media?");
                        Val = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite " + Val + " os valores.");
                        i = 0;
                        soma = 1;
                        while (i < Val)
                        {
                            numero = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Numero Escrito = " + numero);
                            i++;
                            soma = numero * soma;
                        }
                        Raiz = 1.0 / Val;
                        Media1 = Math.Pow(soma,Raiz);
                        Console.WriteLine("A Media Geometrica é " + Media1);
                    }

                    if (a == 3)
                    {
                        int i, Val;
                        double numero, soma, media;
                        Console.WriteLine("Quantos Valores deseja na sua media?");
                        Val = Convert.ToInt32(Console.ReadLine());
                        i = 0;
                        soma = 0;
                        while (i < Val)
                        {
                            numero = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Numero Escrito = " + numero);
                            i++;
                            soma = (1 / numero) + (1 / soma);

                        }

                        media = Val * (soma);
                        Console.WriteLine("A Media Harmônica é " + media);
                    }



                }
                Console.WriteLine("\nQuer Fazer outro Calculo? \nPressione 1 caso deseja fazer outro calculo.");
                b = Convert.ToInt32(Console.ReadLine());
                if (b == 1)
                {
                    goto case1;
                }



            }
         }
    
    }
}

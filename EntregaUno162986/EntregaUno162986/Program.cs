﻿            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;
// Entrega 100
    namespace EntregaUno162986
    {
        public class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine("Que Funcion Te gustaria hacer en el programa? \n");
                Console.WriteLine("Opcion (no) Argumentos y Comprobacion ");
                Console.WriteLine("Opcion (Dos) Calculadora");
                string opciones = Console.ReadLine();
                switch (opciones)
                {

                    case "Uno":
                        string name = "Omar";
                        Console.WriteLine("Dinos Cual es tu nombre");
                        name = Console.ReadLine();
                        if (name == "Omar")
                        {
                            Console.WriteLine("Mi loco dale pa dentro");
                        }
                        else
                        {
                            Console.WriteLine("saquese no eres omar");
                        }
                        break;

                    case "Dos":
                   
                   int Valor1; int Valor2; int resultado;
                    int resultado1 = 0; int resultado2 = 0;
                    string continuar1 = null; string continuar2 = null;

                    do
                    {
                        Console.WriteLine("Ingrese el primer numero");
                        Valor1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Ingrese el segundo numero");
                        Valor2 = Convert.ToInt32(Console.ReadLine());
                       
                        Console.WriteLine("Ingrese una opcion en la calculadora");
                        Console.WriteLine("(+) para sumar");
                        Console.WriteLine("(-) para restar");
                        Console.WriteLine("(*) para Multiplicar");
                        Console.WriteLine("(S) para salir");
                        string opcion = Console.ReadLine();
                        switch (opcion)
                        {
                            case "+":
                                Console.WriteLine("el resultado de la suma es:");
                                resultado = Valor1 + Valor2;
                                Console.WriteLine("{0} + {1} = {2}", Valor1, Valor2, resultado);
                                Console.WriteLine("Desea Utilizar el resultado para una otra operacion? si/no");
                                continuar2 = Console.ReadLine();
                                _ = continuar2 == "si";
                                Console.WriteLine("El resultado anterior es:" + resultado + "\n");
                                Console.WriteLine("Agregue un nuevo dato para sumar");
                                resultado1 = Convert.ToInt32(Console.ReadLine());
                                resultado2 = resultado + resultado1;
                                Console.WriteLine("el resultado es:" + resultado2);
                                break;
                            case "-":
                                Console.WriteLine("el resultado de la resta es:");
                                resultado = Valor1 - Valor2;
                                Console.WriteLine("{0} - {1} = {2}", Valor1, Valor2, resultado);
                                Console.WriteLine("Desea Utilizar el resultado para una otra operacion? si/no");
                                continuar2 = Console.ReadLine();
                                _ = continuar2 == "si";
                                Console.WriteLine("El resultado anterior es:" + resultado + "\n");
                                Console.WriteLine("Agregue un nuevo dato para restar");
                                resultado1 = Convert.ToInt32(Console.ReadLine());
                                resultado2 = resultado - resultado1;
                                Console.WriteLine("el resultado es:" + resultado2);
                                break;
                            case "*":
                                Console.WriteLine("el resultado de la multiplicacion es:");
                                resultado = Valor1 * Valor2;
                                Console.WriteLine("{0} * {1} = {2}", Valor1, Valor2, resultado);
                                Console.WriteLine("Desea Utilizar el resultado para una otra operacion? si/no");
                                continuar2 = Console.ReadLine();
                                _ = continuar2 == "si";
                                Console.WriteLine("El resultado anterior es:" + resultado + "\n");
                                Console.WriteLine("Agregue un nuevo dato para multiplicar");
                                resultado1 = Convert.ToInt32(Console.ReadLine());
                                resultado2 = resultado * resultado1;
                                Console.WriteLine("el resultado es:" + resultado2);
                                break;
                            case "S":
                                Console.WriteLine("hasta la proxima");
                                Console.ReadKey();
                                break;
                        }
                        break;


                    } while (continuar1 == "Si" || continuar1 == "si");
                    Console.ReadKey();



                    break;
                  
                
                }

                Console.ReadKey();
            }
        }
    }


//Primer Ejercicio
using System;
					
public class Program
{
	    public void HolaEstudiante()
        {
            Console.WriteLine("Hola, estudiante Abel De La Cruz. Bienvenido a programación I ");
        }
 }

//Segundo Ejercicio 
using System;
					
public class Program
{
  public void num()
        {
            Console.WriteLine("Numeros del 1 al 50");
            Console.ReadLine();
            for (int i =1; i<51; i++)
            {
            
                Console.WriteLine(i);
              
            }
           
        }

        //Tercer Ejercicio
        static void Main(string[] args)
        {
            NumeroAleatoreo();
            Console.ReadLine();
        }
        static void NumeroAleatoreo()
        {
            int oportunidades = 6;
            int n, entrada, i, adivinado;

            // obtenemos un numero aleatorio entre 1 y 100
            Random ran = new Random();
            num = ran.Next(1, 101);
            i = 1; adivinado = 0;

            do
            {
                Console.Write("Adivina un numero entre 1 y 100: ");
                entrada = int.Parse(Console.ReadLine());
                if ((entrada == n))
                {
                    Console.WriteLine("Has adivinado el numero");
                    adivinado = 1;
                }
                else
                {
                    if ((entrada > n))
                    {
                        Console.WriteLine("Estas alto");
                    }
                    else
                    {
                        Console.WriteLine("Estas bajo");
                    }
                }
                i++;
            } while (((i <= oportunidades) & (adivinado == 0)));
            if ((adivinado == 0))
            {
                Console.Write("Has agotado los intentos... El numero fue: " + num);
            }
        }

    }
    // Cuarto Ejercicio 

public class Vehiculo
    {
        public Vehiculo() 
        {
            Marca = "";
            Modelo = "";
            año = 0;
            Color = "";
            encendido = false;

        }
        public string Marca;
        public string Modelo;
        public int año;
        public string Color;
        public Boolean encendido;
    }
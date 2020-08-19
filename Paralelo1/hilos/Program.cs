using System;
using System.Threading;
 
namespace Programacion.Hilos
{
    class Program
    {
        static void Main(string[] args)
			
        {
            var EContratista = new Contratista();  
            Thread hilo1 = new Thread(EContratista.ImprimeEnunciado);
            Thread hilo2 = new Thread(EContratista.ImprimeEnunciado);
             Console.WriteLine("ID Hilo: {0} => Se llama a la ejecución de los hilos desde el programa principal", Thread.CurrentThread.ManagedThreadId.ToString());
 
           
            hilo1.Start("Empresa: El 'Contratista tiene que firmar el documento");
            hilo2.Start("Persona:Enseguida preparo los documentos");
            
            while ((hilo1.IsAlive) || (hilo2.IsAlive)) // Se espera a que termine la ejecución de ambos hilos
            {
            }
 
            Console.WriteLine("ID Hilo: {0} => Contrato finalizado", Thread.CurrentThread.ManagedThreadId.ToString());
            Console.ReadLine();
        }
    }
 
    // Clase de apoyo que contiene la función que ejecutarán los hilos
    public class Contratista
    {
        public void ImprimeEnunciado(object texto)
        {
            
            Console.WriteLine("ID Hilo: {0} => {1}.", Thread.CurrentThread.ManagedThreadId.ToString(), texto.ToString());
        }
    }
}
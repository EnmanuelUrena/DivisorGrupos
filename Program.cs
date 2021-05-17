using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace DivisorGrupos
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader lectura, lectura1; 
            string linea, linea1;

            int CantEst = File.ReadAllLines(args[1]).Length; //Cantidad de Estudiantes
            int CantTemas = File.ReadAllLines(args[2]).Length; //Cantidad de temas
            int CantGrupos = 0;

            try                                                 //Try-Catch de cantidad de grupos
            {
                CantGrupos = int.Parse(args[0]);
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e);
            }
            
            Random rnd = new Random();
            string[] estudiantes = new string [CantEst];
            string[] temas = new string[CantTemas];
            string[,] grupos = new string[CantEst,CantTemas];

            try                                                 //Try-Catch del path de estudiantes
            {
            lectura = File.OpenText(args[1]);
            linea = lectura.ReadLine();
            for (int i = 0; i < CantEst; i++)
            {
                estudiantes[i] = linea;
                linea = lectura.ReadLine();
            }
            for (int i = estudiantes.Length - 1; i > 0; i--)
            {
                var j = rnd.Next(0, i);
                var temp = estudiantes[i];
                estudiantes[i] = estudiantes[j];
                estudiantes[j] = temp;
            }
    
            }
            catch(FileNotFoundException fe)
            {
                System.Console.WriteLine(fe);
            }

            try                                                 //Try-Catch del path de temas
            {
            lectura1 = File.OpenText(args[2]);
            linea1 = lectura1.ReadLine();
            for (int i = 0; i < CantTemas; i++)
            {
                temas[i] = linea1;
                linea1 = lectura1.ReadLine();
            }
            for (int i = temas.Length - 1; i > 0; i--)
            {
                var j = rnd.Next(0, i);
                var temp = temas[i];
                temas[i] = temas[j];
                temas[j] = temp;
            }
            }
            catch(FileNotFoundException fe)
            {
                System.Console.WriteLine(fe);
            }
            
            Console.ReadKey();
        }
    }
}


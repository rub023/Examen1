using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Geometria;

namespace Examen1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            FiguraGeometrica trian = new Geometria.Triangulo();
            ((Geometria.Triangulo)trian).CalcularArea();
            Console.WriteLine(
                ((Geometria.Triangulo)trian).mostrar()
                );
            FiguraGeometrica recta = new Geometria.Rectangulo();
            ((Geometria.Rectangulo)recta).CalcularArea();
            Console.WriteLine(
                ((Geometria.Rectangulo)recta).mostrar()
                );
            FiguraGeometrica paral = new Geometria.Paralelogramo();
            ((Geometria.Paralelogramo)paral).CalcularArea();
            Console.WriteLine(
                ((Geometria.Paralelogramo)paral).mostrar()
                );

        }
    }
}

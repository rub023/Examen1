using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen1;

namespace Examen1
{
    public interface Poligono
    {
       double Area(double valor1, double valor2);
    }
    public class Triangulo : Poligono
    {
        public double Area(double baseTriangulo, double altura)
        {
            // Fórmula para el área de un triángulo: (base * altura) / 2
            return (baseTriangulo * altura) / 2;
        }
    }
    public class Rectangulo : Poligono
    {
        public double Area(double lado1, double lado2)
        {
            // Fórmula para el área de un rectángulo: lado1 * lado2
            return lado1 * lado2;
        }
    }
    public class Paralelogramo : Poligono
    {
        public double Area(double baseParalelogramo, double altura)
        {
            // Fórmula para el área de un paralelogramo: base * altura
            return baseParalelogramo * altura;
        }
    }
}

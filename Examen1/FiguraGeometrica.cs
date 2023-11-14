using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Geometria
{
    public class FiguraGeometrica
    {
        protected string nombre { get; set; }
        protected double area { get; set; }
    }
  
    public class Triangulo: FiguraGeometrica
    {
        private double base_t, altura;
        public Triangulo()
        {
            nombre = "Triangulo";
            base_t = 10; altura = 6;
        }
        
        public void CalcularArea()
        {
            area = (base_t * altura)/2;
        }
        public  string mostrar()
        {
            return $"Figura: {nombre}, tiene un area de :{area}";
        }
    }
   
    public class Rectangulo : FiguraGeometrica
    {
        private double lado_x, lado_y;
        public Rectangulo()
        {
            nombre = "Triangulo";
            lado_x = 4; lado_y = 5;
        }

        public void CalcularArea()
        {
            area = lado_x * lado_y;
        }
        public string mostrar()
        {
            return $"Figura: {nombre}, tiene un area de :{area}";
        }
    }
    public class Paralelogramo : FiguraGeometrica
    {
        private double base_p, altura_p;
        public Paralelogramo()
        {
            nombre = "Paralelogramo";
            base_p = 10; altura_p = 8;
        }

        public void CalcularArea()
        {
            area = base_p * altura_p;
        }
        public string mostrar()
        {
            return $"Figura: {nombre}, tiene un area de :{area}";
        }
    }
   
}

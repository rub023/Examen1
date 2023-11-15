using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Geometria;

namespace Examen1
{
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();
        }
        string rectanguloa = "";
        string trianguloa = "";
        string paralelogramoa = "";
        private Stack<string> miPila = new Stack<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            int cant = miPila.Count;
            miPila.Push(rectanguloa);

            Console.WriteLine(string.Join(", ", miPila));
            label8.Text = "Elementos en la pila:\n";

            Stack<string> aux = new Stack<string>();
            foreach (string elemento in miPila)
            {
                label8.Text += elemento + "\n";
                aux.Push(elemento);
            }

            label8.Text += "Cantidad de elementos: " + miPila.Count;
        }

        private void btbAreaT_Click(object sender, EventArgs e)
        {

            double baseTriangulo, altura;
            trianguloa = "Triangulo";
            if (double.TryParse(txtBaseT.Text, out baseTriangulo) && double.TryParse(txtAlturaT.Text, out altura))
            {
                Triangulo triangulo = new Triangulo();
                double area = triangulo.Area(baseTriangulo, altura);
               
                lblTriangulo.Text = $"Área calculada del Triangulo es : {area}";
            }
            else
            {
                lblTriangulo.Text = "Ingrese  numéros en el TextBox.";
            }
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

            //Mostrará en la consola
            FiguraGeometrica trian = new Geometria.Triangulo();
            ((Geometria.Triangulo)trian).CalcularArea();
            Console.WriteLine(
                ((Geometria.Triangulo)trian).mostrar()
                );
            FiguraGeometrica rect = new Geometria.Rectangulo();
            ((Geometria.Rectangulo)rect).CalcularArea();
            Console.WriteLine(
                ((Geometria.Rectangulo)rect).mostrar()
                );
            FiguraGeometrica parale = new Geometria.Paralelogramo();
            ((Geometria.Paralelogramo)parale).CalcularArea();
            Console.WriteLine(
                ((Geometria.Paralelogramo)parale).mostrar()
                );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double Lada_A, Lado_B;
            rectanguloa = "Rectangulo";
            if (double.TryParse(textBox4.Text, out Lada_A) && double.TryParse(textBox3.Text, out Lado_B))
            {
                Rectangulo rectangulo = new Rectangulo();
                double area = rectangulo.Area(Lada_A, Lado_B);              
                label3.Text = $"Área calculada del rectangulo es  : {area}";
            }
            else
            {
                label3.Text = "Ingrese  numéros en el TextBox.";
            }
        }

        private void btbAreaP_Click(object sender, EventArgs e)
        {
            double baseP, alturaP;
            paralelogramoa = "Paralelogramo";
            if (double.TryParse(txtBaseP.Text, out baseP) && double.TryParse(txtAlturaP.Text, out alturaP))
            {
                Paralelogramo paralelogramo = new Paralelogramo();
                double area = paralelogramo.Area(baseP, alturaP);

                label4.Text = $"Área calculada del Paralelogramo es : {area}";
            }
            else
            {
                label4.Text = "Ingrese  numéros en el TextBox.";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pilas();
        }
        private void Pilas()
        {
            Stack<string> miPila = new Stack<string>();
            //Métodos propios de la pila (en C#)
            int cant = miPila.Count;
            miPila.Push(rectanguloa);
            miPila.Push(trianguloa);
            miPila.Push(paralelogramoa);
            Console.WriteLine(miPila);           
            Stack<string> aux = new Stack<string>();
            while (miPila.Count > 0)
            {

                string elemento = miPila.Pop();
                label9.Text += "\n" + elemento;
                aux.Push(elemento);
            }
            while (aux.Count > 0)
            {
                miPila.Push(aux.Pop());

            }
            label9.Text += "\nElemento de cima: " + miPila.Peek();
            //label9.Text += "\nCantidad de elementos: " + miPila.Count;
        }

        private void btbAgregaT_Click(object sender, EventArgs e)
        {
            int cant = miPila.Count;
            miPila.Push(trianguloa);

            Console.WriteLine(string.Join(", ", miPila));

            // Limpiar label antes de mostrar los elementos
            label8.Text = "Elementos en la pila:\n";

            Stack<string> aux = new Stack<string>();
            foreach (string elemento in miPila)
            {
                label8.Text += elemento + "\n";
                aux.Push(elemento);
            }

            // Actualizar la cantidad de elementos
            label8.Text += "Cantidad de elementos: " + miPila.Count;
        }

        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            int cant = miPila.Count;
            miPila.Push(paralelogramoa);

            Console.WriteLine(string.Join(", ", miPila));

            label8.Text = "Elementos en la pila:\n";

            Stack<string> aux = new Stack<string>();
            foreach (string elemento in miPila)
            {
                label8.Text += elemento + "\n";
                aux.Push(elemento);
            }

            label8.Text += "Cantidad de elementos: " + miPila.Count;
        }
    }
}

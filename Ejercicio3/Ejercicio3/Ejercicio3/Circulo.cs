using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Circulo
    {
        private float PI = 3.14f;
        private float radio;

        public Circulo(float r)
        {
            this.Radio = r;
        }
        public float Radio { get => radio; set => radio = value; }
        public float calcularArea()
        {
            float area = PI * (Radio * Radio);
            return (area);
        }
        public float calcularPerimetro()
        {
            float perimetro = 2 * PI * radio;
            return (perimetro);
        }

    }
}

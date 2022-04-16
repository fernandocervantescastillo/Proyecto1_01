using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System.Drawing;

namespace Proyecto1
{
    public class Casa
    {
        private float ancho;
        private float alto;
        private float profundidad;
        public Punto origen;
        private Cubo cubo;
        private Techo techo;

        public Casa(Punto p, float ancho, float alto, float profundidad)
        {
            origen = new Punto(p);
            this.ancho = ancho;
            this.alto = alto;
            this.profundidad = profundidad;

            cubo = new Cubo(p, ancho, alto * 0.6f, profundidad);
            p.y = p.y + alto;
            techo = new Techo(p, ancho, alto * 0.4f, profundidad);
        }

        public void Dibujar()
        {
            GL.Rotate(20, 1, 1, 0);
            cubo.Dibujar();
            techo.Dibujar();
        }
    }
}

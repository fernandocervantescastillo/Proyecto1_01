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
    public class Techo
    {
        private float ancho;
        private float alto;
        private float profundidad;
        public Punto origen;

        public Techo(Punto p, float ancho, float alto, float profundidad)
        {
            origen = new Punto(p);
            this.ancho = ancho;
            this.alto = alto;
            this.profundidad = profundidad;
        }

        public void Dibujar()
        {
            //PrimitiveType primitiveType = PrimitiveType.LineLoop;
            PrimitiveType primitiveType = PrimitiveType.Quads;
            back(primitiveType);  //rosado
            front(primitiveType);  //verde
            base1(primitiveType); //azul

            primitiveType = PrimitiveType.Triangles;
            left(primitiveType);   //rojo
            right(primitiveType);  //amarillo
        }

        private void right(PrimitiveType primitiveType)
        {
            //GL.Color4(Color.Aqua);
            GL.Begin(primitiveType);
            GL.Color3(0.0, 0.0, 1.0);//azul;
            GL.Vertex3(origen.x + ancho, origen.y + alto, origen.z);
            GL.Vertex3(origen.x + ancho, origen.y - alto, origen.z + profundidad);
            GL.Vertex3(origen.x + ancho, origen.y - alto, origen.z - profundidad);
            GL.End();
        }

        private void left(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(1.0, 1.0, 0.0);//amarillo
            GL.Vertex3(origen.x - ancho, origen.y + alto, origen.z);
            GL.Vertex3(origen.x - ancho, origen.y - alto, origen.z + profundidad);
            GL.Vertex3(origen.x - ancho, origen.y - alto, origen.z - profundidad);
            GL.End();
        }

        private void front(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(1, 0.0, 0.0);//rojo
            GL.Vertex3(origen.x - ancho, origen.y + alto, origen.z);
            GL.Vertex3(origen.x + ancho, origen.y + alto, origen.z);
            GL.Vertex3(origen.x + ancho, origen.y - alto, origen.z + profundidad);
            GL.Vertex3(origen.x - ancho, origen.y - alto, origen.z + profundidad);
            GL.End();
        }

        private void back(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(0.0, 1.0, 0.0);//verde
            GL.Vertex3(origen.x - ancho, origen.y + alto, origen.z);
            GL.Vertex3(origen.x + ancho, origen.y + alto, origen.z);
            GL.Vertex3(origen.x + ancho, origen.y - alto, origen.z - profundidad);
            GL.Vertex3(origen.x - ancho, origen.y - alto, origen.z - profundidad);
            GL.End();
        }

        private void base1(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(1, 0.2, 1);//rosado
            GL.Vertex3(origen.x - ancho, origen.y - alto, origen.z - profundidad);
            GL.Vertex3(origen.x + ancho, origen.y - alto, origen.z - profundidad);
            GL.Vertex3(origen.x + ancho, origen.y - alto, origen.z + profundidad);
            GL.Vertex3(origen.x - ancho, origen.y - alto, origen.z + profundidad);
            GL.End();
        }

    }
}

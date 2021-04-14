using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawingToolFactory<Pen>.FactoryMethod().Draw();

            DrawingToolFactory<Pencil>.FactoryMethod().Write();

            DrawingToolFactory<Marker>.FactoryMethod().Draw();

            Console.ReadKey();
        }
    }

    abstract class DrawingTool
    {
        public abstract void Draw();
        public abstract void Write();
    }

    class Pen : DrawingTool
    {
        public override void Draw()
        {
            Console.WriteLine("I'm a PEN and I'm drawing");
        }
        public override void Write()
        {
            Console.WriteLine("I'm a PEN and I'm writing");
        }
    }

    class Pencil : DrawingTool
    {
        public override void Draw()
        {
            Console.WriteLine("I'm a PENCIL and I'm drawing");
        }
        public override void Write()
        {
            Console.WriteLine("I'm a PENCIL and I'm writing");
        }
    }

    class Marker : DrawingTool
    {
        public override void Draw()
        {
            Console.WriteLine("I'm a MARKER and I'm drawing");
        }
        public override void Write()
        {
            Console.WriteLine("I'm a MARKER and I'm writing");
        }
    }

    static class DrawingToolFactory<T> where T : DrawingTool, new()
    {
        public static DrawingTool FactoryMethod()
        {
            return new T();
        }
    }
}

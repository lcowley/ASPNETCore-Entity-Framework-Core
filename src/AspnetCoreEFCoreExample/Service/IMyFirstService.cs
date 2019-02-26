using AspnetCoreEFCoreExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCoreEFCoreExample.Service
{
    public interface IMyFirstService
    {
        void RemoveSomething(IRemovable removable);
        IEnumerable<MyModel> GetModels();
    }

    public interface IRemovable
    {
        void Remove();
    }
    public class RemovableSomething : IRemovable, IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Remove()
        {
            //throw new NotImplementedException();
            var list = new List<int>();
            Test(list);
        }
        public void Test(IEnumerable<int> ints)
        {
            throw new NotImplementedException();
        }

    }
    public class RemovableOtherThing : IRemovable
    {
        public void Remove()
        {
            IEnumerable<IShape> shapes = new List<IShape>
            {
                new Triangle(1,2),
                new Square(1)
            };
            foreach(var shape in shapes)
            {
                Console.WriteLine(shape.GetArea());
            }

        }
    }


    public interface IShape
    {
        int GetArea();
    }

    public class Triangle : IShape
    {
        private int _height;
        private int _width;
        public Triangle(int h, int w)
        {
            _height = h;
            _width = w;
        }

        public int GetArea()
        {
            return (int)(0.5 * _height * _width);
        }

        public void Test()
        {
            throw new NotImplementedException();
        }
    }

    public class Square : IShape
    {
        private int _length;
        public Square(int length)
        {
            _length = length;
        }

        public int GetArea()
        {
            return _length * _length;
        }
    }
}

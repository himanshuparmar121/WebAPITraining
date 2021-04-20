using System.Collections.Generic;

namespace WebAPITraining.IServices
{
    public interface IPerimeterServices 
    {
        public int Perimeter(int side);
        public int Perimeter(int length, int breath);
    }
}
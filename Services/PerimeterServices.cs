using WebAPITraining.IServices;

namespace WebAPITraining.Services 
{
    public class PerimeterServices : IPerimeterServices
    {
        public int Perimeter(int side) 
        {
            return side*side;
        }

        public int Perimeter(int length, int breath) 
        {
            return 2*(length+breath);
        }
    }
}
using WebAPITraining.IServices;

namespace WebAPITraining.Services
{
    public class AreaServices : IAreaServices
    {
        public int Area(int side)
        {
            return side*side;
        }

        public int Area(int length, int breath) 
        {
            return length*breath;
        }
    }
}
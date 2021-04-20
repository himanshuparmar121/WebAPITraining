using System.Collections.Generic;
using WebAPITraining.Models;

namespace WebAPITraining.IServices
{
    public interface IAreaServices 
    {
        public int Area(int side);
        public int Area(int length, int breath);
    }
}
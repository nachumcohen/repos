using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    
    internal class MovieRecord
    {
        static public int SumWaching = 1;
        string NameMovie;
        string GenerMovie;
        int YearOfPubliction;
        string TimeWach;
        float Rating = 0;

        public MovieRecord(string nameMovie, string generMovie, int yearOfPubliction, string timeWach)
        {
           
            NameMovie = nameMovie;
            GenerMovie = generMovie;
            YearOfPubliction = yearOfPubliction;
            TimeWach = timeWach;
        }

        public void PlayMovie()
        {
            SumWaching = SumWaching++;
        }

        public float SumRating(float rating)
        {
            Rating = rating / SumWaching;
            return Rating;
            
        }
       

    }
}

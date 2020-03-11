using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Week_4_code_along
{
    class Movie
    {
        public string Title { get; set; }
        public int ReleaseYear { get; set; }

        public decimal Score { get; set; }




        public Movie (string myTitle, int myReleaseYear, decimal myScore)
        {
            this.Title = myTitle;
            this.ReleaseYear = myReleaseYear;
            this.Score = myScore;
        }

        public void ShowDetails()
        {
            string info = "Title: " + this.Title;
            info += "\nRelease Year: " + this.ReleaseYear;
            info += "Rotten Tomatoes Score: " + this.Score;
            MessageBox.Show(info);

        }
    }
}

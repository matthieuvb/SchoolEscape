using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolEsc.Controller
{
    class ScoreData
    {
        public static void VerhoogScore()
        {
            string text = File.ReadAllText(@"..\..\Controller\ScoreData.txt");
            int tempScore = Convert.ToInt32(getScore());
            tempScore = tempScore + 3;
            string WritableScore = tempScore.ToString();
            text = text.Replace(getScore(), WritableScore);
            File.WriteAllText(@"..\..\Controller\ScoreData.txt", text);


        }

        public static void VerlaagScore()
        {
            string text = File.ReadAllText(@"..\..\Controller\ScoreData.txt");
            int tempScore = Convert.ToInt32(getScore());
            tempScore = tempScore - 3;
            string WritableScore = tempScore.ToString();
            text = text.Replace(getScore(), WritableScore);
            File.WriteAllText(@"..\..\Controller\ScoreData.txt", text);
        }

        public static string getScore()
        {
            return System.IO.File.ReadAllText(@"..\..\Controller\ScoreData.txt");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeForXmenBattleCount
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //arrays
            string[] names = new string[] {"X", "iceman", "angel", "beast", "phoenix", "cyclops", "wolverine", "nightcrawler", "rogue", "storm"};
            int[] numbers = new int[] {7, 9, 12, 15, 17, 13, 2, 6, 8, 13};

            //initialize variables
            string result = "";

            int largestNumberIndex = 0;
            int smallestNumberIndex = 0;

            //loop iteration logic 
            for (int i = 0; i < names.Length; i++)
            {
                //check for largest
                if (numbers[i] > numbers[largestNumberIndex])
                {
                    largestNumberIndex = i;
                }
                //check for smallest
                if (numbers[i] < numbers[smallestNumberIndex])
                {
                    smallestNumberIndex = i;
                }
            }
            //format variables into strings for lable using their indeces
            result = String.Format("Most battles belong to: {0} (Value: {1})", names[largestNumberIndex], numbers[largestNumberIndex]);
            result += String.Format("<br/>Least battles belong to: {0} (Value: {1})", names[smallestNumberIndex], numbers[smallestNumberIndex]);

            //print out results
            Label1.Text = result;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuckySpin.Models
{
    public class TextTransformService
    {

        public string numberToText(int a)
        {

            int caseCheck = a;
            string numText;
            switch (caseCheck)
            {
                case 1:
                    numText = "One";
                    break;
                case 2:
                    numText = "Two";
                    break;
                case 3:
                    numText = "Three";
                    break;
                case 4:
                    numText = "Four";
                    break;
                case 5:
                    numText = "Five";
                    break;
                case 6:
                    numText = "Six";
                    break;
                case 7:
                    numText = "Seven";
                    break;
                case 8:
                    numText = "Eight"; 
                    break;
                case 9:
                    numText = "Nine";
                    break;
                default:
                    numText = "Number";
                    break;
            }

            return numText;
        }

}
}

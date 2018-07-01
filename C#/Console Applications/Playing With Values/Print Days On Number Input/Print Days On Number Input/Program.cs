
/*
 * ############################################################################
 * ############################################################################
 * 
 *              WAP an Integer between 1 to 7 and Print 
 *            Days using Switch case and If-Else-If Ladder.
 * 
 * ############################################################################
 * ############################################################################
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Days_On_Number_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter a Positive Integer between 1 to 7 : ");
            int num = Convert.ToInt32(Console.ReadLine());
          
            // Displaying the Day of the Week using Switch Case in a different Class
            Console.WriteLine("\n -> Using Switch Case...");
            UsingSwitchCase objSwitch = new UsingSwitchCase();
            objSwitch.CaseChange(num);

            // Displaying the Day of the Week using IF-Else-If Ladder in a different Class
            Console.WriteLine("\n -> Using If-Else_If Ladder...");
            UsingIf_Else_If objIf = new UsingIf_Else_If();
            objIf.ConditionalLadder(num);

            Console.ReadLine();
        }
    }

    class UsingSwitchCase
    {
        public void CaseChange(int a)
        {
            switch(a)
            {
                case 1:
                    Console.WriteLine("\n My God. It's Monday Again.");
                    break;

                case 2:
                    Console.WriteLine("\n It's Tuesday.");
                    break;

                case 3:
                    Console.WriteLine("\n It's Fine. It's Just another Mid-Week Wednesday.");
                    break;

                case 4:
                    Console.WriteLine("\n Ok. Going on to Thursday.");
                    break;

                case 5:
                    Console.WriteLine("\n Oh Friday's here. Great!");
                    break;

                case 6:
                    Console.WriteLine("\n Party Time. It's Saturday.");
                    break;

                case 7:
                    Console.WriteLine("\n Should I enjoy this Sunday or should I worry about Monday coming again ?");
                    break;

                default:
                    Console.WriteLine("\n Input Out of Bounds.");
                    break;
            }
        }
    }

    class UsingIf_Else_If
    {
        public void ConditionalLadder(int a)
        {
            if (a == 1)
                Console.WriteLine("\n My God. It's Monday Again.");
            else if (a == 2)
                Console.WriteLine("\n It's Tuesday.");
            else if (a == 3)
                Console.WriteLine("\n It's Fine. It's Just another Mid-Week Wednesday.");
            else if (a == 4)
                Console.WriteLine("\n Ok. Going on to Thursday.");
            else if (a == 5)
                Console.WriteLine("\n Oh Friday's here. Great!");
            else if (a == 6)
                Console.WriteLine("\n Party Time. It's Saturday.");
            else if (a == 7)
                Console.WriteLine("\n Should I enjoy this Sunday or should I worry about Monday coming again ?");
            else
                Console.WriteLine("\n Input Out of Bounds.");
        }
    }
}

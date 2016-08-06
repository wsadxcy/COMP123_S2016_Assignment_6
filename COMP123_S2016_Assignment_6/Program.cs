using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Author : Chenyuan Xie
 * Date : Aug 5th, 2016
 * Date Modified: Aug 5th, 2016
 * Description : Assignment 6
 * Version : 0.3 - 
 *                  Added most functions
 */
namespace COMP123_S2016_Assignment_6
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BMI_Calculator()); 
        }
    }
}

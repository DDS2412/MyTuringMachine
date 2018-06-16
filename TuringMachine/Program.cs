using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuringMachine
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
            var d =  new Form1();
            
            Application.Run();
            Map.Init
                (
                new[] {
                    cell11, cell12, cell13, cell14,
                    cell21, cell22, cell23, cell24,
                    cell31, cell32, cell33, cell34,
                    cell41, cell42, cell43, cell44,
                }
                );
        }
    }
}

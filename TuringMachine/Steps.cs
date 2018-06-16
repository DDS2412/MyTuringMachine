using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuringMachine
{
    class Steps
    {
        private int value;
        private char offset;
        private char[2] 

        private int currentPos;
        private string currentStatus;
        private List<int> steps;
        private static Steps instance;
        private TextBox[] map;

        private Steps()
        {
            map = Map.Instance.AllControlComponents;
        }

        public static Steps Instance
        {
            get
            {
                if (instance == null)
                    instance = new Steps();
                return instance;
            }
        }

        public static void Clear() => instance = null;

        public string[] RunAll(int iteration)
        {
            List<string> iterationInfo = new List<string>();
            currentPos = 0;
            currentStatus = map[currentPos].Text;

            for(int i = 0; i< iteration; i++)
            {
                iterationInfo.Add();
            }

            return iterationInfo.ToArray();
        }

        public void ExecuteIteranion()
        {

        }
    }
}

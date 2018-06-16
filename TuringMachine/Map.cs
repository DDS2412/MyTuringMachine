using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuringMachine
{
    class Map
    {
        private static Map instance;

        private Map(TextBox[] textBoxes)
        {
            AllControlComponents = textBoxes;
        }

        internal static Map Init(TextBox[] textBoxes)
        {
                if (instance == null)
                    instance = new Map(textBoxes);
                return instance;
        }

        public static Map Instance
        {
            get { return instance; }
        }

        public TextBox[] AllControlComponents { get; }
    }
}

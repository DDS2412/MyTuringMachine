using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuringMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ALLButton_Click(object sender, EventArgs e)
        {
            IterationList.Items.Clear();
            var steps = Steps.Instance;
            var iteranionInfo = steps.RunAll((int)NumberIteration.Value);
            FillIterationList(iteranionInfo);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {

        }

        private void cell_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            var b = Map.Instance.AllControlComponents.First(n => n.Name == textBox.Name);
            Console.WriteLine(b.Text);
            Steps.Clear();
        }

        private void FillIterationList(string[] iteranionInfo)
        {
            IterationList.Items.AddRange(iteranionInfo);
        }
    }
}

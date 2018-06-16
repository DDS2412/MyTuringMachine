using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfTuringMachine.Model
{
    public class Process : INotifyPropertyChanged
    {
        private Dictionary<string, int> ValueQ = new Dictionary<string, int>()
        {
            { "q0", -1 },
            { "q1", 0},
            { "q2", 1 },
            { "q3", 2 },
            { "q4", 3 }
        };
        private Dictionary<char, int> Value = new Dictionary<char, int>()
        {
            {'S', 0 },
            {'0', 1 },
            {'1', 2 },
            {'2', 3 },
            {'3', 4 }
        };
        private Dictionary<char, int> Moving = new Dictionary<char, int>()
        {
            {'R', 1 },
            {'C', 0 },
            {'L', -1 }
        };
        private StringBuilder firstIteration;
        private List<string[]> testMatrix = new List<string[]>
        {
            new[]
            {
                "q01L", "q31R", "q12R", "q30R",
                "q02C", "q22R", "q10R", "q21R",
                "q00R", "q22L", "q32C", "q12L"
            },
            new[]
            {
                "q01L", "q31R", "q12R", "q30R",
                "q02C", "q22R", "q10R", "q21R",
                "q00R", "q22L", "q32C", "q12L"
            },
            new[]
            {
                "q01L", "q31R", "q12R", "q30R",
                "q22C", "q22R", "q10R", "q21R",
                "q00R", "q22L", "q32C", "q12L"
            },
            new[]
            {
                "q01L", "q31R", "q12R", "q30R",
                "q20L", "q22R", "q10R", "q21R",
                "q00R", "q22L", "q32C", "q12L"
            }
        };
        private List<string> testsFirstWord = new List<string>()
        {
            "001122110",
            "012012012",
            "001122110",
            "001122110"
        };
        private int currentPos;

        public event PropertyChangedEventHandler PropertyChanged;

        public int CurrentPos { get; set; }
        public string CurrentQ { get; set; }
        public int Iteration { get; set; }
        public string[] Cells { get; set; }

        public StringBuilder ResaultIteration { get; private set; }

        public bool IsEnd => ValueQ[CurrentQ] == -1 ? true : false;

        public string FirstIteration
        {
            get
            {
                return firstIteration.ToString();
            }
            set
            {
                firstIteration = new StringBuilder(value);
                OnPropertyChanged("FirstIteration");
            }
        }
        
        public Process()
        {
            firstIteration = new StringBuilder("001122110");
            Reset();
            Cells = new string[16];
            InitMatrix(0);
        }

        public void MakeIter()
        {
            Expand();

            var r = Value[ResaultIteration[currentPos]] * 1 + ValueQ[CurrentQ] * 4;
            var nextStep = Cells[r];
            CurrentQ = $"{nextStep[0]}{nextStep[1]}";
            ResaultIteration[currentPos] = nextStep[2];
            currentPos = currentPos + Moving[nextStep[3]];
            CurrentPos = CurrentPos + Moving[nextStep[3]];

            Iteration++;
        }
        
        public void Reset()
        {
            try
            {
                Iteration = 0;
                AddS();
                ResaultIteration = new StringBuilder(FirstIteration);
                CurrentQ = "q1";
                CurrentPos = 1;
                currentPos = 1;
            }
            catch { }
        }

        private void Expand()
        {
            if (ResaultIteration[currentPos] == 'S' && currentPos != 0)
            {
                ResaultIteration.Append('S');
            }
            else if (ResaultIteration[currentPos] == 'S' && currentPos == 0)
            {
                ResaultIteration.Insert(0, 'S');
                currentPos = 1;
            }
        }

        private void AddS()
        {
            if(firstIteration[0] != 'S' 
                && firstIteration[firstIteration.Length - 1] != 'S')
            {
                firstIteration.Append('S');
                firstIteration.Insert(0, 'S');
            }
        }

        public void SetTest(int selectedIndex)
        {
            FirstIteration = testsFirstWord[selectedIndex];
            InitMatrix(selectedIndex);
            Reset();
        }

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        private void InitMatrix(int matrixSet)
        {
            for (int i = 0; i < testMatrix[matrixSet].Length; i++)
                Cells[i] = testMatrix[matrixSet][i];
        }
    }
}

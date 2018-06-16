using System;
using System.Collections.Generic;
using WpfTuringMachine.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfTuringMachine.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private Process currentProcess;

        public event PropertyChangedEventHandler PropertyChanged;

        public int CountOfIteration { get; set; }

        public bool IsEnd => currentProcess.IsEnd;
        private int CurrentIteration => currentProcess.Iteration;

        public string[] Matrix
        {
            get { return currentProcess.Cells; }
            set { currentProcess.Cells = value; }
        }

        public string FirstIteration
        {
            get { return $"{currentProcess.FirstIteration.Trim('S')}"; }
            set
            {
                currentProcess.FirstIteration = value;
                currentProcess.Reset();
                OnPropertyChanged("FirstIteration");
            }
        }

        public string ResaultIteration
        {
            get {
                return $"\t{CurrentIteration}.\tS0{currentProcess.ResaultIteration.ToString().Trim('S')}S0\t\t" +
                    $"{currentProcess.CurrentQ}\t\tpos: {currentProcess.CurrentPos}" ;
            }
        }

        public MainWindowViewModel()
        {
            CountOfIteration = 1000;
            currentProcess = new Process();
            currentProcess.PropertyChanged += CurrentProcess_PropertyChanged; ;
        }

        public string[] StartAll()
        {
            var resault = new List<string>();
            currentProcess.Reset();
            for (int i = 0; i < CountOfIteration; i++)
            {
                if (IsEnd)
                {
                    resault.Add("Конец");
                    break;
                }
                    
                StartNext();
                resault.Add(ResaultIteration);
            }
            return resault.ToArray();
        }

        public void Test()
        {
            try
            {
                if (CurrentIteration == 0)
                {
                    for(int i = 0; i < CountOfIteration; i++)
                    {
                        if (IsEnd)
                            break;
                        StartNext();
                    }
                    Reset();
                }
            }
            catch
            {
                Reset();
                throw new NotImplementedException();
            }
        }

        public void StartNext() => currentProcess.MakeIter();

        public void Reset() => currentProcess.Reset();
        
        public void SetTest(int selectedIndex) => currentProcess.SetTest(selectedIndex);

        private void CurrentProcess_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            OnPropertyChanged("");
        }

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

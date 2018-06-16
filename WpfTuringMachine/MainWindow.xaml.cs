using System.Windows;
using System.Windows.Controls;
using WpfTuringMachine.ViewModel;

namespace WpfTuringMachine
{
    public partial class MainWindow : Window
    {
        private TextBox[] cells;
        private bool isNotInit;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
            isNotInit = false;
            cells = new TextBox[]
            {
                cell11, cell12, cell13, cell14,
                cell21, cell22, cell23, cell24,
                cell31, cell32, cell33, cell34,
                cell41, cell42, cell43, cell44
            };
            UpdateCells();
        }

        private void All_Click(object sender, RoutedEventArgs e)
        {
            var context = ((MainWindowViewModel)DataContext);
            ErrorField.Visibility = Visibility.Hidden;
            IterationListView.Items.Clear();
            try
            {
                var resault = context.StartAll();
                UpdateListIteration(resault);
            }
            catch
            {
                IterationListView.Items.Clear();
                ErrorField.Visibility = Visibility.Visible;
                context.Reset();
            }
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            var context = ((MainWindowViewModel)DataContext);
            ErrorField.Visibility = Visibility.Hidden;
            try
            {
                if (!context.IsEnd)
                {
                    context.Test();
                    context.StartNext();
                    IterationListView.Items.Add(context.ResaultIteration);
                }
                else
                {
                    IterationListView.Items.Add("Конец");
                }
            }
            catch
            {
                IterationListView.Items.Clear();
                ErrorField.Visibility = Visibility.Visible;
            }

        }

        private void UpdateMatrix()
        {
            var context = (MainWindowViewModel)DataContext;
            for (int i = 0; i < cells.Length; i++)
            {
                context.Matrix[i] = cells[i].Text;
            }
        }

        private void UpdateCells()
        {
            var context = ((MainWindowViewModel)DataContext).Matrix;
            for (int i = 0; i < cells.Length; i++)
            {
                cells[i].Text = context[i];
            }
            isNotInit = true;
        }

        private void UpdateListIteration(string[] resault)
        {
            foreach (var line in resault)
                IterationListView.Items.Add(line);
        }

        private void Cell_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isNotInit)
            {
                UpdateMatrix();
                ((MainWindowViewModel)DataContext).Reset();
                IterationListView.Items.Clear();
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (isNotInit)
            {
                IterationListView.Items.Clear();
                var comboBox = (ComboBox)sender;
                var context = (MainWindowViewModel)DataContext;
                context.SetTest(comboBox.SelectedIndex);
                UpdateCells();
            }
        }   
    }
}

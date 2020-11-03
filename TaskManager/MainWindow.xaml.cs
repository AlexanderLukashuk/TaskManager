using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace TaskManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //DataContext = new ViewModel();

            //var processes = new ProcessManager();
            //processesGrid.DataContext = processes;
            int index = 0;
            //processesGrid.Items.Add(processes);
            /*foreach (var process in processes.processes)
            {
                //processesGrid.Items.Add(process);
                //processesGrid.Items.Add(process.ProcessName.ToString());
                processesGrid.Items.Add(process);
                processesGrid.Name.Insert(index, process.ProcessName);
                index++;
            }*/
            foreach (var proc in Process.GetProcesses())
            {
                processesGrid.Items.Add(proc);
            }
        }
    }
}

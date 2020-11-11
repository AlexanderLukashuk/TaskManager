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
using System.Data;

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

            foreach (var proc in Process.GetProcesses())
            {
                procListView.Items.Add(proc);
            }

        }

        private void AbortProcess(object sender, RoutedEventArgs e)
        {
            Process process = (Process)procListView.SelectedItem;
            process.Kill();

            Task tastk = Task.Run(() =>
            {
                Dispatcher.Invoke(() =>
                {
                    procListView.Items.Clear();

                    foreach (var proc in Process.GetProcesses())
                    {
                        procListView.Items.Add(proc);
                    }

                });
            });
        }

        private void procListView_MouseEnter(object sender, MouseEventArgs e)
        {

        }
    }
}

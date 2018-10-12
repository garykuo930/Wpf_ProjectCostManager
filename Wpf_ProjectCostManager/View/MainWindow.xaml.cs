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
using Wpf_ProjectCostManager.ViewModel;

namespace Wpf_ProjectCostManager
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenProject(object sender, MouseEventArgs e)
        {
            Project p = sender as Project;
            ClsProjects project = p.Tag as ClsProjects;
            Window_ProjectDetails w = new Window_ProjectDetails();
            w.ProjectID = project.ProjectID;
            w.ProjectName = project.ProjectName;
            w.ProgressByTasks = p.progressBar.Value;
            w.RequiredDepartment = project.RequiredDepartment;
            w.TotalCost = project.Budget;
            w.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<ClsProjects> projects = new ClsPageViewModel().Projects;

            foreach (var i in projects)
            {
                Project P = new Project();
                P.ProjectID = i.ProjectID;
                P.ProjectName = i.ProjectName;
                P.progressBar.Value = Convert.ToDouble((DateTime.Now.Ticks - i.StartDate.Ticks)) / Convert.ToDouble((i.EndDate.Ticks - i.StartDate.Ticks)) * 100;
                P.Height = 165;
                P.Width = 158;
                P.Tag = i;
                P.Margin = new Thickness(5);
                P.Click += OpenProject;
                this.wrapPanel.Children.Add(P);
            }
        }
    }
}

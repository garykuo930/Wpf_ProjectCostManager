using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_ProjectCostManager.ViewModel
{
    class ClsPageViewModel : INotifyPropertyChanged
    {
        public List<SeriesData> Series { get; set; }
        public List<ClsProjects> Projects { get; set; }
        public List<ClsCost> AllCosts { get; set; }
        public List<ClsCost> Costs { get; set; }
        public List<ClsTaskResource> TaskResources { get; set; }
        public List<ClsResources> Resources { get; set; }

        public double TotalInput;

        public ClsPageViewModel()
        {
            Projects = new List<ClsProjects>();

            Projects.Add(new ClsProjects { ProjectID = "A10001", ProjectName = "發票管理系統", Budget = 50000, Category = "A", RequiredHours = 100, StartDate = DateTime.Now.AddDays(-20), EndDate = DateTime.Now.AddDays(10), RequiredDepartment = "財務部"});
            Projects.Add(new ClsProjects { ProjectID = "B10002", ProjectName = "生產管理系統", Budget = 700000, Category = "B", RequiredHours = 100, StartDate = DateTime.Now.AddDays(-20), EndDate = DateTime.Now.AddDays(100), RequiredDepartment = "資材部" });

            Resources = new List<ClsResources>();

            Resources.Add(new ClsResources { ResourceID = 1, ResourceName = "文具", Category = "辦公室費用" });

            TaskResources = new List<ClsTaskResource>();

            TaskResources.Add(new ClsTaskResource { TaskID = "A10001", ResourceID = 1, Unit = "個", Quantity = 10, UnitPrice = 20, Date = new DateTime(2018,10,15) });
        }

        public ClsPageViewModel(string ProjectID)
        {
            AllCosts = new List<ClsCost>();

            AllCosts.Add(new ClsCost { ProjectID = "A10001", Category = "租金", Number = 5000 });
            AllCosts.Add(new ClsCost { ProjectID = "A10001", Category = "材料", Number = 2000 });
            AllCosts.Add(new ClsCost { ProjectID = "A10001", Category = "人力", Number = 6000 });
            AllCosts.Add(new ClsCost { ProjectID = "A10001", Category = "折舊", Number = 4000 });

            AllCosts.Add(new ClsCost { ProjectID = "B10002", Category = "租金", Number = 50000 });
            AllCosts.Add(new ClsCost { ProjectID = "B10002", Category = "材料", Number = 20000 });
            AllCosts.Add(new ClsCost { ProjectID = "B10002", Category = "人力", Number = 60000 });
            AllCosts.Add(new ClsCost { ProjectID = "B10002", Category = "折舊", Number = 40000 });

            Series = new List<SeriesData>();

            Costs = new List<ClsCost>();

            foreach(var cost in AllCosts.Where(p => p.ProjectID == ProjectID))
            {
                Costs.Add(cost);
            }

            Series.Add(new SeriesData { DisplayName = "Costs", Items = Costs});

            foreach(var data in Series)
            {
                foreach(var c in data.Items.Where(p => p.ProjectID == ProjectID))
                {
                    TotalInput += c.Number;
                }
            }
        }

        private object selectedItem = null;
        public object SelectedItem
        {
            get
            {
                return selectedItem;
            }
            set
            {
                selectedItem = value;
                NotifyPropertyChanged("SelectedItem");
            }
        }

        private void NotifyPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(property));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}

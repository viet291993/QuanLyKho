using QuanLyKho.HelperClass;
using QuanLyKho.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QuanLyKho.ViewModel
{
    public class CategoriesViewModel : ObservableObject, IPageViewModel
    {
        public string Name => "Thể loại";

        public string PackIcon => "ViewDashboard";

        private ObservableCollection<category> _List;
        public ObservableCollection<category> List { get => _List; set { _List = value; OnPropertyChangedKT(); } }

        private category _SelectedItem;
        public category SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChangedKT();
                if (SelectedItem != null)
                {
                    id = SelectedItem.id;
                    name = SelectedItem.name;
                }
            }
        }

        private int _id;
        public int id { get => _id; set { _id = value; OnPropertyChangedKT(); } }
        private String _name;
        public String name { get => _name; set { _name = value; OnPropertyChangedKT(); } }
       


        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        

        public CategoriesViewModel()
        {
            List = new ObservableCollection<category>(DataProvider.Ins.DB.categories);

            AddCommand = new RelayCommand<object>((p) =>
            {
                return true;

            }, (p) =>
            {
                var category = new category() { id = id, name = name};

                DataProvider.Ins.DB.categories.Add(category);
                DataProvider.Ins.DB.SaveChanges();

                List.Add(category);
            });

            EditCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null)
                    return false;

                var displayList = DataProvider.Ins.DB.categories.Where(x => x.id == SelectedItem.id);
                if (displayList != null && displayList.Count() != 0)
                    return true;

                return false;

            }, (p) =>
            {
                var category = DataProvider.Ins.DB.categories.Where(x => x.id == SelectedItem.id).SingleOrDefault();
                category.id = id;
                category.name = name;
                DataProvider.Ins.DB.SaveChanges();
         
                SelectedItem.id = id;
            });
        }
    }
}

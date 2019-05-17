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
    class ProductsViewModel : ObservableObject, IPageViewModel
    {
        public string Name => "Sản phẩm";

        public string PackIcon => "Cube";

        private ObservableCollection<product> _List;
        public ObservableCollection<product> List { get => _List; set { _List = value; OnPropertyChangedKT(); } }

        private ObservableCollection<category> _Category;
        public ObservableCollection<category> Category { get => _Category; set { _Category = value; OnPropertyChangedKT(); } }

        private product _SelectedItem;
        public product SelectedItem
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
                    unit = SelectedItem.unit;
                    price = SelectedItem.price;
                    SelectCategory = SelectedItem.category;
                    description = SelectedItem.description;
                    note = SelectedItem.note;
                }
            }
        }

        private int _id;
        public int id { get => _id; set { _id = value; OnPropertyChangedKT(); } }
        private String _name;
        public String name { get => _name; set { _name = value; OnPropertyChangedKT(); } }
        private int _price;
        public int price { get => _price; set { _price = value; OnPropertyChangedKT(); } }
        private String _unit;
        public String unit { get => _unit; set { _unit = value; OnPropertyChangedKT(); } }
        private String _description;
        public String description { get => _description; set { _description = value; OnPropertyChangedKT(); } }
        private String _note;
        public String note { get => _note; set { _note = value; OnPropertyChangedKT(); } }
        private category _SelectCategory;
        public category SelectCategory { get => _SelectCategory; set { _SelectCategory = value; OnPropertyChangedKT(); } }


        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }


        public ProductsViewModel()
        {
            List = new ObservableCollection<product>(DataProvider.Ins.DB.products);
            Category = new ObservableCollection<category>(DataProvider.Ins.DB.categories);

            AddCommand = new RelayCommand<object>((p) =>
            {
                return true;

            }, (p) =>
            {
                var product = new product() { id = id, name = name, unit = unit, description = description, price=price,categories_id =  SelectCategory.id, note = note };

                DataProvider.Ins.DB.products.Add(product);
                DataProvider.Ins.DB.SaveChanges();

                List.Add(product);
            });

            EditCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null)
                    return false;

                var displayList = DataProvider.Ins.DB.suppliers.Where(x => x.id == SelectedItem.id);
                if (displayList != null && displayList.Count() != 0)
                    return true;

                return false;

            }, (p) =>
            {
                var product = DataProvider.Ins.DB.products.Where(x => x.id == SelectedItem.id).SingleOrDefault();
                product.id = id;
                product.name = name;
                product.unit = unit;
                product.price = price;
                product.description = description;
                product.categories_id = SelectCategory.id;
                product.note = note;
                DataProvider.Ins.DB.SaveChanges();

                SelectedItem.id = id;
            });
        }
    }
}

using QuanLyKho.HelperClass;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.Model;
using System.Windows.Input;

namespace QuanLyKho.ViewModel
{
    public class SuppliersViewModel : ObservableObject, IPageViewModel
    {
        public string Name => "Nhà cung cấp";

        public string PackIcon => "Factory";

        private ObservableCollection<supplier> _List;
        public ObservableCollection<supplier> List { get => _List; set { _List = value; OnPropertyChangedKT(); } }

        private supplier _SelectedItem;
        public supplier SelectedItem
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
                    phone = SelectedItem.phone;
                    mobile = SelectedItem.mobile;
                    email = SelectedItem.email;
                    bank = SelectedItem.bank;
                    account_number = SelectedItem.account_number;
                    swift_code = SelectedItem.swift_code;
                    address = SelectedItem.address;
                    note = SelectedItem.note;
                }
            }
        }

        private int _id;
        public int id { get => _id; set { _id = value; OnPropertyChangedKT(); } }
        private String _name;
        public String name { get => _name; set { _name = value; OnPropertyChangedKT(); } }
        private String _phone;
        public String phone { get => _phone; set { _phone = value; OnPropertyChangedKT(); } }
        private String _mobile;
        public String mobile { get => _mobile; set { _mobile = value; OnPropertyChangedKT(); } }
        private String _email;
        public String email { get => _email; set { _email = value; OnPropertyChangedKT(); } }
        private String _bank;
        public String bank { get => _bank; set { _bank = value; OnPropertyChangedKT(); } }
        private String _account_number;
        public String account_number { get => _account_number; set { _account_number = value; OnPropertyChangedKT(); } }
        private String _swift_code;
        public String swift_code { get => _swift_code; set { _swift_code = value; OnPropertyChangedKT(); } }
        private String _address;
        public String address { get => _address; set { _address = value; OnPropertyChangedKT(); } }
        private String _note;
        public String note { get => _note; set { _note = value; OnPropertyChangedKT(); } }
        



        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }


        public SuppliersViewModel()
        {
            List = new ObservableCollection<supplier>(DataProvider.Ins.DB.suppliers);

            AddCommand = new RelayCommand<object>((p) =>
            {
                return true;

            }, (p) =>
            {
                var supplier = new supplier() { id = id, name = name,phone = phone,mobile=mobile,email=email,bank=bank,account_number=account_number,swift_code=swift_code,address=address,note=note };

                DataProvider.Ins.DB.suppliers.Add(supplier);
                DataProvider.Ins.DB.SaveChanges();

                List.Add(supplier);
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
                var supplier = DataProvider.Ins.DB.suppliers.Where(x => x.id == SelectedItem.id).SingleOrDefault();
                supplier.id = id;
                supplier.name = name;
                supplier.phone = phone;
                supplier.mobile = mobile;
                supplier.bank = bank;
                supplier.account_number = account_number;
                supplier.swift_code = swift_code;
                supplier.address = address;
                supplier.note = note;
                DataProvider.Ins.DB.SaveChanges();

                SelectedItem.id = id;
            });
        }
    }

}

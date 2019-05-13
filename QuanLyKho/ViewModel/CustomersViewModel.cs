using QuanLyKho.HelperClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.ViewModel
{
    public class CustomersViewModel : ObservableObject, IPageViewModel
    {
        public string Name => "Khách hàng";

        public string PackIcon => "AccountMultiple";
    }
}

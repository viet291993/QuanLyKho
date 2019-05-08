using QuanLyKho.HelperClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.ViewModel
{
    public class HomeViewModel : ObservableObject, IPageViewModel
    {
        public string Name => "Trang chủ";

        public string PackIcon => "ViewDashboard";
    }
}

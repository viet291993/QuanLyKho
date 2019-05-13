using QuanLyKho.HelperClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.ViewModel
{
    public class CategoriesViewModel : ObservableObject, IPageViewModel
    {
        public string Name => "Thể loại";

        public string PackIcon => "ViewDashboard";
    }
}

using QuanLyKho.HelperClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.ViewModel
{
    public class SuppliersViewModel : ObservableObject, IPageViewModel
    {
        public string Name => "Nhà cung cấp";

        public string PackIcon => "Factory";
    }
}

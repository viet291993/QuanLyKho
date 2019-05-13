using QuanLyKho.HelperClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.ViewModel
{
    public class OutputViewModel : ObservableObject, IPageViewModel
    {
        public string Name => "Phiếu xuất";

        public string PackIcon => "PackageUp";
    }
}

using QuanLyKho.HelperClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.ViewModel
{
    public class InputViewModel : ObservableObject, IPageViewModel
    {
        public string Name => "Phiếu nhập";

        public string PackIcon => "PackageDown";
    }
}

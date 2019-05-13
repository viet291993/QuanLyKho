using QuanLyKho.HelperClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.ViewModel
{
    class ProductsViewModel : ObservableObject, IPageViewModel
    {
        public string Name => "Sản phẩm";

        public string PackIcon => "Cube";
    }
}

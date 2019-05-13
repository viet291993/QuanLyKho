using QuanLyKho.HelperClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.ViewModel
{
    public class UsersViewModel : ObservableObject, IPageViewModel
    {
        public string Name => "Người dùng";

        public string PackIcon => "Account";
    }
}

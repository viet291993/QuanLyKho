using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace QuanLyKho
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class ApplicationView : Window
    {
        public ApplicationView()
        {
            InitializeComponent();

           
        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GridBarraTitulo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }


    }

    
}

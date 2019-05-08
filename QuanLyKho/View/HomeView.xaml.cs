using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuanLyKho.View
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
            Consumo consumo = new Consumo();
            DataContext = new ConsumoViewModel(consumo);
        }

        internal class ConsumoViewModel
        {
            public List<Consumo> Consumo { get; private set; }

            public ConsumoViewModel(Consumo consumo)
            {
                Consumo = new List<Consumo>();
                Consumo.Add(consumo);
            }
        }

        internal class Consumo
        {
            public string Titulo { get; private set; }
            public int Porcentagem { get; private set; }

            public Consumo()
            {
                Titulo = "Consumo Atual";
                Porcentagem = CalcularPorcentagem();
            }

            private int CalcularPorcentagem()
            {
                return 95; //Calculo da porcentagem de consumo
            }
        }
    }
}

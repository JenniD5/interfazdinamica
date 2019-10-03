using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Controldeusuario_nuevo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void Btnagregar_Click(object sender, RoutedEventArgs e)
        {
            btnguardar.Visibility = Visibility.Visible;
            btncancelar.Visibility = Visibility.Visible;
        }

        private void Cbnuevos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            gridprincipal.Children.Clear();
            switch (cbnuevos.SelectedIndex)
            {
                case 0:
                    gridprincipal.Children.Add(new alumno());

                    btnguardar.Visibility = Visibility.Hidden;
                    btncancelar.Visibility = Visibility.Hidden;

                    break;
                case 1:
                    gridprincipal.Children.Add(new Maestro());
                    btnguardar.Visibility = Visibility.Hidden;
                    btncancelar.Visibility = Visibility.Hidden;
                    break;
                default:
                    break;
            }
        }

        private void Btncancelar_Click(object sender, RoutedEventArgs e)
        {
            switch (cbnuevos.SelectedIndex)
            {
                case 0:
                    ((alumno)(gridprincipal.Children[0])).txtmatriculaal.Text = "";
                    ((alumno)(gridprincipal.Children[0])).txtnombreal.Text = "";
                    ((alumno)(gridprincipal.Children[0])).txtprepa.Text = "";
                    break;
                case 1:
                    ((Maestro)(gridprincipal.Children[0])).txtcodigo.Text = "";
                    ((Maestro)(gridprincipal.Children[0])).txtmateria.Text = "";
                    ((Maestro)(gridprincipal.Children[0])).txtnombre.Text = "";
                    ((Maestro)(gridprincipal.Children[0])).txttituo.Text = "";

                    gridprincipal.Children.Add(new Maestro());
                    break;
                default:
                    break;
            }


        }

        private void Btnguardar_Click(object sender, RoutedEventArgs e)
        {
            btnguardar.Visibility = Visibility.Hidden;
            btncancelar.Visibility = Visibility.Hidden;

            gridprincipal.Children.Clear();
            
        }
    }
}

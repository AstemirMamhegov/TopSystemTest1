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
using System.Windows.Shapes;
using TopSystemTest1.WPForms;

namespace TopSystemTest1
{
    /// <summary>
    /// Interaction logic for FigureView.xaml
    /// </summary>
    public partial class FigureView : Window
    {
        public FigureView()
        {
            InitializeComponent();
        }

        private void TeleportTriangleButton_Click(object sender, RoutedEventArgs e)
        {
            TriangleViewForm triangleViewForm = new TriangleViewForm();
            triangleViewForm.Show();
            this.Hide();
        }
    }
}

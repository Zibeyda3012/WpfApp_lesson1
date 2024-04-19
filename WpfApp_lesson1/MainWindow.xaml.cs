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

namespace WpfApp_lesson1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Button btn = sender as Button;
            if (e.ChangedButton == MouseButton.Left)
            {
                Random r = new Random();

                Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255), (byte)r.Next(1, 255), (byte)r.Next(1, 255)));

                btn.Background = brush;
                string message = $"{btn.Name} \nWidth: {btn.Width} \nHeight:  {btn.Height}";
                MessageBox.Show(message);
            }

            else
            {
                btn.Visibility = Visibility.Hidden;
                this.Title = btn.Content.ToString();
            }
        }
    }
}
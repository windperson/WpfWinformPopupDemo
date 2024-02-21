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

namespace WpfWinformPopupDemo
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

        private void ShowWpfPopupButton_Click(object sender, RoutedEventArgs e)
        {
            if (!MyPopup.IsOpen)
            {
                var myOldWinFormsControl = new MyOldWinFormsControl.UserControl1();

                TheWinFormHost.Child = myOldWinFormsControl;
            }
            else
            {
                TheWinFormHost.Child = null;
            }

            MyPopup.IsOpen = !MyPopup.IsOpen;

        }

        private void DemoWinFormDialogButton_Click(object sender, RoutedEventArgs e)
        {
            var form1 = new MyOldWinFormsApp1.Form1();
            System.Windows.MessageBox.Show(form1.ShowDialog() == System.Windows.Forms.DialogResult.OK
                ? "You clicked OK"
                : "You clicked Cancel");
        }
    }
}
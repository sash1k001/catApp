using System.Security.Cryptography.X509Certificates;
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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {

        int food = 50;
        int happy = 50;
        public MainWindow()
        {
            InitializeComponent();

            textLabelOne.Text = $"Food: {food}%";
            textLabelTwo.Text = $"Happy: {happy}%";

            offButtons();
        }

        public void onButtons()
        {
            buttonTwo.Visibility = Visibility.Visible;
            buttonThree.Visibility = Visibility.Visible;
        }

        public void offButtons()
        {
            buttonTwo.Visibility = Visibility.Hidden;
            buttonThree.Visibility = Visibility.Hidden;
        }
        private void buttonClick(object sender, RoutedEventArgs e)
        {
            if(food == 100 || food == 90)
            {
                MessageBox.Show("Он не голоден", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            if(buttonTwo.Visibility == Visibility.Hidden)
            {
                onButtons();
            }
            else
            {
                offButtons();
            }
        }

        private void buttonTwoClick(object sender, RoutedEventArgs e)
        {
            offButtons();
            food += 30;

            if (food > 100)
            {
                MessageBox.Show("Что-то поменьше", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
                food += -30;
            }
            else
            {
                textLabelOne.Text = $"Food: {food}%";
            }
        }

        private void buttonThreeClick(object sender, RoutedEventArgs e)
        {
            offButtons();
            food += 20;

            if (food > 100)
            {
                MessageBox.Show("Что-то поменьше", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
                food += -20;
            }
            else
            {
                textLabelOne.Text = $"Food: {food}%";
            }
        }

        private void buttonFourClick(object sender, RoutedEventArgs e)
        {
            happy += 40;

            if(happy > 100)
            {
                MessageBox.Show("Кот счастлив", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
                mainImage.Source = BitmapFrame.Create(new Uri(@"C:\Users\Саша\Desktop\WpfApp1\WpfApp1\066b966b82a7e96c32d01b5007615f4b.jpg"));
                happy -= 40;
            }
            else
            {
                textLabelTwo.Text = $"Happy: {happy}%";
            }
        }
    }
}
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

namespace SimpleAnimation {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window {
    public MainWindow() {
      InitializeComponent();
      rectangle.Fill = Brushes.AliceBlue;
    }

    private void changeColor(object sender, RoutedEventArgs e) {
      double WindowHeight = this.ActualHeight;
      double WindowWidth = this.ActualWidth;
      Random rando = new Random();
      int xMovemement = rando.Next(100);
      int yMovement = rando.Next(100);

      Canvas.SetTop(rectangle, xMovemement);
      Canvas.SetLeft(rectangle, yMovement);

      rectangle.Fill = Brushes.BlueViolet;
    }

    private void changeColorBack(object sender, RoutedEventArgs e) {
      rectangle.Fill = Brushes.AliceBlue;
    }
  }
}

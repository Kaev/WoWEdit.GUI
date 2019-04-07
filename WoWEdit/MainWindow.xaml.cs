using System.Windows;

namespace WoWEdit
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var grid = ToolbarBottom.Template.FindName("OverflowGrid", ToolbarBottom) as FrameworkElement;
            if (grid != null)
                grid.Visibility = Visibility.Hidden;

            grid = ToolbarTop.Template.FindName("OverflowGrid", ToolbarTop) as FrameworkElement;
            if (grid != null)
                grid.Visibility = Visibility.Hidden;

            grid = ToolbarLeft.Template.FindName("OverflowGrid", ToolbarLeft) as FrameworkElement;
            if (grid != null)
                grid.Visibility = Visibility.Hidden;

            grid = ToolbarSearch.Template.FindName("OverflowGrid", ToolbarSearch) as FrameworkElement;
            if (grid != null)
                grid.Visibility = Visibility.Hidden;

            grid = ToolbarTuning.Template.FindName("OverflowGrid", ToolbarTuning) as FrameworkElement;
            if (grid != null)
                grid.Visibility = Visibility.Hidden;
        }
    }
}

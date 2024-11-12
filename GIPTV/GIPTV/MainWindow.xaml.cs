using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Globalization;
using System.Windows.Data;

namespace GIPTV
{
    public class PercentageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double doubleValue)
            {
                return $"{doubleValue:0}%";
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

public partial class MainWindow : Window
{
    public MainWindow()
    {
        object value = InitializeComponent();
    }

    private object InitializeComponent()
    {
        throw new NotImplementedException();
    }

    private void LoadPlaylist_Click(object sender, RoutedEventArgs e)
    {
        // Implement playlist loading logic
    }

    private void Exit_Click(object sender, RoutedEventArgs e)
    {
        this.Close();
    }

    private void ChannelListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        // Implement channel selection logic
    }

    private void PlayButton_Click(object sender, RoutedEventArgs e)
    {
        // Implement play functionality
    }

    private void PauseButton_Click(object sender, RoutedEventArgs e)
    {
        // Implement pause functionality
    }

    private void StopButton_Click(object sender, RoutedEventArgs e)
    {
        // Implement stop functionality
    }

}
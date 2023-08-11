using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using WPF_TreeView.Enums;

namespace WPF_TreeView.Converters
{
    [ValueConversion(typeof(TreeNodeType), typeof(BitmapImage))]
    public class TreeNodeTypeToIconSourceConverters : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var treeNodeType = (TreeNodeType)value;
            string path = string.Empty;
            switch (treeNodeType)
            {
                case TreeNodeType.Folder:
                    path = "pack://application:,,,/Images/folder-icon.png";
                    break;

                case TreeNodeType.Tick:
                    path = "pack://application:,,,/Images/tick-icon.png";
                    break;

                case TreeNodeType.Unknown:
                default:
                    path = "pack://application:,,,/Images/unknown-file-icon.png";
                    break;
            }
            var uri = new Uri(path);
            var source = new BitmapImage(uri);
            return source;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}

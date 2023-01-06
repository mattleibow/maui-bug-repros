// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace App10
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void TextBox_Loaded(object sender, RoutedEventArgs e)
        {
            var tb = sender as TextBox;
            var sv = GetDescendantByName<ScrollViewer>(tb, "ContentElement");
            sv.VerticalAlignment = VerticalAlignment.Center;
        }

        internal static T GetDescendantByName<T>(DependencyObject parent, string elementName)
            where T : DependencyObject
        {
            var myChildrenCount = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < myChildrenCount; i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);

                if (child is T t && elementName.Equals(child.GetValue(FrameworkElement.NameProperty)))
                    return t;
                else if (GetDescendantByName<T>(child, elementName) is T tChild)
                    return tChild;
            }
            return null;
        }
    }
}

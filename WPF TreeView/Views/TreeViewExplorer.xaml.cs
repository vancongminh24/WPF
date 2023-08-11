using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using WPF_TreeView.Models;

namespace WPF_TreeView.Views
{
    /// <summary>
    /// Interaction logic for TreeViewExplorer.xaml
    /// </summary>
    public partial class TreeViewExplorer : UserControl
    {
        public static readonly DependencyProperty TreeNodesProperty =
            DependencyProperty.Register(nameof(TreeNodes), typeof(ObservableCollection<TreeNode>), typeof(TreeViewExplorer), new PropertyMetadata(OnTreeNodesChanged));

        public ObservableCollection<TreeNode> TreeNodes
        {
            get { return (ObservableCollection<TreeNode>)GetValue(TreeNodesProperty); }
            set { SetValue(TreeNodesProperty, value); }
        }

        public TreeViewExplorer()
        {
            InitializeComponent();
        }

        private static void OnTreeNodesChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            
        }
    }
}

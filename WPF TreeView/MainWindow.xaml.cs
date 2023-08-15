using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using WPF_TreeView.Enums;
using WPF_TreeView.Helpers;
using WPF_TreeView.Models;

namespace WPF_TreeView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<TreeNode> TreeNodes { get; set; } = new ObservableCollection<TreeNode>();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            TreeNodes.Add(new TreeNode()
            {
                Name = "Hi1",
                TreeNodeType = TreeNodeType.Folder,
                Children = new List<TreeNode>()
                    {
                    new TreeNode(){Name = "Hi1-1"},

                    new TreeNode(){
                        Name = "Hi1-2",
                        TreeNodeType = TreeNodeType.Tick,
                        Children = new List<TreeNode>()
                        {
                            new TreeNode()
                            {
                                Name = "Hi1-2-1"
                            }
                        }
                    },
                    new TreeNode(){Name = "Hi1-3"}
                    }
            });
            TreeNodes.Add(new TreeNode() { Name = "Hi2" });

            var countries = DummyData.GetDummyCountries();
        }
    }
}

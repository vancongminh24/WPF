using System.Collections.Generic;
using WPF_TreeView.Enums;

namespace WPF_TreeView.Models
{
    public class TreeNode
    {
        public string Name { get; set; }
        public TreeNodeType TreeNodeType { get; set; }
        public List<TreeNode> Children { get; set; }
    }
}

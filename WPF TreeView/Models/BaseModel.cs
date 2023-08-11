using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPF_TreeView.Models
{
    public class BaseModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name.ToString();
        }
    }
}

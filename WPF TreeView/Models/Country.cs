using System.Collections.Generic;

namespace WPF_TreeView.Models
{
    public class Country : BaseModel
    {
        public List<City> Cities { get; set;}
    }
}

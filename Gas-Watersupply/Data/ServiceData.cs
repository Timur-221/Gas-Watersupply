using BlszorApp2.Data;
using Microsoft.AspNetCore.Components.Forms;

namespace Gas_Watersupply.Data
{
    public class ServiceData
    {

        //public Account Account { get; set; }     

        public Developer Developer { get; set; }

        public Customer Customer { get; set; }

        public Designer Designer { get; set; }

        public List<IBrowserFile> BrowserFiles { get; set; } = new List<IBrowserFile>();

        public List<IBrowserFile> BrowserFilesDeveloper { get; set; } = new List<IBrowserFile>();

        public List<MainFile> DeveloperMainFile { get; set; } = new List<MainFile>();

        public List<IBrowserFile> BrowserFilesDesigner { get; set; } = new List<IBrowserFile>();

        public List<MainFile> DesignerMainFile { get; set; } = new List<MainFile>();

        //public Developer GetDeveloper()
        //{
        //    return (Developer)Account;
        //}

        //public Customer GetCustomer()
        //{
        //    return (Customer)Account;
        //}

        //public Designer GetDesigner()
        //{
        //    return (Designer)Account;
        //}
    }
}

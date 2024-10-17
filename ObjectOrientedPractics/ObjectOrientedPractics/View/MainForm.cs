using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        private Store _store = new Store();
        public MainForm()
        {
            InitializeComponent();
            _store.Items = new List<Item>();
            _store.Customers = new List<Customer>();
            itemsTab1.Items = _store.Items;
            customersTab1.Customers = _store.Customers;
        }
    }
}

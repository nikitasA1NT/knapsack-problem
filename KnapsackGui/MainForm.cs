using KnapsackLib;

namespace KnapsackGui
{
    public partial class MainForm : Form
    {
        private readonly List<KnapsackProblem.Item> _itemList = new List<KnapsackProblem.Item>();

    public MainForm()
        {
            InitializeComponent();
        }

        private void itemValueNumericUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void itemWeightNumericUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(itemNameTextBox.Text))
            {
                MessageBox.Show("Item name cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var item = new KnapsackProblem.Item(itemNameTextBox.Text, (int)itemValueNumericUpDown.Value, (int)itemWeightNumericUpDown.Value);
            _itemList.Add(item);
        }
    }
}
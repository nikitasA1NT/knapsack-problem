using KnapsackLib;
using System.ComponentModel;

namespace KnapsackGui
{
    public partial class MainForm : Form
    {
        private readonly BindingList<KnapsackProblem.Item> _itemList = new();
        private readonly BindingList<KnapsackProblem.Item> _resultList = new();

        public MainForm()
        {
            InitializeComponent();

            knapsackCapacityNumericUpDown.TextChanged += new EventHandler(knapsackCapacityNumericUpDown_TextChanged!);

            allItemsDataGridView.DataSource = _itemList;
            resultDataGridView.DataSource = _resultList;

            UpdateResult();
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

        private void knapsackCapacityNumericUpDown_KeyPress(object sender, KeyPressEventArgs e)
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
            UpdateResult();
        }

        private void UpdateResult()
        {
            var solvedList = KnapsackProblem.Solve(_itemList.ToList(), (int)knapsackCapacityNumericUpDown.Value);
            _resultList.Clear();
            foreach (var item in solvedList)
            {
                _resultList.Add(item);
            }
            totalSumLabel.Text = $"Total sum: {solvedList.SummaryValue()}";
        }

        void knapsackCapacityNumericUpDown_TextChanged(object sender, EventArgs e)
        {
            UpdateResult();
        }

        private void clearAllItemsButton_Click(object sender, EventArgs e)
        {
            _itemList.Clear();
            UpdateResult();
        }
    }
}
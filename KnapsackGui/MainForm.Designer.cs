namespace KnapsackGui
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.itemValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.itemValueLabel = new System.Windows.Forms.Label();
            this.itemWeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.itemWeightLabel = new System.Windows.Forms.Label();
            this.addItemButton = new System.Windows.Forms.Button();
            this.allItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.allItemsLabel = new System.Windows.Forms.Label();
            this.resultDataGridView = new System.Windows.Forms.DataGridView();
            this.resultLabel = new System.Windows.Forms.Label();
            this.knapsackCapacityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.knapsackCapacityLabel = new System.Windows.Forms.Label();
            this.clearAllItemsButton = new System.Windows.Forms.Button();
            this.totalSumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemValueNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemWeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allItemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knapsackCapacityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Location = new System.Drawing.Point(12, 9);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(42, 15);
            this.itemNameLabel.TabIndex = 0;
            this.itemNameLabel.Text = "Name:";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(12, 27);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(150, 23);
            this.itemNameTextBox.TabIndex = 1;
            // 
            // itemValueNumericUpDown
            // 
            this.itemValueNumericUpDown.Location = new System.Drawing.Point(168, 27);
            this.itemValueNumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.itemValueNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.itemValueNumericUpDown.Name = "itemValueNumericUpDown";
            this.itemValueNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.itemValueNumericUpDown.TabIndex = 2;
            this.itemValueNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.itemValueNumericUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemValueNumericUpDown_KeyPress);
            // 
            // itemValueLabel
            // 
            this.itemValueLabel.AutoSize = true;
            this.itemValueLabel.Location = new System.Drawing.Point(168, 9);
            this.itemValueLabel.Name = "itemValueLabel";
            this.itemValueLabel.Size = new System.Drawing.Size(38, 15);
            this.itemValueLabel.TabIndex = 3;
            this.itemValueLabel.Text = "Value:";
            // 
            // itemWeightNumericUpDown
            // 
            this.itemWeightNumericUpDown.Location = new System.Drawing.Point(294, 27);
            this.itemWeightNumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.itemWeightNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.itemWeightNumericUpDown.Name = "itemWeightNumericUpDown";
            this.itemWeightNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.itemWeightNumericUpDown.TabIndex = 4;
            this.itemWeightNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.itemWeightNumericUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemWeightNumericUpDown_KeyPress);
            // 
            // itemWeightLabel
            // 
            this.itemWeightLabel.AutoSize = true;
            this.itemWeightLabel.Location = new System.Drawing.Point(294, 9);
            this.itemWeightLabel.Name = "itemWeightLabel";
            this.itemWeightLabel.Size = new System.Drawing.Size(48, 15);
            this.itemWeightLabel.TabIndex = 5;
            this.itemWeightLabel.Text = "Weight:";
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(294, 56);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(120, 38);
            this.addItemButton.TabIndex = 6;
            this.addItemButton.Text = "Add item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // allItemsDataGridView
            // 
            this.allItemsDataGridView.AllowUserToAddRows = false;
            this.allItemsDataGridView.AllowUserToDeleteRows = false;
            this.allItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allItemsDataGridView.Location = new System.Drawing.Point(12, 115);
            this.allItemsDataGridView.Name = "allItemsDataGridView";
            this.allItemsDataGridView.ReadOnly = true;
            this.allItemsDataGridView.RowTemplate.Height = 25;
            this.allItemsDataGridView.Size = new System.Drawing.Size(402, 403);
            this.allItemsDataGridView.TabIndex = 7;
            // 
            // allItemsLabel
            // 
            this.allItemsLabel.AutoSize = true;
            this.allItemsLabel.Location = new System.Drawing.Point(12, 97);
            this.allItemsLabel.Name = "allItemsLabel";
            this.allItemsLabel.Size = new System.Drawing.Size(56, 15);
            this.allItemsLabel.TabIndex = 8;
            this.allItemsLabel.Text = "All items:";
            // 
            // resultDataGridView
            // 
            this.resultDataGridView.AllowUserToAddRows = false;
            this.resultDataGridView.AllowUserToDeleteRows = false;
            this.resultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGridView.Location = new System.Drawing.Point(546, 115);
            this.resultDataGridView.Name = "resultDataGridView";
            this.resultDataGridView.ReadOnly = true;
            this.resultDataGridView.RowTemplate.Height = 25;
            this.resultDataGridView.Size = new System.Drawing.Size(402, 403);
            this.resultDataGridView.TabIndex = 9;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(546, 97);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(140, 15);
            this.resultLabel.TabIndex = 10;
            this.resultLabel.Text = "Knapsack problem result:";
            // 
            // knapsackCapacityNumericUpDown
            // 
            this.knapsackCapacityNumericUpDown.Location = new System.Drawing.Point(420, 190);
            this.knapsackCapacityNumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.knapsackCapacityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.knapsackCapacityNumericUpDown.Name = "knapsackCapacityNumericUpDown";
            this.knapsackCapacityNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.knapsackCapacityNumericUpDown.TabIndex = 11;
            this.knapsackCapacityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.knapsackCapacityNumericUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.knapsackCapacityNumericUpDown_KeyPress);
            // 
            // knapsackCapacityLabel
            // 
            this.knapsackCapacityLabel.AutoSize = true;
            this.knapsackCapacityLabel.Location = new System.Drawing.Point(420, 172);
            this.knapsackCapacityLabel.Name = "knapsackCapacityLabel";
            this.knapsackCapacityLabel.Size = new System.Drawing.Size(107, 15);
            this.knapsackCapacityLabel.TabIndex = 12;
            this.knapsackCapacityLabel.Text = "Knapsack capacity:";
            // 
            // clearAllItemsButton
            // 
            this.clearAllItemsButton.Location = new System.Drawing.Point(420, 71);
            this.clearAllItemsButton.Name = "clearAllItemsButton";
            this.clearAllItemsButton.Size = new System.Drawing.Size(75, 23);
            this.clearAllItemsButton.TabIndex = 13;
            this.clearAllItemsButton.Text = "Clear items";
            this.clearAllItemsButton.UseVisualStyleBackColor = true;
            this.clearAllItemsButton.Click += new System.EventHandler(this.clearAllItemsButton_Click);
            // 
            // totalSumLabel
            // 
            this.totalSumLabel.AutoSize = true;
            this.totalSumLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalSumLabel.Location = new System.Drawing.Point(546, 521);
            this.totalSumLabel.Name = "totalSumLabel";
            this.totalSumLabel.Size = new System.Drawing.Size(96, 25);
            this.totalSumLabel.TabIndex = 14;
            this.totalSumLabel.Text = "Total sum:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 555);
            this.Controls.Add(this.totalSumLabel);
            this.Controls.Add(this.clearAllItemsButton);
            this.Controls.Add(this.knapsackCapacityLabel);
            this.Controls.Add(this.knapsackCapacityNumericUpDown);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.resultDataGridView);
            this.Controls.Add(this.allItemsLabel);
            this.Controls.Add(this.allItemsDataGridView);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.itemWeightLabel);
            this.Controls.Add(this.itemWeightNumericUpDown);
            this.Controls.Add(this.itemValueLabel);
            this.Controls.Add(this.itemValueNumericUpDown);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(this.itemNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Knapsack";
            ((System.ComponentModel.ISupportInitialize)(this.itemValueNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemWeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allItemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knapsackCapacityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label itemNameLabel;
        private TextBox itemNameTextBox;
        private NumericUpDown itemValueNumericUpDown;
        private Label itemValueLabel;
        private NumericUpDown itemWeightNumericUpDown;
        private Label itemWeightLabel;
        private Button addItemButton;
        private DataGridView allItemsDataGridView;
        private Label allItemsLabel;
        private DataGridView resultDataGridView;
        private Label resultLabel;
        private NumericUpDown knapsackCapacityNumericUpDown;
        private Label knapsackCapacityLabel;
        private Button clearAllItemsButton;
        private Label totalSumLabel;
    }
}
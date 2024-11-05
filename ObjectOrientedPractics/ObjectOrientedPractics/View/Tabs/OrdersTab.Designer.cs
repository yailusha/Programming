using System.Data;

namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Model.Address address1 = new Model.Address();
            label1 = new Label();
            OrdersDataGrid = new DataGridView();
            IdColumn = new DataGridViewTextBoxColumn();
            CreatedColumn = new DataGridViewTextBoxColumn();
            FullnameColumn = new DataGridViewTextBoxColumn();
            AddressColumn = new DataGridViewTextBoxColumn();
            AmountColumn = new DataGridViewTextBoxColumn();
            StatusColumn = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            idTextBox = new TextBox();
            createdTextBox = new TextBox();
            StatusComboBox = new ComboBox();
            label6 = new Label();
            OrderItemsListBox = new ListBox();
            label7 = new Label();
            amountLabel = new Label();
            addressControl1 = new Controls.AddressControl();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Orders";
            // 
            // OrdersDataGrid
            // 
            OrdersDataGrid.AllowUserToAddRows = false;
            OrdersDataGrid.AllowUserToDeleteRows = false;
            OrdersDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersDataGrid.Columns.AddRange(new DataGridViewColumn[] { IdColumn, CreatedColumn, FullnameColumn, AddressColumn, AmountColumn, StatusColumn });
            OrdersDataGrid.Location = new Point(3, 18);
            OrdersDataGrid.MultiSelect = false;
            OrdersDataGrid.Name = "OrdersDataGrid";
            OrdersDataGrid.ReadOnly = true;
            OrdersDataGrid.Size = new Size(337, 668);
            OrdersDataGrid.TabIndex = 1;
            OrdersDataGrid.RowHeaderMouseClick += OrdersDataGrid_RowHeaderMouseClick1;
            // 
            // IdColumn
            // 
            IdColumn.HeaderText = "Id";
            IdColumn.Name = "IdColumn";
            IdColumn.ReadOnly = true;
            // 
            // CreatedColumn
            // 
            CreatedColumn.HeaderText = "Created";
            CreatedColumn.Name = "CreatedColumn";
            CreatedColumn.ReadOnly = true;
            // 
            // FullnameColumn
            // 
            FullnameColumn.HeaderText = "Full Name";
            FullnameColumn.Name = "FullnameColumn";
            FullnameColumn.ReadOnly = true;
            // 
            // AddressColumn
            // 
            AddressColumn.HeaderText = "Address";
            AddressColumn.Name = "AddressColumn";
            AddressColumn.ReadOnly = true;
            // 
            // AmountColumn
            // 
            AmountColumn.HeaderText = "Amount";
            AmountColumn.Name = "AmountColumn";
            AmountColumn.ReadOnly = true;
            // 
            // StatusColumn
            // 
            StatusColumn.HeaderText = "Status of delivery";
            StatusColumn.Name = "StatusColumn";
            StatusColumn.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(355, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 2;
            label2.Text = "Selected order";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(355, 32);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 3;
            label3.Text = "ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(355, 100);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 4;
            label4.Text = "Status:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(355, 66);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 5;
            label5.Text = "Created:";
            // 
            // idTextBox
            // 
            idTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            idTextBox.Location = new Point(411, 29);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(157, 23);
            idTextBox.TabIndex = 6;
            // 
            // createdTextBox
            // 
            createdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            createdTextBox.Location = new Point(411, 63);
            createdTextBox.Name = "createdTextBox";
            createdTextBox.ReadOnly = true;
            createdTextBox.Size = new Size(157, 23);
            createdTextBox.TabIndex = 7;
            // 
            // StatusComboBox
            // 
            StatusComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(411, 97);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(157, 23);
            StatusComboBox.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(355, 310);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 10;
            label6.Text = "Order Items";
            // 
            // OrderItemsListBox
            // 
            OrderItemsListBox.Anchor = AnchorStyles.Right;
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.ItemHeight = 15;
            OrderItemsListBox.Location = new Point(355, 328);
            OrderItemsListBox.Name = "OrderItemsListBox";
            OrderItemsListBox.Size = new Size(496, 169);
            OrderItemsListBox.TabIndex = 11;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(791, 509);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 12;
            label7.Text = "Amount:";
            // 
            // amountLabel
            // 
            amountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            amountLabel.Location = new Point(791, 535);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(25, 30);
            amountLabel.TabIndex = 13;
            amountLabel.Text = "0";
            // 
            // addressControl1
            // 
            address1.Apartment = "Apartment";
            address1.Building = "Building";
            address1.City = "City";
            address1.Country = "Country";
            address1.Index = 100000;
            address1.Street = "Street";
            addressControl1.Address = address1;
            addressControl1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addressControl1.ApartmentValue = null;
            addressControl1.BuildingValue = null;
            addressControl1.CityValue = null;
            addressControl1.CountryValue = null;
            addressControl1.Location = new Point(355, 126);
            addressControl1.Name = "addressControl1";
            addressControl1.PostIndexValue = null;
            addressControl1.Size = new Size(520, 181);
            addressControl1.StreetValue = null;
            addressControl1.TabIndex = 14;
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(addressControl1);
            Controls.Add(amountLabel);
            Controls.Add(label7);
            Controls.Add(OrderItemsListBox);
            Controls.Add(label6);
            Controls.Add(StatusComboBox);
            Controls.Add(createdTextBox);
            Controls.Add(idTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(OrdersDataGrid);
            Controls.Add(label1);
            Name = "OrdersTab";
            Size = new Size(873, 689);
            ((System.ComponentModel.ISupportInitialize)OrdersDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void OrdersDataGrid_RowHeaderMouseClick1(object sender, DataGridViewCellMouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private DataGridView OrdersDataGrid;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn CreatedColumn;
        private DataGridViewTextBoxColumn FullnameColumn;
        private DataGridViewTextBoxColumn AddressColumn;
        private DataGridViewTextBoxColumn AmountColumn;
        private DataGridViewTextBoxColumn StatusColumn;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox idTextBox;
        private TextBox createdTextBox;
        private ComboBox StatusComboBox;
        private Label label6;
        private ListBox OrderItemsListBox;
        private Label label7;
        private Label amountLabel;
        private Controls.AddressControl addressControl1;
    }
}

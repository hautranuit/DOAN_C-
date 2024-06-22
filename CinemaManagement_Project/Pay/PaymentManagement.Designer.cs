namespace CinemaManagement_Project.Pay
{
    partial class PaymentManagement
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentManagement));
            ListViewItem listViewItem11 = new ListViewItem(new string[] { "Vé Rạp 1" }, -1, Color.White, Color.Empty, new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point));
            ListViewItem listViewItem12 = new ListViewItem(new string[] { "Vé Rạp 2" }, -1, Color.White, Color.Empty, new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point));
            ListViewItem listViewItem13 = new ListViewItem(new string[] { "Vé Rạp 3" }, -1, Color.White, Color.Empty, new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point));
            ListViewItem listViewItem14 = new ListViewItem(new string[] { "Voucher" }, -1, Color.White, Color.Empty, new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point));
            ListViewItem listViewItem15 = new ListViewItem(new string[] { "ComboSolo" }, -1, Color.White, Color.Empty, new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point));
            ListViewItem listViewItem16 = new ListViewItem(new string[] { "ComboCouple" }, -1, Color.White, Color.Empty, new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point));
            ListViewItem listViewItem17 = new ListViewItem(new string[] { "ComboParty" }, -1, Color.White, Color.Empty, new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point));
            ListViewItem listViewItem18 = new ListViewItem(new string[] { "Combo2NganSolo" }, -1, Color.White, Color.Empty, new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point));
            ListViewItem listViewItem19 = new ListViewItem(new string[] { "Combo2NganCouple" }, -1, Color.White, Color.Empty, new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point));
            ListViewItem listViewItem20 = new ListViewItem(new string[] { "Combo2NganParty" }, -1, Color.White, Color.Empty, new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point));
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            btn_Back = new Button();
            btn_Edit = new Button();
            btn_Theater = new Button();
            btn_Voucher = new Button();
            btn_Combo = new Button();
            btn_Revenue = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BackColor = Color.SlateBlue;
            listView1.BackgroundImage = (Image)resources.GetObject("listView1.BackgroundImage");
            listView1.BackgroundImageTiled = true;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            listView1.ForeColor = Color.White;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem11, listViewItem12, listViewItem13, listViewItem14, listViewItem15, listViewItem16, listViewItem17, listViewItem18, listViewItem19, listViewItem20 });
            listView1.Location = new Point(216, 23);
            listView1.Name = "listView1";
            listView1.Size = new Size(990, 415);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Item";
            columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số lượng còn lại";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Số lượng đã bán";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Đơn giá";
            columnHeader4.Width = 235;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Tổng danh thu";
            columnHeader5.Width = 200;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.Silver;
            btn_Back.Cursor = Cursors.Hand;
            btn_Back.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Back.Location = new Point(12, 794);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(111, 44);
            btn_Back.TabIndex = 1;
            btn_Back.Text = "Trở Lại";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.BackColor = Color.Yellow;
            btn_Edit.Cursor = Cursors.Hand;
            btn_Edit.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Edit.Location = new Point(1095, 444);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(111, 44);
            btn_Edit.TabIndex = 2;
            btn_Edit.Text = "Chỉnh Sửa";
            btn_Edit.UseVisualStyleBackColor = false;
            btn_Edit.Click += btn_Edit_Click;
            // 
            // btn_Theater
            // 
            btn_Theater.BackColor = Color.Yellow;
            btn_Theater.Cursor = Cursors.Hand;
            btn_Theater.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Theater.Location = new Point(193, 484);
            btn_Theater.Name = "btn_Theater";
            btn_Theater.Size = new Size(158, 44);
            btn_Theater.TabIndex = 3;
            btn_Theater.Text = "Theo Rạp";
            btn_Theater.UseVisualStyleBackColor = false;
            btn_Theater.Click += btn_Theater_Click;
            // 
            // btn_Voucher
            // 
            btn_Voucher.BackColor = Color.Yellow;
            btn_Voucher.Cursor = Cursors.Hand;
            btn_Voucher.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Voucher.Location = new Point(193, 558);
            btn_Voucher.Name = "btn_Voucher";
            btn_Voucher.Size = new Size(158, 44);
            btn_Voucher.TabIndex = 4;
            btn_Voucher.Text = "Theo Voucher";
            btn_Voucher.UseVisualStyleBackColor = false;
            btn_Voucher.Click += btn_Voucher_Click;
            // 
            // btn_Combo
            // 
            btn_Combo.BackColor = Color.Yellow;
            btn_Combo.Cursor = Cursors.Hand;
            btn_Combo.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Combo.Location = new Point(193, 631);
            btn_Combo.Name = "btn_Combo";
            btn_Combo.Size = new Size(158, 44);
            btn_Combo.TabIndex = 5;
            btn_Combo.Text = "Theo Combo";
            btn_Combo.UseVisualStyleBackColor = false;
            btn_Combo.Click += btn_Combo_Click;
            // 
            // btn_Revenue
            // 
            btn_Revenue.BackColor = Color.Yellow;
            btn_Revenue.Cursor = Cursors.Hand;
            btn_Revenue.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Revenue.Location = new Point(193, 704);
            btn_Revenue.Name = "btn_Revenue";
            btn_Revenue.Size = new Size(158, 44);
            btn_Revenue.TabIndex = 6;
            btn_Revenue.Text = "Theo Doanh Thu";
            btn_Revenue.UseVisualStyleBackColor = false;
            btn_Revenue.Click += btn_Revenue_Click;
            // 
            // PaymentManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1400, 850);
            Controls.Add(btn_Revenue);
            Controls.Add(btn_Combo);
            Controls.Add(btn_Voucher);
            Controls.Add(btn_Theater);
            Controls.Add(btn_Edit);
            Controls.Add(btn_Back);
            Controls.Add(listView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PaymentManagement";
            Text = "PaymentManagement";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button btn_Back;
        private Button btn_Edit;
        private Button btn_Theater;
        private Button btn_Voucher;
        private Button btn_Combo;
        private Button btn_Revenue;
    }
}
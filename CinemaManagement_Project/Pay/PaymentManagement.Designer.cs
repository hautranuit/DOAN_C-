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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Vé Rạp 1" }, -1, Color.White, Color.Empty, new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point));
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "Vé Rạp 2" }, -1, Color.White, Color.Empty, new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point));
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "Vé Rạp 3" }, -1, Color.White, Color.Empty, new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point));
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "Voucher" }, -1, Color.White, Color.Empty, new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point));
            ListViewItem listViewItem5 = new ListViewItem(new string[] { "ComboSolo" }, -1, Color.White, Color.Empty, new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point));
            ListViewItem listViewItem6 = new ListViewItem(new string[] { "ComboCouple" }, -1, Color.White, Color.Empty, new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point));
            ListViewItem listViewItem7 = new ListViewItem(new string[] { "ComboParty" }, -1, Color.White, Color.Empty, new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point));
            ListViewItem listViewItem8 = new ListViewItem(new string[] { "Combo2NganSolo" }, -1, Color.White, Color.Empty, new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point));
            ListViewItem listViewItem9 = new ListViewItem(new string[] { "Combo2NganCouple" }, -1, Color.White, Color.Empty, new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point));
            ListViewItem listViewItem10 = new ListViewItem(new string[] { "Combo2NganParty" }, -1, Color.White, Color.Empty, new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point));
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            btn_Back = new Button();
            btn_Edit = new Button();
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
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5, listViewItem6, listViewItem7, listViewItem8, listViewItem9, listViewItem10 });
            listView1.Location = new Point(12, 50);
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
            btn_Back.Location = new Point(370, 502);
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
            btn_Edit.Location = new Point(534, 502);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(111, 44);
            btn_Edit.TabIndex = 2;
            btn_Edit.Text = "Chỉnh Sửa";
            btn_Edit.UseVisualStyleBackColor = false;
            btn_Edit.Click += btn_Edit_Click;
            // 
            // PaymentManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1017, 558);
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
    }
}
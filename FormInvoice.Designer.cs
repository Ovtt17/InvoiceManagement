namespace InvoiceManagement
{
    partial class FormInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInvoice));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InvoiceTC = new System.Windows.Forms.TabControl();
            this.ViewTP = new System.Windows.Forms.TabPage();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.TotalTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GridViewProducts = new System.Windows.Forms.DataGridView();
            this.RichTextBox = new System.Windows.Forms.RichTextBox();
            this.CodeCmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NewTP = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.GridNewProducts = new System.Windows.Forms.DataGridView();
            this.ProductColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatePurchaseTimer = new System.Windows.Forms.DateTimePicker();
            this.ClientNameTxt = new System.Windows.Forms.TextBox();
            this.InvoiceCodeTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.InvoiceTC.SuspendLayout();
            this.ViewTP.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewProducts)).BeginInit();
            this.NewTP.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridNewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.InvoiceTC);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // InvoiceTC
            // 
            resources.ApplyResources(this.InvoiceTC, "InvoiceTC");
            this.InvoiceTC.Controls.Add(this.ViewTP);
            this.InvoiceTC.Controls.Add(this.NewTP);
            this.InvoiceTC.Cursor = System.Windows.Forms.Cursors.Default;
            this.InvoiceTC.Name = "InvoiceTC";
            this.InvoiceTC.SelectedIndex = 0;
            // 
            // ViewTP
            // 
            this.ViewTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.ViewTP.Controls.Add(this.groupBox);
            this.ViewTP.Controls.Add(this.RichTextBox);
            this.ViewTP.Controls.Add(this.CodeCmb);
            this.ViewTP.Controls.Add(this.label1);
            this.ViewTP.Cursor = System.Windows.Forms.Cursors.Default;
            this.ViewTP.ForeColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.ViewTP, "ViewTP");
            this.ViewTP.Name = "ViewTP";
            // 
            // groupBox
            // 
            resources.ApplyResources(this.groupBox, "groupBox");
            this.groupBox.Controls.Add(this.TotalTxt);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.GridViewProducts);
            this.groupBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox.ForeColor = System.Drawing.Color.White;
            this.groupBox.Name = "groupBox";
            this.groupBox.TabStop = false;
            // 
            // TotalTxt
            // 
            resources.ApplyResources(this.TotalTxt, "TotalTxt");
            this.TotalTxt.Name = "TotalTxt";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // GridViewProducts
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.GridViewProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.GridViewProducts, "GridViewProducts");
            this.GridViewProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.GridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridViewProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridViewProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.GridViewProducts.Name = "GridViewProducts";
            this.GridViewProducts.RowTemplate.Height = 24;
            // 
            // RichTextBox
            // 
            resources.ApplyResources(this.RichTextBox, "RichTextBox");
            this.RichTextBox.Name = "RichTextBox";
            // 
            // CodeCmb
            // 
            this.CodeCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.CodeCmb, "CodeCmb");
            this.CodeCmb.FormattingEnabled = true;
            this.CodeCmb.Name = "CodeCmb";
            this.CodeCmb.SelectedIndexChanged += new System.EventHandler(this.CodeCmb_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // NewTP
            // 
            this.NewTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.NewTP.Controls.Add(this.groupBox1);
            this.NewTP.Controls.Add(this.DatePurchaseTimer);
            this.NewTP.Controls.Add(this.ClientNameTxt);
            this.NewTP.Controls.Add(this.InvoiceCodeTxt);
            this.NewTP.Controls.Add(this.label5);
            this.NewTP.Controls.Add(this.label4);
            this.NewTP.Controls.Add(this.label3);
            this.NewTP.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.NewTP, "NewTP");
            this.NewTP.Name = "NewTP";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.SaveBtn);
            this.groupBox1.Controls.Add(this.GridNewProducts);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // SaveBtn
            // 
            resources.ApplyResources(this.SaveBtn, "SaveBtn");
            this.SaveBtn.BackColor = System.Drawing.Color.Green;
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // GridNewProducts
            // 
            this.GridNewProducts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.GridNewProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.GridNewProducts, "GridNewProducts");
            this.GridNewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridNewProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridNewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridNewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridNewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductColumn,
            this.AmountColumn});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridNewProducts.DefaultCellStyle = dataGridViewCellStyle5;
            this.GridNewProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.GridNewProducts.Name = "GridNewProducts";
            this.GridNewProducts.RowTemplate.Height = 24;
            // 
            // ProductColumn
            // 
            this.ProductColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            resources.ApplyResources(this.ProductColumn, "ProductColumn");
            this.ProductColumn.Name = "ProductColumn";
            this.ProductColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // AmountColumn
            // 
            resources.ApplyResources(this.AmountColumn, "AmountColumn");
            this.AmountColumn.Name = "AmountColumn";
            // 
            // DatePurchaseTimer
            // 
            resources.ApplyResources(this.DatePurchaseTimer, "DatePurchaseTimer");
            this.DatePurchaseTimer.Name = "DatePurchaseTimer";
            // 
            // ClientNameTxt
            // 
            resources.ApplyResources(this.ClientNameTxt, "ClientNameTxt");
            this.ClientNameTxt.Name = "ClientNameTxt";
            // 
            // InvoiceCodeTxt
            // 
            resources.ApplyResources(this.InvoiceCodeTxt, "InvoiceCodeTxt");
            this.InvoiceCodeTxt.Name = "InvoiceCodeTxt";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // FormInvoice
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "FormInvoice";
            this.Load += new System.EventHandler(this.FormInvoice_Load);
            this.panel1.ResumeLayout(false);
            this.InvoiceTC.ResumeLayout(false);
            this.ViewTP.ResumeLayout(false);
            this.ViewTP.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewProducts)).EndInit();
            this.NewTP.ResumeLayout(false);
            this.NewTP.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridNewProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl InvoiceTC;
        private System.Windows.Forms.TabPage ViewTP;
        private System.Windows.Forms.TabPage NewTP;
        private System.Windows.Forms.ComboBox CodeCmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RichTextBox;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox TotalTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView GridViewProducts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DatePurchaseTimer;
        private System.Windows.Forms.TextBox ClientNameTxt;
        private System.Windows.Forms.TextBox InvoiceCodeTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView GridNewProducts;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProductColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
    }
}
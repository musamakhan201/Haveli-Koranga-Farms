namespace HK_Farms
{
    partial class HomeRestoration
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeRestoration));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.idno = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.details = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.rtype = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.submit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.amount = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.idate = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.DataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1023, 724);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.idate);
            this.tabPage1.Controls.Add(this.date);
            this.tabPage1.Controls.Add(this.idno);
            this.tabPage1.Controls.Add(this.bunifuCustomLabel3);
            this.tabPage1.Controls.Add(this.details);
            this.tabPage1.Controls.Add(this.rtype);
            this.tabPage1.Controls.Add(this.submit);
            this.tabPage1.Controls.Add(this.bunifuCustomLabel2);
            this.tabPage1.Controls.Add(this.amount);
            this.tabPage1.Controls.Add(this.bunifuCustomLabel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1015, 698);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Restoration";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // idno
            // 
            this.idno.BackColor = System.Drawing.Color.White;
            this.idno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idno.Enabled = false;
            this.idno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.idno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.idno.HintForeColor = System.Drawing.Color.DarkGray;
            this.idno.HintText = "ID";
            this.idno.isPassword = false;
            this.idno.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.idno.LineIdleColor = System.Drawing.SystemColors.ControlDarkDark;
            this.idno.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.idno.LineThickness = 3;
            this.idno.Location = new System.Drawing.Point(352, 63);
            this.idno.Margin = new System.Windows.Forms.Padding(4);
            this.idno.Name = "idno";
            this.idno.Size = new System.Drawing.Size(313, 33);
            this.idno.TabIndex = 50;
            this.idno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(349, 177);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(89, 13);
            this.bunifuCustomLabel3.TabIndex = 49;
            this.bunifuCustomLabel3.Text = "Complete Details:";
            // 
            // details
            // 
            this.details.BorderColor = System.Drawing.Color.SeaGreen;
            this.details.Location = new System.Drawing.Point(352, 193);
            this.details.Multiline = true;
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(313, 191);
            this.details.TabIndex = 48;
            // 
            // rtype
            // 
            this.rtype.BackColor = System.Drawing.Color.White;
            this.rtype.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.rtype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtype.HintForeColor = System.Drawing.Color.DarkGray;
            this.rtype.HintText = "Restoration Type";
            this.rtype.isPassword = false;
            this.rtype.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.rtype.LineIdleColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rtype.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.rtype.LineThickness = 3;
            this.rtype.Location = new System.Drawing.Point(352, 111);
            this.rtype.Margin = new System.Windows.Forms.Padding(4);
            this.rtype.Name = "rtype";
            this.rtype.Size = new System.Drawing.Size(313, 33);
            this.rtype.TabIndex = 47;
            this.rtype.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // submit
            // 
            this.submit.ActiveBorderThickness = 1;
            this.submit.ActiveCornerRadius = 20;
            this.submit.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.submit.ActiveForecolor = System.Drawing.Color.White;
            this.submit.ActiveLineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.submit.BackColor = System.Drawing.Color.Transparent;
            this.submit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("submit.BackgroundImage")));
            this.submit.ButtonText = "SUBMIT";
            this.submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.submit.IdleBorderThickness = 3;
            this.submit.IdleCornerRadius = 20;
            this.submit.IdleFillColor = System.Drawing.Color.White;
            this.submit.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.submit.IdleLineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.submit.Location = new System.Drawing.Point(355, 643);
            this.submit.Margin = new System.Windows.Forms.Padding(5);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(310, 41);
            this.submit.TabIndex = 46;
            this.submit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(352, 480);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(66, 13);
            this.bunifuCustomLabel2.TabIndex = 45;
            this.bunifuCustomLabel2.Text = "Payed Date:";
            // 
            // amount
            // 
            this.amount.BackColor = System.Drawing.Color.White;
            this.amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.amount.HintForeColor = System.Drawing.Color.DarkGray;
            this.amount.HintText = "Amount";
            this.amount.isPassword = false;
            this.amount.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.amount.LineIdleColor = System.Drawing.SystemColors.ControlDarkDark;
            this.amount.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.amount.LineThickness = 3;
            this.amount.Location = new System.Drawing.Point(352, 403);
            this.amount.Margin = new System.Windows.Forms.Padding(4);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(313, 33);
            this.amount.TabIndex = 43;
            this.amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amount_KeyPress);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(394, 14);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(228, 31);
            this.bunifuCustomLabel1.TabIndex = 42;
            this.bunifuCustomLabel1.Text = "Home Restoration";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DataGrid1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1015, 698);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "History";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(351, 496);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(313, 20);
            this.date.TabIndex = 51;
            this.date.Value = new System.DateTime(2019, 12, 19, 0, 0, 0, 0);
            // 
            // idate
            // 
            this.idate.AutoSize = true;
            this.idate.ForeColor = System.Drawing.Color.White;
            this.idate.Location = new System.Drawing.Point(349, 540);
            this.idate.Name = "idate";
            this.idate.Size = new System.Drawing.Size(35, 13);
            this.idate.TabIndex = 52;
            this.idate.Text = "label1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DataGrid1
            // 
            this.DataGrid1.AllowUserToAddRows = false;
            this.DataGrid1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGrid1.BackgroundColor = System.Drawing.Color.White;
            this.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid1.DoubleBuffered = true;
            this.DataGrid1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGrid1.EnableHeadersVisualStyles = false;
            this.DataGrid1.HeaderBgColor = System.Drawing.Color.LightGray;
            this.DataGrid1.HeaderForeColor = System.Drawing.Color.Black;
            this.DataGrid1.Location = new System.Drawing.Point(10, 9);
            this.DataGrid1.Name = "DataGrid1";
            this.DataGrid1.ReadOnly = true;
            this.DataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid1.Size = new System.Drawing.Size(994, 632);
            this.DataGrid1.TabIndex = 29;
            // 
            // HomeRestoration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl1);
            this.Name = "HomeRestoration";
            this.Size = new System.Drawing.Size(1026, 727);
            this.Load += new System.EventHandler(this.HomeRestoration_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox idno;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox details;
        private Bunifu.Framework.UI.BunifuMaterialTextbox rtype;
        private Bunifu.Framework.UI.BunifuThinButton2 submit;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox amount;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label idate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid1;
    }
}

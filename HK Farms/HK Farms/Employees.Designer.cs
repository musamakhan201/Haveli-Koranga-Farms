namespace HK_Farms
{
    partial class Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.search = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clear = new Bunifu.Framework.UI.BunifuThinButton2();
            this.delete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.update = new Bunifu.Framework.UI.BunifuThinButton2();
            this.add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.group = new System.Windows.Forms.GroupBox();
            this.hdate = new System.Windows.Forms.DateTimePicker();
            this.idno = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.salary = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.type = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.phone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cnic = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.fname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.DataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1026, 727);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1018, 701);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Attendence";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.group);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1018, 701);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employees";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.DataGrid1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.search);
            this.groupBox3.Location = new System.Drawing.Point(6, 348);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1006, 347);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "All Employees";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "SEARCH:";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.White;
            this.search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.search.HintForeColor = System.Drawing.Color.DarkGray;
            this.search.HintText = "";
            this.search.isPassword = false;
            this.search.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.search.LineIdleColor = System.Drawing.SystemColors.ControlDarkDark;
            this.search.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.search.LineThickness = 3;
            this.search.Location = new System.Drawing.Point(385, 11);
            this.search.Margin = new System.Windows.Forms.Padding(4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(313, 33);
            this.search.TabIndex = 25;
            this.search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.clear);
            this.groupBox2.Controls.Add(this.delete);
            this.groupBox2.Controls.Add(this.update);
            this.groupBox2.Controls.Add(this.add);
            this.groupBox2.Location = new System.Drawing.Point(6, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1006, 73);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controls";
            // 
            // clear
            // 
            this.clear.ActiveBorderThickness = 1;
            this.clear.ActiveCornerRadius = 20;
            this.clear.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.clear.ActiveForecolor = System.Drawing.Color.White;
            this.clear.ActiveLineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.clear.BackColor = System.Drawing.Color.White;
            this.clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clear.BackgroundImage")));
            this.clear.ButtonText = "CLEAR";
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.clear.IdleBorderThickness = 3;
            this.clear.IdleCornerRadius = 20;
            this.clear.IdleFillColor = System.Drawing.Color.White;
            this.clear.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.clear.IdleLineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.clear.Location = new System.Drawing.Point(757, 21);
            this.clear.Margin = new System.Windows.Forms.Padding(5);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(181, 41);
            this.clear.TabIndex = 11;
            this.clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // delete
            // 
            this.delete.ActiveBorderThickness = 1;
            this.delete.ActiveCornerRadius = 20;
            this.delete.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.delete.ActiveForecolor = System.Drawing.Color.White;
            this.delete.ActiveLineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.delete.BackColor = System.Drawing.Color.White;
            this.delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete.BackgroundImage")));
            this.delete.ButtonText = "DELETE";
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.delete.IdleBorderThickness = 3;
            this.delete.IdleCornerRadius = 20;
            this.delete.IdleFillColor = System.Drawing.Color.White;
            this.delete.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.delete.IdleLineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.delete.Location = new System.Drawing.Point(528, 21);
            this.delete.Margin = new System.Windows.Forms.Padding(5);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(181, 41);
            this.delete.TabIndex = 10;
            this.delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.ActiveBorderThickness = 1;
            this.update.ActiveCornerRadius = 20;
            this.update.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.update.ActiveForecolor = System.Drawing.Color.White;
            this.update.ActiveLineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.update.BackColor = System.Drawing.Color.White;
            this.update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("update.BackgroundImage")));
            this.update.ButtonText = "UPDATE";
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.update.IdleBorderThickness = 3;
            this.update.IdleCornerRadius = 20;
            this.update.IdleFillColor = System.Drawing.Color.White;
            this.update.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.update.IdleLineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.update.Location = new System.Drawing.Point(299, 21);
            this.update.Margin = new System.Windows.Forms.Padding(5);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(181, 41);
            this.update.TabIndex = 9;
            this.update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // add
            // 
            this.add.ActiveBorderThickness = 1;
            this.add.ActiveCornerRadius = 20;
            this.add.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.add.ActiveForecolor = System.Drawing.Color.White;
            this.add.ActiveLineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.add.BackColor = System.Drawing.Color.White;
            this.add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add.BackgroundImage")));
            this.add.ButtonText = "ADD";
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.add.IdleBorderThickness = 3;
            this.add.IdleCornerRadius = 20;
            this.add.IdleFillColor = System.Drawing.Color.White;
            this.add.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.add.IdleLineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.add.Location = new System.Drawing.Point(70, 21);
            this.add.Margin = new System.Windows.Forms.Padding(5);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(181, 41);
            this.add.TabIndex = 8;
            this.add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // group
            // 
            this.group.BackColor = System.Drawing.Color.White;
            this.group.Controls.Add(this.hdate);
            this.group.Controls.Add(this.idno);
            this.group.Controls.Add(this.salary);
            this.group.Controls.Add(this.type);
            this.group.Controls.Add(this.phone);
            this.group.Controls.Add(this.cnic);
            this.group.Controls.Add(this.fname);
            this.group.Controls.Add(this.name);
            this.group.Location = new System.Drawing.Point(6, 6);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(1006, 256);
            this.group.TabIndex = 0;
            this.group.TabStop = false;
            this.group.Text = "Employee Data";
            // 
            // hdate
            // 
            this.hdate.Location = new System.Drawing.Point(566, 27);
            this.hdate.Name = "hdate";
            this.hdate.Size = new System.Drawing.Size(313, 20);
            this.hdate.TabIndex = 25;
            this.hdate.Value = new System.DateTime(2019, 12, 19, 0, 0, 0, 0);
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
            this.idno.Location = new System.Drawing.Point(111, 15);
            this.idno.Margin = new System.Windows.Forms.Padding(4);
            this.idno.Name = "idno";
            this.idno.Size = new System.Drawing.Size(313, 33);
            this.idno.TabIndex = 24;
            this.idno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // salary
            // 
            this.salary.BackColor = System.Drawing.Color.White;
            this.salary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.salary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.salary.HintForeColor = System.Drawing.Color.DarkGray;
            this.salary.HintText = "Salary";
            this.salary.isPassword = false;
            this.salary.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.salary.LineIdleColor = System.Drawing.SystemColors.ControlDarkDark;
            this.salary.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.salary.LineThickness = 3;
            this.salary.Location = new System.Drawing.Point(566, 207);
            this.salary.Margin = new System.Windows.Forms.Padding(4);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(313, 33);
            this.salary.TabIndex = 23;
            this.salary.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salary_KeyPress);
            // 
            // type
            // 
            this.type.BackColor = System.Drawing.Color.White;
            this.type.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.type.HintForeColor = System.Drawing.Color.DarkGray;
            this.type.HintText = "Employee Type";
            this.type.isPassword = false;
            this.type.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.type.LineIdleColor = System.Drawing.SystemColors.ControlDarkDark;
            this.type.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.type.LineThickness = 3;
            this.type.Location = new System.Drawing.Point(111, 207);
            this.type.Margin = new System.Windows.Forms.Padding(4);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(313, 33);
            this.type.TabIndex = 22;
            this.type.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // phone
            // 
            this.phone.BackColor = System.Drawing.Color.White;
            this.phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.phone.HintForeColor = System.Drawing.Color.DarkGray;
            this.phone.HintText = "Phone #";
            this.phone.isPassword = false;
            this.phone.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.phone.LineIdleColor = System.Drawing.SystemColors.ControlDarkDark;
            this.phone.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.phone.LineThickness = 3;
            this.phone.Location = new System.Drawing.Point(566, 143);
            this.phone.Margin = new System.Windows.Forms.Padding(4);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(313, 33);
            this.phone.TabIndex = 21;
            this.phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_KeyPress);
            // 
            // cnic
            // 
            this.cnic.BackColor = System.Drawing.Color.White;
            this.cnic.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cnic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cnic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cnic.HintForeColor = System.Drawing.Color.DarkGray;
            this.cnic.HintText = "CNIC    ( Format should be 3610241204111)";
            this.cnic.isPassword = false;
            this.cnic.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.cnic.LineIdleColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cnic.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.cnic.LineThickness = 3;
            this.cnic.Location = new System.Drawing.Point(111, 143);
            this.cnic.Margin = new System.Windows.Forms.Padding(4);
            this.cnic.Name = "cnic";
            this.cnic.Size = new System.Drawing.Size(313, 33);
            this.cnic.TabIndex = 20;
            this.cnic.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cnic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cnic_KeyPress);
            // 
            // fname
            // 
            this.fname.BackColor = System.Drawing.Color.White;
            this.fname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.fname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fname.HintForeColor = System.Drawing.Color.DarkGray;
            this.fname.HintText = "Father Name";
            this.fname.isPassword = false;
            this.fname.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.fname.LineIdleColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fname.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.fname.LineThickness = 3;
            this.fname.Location = new System.Drawing.Point(566, 79);
            this.fname.Margin = new System.Windows.Forms.Padding(4);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(313, 33);
            this.fname.TabIndex = 19;
            this.fname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.White;
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.name.HintForeColor = System.Drawing.Color.DarkGray;
            this.name.HintText = "NAME";
            this.name.isPassword = false;
            this.name.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.name.LineIdleColor = System.Drawing.SystemColors.ControlDarkDark;
            this.name.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.name.LineThickness = 3;
            this.name.Location = new System.Drawing.Point(111, 79);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(313, 33);
            this.name.TabIndex = 18;
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1018, 701);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Salary";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DataGrid1
            // 
            this.DataGrid1.AllowUserToAddRows = false;
            this.DataGrid1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGrid1.BackgroundColor = System.Drawing.Color.White;
            this.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid1.DoubleBuffered = true;
            this.DataGrid1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGrid1.EnableHeadersVisualStyles = false;
            this.DataGrid1.HeaderBgColor = System.Drawing.Color.LightGray;
            this.DataGrid1.HeaderForeColor = System.Drawing.Color.Black;
            this.DataGrid1.Location = new System.Drawing.Point(6, 52);
            this.DataGrid1.Name = "DataGrid1";
            this.DataGrid1.ReadOnly = true;
            this.DataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid1.Size = new System.Drawing.Size(994, 289);
            this.DataGrid1.TabIndex = 27;
            this.DataGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid1_CellClick);
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl1);
            this.Name = "Employees";
            this.Size = new System.Drawing.Size(1032, 733);
            this.Load += new System.EventHandler(this.Employees_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.group.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox group;
        private Bunifu.Framework.UI.BunifuMaterialTextbox salary;
        private Bunifu.Framework.UI.BunifuMaterialTextbox type;
        private Bunifu.Framework.UI.BunifuMaterialTextbox phone;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cnic;
        private Bunifu.Framework.UI.BunifuMaterialTextbox fname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox name;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox search;
        private Bunifu.Framework.UI.BunifuThinButton2 delete;
        private Bunifu.Framework.UI.BunifuThinButton2 update;
        private Bunifu.Framework.UI.BunifuThinButton2 add;
        private Bunifu.Framework.UI.BunifuMaterialTextbox idno;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker hdate;
        private Bunifu.Framework.UI.BunifuThinButton2 clear;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid1;
    }
}

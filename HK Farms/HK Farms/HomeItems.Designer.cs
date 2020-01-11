namespace HK_Farms
{
    partial class HomeItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeItems));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.idate = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.idno = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.details = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.item = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.submit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.amount = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.petrol = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gen_date = new System.Windows.Forms.Label();
            this.date_gen = new System.Windows.Forms.DateTimePicker();
            this.id_gen = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.details_gen = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.whom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.submit_generator = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.rtime = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.history = new Bunifu.Framework.UI.BunifuDropdown();
            this.DataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1023, 721);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.idate);
            this.tabPage1.Controls.Add(this.date);
            this.tabPage1.Controls.Add(this.idno);
            this.tabPage1.Controls.Add(this.bunifuCustomLabel3);
            this.tabPage1.Controls.Add(this.details);
            this.tabPage1.Controls.Add(this.item);
            this.tabPage1.Controls.Add(this.submit);
            this.tabPage1.Controls.Add(this.bunifuCustomLabel2);
            this.tabPage1.Controls.Add(this.amount);
            this.tabPage1.Controls.Add(this.bunifuCustomLabel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1015, 695);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home Items";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // idate
            // 
            this.idate.AutoSize = true;
            this.idate.ForeColor = System.Drawing.Color.White;
            this.idate.Location = new System.Drawing.Point(350, 524);
            this.idate.Name = "idate";
            this.idate.Size = new System.Drawing.Size(35, 13);
            this.idate.TabIndex = 55;
            this.idate.Text = "label1";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(352, 480);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(313, 20);
            this.date.TabIndex = 54;
            this.date.Value = new System.DateTime(2019, 12, 19, 0, 0, 0, 0);
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
            this.idno.Location = new System.Drawing.Point(351, 47);
            this.idno.Margin = new System.Windows.Forms.Padding(4);
            this.idno.Name = "idno";
            this.idno.Size = new System.Drawing.Size(313, 33);
            this.idno.TabIndex = 53;
            this.idno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(349, 162);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(89, 13);
            this.bunifuCustomLabel3.TabIndex = 52;
            this.bunifuCustomLabel3.Text = "Complete Details:";
            // 
            // details
            // 
            this.details.BorderColor = System.Drawing.Color.SeaGreen;
            this.details.Location = new System.Drawing.Point(352, 178);
            this.details.Multiline = true;
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(313, 191);
            this.details.TabIndex = 51;
            // 
            // item
            // 
            this.item.BackColor = System.Drawing.Color.White;
            this.item.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.item.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.item.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.item.HintForeColor = System.Drawing.Color.DarkGray;
            this.item.HintText = "Item";
            this.item.isPassword = false;
            this.item.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.item.LineIdleColor = System.Drawing.SystemColors.ControlDarkDark;
            this.item.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.item.LineThickness = 3;
            this.item.Location = new System.Drawing.Point(352, 96);
            this.item.Margin = new System.Windows.Forms.Padding(4);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(313, 33);
            this.item.TabIndex = 50;
            this.item.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.submit.Location = new System.Drawing.Point(355, 628);
            this.submit.Margin = new System.Windows.Forms.Padding(5);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(310, 41);
            this.submit.TabIndex = 49;
            this.submit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(352, 465);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(66, 13);
            this.bunifuCustomLabel2.TabIndex = 48;
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
            this.amount.Location = new System.Drawing.Point(352, 388);
            this.amount.Margin = new System.Windows.Forms.Padding(4);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(313, 33);
            this.amount.TabIndex = 46;
            this.amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amount_KeyPress);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(408, 8);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(154, 31);
            this.bunifuCustomLabel1.TabIndex = 45;
            this.bunifuCustomLabel1.Text = "Home Items";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.petrol);
            this.tabPage2.Controls.Add(this.gen_date);
            this.tabPage2.Controls.Add(this.date_gen);
            this.tabPage2.Controls.Add(this.id_gen);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel4);
            this.tabPage2.Controls.Add(this.details_gen);
            this.tabPage2.Controls.Add(this.whom);
            this.tabPage2.Controls.Add(this.submit_generator);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel5);
            this.tabPage2.Controls.Add(this.rtime);
            this.tabPage2.Controls.Add(this.bunifuCustomLabel6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1015, 695);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Generator Usage";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // petrol
            // 
            this.petrol.BackColor = System.Drawing.Color.White;
            this.petrol.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.petrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.petrol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.petrol.HintForeColor = System.Drawing.Color.DarkGray;
            this.petrol.HintText = "Petrol in Literes e.g. 2";
            this.petrol.isPassword = false;
            this.petrol.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.petrol.LineIdleColor = System.Drawing.SystemColors.ControlDarkDark;
            this.petrol.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.petrol.LineThickness = 3;
            this.petrol.Location = new System.Drawing.Point(351, 463);
            this.petrol.Margin = new System.Windows.Forms.Padding(4);
            this.petrol.Name = "petrol";
            this.petrol.Size = new System.Drawing.Size(313, 33);
            this.petrol.TabIndex = 66;
            this.petrol.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.petrol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.petrol_KeyPress);
            // 
            // gen_date
            // 
            this.gen_date.AutoSize = true;
            this.gen_date.ForeColor = System.Drawing.Color.White;
            this.gen_date.Location = new System.Drawing.Point(350, 590);
            this.gen_date.Name = "gen_date";
            this.gen_date.Size = new System.Drawing.Size(35, 13);
            this.gen_date.TabIndex = 65;
            this.gen_date.Text = "label1";
            // 
            // date_gen
            // 
            this.date_gen.Location = new System.Drawing.Point(352, 546);
            this.date_gen.Name = "date_gen";
            this.date_gen.Size = new System.Drawing.Size(313, 20);
            this.date_gen.TabIndex = 64;
            this.date_gen.Value = new System.DateTime(2019, 12, 19, 0, 0, 0, 0);
            // 
            // id_gen
            // 
            this.id_gen.BackColor = System.Drawing.Color.White;
            this.id_gen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.id_gen.Enabled = false;
            this.id_gen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.id_gen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.id_gen.HintForeColor = System.Drawing.Color.DarkGray;
            this.id_gen.HintText = "ID";
            this.id_gen.isPassword = false;
            this.id_gen.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.id_gen.LineIdleColor = System.Drawing.SystemColors.ControlDarkDark;
            this.id_gen.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.id_gen.LineThickness = 3;
            this.id_gen.Location = new System.Drawing.Point(351, 58);
            this.id_gen.Margin = new System.Windows.Forms.Padding(4);
            this.id_gen.Name = "id_gen";
            this.id_gen.Size = new System.Drawing.Size(313, 33);
            this.id_gen.TabIndex = 63;
            this.id_gen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(349, 173);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(89, 13);
            this.bunifuCustomLabel4.TabIndex = 62;
            this.bunifuCustomLabel4.Text = "Complete Details:";
            // 
            // details_gen
            // 
            this.details_gen.BorderColor = System.Drawing.Color.SeaGreen;
            this.details_gen.Location = new System.Drawing.Point(352, 189);
            this.details_gen.Multiline = true;
            this.details_gen.Name = "details_gen";
            this.details_gen.Size = new System.Drawing.Size(313, 191);
            this.details_gen.TabIndex = 61;
            // 
            // whom
            // 
            this.whom.BackColor = System.Drawing.Color.White;
            this.whom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.whom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.whom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.whom.HintForeColor = System.Drawing.Color.DarkGray;
            this.whom.HintText = "For Whom";
            this.whom.isPassword = false;
            this.whom.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.whom.LineIdleColor = System.Drawing.SystemColors.ControlDarkDark;
            this.whom.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.whom.LineThickness = 3;
            this.whom.Location = new System.Drawing.Point(352, 107);
            this.whom.Margin = new System.Windows.Forms.Padding(4);
            this.whom.Name = "whom";
            this.whom.Size = new System.Drawing.Size(313, 33);
            this.whom.TabIndex = 60;
            this.whom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // submit_generator
            // 
            this.submit_generator.ActiveBorderThickness = 1;
            this.submit_generator.ActiveCornerRadius = 20;
            this.submit_generator.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.submit_generator.ActiveForecolor = System.Drawing.Color.White;
            this.submit_generator.ActiveLineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.submit_generator.BackColor = System.Drawing.Color.Transparent;
            this.submit_generator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("submit_generator.BackgroundImage")));
            this.submit_generator.ButtonText = "SUBMIT";
            this.submit_generator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submit_generator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_generator.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.submit_generator.IdleBorderThickness = 3;
            this.submit_generator.IdleCornerRadius = 20;
            this.submit_generator.IdleFillColor = System.Drawing.Color.White;
            this.submit_generator.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.submit_generator.IdleLineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.submit_generator.Location = new System.Drawing.Point(355, 639);
            this.submit_generator.Margin = new System.Windows.Forms.Padding(5);
            this.submit_generator.Name = "submit_generator";
            this.submit_generator.Size = new System.Drawing.Size(310, 41);
            this.submit_generator.TabIndex = 59;
            this.submit_generator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.submit_generator.Click += new System.EventHandler(this.submit_generator_Click);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(352, 531);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(66, 13);
            this.bunifuCustomLabel5.TabIndex = 58;
            this.bunifuCustomLabel5.Text = "Payed Date:";
            // 
            // rtime
            // 
            this.rtime.BackColor = System.Drawing.Color.White;
            this.rtime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.rtime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtime.HintForeColor = System.Drawing.Color.DarkGray;
            this.rtime.HintText = "Running Time in Hours e.g. 2";
            this.rtime.isPassword = false;
            this.rtime.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.rtime.LineIdleColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rtime.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.rtime.LineThickness = 3;
            this.rtime.Location = new System.Drawing.Point(352, 399);
            this.rtime.Margin = new System.Windows.Forms.Padding(4);
            this.rtime.Name = "rtime";
            this.rtime.Size = new System.Drawing.Size(313, 33);
            this.rtime.TabIndex = 57;
            this.rtime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.rtime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtime_KeyPress);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(408, 19);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(212, 31);
            this.bunifuCustomLabel6.TabIndex = 56;
            this.bunifuCustomLabel6.Text = "Generator Usage";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.history);
            this.tabPage3.Controls.Add(this.DataGrid1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1015, 695);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "History";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // history
            // 
            this.history.BackColor = System.Drawing.Color.White;
            this.history.BorderRadius = 3;
            this.history.DisabledColor = System.Drawing.Color.Gray;
            this.history.ForeColor = System.Drawing.Color.White;
            this.history.Items = new string[] {
        "Home Items",
        "Generator Usage"};
            this.history.Location = new System.Drawing.Point(351, 9);
            this.history.Name = "history";
            this.history.NomalColor = System.Drawing.SystemColors.ControlDark;
            this.history.onHoverColor = System.Drawing.Color.SeaGreen;
            this.history.selectedIndex = 0;
            this.history.Size = new System.Drawing.Size(313, 35);
            this.history.TabIndex = 34;
            this.history.onItemSelected += new System.EventHandler(this.history_onItemSelected);
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
            this.DataGrid1.Location = new System.Drawing.Point(10, 50);
            this.DataGrid1.Name = "DataGrid1";
            this.DataGrid1.ReadOnly = true;
            this.DataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid1.Size = new System.Drawing.Size(994, 598);
            this.DataGrid1.TabIndex = 30;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // HomeItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl1);
            this.Name = "HomeItems";
            this.Size = new System.Drawing.Size(1026, 727);
            this.Load += new System.EventHandler(this.HomeItems_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox details;
        private Bunifu.Framework.UI.BunifuMaterialTextbox item;
        private Bunifu.Framework.UI.BunifuThinButton2 submit;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox amount;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid1;
        private Bunifu.Framework.UI.BunifuDropdown history;
        private Bunifu.Framework.UI.BunifuMaterialTextbox idno;
        private System.Windows.Forms.Label idate;
        private System.Windows.Forms.DateTimePicker date;
        private Bunifu.Framework.UI.BunifuMaterialTextbox petrol;
        private System.Windows.Forms.Label gen_date;
        private System.Windows.Forms.DateTimePicker date_gen;
        private Bunifu.Framework.UI.BunifuMaterialTextbox id_gen;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox details_gen;
        private Bunifu.Framework.UI.BunifuMaterialTextbox whom;
        private Bunifu.Framework.UI.BunifuThinButton2 submit_generator;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox rtime;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

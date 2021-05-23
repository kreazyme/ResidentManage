
namespace PBLnh2
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panMenu = new System.Windows.Forms.Panel();
            this.panSearch = new System.Windows.Forms.Panel();
            this.panSort = new System.Windows.Forms.Panel();
            this.panLogo = new System.Windows.Forms.Panel();
            this.panelText = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namedgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butSearchFamily = new System.Windows.Forms.Button();
            this.btnSearchCMND = new System.Windows.Forms.Button();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSortAge = new System.Windows.Forms.Button();
            this.btnSortCMND = new System.Windows.Forms.Button();
            this.btnSortName = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panMenu.SuspendLayout();
            this.panSearch.SuspendLayout();
            this.panSort.SuspendLayout();
            this.panLogo.SuspendLayout();
            this.panelText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panMenu
            // 
            this.panMenu.AutoScroll = true;
            this.panMenu.Controls.Add(this.panSearch);
            this.panMenu.Controls.Add(this.btnSearch);
            this.panMenu.Controls.Add(this.btnDelete);
            this.panMenu.Controls.Add(this.btnEdit);
            this.panMenu.Controls.Add(this.btnAdd);
            this.panMenu.Controls.Add(this.panSort);
            this.panMenu.Controls.Add(this.btnSort);
            this.panMenu.Controls.Add(this.panLogo);
            this.panMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panMenu.Location = new System.Drawing.Point(0, 0);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(277, 683);
            this.panMenu.TabIndex = 0;
            // 
            // panSearch
            // 
            this.panSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panSearch.Controls.Add(this.butSearchFamily);
            this.panSearch.Controls.Add(this.btnSearchCMND);
            this.panSearch.Controls.Add(this.btnSearchName);
            this.panSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSearch.Location = new System.Drawing.Point(0, 661);
            this.panSearch.Name = "panSearch";
            this.panSearch.Size = new System.Drawing.Size(256, 198);
            this.panSearch.TabIndex = 7;
            // 
            // panSort
            // 
            this.panSort.Controls.Add(this.btnSortAge);
            this.panSort.Controls.Add(this.btnSortCMND);
            this.panSort.Controls.Add(this.btnSortName);
            this.panSort.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSort.Location = new System.Drawing.Point(0, 206);
            this.panSort.Name = "panSort";
            this.panSort.Size = new System.Drawing.Size(256, 195);
            this.panSort.TabIndex = 2;
            // 
            // panLogo
            // 
            this.panLogo.Controls.Add(this.pictureBox1);
            this.panLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panLogo.Location = new System.Drawing.Point(0, 0);
            this.panLogo.Name = "panLogo";
            this.panLogo.Size = new System.Drawing.Size(256, 141);
            this.panLogo.TabIndex = 0;
            // 
            // panelText
            // 
            this.panelText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panelText.Controls.Add(this.label1);
            this.panelText.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelText.Location = new System.Drawing.Point(277, 0);
            this.panelText.Name = "panelText";
            this.panelText.Size = new System.Drawing.Size(918, 103);
            this.panelText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(225, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH NHÂN KHẨU";
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dtgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CMND,
            this.Namedgv,
            this.Gender,
            this.Age,
            this.Phone_Num,
            this.Address});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv.GridColor = System.Drawing.Color.White;
            this.dtgv.Location = new System.Drawing.Point(277, 103);
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgv.RowHeadersWidth = 20;
            this.dtgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.ForestGreen;
            this.dtgv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgv.RowTemplate.Height = 24;
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv.Size = new System.Drawing.Size(918, 580);
            this.dtgv.TabIndex = 2;
            // 
            // CMND
            // 
            this.CMND.HeaderText = "Số CMND";
            this.CMND.MinimumWidth = 6;
            this.CMND.Name = "CMND";
            this.CMND.ReadOnly = true;
            // 
            // Namedgv
            // 
            this.Namedgv.HeaderText = "Họ tên";
            this.Namedgv.MinimumWidth = 6;
            this.Namedgv.Name = "Namedgv";
            this.Namedgv.ReadOnly = true;
            this.Namedgv.Width = 125;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Giới tính";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 90;
            // 
            // Age
            // 
            this.Age.HeaderText = "Năm sinh";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Width = 95;
            // 
            // Phone_Num
            // 
            this.Phone_Num.HeaderText = "SDT";
            this.Phone_Num.MinimumWidth = 6;
            this.Phone_Num.Name = "Phone_Num";
            this.Phone_Num.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Địa chỉ";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 150;
            // 
            // butSearchFamily
            // 
            this.butSearchFamily.BackColor = System.Drawing.Color.White;
            this.butSearchFamily.Dock = System.Windows.Forms.DockStyle.Top;
            this.butSearchFamily.FlatAppearance.BorderSize = 0;
            this.butSearchFamily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSearchFamily.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSearchFamily.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.butSearchFamily.Image = global::PBLnh2.Properties.Resources.family__v1;
            this.butSearchFamily.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butSearchFamily.Location = new System.Drawing.Point(0, 130);
            this.butSearchFamily.Name = "butSearchFamily";
            this.butSearchFamily.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.butSearchFamily.Size = new System.Drawing.Size(256, 65);
            this.butSearchFamily.TabIndex = 4;
            this.butSearchFamily.Text = "  Hộ gia đình";
            this.butSearchFamily.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butSearchFamily.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butSearchFamily.UseVisualStyleBackColor = false;
            // 
            // btnSearchCMND
            // 
            this.btnSearchCMND.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearchCMND.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchCMND.FlatAppearance.BorderSize = 0;
            this.btnSearchCMND.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCMND.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCMND.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnSearchCMND.Image = global::PBLnh2.Properties.Resources.cmnd2;
            this.btnSearchCMND.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCMND.Location = new System.Drawing.Point(0, 65);
            this.btnSearchCMND.Name = "btnSearchCMND";
            this.btnSearchCMND.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSearchCMND.Size = new System.Drawing.Size(256, 65);
            this.btnSearchCMND.TabIndex = 3;
            this.btnSearchCMND.Text = "  Số CMND";
            this.btnSearchCMND.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCMND.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchCMND.UseVisualStyleBackColor = false;
            this.btnSearchCMND.Click += new System.EventHandler(this.btnSearchCMND_Click);
            // 
            // btnSearchName
            // 
            this.btnSearchName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearchName.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchName.FlatAppearance.BorderSize = 0;
            this.btnSearchName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnSearchName.Image = global::PBLnh2.Properties.Resources.age2;
            this.btnSearchName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchName.Location = new System.Drawing.Point(0, 0);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSearchName.Size = new System.Drawing.Size(256, 65);
            this.btnSearchName.TabIndex = 2;
            this.btnSearchName.Text = "  Họ và tên";
            this.btnSearchName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchName.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchName.UseVisualStyleBackColor = false;
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnSearch.Image = global::PBLnh2.Properties.Resources.search1;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(0, 596);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSearch.Size = new System.Drawing.Size(256, 65);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "  Tìm kiếm theo";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnDelete.Image = global::PBLnh2.Properties.Resources.delete1;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(0, 531);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(256, 65);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "  Xoá nhân khẩu";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnEdit.Image = global::PBLnh2.Properties.Resources.edit2;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(0, 466);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnEdit.Size = new System.Drawing.Size(256, 65);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "  Chỉnh sửa";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnAdd.Image = global::PBLnh2.Properties.Resources.add2;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(0, 401);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(256, 65);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "  Thêm nhân khẩu";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSortAge
            // 
            this.btnSortAge.BackColor = System.Drawing.Color.White;
            this.btnSortAge.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSortAge.FlatAppearance.BorderSize = 0;
            this.btnSortAge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortAge.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnSortAge.Image = global::PBLnh2.Properties.Resources.age2;
            this.btnSortAge.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSortAge.Location = new System.Drawing.Point(0, 130);
            this.btnSortAge.Name = "btnSortAge";
            this.btnSortAge.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSortAge.Size = new System.Drawing.Size(256, 65);
            this.btnSortAge.TabIndex = 4;
            this.btnSortAge.Text = "  Năm sinh";
            this.btnSortAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSortAge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSortAge.UseVisualStyleBackColor = false;
            this.btnSortAge.Click += new System.EventHandler(this.btnSortAge_Click);
            // 
            // btnSortCMND
            // 
            this.btnSortCMND.BackColor = System.Drawing.Color.White;
            this.btnSortCMND.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSortCMND.FlatAppearance.BorderSize = 0;
            this.btnSortCMND.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortCMND.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortCMND.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnSortCMND.Image = global::PBLnh2.Properties.Resources.cmnd2;
            this.btnSortCMND.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSortCMND.Location = new System.Drawing.Point(0, 65);
            this.btnSortCMND.Name = "btnSortCMND";
            this.btnSortCMND.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSortCMND.Size = new System.Drawing.Size(256, 65);
            this.btnSortCMND.TabIndex = 3;
            this.btnSortCMND.Text = "  CMND";
            this.btnSortCMND.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSortCMND.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSortCMND.UseVisualStyleBackColor = false;
            this.btnSortCMND.Click += new System.EventHandler(this.btnSortCMND_Click);
            // 
            // btnSortName
            // 
            this.btnSortName.BackColor = System.Drawing.Color.White;
            this.btnSortName.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSortName.FlatAppearance.BorderSize = 0;
            this.btnSortName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnSortName.Image = global::PBLnh2.Properties.Resources.name;
            this.btnSortName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSortName.Location = new System.Drawing.Point(0, 0);
            this.btnSortName.Name = "btnSortName";
            this.btnSortName.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSortName.Size = new System.Drawing.Size(256, 65);
            this.btnSortName.TabIndex = 2;
            this.btnSortName.Text = "  Họ và tên";
            this.btnSortName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSortName.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSortName.UseVisualStyleBackColor = false;
            this.btnSortName.Click += new System.EventHandler(this.btnSortName_Click);
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.White;
            this.btnSort.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSort.FlatAppearance.BorderSize = 0;
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnSort.Image = global::PBLnh2.Properties.Resources.sort2;
            this.btnSort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSort.Location = new System.Drawing.Point(0, 141);
            this.btnSort.Name = "btnSort";
            this.btnSort.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSort.Size = new System.Drawing.Size(256, 65);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "  Sắp xếp theo";
            this.btnSort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PBLnh2.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1195, 683);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.panelText);
            this.Controls.Add(this.panMenu);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panMenu.ResumeLayout(false);
            this.panSearch.ResumeLayout(false);
            this.panSort.ResumeLayout(false);
            this.panLogo.ResumeLayout(false);
            this.panelText.ResumeLayout(false);
            this.panelText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMenu;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Panel panLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panSort;
        private System.Windows.Forms.Button btnSortAge;
        private System.Windows.Forms.Button btnSortCMND;
        private System.Windows.Forms.Button btnSortName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panSearch;
        private System.Windows.Forms.Button btnSearchCMND;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.Panel panelText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namedgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.Button butSearchFamily;
    }
}
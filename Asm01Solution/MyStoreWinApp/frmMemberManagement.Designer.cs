namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            this.dgvMemberList = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.btnSortName = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.txtWelcomeUser = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMemberList
            // 
            this.dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberList.Location = new System.Drawing.Point(18, 203);
            this.dgvMemberList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMemberList.Name = "dgvMemberList";
            this.dgvMemberList.RowHeadersWidth = 51;
            this.dgvMemberList.RowTemplate.Height = 25;
            this.dgvMemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberList.Size = new System.Drawing.Size(768, 341);
            this.dgvMemberList.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(18, 128);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search keyword...";
            this.txtSearch.Size = new System.Drawing.Size(191, 27);
            this.txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(219, 128);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 31);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // cboCity
            // 
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Location = new System.Drawing.Point(402, 160);
            this.cboCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(138, 28);
            this.cboCity.TabIndex = 5;
            this.cboCity.Text = "City";
            // 
            // cboCountry
            // 
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(558, 160);
            this.cboCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(138, 28);
            this.cboCountry.TabIndex = 6;
            // 
            // btnSortName
            // 
            this.btnSortName.Location = new System.Drawing.Point(119, 160);
            this.btnSortName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSortName.Name = "btnSortName";
            this.btnSortName.Size = new System.Drawing.Size(91, 31);
            this.btnSortName.TabIndex = 7;
            this.btnSortName.Text = "Ascending";
            this.btnSortName.UseVisualStyleBackColor = true;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(18, 32);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(304, 37);
            this.lbTitle.TabIndex = 8;
            this.lbTitle.Text = "Member Management";
            // 
            // txtWelcomeUser
            // 
            this.txtWelcomeUser.AutoSize = true;
            this.txtWelcomeUser.Location = new System.Drawing.Point(731, 32);
            this.txtWelcomeUser.Name = "txtWelcomeUser";
            this.txtWelcomeUser.Size = new System.Drawing.Size(75, 20);
            this.txtWelcomeUser.TabIndex = 9;
            this.txtWelcomeUser.Text = "Welcome ";
            this.txtWelcomeUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtWelcomeUser.Click += new System.EventHandler(this.txtWelcomeUser_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(805, 21);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(86, 32);
            this.btnSignOut.TabIndex = 10;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(805, 203);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 31);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(805, 352);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 31);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(805, 512);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 31);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // frmMemberManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 556);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.txtWelcomeUser);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnSortName);
            this.Controls.Add(this.cboCountry);
            this.Controls.Add(this.cboCity);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvMemberList);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMemberManagement";
            this.Text = "Member Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dgvMemberList;
        private TextBox txtSearch;
        private Button btnSearch;
        private ComboBox cboCity;
        private ComboBox cboCountry;
        private Button btnSortName;
        private Label lbTitle;
        private Label txtWelcomeUser;
        private Button btnSignOut;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
namespace DesktopHranitel
{
    partial class SubUnitUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubUnitUserForm));
            this.logoLabel = new System.Windows.Forms.Label();
            this.dateEneringGroupOrderByDate = new System.Windows.Forms.TabControl();
            this.groupPage = new System.Windows.Forms.TabPage();
            this.CreateReportButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddGroupToBlackList = new System.Windows.Forms.Button();
            this.openUserDataGroup = new System.Windows.Forms.Button();
            this.OrderByButton = new System.Windows.Forms.Button();
            this.dateEnteringGroup = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupUsersDataGrid = new System.Windows.Forms.DataGridView();
            this.privatePage = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.addIndToBlackListTextBox = new System.Windows.Forms.TextBox();
            this.AddIndUserToBlackList = new System.Windows.Forms.Button();
            this.OpenIndUserData = new System.Windows.Forms.Button();
            this.OrderByButtonInd = new System.Windows.Forms.Button();
            this.indDateEntering = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.indDataGrid = new System.Windows.Forms.DataGridView();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.dateEneringGroupOrderByDate.SuspendLayout();
            this.groupPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupUsersDataGrid)).BeginInit();
            this.privatePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(204)))), ((int)(((byte)(10)))));
            this.logoLabel.Location = new System.Drawing.Point(72, 17);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(563, 30);
            this.logoLabel.TabIndex = 6;
            this.logoLabel.Text = "ХранительПро - Панель сотрудника подразделения";
            // 
            // dateEneringGroupOrderByDate
            // 
            this.dateEneringGroupOrderByDate.Controls.Add(this.groupPage);
            this.dateEneringGroupOrderByDate.Controls.Add(this.privatePage);
            this.dateEneringGroupOrderByDate.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateEneringGroupOrderByDate.Location = new System.Drawing.Point(12, 68);
            this.dateEneringGroupOrderByDate.Name = "dateEneringGroupOrderByDate";
            this.dateEneringGroupOrderByDate.SelectedIndex = 0;
            this.dateEneringGroupOrderByDate.Size = new System.Drawing.Size(776, 370);
            this.dateEneringGroupOrderByDate.TabIndex = 7;
            // 
            // groupPage
            // 
            this.groupPage.Controls.Add(this.label3);
            this.groupPage.Controls.Add(this.textBox1);
            this.groupPage.Controls.Add(this.AddGroupToBlackList);
            this.groupPage.Controls.Add(this.openUserDataGroup);
            this.groupPage.Controls.Add(this.OrderByButton);
            this.groupPage.Controls.Add(this.dateEnteringGroup);
            this.groupPage.Controls.Add(this.label1);
            this.groupPage.Controls.Add(this.groupUsersDataGrid);
            this.groupPage.Location = new System.Drawing.Point(4, 24);
            this.groupPage.Name = "groupPage";
            this.groupPage.Padding = new System.Windows.Forms.Padding(3);
            this.groupPage.Size = new System.Drawing.Size(768, 342);
            this.groupPage.TabIndex = 0;
            this.groupPage.Text = "Групповые посещения";
            this.groupPage.UseVisualStyleBackColor = true;
            // 
            // CreateReportButton
            // 
            this.CreateReportButton.Location = new System.Drawing.Point(618, 50);
            this.CreateReportButton.Name = "CreateReportButton";
            this.CreateReportButton.Size = new System.Drawing.Size(163, 23);
            this.CreateReportButton.TabIndex = 15;
            this.CreateReportButton.Text = "Сформировать отчет";
            this.CreateReportButton.UseVisualStyleBackColor = true;
            this.CreateReportButton.Click += new System.EventHandler(this.CreateReportButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Введите ФИО пользователя для внесения в ЧС:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(271, 311);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 13;
            // 
            // AddGroupToBlackList
            // 
            this.AddGroupToBlackList.Location = new System.Drawing.Point(377, 310);
            this.AddGroupToBlackList.Name = "AddGroupToBlackList";
            this.AddGroupToBlackList.Size = new System.Drawing.Size(163, 23);
            this.AddGroupToBlackList.TabIndex = 12;
            this.AddGroupToBlackList.Text = "Добавить в черный список";
            this.AddGroupToBlackList.UseVisualStyleBackColor = true;
            this.AddGroupToBlackList.Click += new System.EventHandler(this.AddGroupToBlackList_Click);
            // 
            // openUserDataGroup
            // 
            this.openUserDataGroup.Location = new System.Drawing.Point(368, 22);
            this.openUserDataGroup.Name = "openUserDataGroup";
            this.openUserDataGroup.Size = new System.Drawing.Size(205, 23);
            this.openUserDataGroup.TabIndex = 4;
            this.openUserDataGroup.Text = "Открыть информацию о человеке";
            this.openUserDataGroup.UseVisualStyleBackColor = true;
            this.openUserDataGroup.Click += new System.EventHandler(this.openUserDataGroup_Click);
            // 
            // OrderByButton
            // 
            this.OrderByButton.Location = new System.Drawing.Point(237, 22);
            this.OrderByButton.Name = "OrderByButton";
            this.OrderByButton.Size = new System.Drawing.Size(125, 23);
            this.OrderByButton.TabIndex = 3;
            this.OrderByButton.Text = "Отфильтровать";
            this.OrderByButton.UseVisualStyleBackColor = true;
            this.OrderByButton.Click += new System.EventHandler(this.OrderByButton_Click);
            // 
            // dateEnteringGroup
            // 
            this.dateEnteringGroup.Location = new System.Drawing.Point(17, 22);
            this.dateEnteringGroup.Name = "dateEnteringGroup";
            this.dateEnteringGroup.Size = new System.Drawing.Size(200, 23);
            this.dateEnteringGroup.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фильтр по дате:";
            // 
            // groupUsersDataGrid
            // 
            this.groupUsersDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.groupUsersDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.groupUsersDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.groupUsersDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.groupUsersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.groupUsersDataGrid.GridColor = System.Drawing.Color.White;
            this.groupUsersDataGrid.Location = new System.Drawing.Point(6, 64);
            this.groupUsersDataGrid.Name = "groupUsersDataGrid";
            this.groupUsersDataGrid.Size = new System.Drawing.Size(736, 242);
            this.groupUsersDataGrid.TabIndex = 0;
            // 
            // privatePage
            // 
            this.privatePage.Controls.Add(this.label5);
            this.privatePage.Controls.Add(this.addIndToBlackListTextBox);
            this.privatePage.Controls.Add(this.AddIndUserToBlackList);
            this.privatePage.Controls.Add(this.OpenIndUserData);
            this.privatePage.Controls.Add(this.OrderByButtonInd);
            this.privatePage.Controls.Add(this.indDateEntering);
            this.privatePage.Controls.Add(this.label2);
            this.privatePage.Controls.Add(this.indDataGrid);
            this.privatePage.Location = new System.Drawing.Point(4, 24);
            this.privatePage.Name = "privatePage";
            this.privatePage.Padding = new System.Windows.Forms.Padding(3);
            this.privatePage.Size = new System.Drawing.Size(768, 342);
            this.privatePage.TabIndex = 1;
            this.privatePage.Text = "Индивидуальные посещения";
            this.privatePage.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Введите ФИО пользователя для внесения в ЧС:";
            // 
            // addIndToBlackListTextBox
            // 
            this.addIndToBlackListTextBox.Location = new System.Drawing.Point(271, 313);
            this.addIndToBlackListTextBox.Name = "addIndToBlackListTextBox";
            this.addIndToBlackListTextBox.Size = new System.Drawing.Size(100, 23);
            this.addIndToBlackListTextBox.TabIndex = 10;
            // 
            // AddIndUserToBlackList
            // 
            this.AddIndUserToBlackList.Location = new System.Drawing.Point(377, 313);
            this.AddIndUserToBlackList.Name = "AddIndUserToBlackList";
            this.AddIndUserToBlackList.Size = new System.Drawing.Size(163, 23);
            this.AddIndUserToBlackList.TabIndex = 8;
            this.AddIndUserToBlackList.Text = "Добавить в черный список";
            this.AddIndUserToBlackList.UseVisualStyleBackColor = true;
            this.AddIndUserToBlackList.Click += new System.EventHandler(this.AddIndUserToBlackList_Click);
            // 
            // OpenIndUserData
            // 
            this.OpenIndUserData.Location = new System.Drawing.Point(355, 21);
            this.OpenIndUserData.Name = "OpenIndUserData";
            this.OpenIndUserData.Size = new System.Drawing.Size(205, 23);
            this.OpenIndUserData.TabIndex = 7;
            this.OpenIndUserData.Text = "Открыть информацию о человеке";
            this.OpenIndUserData.UseVisualStyleBackColor = true;
            this.OpenIndUserData.Click += new System.EventHandler(this.OpenIndUserData_Click);
            // 
            // OrderByButtonInd
            // 
            this.OrderByButtonInd.Location = new System.Drawing.Point(233, 21);
            this.OrderByButtonInd.Name = "OrderByButtonInd";
            this.OrderByButtonInd.Size = new System.Drawing.Size(116, 23);
            this.OrderByButtonInd.TabIndex = 5;
            this.OrderByButtonInd.Text = "Отфильтровать";
            this.OrderByButtonInd.UseVisualStyleBackColor = true;
            this.OrderByButtonInd.Click += new System.EventHandler(this.OrderByButtonInd_Click);
            // 
            // indDateEntering
            // 
            this.indDateEntering.Location = new System.Drawing.Point(9, 21);
            this.indDateEntering.Name = "indDateEntering";
            this.indDateEntering.Size = new System.Drawing.Size(200, 23);
            this.indDateEntering.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фильтр по дате:";
            // 
            // indDataGrid
            // 
            this.indDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.indDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.indDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.indDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.indDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.indDataGrid.GridColor = System.Drawing.Color.White;
            this.indDataGrid.Location = new System.Drawing.Point(3, 64);
            this.indDataGrid.Name = "indDataGrid";
            this.indDataGrid.Size = new System.Drawing.Size(726, 242);
            this.indDataGrid.TabIndex = 1;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::DesktopHranitel.Properties.Resources.logo;
            this.logoPictureBox.Location = new System.Drawing.Point(12, 12);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(54, 50);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 5;
            this.logoPictureBox.TabStop = false;
            // 
            // SubUnitUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateReportButton);
            this.Controls.Add(this.dateEneringGroupOrderByDate);
            this.Controls.Add(this.logoLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SubUnitUserForm";
            this.Text = "ХранительПро - Сотрудник подразделения";
            this.dateEneringGroupOrderByDate.ResumeLayout(false);
            this.groupPage.ResumeLayout(false);
            this.groupPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupUsersDataGrid)).EndInit();
            this.privatePage.ResumeLayout(false);
            this.privatePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.TabControl dateEneringGroupOrderByDate;
        private System.Windows.Forms.TabPage groupPage;
        private System.Windows.Forms.DateTimePicker dateEnteringGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView groupUsersDataGrid;
        private System.Windows.Forms.TabPage privatePage;
        private System.Windows.Forms.DataGridView indDataGrid;
        private System.Windows.Forms.DateTimePicker indDateEntering;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OrderByButton;
        private System.Windows.Forms.Button OrderByButtonInd;
        private System.Windows.Forms.Button openUserDataGroup;
        private System.Windows.Forms.Button AddIndUserToBlackList;
        private System.Windows.Forms.Button OpenIndUserData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addIndToBlackListTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddGroupToBlackList;
        private System.Windows.Forms.Button CreateReportButton;
    }
}
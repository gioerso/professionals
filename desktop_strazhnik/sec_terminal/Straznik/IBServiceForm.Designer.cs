namespace Straznik
{
    partial class IBServiceForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IBServiceForm));
            this.nameLabel = new System.Windows.Forms.Label();
            this.authLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.verifyPage = new System.Windows.Forms.TabPage();
            this.userTypeComboBox = new System.Windows.Forms.ComboBox();
            this.veifyUser = new System.Windows.Forms.Button();
            this.verifyDataGrid = new System.Windows.Forms.DataGridView();
            this.entryPage = new System.Windows.Forms.TabPage();
            this.executeMandatsButton = new System.Windows.Forms.Button();
            this.mandatsDataGrid = new System.Windows.Forms.DataGridView();
            this.user06DataSet = new Straznik.User06DataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Straznik.User06DataSetTableAdapters.usersTableAdapter();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.verifyPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verifyDataGrid)).BeginInit();
            this.entryPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mandatsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user06DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(872, 45);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(53, 13);
            this.nameLabel.TabIndex = 27;
            this.nameLabel.Text = "username";
            // 
            // authLabel
            // 
            this.authLabel.AutoSize = true;
            this.authLabel.BackColor = System.Drawing.Color.White;
            this.authLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(230)))), ((int)(((byte)(48)))));
            this.authLabel.Location = new System.Drawing.Point(78, 20);
            this.authLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.authLabel.Name = "authLabel";
            this.authLabel.Size = new System.Drawing.Size(324, 29);
            this.authLabel.TabIndex = 26;
            this.authLabel.Text = "Стражник - Панель службы ИБ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Straznik.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(8, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.verifyPage);
            this.tabControl1.Controls.Add(this.entryPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 75);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(954, 363);
            this.tabControl1.TabIndex = 28;
            // 
            // verifyPage
            // 
            this.verifyPage.BackColor = System.Drawing.Color.White;
            this.verifyPage.Controls.Add(this.userTypeComboBox);
            this.verifyPage.Controls.Add(this.veifyUser);
            this.verifyPage.Controls.Add(this.verifyDataGrid);
            this.verifyPage.Location = new System.Drawing.Point(4, 22);
            this.verifyPage.Name = "verifyPage";
            this.verifyPage.Padding = new System.Windows.Forms.Padding(3);
            this.verifyPage.Size = new System.Drawing.Size(946, 337);
            this.verifyPage.TabIndex = 0;
            this.verifyPage.Text = "Верификация";
            // 
            // userTypeComboBox
            // 
            this.userTypeComboBox.FormattingEnabled = true;
            this.userTypeComboBox.Items.AddRange(new object[] {
            "Администратор доступа",
            "Служба ИБ",
            "Руководитель ПОП",
            "Контролёр МО"});
            this.userTypeComboBox.Location = new System.Drawing.Point(335, 285);
            this.userTypeComboBox.Name = "userTypeComboBox";
            this.userTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.userTypeComboBox.TabIndex = 2;
            this.userTypeComboBox.Text = "Тип пользователя";
            // 
            // veifyUser
            // 
            this.veifyUser.Location = new System.Drawing.Point(479, 283);
            this.veifyUser.Name = "veifyUser";
            this.veifyUser.Size = new System.Drawing.Size(147, 23);
            this.veifyUser.TabIndex = 1;
            this.veifyUser.Text = "Одобрить выбранного";
            this.veifyUser.UseVisualStyleBackColor = true;
            this.veifyUser.Click += new System.EventHandler(this.veifyUser_Click);
            // 
            // verifyDataGrid
            // 
            this.verifyDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.verifyDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.verifyDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(230)))), ((int)(((byte)(48)))));
            this.verifyDataGrid.Location = new System.Drawing.Point(6, 6);
            this.verifyDataGrid.MultiSelect = false;
            this.verifyDataGrid.Name = "verifyDataGrid";
            this.verifyDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.verifyDataGrid.Size = new System.Drawing.Size(934, 273);
            this.verifyDataGrid.TabIndex = 0;
            // 
            // entryPage
            // 
            this.entryPage.Controls.Add(this.executeMandatsButton);
            this.entryPage.Controls.Add(this.mandatsDataGrid);
            this.entryPage.Location = new System.Drawing.Point(4, 22);
            this.entryPage.Name = "entryPage";
            this.entryPage.Padding = new System.Windows.Forms.Padding(3);
            this.entryPage.Size = new System.Drawing.Size(946, 337);
            this.entryPage.TabIndex = 1;
            this.entryPage.Text = "Мандаты доступа";
            this.entryPage.UseVisualStyleBackColor = true;
            // 
            // executeMandatsButton
            // 
            this.executeMandatsButton.Location = new System.Drawing.Point(396, 285);
            this.executeMandatsButton.Name = "executeMandatsButton";
            this.executeMandatsButton.Size = new System.Drawing.Size(147, 46);
            this.executeMandatsButton.TabIndex = 2;
            this.executeMandatsButton.Text = "Применить для выбранного";
            this.executeMandatsButton.UseVisualStyleBackColor = true;
            this.executeMandatsButton.Click += new System.EventHandler(this.executeMandatsButton_Click);
            // 
            // mandatsDataGrid
            // 
            this.mandatsDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.mandatsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mandatsDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(230)))), ((int)(((byte)(48)))));
            this.mandatsDataGrid.Location = new System.Drawing.Point(3, 6);
            this.mandatsDataGrid.MultiSelect = false;
            this.mandatsDataGrid.Name = "mandatsDataGrid";
            this.mandatsDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.mandatsDataGrid.Size = new System.Drawing.Size(934, 273);
            this.mandatsDataGrid.TabIndex = 1;
            // 
            // user06DataSet
            // 
            this.user06DataSet.DataSetName = "User06DataSet";
            this.user06DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.user06DataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.IndianRed;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Location = new System.Drawing.Point(942, 5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(20, 22);
            this.ExitButton.TabIndex = 29;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // IBServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(978, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.authLabel);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IBServiceForm";
            this.Text = "Стражник - Служба информационной безопасности";
            this.Load += new System.EventHandler(this.IBServiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.verifyPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.verifyDataGrid)).EndInit();
            this.entryPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mandatsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user06DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label authLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage verifyPage;
        private System.Windows.Forms.TabPage entryPage;
        private System.Windows.Forms.DataGridView verifyDataGrid;
        private User06DataSet user06DataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private User06DataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button veifyUser;
        private System.Windows.Forms.ComboBox userTypeComboBox;
        private System.Windows.Forms.DataGridView mandatsDataGrid;
        private System.Windows.Forms.Button executeMandatsButton;
    }
}
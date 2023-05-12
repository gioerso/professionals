namespace Straznik
{
    partial class EntryAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryAdminForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.addPhotoButton = new System.Windows.Forms.Button();
            this.cancelUserButton = new System.Windows.Forms.Button();
            this.saveUserButton = new System.Windows.Forms.Button();
            this.photoImage = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.MiddleNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.authLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(733, 302);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.addPhotoButton);
            this.tabPage1.Controls.Add(this.cancelUserButton);
            this.tabPage1.Controls.Add(this.saveUserButton);
            this.tabPage1.Controls.Add(this.photoImage);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.positionTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.sexComboBox);
            this.tabPage1.Controls.Add(this.FirstNameTextBox);
            this.tabPage1.Controls.Add(this.MiddleNameTextBox);
            this.tabPage1.Controls.Add(this.LastNameTextBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.loginLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(725, 274);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Управление доступом";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // addPhotoButton
            // 
            this.addPhotoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addPhotoButton.Location = new System.Drawing.Point(400, 131);
            this.addPhotoButton.Name = "addPhotoButton";
            this.addPhotoButton.Size = new System.Drawing.Size(100, 23);
            this.addPhotoButton.TabIndex = 22;
            this.addPhotoButton.Text = "Добавить фото";
            this.addPhotoButton.UseVisualStyleBackColor = true;
            this.addPhotoButton.Click += new System.EventHandler(this.addPhotoButton_Click);
            // 
            // cancelUserButton
            // 
            this.cancelUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelUserButton.Location = new System.Drawing.Point(186, 219);
            this.cancelUserButton.Name = "cancelUserButton";
            this.cancelUserButton.Size = new System.Drawing.Size(164, 23);
            this.cancelUserButton.TabIndex = 21;
            this.cancelUserButton.Text = "Отменить";
            this.cancelUserButton.UseVisualStyleBackColor = true;
            this.cancelUserButton.Click += new System.EventHandler(this.cancelUserButton_Click);
            // 
            // saveUserButton
            // 
            this.saveUserButton.BackColor = System.Drawing.Color.White;
            this.saveUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveUserButton.Location = new System.Drawing.Point(186, 190);
            this.saveUserButton.Name = "saveUserButton";
            this.saveUserButton.Size = new System.Drawing.Size(164, 23);
            this.saveUserButton.TabIndex = 20;
            this.saveUserButton.Text = "Сохранить";
            this.saveUserButton.UseVisualStyleBackColor = false;
            this.saveUserButton.Click += new System.EventHandler(this.saveUserButton_Click);
            // 
            // photoImage
            // 
            this.photoImage.Image = global::Straznik.Properties.Resources.User;
            this.photoImage.Location = new System.Drawing.Point(400, 25);
            this.photoImage.Name = "photoImage";
            this.photoImage.Size = new System.Drawing.Size(100, 100);
            this.photoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoImage.TabIndex = 18;
            this.photoImage.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Введите должность:";
            // 
            // positionTextBox
            // 
            this.positionTextBox.Location = new System.Drawing.Point(167, 141);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(183, 23);
            this.positionTextBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Укажите пол:";
            // 
            // sexComboBox
            // 
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Items.AddRange(new object[] {
            "М",
            "Ж"});
            this.sexComboBox.Location = new System.Drawing.Point(167, 112);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(39, 23);
            this.sexComboBox.TabIndex = 14;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(167, 54);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(183, 23);
            this.FirstNameTextBox.TabIndex = 13;
            // 
            // MiddleNameTextBox
            // 
            this.MiddleNameTextBox.Location = new System.Drawing.Point(167, 83);
            this.MiddleNameTextBox.Name = "MiddleNameTextBox";
            this.MiddleNameTextBox.Size = new System.Drawing.Size(183, 23);
            this.MiddleNameTextBox.TabIndex = 12;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(167, 25);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(183, 23);
            this.LastNameTextBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Введите отчество:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Введите имя:";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(50, 28);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(111, 15);
            this.loginLabel.TabIndex = 8;
            this.loginLabel.Text = "Введите фамилию:";
            // 
            // authLabel
            // 
            this.authLabel.AutoSize = true;
            this.authLabel.BackColor = System.Drawing.Color.White;
            this.authLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(230)))), ((int)(((byte)(48)))));
            this.authLabel.Location = new System.Drawing.Point(77, 18);
            this.authLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.authLabel.Name = "authLabel";
            this.authLabel.Size = new System.Drawing.Size(461, 29);
            this.authLabel.TabIndex = 3;
            this.authLabel.Text = "Стражник - Панель администратора доступа";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.IndianRed;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Location = new System.Drawing.Point(545, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(20, 22);
            this.ExitButton.TabIndex = 23;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(469, 53);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(55, 15);
            this.nameLabel.TabIndex = 24;
            this.nameLabel.Text = "username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Straznik.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(7, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "fileDialog";
            // 
            // EntryAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(577, 385);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.authLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "EntryAdminForm";
            this.Text = "Стражник - Панель администратора доступа";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label authLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox MiddleNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.PictureBox photoImage;
        private System.Windows.Forms.Button cancelUserButton;
        private System.Windows.Forms.Button saveUserButton;
        private System.Windows.Forms.Button addPhotoButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.OpenFileDialog fileDialog;
    }
}
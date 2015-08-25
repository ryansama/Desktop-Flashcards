namespace Desktop_Flashcards
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cardCreatedAlert = new System.Windows.Forms.PictureBox();
            this.createCardBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.deleteGroupBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.createGroupBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.createGroupInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardCreatedAlert)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(12, 115);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(717, 358);
            this.materialTabControl1.TabIndex = 1;
            this.materialTabControl1.SelectedIndexChanged += new System.EventHandler(this.materialTabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialRaisedButton2);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Controls.Add(this.flowLayoutPanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(709, 332);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Read";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(296, 288);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(116, 38);
            this.materialRaisedButton2.TabIndex = 6;
            this.materialRaisedButton2.Text = "READ";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(275, 50);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(158, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "SELECT CARD GROUP";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(82, 86);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(544, 182);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.materialLabel1);
            this.tabPage2.Controls.Add(this.flowLayoutPanel1);
            this.tabPage2.Controls.Add(this.cardCreatedAlert);
            this.tabPage2.Controls.Add(this.createCardBtn);
            this.tabPage2.Controls.Add(this.materialSingleLineTextField2);
            this.tabPage2.Controls.Add(this.materialSingleLineTextField1);
            this.tabPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(709, 332);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(222, 161);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(158, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "SELECT CARD GROUP";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(46, 183);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(511, 143);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // cardCreatedAlert
            // 
            this.cardCreatedAlert.Image = ((System.Drawing.Image)(resources.GetObject("cardCreatedAlert.Image")));
            this.cardCreatedAlert.Location = new System.Drawing.Point(563, 230);
            this.cardCreatedAlert.Name = "cardCreatedAlert";
            this.cardCreatedAlert.Size = new System.Drawing.Size(140, 50);
            this.cardCreatedAlert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cardCreatedAlert.TabIndex = 2;
            this.cardCreatedAlert.TabStop = false;
            this.cardCreatedAlert.Visible = false;
            // 
            // createCardBtn
            // 
            this.createCardBtn.Depth = 0;
            this.createCardBtn.Location = new System.Drawing.Point(576, 286);
            this.createCardBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.createCardBtn.Name = "createCardBtn";
            this.createCardBtn.Primary = true;
            this.createCardBtn.Size = new System.Drawing.Size(127, 40);
            this.createCardBtn.TabIndex = 1;
            this.createCardBtn.Text = "Create Card";
            this.createCardBtn.UseVisualStyleBackColor = true;
            this.createCardBtn.Click += new System.EventHandler(this.createCardBtn_Click);
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "Back";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(46, 112);
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(596, 23);
            this.materialSingleLineTextField2.TabIndex = 0;
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.materialSingleLineTextField1.Hint = "Front";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(46, 49);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(596, 23);
            this.materialSingleLineTextField1.TabIndex = 0;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.deleteGroupBtn);
            this.tabPage3.Controls.Add(this.flowLayoutPanel3);
            this.tabPage3.Controls.Add(this.createGroupBtn);
            this.tabPage3.Controls.Add(this.createGroupInput);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(709, 332);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Groups";
            // 
            // deleteGroupBtn
            // 
            this.deleteGroupBtn.AutoSize = true;
            this.deleteGroupBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteGroupBtn.Depth = 0;
            this.deleteGroupBtn.Location = new System.Drawing.Point(547, 255);
            this.deleteGroupBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deleteGroupBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteGroupBtn.Name = "deleteGroupBtn";
            this.deleteGroupBtn.Primary = true;
            this.deleteGroupBtn.Size = new System.Drawing.Size(60, 36);
            this.deleteGroupBtn.TabIndex = 5;
            this.deleteGroupBtn.Text = "Delete";
            this.deleteGroupBtn.UseVisualStyleBackColor = true;
            this.deleteGroupBtn.Click += new System.EventHandler(this.deleteGroupBtn_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoScroll = true;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(99, 148);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(408, 143);
            this.flowLayoutPanel3.TabIndex = 4;
            // 
            // createGroupBtn
            // 
            this.createGroupBtn.AutoSize = true;
            this.createGroupBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createGroupBtn.Depth = 0;
            this.createGroupBtn.Location = new System.Drawing.Point(546, 41);
            this.createGroupBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.createGroupBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.createGroupBtn.Name = "createGroupBtn";
            this.createGroupBtn.Primary = true;
            this.createGroupBtn.Size = new System.Drawing.Size(62, 36);
            this.createGroupBtn.TabIndex = 1;
            this.createGroupBtn.Text = "Create";
            this.createGroupBtn.UseVisualStyleBackColor = true;
            this.createGroupBtn.Click += new System.EventHandler(this.createGroupBtn_Click);
            // 
            // createGroupInput
            // 
            this.createGroupInput.Depth = 0;
            this.createGroupInput.Hint = "Group Name";
            this.createGroupInput.Location = new System.Drawing.Point(100, 48);
            this.createGroupInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.createGroupInput.Name = "createGroupInput";
            this.createGroupInput.PasswordChar = '\0';
            this.createGroupInput.SelectedText = "";
            this.createGroupInput.SelectionLength = 0;
            this.createGroupInput.SelectionStart = 0;
            this.createGroupInput.Size = new System.Drawing.Size(407, 23);
            this.createGroupInput.TabIndex = 0;
            this.createGroupInput.UseSystemPasswordChar = false;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(749, 45);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "\\";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(741, 501);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SharpCards";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardCreatedAlert)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialRaisedButton createCardBtn;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.PictureBox cardCreatedAlert;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialFlatButton createGroupBtn;
        private MaterialSkin.Controls.MaterialSingleLineTextField createGroupInput;
        private MaterialSkin.Controls.MaterialFlatButton deleteGroupBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
    }
}


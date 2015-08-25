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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.continueBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.readCardPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.createCardBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.createCardPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.newCardBack = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.newCardFront = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.deleteGroupBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.groupPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.createGroupBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.createGroupInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.materialFlatButton1);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Controls.Add(this.readCardPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(709, 332);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Read";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.continueBtn);
            this.panel1.Location = new System.Drawing.Point(234, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 154);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            // 
            // continueBtn
            // 
            this.continueBtn.AutoSize = true;
            this.continueBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.continueBtn.Depth = 0;
            this.continueBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.continueBtn.Location = new System.Drawing.Point(312, 259);
            this.continueBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.continueBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Primary = true;
            this.continueBtn.Size = new System.Drawing.Size(79, 36);
            this.continueBtn.TabIndex = 1;
            this.continueBtn.Text = "Continue";
            this.continueBtn.UseVisualStyleBackColor = true;
            this.continueBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.materialFlatButton1.Location = new System.Drawing.Point(307, 287);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = true;
            this.materialFlatButton1.Size = new System.Drawing.Size(95, 36);
            this.materialFlatButton1.TabIndex = 6;
            this.materialFlatButton1.Text = "Read Group";
            this.materialFlatButton1.UseVisualStyleBackColor = false;
            this.materialFlatButton1.Click += new System.EventHandler(this.readCardBtn_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(258, 50);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(193, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Select a card group to read.";
            // 
            // readCardPanel
            // 
            this.readCardPanel.AutoScroll = true;
            this.readCardPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.readCardPanel.Location = new System.Drawing.Point(82, 86);
            this.readCardPanel.Name = "readCardPanel";
            this.readCardPanel.Padding = new System.Windows.Forms.Padding(3);
            this.readCardPanel.Size = new System.Drawing.Size(544, 182);
            this.readCardPanel.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.createCardBtn);
            this.tabPage2.Controls.Add(this.materialLabel1);
            this.tabPage2.Controls.Add(this.createCardPanel);
            this.tabPage2.Controls.Add(this.newCardBack);
            this.tabPage2.Controls.Add(this.newCardFront);
            this.tabPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(709, 332);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create";
            // 
            // createCardBtn
            // 
            this.createCardBtn.AutoSize = true;
            this.createCardBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createCardBtn.Depth = 0;
            this.createCardBtn.Location = new System.Drawing.Point(583, 287);
            this.createCardBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.createCardBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.createCardBtn.Name = "createCardBtn";
            this.createCardBtn.Primary = true;
            this.createCardBtn.Size = new System.Drawing.Size(102, 36);
            this.createCardBtn.TabIndex = 4;
            this.createCardBtn.Text = "Create Card";
            this.createCardBtn.UseVisualStyleBackColor = true;
            this.createCardBtn.Click += new System.EventHandler(this.createCardBtn_Click);
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
            // createCardPanel
            // 
            this.createCardPanel.AutoScroll = true;
            this.createCardPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.createCardPanel.Location = new System.Drawing.Point(46, 183);
            this.createCardPanel.Name = "createCardPanel";
            this.createCardPanel.Padding = new System.Windows.Forms.Padding(3);
            this.createCardPanel.Size = new System.Drawing.Size(511, 143);
            this.createCardPanel.TabIndex = 3;
            // 
            // newCardBack
            // 
            this.newCardBack.Depth = 0;
            this.newCardBack.Hint = "Back";
            this.newCardBack.Location = new System.Drawing.Point(46, 112);
            this.newCardBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.newCardBack.Name = "newCardBack";
            this.newCardBack.PasswordChar = '\0';
            this.newCardBack.SelectedText = "";
            this.newCardBack.SelectionLength = 0;
            this.newCardBack.SelectionStart = 0;
            this.newCardBack.Size = new System.Drawing.Size(596, 23);
            this.newCardBack.TabIndex = 0;
            this.newCardBack.UseSystemPasswordChar = false;
            // 
            // newCardFront
            // 
            this.newCardFront.Depth = 0;
            this.newCardFront.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.newCardFront.Hint = "Front";
            this.newCardFront.Location = new System.Drawing.Point(46, 49);
            this.newCardFront.MouseState = MaterialSkin.MouseState.HOVER;
            this.newCardFront.Name = "newCardFront";
            this.newCardFront.PasswordChar = '\0';
            this.newCardFront.SelectedText = "";
            this.newCardFront.SelectionLength = 0;
            this.newCardFront.SelectionStart = 0;
            this.newCardFront.Size = new System.Drawing.Size(596, 23);
            this.newCardFront.TabIndex = 0;
            this.newCardFront.UseSystemPasswordChar = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.deleteGroupBtn);
            this.tabPage3.Controls.Add(this.groupPanel);
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
            // groupPanel
            // 
            this.groupPanel.AutoScroll = true;
            this.groupPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.groupPanel.Location = new System.Drawing.Point(99, 148);
            this.groupPanel.Name = "groupPanel";
            this.groupPanel.Padding = new System.Windows.Forms.Padding(3);
            this.groupPanel.Size = new System.Drawing.Size(408, 143);
            this.groupPanel.TabIndex = 4;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialSingleLineTextField newCardBack;
        private MaterialSkin.Controls.MaterialSingleLineTextField newCardFront;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.FlowLayoutPanel createCardPanel;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.FlowLayoutPanel readCardPanel;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton createGroupBtn;
        private MaterialSkin.Controls.MaterialSingleLineTextField createGroupInput;
        private MaterialSkin.Controls.MaterialFlatButton deleteGroupBtn;
        private System.Windows.Forms.FlowLayoutPanel groupPanel;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialFlatButton createCardBtn;
        private MaterialSkin.Controls.MaterialFlatButton continueBtn;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Desktop_Flashcards
{
    public partial class Form1 : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public Form1()
        {
            InitializeComponent();
            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
            populatePanel();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            //TODO add fade effect when showing and hiding the alert
            //TODO add shadow to the alert
            pictureBox1.Show();
        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(materialTabControl1.SelectedIndex == 0)
            {
                populatePanel();//update panel when entering the 'create' tab
            }
            
        }

        /// <summary>
        /// Populates the panel containing radio buttons in 'Create' tab.
        /// </summary>
        private void populatePanel()
        {
            MaterialRadioButton test;
            for (int i = 0; i < 20; i++)
            {
                test = new MaterialRadioButton();
                test.AutoSize = true;
                test.Depth = 0;
                test.Font = new System.Drawing.Font("Roboto", 10F);
                test.Location = new System.Drawing.Point(3, 3);
                test.Margin = new System.Windows.Forms.Padding(0);
                test.MouseLocation = new System.Drawing.Point(-1, -1);
                test.MouseState = MaterialSkin.MouseState.HOVER;
                test.Name = "testRadiobutton";
                test.Ripple = true;
                test.Size = new System.Drawing.Size(163, 30);
                test.TabIndex = 0;
                test.TabStop = true;
                test.Text = "Card Group " + i.ToString() + "\t";
                test.UseVisualStyleBackColor = true;
                flowLayoutPanel1.Controls.Add(test);
            }
        }
    }
}

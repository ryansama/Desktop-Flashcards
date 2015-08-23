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
using System.IO;

namespace Desktop_Flashcards
{
    public partial class Form1 : MaterialForm
    {

        string cardDir = "";//full path of the 'cards' directory

        //Material skin from Ignace Maes
        private readonly MaterialSkinManager materialSkinManager;

        /// <summary>
        /// Method to run all code upon startup.
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            Directory.CreateDirectory("cards");//if the cards/ directory is not present, create one
            this.cardDir = getCardsDirectory();//set the global variable to the full path


            // Initialize MaterialSkinManager with theme and color scheme
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);

            //populate the radio button panel under 'Create' tab
            populatePanel(flowLayoutPanel1);

        }

        /// <summary>
        /// Get the directory of the program and return 
        /// a string containing the "\cards" directory.
        /// </summary>
        /// <returns></returns>
        private string getCardsDirectory()
        {
            string path = Directory.GetCurrentDirectory() + "\\cards\\";
            return path;
        }

        /// <summary>
        /// Method to start events when switching between tabs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tab = materialTabControl1.SelectedIndex;
            switch (tab)
            {
                case 0:
                    flowLayoutPanel1.Controls.Clear();
                    populatePanel(flowLayoutPanel1);//update panel when entering the 'create' tab
                    break;
                case 1:
                    flowLayoutPanel2.Controls.Clear();
                    populatePanel(flowLayoutPanel2);//update panel when entering the 'read' tab
                    break;
                default:
                    MessageBox.Show("Default switch case");
                    break;
            }
            
        }

        /// <summary>
        /// Populates the panel containing radio buttons in 'Create' tab.
        /// </summary>
        private void populatePanel(FlowLayoutPanel panel)
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
                panel.Controls.Add(test);
            }
        }

        /// <summary>
        /// Events when the 'Create Card' button is clicked.
        /// </summary>
        private void createCardBtn_Click(object sender, EventArgs e)
        {
            //TODO add fade-in and fade-out effect to the alert
            cardCreatedAlert.Show();
        }
    }
}

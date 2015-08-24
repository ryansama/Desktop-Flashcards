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
        IList<Card>[] collection;//the collection of card groups and their cards 

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
            this.collection = makeList();

            // Initialize MaterialSkinManager with theme and color scheme
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);

            //populate the radio button panel under 'Create' tab
            populatePanel(flowLayoutPanel2);

        }

        /// <summary>
        /// Get the directory of the .exe and return 
        /// a string containing the "\cards" directory.
        /// </summary>
        /// <returns></returns>
        private string getCardsDirectory()
        {
            string path = Directory.GetCurrentDirectory() + "\\cards\\";
            return path;
        }

        /// <summary>
        /// Make an IList of Card objects to allow for 
        /// traversing through each card group.
        /// </summary>
        /// <returns></returns>
        private IList<Card>[] makeList()
        {
            //get card group paths and store it in a string array
            string[] folders = Directory.GetDirectories(getCardsDirectory());

            //number of card groups the user has
            int numGroups = folders.Length;

            //Create an array of ILists. The size of the array depends on the number of card groups the user has.
            IList<Card>[] iListArray = new IList<Card>[numGroups];

            for (int i = 0; i < iListArray.Length; i++)
            {
                var type = Type.GetType(typeof(List<Card>).AssemblyQualifiedName);
                var list = (IList<Card>)Activator.CreateInstance(type);
                iListArray[i] = list;
            }
            //get cards from each card group
            for (int i = 0; i < numGroups; i++)
            {

                string[] fileEntries = System.IO.Directory.GetFiles(folders[i]);//.txt file paths of current card group
                int numCards = fileEntries.Length;//number of cards in the folder

                for (int j = 0; j < numCards; j++)
                {
                    Card tempCard = makeCardObject(fileEntries[j]);//make a card from the current file
                    tempCard.belongsTo = folders[i];

                    try
                    {
                        iListArray[i].Add(tempCard);//add the card to the iList array's appropriate index
                    }
                    catch (NullReferenceException e)
                    {
                        Console.WriteLine("Exception when adding card to IList");
                    }


                }

                for (int j = 0; j < numCards; j++)
                {
                    Card tempCard = makeCardObject(fileEntries[j]);//make a card from the current file
                    tempCard.belongsTo = folders[i];

                    try
                    {
                        iListArray[i].Add(tempCard);//add the card to the iList array's appropriate index
                    }
                    catch (NullReferenceException e)
                    {
                        Console.WriteLine("Exception when adding card to IList");
                    }

                }

            }
            return iListArray;

        }

        /// <summary>
        /// Reads a .txt file, populates
        /// a Card object using its content 
        /// and returns it.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private Card makeCardObject(string path)
        {
            Card newCard = new Card();
            int counter = 1;
            string line;

            // Read the file and add each line to the Card.
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                newCard.writeToSide(counter, line);
                counter++;
            }

            file.Close();
            return newCard;
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
                    populatePanel(flowLayoutPanel1);//update panel when entering the 'create' tab
                    break;
                case 1:
                    populatePanel(flowLayoutPanel2);//update panel when entering the 'read' tab
                    break;
                case 2:
                    populatePanel(flowLayoutPanel3);
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

        /// <summary>
        /// Events when the 'Create Card Group' button is clicked.
        /// The functionality from the console applciation's "createCardGroup()"
        /// method is included here.
        /// </summary>
        //TODO allow the user to create a new group using the 'Enter' key
        private void createGroupBtn_Click(object sender, EventArgs e)
        {
            //get new card group name and combine with full 'cards/' path
            string newGroup = createGroupInput.Text;
            string tempPath = this.cardDir + newGroup;

            //error checking
            if (String.IsNullOrWhiteSpace(newGroup))
            {
                //TODO create material design pop-up
                MessageBox.Show("Please enter a valid card group name.");
            }else if (Directory.Exists(tempPath))
            {
                //TODO create material design pop-up
                MessageBox.Show("This card group already exists!");
            }
            else
            {
                //make the card group
                Directory.CreateDirectory(tempPath);
                MessageBox.Show(newGroup + " was created!");
            }
        }

        /// <summary>
        /// Events when the 'Delete Card Group' button is clicked.
        /// </summary>
        private void deleteGroupBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

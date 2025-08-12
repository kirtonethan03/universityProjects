using System;
using System.Windows.Forms;

namespace FishyForms
{
    public partial class Fishyform : Form
    {
        public Fishyform()
        {
            InitializeComponent();
            
            // Click event handlers for each button
            OrangeFishBtn.Click += (sender, e) => LoadAndDisplayImage("OrangeFish");
            JavaFishBtn.Click += (sender, e) => LoadAndDisplayImage("JavaFish");
            SeaHorseBtn.Click += (sender, e) => LoadAndDisplayImage("Seahorse");
            AnglerFishBtn.Click += (sender, e) => LoadAndDisplayImage("AnglerFish_Lit");
            GPiranhaBtn.Click += (sender, e) => LoadAndDisplayImage("PiranhaGreen");
            RPiranhaBtn.Click += (sender, e) => LoadAndDisplayImage("PiranhaRed");
            UrchinBtn.Click += (sender, e) => LoadAndDisplayImage("Urchin");
        }

        private void LoadAndDisplayImage(string resourceName)
        {
            try
            {            
                var imageServer = new MediaServer.ResourceFileServer();
                var image = imageServer.LoadImage(resourceName);

                //a Declared list to store references to Fishyform instances
                Fishes fishesForm = new Fishes();
                fishesForm.SetImage(image);

                // Display the Fishes form
                fishesForm.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Error loading image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Fishyform_Load(object sender, EventArgs e)
        {

        }       

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

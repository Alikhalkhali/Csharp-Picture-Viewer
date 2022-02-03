using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Viewer
{

    // **Ali Khalkhali**
    //my email => alikhalkhali.org@gamil.com
    //my github =>https://github.com/alikhalkhali
    public partial class Form1 : Form
    {
        int i = 1; //name of picture 
        string visibility = "show"; //for checked picSimple Visable or Hide .Show by default .
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            picSample.ImageLocation = i + ".jpg"; //When the program starts, the first image is '1.jpg' 
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            picSample.Width +=  4; //Increase the width for zoom-in
            picSample.Height += 3;//Increase the height for zoom-in
            picSample.Left = (this.Width - picSample.Width) / 2; //Adjust the width to be in the center of the screen and not move when zooming
            picSample.Top = (this.Height - picSample.Height) / 2;//Adjust the height to be in the center of the screen and not move when zooming
        }
        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            picSample.Width -= 4; //Decrease the width for zoom-out
            picSample.Height -= 3;//Decrease the height for zoom-out;
            picSample.Left = (this.Width - picSample.Width) / 2;//Adjust the width to be in the center of the screen and not move when zooming
            picSample.Top = (this.Height - picSample.Height) / 2;//Adjust the height to be in the center of the screen and not move when zooming;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            i++; //Increase i for the next name of the pitcture
            if (i == 5) // if i equal to 5 ,The pictures are finished and she has to go to the 1.jpg
            {
                i = 1;
            }
            string path = i.ToString() + ".jpg"; //Attach the name to the picture extension
            picSample.ImageLocation = path;  //change picture
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            i--; //Increase i for the previous name of the picture
            if (i == 0)  //if  user clicked on btnPrev when he sees the first image. The previous image must be the last image and therefore i = 4
            {
                i = 4;
            }
            
            else if (i == 5)// if i equal to 5 ,The pictures are finished and she has to go to the 1.jpg
            {
                i = 1;
            }
            string path = i.ToString() + ".jpg"; //Attach the name to the picture extension
            picSample.ImageLocation = path;//change picture
        }

        private void btnVisibility_Click(object sender, EventArgs e) //For control visibility of picSample
        {
            if (visibility == "show")      //if value is show ....
            {
                picSample.Hide();          //hide the pic sample
                visibility = "hide";        // change value of visibility variable to hide
                btnVisibility.Text = "Show";//Change text button to show

            }
            else        //If value is Hide ...
            {                       
                picSample.Show();   //Show the picSample
                visibility = "show"; //change value of visibility variable to show
                btnVisibility.Text = "Hide"; //Change text button to Hide
            }
            

        }
    }
}

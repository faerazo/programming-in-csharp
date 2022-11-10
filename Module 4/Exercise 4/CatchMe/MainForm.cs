//Code example
//Farid Naisan

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace TimerExample
{
    /// <summary>
    /// MainForm Displays an interface for a simple game.  An image is moving on 
    /// a panel control with a certain interval of  seconds (milliseconds)
    /// The user should try to click on the image and every hit on the image gives one 
    /// point.  If the user clicks but misses the target, these are shown as number of 
    /// misses.  The total number of time the target image is displayed is also shown.
    /// </summary>
    ///   
    /// <remarks>
    /// TO DO:  Study every single method in this class.  Comments all 
    /// methods and also the code lines which you find unclear.
    /// 
    /// To remember:  A panel is always good to draw on it.  A pictureBox is good 
    /// to display an image. Do you see the difference?
    /// </remarks>

    public partial class MainForm : Form
    {
        //As an exercise, make these constants as ordinary variable and let the
        //user define them through conrols on the GUI.
        private const int maxAttempts = 100;
        private const int maxLevels = 10;
        private const int intervalIncrement = 300;  //milliseconds

        //To randomly display (move) the impage on the panel.
        private Random random = new Random ( DateTime.Now.Second );

        //Declare an object of the CatchMe that is defined to handle the game CatchMe.
        //The object MUST be created by using the keyword new.  This is done in the 
        //constructor below (try to locate it).
        private CatchMe game;

        public MainForm ( )
        {
            InitializeComponent ( );
            InitializeGUI ( );
        }

        /// <summary>
        /// Describe what this method is for.
        /// </summary>
        private void InitializeGUI ( )
        {
            game = new CatchMe ( maxAttempts, maxLevels, intervalIncrement );

            //Fill the combobox
            cmbLevel.Items.Clear ( );
            for (int i = 0; i < maxLevels; i++)
                cmbLevel.Items.Add ( (i + 1).ToString ( "00" ) );

            //Select a default option in the combobox
            cmbLevel.SelectedIndex = 4; //Default value level 5 (4+1)

            SetLevel ( );
            InitializeControls ( );
        }
        private void InitializeControls ( )
        {
            btnStart.Enabled = true;
            cmbLevel.Enabled = true;
            btnReset.Enabled = true;
            panel1.Enabled = false;
            btnStop.Enabled = false;
            lblAttemptsLeft.Text = game.MaxAttempts.ToString ( );
            lblPanelClicks.Text = "0";
            lblAttempts.Text = "0";
            lblInfo.ForeColor = Color.DarkOrange;
            lblInfo.Text = game.ToString ( );
        }

        /// <summary>
        /// When the user clicks on the picture his/her result inceases
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void targetPictureBox_Click (object sender, EventArgs e)
        {
            game.IncrementTargetHits ( );
            lblAttempts.Text = game.NumOfTargetHits.ToString ( );
        }

        /// <summary>
        /// When the user clicks start button the picture will start to move
        /// (be moved).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click (object sender, EventArgs e)
        {
            if (game.IsGameOver ( ))
            {
                ResetGame ( );
            }
            ReadName ( );
            grpPlayer.Text = game.Name;
            timerPopups.Start ( );
            panel1.Cursor = Cursors.NoMove2D;
            btnStart.Enabled = false;
            cmbLevel.Enabled = false;

            panel1.Enabled = true;
            btnStop.Enabled = true;

        }

        /// <summary>
        /// Write your comments here.  Clear this line first.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click (object sender, EventArgs e)
        {
            timerPopups.Stop ( );
            targetPictureBox.Left = 0;
            targetPictureBox.Top = 0;
            panel1.Cursor = Cursors.No;
            btnStart.Enabled = true;
            panel1.Enabled = false;
            btnStop.Enabled = false;
         }
        private void ReadName ( )
        {
            game.Name = txtName.Text.Trim ( ); //trim the leading and tailing spaces

        }

        /// <summary>
        /// Everytime the clock (timer) interval is reached.  This method
        /// is automatically executed.  
        /// Write comments to explain what is happening here.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerPicture_Tick (object sender, EventArgs e)
        {
            if (game.IsGameOver ( ))
            {
                timerPopups.Stop ( );
                MessageBox.Show ( "Nice try!", "Game Over!!" );
                btnStop_Click ( sender, e );
            }
            else
            {
                int left = random.Next ( 0, panel1.Width );
                int top = random.Next ( 0, panel1.Height );
                targetPictureBox.Left = Math.Min ( left, panel1.Width - targetPictureBox.Width ); // Math.Max(left, panel1.Width - pictureBox1.Width);
                targetPictureBox.Top = Math.Min ( top, panel1.Height - targetPictureBox.Height ); // Math.Max(top, panel1.Height - pictureBox1.Width);
                //
                game.IncrementTargetPopups ( );
                lblAttemptsLeft.Text = game.NumOfAttemptsLeft.ToString ( );
            }
        }

        /// <summary>
        /// When is this method executed?
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged (object sender, EventArgs e)
        {
            SetLevel ( );
        }

        private void SetLevel ( )
        {
            timerPopups.Stop ( );

            int level = cmbLevel.SelectedIndex; //counted from 0
            timerPopups.Interval = game.GetLevelBasedInterval ( level );

            if (level == maxLevels - 1)
            {
                //make it harder - reduce the size of the image
                targetPictureBox.Width -= targetPictureBox.Width / 4;
                targetPictureBox.Height -= targetPictureBox.Height / 4;
            }

        }

        private void panel1_Click (object sender, EventArgs e)
        {
            game.IncrementAttempts ( );
            lblPanelClicks.Text = game.NumOfAttempts.ToString ( );
        }

        private void btnReset_Click (object sender, EventArgs e)
        {
            ResetGame ( );
        }

        private void ResetGame ( )
        {
            game.DefaultValues ( );
            InitializeGUI ( );
        }


    }
}

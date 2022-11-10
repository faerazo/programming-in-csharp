//Code Example
//created by:  Farid Naisan, 2006-08-01
//revised 2014 (Compilation to VS 2013)

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawPointsCS
{
    public partial class MainForm : Form
    {        
        private bool clicked;//false        
        private PointsManager pointsMngr = new PointsManager();//call default constructor        
		private int currX = 0;//currX of a point on the form where the cursor is at the moment
		private int currY = 0;//currY of a point on the form where the cursor is at the moment
		

		public MainForm()
        {
	        //This call is required by the Windows Form Designer.
	        InitializeComponent();

	        //my initializations - reset and initiate GUI
	        MyInitializations();
        }

        //Reset GUI and do other initializations
        private void MyInitializations()
        {
            lstPoints.Items.Clear();
	        txtPoints.Text = "";
            btnReset.Visible = false;
	       
	        grpInput.Visible = true;
	        grpOutput.Visible = false;
			pointsMngr.Reset();

			lblMessage.Text = "";
			Invalidate();
        }

 
         //Mark the cursor position by drawing a small circle
        private void DrawCursor(Graphics g)
        {
			if (pointsMngr.Size <= 0)
				return;  //array not created
			

			g.FillEllipse(Brushes.CornflowerBlue, currX - 3, currY - 3, 6, 6);
	        g.DrawEllipse(Pens.BlueViolet, currX- 5, currY - 5, 10, 10);
	        string strMsg = "(" + currX.ToString() + "," + currY.ToString() + ")" + " ";

			g.DrawString(strMsg, new Font("Courier New", 14, FontStyle.Italic), 
				Brushes.CornflowerBlue, currX- 50, currY + 10);
        }


        //Refresh the listbox by refilling from the polypoints.
        private void UpdatePointList()
        {
	        string strRow = null;
	        lstPoints.Items.Clear();

	        for (int i = 0; i < pointsMngr.Count; i++) 
            {
				int x = 0;
				int y = 0;
				bool ok = pointsMngr.GetPoint(i, out x,  out y);

				strRow = String.Format("{0,5}{1,6:f0} {2,6:f0}", i + 1, x, y); 					                      
		        lstPoints.Items.Add(strRow);
	        }
        }

        //The button is visible until the user gives the max number of points.
        //The input groupbox is then made hidden.
        private void btnOK_Click(object sender, EventArgs e)
        {
	        int maxnum = 0;

	        if (ReadInteger(txtPoints.Text, ref maxnum)) 
            {
		        pointsMngr = new PointsManager(maxnum);
		        grpInput.Visible = false;
		        grpOutput.Visible = true;
                btnReset.Visible = true;

		        MessageBox.Show("Click on any point on the drawing area of this form!", "Info");
	        } 
            else 
            {
		        MessageBox.Show("Invalid value!", "Info");
	        }
        }

        //Convert a string-number to  an integer.  Check the validity of given number.
        private bool ReadInteger(string strTal, ref int number)
        {
	        double dblNum = 0;
	        bool bOK = false;	        //initiering
	        
	        if ((double.TryParse(strTal, out dblNum))) 
            {
		        number = Convert.ToInt32(dblNum);
		        bOK = true;
	        }

	        return bOK;
        }

        private void DrawPolyLines(Graphics g)
        {
	        int numOfPoints = pointsMngr.Count;

	        //at least 2 points are needed to draw a line
	        if ((numOfPoints <= 1)) 
            {
		        return;
	        }
			
			int x = 0;
			int y = 0;
			bool ok = false;

			Point point1 = new Point(0, 0); //initialization
			Point point2 = new Point(0, 0); //initialization
			Point[] points = new Point[pointsMngr.Count];
			for (int i = 0; i < pointsMngr.Count; i++)
			{
				points[i] = new Point(x, y);

				ok = pointsMngr.GetPoint(i, out x, out y);
				if (i == 0)
				{
					point1 = new Point(x, y);
				}
				else
				{
					pointsMngr.GetPoint(i, out x, out y);
					point2 = new Point(x, y);
					g.DrawLine(Pens.Coral, point1, point2);
					point1 = point2;
				}
			}
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            MyInitializations();
        }

        //This function is called automaticall whenever the mouse is moved
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
 	        currX= e.X;
	        currY = e.Y;
			Invalidate();

		}

		//Event-handler for mouse-up.  This event happens when a button is in the up-position
		private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
	        if ((e.Button == MouseButtons.Right)) 
            {
		        MessageBox.Show("Move the mouse and left-click to save the coordinates of the current position!", "Info");
	        } 
            else if ((!grpInput.Visible)) 
            {
		        clicked = true;
		        currX= e.X;
		        currY = e.Y;
		        Invalidate();
	        }

        }

       //The paint-method takes care of all painting and repainting. Do not call this method 
        //directly. Try to cause a paint even instead by calling Invalidate() instead.   
        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
 	        Brush textBrush = Brushes.CornflowerBlue;  //for writing (drawing) text
	        string strMessage = "";  //text to be "drawn"

			int numOfPoints = pointsMngr.Count;  //num of points stored

			//If the user has left-clicked then save point and draw lines
			//otherwise, draw only the cursor position,

			if (clicked && (numOfPoints >= 0)) //if the user has chosen a point by clicking
			{
				if ((!pointsMngr.AddNewPoint(currX, currY)))
				{
					strMessage = "List is full honey!";
					//textBrush = Brushes.Red;
					lblMessage.Text = strMessage;
				}
				else
					strMessage = "";
			}
			else
			

			DrawPolyLines(e.Graphics); //draw lines
			UpdatePointList(); //refresh the listbox
			
			DrawCursor(e.Graphics); //Draw a circle at the cursor position
			
			clicked = false;  //make ready for next point
		}
        
    }
}

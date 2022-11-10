//PolyPoints.cs
//created by:  Farid Naisan, 2006-08-01
//revised 2014 (Compilation to VS 2013)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace DrawPointsCS
{
    //class that manages a one-dimentional list of pointList with elements of the type DoublePoint
    //It is assumed that the pointList are added at the end of the list and a variable
    //(currIndex) keeps track of the current position in the list.
    public class PointsManager
    {
        private int maxNumOfPoints = 0; //this is not the same as array.length
        //the working position of the list
        private int currIndex = 0;
   
        //declaration of Array of DoublePoint,created in the constructor
        private int [,] pointList;

        //default constructor
        public PointsManager()
        {
        }
        public void Reset()
        {
            pointList = null;
            maxNumOfPoints = 0;
            currIndex = 0;

        }

        //Constructor with intiates the array (pointList
        public PointsManager(int size)
        {
            maxNumOfPoints = size;
            pointList = new int[size, 2];        //6 rows 2 cols (cols: x, y) 
        }

        //Adds a new point at the end of the array
        public bool AddNewPoint(int x, int y)
        {
            bool bOK = false;

            if (currIndex < maxNumOfPoints)
            {
                pointList[currIndex, 0] = x;
                pointList[currIndex, 1] = y;
                currIndex++;
                bOK = true;
            }

            return bOK;
        }

        //return numOfPoints (size of the array)
        public int Size
        {
            get { return maxNumOfPoints; }
        }

        //retun currentPosition = current no of points saved.
        public int Count
        {
            get { return currIndex; }
        }

        //returns a point at index-position from the pointList array
        public bool GetPoint(int index, out int x, out int y)
        {
          
            bool ok = false;
            x = 0;
            y = 0;

            if (pointList == null)
                return false;

            if ( (index >= 0) && (index < maxNumOfPoints))
            {
                x = pointList[index, 0];
                y = pointList[index, 1];
                ok = true; 
            }
            return ok;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPDataLibrary
{
    public class Wall
    {
        private int _wallHeight;
        private int _wallWidth;

        public int WallHeight
        {
            get { return _wallHeight; }
            set { _wallHeight = value; }
        }
        public int WallWidth 
        {
            get { return _wallWidth; } 
            set { _wallWidth = value; } 
        }  
    }
}

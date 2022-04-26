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
        private int _areaOfWall;
        private int _centerPointOfWall;

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
        public int AreaOfWall
        {
            get { return _areaOfWall; }
            set { _areaOfWall = _wallHeight * _wallWidth; }
        }
        public int CenterPointOfWall
        {
            get { return _centerPointOfWall; }
            set { _centerPointOfWall = _wallWidth / 2; }
        }
    }
}

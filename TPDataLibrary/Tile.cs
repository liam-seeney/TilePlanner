using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPDataLibrary
{
    public class Tile
    {
        private int _tileHeight;
        private int _tileWidth;
        private int _tileArea;

        public int TileHeight
        {
            get { return _tileHeight; }
            set { _tileHeight = value; }
        }
        public int TileWidth
        {
            get { return _tileWidth; }
            set { _tileWidth = value; }
        }

        public int TileArea
        {
            get { return _tileArea; }
            set { _tileArea = value; }
        }
    }
}

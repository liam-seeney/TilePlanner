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
    }
}

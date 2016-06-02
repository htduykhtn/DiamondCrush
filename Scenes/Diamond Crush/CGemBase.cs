using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformTest
{
    public class CGemBase
    {
      
        public uint _row { get; set; }
        public uint _column { get; set; }
        public Point _location { get; set; }
        public static CGemBase _elementSelected;
        public static bool _elementSelectedExist=false;
        
        public uint _gemType { get; set; } // Green, Red, Blue, Orange, Purple, Yello, White
        private Rectangle _gemBox;
        public CGemBase(Point location, uint Row,uint Column, uint randomGemType)
        {
            _location = location;
            _row = Row;
            _column = Column;
            _gemBox = new Rectangle(location.X, location.Y, 50, 50);
            _gemType = (randomGemType % 7);
        }
        public CGemBase(CGemBase root)
        {
            _location = root._location;
            _row = root._row;
            _column = root._column;
            _gemBox = new Rectangle();
            _gemBox = root._gemBox;
            _gemType = root._gemType;

        }
        public void SwapLeft(CGemBase secondeGem,int speed)
        {
            this._location = new Point (this._location.X-speed,this._location.Y);
            secondeGem._location = new Point(secondeGem._location.X+speed,secondeGem._location.Y);

        }
        public void SwapRight(CGemBase secondeGem, int speed)
        {
            this._location = new Point(this._location.X + speed, this._location.Y);
            secondeGem._location = new Point(secondeGem._location.X - speed, secondeGem._location.Y);

        }
        public void SwapUp(CGemBase secondeGem, int speed)
        {
            this._location = new Point(this._location.X , this._location.Y - speed);
            secondeGem._location = new Point(secondeGem._location.X , secondeGem._location.Y+speed);

        }
        public void SwapDown(CGemBase secondeGem, int speed)
        {
            this._location = new Point(this._location.X, this._location.Y + speed);
            secondeGem._location = new Point(secondeGem._location.X , secondeGem._location.Y - speed);

        }

        public bool IsRightOf(CGemBase secondGem)
        {
            if (this._row == secondGem._row && this._column - secondGem._column == 1)
            {
                return true;
            }
            return false;
        }
        public bool IsLeftOf(CGemBase secondGem)
        {
            if (this._row == secondGem._row && (int)this._column - secondGem._column == -1)
            {
                return true;
            }
            return false;
        }
        public bool IsHeadOf(CGemBase secondGem)
        {
            if (this._column==secondGem._column&&(int)this._row-secondGem._row==-1)
            {
                return true;
            }
            return false;
        }
        public bool IsBottomOf(CGemBase secondGem)
        {
            if (this._column == secondGem._column && this._row - secondGem._row == 1)
            {
                return true;
            }
            return false;
        }

        public bool IsClickable(int x,int y)
        {
            if(_gemBox.Contains(new Point(x, y)))
            {
                return true;
            }
            return false;
        }
        public bool IsSwapable(CGemBase secondGem)
        {
            if(this._row==secondGem._row&&(this._column-secondGem._column==1
                || (int)this._column - secondGem._column == -1))
            {
                return true;
            }
            if(this._column==secondGem._column&& (this._row - secondGem._row == 1
                ||(int) this._row - secondGem._row == -1))
            {
                return true;
            }
            return false;
        }

    }
}

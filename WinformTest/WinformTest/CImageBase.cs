using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond_Crush
{
    class CImageBase
    {
        bool disposed = false;
        Bitmap _bitmap;
        private int X, Y;
        private Rectangle _hotSpot = new Rectangle();
        public int Left { get { return X; } set { X = value; _hotSpot.X = value; } }
        public int Top { get { return Y; } set { Y = value; _hotSpot.Y = value; } }
        public CImageBase(Bitmap _resource)
        {
            _bitmap = new Bitmap(_resource);
            _hotSpot.Width = _bitmap.Width;
            _hotSpot.Height = _bitmap.Height;
        }
        public void DrawSprite(Graphics gfx)
        {
            gfx.DrawImage(_bitmap, X, Y);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;
            if (disposing)
            {
                _bitmap.Dispose();
            }
            disposed = true;
        }
        public virtual bool IsClicked(int X, int Y)
        {
            Rectangle c = new Rectangle(X, Y, 1, 1);
            if (_hotSpot.Contains(c))
                return true;
            return false;
        }
    }
}

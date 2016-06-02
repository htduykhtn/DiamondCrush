
using ClassLibrary1;
using Diamond_Crush;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformTest.Properties;

namespace WinformTest
{
    public partial class Form1 : Form
    {
        private uint[] _targetScore;
        public static uint _score = 0;
        private uint _scoreInOneMove = 0;
        private uint _explodeWave = 0;
        private uint _normalGemFrameIndex = 0;
        private uint _whiteGemFrameIndex = 0;
        private uint _explodeGemFrameIndex = 0;
        private CGemBase[,] _gem;
        private List<CGemBase> _proccessingGem;
        private List<CGemBase>[] _explodeGemList;
        private bool[] _colToCheckExplode;
        private bool _isMouseClickListening;
        private bool _isExploding = false;
        private int _swapSpeed;
        private SwapInfo _lastSwapInfo;
        private SoundPlayer[] _crushSound;
        private SoundPlayer _finalCrushSound;
        private SoundPlayer _victorySound;
        private SoundPlayer _gameOverSound;
        private CImageBase _butBack;
        private CImageBase _lifeCount;
        private CImageBase _goldCount;
        private enum SwapInfo
        {
            RightSwap,
            LeftSwap,
            UpSwap,
            DownSwap,
            NullSwap
        }
        private enum ExplodeType
        {
            NotExplode,
            AllLeft,
            AllRight,
            AllAbove,
            AllBelow,
            Balance,
            NullType,
            BigBalance,
            ThreeLeft,
            ThreeRight,
            TwoLeftOneRight,
            TwoRightOneLeft,
            ThreeAbove,
            ThreeBelow,
            TwoAboveOneBelow,
            TwoBelowOneAbove,
            TMatch, 
            LeftTMatch,
            RightTMatch,
            UpSideDownTMatch
        }
        
        public Form1(uint lvID)
        {
            InitializeComponent();
            this.Text = "Diamond Crush level " + (lvID+1).ToString();
            life_count_lab.Text = CUser.Instance()._lifeCount.ToString();
            gold_count_lab.Text = CUser.Instance()._goldCount.ToString();
            _lifeCount = new CImageBase(Resources.heart_40x40) { Left = 80, Top = 10 };
            _goldCount = new CImageBase(Resources.coin_40x40) { Left = 80, Top = 50 };
            _explodeGemList = new List<CGemBase>[8];
            _targetScore = new uint[9];
            _victorySound = new SoundPlayer(Resources.Final_Fantasy_VII___Victory_Fanfare);
            _crushSound = new SoundPlayer[5];
            _gameOverSound = new SoundPlayer(Resources.smb_gameover);
            _finalCrushSound = new SoundPlayer(Resources.Sword_Swipe_And_Klang_02);
            _crushSound[0] = new SoundPlayer(Resources.Sword_Movement_Single_01);
            _crushSound[1] = new SoundPlayer(Resources.Sword_Movement_Single_02);
            _crushSound[2] = new SoundPlayer(Resources.Sword_Movement_Single_03);
            _crushSound[3] = new SoundPlayer(Resources.Sword_Movement_Single_04);
            _crushSound[4] = new SoundPlayer(Resources.Sword_Movement_Single_05);
            _proccessingGem = new List<CGemBase>();
            _butBack = new CImageBase(Resources.but_back_75x75) { Left = 10, Top = 10 };
            for (uint i = 0; i < 9; i++)
            {
                switch (i)
                {
                    case 0:
                        _targetScore[i] = 40000;

                        break;
                    case 1:
                        _targetScore[i] = 30000;
                        break;
                    case 2:
                        _targetScore[i] = 12000;
                        break;
                    case 3:
                        _targetScore[i] = 5000;
                        break;
                    case 4:
                        _targetScore[i] = 9000;
                        break;
                    case 5:
                        _targetScore[i] = 12000;
                        break;
                    case 6:
                        _targetScore[i] = 15000;
                        break;
                    case 7:
                        _targetScore[i] = 18000;
                        break;
                    case 8:
                        _targetScore[i] = 20000;
                        break;
                }
            }
            this.label3.Text += "    "+_targetScore[lvID].ToString();
            this.label4.Text += "    " + CUser.Instance().GetLevel((int)lvID)._highestScore;
            _colToCheckExplode = new bool[8];
            for(int i = 0; i < 8; i++)
            {
                _colToCheckExplode[i] = false;
                _explodeGemList[i] = new List<CGemBase>();

            }
            CGemBase._elementSelectedExist = false;
            _isMouseClickListening = true;
            _swapSpeed = 0;
            _gem = new CGemBase[8, 8];
            for (uint i = 0; i < 8; i++)
                for (uint j = 0; j < 8; j++)
                {
                    _gem[i, j] = new CGemBase(SetLocationFromOriginal(i, j), i, j, (uint)new Random(Guid.NewGuid().GetHashCode()).Next(1, 100)%(lvID + 4 > 7 ? 7 : lvID + 4));
                }
            foreach(var gem in _gem)
            {
                while (IsRowMatch(gem)!= ExplodeType.NotExplode || IsColunmMatch(gem)!= ExplodeType.NotExplode)
                {
                    gem._gemType = (uint)new Random(Guid.NewGuid().GetHashCode()).Next(1, 100) %(lvID+4>7?7:lvID+4);
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            _explodeGemList = new List<CGemBase>[8];
            _colToCheckExplode = new bool[8];
            for (int i = 0; i < 8; i++)
            {
                _colToCheckExplode[i] = false;
                _explodeGemList[i] = new List<CGemBase>();

            }
            CGemBase._elementSelectedExist = false;
            _isMouseClickListening = true;
            _swapSpeed = 0;
            _gem = new CGemBase[8, 8];
            for (uint i = 0; i < 8; i++)
                for (uint j = 0; j < 8; j++)
                {
                    _gem[i, j] = new CGemBase(SetLocationFromOriginal(i, j), i, j, (uint)new Random(Guid.NewGuid().GetHashCode()).Next(1, 100));
                }
            foreach (var gem in _gem)
            {
                while (IsRowMatch(gem) != ExplodeType.NotExplode || IsColunmMatch(gem) != ExplodeType.NotExplode)
                {
                    gem._gemType = (uint)new Random(Guid.NewGuid().GetHashCode()).Next(1, 100) % 7;
                }
            }
        }
        Point SetLocationFromOriginal(uint row, uint col)
        {
            uint modRow = row % 8;
            uint modCol = col % 8;
            int x = label1.Location.X;
            int y = label1.Location.Y;
            x = x + (int)modCol * 50;
            y = y + (int)modRow * 50;
            return new Point(x, y);
        }
        protected override void OnPaint(PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            Draw_64_Gem(g, e);
            TextFormatFlags flag = TextFormatFlags.HorizontalCenter;
            Font font = new Font("Arial", 14, FontStyle.Regular);
            TextRenderer.DrawText(g, ""+_score.ToString(), font
                , new Rectangle(this.label2.Location.X+this.label2.Width, this.label2.Location.Y, 100, 20), SystemColors.ControlText, flag);
            
            base.OnPaint(e);
        }
        private void Draw_64_Gem(Graphics g, PaintEventArgs e)
        {
            for (uint i = 0; i < 8; i++)
                for (uint j = 0; j < 8; j++)
                {
                    if (CGemBase._elementSelectedExist == true && CGemBase._elementSelected._row == i && CGemBase._elementSelected._column == j)
                    {
                        var SelectedEle = new CGemBase(CGemBase._elementSelected);
                        sprite_ImageList.Draw(g, SelectedEle._location, 7);
                        DrawSelectedAnimation(g, SelectedEle);
                    }
                    else if (ExplodeGemIndexSearch(_explodeGemList[j], i, j) && _isExploding == true)
                    {
                        if (_explodeGemFrameIndex < 5)
                        {
                            DrawExplodeGem(g, _gem[i, j]);
                        }
                    }
                    else sprite_ImageList.Draw(g, _gem[i, j]._location.X, _gem[i, j]._location.Y, (int)_gem[i, j]._gemType);
                }
        }
        private void DrawSelectedAnimation(Graphics g, CGemBase selectedGem)
        {
            switch (selectedGem._gemType)
            {
                case 0:
                    green_Selected.Draw(g, selectedGem._location, (int)_normalGemFrameIndex++);

                    break;
                case 1:
                    red_Selected.Draw(g, selectedGem._location, (int)_normalGemFrameIndex++);
                    break;
                case 2:
                    blue_Selected.Draw(g, selectedGem._location, (int)_normalGemFrameIndex++);
                    break;
                case 3:
                    orange_Selected.Draw(g, selectedGem._location, (int)_normalGemFrameIndex++);
                    break;
                case 4:
                    purple_Selected.Draw(g, selectedGem._location, (int)_normalGemFrameIndex++);
                    break;
                case 5:
                    yellow_Selected.Draw(g, selectedGem._location, (int)_normalGemFrameIndex++);
                    break;
                case 6:
                    white_Selected.Draw(g, selectedGem._location, (int)_whiteGemFrameIndex++);
                    break;
            }
            if (_normalGemFrameIndex / 10 == 1) _normalGemFrameIndex = 0;
            if (_whiteGemFrameIndex / 20 == 1) _whiteGemFrameIndex = 0;
        }
        private void DrawExplodeGem(Graphics g, CGemBase ExplodeGem)
        {
            switch (ExplodeGem._gemType)
            {
                case 0: greenExplode_imgList.Draw(g, ExplodeGem._location, (int)_explodeGemFrameIndex);
                    break;
                case 1:
                    redExplode_imgList.Draw(g, ExplodeGem._location, (int)_explodeGemFrameIndex);
                    break;
                case 2:
                    blueExplode_imgList.Draw(g, ExplodeGem._location, (int)_explodeGemFrameIndex);
                    break;
                case 3:
                    orangeExplode_imgList.Draw(g, ExplodeGem._location, (int)_explodeGemFrameIndex);
                    break;
                case 4:
                    purpleExplode_imgList.Draw(g, ExplodeGem._location, (int)_explodeGemFrameIndex);
                    break;
                case 5:
                    yellowExplode_imgList.Draw(g, ExplodeGem._location, (int)_explodeGemFrameIndex);
                    break;
                case 6:
                    whiteExplode_imgList.Draw(g, ExplodeGem._location, (int)_explodeGemFrameIndex);
                    break;
            }
            
        }
        private bool ExplodeGemIndexSearch(List<CGemBase> explodeGemList, uint row,uint col)
        {
            foreach(var gem in explodeGemList)
            {
                if (gem._row == row && gem._column == col) return true;
            }
            return false;
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private CGemBase GetGemByLocation(int x, int y)
        {
            return _gem[y / 50, x / 50];
        }

        private void timer_selectedSpriteAnimation_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }


        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            if (_isMouseClickListening == true)
            {
                _isMouseClickListening = false;
                var currGem = new CGemBase(GetGemByLocation(e.X, e.Y));
                if (CGemBase._elementSelectedExist == true)
                {
                    var selectedGem = new CGemBase(CGemBase._elementSelected);
                    if (GetGemByLocation(e.X, e.Y).IsSwapable(CGemBase._elementSelected) == false)
                    {
                        CGemBase._elementSelected = GetGemByLocation(e.X, e.Y);
                        _isMouseClickListening = true;
                    }
                    else if (GetGemByLocation(e.X, e.Y).IsSwapable(CGemBase._elementSelected) == true)
                    {
                        // Selected Gem's location is added first.
                        _proccessingGem = new List<CGemBase>();
                        _proccessingGem.Add(selectedGem);
                        _proccessingGem.Add(currGem);
                        CGemBase._elementSelectedExist = false;
                        timer_GoSwap.Start();
                    }
                }
                else if (CGemBase._elementSelectedExist == false)
                {
                    CGemBase._elementSelected = GetGemByLocation(e.X, e.Y);
                    CGemBase._elementSelectedExist = true;
                    timer_selectedSpriteAnimation.Start();
                    _isMouseClickListening = true;
                }
            }

        }


        private void timer_swappingGem_Tick(object sender, EventArgs e)
        {
            _swapSpeed += 5;
            if (GoSwap(_swapSpeed))
            {
                uint gem0Col = _proccessingGem[0]._column;
                uint gem0Row = _proccessingGem[0]._row;
                uint gem1Row = _proccessingGem[1]._row;
                uint gem1Col = _proccessingGem[1]._column;

                SwapExceptLocation(_gem[gem0Row, gem0Col],_gem[gem1Row, gem1Col]);
                CheckExplode(gem1Row,gem1Col);
                CheckExplode(gem0Row, gem0Col);
                
                if (_isExploding == true)
                {
                    _explodeWave++;
                    timer_Explode.Start();
                    CGemBase._elementSelectedExist = false;
                    timer_selectedSpriteAnimation.Stop();
                    //consider mouseClick=true;
                }else if (_isExploding == false)
                {
                    SwapExceptLocation(_gem[gem0Row, gem0Col],_gem[gem1Row, gem1Col]);
                    timer_SwapBack.Start();
                }
                timer_GoSwap.Stop();

            }
            Invalidate();
        }
        private void SwapExceptLocation(CGemBase gem1, CGemBase gem2)
        {
            var gem3 = new CGemBase(gem2);
            gem2._gemType = gem1._gemType;
            gem2._location = gem1._location;
            gem1._gemType = gem3._gemType;
            gem1._location = gem3._location;
        }
        private void CheckExplode(uint row, uint col)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < _explodeGemList[i].Count; j++)
                {
                    if (_explodeGemList[i][j]._row==row&& i == col) return;
                }
            }
            CheckRowMatchType(_gem[row, col]);
        }
        private void CheckRowMatchType(CGemBase gem)
        {
            var row = gem._row;
            var col = gem._column;
            switch (IsRowMatch(_gem[row, col]))
            {
                case ExplodeType.AllLeft:
                    {
                        AddExplodeGem(_explodeGemList[col - 2], _gem[row, col - 2]);
                        AddExplodeGem(_explodeGemList[col - 1], _gem[row, col - 1]);
                        _isExploding = true;
                        CheckColMatchType(_gem[row, col]);
                        AddExplodeGem(_explodeGemList[col], _gem[row, col]);
                        break;
                    }
                case ExplodeType.AllRight:
                    {
                        CheckColMatchType(_gem[row, col]);
                        AddExplodeGem(_explodeGemList[col], _gem[row, col]);
                        AddExplodeGem(_explodeGemList[col + 1], _gem[row, col + 1]);
                        AddExplodeGem(_explodeGemList[col + 2], _gem[row, col + 2]);
                        _isExploding = true;
                        break;
                    }
                case ExplodeType.Balance:
                    {
                        AddExplodeGem(_explodeGemList[col - 1], _gem[row, col - 1]);
                        CheckColMatchType(_gem[row, col]);
                        AddExplodeGem(_explodeGemList[col], _gem[row, col]);
                        AddExplodeGem(_explodeGemList[col + 1], _gem[row, col + 1]);
                        _isExploding = true;
                        break;
                    }
                case ExplodeType.BigBalance:
                    {
                        AddExplodeGem(_explodeGemList[col - 2], _gem[row, col - 2]);
                        AddExplodeGem(_explodeGemList[col - 1], _gem[row, col - 1]);
                        CheckColMatchType(_gem[row, col]);
                        AddExplodeGem(_explodeGemList[col], _gem[row, col]);
                        AddExplodeGem(_explodeGemList[col + 1], _gem[row, col + 1]);
                        AddExplodeGem(_explodeGemList[col + 2], _gem[row, col + 2]);
                        _isExploding = true;
                        break;
                    }
                case ExplodeType.ThreeLeft:
                    {
                        AddExplodeGem(_explodeGemList[col - 3], _gem[row, col - 3]);
                        AddExplodeGem(_explodeGemList[col - 2], _gem[row, col - 2]);
                        AddExplodeGem(_explodeGemList[col - 1], _gem[row, col - 1]);
                        CheckColMatchType(_gem[row, col]);
                        AddExplodeGem(_explodeGemList[col], _gem[row, col]);
                        _isExploding = true;
                        break;
                    }
                case ExplodeType.ThreeRight:
                    {
                        CheckColMatchType(_gem[row, col]);
                        AddExplodeGem(_explodeGemList[col], _gem[row, col]);
                        AddExplodeGem(_explodeGemList[col + 1], _gem[row, col + 1]);
                        AddExplodeGem(_explodeGemList[col + 2], _gem[row, col + 2]);
                        AddExplodeGem(_explodeGemList[col + 3], _gem[row, col + 3]);
                        _isExploding = true;
                        break;
                    }
                case ExplodeType.TwoLeftOneRight:
                    {
                        AddExplodeGem(_explodeGemList[col - 2], _gem[row, col - 2]);
                        AddExplodeGem(_explodeGemList[col - 1], _gem[row, col - 1]);
                        CheckColMatchType(_gem[row, col]);
                        AddExplodeGem(_explodeGemList[col], _gem[row, col]);
                        AddExplodeGem(_explodeGemList[col + 1], _gem[row, col + 1]);
                        _isExploding = true;
                        break;
                    }
                case ExplodeType.TwoRightOneLeft:
                    {
                        AddExplodeGem(_explodeGemList[col - 1], _gem[row, col - 1]);
                        CheckColMatchType(_gem[row, col]);
                        AddExplodeGem(_explodeGemList[col], _gem[row, col]);
                        AddExplodeGem(_explodeGemList[col + 1], _gem[row, col + 1]);
                        AddExplodeGem(_explodeGemList[col + 2], _gem[row, col + 2]);
                        _isExploding = true;
                        break;
                    }
                case ExplodeType.NotExplode:
                    {
                        CheckColMatchType(_gem[row, col]);
                        break;
                    }

            }
        }
        private void CheckColMatchType(CGemBase gem)
        {
            var col = gem._column;
            var row = gem._row;
            switch (IsColunmMatch(_gem[row, col]))
            {
                case ExplodeType.AllAbove:
                    {
                        AddExplodeGem(_explodeGemList[col], _gem[row - 2, col]);
                        AddExplodeGem(_explodeGemList[col], _gem[row - 1, col]);
                        AddExplodeGem(_explodeGemList[col], _gem[row, col]);
                        _isExploding = true;
                        break;
                    }
                case ExplodeType.AllBelow:
                    {
                        AddExplodeGem(_explodeGemList[col], _gem[row, col]);
                        AddExplodeGem(_explodeGemList[col], _gem[row + 1, col]);
                        AddExplodeGem(_explodeGemList[col], _gem[row + 2, col]);
                        _isExploding = true;
                        break;
                    }
                case ExplodeType.Balance:
                    {
                        AddExplodeGem(_explodeGemList[col], _gem[row - 1, col]);
                        AddExplodeGem(_explodeGemList[col], _gem[row, col]);
                        AddExplodeGem(_explodeGemList[col], _gem[row + 1, col]);
                        _isExploding = true;
                        break;
                    }
                case ExplodeType.BigBalance:
                    {
                        AddExplodeGem(_explodeGemList[col], _gem[row - 2, col]);
                        AddExplodeGem(_explodeGemList[col], _gem[row - 1, col]);
                        AddExplodeGem(_explodeGemList[col], _gem[row, col]);
                        AddExplodeGem(_explodeGemList[col], _gem[row + 1, col]);
                        AddExplodeGem(_explodeGemList[col], _gem[row + 2, col]);
                        _isExploding = true;
                        break;
                    }
                case ExplodeType.ThreeAbove:
                    {
                        AddExplodeGem(_explodeGemList[col], _gem[row - 3, col]);
                        AddExplodeGem(_explodeGemList[col], _gem[row - 2, col]);
                        AddExplodeGem(_explodeGemList[col], _gem[row - 1, col]);
                        AddExplodeGem(_explodeGemList[col], _gem[row, col]);
                        _isExploding = true;
                        break;
                    }
                case ExplodeType.ThreeBelow:
                    {
                        AddExplodeGem(_explodeGemList[col], _gem[row, col]);
                        AddExplodeGem(_explodeGemList[col], _gem[row + 1, col]);
                        AddExplodeGem(_explodeGemList[col], _gem[row + 2, col]);
                        AddExplodeGem(_explodeGemList[col], _gem[row + 3, col]);
                        _isExploding = true;
                        break;
                    }
                case ExplodeType.TwoAboveOneBelow:
                    {
                        AddExplodeGem(_explodeGemList[col], _gem[row - 2, col]);
                        AddExplodeGem(_explodeGemList[col], _gem[row - 1, col]);
                        AddExplodeGem(_explodeGemList[col], _gem[row, col]);
                        AddExplodeGem(_explodeGemList[col], _gem[row + 1, col]);
                        _isExploding = true;
                        break;
                    }
                case ExplodeType.TwoBelowOneAbove:
                    {
                        AddExplodeGem(_explodeGemList[col], _gem[row - 1, col]);
                        AddExplodeGem(_explodeGemList[col], _gem[row, col]);
                        AddExplodeGem(_explodeGemList[col], _gem[row + 1, col]);
                        AddExplodeGem(_explodeGemList[col], _gem[row + 2, col]);
                        _isExploding = true;
                        break;
                    }
                case ExplodeType.NotExplode:
                    {
                        break;
                    }
            }
        }
        private void AddExplodeGem(List<CGemBase> listGem,CGemBase gem)
        {
            for(int i = 0; i < listGem.Count; i++)
            {
                if (listGem[i]._row == gem._row && listGem[i]._column == gem._column)
                    return;
            }
            listGem.Add(gem);
        }
        private bool GoSwap(int speed)
        {
            uint gem0Col = _proccessingGem[0]._column;
            uint gem0Row = _proccessingGem[0]._row;
            uint gem1Row = _proccessingGem[1]._row;
            uint gem1Col = _proccessingGem[1]._column;
            if (_gem[gem0Row, gem0Col]._location == _proccessingGem[1]._location)
            {
                return true;
            }
            if (_proccessingGem[0].IsRightOf(_proccessingGem[1]))
            {
                _gem[gem0Row, gem0Col].SwapLeft(_gem[gem1Row, gem1Col], speed);
                _lastSwapInfo = SwapInfo.LeftSwap;
            }
            else if (_proccessingGem[0].IsLeftOf(_proccessingGem[1]))
            {
                _gem[gem0Row, gem0Col].SwapRight(_gem[gem1Row, gem1Col], speed);
                _lastSwapInfo = SwapInfo.RightSwap;
            }
            else if (_proccessingGem[0].IsHeadOf(_proccessingGem[1]))
            {
                _gem[gem0Row, gem0Col].SwapDown(_gem[gem1Row, gem1Col], speed);
                _lastSwapInfo = SwapInfo.DownSwap;
            }
            else if (_proccessingGem[0].IsBottomOf(_proccessingGem[1]))
            {
                _gem[gem0Row, gem0Col].SwapUp(_gem[gem1Row, gem1Col], speed);
                _lastSwapInfo = SwapInfo.UpSwap;
            }
            return false;
        }

        private void timer_SwapBack_Tick(object sender, EventArgs e)
        {
            _swapSpeed -= 5;
            if (SwapBack(_swapSpeed))
            {
                timer_SwapBack.Stop();
                _proccessingGem.Clear();
                CGemBase._elementSelectedExist = false;
                timer_selectedSpriteAnimation.Stop();
                _isMouseClickListening = true;
            }
            Invalidate();
        }
        private bool SwapBack(int speed)
        {
            uint gem0Col = _proccessingGem[0]._column;
            uint gem0Row = _proccessingGem[0]._row;
            uint gem1Row = _proccessingGem[1]._row;
            uint gem1Col = _proccessingGem[1]._column;
            if (_gem[gem0Row, gem0Col]._location == _proccessingGem[0]._location)
            {
                return true;
            }
            if (_lastSwapInfo == SwapInfo.RightSwap)
            {
                _gem[gem0Row, gem0Col].SwapLeft(_gem[gem1Row, gem1Col], speed);
            } else if (_lastSwapInfo == SwapInfo.LeftSwap)
            {
                _gem[gem0Row, gem0Col].SwapRight(_gem[gem1Row, gem1Col], speed);
            }
            else if (_lastSwapInfo == SwapInfo.UpSwap)
            {
                _gem[gem0Row, gem0Col].SwapDown(_gem[gem1Row, gem1Col], speed);
            }
            else if (_lastSwapInfo == SwapInfo.DownSwap)
            {
                _gem[gem0Row, gem0Col].SwapUp(_gem[gem1Row, gem1Col], speed);
            }
            return false;
        }
        private ExplodeType IsRowMatch(CGemBase checkingGem)
        {
            var type = checkingGem._gemType;
            var row = checkingGem._row;
            var col = checkingGem._column;
            if (col > 1 && col < 6)
            {
                if(type==_gem[row,col-2]._gemType&&type==_gem[row,col+2]._gemType
                    &&type == _gem[row, col - 1]._gemType && type == _gem[row, col + 1]._gemType)
                {
                    return ExplodeType.BigBalance;
                }
            }
            if (col > 2)
            {
                if (type == _gem[row, col - 2]._gemType && type == _gem[row, col - 1]._gemType
                    && type == _gem[row, col - 3]._gemType)
                    return ExplodeType.ThreeLeft;
            }
            if (col <5)
            {
                if (type == _gem[row, col + 2]._gemType && type == _gem[row, col + 1]._gemType
                    && type == _gem[row, col + 3]._gemType)
                    return ExplodeType.ThreeRight;
            }
            if (col > 1 && col < 7)
            {
                if (type == _gem[row, col - 2]._gemType && type == _gem[row, col - 1]._gemType
                    && _gem[row, col + 1]._gemType == type)
                    return ExplodeType.TwoLeftOneRight;
            }
            if (col > 0 && col < 6)
            {
                if (type == _gem[row, col + 2]._gemType && _gem[row, col + 1]._gemType == type
                    && type == _gem[row, col - 1]._gemType)
                    return ExplodeType.TwoRightOneLeft;
            }
            if (col > 0 && col < 7)
            {
                if(type == _gem[row, col - 1]._gemType && type == _gem[row, col + 1]._gemType)
                    return ExplodeType.Balance;
            }
            if(col >1)
            {
                if(type == _gem[row, col - 2]._gemType && type == _gem[row, col - 1]._gemType)
                    return ExplodeType.AllLeft;
            }
            if (col < 6 )
            {
                if(type == _gem[row, col + 2]._gemType && _gem[row, col + 1]._gemType == type)
                    return ExplodeType.AllRight;
            }
            return ExplodeType.NotExplode;

        }
        private ExplodeType IsColunmMatch(CGemBase checkingGem)
        {
            var type = checkingGem._gemType;
            var row = checkingGem._row;
            var col = checkingGem._column;
            if (row > 1 && row < 6)
            {
                if (type == _gem[row - 1, col]._gemType && type == _gem[row + 1, col]._gemType
                    && type == _gem[row - 2, col]._gemType && type == _gem[row + 2, col]._gemType)
                    return ExplodeType.BigBalance;
            }
            if (row > 2)
            {
                if (type == _gem[row - 2, col]._gemType && type == _gem[row - 1, col]._gemType
                    && type == _gem[row - 3, col]._gemType)
                    return ExplodeType.ThreeAbove;
            }
            if (row < 5)
            {
                if (_gem[row + 2, col]._gemType == type && type == _gem[row + 1, col]._gemType
                    && _gem[row + 3, col]._gemType == type)
                    return ExplodeType.ThreeBelow;
            }
            if (row > 1 && row < 7)
            {
                if (type == _gem[row - 2, col]._gemType && type == _gem[row - 1, col]._gemType
                    && type == _gem[row + 1, col]._gemType)
                    return ExplodeType.TwoAboveOneBelow;
            }
            if (row < 6 && row > 0)
            {
                if (_gem[row + 2, col]._gemType == type && type == _gem[row + 1, col]._gemType
                    && type == _gem[row - 1, col]._gemType)
                    return ExplodeType.TwoBelowOneAbove;
            }
            if (row > 0 && row < 7 )
            {
                if(type == _gem[row - 1, col]._gemType && type == _gem[row + 1, col]._gemType)
                    return ExplodeType.Balance;
            }
            if (row > 1  )
            {
                if(type == _gem[row - 2, col]._gemType && type == _gem[row - 1, col]._gemType)
                    return ExplodeType.AllAbove;
            }
            if (row < 6 )
            {
                if (_gem[row + 2, col]._gemType == type && type == _gem[row + 1, col]._gemType)
                    return ExplodeType.AllBelow;
            }
            return ExplodeType.NotExplode;
        }

        private void timer_Explode_Tick(object sender, EventArgs e)
        {
            _explodeGemFrameIndex++;
            if (_explodeGemFrameIndex  == 6)
            {
                timer_Explode.Stop();
                // _explodeGemList.Clear();
                // _isMouseClickListening = true;
                // _explodeGemFrameIndex = 0;
                if (_explodeWave < 6)
                {
                    _crushSound[_explodeWave-1].Play();
                }
                else _finalCrushSound.Play();
                _isExploding = false;
                CGemBase._elementSelectedExist = false;
                _lastSwapInfo = SwapInfo.NullSwap;
                _normalGemFrameIndex = 0;
                _whiteGemFrameIndex = 0;
                _swapSpeed = 0;
                UpdateOldGemAndAddNewGemAttribute();
                SetScoreInOneMove();
                timer_updateScreen.Start();
            }
            else Invalidate();

        }
        private void SetScoreInOneMove()
        {
            for(int i = 0; i < 8; i++)
            {
                _scoreInOneMove += (uint)(_explodeGemList[i].Count) * _explodeWave*60;
            }
        }
        private uint SearchLowestRowExplodeGem(List<CGemBase> gemList)
        {
            uint Lowest = 0;
            foreach(var gem in gemList)
            {
                if (gem._row > Lowest)
                {
                    Lowest = gem._row;
                }
            }
            return Lowest;
        }
        private void UpdateOldGemAndAddNewGemAttribute()
        {
            for(int i = 0; i < 8; i++)
            {
                var maxRowIndex = SearchLowestRowExplodeGem(_explodeGemList[i]);
                for(int j = (int)maxRowIndex;j>=_explodeGemList[i].Count ; j--)
                {
                    _gem[j, i]._location = _gem[j - _explodeGemList[i].Count, i]._location;
                    _gem[j, i]._gemType = _gem[j - _explodeGemList[i].Count, i]._gemType;
                }
                for(int j = 0; j < _explodeGemList[i].Count; j++)
                {
                    _gem[j,i] = new CGemBase(
                        new Point((int)(this.label1.Location.X + (50 * i)), (_explodeGemList[i].Count-1-j)*-50)
                        , (uint)j
                        , (uint)i
                        , (uint)new Random(Guid.NewGuid().GetHashCode()).Next(1, 100)%(CLevel._currLevel.LevelID + 4>7?7: CLevel._currLevel.LevelID + 4));
                    _colToCheckExplode[i] = true;
                }
            }
        }
        private void UpdateOldGemLocation(int speed)
        {
            for (int i =0; i < 8; i++)
            {
                for(int j= (int)SearchLowestRowExplodeGem(_explodeGemList[i]); j>=_explodeGemList[i].Count;j--)
                {
                    if (_gem[j, i]._location.Y < 150 + 50 * j)
                    {
                        _gem[j, i]._location = new Point(_gem[j, i]._location.X, _gem[j, i]._location.Y + speed);
                    }
                }
            }
        }
        private void UpdateNewGemLocation(int speed)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = _explodeGemList[i].Count-1; j>=0 ; j--)
                {
                    if (_gem[j, i]._location.Y < 150 + 50 * j)
                    {
                        _gem[j, i]._location = new Point(_gem[j, i]._location.X, _gem[j, i]._location.Y + speed);
                    }
                }
            }
        }
        private void timer_updateScreen_Tick(object sender, EventArgs e)
        {
            var updateSuccessfullyColCount = 0;
            UpdateOldGemLocation(25);
            UpdateNewGemLocation(25);
            Invalidate();      
            for(int i = 0; i < 8; i++)
            {
                if (_gem[0, i]._location.Y == this.label1.Location.Y)
                {
                    updateSuccessfullyColCount++;
                }
            }
            if(updateSuccessfullyColCount==8)
            {
                timer_updateScreen.Stop();
                ReInitialize();
                for(int i = 0; i < 8; i++)
                {
                    if (_colToCheckExplode[i] == true)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            CheckExplode((uint)j,(uint)i);
                        }
                    }
                    _colToCheckExplode[i] = false;
                }
                if (_isExploding == true)
                {
                    timer_Explode.Start();
                    _isMouseClickListening = false;
                    _explodeWave++;
                }
                else _explodeWave = 0;
            }
        }
        private void ReInitialize()
        {
            _isMouseClickListening = true;
            _lastSwapInfo = SwapInfo.NullSwap;
            _explodeGemFrameIndex = 0;
            foreach(var list in _explodeGemList)
            {
                list.Clear();
            }
            _proccessingGem.Clear();
            CGemBase._elementSelectedExist = false;
            _isExploding = false;
            timer_GoSwap.Stop();
            timer_Explode.Stop();
            timer_updateScreen.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer_scoreCount_Tick(object sender, EventArgs e)
        {
            if (_scoreInOneMove > 0)
            {
                if (CLevel._currLevel.LevelID > 2)
                {
                    _score += 20;
                    _scoreInOneMove -= 20;
                    Invalidate();
                }
                else
                {
                    _score += 60;
                    _scoreInOneMove -= 60;
                    Invalidate();
                }
            }
        }

        private void timer_gameTimeLimit_Tick(object sender, EventArgs e)
        {
            if (timer_updateScreen.Enabled == false)
            {
                this.progressBar1.Value -= 1;
            }
            if (this.progressBar1.Value == 0)
            {
                timer_gameTimeLimit.Stop();
                
                if (_score > _targetScore[CLevel._currLevel.LevelID])
                {
                    uint star = 1;
                    uint gold = 0;
                    ReInitialize();
                    _victorySound.Play();
                    if (_score > CUser.Instance().GetLevel((int)CLevel._currLevel.LevelID)._highestScore)
                    {
                        if (_score > _targetScore[CLevel._currLevel.LevelID] + 1000)
                        {
                            star++;
                        }
                        if (_score > _targetScore[CLevel._currLevel.LevelID] + 3000)
                        {
                            star++;
                        }
                        if (star > CUser.Instance().GetLevel((int)CLevel._currLevel.LevelID)._highestStar)
                        {
                            gold=(star - CUser.Instance().GetLevel((int)CLevel._currLevel.LevelID)._highestStar) * 50;
                            CUser.Instance()._goldCount += gold;
                            CUser.Instance().GetLevel((int)CLevel._currLevel.LevelID)._highestStar=star;
                        }
                        MessageBox.Show("New high score : "+_score.ToString()+"\n You earn "+gold.ToString()+" gold. Congratulation!" );
                    }
                    else
                    {
                        MessageBox.Show("You win! Last time you do better!");
                    }
                    if (CUser.Instance()._currLevel == CLevel._currLevel.LevelID )
                    {
                        CUser.Instance()._currLevel++;
                    }
                    if (CUser.Instance().GetLevel((int)CLevel._currLevel.LevelID)._highestScore < _score)
                    {
                        CUser.Instance().GetLevel((int)CLevel._currLevel.LevelID)._highestScore = _score; 
                    }
                    CUser.UpdateOfflineUserInfo();
                    CLevel.UpdateOfflineLevelInfo((int)CLevel._currLevel.LevelID);
                    this.Close();

                }
                else
                {
                    ReInitialize();
                    _gameOverSound.Play();
                    MessageBox.Show("Game over!");
                    this.Close();
                }

            }
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            _victorySound.Stop();
            _score = 0;
        }

        private void but_back_picBox_Click(object sender, EventArgs e)
        {
            this.Close();
            CUser.Instance()._lifeCount--;
            CUser.UpdateOfflineUserInfo();
            MessageBox.Show("You have just lost 1 life.");
            this.Dispose();
        }
    }
}

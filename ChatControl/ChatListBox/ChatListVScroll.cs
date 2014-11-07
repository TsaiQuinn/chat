using System.Drawing;
using System.Windows.Forms;

namespace ChatControl.ChatListBox
{
    internal class ChatListVScroll
    {
        //滚动条自身的区域

        #region Fields

        private Color arrowBackColor;

        private Color arrowColor;

        private Color backColor;

        private Rectangle bounds;

        private Control ctrl;

        //下边箭头区域
        private Rectangle downBounds;

        private bool isMouseDown;

        private bool isMouseOnDown;

        private bool isMouseOnSlider;

        private bool isMouseOnUp;

        private int m_nLastSliderY;

        private int mouseDownY;

        private bool shouldBeDraw;

        //滑块区域
        private Rectangle sliderBounds;

        private Color sliderDefaultColor;

        private Color sliderDownColor;

        private Rectangle upBounds;

        private int value;

        private int virtualHeight;

        #endregion

        #region Constructors and Destructors

        public ChatListVScroll(Control c)
        {
            this.ctrl = c;
            this.virtualHeight = 400;
            this.bounds = new Rectangle(0, 0, 10, 10);
            this.upBounds = new Rectangle(0, 0, 10, 10);
            this.downBounds = new Rectangle(0, 0, 10, 10);
            this.sliderBounds = new Rectangle(0, 0, 10, 10);
            this.backColor = Color.LightYellow;
            this.sliderDefaultColor = Color.Gray;
            this.sliderDownColor = Color.DarkGray;
            this.arrowBackColor = Color.Gray;
            this.arrowColor = Color.White;
        }

        #endregion

        #region Public Properties

        public Color ArrowBackColor
        {
            get
            {
                return this.arrowBackColor;
            }
            set
            {
                if (this.arrowBackColor == value)
                {
                    return;
                }
                this.arrowBackColor = value;
                this.ctrl.Invalidate(this.bounds);
            }
        }

        public Color ArrowColor
        {
            get
            {
                return this.arrowColor;
            }
            set
            {
                if (this.arrowColor == value)
                {
                    return;
                }
                this.arrowColor = value;
                this.ctrl.Invalidate(this.bounds);
            }
        }

        public Color BackColor
        {
            get
            {
                return this.backColor;
            }
            set
            {
                this.backColor = value;
            }
        }

        public Rectangle Bounds
        {
            get
            {
                return this.bounds;
            }
        }

        //绑定的控件

        public Control Ctrl
        {
            get
            {
                return this.ctrl;
            }
            set
            {
                this.ctrl = value;
            }
        }

        public Rectangle DownBounds
        {
            get
            {
                return this.downBounds;
            }
        }

        //虚拟的一个高度(控件中内容的高度)

        public bool IsMouseDown
        {
            get
            {
                return this.isMouseDown;
            }
            set
            {
                if (value)
                {
                    this.m_nLastSliderY = this.sliderBounds.Y;
                }
                this.isMouseDown = value;
            }
        }

        public bool IsMouseOnDown
        {
            get
            {
                return this.isMouseOnDown;
            }
            set
            {
                if (this.isMouseOnDown == value)
                {
                    return;
                }
                this.isMouseOnDown = value;
                this.ctrl.Invalidate(this.DownBounds);
            }
        }

        public bool IsMouseOnSlider
        {
            get
            {
                return this.isMouseOnSlider;
            }
            set
            {
                if (this.isMouseOnSlider == value)
                {
                    return;
                }
                this.isMouseOnSlider = value;
                this.ctrl.Invalidate(this.SliderBounds);
            }
        }

        public bool IsMouseOnUp
        {
            get
            {
                return this.isMouseOnUp;
            }
            set
            {
                if (this.isMouseOnUp == value)
                {
                    return;
                }
                this.isMouseOnUp = value;
                this.ctrl.Invalidate(this.UpBounds);
            }
        }

        public int MouseDownY
        {
            get
            {
                return this.mouseDownY;
            }
            set
            {
                this.mouseDownY = value;
            }
        }

        public bool ShouldBeDraw
        {
            get
            {
                return this.shouldBeDraw;
            }
        }

        public Rectangle SliderBounds
        {
            get
            {
                return this.sliderBounds;
            }
        }

        public Color SliderDefaultColor
        {
            get
            {
                return this.sliderDefaultColor;
            }
            set
            {
                if (this.sliderDefaultColor == value)
                {
                    return;
                }
                this.sliderDefaultColor = value;
                this.ctrl.Invalidate(this.sliderBounds);
            }
        }

        public Color SliderDownColor
        {
            get
            {
                return this.sliderDownColor;
            }
            set
            {
                if (this.sliderDownColor == value)
                {
                    return;
                }
                this.sliderDownColor = value;
                this.ctrl.Invalidate(this.sliderBounds);
            }
        }

        public Rectangle UpBounds
        {
            get
            {
                return this.upBounds;
            }
        }

        public int Value
        {
            get
            {
                return this.value;
            }
            set
            {
                if (!this.shouldBeDraw)
                {
                    return;
                }
                if (value < 0)
                {
                    if (this.value == 0)
                    {
                        return;
                    }
                    this.value = 0;
                    this.ctrl.Invalidate();
                    return;
                }
                if (value > this.virtualHeight - this.ctrl.Height)
                {
                    if (this.value == this.virtualHeight - this.ctrl.Height)
                    {
                        return;
                    }
                    this.value = this.virtualHeight - this.ctrl.Height;
                    this.ctrl.Invalidate();
                    return;
                }
                this.value = value;
                this.ctrl.Invalidate();
            }
        }

        public int VirtualHeight
        {
            get
            {
                return this.virtualHeight;
            }
            set
            {
                if (value <= this.ctrl.Height)
                {
                    if (this.shouldBeDraw == false)
                    {
                        return;
                    }
                    this.shouldBeDraw = false;
                    if (this.value != 0)
                    {
                        this.value = 0;
                        this.ctrl.Invalidate();
                    }
                }
                else
                {
                    this.shouldBeDraw = true;
                    if (value - this.value < this.ctrl.Height)
                    {
                        this.value -= this.ctrl.Height - value + this.value;
                        this.ctrl.Invalidate();
                    }
                }
                this.virtualHeight = value;
            }
        }

        #endregion

        //滑块移动前的 滑块的y坐标

        #region Public Methods and Operators

        public void ClearAllMouseOn()
        {
            if (!this.isMouseOnDown && !this.isMouseOnSlider && !this.isMouseOnUp)
            {
                return;
            }
            this.isMouseOnDown = this.isMouseOnSlider = this.isMouseOnUp = false;
            this.ctrl.Invalidate(this.bounds);
        }

        //将滑块跳动至一个地方

        //根据鼠标位置移动滑块
        public void MoveSliderFromLocation(int nCurrentMouseY)
        {
            //if (!this.IsMouseDown) return;
            if (this.m_nLastSliderY + nCurrentMouseY - this.mouseDownY < 11)
            {
                if (this.sliderBounds.Y == 11)
                {
                    return;
                }
                this.sliderBounds.Y = 11;
            }
            else if (this.m_nLastSliderY + nCurrentMouseY - this.mouseDownY
                     > this.ctrl.Height - 11 - this.SliderBounds.Height)
            {
                if (this.sliderBounds.Y == this.ctrl.Height - 11 - this.sliderBounds.Height)
                {
                    return;
                }
                this.sliderBounds.Y = this.ctrl.Height - 11 - this.sliderBounds.Height;
            }
            else
            {
                this.sliderBounds.Y = this.m_nLastSliderY + nCurrentMouseY - this.mouseDownY;
            }
            this.value =
                (int)
                ((double)(this.sliderBounds.Y - 11) / (this.ctrl.Height - 22 - this.SliderBounds.Height)
                 * (this.virtualHeight - this.ctrl.Height));
            this.ctrl.Invalidate();
        }

        public void MoveSliderToLocation(int nCurrentMouseY)
        {
            if (nCurrentMouseY - this.sliderBounds.Height / 2 < 11)
            {
                this.sliderBounds.Y = 11;
            }
            else if (nCurrentMouseY + this.sliderBounds.Height / 2 > this.ctrl.Height - 11)
            {
                this.sliderBounds.Y = this.ctrl.Height - this.sliderBounds.Height - 11;
            }
            else
            {
                this.sliderBounds.Y = nCurrentMouseY - this.sliderBounds.Height / 2;
            }
            this.value =
                (int)
                ((double)(this.sliderBounds.Y - 11) / (this.ctrl.Height - 22 - this.SliderBounds.Height)
                 * (this.virtualHeight - this.ctrl.Height));
            this.ctrl.Invalidate();
        }

        //绘制滚动条
        public void ReDrawScroll(Graphics g)
        {
            if (!this.shouldBeDraw)
            {
                return;
            }
            this.bounds.X = this.ctrl.Width - 10;
            this.bounds.Height = this.ctrl.Height;
            this.upBounds.X = this.downBounds.X = this.bounds.X;
            this.downBounds.Y = this.ctrl.Height - 10;
            //计算滑块位置
            this.sliderBounds.X = this.bounds.X;
            this.sliderBounds.Height = (int)(((double)this.ctrl.Height / this.virtualHeight) * (this.ctrl.Height - 22));
            if (this.sliderBounds.Height < 3)
            {
                this.sliderBounds.Height = 3;
            }
            this.sliderBounds.Y = 11
                                  + (int)
                                    (((double)this.value / (this.virtualHeight - this.ctrl.Height))
                                     * (this.ctrl.Height - 22 - this.sliderBounds.Height));
            var sb = new SolidBrush(this.backColor);
            try
            {
                g.FillRectangle(sb, this.bounds);
                sb.Color = this.arrowBackColor;
                g.FillRectangle(sb, this.upBounds);
                g.FillRectangle(sb, this.downBounds);
                if (this.isMouseDown || this.isMouseOnSlider)
                {
                    sb.Color = this.sliderDownColor;
                }
                else
                {
                    sb.Color = this.sliderDefaultColor;
                }
                g.FillRectangle(sb, this.sliderBounds);
                sb.Color = this.arrowColor;
                if (this.isMouseOnUp)
                {
                    g.FillPolygon(
                        sb,
                        new[]
                            {
                                new Point(this.ctrl.Width - 5, 3), new Point(this.ctrl.Width - 9, 7),
                                new Point(this.ctrl.Width - 2, 7)
                            });
                }
                if (this.isMouseOnDown)
                {
                    g.FillPolygon(
                        sb,
                        new[]
                            {
                                new Point(this.ctrl.Width - 5, this.ctrl.Height - 4),
                                new Point(this.ctrl.Width - 8, this.ctrl.Height - 7),
                                new Point(this.ctrl.Width - 2, this.ctrl.Height - 7)
                            });
                }
            }
            finally
            {
                sb.Dispose();
            }
        }

        #endregion
    }
}
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DynamicGifLib;
using ImageOleLib;

namespace ChatControl.ChatRichTextBox
{
    /* 作者：Starts_2000
     * 日期：2009-09-13
     * 网站：http://www.csharpwin.com CS 程序员之窗。
     * 你可以免费使用或修改以下代码，但请保留版权信息。
     * 具体请查看 CS程序员之窗开源协议（http://www.csharpwin.com/csol.html）。
     */

    public class ChatRichTextBox : RichTextBox
    {
        private RichEditOle _richEditOle;
        private Dictionary<int, REOBJECT> _oleObjectList;
        private int _index;

        public ChatRichTextBox()
            : base()
        {
        }

        public Dictionary<int, REOBJECT> OleObjectList
        {
            get
            {
                if (_oleObjectList == null)
                {
                    _oleObjectList = new Dictionary<int, REOBJECT>(10);
                }
                return _oleObjectList;
            }
        }

        internal RichEditOle RichEditOle
        {
            get
            {
                if (_richEditOle == null)
                {
                    if (base.IsHandleCreated)
                    {
                        _richEditOle = new RichEditOle(this);
                    }
                }

                return _richEditOle;
            }
        }

        public bool InsertImageUseImageOle(string path)
        {
            try
            {
                IGifAnimator gif = new GifAnimatorClass();
                gif.LoadFromFile(path);
                
                gif.TriggerFrameChange();
                if (gif is IOleObject)
                {
                    int index = _index++;
                    REOBJECT reObj = RichEditOle.InsertOleObject(
                        (IOleObject)gif,
                        index);
                    RichEditOle.UpdateObjects(reObj.cp);
                    OleObjectList.Add(index, reObj);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool InsertImageUseDynamic(string path)
        {
            try
            {
                IDynamicGif gif = new DynamicGifClass();
                gif.LoadFromFile(path);
                gif.Play();
                if (gif is IOleObject)
                {
                    int index = _index++;
                    REOBJECT reObj = RichEditOle.InsertOleObject(
                        (IOleObject)gif,
                        index);
                    RichEditOle.UpdateObjects(reObj.cp);
                    OleObjectList.Add(index, reObj);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool InsertImageUseGifBox(string path)
        {
            try
            {
                GifBox gif = new GifBox();
                gif.BackColor = base.BackColor;
                gif.Image = Image.FromFile(path);
                RichEditOle.InsertControl(gif);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// 添加一个控件   2013.8.16 CK
        /// </summary> 
        public void InsertControl(Control control)
        {
            //RichEditOle ole = new RichEditOle(this);
            //ole.InsertControl(control);
            RichEditOle.InsertControl(control);
        }
    }
}

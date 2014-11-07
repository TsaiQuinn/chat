using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;

namespace ChatControl.ChatListBox
{
    internal class ChatListItemConverter : ExpandableObjectConverter
    {
        #region Public Methods and Operators

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            //MessageBox.Show("CanConvertTo:" + (destinationType == typeof(InstanceDescriptor)));
            return destinationType == typeof(InstanceDescriptor) || base.CanConvertTo(context, destinationType);
        }

        public override object ConvertTo(
            ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == null)
            {
                throw new ArgumentNullException("DestinationType cannot be null");
            }
            //MessageBox.Show("Convertto OK");
            if (destinationType == typeof(InstanceDescriptor) && (value is ChatListItem))
            {
                ConstructorInfo constructor = null;
                var item = (ChatListItem)value;
                ChatListSubItem[] subItems = null;
                //MessageBox.Show("Convertto Start Item:" + item.Text);
                //MessageBox.Show("Item.SubItems.Count:" + item.SubItems.Count);
                if (item.SubItems.Count > 0)
                {
                    subItems = new ChatListSubItem[item.SubItems.Count];
                    item.SubItems.CopyTo(subItems, 0);
                }
                //MessageBox.Show("Item.SubItems.Count:" + item.SubItems.Count);
                if (item.Text != null && subItems != null)
                {
                    constructor =
                        typeof(ChatListItem).GetConstructor(new[] { typeof(string), typeof(ChatListSubItem[]) });
                }
                //MessageBox.Show("Constructor(Text,item[]):" + (constructor != null));
                if (constructor != null)
                {
                    return new InstanceDescriptor(constructor, new object[] { item.Text, subItems }, false);
                }

                if (subItems != null)
                {
                    constructor = typeof(ChatListItem).GetConstructor(new[] { typeof(ChatListSubItem[]) });
                }
                if (constructor != null)
                {
                    return new InstanceDescriptor(constructor, new object[] { subItems }, false);
                }
                if (item.Text != null)
                {
                    //MessageBox.Show("StartGetConstructor(text)");
                    constructor = typeof(ChatListItem).GetConstructor(new[] { typeof(string), typeof(bool) });
                }
                //MessageBox.Show("Constructor(Text):" + (constructor != null));
                if (constructor != null)
                {
                    //System.Windows.Forms.MessageBox.Show("text OK");
                    return new InstanceDescriptor(constructor, new object[] { item.Text, item.IsOpen });
                }
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }

        #endregion
    }
}
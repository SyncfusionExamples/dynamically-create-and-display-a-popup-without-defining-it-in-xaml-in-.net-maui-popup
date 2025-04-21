using Syncfusion.Maui.Popup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiPopup
{
    public static class PopupHelper
    {
        public static SfPopup Popup =>
            new SfPopup()
            {
                HeaderTitle = "Popup Header",
                ShowCloseButton = true,
                PopupStyle = new PopupStyle()
                {
                    HeaderBackground = Colors.Pink,
                }
            };
    }
}

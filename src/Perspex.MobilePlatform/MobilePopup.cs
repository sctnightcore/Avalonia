﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Perspex.Platform;

namespace Perspex.MobilePlatform
{
    class MobilePopup : MobileTopLevel, IPopupImpl, IHaveScreenPosition
    {
        public void SetPosition(Point p)
        {
            X = (int) p.X;
            Y = (int) p.Y;
            Platform.Scene.RenderRequestedBy(this);
        }

        public void Show()
        {
            Platform.Scene.AddPopup(this);
        }

        public void Hide()
        {
            Platform.Scene.RemovePopup(this);
        }

        public int X { get; set; }
        public int Y { get; set; }
        public override Size ClientSize { get; set; }
    }
}
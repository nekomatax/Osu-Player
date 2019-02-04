﻿using OSharp.Storyboard;
using OSharp.Storyboard.Events;
using System.Collections.Generic;

namespace Milkitic.OsuPlayer.Media.Storyboard
{
    public struct RenderThings
    {
        public int Index;
        public Element Elment;
        public IEnumerable<ICommonEvent> Events;
    }
}
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AbstractFactory.Modern
{
    class ModernChair : IChair
    {
        public Color Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}

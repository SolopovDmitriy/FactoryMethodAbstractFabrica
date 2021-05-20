using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AbstractFactory.Modern
{
    class ModernSofa : ISofa
    {
        public Color Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}

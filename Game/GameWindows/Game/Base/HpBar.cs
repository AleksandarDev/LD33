using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameWindows.Game.Base
{
    public class HpBar : StaticObject
    {
        public HpBar(Texture2D texture)
            : base(texture, new Vector2(100 , 100), 300, 50)
        {
        }
    }
}

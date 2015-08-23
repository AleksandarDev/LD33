using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameWindows.Game.Base
{
    public class HpBar : MovableBase
    {
        public HpBar(Texture2D texture)
            : base(texture, Vector2.Zero, 48, 8)
        {
            this.GreenWidht = 100;
        }
        public override void Draw(SpriteBatch sb, float delta)
        {
            sb.Draw(this.Texture, this.Position, null, null, Vector2.Zero, 0, new Vector2(this.Width / this.Texture.Width, this.Height / this.Texture.Height), Color.Red);

            sb.Draw(this.Texture, this.Position, null, null, Vector2.Zero, 0, new Vector2(this.GreenWidht / this.Texture.Width, this.Height / this.Texture.Height), Color.Green);
        }

        public float GreenWidht;

        public void SetHealth(int amount)
        {
            this.GreenWidht = (amount / 100f) * this.Width;

        }
    }
}

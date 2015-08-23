using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameWindows.Game.Base;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameWindows.Game.Player
{

	internal interface IPlayer : ICreature
	{
	}

    public class Player : IPlayer
    {
        public Player(Texture2D texture, Vector2 position)
        {
            // Setting player values
            this.Texture = texture;
            this.Position = position;
            this.Active = true;
            this.Health = 100;
        }

        // Get the height of the player
        public float Height { get; set; }


        // Position of the player
        public Vector2 Position { get; set; }
        

        // Get width of the player
        public float Width { get; set; }


        public void Draw(SpriteBatch sb, float delta)
        {
            sb.Draw(this.Texture, this.Position, Color.White);
        }

        public void Update(float delta)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// State of the player
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Animation of the player
        /// </summary>
        public Texture2D Texture { get; set; }

        /// <summary>
        /// Amount of hit points of the player
        /// </summary>
        public int Health { get; set; }
    }
}


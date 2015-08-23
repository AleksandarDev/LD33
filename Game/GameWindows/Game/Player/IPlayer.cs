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
		/// <summary>
		/// Amount of hit points of the player
		/// </summary>
		int Health { get; set; }
	}

    public class Player : Creature, IPlayer
    {
        public Player(Texture2D texture, Vector2 position)
        {
            // Setting player values
            this.Texture = texture;
            this.Position = position;
            this.Active = true;
            this.Health = 100;
	        this.Speed = 3;
        }

        /// <summary>
        /// Amount of hit points of the player
        /// </summary>
        public int Health { get; set; }
    }
}


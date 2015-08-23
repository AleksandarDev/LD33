using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameWindows.Game.Base
{
	internal interface IRotatable
	{
		/// <summary>
		/// Gets or sets the rotation.
		/// </summary>
		/// <value>
		/// The rotation.
		/// </value>
		float Rotation { get; set; }

		/// <summary>
		/// Rotates towards given position.
		/// </summary>
		/// <param name="position">The position.</param>
		void RotateTo(Vector2 position);
	}

	internal interface ICreature : IMovable, IRotatable
	{
	}

	public abstract class Creature : MovableBase, ICreature
	{
		/// <summary>
		/// Gets or sets the rotation.
		/// </summary>
		/// <value>
		/// The rotation.
		/// </value>
		public float Rotation { get; set; }

		/// <summary>
		/// Rotates towards given position.
		/// </summary>
		/// <param name="position">The position.</param>
		/// <exception cref="System.NotImplementedException"></exception>
		public void RotateTo(Vector2 position)
		{
			this.Rotation = (float)Math.Atan2(position.Y - this.Position.Y, position.X - this.Position.X) + MathHelper.ToRadians(90);
		}

		/// <summary>
		/// Draws the object.
		/// </summary>
		/// <param name="sb">The sb.</param>
		/// <param name="delta">The delta.</param>
		public override void Draw(SpriteBatch sb, float delta)
		{
			sb.Draw(this.Texture, this.Position, null, null, new Vector2(this.Texture.Width / 2f, this.Texture.Height / 2f), this.Rotation, Vector2.One * 2, Color.White, SpriteEffects.None, 0);
		}
	}
}
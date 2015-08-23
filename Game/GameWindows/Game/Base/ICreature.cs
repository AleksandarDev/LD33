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
			// TODO Calculate rotation
		}

		/// <summary>
		/// Draws the object.
		/// </summary>
		/// <param name="sb">The sb.</param>
		/// <param name="delta">The delta.</param>
		public override void Draw(SpriteBatch sb, float delta)
		{
			sb.Draw(this.Texture, this.Position, null, null, Vector2.One / 2f, this.Rotation, Vector2.One * 2, Color.White, SpriteEffects.None, 0);
		}
	}
}
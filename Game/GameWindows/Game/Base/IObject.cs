using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameWindows.Game.Base
{
	internal interface IObject : IDisposable
	{
		/// <summary>
		/// Gets or sets the texture.
		/// </summary>
		/// <value>
		/// The texture.
		/// </value>
		Texture2D Texture { get; set; }

		/// <summary>
		/// Gets or sets the position of the object.
		/// </summary>
		/// <value>
		/// The position.
		/// </value>
		Vector2 Position { get; set; }

		/// <summary>
		/// Gets or sets the width of the object.
		/// </summary>
		/// <value>
		/// The width.
		/// </value>
		float Width { get; set; }

		/// <summary>
		/// Gets or sets the height of the object.
		/// </summary>
		/// <value>
		/// The height.
		/// </value>
		float Height { get; set; }

		/// <summary>
		/// Updates the object.
		/// </summary>
		/// <param name="delta">The delta.</param>
		void Update(float delta);

		/// <summary>
		/// Draws the object.
		/// </summary>
		/// <param name="sb">The sb.</param>
		/// <param name="delta">The delta.</param>
		void Draw(SpriteBatch sb, float delta);
	}
}
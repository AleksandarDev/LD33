using System;
using Microsoft.Xna.Framework;

namespace GameWindows.Game.Base
{
	internal interface IObject : IDisposable
	{
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
		/// Updates this instance.
		/// </summary>
		void Update(float delta);

		/// <summary>
		/// Draws this instance.
		/// </summary>
		void Draw(float delta);
	}
}
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameWindows.Game.Base
{
	/// <summary>
	/// Static object.
	/// </summary>
	public class StaticObject : IStatic
	{
		private readonly float height;
		private readonly float width;
		private readonly Vector2 position;
		private readonly Texture2D texture;


		/// <summary>
		/// Initializes a new instance of the <see cref="StaticObject"/> class.
		/// </summary>
		/// <param name="texture">The texture.</param>
		/// <param name="position">The position.</param>
		/// <param name="width">The width.</param>
		/// <param name="height">The height.</param>
		public StaticObject(Texture2D texture, Vector2 position, float width, float height)
		{
			this.texture = texture;
			this.position = position;
			this.width = width;
			this.height = height;
		}


		/// <summary>
		/// Gets or sets the height of the object.
		/// </summary>
		/// <value>
		/// The height.
		/// </value>
		/// <exception cref="NotSupportedException">Can't change the size of static object</exception>
		public float Height
		{
			get { return this.height; }
			set { throw new NotSupportedException("Can't change the size of static object"); }
		}

		/// <summary>
		/// Gets or sets the position of the object.
		/// </summary>
		/// <value>
		/// The position.
		/// </value>
		/// <exception cref="NotSupportedException">Can't change the position of static object</exception>
		public Vector2 Position
		{
			get { return this.position; }
			set { throw new NotSupportedException("Can't change the position of static object"); }
		}

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="IObject" /> is active.
		/// </summary>
		/// <value>
		///   <c>true</c> if active; otherwise, <c>false</c>.
		/// </value>
		public bool Active { get; set; }

		/// <summary>
		/// Gets or sets the texture.
		/// </summary>
		/// <value>
		/// The texture.
		/// </value>
		/// <exception cref="NotSupportedException">Can't change the texture of static object</exception>
		public Texture2D Texture
		{
			get { return this.texture; }
			set { throw new NotSupportedException("Can't change the texture of static object"); }
		}

		/// <summary>
		/// Gets or sets the width of the object.
		/// </summary>
		/// <value>
		/// The width.
		/// </value>
		/// <exception cref="NotImplementedException"></exception>
		/// <exception cref="NotSupportedException">Can't change the size of static object</exception>
		public float Width
		{
			get { return this.width; }
			set { throw new NotSupportedException("Can't change the size of static object"); }
		}

		/// <summary>
		/// Draws the object.
		/// </summary>
		/// <param name="sb">The sb.</param>
		/// <param name="delta">The delta.</param>
		public virtual void Draw(SpriteBatch sb, float delta)
		{
			sb.Draw(this.Texture, this.Position, null, null, Vector2.One / 2f, 0, new Vector2(this.Width / this.Texture.Width, this.Height / this.Texture.Height), Color.White);
		}

		/// <summary>
		/// Updates the object.
		/// </summary>
		/// <param name="delta">The delta.</param>
		public virtual void Update(float delta)
		{
			// Do nothing. It's a static object.
		}

		#region IDisposable Support

		private bool disposedValue = false; // To detect redundant calls

		/// <summary>
		/// Releases unmanaged and - optionally - managed resources.
		/// </summary>
		/// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
		protected virtual void Dispose(bool disposing)
		{
			if (disposedValue) return;

			if (disposing)
			{
			}

			disposedValue = true;
		}

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			Dispose(true);
		}

		#endregion

	}
}
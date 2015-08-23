using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameWindows.Game.Base
{
	internal interface IStatic : IObject
	{
			
	}

	public class StaticObject : IStatic
	{
		private float height;
		private float width;
		private Vector2 position;
		private Texture2D texture;

		public float Height
		{
			get { return this.height; }

			set
			{
				throw new NotSupportedException("Can't change size of static object");
			}
		}

		public Vector2 Position
		{
			get
			{
				throw new NotImplementedException();
			}

			set
			{
				throw new NotImplementedException();
			}
		}

		public Texture2D Texture
		{
			get
			{
				throw new NotImplementedException();
			}

			set
			{
				throw new NotImplementedException();
			}
		}

		public float Width
		{
			get
			{
				throw new NotImplementedException();
			}

			set
			{
				throw new NotSupportedException("Can't change size of static object");
			}
		}

		/// <summary>
		/// Draws the object.
		/// </summary>
		/// <param name="sb">The sb.</param>
		/// <param name="delta">The delta.</param>
		public void Draw(SpriteBatch sb, float delta)
		{
			sb.Draw(this.Texture, this.Position, Color.White);
		}

		/// <summary>
		/// Updates the object.
		/// </summary>
		/// <param name="delta">The delta.</param>
		public void Update(float delta)
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
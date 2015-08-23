using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameWindows.Game.Base
{
	public abstract class MovableBase : IMovable
	{
		private Vector2? destination;
        

        public MovableBase()
        {

        }

        public MovableBase(Texture2D texture, Vector2 position, float width, float height)
        {
            Texture = texture;
            this.Position = position;
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="IObject" /> is active.
        /// </summary>
        /// <value>
        ///   <c>true</c> if active; otherwise, <c>false</c>.
        /// </value>
        public bool Active { get; set; }

		/// <summary>
		/// Gets or sets the height of the object.
		/// </summary>
		/// <value>
		/// The height.
		/// </value>
		public float Height { get; set; }

		/// <summary>
		/// Gets or sets the inertia.
		/// </summary>
		/// <value>
		/// The inertia.
		/// </value>
		public float Inertia { get; set; }

		/// <summary>
		/// Gets or sets the position of the object.
		/// </summary>
		/// <value>
		/// The position.
		/// </value>
		public Vector2 Position { get; set; }

		/// <summary>
		/// Gets or sets the speed.
		/// </summary>
		/// <value>
		/// The speed.
		/// </value>
		public float Speed { get; set; }

		/// <summary>
		/// Gets or sets the texture.
		/// </summary>
		/// <value>
		/// The texture.
		/// </value>
		public Texture2D Texture { get; set; }

		/// <summary>
		/// Gets or sets the velocity.
		/// </summary>
		/// <value>
		/// The velocity.
		/// </value>
		public Vector2 Velocity { get; set; }

		/// <summary>
		/// Gets or sets the width of the object.
		/// </summary>
		/// <value>
		/// The width.
		/// </value>
		public float Width { get; set; }

		/// <summary>
		/// Draws the object.
		/// </summary>
		/// <param name="sb">The sb.</param>
		/// <param name="delta">The delta.</param>
		/// <exception cref="NotImplementedException"></exception>
		public virtual void Draw(SpriteBatch sb, float delta)
		{
			sb.Draw(this.Texture, this.Position, null, null, Vector2.One / 2f, 0, Vector2.One * 2, Color.White, SpriteEffects.None, 0);
		}

		/// <summary>
		/// Move by specified delta.
		/// </summary>
		/// <param name="xDelta">The x delta.</param>
		/// <param name="yDelta">The y delta.</param>
		/// <exception cref="NotImplementedException"></exception>
		public void Move(float xDelta, float yDelta)
		{
			this.Position += new Vector2(xDelta, yDelta);
		}

		/// <summary>
		/// Moves to given position. This will move object to destination over time, not in one frame.
		/// </summary>
		/// <param name="x">The x.</param>
		/// <param name="y">The y.</param>
		/// <exception cref="NotImplementedException"></exception>
		public void MoveTo(float x, float y)
		{
			this.destination = new Vector2(x, y);
		}

		/// <summary>
		/// Sets the position.
		/// </summary>
		/// <param name="x">The x.</param>
		/// <param name="y">The y.</param>
		public void SetPosition(float x, float y)
		{
			this.Position = new Vector2(x, y);
		}

		/// <summary>
		/// Updates the object.
		/// </summary>
		/// <param name="delta">The delta.</param>
		/// <exception cref="NotImplementedException"></exception>
		public virtual void Update(float delta)
		{
			// Move toward position
			if (this.destination != null)
			{
				var direction = DetermineDirection(this.destination.Value);
				var speed = ApplySpeed(direction);
				var newVelocity = this.Velocity + speed;

				this.Velocity = this.ClipVelocity(newVelocity);
			}
		}

		/// <summary>
		/// Clips the velocity.
		/// </summary>
		/// <param name="velocity">The velocity.</param>
		/// <returns></returns>
		protected Vector2 ClipVelocity(Vector2 velocity)
		{
			return new Vector2(
				MathHelper.Clamp(velocity.X, -this.Speed, this.Speed),
				MathHelper.Clamp(velocity.Y, -this.Speed, this.Speed));
		}

		/// <summary>
		/// Applies the speed.
		/// </summary>
		/// <param name="direction">The direction.</param>
		/// <returns></returns>
		protected Vector2 ApplySpeed(Vector2 direction)
		{
			return direction*this.Speed*(1f/this.Inertia);
		}

		/// <summary>
		/// Determines the direction.
		/// </summary>
		/// <param name="destination">The destination.</param>
		/// <returns></returns>
		protected Vector2 DetermineDirection(Vector2 destination)
		{
			return destination - this.Position;
		}

		/// <summary>
		/// Determines whether object is at the specified position.
		/// </summary>
		/// <param name="x">The x.</param>
		/// <param name="y">The y.</param>
		/// <returns></returns>
		protected bool IsAtPosition(float x, float y)
		{
			return this.IsAtPosition(new Vector2(x, y));
		}

		/// <summary>
		/// Determines whether object is at the specified position.
		/// </summary>
		/// <param name="x">The x.</param>
		/// <param name="y">The y.</param>
		/// <returns></returns>
		protected bool IsAtPosition(Vector2 destination)
		{
			var delta = this.Position - destination;
			return Math.Abs(delta.X) < 0.1f && Math.Abs(delta.Y) < 0.1f;
		}


        #region IDisposable Support

        private bool disposedValue = false;

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				if (disposing)
				{
				}
				
				disposedValue = true;
			}
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
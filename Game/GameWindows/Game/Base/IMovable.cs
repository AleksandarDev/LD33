using Microsoft.Xna.Framework;

namespace GameWindows.Game.Base
{
	internal interface IMovable : IObject
	{
		/// <summary>
		/// Gets or sets the speed.
		/// </summary>
		/// <value>
		/// The speed.
		/// </value>
		float Speed { get; set; }

		/// <summary>
		/// Gets or sets the inertia.
		/// </summary>
		/// <value>
		/// The inertia.
		/// </value>
		float Inertia { get; set; }

		/// <summary>
		/// Gets or sets the velocity.
		/// </summary>
		/// <value>
		/// The velocity.
		/// </value>
		Vector2 Velocity { get; set; }

		/// <summary>
		/// Move by specified delta.
		/// </summary>
		/// <param name="xDelta">The x delta.</param>
		/// <param name="yDelta">The y delta.</param>
		void Move(float xDelta, float yDelta);

		/// <summary>
		/// Moves to given position. This will move object to destination over time, not in one frame.
		/// </summary>
		/// <param name="x">The x.</param>
		/// <param name="y">The y.</param>
		void MoveTo(float x, float y);

		/// <summary>
		/// Sets the position.
		/// </summary>
		/// <param name="x">The x.</param>
		/// <param name="y">The y.</param>
		void SetPosition(float x, float y);
	}
}
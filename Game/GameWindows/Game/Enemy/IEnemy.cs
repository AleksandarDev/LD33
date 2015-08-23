using GameWindows.Game.Base;
using Microsoft.Xna.Framework.Graphics;

namespace GameWindows.Game.Enemy
{
	internal interface IEnemy : ICreature
	{
	}

	public class Enemy : Creature
	{
		public Enemy(Texture2D texture)
		{
			this.Texture = texture;
		}
	}
}
using GameWindows.Game.Base;
using GameWindows.Game.Player;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GameWindows
{
    
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class GameStart : Microsoft.Xna.Framework.Game
	{
		GraphicsDeviceManager graphics;
		SpriteBatch spriteBatch;
        Player player;
        HpBar playerhp;

        /// <summary>
        /// Initializes a new instance of the <see cref="GameStart"/> class.
        /// </summary>
        public GameStart()
		{
			graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";

	        IsMouseVisible = true;
		}

		/// <summary>
		/// Allows the game to perform any initialization it needs to before starting to run.
		/// This is where it can query for any required services and load any non-graphic
		/// related content.  Calling base.Initialize will enumerate through any components
		/// and initialize them as well.
		/// </summary>
		protected override void Initialize()
		{
			base.Initialize();
		}

		/// <summary>
		/// LoadContent will be called once per game and is the place to load
		/// all of your content.
		/// </summary>
		protected override void LoadContent()
		{
			// Create a new SpriteBatch, which can be used to draw textures.
			spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            Vector2 playerposition = new Vector2(0, GraphicsDevice.Viewport.Height / 2);

            this.player = new Player(Content.Load<Texture2D>("Textures\\Player"), playerposition);

            playerhp = new HpBar(Content.Load<Texture2D>("Textures\\HealthBar"));
            
                            
		}

		/// <summary>
		/// UnloadContent will be called once per game and is the place to unload
		/// game-specific content.
		/// </summary>
		protected override void UnloadContent()
		{
			// TODO: Unload any non ContentManager content here
		}

		/// <summary>
		/// Allows the game to run logic such as updating the world,
		/// checking for collisions, gathering input, and playing audio.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Update(GameTime gameTime)
		{
            GamePadState gamePadState = GamePad.GetState(PlayerIndex.One);

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            if (gamePadState.Buttons.X == ButtonState.Pressed) 
            {
                
            }

            this.player.Position += new Vector2(gamePadState.ThumbSticks.Left.X *3 , -gamePadState.ThumbSticks.Left.Y *3);

            if (Keyboard.GetState().IsKeyDown(Keys.A))
                this.player.Position += new Vector2(-3, 0);

            if (Keyboard.GetState().IsKeyDown(Keys.D))
                this.player.Position += new Vector2(3, 0);

            if (Keyboard.GetState().IsKeyDown(Keys.W))
                this.player.Position += new Vector2(0, -3);

            if (Keyboard.GetState().IsKeyDown(Keys.S))
                this.player.Position += new Vector2(0, 3);

            this.playerhp.SetHealth(this.player.Health);

            this.playerhp.Position = new Vector2(this.player.Position.X -10, this.player.Position.Y -20);
            
            

			MouseState state = Mouse.GetState();
			this.player.RotateTo(new Vector2(state.X, state.Y));


            // TODO: Add your update logic here

            base.Update(gameTime);
		}

		/// <summary>
		/// This is called when the game should draw itself.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.Purple);

            // TODO: Add your drawing code here

            spriteBatch.Begin();

            playerhp.Draw(spriteBatch, (float)gameTime.ElapsedGameTime.TotalMilliseconds);

            this.player.Draw(spriteBatch, (float)gameTime.ElapsedGameTime.TotalMilliseconds);

            spriteBatch.End();




			base.Draw(gameTime);
		}
	}
}

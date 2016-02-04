using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MovingManTe15
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        MovingObject player;

//        Texture2D sprite; //Deklarerar ett objekt av typ Texture2D.
                          //OBS: Skapar inte objektet.

        int speed = 5;
//        Vector2 position, velocity;      
  
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            player = new MovingObject();
            player.position = new Vector2(50, 200);
            player.velocity = new Vector2(1, 0.5f);

//            position = new Vector2(50, 200); Behövs inte eftersom player har en "inbyggd" position
//            velocity = new Vector2(1, 0.5f);

            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            player.sprite = Content.Load<Texture2D>("giana");
//            sprite = Content.Load<Texture2D>("giana");
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
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
            KeyboardState pressedKeys = Keyboard.GetState();

            if (pressedKeys.IsKeyDown(Keys.LeftShift) || pressedKeys.IsKeyDown(Keys.RightShift))
                speed = 50;
            else
                speed = 5;

            if (pressedKeys.IsKeyDown(Keys.W))
            {
                player.velocity.Y = -speed;
            }
            else if (pressedKeys.IsKeyDown(Keys.S))
            {
                player.velocity.Y = speed;
            }
            else
            {
                player.velocity.Y = 0;
            }


            //            position.X += velocity.X;
            //            position.Y += velocity.Y;

            player.Update();

            //player.position += player.velocity;

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            spriteBatch.Draw(player.sprite, player.position, Color.White);
            spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}

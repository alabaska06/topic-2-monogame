using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace topic_2_monogame
{
    public class Game1 : Game
    {
        Texture2D rectangleTexture;
        Texture2D circleTexture;

        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            _graphics.PreferredBackBufferWidth = 800; 
            _graphics.PreferredBackBufferHeight = 500;
            _graphics.ApplyChanges();

            this.Window.Title = "Scaled Images";
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            rectangleTexture = Content.Load<Texture2D>("rectangle");
            circleTexture = Content.Load<Texture2D>("circle");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.DarkOliveGreen);

            _spriteBatch.Begin();
            _spriteBatch.Draw(rectangleTexture, new Rectangle(0, 0, 800, 400), Color.DarkBlue);
            _spriteBatch.Draw(circleTexture, new Rectangle(600, 40, 150, 150), Color.WhiteSmoke);
            _spriteBatch.Draw(circleTexture, new Rectangle(560, 60, 150, 150), Color.DarkBlue);
            _spriteBatch.Draw(circleTexture, new Rectangle(300, 250, 30, 30), Color.Goldenrod);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(310, 330, 10, 80), Color.DarkGreen);
            _spriteBatch.Draw(circleTexture, new Rectangle(300, 190, 30, 60), Color.DarkViolet);
            _spriteBatch.Draw(circleTexture, new Rectangle(300, 280, 30, 60), Color.DarkViolet);
            _spriteBatch.Draw(circleTexture, new Rectangle(240, 250, 60, 30), Color.DarkViolet);
            _spriteBatch.Draw(circleTexture, new Rectangle(330, 250, 60, 30), Color.DarkViolet);
            _spriteBatch.Draw(circleTexture, new Rectangle(240, 250, 60, 30), Color.DarkViolet);
            _spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
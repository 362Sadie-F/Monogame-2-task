using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_2_task
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D circleTexture;
        Texture2D recTexture;
        Rectangle window;
        Rectangle waterRind;
        Rectangle waterSkin;
        Rectangle waterMelon;
        Rectangle waterSeed1;
        Rectangle waterSeed2;
        Rectangle waterSeed3;
        Rectangle waterSeed4;
        Rectangle waterSeed5;
        SpriteFont asciiArt;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            window = new Rectangle(0,0,800,600);
            _graphics.PreferredBackBufferWidth = window.Width;
            _graphics.PreferredBackBufferHeight = window.Height;
            _graphics.ApplyChanges();
            
            waterSkin = new Rectangle(0,0,window.Width,40);
            waterMelon = new Rectangle(0,0,window.Width, window.Height);
            waterRind = new Rectangle(0,30,window.Width,30);
            waterSeed1 = new Rectangle(50, 80, 75, 110); //top left corner
            waterSeed2 = new Rectangle(360, 80, 75, 110); //top middle
            waterSeed3 = new Rectangle(370, 480, 75, 110); //bottom middle
            waterSeed4 = new Rectangle(380, 170, 75, 110);
            waterSeed5 = new Rectangle(698, 80, 75, 110); //top right corner
            


            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            circleTexture = Content.Load<Texture2D>("circle");
            recTexture = Content.Load<Texture2D>("rectangle");
            asciiArt = Content.Load<SpriteFont>("TextFont");

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
            GraphicsDevice.Clear(Color.LavenderBlush);
            _spriteBatch.Begin();
            _spriteBatch.Draw(recTexture, waterMelon, Color.IndianRed);
            _spriteBatch.Draw(recTexture, waterRind, Color.NavajoWhite);
            _spriteBatch.Draw(recTexture, waterSkin, Color.DarkGreen);
            _spriteBatch.Draw(circleTexture, waterSeed1, Color.Black);
            _spriteBatch.Draw(circleTexture, waterSeed2, Color.Black);
            _spriteBatch.Draw(circleTexture, waterSeed3, Color.Black);
            _spriteBatch.Draw(circleTexture, waterSeed4, Color.Black);
            _spriteBatch.Draw(circleTexture, waterSeed5, Color.Black);
            _spriteBatch.DrawString(asciiArt, " /\\_/\\\r\n( o.o )\r\n > ^ <", new Vector2(300,150), Color.Azure);

            _spriteBatch.End();
            

            base.Draw(gameTime);
        }
    }
}

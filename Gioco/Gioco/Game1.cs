using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Gioco
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager _graphics;
        SpriteBatch _spriteBatch;
        public const int WindowWidth = 1366;
        public const int WindowsHeight = 768;

        private SpriteFont _font;

        private Dictionary<uint, Texture2D> _textureDataBase;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this)
            {
                PreferredBackBufferWidth = WindowWidth,
                PreferredBackBufferHeight = WindowsHeight,
                // IsFullScreen = true    
            };
            
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
            // TODO: Add your initialization logic here
            // Carico avventure
                // Carico mappa
                    // Parso elenco espansioni
            // Carico conseguenti cose
            // Carico mostri e png
            
            _textureDataBase = new Dictionary<uint, Texture2D>();
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // _textureDataBase.Add(1, Content.Load<Texture2D>(@"immagine"));

            // _font = Content.Load<SpriteFont>("Font\\fontCreato");

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
            // Controllo GamePad
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed) Exit(); 
            
            // Controllo KeyBoard
            if (Keyboard.GetState().IsKeyDown(Keys.Escape)) Exit();

            var mouse = Mouse.GetState();
            if (mouse.LeftButton == ButtonState.Pressed) { }
            



            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(new Color(0, 0, 0));
            _spriteBatch.Begin();

            // Disegna texture sullo schermo
            // _spriteBatch.Draw(_textureDataBase[1], new Vector2(10, 10), Color.White);

            // Scrive del testo
            // _spriteBatch.DrawString(_font, "Hello World", new Vector2(5, 5), new Color(255, 255, 255));
            
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}

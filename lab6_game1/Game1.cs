using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace lab6_game1
{
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D ballTexture;
        Texture2D charTexture;
        Vector2 charPosition = new Vector2(0, 250);
        Vector2 ballPosition = new Vector2(250, 250);
        Random r = new Random();
        private AnimatedTexture SpriteTexture;

        // Ball Array
        Vector2[] BallPosition = new Vector2[4];
        int[] BallColor = new int[4];

        private const float Rotation = 0;
        private const float Scale = 1.0f;
        private const float Depth = 0.5f;

        private const int Frames = 4;
        private const int FramesPerSec = 15;
        private const int FramesRow = 4;
        int FrameToRun = 1;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            SpriteTexture = new AnimatedTexture(Vector2.Zero, Rotation, Scale, Depth);

            Content.RootDirectory = "Content";
        }
        protected override void Initialize()
        {
            base.Initialize();
        }
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            SpriteTexture.Load(Content, "Char01", Frames, FramesRow, FramesPerSec);
            ballTexture = Content.Load<Texture2D>("ball");

            for (int i = 0; i < BallPosition.Length; i++)
            {
                BallPosition[i] = new Vector2(r.Next(0, 500), r.Next(100, 350));
                BallColor[i] = r.Next(0,3);
            }

        }
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }
    }
}

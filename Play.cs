using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NourishMeant
{
    public class Play : GameState
    {
        Texture2D background2;
        Texture2D fridge;
        SpriteFont font;
        Texture2D mySprite;
        public Play(GraphicsDevice graphicsDevice) :base(graphicsDevice)
        {
          
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            _graphicsDevice.Clear(Color.White);
            spriteBatch.Begin();

            // Draw sprites here
            //spriteBatch.Draw(background2, new Vector2(150, 150), Color.White);
            spriteBatch.DrawString(font, "Choose your ingredients", new Vector2(200, 600), Color.Black,0, new Vector2(0,0), 7.0f, SpriteEffects.None, 0.0f);
            //spriteBatch.Draw(fridge, new Vector2(300, 500), new Rectangle(10, 60, 40, 40), Color.White, 0.0f, new Vector2(0, 0), new Vector2(500, 700),  SpriteEffects.None, 0.0f);
            spriteBatch.Draw(fridge, new Vector2(0, 60), Color.White);

            spriteBatch.End();
        }

        public override void Initialize()
        {
            
        }

        public override void LoadContent(ContentManager content)
        {
            content.RootDirectory = "Content";
            background2 = content.Load<Texture2D>("1f");
            font = content.Load<SpriteFont>("Font");
            fridge = content.Load<Texture2D>("openfridge1");
            
        }

        public override void UnloadContent()
        {
          
        }

        public override void Update(GameTime gameTime)
        {
            
        }
    }
}
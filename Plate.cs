using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NourishMeant
{
    class Plate : GameState
    {
        SpriteFont font;
        Texture2D plate;
        public Plate(GraphicsDevice graphicsDevice) : base(graphicsDevice)
        {
            


        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            _graphicsDevice.Clear(Color.White);


            spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.AlphaBlend);
            spriteBatch.DrawString(font, "Here's your plate!", new Vector2(125, 200), Color.Black, 0, new Vector2(0, 0), 4.5f, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(plate, new Vector2(200, 650), Color.White);
            spriteBatch.End();
        }

        public override void Initialize()
        {
            
        }

        public override void LoadContent(ContentManager content)
        {
            content.RootDirectory = "Content";
            font = content.Load<SpriteFont>("Font");
            plate = content.Load<Texture2D>("pixelplate");
        }

        public override void UnloadContent()
        {
            
        }

        public override void Update(GameTime gameTime)
        {
            
        }
    }
}
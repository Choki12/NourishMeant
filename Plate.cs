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
        public string[] selectedFood;
       


        public Plate(GraphicsDevice graphicsDevice) : base(graphicsDevice)
        {
            
            
            

        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            _graphicsDevice.Clear(Color.White);


            spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.AlphaBlend);
            spriteBatch.DrawString(font, "Your plate is ready!", new Vector2(160, 200), Color.Black, 0, new Vector2(0, 0), 4.5f, SpriteEffects.None, 0.0f);
            spriteBatch.DrawString(font, "Here are the foods you selected:", new Vector2(160, 365), Color.Purple, 0, new Vector2(0, 0), 2.5f, SpriteEffects.None, 0.0f);
            
            /*for (int i = 0; i < 3; i++)
            {
                spriteBatch.DrawString(font, selectedFood[i], new Vector2(160, 260), Color.Black, 0, new Vector2(0, 0), 4.5f, SpriteEffects.None, 0.0f);
            }*/
            
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
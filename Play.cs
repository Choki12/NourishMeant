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
        Texture2D fruit;
        
        public Play(GraphicsDevice graphicsDevice) :base(graphicsDevice)
        {
          
        }

        /*Written by Boitshoko Tumane*/
        public override void Draw(SpriteBatch spriteBatch)
        {
            _graphicsDevice.Clear(Color.White);
            spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.AlphaBlend);

            // Draw sprites here
            //spriteBatch.Draw(background2, new Vector2(150, 150), Color.White);
            spriteBatch.DrawString(font, "Choose your ingredients", new Vector2(200, 200), Color.Black,0, new Vector2(0,0), 4.0f, SpriteEffects.None, 0.0f);
            //spriteBatch.Draw()
            //spriteBatch.Draw(fridge, new Vector2(300, 500), new Rectangle(10, 60, 40, 40), Color.White, 0.0f, new Vector2(0, 0), new Vector2(500, 700),  SpriteEffects.None, 0.0f);
            spriteBatch.Draw(fridge, new Vector2(0, 400), Color.White);
            for (int y  = 0; y < 400; y++)
            {
                for(int x = 0; x < 50; x++)
                {
                 
                    spriteBatch.Draw(fruit, new Vector2(350, 850), Color.White); // 1st row clamp @ y = 850
                    
                }
            }
            
            

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
            fridge = content.Load<Texture2D>("openfridge3");
            fruit = content.Load<Texture2D>("CharactersBright_Line1");
           

        }

        public override void UnloadContent()
        {
          
        }

        public override void Update(GameTime gameTime)
        {
            
        }
    }
}
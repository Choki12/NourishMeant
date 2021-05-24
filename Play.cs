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
    public class Play : GameState
    {
        Texture2D background2;
        Texture2D fridge;
        SpriteFont font;
        Texture2D mySprite;

        /*Sprite definitions*/

        /*1st row*/
        Texture2D fruit;
        Texture2D food1;
        Texture2D food2;
        Texture2D food3;


        /*2nd row*/
        Texture2D food4;
        Texture2D food5;
        Texture2D food6;
        Texture2D food7;

        /*3rd row*/
        Texture2D food8;
        Texture2D food9;
        Texture2D food10;
        Texture2D food11;

        /*4th row*/
        Texture2D food12;
        Texture2D food13;
        Texture2D food14;
        Texture2D food15;


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
            spriteBatch.DrawString(font, "Welcome to NourishMeant!", new Vector2(125, 200), Color.Black,0, new Vector2(0,0), 4.5f, SpriteEffects.None, 0.0f);
            spriteBatch.DrawString(font, "Start by choosing 3 ingridients from the fridge", new Vector2(40, 350), Color.Green, 0, new Vector2(0, 0), 3.0f, SpriteEffects.None, 0.0f);
            //spriteBatch.Draw()
            //spriteBatch.Draw(fridge, new Vector2(300, 500), new Rectangle(10, 60, 40, 40), Color.White, 0.0f, new Vector2(0, 0), new Vector2(500, 700),  SpriteEffects.None, 0.0f);
            spriteBatch.Draw(fridge, new Vector2(0, 400), Color.White);
            for (int y  = 0; y < 400; y++)
            {
                for(int x = 0; x < 50; x++)
                {
                    spriteBatch.Draw(fruit, new Vector2(350, 850), null, Color.White, 0f, Vector2.Zero, 3.5f, SpriteEffects.None, 0f);//spriteBatch.Draw(fruit, new Vector2(350, 850), Color.White); // 1st row clamp @ y = 850
                    spriteBatch.Draw(food1, new Vector2(430, 850), null, Color.White, 0f, Vector2.Zero, 3.5f, SpriteEffects.None, 0f);
                    spriteBatch.Draw(food2, new Vector2(510, 850), null, Color.White, 0f, Vector2.Zero, 3.5f, SpriteEffects.None, 0f);
                    spriteBatch.Draw(food3, new Vector2(590, 850), null, Color.White, 0f, Vector2.Zero, 3.5f, SpriteEffects.None, 0f);
                    
                    spriteBatch.Draw(food4, new Vector2(350, 1050), null, Color.White, 0f, Vector2.Zero, 3.5f, SpriteEffects.None, 0f);//spriteBatch.Draw(fruit, new Vector2(350, 850), Color.White); // 2nd row clamp @ y = 950
                    spriteBatch.Draw(food5, new Vector2(430, 1050), null, Color.White, 0f, Vector2.Zero, 3.5f, SpriteEffects.None, 0f);
                    spriteBatch.Draw(food6, new Vector2(510, 1050), null, Color.White, 0f, Vector2.Zero, 3.5f, SpriteEffects.None, 0f);
                    spriteBatch.Draw(food7, new Vector2(590, 1050), null, Color.White, 0f, Vector2.Zero, 3.5f, SpriteEffects.None, 0f);

                    spriteBatch.Draw(food8, new Vector2(350, 1300), null, Color.White, 0f, Vector2.Zero, 3.5f, SpriteEffects.None, 0f);//spriteBatch.Draw(fruit, new Vector2(350, 850), Color.White); // 2nd row clamp @ y = 950
                    spriteBatch.Draw(food9, new Vector2(430, 1300), null, Color.White, 0f, Vector2.Zero, 3.5f, SpriteEffects.None, 0f);
                    spriteBatch.Draw(food10, new Vector2(510, 1300), null, Color.White, 0f, Vector2.Zero, 3.5f, SpriteEffects.None, 0f);
                    spriteBatch.Draw(food11, new Vector2(590, 1300), null, Color.White, 0f, Vector2.Zero, 3.5f, SpriteEffects.None, 0f);

                    spriteBatch.Draw(food12, new Vector2(350, 1500), null, Color.White, 0f, Vector2.Zero, 3.5f, SpriteEffects.None, 0f);//spriteBatch.Draw(fruit, new Vector2(350, 850), Color.White); // 2nd row clamp @ y = 950
                    spriteBatch.Draw(food13, new Vector2(430, 1500), null, Color.White, 0f, Vector2.Zero, 3.5f, SpriteEffects.None, 0f);
                    spriteBatch.Draw(food14, new Vector2(510, 1500), null, Color.White, 0f, Vector2.Zero, 3.5f, SpriteEffects.None, 0f);
                    spriteBatch.Draw(food15, new Vector2(590, 1500), null, Color.White, 0f, Vector2.Zero, 3.5f, SpriteEffects.None, 0f);


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
            
            /*Written by Boitshoko Tumane*/

            /*1st row*/
            fruit = content.Load<Texture2D>("yp_apple");
            food1 = content.Load<Texture2D>("yp_bananas");
            food2 = content.Load<Texture2D>("yp_beet");
            food3 = content.Load<Texture2D>("yp_avocado");

            /*2nd row */
            food4 = content.Load<Texture2D>("yp_bellpepper");
            food5 = content.Load<Texture2D>("yp_broccoli");
            food6 = content.Load<Texture2D>("yp_canteloupe");
            food7 = content.Load<Texture2D>("yp_chilipepper");

            /*3rd row*/
            food8 = content.Load<Texture2D>("yp_eggplant");
            food9 = content.Load<Texture2D>("yp_fries");
            food10 = content.Load<Texture2D>("yp_grapes");
            food11 = content.Load<Texture2D>("yp_dragonfruit");

            /*4th row*/
            food12 = content.Load<Texture2D>("yp_ham");
            food13 = content.Load<Texture2D>("yp_kiwi");
            food14 = content.Load<Texture2D>("yp_jalapeno");
            food15 = content.Load<Texture2D>("yp_orange");


        }

        public override void UnloadContent()
        {
          
        }

        public override void Update(GameTime gameTime)
        {
            
        }
    }
}
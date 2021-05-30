﻿using Android.App;
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
using InputHelper;
using SharpDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TouchScreenBuddy;

namespace NourishMeant
{
    public class Play : GameState
    {
        bool _firstUpdate;
        Texture2D background2;
        Texture2D fridge;
        SpriteFont font;
        Texture2D mySprite;
        GraphicsDeviceManager graphics;
        float alpha = 3;
        int counter = 0; //Manage user selections for changing screens
        bool isDrawn = false;
        
        //private List<Sprite> sprites = new List<Sprite>();
        //private Sprite selectedSprite;

        /*Written by Boitshoko Tumane*/

        /*Input*/
        bool isTouchedfruit;
        bool isTouchedfood1;
        bool isTouchedfood2;
        bool isTouchedfood3;

        bool isTouchedfood4;
        bool isTouchedfood5;
        bool isTouchedfood6;
        bool isTouchedfood7;

        bool isTouchedfood8;
        bool isTouchedfood9;
        bool isTouchedfood10;
        bool isTouchedfood11;

        bool isTouchedfood12;
        bool isTouchedfood13;
        bool isTouchedfood14;
        bool isTouchedfood15;

        bool isTouchedNext; //check if the next button was clicked

        //private List<Sprite> mySprites = new List<Sprite>(); 
        //private Sprite chosenSprite; 

        /*Written by Boitshoko Tumane*/

        /*Sprite definitions*/

        /*1st row*/
        Texture2D fruit; //r
        Texture2D food1; //r1
        Texture2D food2; //r2
        Texture2D food3; //r3


        /*2nd row*/
        Texture2D food4; //r4
        Texture2D food5; //r5
        Texture2D food6; //r6
        Texture2D food7; //r7

        /*3rd row*/
        Texture2D food8; //r8
        Texture2D food9; //r9
        Texture2D food10;//r10
        Texture2D food11;//r11

        /*4th row*/
        Texture2D food12;//r12
        Texture2D food13;//r13
        Texture2D food14;//r14
        Texture2D food15;//r15

        Texture2D hide;

        Texture2D btnNext;

        /*Written by Boitshoko Tumane*/
        /*Rectangles*/
        /*1st row*/
        Vector2 v = new Vector2(350, 850);
        Vector2 v1 = new Vector2(450, 850);
        Vector2 v2 = new Vector2(530, 850);
        Vector2 v3 = new Vector2(620, 850);

        /*2nd row*/
        Vector2 v4 = new Vector2(350, 1050);
        Vector2 v5 = new Vector2(430, 1050);
        Vector2 v6 = new Vector2(510, 1050);
        Vector2 v7 = new Vector2(590, 1050);

        /*3rd row*/
        Vector2 v8 = new Vector2(350, 1300);
        Vector2 v9 = new Vector2(430, 1300);
        Vector2 v10 = new Vector2(510, 1300);
        Vector2 v11 = new Vector2(590, 1300);

        /*4th row*/
        Vector2 v12 = new Vector2(350, 1500);
        Vector2 v13 = new Vector2(430, 1500);
        Vector2 v14 = new Vector2(510, 1500);
        Vector2 v15 = new Vector2(590, 1500);

        Rectangle r = new Rectangle(360, 850, 50, 50);
        Rectangle r1 = new Rectangle(450, 850, 50, 50);
        Rectangle r2 = new Rectangle(530, 850, 50, 50);
        Rectangle r3 = new Rectangle(620, 850, 50, 50);

        /*2nd row*/
        Rectangle r4 = new Rectangle(350, 1050, 50, 50);
        Rectangle r5 = new Rectangle(430, 1050, 50, 50);
        Rectangle r6 = new Rectangle(510, 1050, 50, 50);
        Rectangle r7 = new Rectangle(590, 1050, 50, 50);

        /*3rd row*/
        Rectangle r8 = new Rectangle(350, 1300, 50, 50);
        Rectangle r9 = new Rectangle(430, 1300, 50, 50);
        Rectangle r10 = new Rectangle(510, 1300, 50, 50);
        Rectangle r11 = new Rectangle(590, 1300, 50, 50);

        /*4th row*/
        Rectangle r12 = new Rectangle(350, 1500, 50, 50);
        Rectangle r13 = new Rectangle(430, 1500, 50, 50);
        Rectangle r14 = new Rectangle(510, 1500, 50, 50);
        Rectangle r15 = new Rectangle(590, 1500, 50, 50);

        
        Rectangle rbtnNext = new Rectangle(430, 2050, 270, 80);







        public Play(GraphicsDevice graphicsDevice) :base(graphicsDevice)
        {
            TouchPanel.GetCapabilities();

            TouchPanel.EnabledGestures = GestureType.Tap | GestureType.DoubleTap | GestureType.Hold | GestureType.Pinch |
                            GestureType.FreeDrag | GestureType.DragComplete | GestureType.Flick | GestureType.HorizontalDrag |
                            GestureType.VerticalDrag;

            
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
            //for (int y  = 0; y < 400; y++)
            //{
               // for(int x = 0; x < 50; x++)
                //{
                    
            for (int i = 0; i < 16; i++) { 
                    spriteBatch.Draw(fruit, r, null, Color.White, 0f, Vector2.Zero, SpriteEffects.None, 0f);//spriteBatch.Draw(fruit, new Vector2(350, 850), Color.White); // 1st row clamp @ y = 850
                    if (isTouchedfruit == true)
                    { spriteBatch.Draw(hide, r, null, Color.Green * 15.9f, 0f, Vector2.Zero, SpriteEffects.None, 0f);
                      spriteBatch.DrawString(font, "\nItem: Apple", new Vector2(40, 390), Color.Black, 0, new Vector2(0, 0), 2.0f, SpriteEffects.None, 0.0f);
                    }
                   


                    spriteBatch.Draw(food1, r1, null, Color.White, 0f, Vector2.Zero, SpriteEffects.None, 0f);
                    if (isTouchedfood1 == true)
                    {
                        spriteBatch.Draw(hide, r1, null, Color.Green * 15.9f, 0f, Vector2.Zero, SpriteEffects.None, 0f);
                        spriteBatch.DrawString(font, "\nItem: Banana", new Vector2(40, 390), Color.Black, 0, new Vector2(0, 0), 2.0f, SpriteEffects.None, 0.0f);
                    }

                    spriteBatch.Draw(food2, r2, null, Color.White, 0f, Vector2.Zero,  SpriteEffects.None, 0f);
                    if (isTouchedfood2 == true)
                    {
                        spriteBatch.Draw(hide, r2, null, Color.Green * 15.9f, 0f, Vector2.Zero, SpriteEffects.None, 0f);
                        spriteBatch.DrawString(font, "\nItem: Beetroot", new Vector2(40, 390), Color.Black, 0, new Vector2(0, 0), 2.0f, SpriteEffects.None, 0.0f);
                    }

                    spriteBatch.Draw(food3, r3, null, Color.White, 0f, Vector2.Zero, SpriteEffects.None, 0f);
                    if (isTouchedfood3 == true)
                    {
                        spriteBatch.Draw(hide, r3, null, Color.Green * 15.9f, 0f, Vector2.Zero, SpriteEffects.None, 0f);
                        spriteBatch.DrawString(font, "\nItem: Avocado", new Vector2(40, 390), Color.Black, 0, new Vector2(0, 0), 2.0f, SpriteEffects.None, 0.0f);
                    }


                    spriteBatch.Draw(food4, r4, null, Color.White, 0f, Vector2.Zero,  SpriteEffects.None, 0f);//spriteBatch.Draw(fruit, new Vector2(350, 850), Color.White); // 2nd row clamp @ y = 950
                    if (isTouchedfood4 == true)
                    {
                        spriteBatch.Draw(hide, r4, null, Color.Green * 15.9f, 0f, Vector2.Zero, SpriteEffects.None, 0f);
                        spriteBatch.DrawString(font, "\nItem: Bellpepper", new Vector2(40, 390), Color.Black, 0, new Vector2(0, 0), 2.0f, SpriteEffects.None, 0.0f);
                    }

                    spriteBatch.Draw(food5, r5, null, Color.White, 0f, Vector2.Zero,  SpriteEffects.None, 0f);
                    if (isTouchedfood5 == true)
                    {
                        spriteBatch.Draw(hide, r5, null, Color.Green * 15.9f, 0f, Vector2.Zero, SpriteEffects.None, 0f);
                        spriteBatch.DrawString(font, "\nItem: Brocolli", new Vector2(40, 390), Color.Black, 0, new Vector2(0, 0), 2.0f, SpriteEffects.None, 0.0f);
                    }

                    spriteBatch.Draw(food6, r6, null, Color.White, 0f, Vector2.Zero, SpriteEffects.None, 0f);
                    if (isTouchedfood6 == true)
                    {
                        spriteBatch.Draw(hide, r6, null, Color.Green * 15.9f, 0f, Vector2.Zero, SpriteEffects.None, 0f);
                        spriteBatch.DrawString(font, "\nItem: Canteloupe", new Vector2(40, 390), Color.Black, 0, new Vector2(0, 0), 2.0f, SpriteEffects.None, 0.0f);
                    }

                    spriteBatch.Draw(food7, r7, null, Color.White, 0f, Vector2.Zero,  SpriteEffects.None, 0f);
                    if (isTouchedfood7 == true)
                    {
                        spriteBatch.Draw(hide, r7, null, Color.Green * 15.9f, 0f, Vector2.Zero, SpriteEffects.None, 0f);
                        spriteBatch.DrawString(font, "\nItem: Chillipepper", new Vector2(40, 390), Color.Black, 0, new Vector2(0, 0), 2.0f, SpriteEffects.None, 0.0f);
                    }

                    spriteBatch.Draw(food8, r8, null, Color.White, 0f, Vector2.Zero,  SpriteEffects.None, 0f);//spriteBatch.Draw(fruit, new Vector2(350, 850), Color.White); // 2nd row clamp @ y = 950
                    if (isTouchedfood8 == true)
                    {
                        spriteBatch.Draw(hide, r8, null, Color.Green * 15.9f, 0f, Vector2.Zero, SpriteEffects.None, 0f);
                        spriteBatch.DrawString(font, "\nItem: Eggplant", new Vector2(40, 390), Color.Black, 0, new Vector2(0, 0), 2.0f, SpriteEffects.None, 0.0f);
                    }

                    spriteBatch.Draw(food9, r9, null, Color.White, 0f, Vector2.Zero,  SpriteEffects.None, 0f);
                    if (isTouchedfood9 == true)
                    {
                        spriteBatch.Draw(hide, r9, null, Color.Green * 15.9f, 0f, Vector2.Zero, SpriteEffects.None, 0f);
                        spriteBatch.DrawString(font, "\nItem: Fries", new Vector2(40, 390), Color.Black, 0, new Vector2(0, 0), 2.0f, SpriteEffects.None, 0.0f);
                    }
                    spriteBatch.Draw(food10, r10, null, Color.White, 0f, Vector2.Zero, SpriteEffects.None, 0f);
                    if (isTouchedfood10 == true)
                    {
                        spriteBatch.Draw(hide, r10, null, Color.Green * 15.9f, 0f, Vector2.Zero, SpriteEffects.None, 0f);
                        spriteBatch.DrawString(font, "\nItem: Grapes", new Vector2(40, 390), Color.Black, 0, new Vector2(0, 0), 2.0f, SpriteEffects.None, 0.0f);
                    }

                    spriteBatch.Draw(food11, r11, null, Color.White, 0f, Vector2.Zero,  SpriteEffects.None, 0f);
                    if (isTouchedfood11 == true)
                    {
                        spriteBatch.Draw(hide, r11, null, Color.Green * 15.9f, 0f, Vector2.Zero, SpriteEffects.None, 0f);
                        spriteBatch.DrawString(font, "\nItem: Dragon Fruit", new Vector2(40, 390), Color.Black, 0, new Vector2(0, 0), 2.0f, SpriteEffects.None, 0.0f);
                    }

                    spriteBatch.Draw(food12, r12, null, Color.White, 0f, Vector2.Zero,  SpriteEffects.None, 0f);//spriteBatch.Draw(fruit, new Vector2(350, 850), Color.White); // 2nd row clamp @ y = 950
                    if (isTouchedfood12 == true)
                    {
                        spriteBatch.Draw(hide, r12, null, Color.Green * 15.9f, 0f, Vector2.Zero, SpriteEffects.None, 0f);
                        spriteBatch.DrawString(font, "\nItem: Ham", new Vector2(40, 390), Color.Black, 0, new Vector2(0, 0), 2.0f, SpriteEffects.None, 0.0f);
                    }

                    spriteBatch.Draw(food13, r13, null, Color.White, 0f, Vector2.Zero,  SpriteEffects.None, 0f);
                    if (isTouchedfood13 == true)
                    {
                        spriteBatch.Draw(hide, r13, null, Color.Green * 15.9f, 0f, Vector2.Zero, SpriteEffects.None, 0f);
                        spriteBatch.DrawString(font, "\nItem: Kiwi", new Vector2(40, 390), Color.Black, 0, new Vector2(0, 0), 2.0f, SpriteEffects.None, 0.0f);
                    }

                    spriteBatch.Draw(food14, r14, null, Color.White, 0f, Vector2.Zero,  SpriteEffects.None, 0f);
                    if (isTouchedfood14 == true)
                    {
                        spriteBatch.Draw(hide, r14, null, Color.Green * 15.9f, 0f, Vector2.Zero, SpriteEffects.None, 0f);
                        spriteBatch.DrawString(font, "\nItem: Jalapeno", new Vector2(40, 390), Color.Black, 0, new Vector2(0, 0), 2.0f, SpriteEffects.None, 0.0f);
                    }

                    spriteBatch.Draw(food15, r15, null, Color.White, 0f, Vector2.Zero,  SpriteEffects.None, 0f);
                    if (isTouchedfood15 == true)
                    {
                        spriteBatch.Draw(hide, r15, null, Color.Green * 15.9f, 0f, Vector2.Zero, SpriteEffects.None, 0f);
                        spriteBatch.DrawString(font, "\nItem: Orange", new Vector2(40, 390), Color.Black, 0, new Vector2(0, 0), 2.0f, SpriteEffects.None, 0.0f);
                    }

                spriteBatch.DrawString(font, "Number of items taken: ", new Vector2(40, 470), Color.Green, 0, new Vector2(0, 0), 3.0f, SpriteEffects.None, 0.0f);
                spriteBatch.DrawString(font, counter.ToString(), new Vector2(550, 470), Color.Red, 0, new Vector2(0, 0), 3.0f, SpriteEffects.None, 0.0f);


                spriteBatch.Draw(btnNext, rbtnNext, null, Color.White, 0f, Vector2.Zero, SpriteEffects.None, 0f);

                //Game Logic to change screen and check whether 3 items have been selected
                /*Written by Boitshoko Tumane*/

                if((isTouchedNext == true) && (counter == 3))
                {
                
                        spriteBatch.DrawString(font, "You've picked 3 food items! Onto the next page", new Vector2(70, 900), Color.Red, 0, new Vector2(0, 0), 6.0f, SpriteEffects.None, 0.0f);
                        GameStateManager.Instance.AddNewScreen(new Plate(_graphicsDevice));
                    
                }
                
                if ((isTouchedNext == true) && (counter != 3))
                {
                    spriteBatch.DrawString(font, "Please select 3 food items", new Vector2(70, 900), Color.Red, 0, new Vector2(0, 0), 6.0f, SpriteEffects.None, 0.0f);
                }
                
            }
            //}


            spriteBatch.Draw(food15, r15, null, Color.White, 0f, Vector2.Zero, SpriteEffects.None, 0f);

            spriteBatch.End();
        }

        public override void Initialize()
        {
            
        }

        /*Written by Boitshoko Tumane*/
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

            hide = content.Load<Texture2D>("hide");

            btnNext = content.Load<Texture2D>("btnNext");



             GameStateManager.Instance.SetContent(content);
            /*GameStateManager.Instance.SetContent(content);
            GameStateManager.Instance.AddNewScreen(new Plate(base._graphicsDevice));*/


        }

        public override void UnloadContent()
        {
            
        }

        /*Written by Boitshoko Tumane*/
        public override void Update(GameTime gameTime)
        {
        


            if (_firstUpdate)
            {
                typeof(Microsoft.Xna.Framework.Input.Touch.TouchPanel).GetField("_touchScale", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static).SetValue(null, Vector2.One);
                _firstUpdate = false;
            }

            TouchCollection tc = TouchPanel.GetState();
            isTouchedfruit = GetUserInput(r, tc);
            isTouchedfood1 = GetUserInput(r1, tc);
            isTouchedfood2 = GetUserInput(r2, tc);
            isTouchedfood3 = GetUserInput(r3, tc);

            isTouchedfood4 = GetUserInput(r4, tc);
            isTouchedfood5 = GetUserInput(r5, tc);
            isTouchedfood6 = GetUserInput(r6, tc);
            isTouchedfood7 = GetUserInput(r7, tc);

            isTouchedfood8 = GetUserInput(r8, tc);
            isTouchedfood9 = GetUserInput(r9, tc);
            isTouchedfood10 = GetUserInput(r10, tc);
            isTouchedfood11 = GetUserInput(r11, tc);

            isTouchedfood12 = GetUserInput(r12, tc);
            isTouchedfood13 = GetUserInput(r13, tc);
            isTouchedfood14 = GetUserInput(r14, tc);
            isTouchedfood15 = GetUserInput(r15, tc);

            isTouchedNext = isNextButtonTouched(tc);



            while (TouchPanel.IsGestureAvailable)
            {

                GestureSample gesture = TouchPanel.ReadGesture();


                switch (gesture.GestureType)
                {

                    case GestureType.Tap:
                    /*GameStateManager.Instance.UnloadContent();
                    GameStateManager.Instance.SetContent(content);
                    GameStateManager.Instance.AddNewScreen(new Plate(_graphicsDevice));
                    break;*/
                    case GestureType.Pinch:

                        
                        //GameStateManager.Instance.AddNewScreen(new Plate(_graphicsDevice));
                        break;
                }



            }

     


        }

        /*Written by Boitshoko Tumane*/
        private bool GetUserInput(Rectangle rec, TouchCollection tc)
        {

           
            foreach (TouchLocation tl in tc)
            {
             

                //bool spriteTouched = false;
                if (tc.Count > 0 &&  rec.Contains(tl.Position.X, tl.Position.Y) && tl.State == (TouchLocationState.Pressed)) 
                {
                    //spriteTouched = true;
                    isDrawn = true;
                    return true;

                }

                if(tc.Count > 0 && rec.Contains(tl.Position.X, tl.Position.Y) && tl.State == TouchLocationState.Moved)
                {
                    isDrawn = true;
                    return true;
                    
                }

                if(tc.Count > 0 && rec.Contains(tl.Position.X, tl.Position.Y) && tl.State == TouchLocationState.Released)
                {
                    isDrawn = true;
                    counter++;
                    return true;
                }
      
            }
            return false;
        }

        private bool isNextButtonTouched(TouchCollection tc)
        {
            foreach (TouchLocation tl in tc)
            {
                if (tc.Count > 0 && rbtnNext.Contains(tl.Position.X, tl.Position.Y) && tl.State == (TouchLocationState.Pressed) && (counter == 3))
                {
                    //spriteTouched = true;
                    
                    isDrawn = true;
                    return true;

                }

                if (tc.Count > 0 && rbtnNext.Contains(tl.Position.X, tl.Position.Y) && tl.State == (TouchLocationState.Released) && (counter == 3))
                {
                    //spriteTouched = true;
                    
                    isDrawn = true;
                    return true;

                }
            }

            return false;
        }

        private void HandleInput() //override 
        {
           
        }




    }
}
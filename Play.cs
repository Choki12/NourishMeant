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
using InputHelper;
using SharpDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TouchScreenBuddy;

using System.IO;
using System.Threading.Tasks;

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

        enum playerFood
        {
            Apple, Banana, Beetroot, Avocado, Bellpepper, Brocolli, Canteloupe,
            Chillipepper, Eggplant, Fries, Grapes, Dragonfruit, Ham, Kiwi, Jalapeno, Orange
        }
        
        public string [] arrFoodSelected = { "Apple", "Banana", "Beetroot", "Avocado", "Bellpepper", "Brocolli", "Canteloupe",
        "Chillipepper", "Eggplant", "Fries", "Grapes", "Dragonfruit", "Ham", "Kiwi", "Jalapeno", "Orange"};

        string[] playerFoodSelected = {"Apple", "Orange", "Banana"};
        public int index = 0; //index of food selected 

        float alpha = 3;
        int counter = 0; //Manage transition Play class
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
        Rectangle r = new Rectangle(350, 850, 80,80);
        Rectangle r1 = new Rectangle(450, 850, 80, 80);
        Rectangle r2 = new Rectangle(550, 850, 80, 80);
        Rectangle r3 = new Rectangle(640, 850, 80, 80);

        /*2nd row*/
        Rectangle r4 = new Rectangle(350, 1050, 80, 80);
        Rectangle r5 = new Rectangle(450, 1050, 80, 80);
        Rectangle r6 = new Rectangle(530, 1050, 80, 80);
        Rectangle r7 = new Rectangle(640, 1050, 80, 80);

        /*3rd row*/
        Rectangle r8 = new Rectangle(350, 1300, 80, 80);
        Rectangle r9 = new Rectangle(450, 1300, 80, 80);
        Rectangle r10 = new Rectangle(530, 1300, 80, 80);
        Rectangle r11 = new Rectangle(640, 1300, 80, 80);

        /*4th row*/
        Rectangle r12 = new Rectangle(350, 1500, 80, 80);
        Rectangle r13 = new Rectangle(450, 1500, 80, 80);
        Rectangle r14 = new Rectangle(530, 1500, 80, 80);
        Rectangle r15 = new Rectangle(640, 1500, 80, 80);

        
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

            


            spriteBatch.DrawString(font, "Welcome to NourishMeant!", new Vector2(125, 140), Color.Black,0, new Vector2(0,0), 4.5f, SpriteEffects.None, 0.0f);
            spriteBatch.DrawString(font, "Start by choosing 3 ingridients from the fridge", new Vector2(40, 320), Color.Green, 0, new Vector2(0, 0), 3.0f, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(fridge, new Vector2(0, 400), Color.White);
          
                    
            for (int i = 0; i < 16; i++) { 
                    spriteBatch.Draw(fruit, r, null, Color.White, 0f, Vector2.Zero, SpriteEffects.None, 0f);//spriteBatch.Draw(fruit, new Vector2(350, 850), Color.White); // 1st row clamp @ y = 850
                if (isTouchedfruit == true)           
                    {
                    //playerFood selectedFood = playerFood.Apple;
                      spriteBatch.Draw(hide, r, null, Color.Green * 15.9f, 0f, Vector2.Zero, SpriteEffects.None, 0f);
                      spriteBatch.DrawString(font, "\nItem: Apple", new Vector2(40, 390), Color.Black, 0, new Vector2(0, 0), 2.0f, SpriteEffects.None, 0.0f);
                      arrFoodSelected[i] = "Apple";
                      
                 
                   
                   
                      index = i;
                    }
                   


                    spriteBatch.Draw(food1, r1, null, Color.White, 0f, Vector2.Zero, SpriteEffects.None, 0f);
                    if (isTouchedfood1 == true)
                    {
                        spriteBatch.Draw(hide, r1, null, Color.Green * 15.9f, 0f, Vector2.Zero, SpriteEffects.None, 0f);
                        spriteBatch.DrawString(font, "\nItem: Banana", new Vector2(40, 390), Color.Black, 0, new Vector2(0, 0), 2.0f, SpriteEffects.None, 0.0f);
                        arrFoodSelected[i] = "Banana";
                   
                    index = i;
                    }

                    spriteBatch.Draw(food2, r2, null, Color.White, 0f, Vector2.Zero,  SpriteEffects.None, 0f);
                    if (isTouchedfood2 == true)
                    {
                        spriteBatch.Draw(hide, r2, null, Color.Green * 15.9f, 0f, Vector2.Zero, SpriteEffects.None, 0f);
                        spriteBatch.DrawString(font, "\nItem: Beetroot", new Vector2(40, 390), Color.Black, 0, new Vector2(0, 0), 2.0f, SpriteEffects.None, 0.0f);
                        arrFoodSelected[i] = "Beetroot";
                      
                    index = i;
                    }

                    spriteBatch.Draw(food3, r3, null, Color.White, 0f, Vector2.Zero, SpriteEffects.None, 0f);
                    if (isTouchedfood3 == true)
                    {
                        spriteBatch.Draw(hide, r3, null, Color.Green * 15.9f, 0f, Vector2.Zero, SpriteEffects.None, 0f);
                        spriteBatch.DrawString(font, "\nItem: Avocado", new Vector2(40, 390), Color.Black, 0, new Vector2(0, 0), 2.0f, SpriteEffects.None, 0.0f);
                        arrFoodSelected[i] = "Avocado";
                      
                    index = i;
                    }


                    spriteBatch.Draw(food4, r4, null, Color.White, 0f, Vector2.Zero,  SpriteEffects.None, 0f);//spriteBatch.Draw(fruit, new Vector2(350, 850), Color.White); // 2nd row clamp @ y = 950
                    if (isTouchedfood4 == true)
                    {
                        spriteBatch.Draw(hide, r4, null, Color.Green * 15.9f, 0f, Vector2.Zero, SpriteEffects.None, 0f);
                        spriteBatch.DrawString(font, "\nItem: Bellpepper", new Vector2(40, 390), Color.Black, 0, new Vector2(0, 0), 2.0f, SpriteEffects.None, 0.0f);
                        arrFoodSelected[i] = "Bellpepper";
                 
                    index = i;
                    }

                    spriteBatch.Draw(food5, r5, null, Color.White, 0f, Vector2.Zero,  SpriteEffects.None, 0f);
                    if (isTouchedfood5 == true)
                    {
                        spriteBatch.Draw(hide, r5, null, Color.Green * 15.9f, 0f, Vector2.Zero, SpriteEffects.None, 0f);
                        spriteBatch.DrawString(font, "\nItem: Brocolli", new Vector2(40, 390), Color.Black, 0, new Vector2(0, 0), 2.0f, SpriteEffects.None, 0.0f);
                        arrFoodSelected[i] = "Brocolli";
                      
                    index = i;
                    }

                    spriteBatch.Draw(food6, r6, null, Color.White, 0f, Vector2.Zero, SpriteEffects.None, 0f);
                    if (isTouchedfood6 == true)
                    {
                        spriteBatch.Draw(hide, r6, null, Color.Green * 15.9f, 0f, Vector2.Zero, SpriteEffects.None, 0f);
                        spriteBatch.DrawString(font, "\nItem: Canteloupe", new Vector2(40, 390), Color.Black, 0, new Vector2(0, 0), 2.0f, SpriteEffects.None, 0.0f);
                        arrFoodSelected[i] = "Canteloupe";
                  
                    index = i;
                    }

                    spriteBatch.Draw(food7, r7, null, Color.White, 0f, Vector2.Zero,  SpriteEffects.None, 0f);
                    if (isTouchedfood7 == true)
                    {
                        spriteBatch.Draw(hide, r7, null, Color.Green * 15.9f, 0f, Vector2.Zero, SpriteEffects.None, 0f);
                        spriteBatch.DrawString(font, "\nItem: Chillipepper", new Vector2(40, 390), Color.Black, 0, new Vector2(0, 0), 2.0f, SpriteEffects.None, 0.0f);
                        arrFoodSelected[i] = "Chillipepper";
                    
                    index = i;
                    }

                    spriteBatch.Draw(food8, r8, null, Color.White, 0f, Vector2.Zero,  SpriteEffects.None, 0f);//spriteBatch.Draw(fruit, new Vector2(350, 850), Color.White); // 2nd row clamp @ y = 950
                    if (isTouchedfood8 == true)
                    {
                        spriteBatch.Draw(hide, r8, null, Color.Green * 15.9f, 0f, Vector2.Zero, SpriteEffects.None, 0f);
                        spriteBatch.DrawString(font, "\nItem: Eggplant", new Vector2(40, 390), Color.Black, 0, new Vector2(0, 0), 2.0f, SpriteEffects.None, 0.0f);
                        arrFoodSelected[i] = "Eggplant";
                     
                        index = i;
                    }

                    spriteBatch.Draw(food9, r9, null, Color.White, 0f, Vector2.Zero,  SpriteEffects.None, 0f);
                    if (isTouchedfood9 == true)
                    {
                        spriteBatch.Draw(hide, r9, null, Color.Green * 15.9f, 0f, Vector2.Zero, SpriteEffects.None, 0f);
                        spriteBatch.DrawString(font, "\nItem: Fries", new Vector2(40, 390), Color.Black, 0, new Vector2(0, 0), 2.0f, SpriteEffects.None, 0.0f);
                        arrFoodSelected[i] = "Fries";
                       
                        index = i;
                    }
                    spriteBatch.Draw(food10, r10, null, Color.White, 0f, Vector2.Zero, SpriteEffects.None, 0f);
                    if (isTouchedfood10 == true)
                    {
                        spriteBatch.Draw(hide, r10, null, Color.Green * 15.9f, 0f, Vector2.Zero, SpriteEffects.None, 0f);
                        spriteBatch.DrawString(font, "\nItem: Grapes", new Vector2(40, 390), Color.Black, 0, new Vector2(0, 0), 2.0f, SpriteEffects.None, 0.0f);
                        arrFoodSelected[i] = "Grapes";
                 
                        index = i;
                    }

                    spriteBatch.Draw(food11, r11, null, Color.White, 0f, Vector2.Zero,  SpriteEffects.None, 0f);
                    if (isTouchedfood11 == true)
                    {
                        spriteBatch.Draw(hide, r11, null, Color.Green * 15.9f, 0f, Vector2.Zero, SpriteEffects.None, 0f);
                        spriteBatch.DrawString(font, "\nItem: Dragon Fruit", new Vector2(40, 390), Color.Black, 0, new Vector2(0, 0), 2.0f, SpriteEffects.None, 0.0f);
                        arrFoodSelected[i] = "Dragonfruit";
                        
                        index = i;
                    }

                    spriteBatch.Draw(food12, r12, null, Color.White, 0f, Vector2.Zero,  SpriteEffects.None, 0f);//spriteBatch.Draw(fruit, new Vector2(350, 850), Color.White); // 2nd row clamp @ y = 950
                    if (isTouchedfood12 == true)
                    {
                        spriteBatch.Draw(hide, r12, null, Color.Green * 15.9f, 0f, Vector2.Zero, SpriteEffects.None, 0f);
                        spriteBatch.DrawString(font, "\nItem: Ham", new Vector2(40, 390), Color.Black, 0, new Vector2(0, 0), 2.0f, SpriteEffects.None, 0.0f);
                        arrFoodSelected[i] = "Ham";
                        
                        index = i;
                    }

                    spriteBatch.Draw(food13, r13, null, Color.White, 0f, Vector2.Zero,  SpriteEffects.None, 0f);
                    if (isTouchedfood13 == true)
                    {
                        spriteBatch.Draw(hide, r13, null, Color.Green * 15.9f, 0f, Vector2.Zero, SpriteEffects.None, 0f);
                        spriteBatch.DrawString(font, "\nItem: Kiwi", new Vector2(40, 390), Color.Black, 0, new Vector2(0, 0), 2.0f, SpriteEffects.None, 0.0f);
                        arrFoodSelected[i] = "Kiwi";
                    
                        index = i;
                    }  

                    spriteBatch.Draw(food14, r14, null, Color.White, 0f, Vector2.Zero,  SpriteEffects.None, 0f);
                    if (isTouchedfood14 == true)
                    {
                        spriteBatch.Draw(hide, r14, null, Color.Green * 15.9f, 0f, Vector2.Zero, SpriteEffects.None, 0f);
                        spriteBatch.DrawString(font, "\nItem: Jalapeno", new Vector2(40, 390), Color.Black, 0, new Vector2(0, 0), 2.0f, SpriteEffects.None, 0.0f);
                        arrFoodSelected[i] = "Jalapeno";
                        
                        index = i;
                    }

                    spriteBatch.Draw(food15, r15, null, Color.White, 0f, Vector2.Zero,  SpriteEffects.None, 0f);
                    if (isTouchedfood15 == true)
                    {
                        spriteBatch.Draw(hide, r15, null, Color.Green * 15.9f, 0f, Vector2.Zero, SpriteEffects.None, 0f);
                        spriteBatch.DrawString(font, "\nItem: Orange", new Vector2(40, 390), Color.Black, 0, new Vector2(0, 0), 2.0f, SpriteEffects.None, 0.0f);
                        arrFoodSelected[i] = "Orange";
                       
                        index = i;
                    }

                spriteBatch.DrawString(font, "Number of items taken: ", new Vector2(40, 475), Color.Green, 0, new Vector2(0, 0), 3.0f, SpriteEffects.None, 0.0f);
                spriteBatch.DrawString(font, counter.ToString(), new Vector2(550, 475), Color.Red, 0, new Vector2(0, 0), 3.0f, SpriteEffects.None, 0.0f);


                spriteBatch.Draw(btnNext, rbtnNext, null, Color.White, 0f, Vector2.Zero, SpriteEffects.None, 0f);





                /*Write player choices to a textfile*/

                //Game Logic to change screen and check whether 3 items have been selected
                /*Written by Boitshoko Tumane*/


                if ((isTouchedNext == true) && (counter >= 3))
                    {

                    /*Write player choices to a textfile*/
                    /*Written By Boitshoko Tumane*/
                    try
                    {
                        using (FileStream fileStream = new FileStream("C:\\Users\\Choki\\Desktop\\SE-master\\SE-master\\Choices.txt",
                            FileMode.Open, FileAccess.Write))
                        {
                            using (StreamWriter streamWriter = new StreamWriter(fileStream, System.Text.Encoding.ASCII))
                            {
                                streamWriter.Write(playerFoodSelected.ToString());
                                streamWriter.Close();
                            }
                            fileStream.Close();
                        }
                            
                       

                        
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine(ex.StackTrace);
                    }

                    spriteBatch.DrawString(font, "Great!", new Vector2(70, 900), Color.Red, 0, new Vector2(0, 0), 6.0f, SpriteEffects.None, 0.0f);
                    GameStateManager.Instance.AddNewScreen(new Plate(_graphicsDevice));
                    
                }
                
                if ((isTouchedNext == true) && (counter != 3))
                {
                    spriteBatch.DrawString(font, "Please select 3 food items", new Vector2(70, 600), Color.Red, 0, new Vector2(0, 0), 6.0f, SpriteEffects.None, 0.0f);
                }
                
            }
            


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



            /*while (TouchPanel.IsGestureAvailable)
           {

               GestureSample gesture = TouchPanel.ReadGesture();


               switch (gesture.GestureType)
               {

                   case GestureType.Tap:
                   GameStateManager.Instance.UnloadContent();
                   GameStateManager.Instance.SetContent(content);
                   GameStateManager.Instance.AddNewScreen(new Plate(_graphicsDevice));
                   break;
                   case GestureType.Pinch:


                       //GameStateManager.Instance.AddNewScreen(new Plate(_graphicsDevice));
                       break;
               }
           } */


            //AddFoodSelected(myPlate.selectedFood, index);




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

        /*Written by Boitshoko Tumane*/
        public void AddFoodSelected(string[] destArr, int myIndex)
        {
            //string value = "";
            string[] copyArr = new string[3];
            for (int i = 0; i < 3; i++)
            {
                copyArr[i] += arrFoodSelected[myIndex];
                destArr[i] += copyArr[i];
            }
        }

    }
}
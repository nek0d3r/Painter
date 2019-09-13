using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Painter
{
    public enum Tool { Pencil, Eraser, Line, Undo, Circle, Box };

    public class Paint : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        // Table dialogs
        ColorTable colorToolbar = new ColorTable();
        ToolTable toolBar = new ToolTable();
        BrushTable sizeBar = new BrushTable();
        SaveTable saveBar = new SaveTable();

        // Graphics for tools
        Texture2D pencil;
        Texture2D eraser;
        Texture2D line;
        Texture2D undo;

        // Sound effects for tools
        SoundEffect scribble;
        SoundEffect erasing;
        SoundEffect lineMiddle;
        SoundEffectInstance playPencil;
        SoundEffectInstance playEraser;
        SoundEffectInstance playLine;

        BrushSize size = new BrushSize();

        Tool toolOn = Tool.Pencil;

        // Graphics for drawing textures
        Texture2D fillPencil;
        Texture2D colorTexture;

        // Mouse position
        MouseState mousePos = new MouseState();
        MouseState prevMousePos = new MouseState();
        int currentMouseX, currentMouseY;

        // Keyboard
        KeyboardState keyState = new KeyboardState();
        KeyboardState prevKeyState = new KeyboardState();

        // Color currently being used
        Coloring color = new Coloring();

        // List of texture locations
        List<int[]> pencilPos = new List<int[]>();

        // Spritefont for text
        SpriteFont font;

        public Paint()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            IntPtr hWnd = this.Window.Handle;
            var control = System.Windows.Forms.Control.FromHandle(hWnd);
            var form = control.FindForm();
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            colorToolbar.Show();
            toolBar.Show();
            sizeBar.Show();
            saveBar.setWindowBounds(new System.Drawing.Rectangle(this.Window.ClientBounds.X, this.Window.ClientBounds.Y, this.Window.ClientBounds.Width, this.Window.ClientBounds.Height));
            saveBar.Show();

            size.setSize(16);

            // Color currently being used
            color.setColor(1);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // Graphics for tools
            pencil = Content.Load<Texture2D>("Graphics/Tools/pencil");
            eraser = Content.Load<Texture2D>("Graphics/Tools/eraser");
            line = Content.Load<Texture2D>("Graphics/Tools/linepoint");
            undo = Content.Load<Texture2D>("Graphics/Tools/undo");

            // Graphics for drawing textures
            fillPencil = Content.Load<Texture2D>("Graphics/Draw/pencilfill");
            colorTexture = Content.Load<Texture2D>("Graphics/Draw/colortexture");

            // Sound effects for tools
            scribble = Content.Load<SoundEffect>("Audio/pencil");
            erasing = Content.Load<SoundEffect>("Audio/eraser");
            lineMiddle = Content.Load<SoundEffect>("Audio/line");
            playPencil = scribble.CreateInstance();
            playEraser = erasing.CreateInstance();
            playLine = lineMiddle.CreateInstance();

            // Font for text
            font = Content.Load<SpriteFont>("Text");

            int[] i = { -1, -1, colorToolbar.getColor(), size.getSize(), 0 };
            int[] j = { -1, -1, colorToolbar.getColor(), size.getSize(), 0 };
            pencilPos.Add(i);
            pencilPos.Add(j);
        }
        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            if (toolBar.IsDisposed)
            {
                toolBar = new ToolTable();
                toolBar.Show();
            }
            if (colorToolbar.IsDisposed)
            {
                colorToolbar = new ColorTable();
                colorToolbar.Show();
            }
            if (sizeBar.IsDisposed)
            {
                sizeBar = new BrushTable();
                sizeBar.Show();
            }
            if (saveBar.IsDisposed)
            {
                saveBar = new SaveTable();
                saveBar.setWindowBounds(new System.Drawing.Rectangle(this.Window.ClientBounds.X, this.Window.ClientBounds.Y, this.Window.ClientBounds.Width, this.Window.ClientBounds.Height));
                saveBar.Show();
            }

            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            toolOn = toolBar.getTool();
            size.setSize(sizeBar.getBrushSize());

            mousePos = Mouse.GetState();
            keyState = Keyboard.GetState();

            currentMouseX = mousePos.X;
            currentMouseY = mousePos.Y;

            if (this.IsActive && mousePos.X >= 0 && mousePos.X < graphics.PreferredBackBufferWidth && mousePos.Y >= 0 && mousePos.Y < graphics.PreferredBackBufferHeight)
            {
                if (toolOn == Tool.Pencil)
                {
                    if (mousePos.LeftButton == ButtonState.Pressed)
                    {
                        int[] i = { mousePos.X, mousePos.Y, colorToolbar.getColor(), size.getSize(), 0 };
                        pencilPos.Add(i);
                        if (playPencil.State != SoundState.Playing)
                            playPencil.Play();
                    }
                    else if (playPencil.State == SoundState.Playing)
                    {
                        playPencil.Stop();
                    }

                    if (mousePos.LeftButton == ButtonState.Released && prevMousePos.LeftButton == ButtonState.Pressed)
                    {
                        int[] i = { -1, -1, colorToolbar.getColor(), size.getSize(), 0 };
                        pencilPos.Add(i);
                    }
                }
                else if (toolOn == Tool.Eraser)
                {
                    if (mousePos.LeftButton == ButtonState.Pressed)
                    {
                        int[] i = { mousePos.X, mousePos.Y, 0, size.getSize(), 0 };
                        pencilPos.Add(i);
                        if (playEraser.State != SoundState.Playing)
                            playEraser.Play();
                    }
                    else if (playEraser.State == SoundState.Playing)
                    {
                        playEraser.Stop();
                    }

                    if (mousePos.LeftButton == ButtonState.Released && prevMousePos.LeftButton == ButtonState.Pressed)
                    {
                        int[] i = { -1, -1, 0, size.getSize(), 0 };
                        pencilPos.Add(i);
                    }
                }
                else if (toolOn == Tool.Line)
                {
                    if (mousePos.LeftButton == ButtonState.Pressed && prevMousePos.LeftButton == ButtonState.Released)
                    {
                        int[] i = { mousePos.X - Convert.ToInt32(size.getSize() / 2), mousePos.Y - Convert.ToInt32(size.getSize() / 2), colorToolbar.getColor(), size.getSize(), 0 };
                        int[] j = { mousePos.X - Convert.ToInt32(size.getSize() / 2), mousePos.Y - Convert.ToInt32(size.getSize() / 2), colorToolbar.getColor(), size.getSize(), 0 };
                        pencilPos.Add(i);
                        pencilPos.Add(j);
                    }

                    if (mousePos.LeftButton == ButtonState.Pressed && prevMousePos.LeftButton == ButtonState.Pressed)
                    {
                        pencilPos[pencilPos.Count - 1][0] = mousePos.X - Convert.ToInt32(size.getSize() / 2);
                        pencilPos[pencilPos.Count - 1][1] = mousePos.Y - Convert.ToInt32(size.getSize() / 2);
                        if (playLine.State != SoundState.Playing)
                            playLine.Play();
                    }

                    if (mousePos.LeftButton == ButtonState.Released && prevMousePos.LeftButton == ButtonState.Pressed)
                    {
                        int[] i = { -1, -1, 0, size.getSize(), 0 };
                        pencilPos.Add(i);
                    }
                }
                else if (toolOn == Tool.Undo && pencilPos.Count > 0)
                {
                    if (mousePos.LeftButton == ButtonState.Pressed)
                    {
                        pencilPos.Remove(pencilPos[pencilPos.Count - 1]);
                    }
                }
                else if (toolOn == Tool.Circle)
                {
                    if (mousePos.LeftButton == ButtonState.Pressed && prevMousePos.LeftButton == ButtonState.Released)
                    {
                        int[] i = { mousePos.X - Convert.ToInt32(size.getSize() / 2), mousePos.Y - Convert.ToInt32(size.getSize() / 2), colorToolbar.getColor(), size.getSize(), 1 };
                        int[] j = { mousePos.X - Convert.ToInt32(size.getSize() / 2), mousePos.Y - Convert.ToInt32(size.getSize() / 2), colorToolbar.getColor(), size.getSize(), 0 };
                        pencilPos.Add(i);
                        pencilPos.Add(j);
                    }

                    if (mousePos.LeftButton == ButtonState.Pressed && prevMousePos.LeftButton == ButtonState.Pressed)
                    {
                        pencilPos[pencilPos.Count - 1][0] = mousePos.X - Convert.ToInt32(size.getSize() / 2);
                        pencilPos[pencilPos.Count - 1][1] = mousePos.Y - Convert.ToInt32(size.getSize() / 2);
                        if (playLine.State != SoundState.Playing)
                            playLine.Play();
                    }

                    if (mousePos.LeftButton == ButtonState.Released && prevMousePos.LeftButton == ButtonState.Pressed)
                    {
                        int[] i = { -1, -1, 0, size.getSize(), 0 };
                        pencilPos.Add(i);
                    }
                }
                else if (toolOn == Tool.Box)
                {
                    if (mousePos.LeftButton == ButtonState.Pressed && prevMousePos.LeftButton == ButtonState.Released)
                    {
                        int[] i = { mousePos.X - Convert.ToInt32(size.getSize() / 2), mousePos.Y - Convert.ToInt32(size.getSize() / 2), colorToolbar.getColor(), size.getSize(), 2 };
                        int[] j = { mousePos.X - Convert.ToInt32(size.getSize() / 2), mousePos.Y - Convert.ToInt32(size.getSize() / 2), colorToolbar.getColor(), size.getSize(), 0 };
                        pencilPos.Add(i);
                        pencilPos.Add(j);
                    }

                    if (mousePos.LeftButton == ButtonState.Pressed && prevMousePos.LeftButton == ButtonState.Pressed)
                    {
                        pencilPos[pencilPos.Count - 1][0] = mousePos.X - Convert.ToInt32(size.getSize() / 2);
                        pencilPos[pencilPos.Count - 1][1] = mousePos.Y - Convert.ToInt32(size.getSize() / 2);
                        if (playLine.State != SoundState.Playing)
                            playLine.Play();
                    }

                    if (mousePos.LeftButton == ButtonState.Released && prevMousePos.LeftButton == ButtonState.Pressed)
                    {
                        int[] i = { -1, -1, 0, size.getSize(), 0 };
                        pencilPos.Add(i);
                    }
                }

                base.Update(gameTime);
            }
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            spriteBatch.Begin();

            for (int c = 1; c < pencilPos.Count; c++)
            {
                color.setColor(pencilPos[c][2]);
                size.setSize(pencilPos[c][3]);

                if (pencilPos[c - 1][4] == 0 && pencilPos[c][4] == 0)
                {
                    if (pencilPos[c][0] != -1 && pencilPos[c][1] != -1)
                    {
                        spriteBatch.Draw(fillPencil, new Rectangle(Convert.ToInt32(pencilPos[c][0] - (size.getSize() / 2)), Convert.ToInt32(pencilPos[c][1] - (size.getSize() / 2)), size.getSize(), size.getSize()), color.getColor());
                    }

                    if (!(pencilPos[c - 1][0] == -1 && pencilPos[c - 1][1] == -1) && !(pencilPos[c][0] == -1 && pencilPos[c][1] == -1))
                    {
                        Line temp = new Line(pencilPos[c - 1][0], pencilPos[c - 1][1], pencilPos[c][0], pencilPos[c][1]);
                        spriteBatch.Draw(colorTexture, new Rectangle(Convert.ToInt32(pencilPos[c][0]), Convert.ToInt32(pencilPos[c][1]), temp.getLength(), size.getSize()), null, color.getColor(), MathHelper.ToRadians((float)temp.getAngle()), new Vector2(0, 0.5f), SpriteEffects.None, 0);
                    }
                }
                else if (pencilPos[c - 1][4] == 1)
                {
                    // If drawing top left to bottom right
                    if (pencilPos[c][0] > pencilPos[c - 1][0] && pencilPos[c][1] > pencilPos[c - 1][1])
                        spriteBatch.Draw(fillPencil, new Rectangle(pencilPos[c - 1][0], pencilPos[c - 1][1], pencilPos[c][0] - pencilPos[c - 1][0], pencilPos[c][1] - pencilPos[c - 1][1]), color.getColor());

                    // If drawing top right to bottom left
                    if (pencilPos[c][0] < pencilPos[c - 1][0] && pencilPos[c][1] > pencilPos[c - 1][1])
                        spriteBatch.Draw(fillPencil, new Rectangle(pencilPos[c][0], pencilPos[c - 1][1], pencilPos[c - 1][0] - pencilPos[c][0], pencilPos[c][1] - pencilPos[c - 1][1]), color.getColor());

                    // If drawing bottom right to top left
                    if (pencilPos[c][0] < pencilPos[c - 1][0] && pencilPos[c][1] < pencilPos[c - 1][1])
                        spriteBatch.Draw(fillPencil, new Rectangle(pencilPos[c][0], pencilPos[c][1], pencilPos[c - 1][0] - pencilPos[c][0], pencilPos[c - 1][1] - pencilPos[c][1]), color.getColor());

                    // If drawing bottom left to top right
                    if (pencilPos[c][0] > pencilPos[c - 1][0] && pencilPos[c][1] < pencilPos[c - 1][1])
                        spriteBatch.Draw(fillPencil, new Rectangle(pencilPos[c - 1][0], pencilPos[c][1], pencilPos[c][0] - pencilPos[c - 1][0], pencilPos[c - 1][1] - pencilPos[c][1]), color.getColor());
                }
                else if (pencilPos[c - 1][4] == 2)
                {
                    // If drawing top left to bottom right
                    if (pencilPos[c][0] > pencilPos[c - 1][0] && pencilPos[c][1] > pencilPos[c - 1][1])
                        spriteBatch.Draw(colorTexture, new Rectangle(pencilPos[c - 1][0], pencilPos[c - 1][1], pencilPos[c][0] - pencilPos[c - 1][0], pencilPos[c][1] - pencilPos[c - 1][1]), color.getColor());

                    // If drawing top right to bottom left
                    if (pencilPos[c][0] < pencilPos[c - 1][0] && pencilPos[c][1] > pencilPos[c - 1][1])
                        spriteBatch.Draw(colorTexture, new Rectangle(pencilPos[c][0], pencilPos[c - 1][1], pencilPos[c - 1][0] - pencilPos[c][0], pencilPos[c][1] - pencilPos[c - 1][1]), color.getColor());

                    // If drawing bottom right to top left
                    if (pencilPos[c][0] < pencilPos[c - 1][0] && pencilPos[c][1] < pencilPos[c - 1][1])
                        spriteBatch.Draw(colorTexture, new Rectangle(pencilPos[c][0], pencilPos[c][1], pencilPos[c - 1][0] - pencilPos[c][0], pencilPos[c - 1][1] - pencilPos[c][1]), color.getColor());

                    // If drawing bottom left to top right
                    if (pencilPos[c][0] > pencilPos[c - 1][0] && pencilPos[c][1] < pencilPos[c - 1][1])
                        spriteBatch.Draw(colorTexture, new Rectangle(pencilPos[c - 1][0], pencilPos[c][1], pencilPos[c][0] - pencilPos[c - 1][0], pencilPos[c - 1][1] - pencilPos[c][1]), color.getColor());
                }
            }

            if (toolOn == Tool.Pencil)
            {
                spriteBatch.Draw(pencil, new Rectangle(currentMouseX, currentMouseY - 16, 16, 16), Color.White);
            }
            if (toolOn == Tool.Eraser)
            {
                spriteBatch.Draw(eraser, new Rectangle(currentMouseX, currentMouseY - 16, 16, 16), Color.White);
            }
            if (toolOn == Tool.Line || toolOn == Tool.Circle || toolOn == Tool.Box)
            {
                if (mousePos.LeftButton == ButtonState.Pressed)
                {
                    spriteBatch.Draw(line, new Rectangle(currentMouseX - 16, currentMouseY - 16, 16, 16), Color.Black);
                }
                else
                {
                    spriteBatch.Draw(line, new Rectangle(currentMouseX - 16, currentMouseY - 16, 16, 16), Color.White);
                }
            }
            if (toolOn == Tool.Undo)
            {
                spriteBatch.Draw(undo, new Rectangle(currentMouseX - 16, currentMouseY - 16, 16, 16), Color.White);
            }

            spriteBatch.End();

            prevMousePos = mousePos;
            prevKeyState = keyState;

            base.Draw(gameTime);
        }
    }
}

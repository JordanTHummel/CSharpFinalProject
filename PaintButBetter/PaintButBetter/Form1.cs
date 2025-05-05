using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Timer = System.Windows.Forms.Timer; //timer was giving error that timer was ambigious between to different classes and need to specify


namespace PaintButBetter
{
    public partial class Form1 : Form
    {
        private Bitmap canvas;
        private Graphics graphics;
        private bool isDrawing = false;
        private Point lastPoint;
        private Timer autoSaveTimer;
        // Fields for tracking what the user wants to draw on the canvas
        private string? shapeToDraw = null;
        private string? textToDraw = null;

        public Form1()
        {
            InitializeComponent();
            InitializeCanvas();
            HookEvents();



            autoSaveTimer = new Timer(); //create new timer 
            autoSaveTimer.Interval = 1000; //set to however long want
            autoSaveTimer.Tick += AutoSaveTimer_Tick; //same as button logic, sets timer to the actual save
            autoSaveTimer.Start();


        }

        private void InitializeCanvas()
        {
            canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(canvas);
            graphics.Clear(Color.White);
            pictureBox1.Image = canvas;
        }

        private void HookEvents()
        {
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (penToolStripMenuItem.Checked)
            {
                isDrawing = true;
                lastPoint = e.Location;
            }

            if (fillToolStripMenuItem.Checked)
            {
                Color inital = canvas.GetPixel(e.X, e.Y); //gets color of initial pixel (we're filling in all pixels of that color)
                Color replacement = Color.Blue; //we'll figure out color later, blue for now
                Fill(e.X, e.Y, inital, replacement); //calls method to fill in pixel

            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e) // this will have to be changed when you work on brush
        {
            if (isDrawing)
            {
                using (Pen pen = new Pen(Color.Black, 2))
                {
                    graphics.DrawLine(pen, lastPoint, e.Location);
                }
                lastPoint = e.Location;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void BrushButton_Click(object sender, EventArgs e)
        {
            UncheckTools();
            penToolStripMenuItem.Checked = true;
        }

        private void EraserButton_Click(object sender, EventArgs e)
        {
            UncheckTools();
            eraserToolStripMenuItem.Checked = true;
        }

        private void BrushColorButton_Click(object sender, EventArgs e)
        {
            // color mode
        }

        private void ShapesButton_Click(object sender, EventArgs e) // Jordan
        {
            // Create a new window, displaying shape options to select from
            using (Form shapeForm = new Form())
            {
                shapeForm.Text = "Choose a Shape";
                shapeForm.Size = new Size(200, 250);
                // Button for selecting to draw a rectangle
                Button rectButton = new Button
                {
                    Text = "Rectangle",
                    // Makes sure buttons are aligned from top to bottom
                    Dock = DockStyle.Top
                };
                // Button for selecting to draw a square
                Button squareButton = new Button
                {
                    Text = "Square",
                    Dock = DockStyle.Top
                };
                // Button for selecting to draw a circle
                Button circleButton = new Button
                {
                    Text = "Circle",
                    Dock = DockStyle.Top
                };
                // Button for selecting to draw a triangle
                Button triangleButton = new Button
                {
                    Text = "Triangle",
                    Dock = DockStyle.Top
                };
                // Using a lambda expression, to add an event handler on click of one the elements to set field shapeToDraw
                // Just updates the shapeToDraw element and then closes the new form
                rectButton.Click += (s, ev) =>
                {
                    shapeToDraw = "Rectangle";
                    shapeForm.Close();
                };
                squareButton.Click += (s, ev) =>
                {
                    shapeToDraw = "Square";
                    shapeForm.Close();
                };
                circleButton.Click += (s, ev) =>
                {
                    shapeToDraw = "Circle";
                    shapeForm.Close();
                };
                triangleButton.Click += (s, ev) =>
                {
                    shapeToDraw = "Triangle";
                    shapeForm.Close();
                };
                // Adding each of the buttons to the shapeform
                shapeForm.Controls.AddRange(new Control[] { triangleButton, circleButton, squareButton, rectButton });
                // Below will make it so must select a shape or exit before moving on
                shapeForm.ShowDialog();
            }
        }

        private void TextLabelButton_Click(object sender, EventArgs e) // Jordan
        {
            // Very similiar to the shapes
            using (Form textForm = new Form())
            {
                textForm.Text = "Enter Text";
                textForm.Size = new Size(300, 150);
                TextBox inputBox = new TextBox
                {
                    Dock = DockStyle.Top
                };
                Button drawTextButton = new Button
                {
                    Text = "OK",
                    Dock = DockStyle.Bottom
                };
                // Using lambda expression to add
                drawTextButton.Click += (s, ev) =>
                {
                    // If something was entered and the button to submit was clicked
                    if (!string.IsNullOrWhiteSpace(inputBox.Text))
                    {
                        // Update the textToDraw variable
                        textToDraw = inputBox.Text;
                        // Close the form
                        textForm.Close();
                    }
                };
                // Add the elements of the form to the form
                textForm.Controls.Add(inputBox);
                textForm.Controls.Add(drawTextButton);
                // Below will make it so must submit text or exit before moving on
                textForm.ShowDialog();
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e) // Jordan
        {
            // Sanity check
            if (graphics == null)
            {
                return;
            }
            // If shapeToDraw is null or empty, do not draw a shape on click
            if (!string.IsNullOrEmpty(shapeToDraw))
            {
                // Switch Statement to test shapeToDraw
                switch (shapeToDraw)
                {
                    case "Rectangle":
                        graphics.DrawRectangle(new Pen(Color.Black, 2), e.X, e.Y, 200, 100);
                        break;
                    case "Square":
                        graphics.DrawRectangle(new Pen(Color.Black, 2), e.X, e.Y, 100, 100);
                        break;
                    case "Circle":
                        graphics.DrawEllipse(new Pen(Color.Black, 2), e.X, e.Y, 100, 100);
                        break;
                    case "Triangle":
                        Point[] points = { new Point(e.X, e.Y), new Point(e.X - 50, e.Y + 100), new Point(e.X + 50, e.Y + 100) };
                        graphics.DrawPolygon(new Pen(Color.Black, 2), points);
                        break;
                        // No default cause of no need to do anything in the default case
                }
                // Reset because dont want to draw a shape every time we click
                shapeToDraw = null;
                // Invalidates the entire surface of the control and causes the control to be redrawn.
                pictureBox1.Invalidate();
            }
            // If textToDraw is null or empty no need to draw text on click
            else if (!string.IsNullOrEmpty(textToDraw))
            {
                using (Font font = new Font("Comic Sans", 16))
                {
                    // Draw inputted text on clicks location using the above font definition
                    graphics.DrawString(textToDraw, font, Brushes.Black, e.Location);
                }
                // Reset cause we dont want to draw a text string everytime we click
                textToDraw = null;
                // Invalidates the entire surface of the control and causes the control to be redrawn.
                pictureBox1.Invalidate();
            }
        }

        private void FillButton_Click(object sender, EventArgs e)
        {
            UncheckTools();
            fillToolStripMenuItem.Checked = true;
        }

        private void Fill(int x, int y, Color initial, Color replacement)
        {

            Stack<Point> pixels = new Stack<Point>(); //creates stack to hold pixels to fill

            bool[,] alreadyVisited = new bool[canvas.Width, canvas.Height]; //prevents checking same pixels twice

            pixels.Push(new Point(x, y)); //creates starting point from mouse

            while (pixels.Count > 0) //looping while there's more pixels to fill
            {
                Point p = pixels.Pop();
                int nextX = p.X;
                int nextY = p.Y;

                if (nextX < 0 || nextY < 0 || nextX >= canvas.Width || nextY >= canvas.Height) continue;

                if (alreadyVisited[nextX, nextY]) continue;

                if (canvas.GetPixel(nextX, nextY) != initial) continue;

                alreadyVisited[nextX, nextY] = true;

                canvas.SetPixel(nextX, nextY, replacement);

                pixels.Push(new Point(nextX + 1, nextY));
                pixels.Push(new Point(nextX - 1, nextY));
                pixels.Push(new Point(nextX, nextY + 1));
                pixels.Push(new Point(nextX, nextY - 1));
            }


            pictureBox1.Invalidate();

        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Title = "Find Save Location"; // just the name of the new file explorer
                saveDialog.Filter = "PNG Image|*.png"; // formats as png
                saveDialog.AddExtension = true; // automatically sets as png if user doesn't

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        canvas.Save(saveDialog.FileName, System.Drawing.Imaging.ImageFormat.Png); // Saves canvas
                        MessageBox.Show("Image saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void LoadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.Title = "Enter Image Import Location";
                openDialog.Filter = "PNG Image|*.png";

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    graphics.DrawImage(Image.FromFile(openDialog.FileName), 0, 0);
                    pictureBox1.Image = canvas;
                }

            }

        }

        private void UncheckTools()
        {
            penToolStripMenuItem.Checked = false;
            eraserToolStripMenuItem.Checked = false;
            fillToolStripMenuItem.Checked = false;
            //add more as we add more tools
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ignore
        }


        private void AutoSaveTimer_Tick(object sender, EventArgs e)
        {
            string path = "autosave.png"; //autosave file
            canvas.Save(path, System.Drawing.Imaging.ImageFormat.Png);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White); //fills canvas white
            pictureBox1.Invalidate();     // Refresh the screen

        }
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            //haven't used yet
        }

        private void brushToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //haven't used yet
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace PaintButBetter
{
    public partial class Form1 : Form
    {
        private Bitmap canvas;
        private Graphics graphics;
        private bool isDrawing = false;
        private Point lastPoint;
        /*private Timer autoSaveTimer;
        private Button clearButton;*/

        // Fields for tracking what the user wants to draw on the canvas
        private string? shapeToDraw = null;
        private string? textToDraw = null;

        public Form1()
        {
            InitializeComponent();
            InitializeCanvas();
            HookEvents();

            /*clearButton = new Button(); //creates a new button object
            clearButton.Text = "Clear"; //sets the button text as clear
            clearButton.Click += ClearButton_Click; //attatches the clear button click method to the button
            Controls.Add(clearButton); //shows the button on form

            autoSaveTimer = new Timer(); //create new timer 
            autoSaveTimer.Interval = x; //set to however long want
            autoSaveTimer.Tick += AutoSaveTimer_Tick; //same as button logic, sets timer to the actual save
            autoSaveTimer.Start();*/


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
            isDrawing = true;
            lastPoint = e.Location;
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
            // brush button
        }

        private void EraserButton_Click(object sender, EventArgs e)
        {
            // eraser mode
        }

        private void BrushColorButton_Click(object sender, EventArgs e)
        {
            // color mode
        }

        private void ShapesButton_Click(object sender, EventArgs e)
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
                // Using a lambda expression, on click of one the elements to set field shapeToDraw
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
                // Must select a shape or exit before moving on
                shapeForm.ShowDialog();
            }
        }

        private void TextLabelButton_Click(object sender, EventArgs e)
        {
            using (Form textForm = new Form())
            {
                textForm.Text = "Enter Text";
                textForm.Size = new Size(300, 150);

                TextBox inputBox = new TextBox { Dock = DockStyle.Top };
                Button drawTextButton = new Button { Text = "OK", Dock = DockStyle.Bottom };

                drawTextButton.Click += (s, ev) =>
                {
                    if (!string.IsNullOrWhiteSpace(inputBox.Text))
                    {
                        textToDraw = inputBox.Text;
                        textForm.Close();
                    }
                };

                textForm.Controls.Add(inputBox);
                textForm.Controls.Add(drawTextButton);
                textForm.ShowDialog();
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
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
                        Point[] points = {new Point(e.X, e.Y),new Point(e.X - 50, e.Y + 100),new Point(e.X + 50, e.Y + 100)};
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
            // import
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ignore
        }
        /*private void ClearButton_Click(object sender, EventArgs e)
        {    
            canvasGraphics.Clear(Color.White);   //fills canvas white     
            pictureBox1.Invalidate();     // Refresh the screen
        }
        
        private void AutoSaveTimer_Tick(object sender, EventArgs e)
        {
            string path = "autosave.png"; //autosave file
            canvas.Save(path, System.Drawing.Imaging.ImageFormat.Png);  
        }*/

    }
}

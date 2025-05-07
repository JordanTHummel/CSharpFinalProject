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
        private Pen pen = new Pen(Color.Black, 5);
        private enum ShapeType { None, Square, Circle, Rectangle, Triangle }
        private ShapeType currentShape = ShapeType.None;
        private string textToDraw;
        private Color penColor = Color.Black;



        public Form1()
        {
            InitializeComponent();
            InitializeCanvas();
            HookEvents();

        // This will run before the program starts to ask what canvas size to choose from
          string input = Microsoft.VisualBasic.Interaction.InputBox(
              "Choose a Canvas size: \n1 = 800 x 600\n2 = 1920 x 1080\n3 = 3840 x 2160",
              "Canvas Size", "1");

          if (int.TryParse(input, out int choice))
          {
              SetCanvasSize(choice);
          }
          else
          {
              MessageBox.Show("Invalid input.  Using default size.");
              SetCanvasSize(1);
          }



            autoSaveTimer = new Timer(); //create new timer 
            autoSaveTimer.Interval = 1000; //set to however long want
            autoSaveTimer.Tick += AutoSaveTimer_Tick; //same as button logic, sets timer to the actual save
            autoSaveTimer.Start();

            //makes the pen look good

            penToolStripMenuItem.Checked = true;
            pen = new Pen(Color.Black, 5);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

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
            if (currentShape != ShapeType.None)
            {
                DrawShape(e.Location);
                // reset shape
                currentShape = ShapeType.None;
                return;
            }

            if (!string.IsNullOrWhiteSpace(textToDraw))
            {
                PlaceText(e.Location);
                // Reset cause we dont want to draw a text string everytime we click
                textToDraw = "";
                return;
            }

            if (penToolStripMenuItem.Checked || eraserToolStripMenuItem.Checked)
            {
                isDrawing = true;
                lastPoint = e.Location;
            }

            if (fillToolStripMenuItem.Checked)
            {
                Color inital = canvas.GetPixel(e.X, e.Y); //gets color of initial pixel (we're filling in all pixels of that color)
                Color replacement = Color.Blue; //we'll figure out color later, blue for now
                Fill(e.X, e.Y, inital); //calls method to fill in pixel

            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e) // this will have to be changed when you work on brush
        {
            if (isDrawing)
            {
                graphics.DrawLine(pen, lastPoint, e.Location);

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
            pen = new Pen(penColor, 5);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void EraserButton_Click(object sender, EventArgs e)
        {
            UncheckTools();
            eraserToolStripMenuItem.Checked = true;
            pen = new Eraser(pen.Width).Pen;
        }

        

        private void TextLabelButton_Click(object sender, EventArgs e)
        {
            // Very similar to the shapes
            using (Form textForm = new Form())
            {
                textForm.Text = "Enter Text";
                textForm.Size = new Size(300, 90);
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

        private void PlaceText(Point location)
        {
            using (Font font = new Font("Comic Sans MS", 16))
            {
                // Draw inputted text on clicks location using the above font definition
                graphics.DrawString(textToDraw, font, pen.Brush, location.X, location.Y);
            }
            // Invalidates the entire surface of the control and causes the control to be redrawn.
            pictureBox1.Invalidate();
        }

        // SHAPES TOOL BELOW
        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckTools();
            currentShape = ShapeType.Square;
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckTools();
            currentShape = ShapeType.Circle;
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckTools();
            currentShape = ShapeType.Rectangle;
        }

        private void triangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckTools();
            currentShape = ShapeType.Triangle;
        }

        private void DrawShape(Point location)
        {
            // Use switch statement to find which shape to draw
            switch (currentShape)
            {
                case ShapeType.Square:
                    graphics.DrawRectangle(pen, location.X, location.Y, 100, 100);
                    break;
                case ShapeType.Circle:
                    graphics.DrawEllipse(pen, location.X, location.Y, 100, 100);
                    break;
                case ShapeType.Rectangle:
                    graphics.DrawRectangle(pen, location.X, location.Y, 200, 100);
                    break;
                case ShapeType.Triangle:
                    Point[] trianglePoints =
                    {
                new Point(location.X, location.Y),
                new Point(location.X + 50, location.Y + 100),
                new Point(location.X - 50, location.Y + 100)
            };
                    graphics.DrawPolygon(pen, trianglePoints);
                    break;
            }
            pictureBox1.Invalidate();
        }


        private void FillButton_Click(object sender, EventArgs e)
        {
            UncheckTools();
            fillToolStripMenuItem.Checked = true;
        }

        private void Fill(int x, int y, Color initial)
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

                canvas.SetPixel(nextX, nextY, penColor);

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

        private void PenSizeUp(object sender, EventArgs e)
        {
            pen.Width++;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        private void PenSizeDown(object sender, EventArgs e)
        {
            pen.Width--;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            TrackBar x = (TrackBar)sender;
            pen.Width = x.Value * 5;
        }

        private void ColorButton(object sender, EventArgs e)
        {
            if (!eraserToolStripMenuItem.Checked)
            {
                pen.Color = ((Button)sender).BackColor;
                penColor = pen.Color;
            }
        }

        private void antialiasingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            antialiasingToolStripMenuItem.Checked = !antialiasingToolStripMenuItem.Checked;
            if (antialiasingToolStripMenuItem.Checked)
            {
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            }
            else
            {
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            }

        }
    
    
    }
}

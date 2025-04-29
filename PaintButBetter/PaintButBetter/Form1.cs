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
            // create shapes
        }

        private void TextLabelButton_Click(object sender, EventArgs e)
        {
            // add text
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

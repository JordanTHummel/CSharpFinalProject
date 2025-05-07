namespace PaintButBetter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton2 = new ToolStripDropDownButton();
            loadToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            toolStripDropDownButton3 = new ToolStripDropDownButton();
            clearToolStripMenuItem = new ToolStripMenuItem();
            antialiasingToolStripMenuItem = new ToolStripMenuItem();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            brushesToolStripMenuItem = new ToolStripMenuItem();
            penToolStripMenuItem = new ToolStripMenuItem();
            eraserToolStripMenuItem = new ToolStripMenuItem();
            eraToolStripMenuItem = new ToolStripMenuItem();
            squareToolStripMenuItem = new ToolStripMenuItem();
            circleToolStripMenuItem = new ToolStripMenuItem();
            rectangleToolStripMenuItem = new ToolStripMenuItem();
            triangleToolStripMenuItem = new ToolStripMenuItem();
            textToolStripMenuItem = new ToolStripMenuItem();
            fillToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            trackBar1 = new TrackBar();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(20, 103);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1123, 689);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            // This gives the option to set the canvas size in the toolbox
            ToolStripDropDownButton canvasSizeDropDown = new ToolStripDropDownButton("Canvas Size");
            canvasSizeDropDown.DropDownItems.Add("Small (800 x 600)", null, (s, e) => SetCanvasSize(1)); 
            canvasSizeDropDown.DropDownItems.Add("Medium (1600 x 900)", null, (s, e) => SetCanvasSize(2));
            canvasSizeDropDown.DropDownItems.Add("Large (1920 x 1080)", null, (s, e) => SetCanvasSize(3));
            toolStrip1.Items.Add(canvasSizeDropDown);
            
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton2, toolStripDropDownButton3, toolStripDropDownButton1, toolStripSeparator1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.ShowItemToolTips = false;
            toolStrip1.Size = new Size(1173, 27);
            toolStrip1.TabIndex = 10;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton2
            // 
            toolStripDropDownButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton2.DropDownItems.AddRange(new ToolStripItem[] { loadToolStripMenuItem, saveToolStripMenuItem });
            toolStripDropDownButton2.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            toolStripDropDownButton2.Size = new Size(46, 24);
            toolStripDropDownButton2.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(125, 26);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += LoadButton_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(125, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += SaveButton_Click;
            // 
            // toolStripDropDownButton3
            // 
            toolStripDropDownButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton3.DropDownItems.AddRange(new ToolStripItem[] { clearToolStripMenuItem, antialiasingToolStripMenuItem });
            toolStripDropDownButton3.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            toolStripDropDownButton3.Size = new Size(49, 24);
            toolStripDropDownButton3.Text = "Edit";
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(224, 26);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.Click += ClearButton_Click;
            // 
            // antialiasingToolStripMenuItem
            // 
            antialiasingToolStripMenuItem.Name = "antialiasingToolStripMenuItem";
            antialiasingToolStripMenuItem.Size = new Size(224, 26);
            antialiasingToolStripMenuItem.Text = "Anti-Aliasing";
            antialiasingToolStripMenuItem.Click += antialiasingToolStripMenuItem_Click;
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { brushesToolStripMenuItem, eraToolStripMenuItem, textToolStripMenuItem, fillToolStripMenuItem });
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(58, 24);
            toolStripDropDownButton1.Text = "Tools";
            // 
            // brushesToolStripMenuItem
            // 
            brushesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { penToolStripMenuItem, eraserToolStripMenuItem });
            brushesToolStripMenuItem.Name = "brushesToolStripMenuItem";
            brushesToolStripMenuItem.Size = new Size(142, 26);
            brushesToolStripMenuItem.Text = "Brushes";
            brushesToolStripMenuItem.Click += brushToolStripMenuItem_Click;
            // 
            // penToolStripMenuItem
            // 
            penToolStripMenuItem.CheckOnClick = true;
            penToolStripMenuItem.Name = "penToolStripMenuItem";
            penToolStripMenuItem.Size = new Size(132, 26);
            penToolStripMenuItem.Text = "Pen";
            penToolStripMenuItem.Click += BrushButton_Click;
            // 
            // eraserToolStripMenuItem
            // 
            eraserToolStripMenuItem.Name = "eraserToolStripMenuItem";
            eraserToolStripMenuItem.Size = new Size(132, 26);
            eraserToolStripMenuItem.Text = "Eraser";
            eraserToolStripMenuItem.Click += EraserButton_Click;
            // 
            // eraToolStripMenuItem
            // 
            eraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { squareToolStripMenuItem, circleToolStripMenuItem, rectangleToolStripMenuItem, triangleToolStripMenuItem });
            eraToolStripMenuItem.Name = "eraToolStripMenuItem";
            eraToolStripMenuItem.Size = new Size(142, 26);
            eraToolStripMenuItem.Text = "Shapes";
            // 
            // squareToolStripMenuItem
            // 
            squareToolStripMenuItem.Name = "squareToolStripMenuItem";
            squareToolStripMenuItem.Size = new Size(158, 26);
            squareToolStripMenuItem.Text = "Square";
            squareToolStripMenuItem.Click += squareToolStripMenuItem_Click;
            // 
            // circleToolStripMenuItem
            // 
            circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            circleToolStripMenuItem.Size = new Size(158, 26);
            circleToolStripMenuItem.Text = "Circle";
            circleToolStripMenuItem.Click += circleToolStripMenuItem_Click;
            // 
            // rectangleToolStripMenuItem
            // 
            rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            rectangleToolStripMenuItem.Size = new Size(158, 26);
            rectangleToolStripMenuItem.Text = "Rectangle";
            rectangleToolStripMenuItem.Click += rectangleToolStripMenuItem_Click;
            // 
            // triangleToolStripMenuItem
            // 
            triangleToolStripMenuItem.Name = "triangleToolStripMenuItem";
            triangleToolStripMenuItem.Size = new Size(158, 26);
            triangleToolStripMenuItem.Text = "Triangle";
            triangleToolStripMenuItem.Click += triangleToolStripMenuItem_Click;
            // 
            // textToolStripMenuItem
            // 
            textToolStripMenuItem.Name = "textToolStripMenuItem";
            textToolStripMenuItem.Size = new Size(142, 26);
            textToolStripMenuItem.Text = "Text";
            textToolStripMenuItem.Click += TextLabelButton_Click;
            // 
            // fillToolStripMenuItem
            // 
            fillToolStripMenuItem.CheckOnClick = true;
            fillToolStripMenuItem.Name = "fillToolStripMenuItem";
            fillToolStripMenuItem.Size = new Size(142, 26);
            fillToolStripMenuItem.Text = "Fill";
            fillToolStripMenuItem.Click += FillButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(20, 41);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(279, 56);
            trackBar1.TabIndex = 13;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Location = new Point(621, 37);
            button1.Name = "button1";
            button1.Size = new Size(60, 60);
            button1.TabIndex = 14;
            button1.UseVisualStyleBackColor = false;
            button1.Click += ColorButton;
            // 
            // button3
            // 
            button3.BackColor = Color.Yellow;
            button3.Location = new Point(819, 37);
            button3.Name = "button3";
            button3.Size = new Size(60, 60);
            button3.TabIndex = 16;
            button3.UseVisualStyleBackColor = false;
            button3.Click += ColorButton;
            // 
            // button4
            // 
            button4.BackColor = Color.Orange;
            button4.Location = new Point(885, 37);
            button4.Name = "button4";
            button4.Size = new Size(60, 60);
            button4.TabIndex = 17;
            button4.UseVisualStyleBackColor = false;
            button4.Click += ColorButton;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Location = new Point(951, 37);
            button5.Name = "button5";
            button5.Size = new Size(60, 60);
            button5.TabIndex = 18;
            button5.UseVisualStyleBackColor = false;
            button5.Click += ColorButton;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkOrchid;
            button6.Location = new Point(1017, 37);
            button6.Name = "button6";
            button6.Size = new Size(60, 60);
            button6.TabIndex = 19;
            button6.UseVisualStyleBackColor = false;
            button6.Click += ColorButton;
            // 
            // button7
            // 
            button7.BackColor = Color.HotPink;
            button7.Location = new Point(1083, 37);
            button7.Name = "button7";
            button7.Size = new Size(60, 60);
            button7.TabIndex = 20;
            button7.UseVisualStyleBackColor = false;
            button7.Click += ColorButton;
            // 
            // button8
            // 
            button8.BackColor = Color.Blue;
            button8.Location = new Point(687, 37);
            button8.Name = "button8";
            button8.Size = new Size(60, 60);
            button8.TabIndex = 21;
            button8.UseVisualStyleBackColor = false;
            button8.Click += ColorButton;
            // 
            // button2
            // 
            button2.BackColor = Color.LimeGreen;
            button2.Location = new Point(753, 37);
            button2.Name = "button2";
            button2.Size = new Size(60, 60);
            button2.TabIndex = 22;
            button2.UseVisualStyleBackColor = false;
            button2.Click += ColorButton;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1173, 849);
            Controls.Add(button2);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(trackBar1);
            Controls.Add(toolStrip1);
            Controls.Add(pictureBox1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem brushesToolStripMenuItem;
        private ToolStripMenuItem eraToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButton3;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem penToolStripMenuItem;
        private ToolStripMenuItem eraserToolStripMenuItem;
        private ToolStripMenuItem squareToolStripMenuItem;
        private ToolStripMenuItem circleToolStripMenuItem;
        private ToolStripMenuItem textToolStripMenuItem;
        private ToolStripMenuItem fillToolStripMenuItem;
        private ToolStripMenuItem rectangleToolStripMenuItem;
        private ToolStripMenuItem triangleToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private TrackBar trackBar1;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button2;
        private ToolStripMenuItem antialiasingToolStripMenuItem;
    }
}

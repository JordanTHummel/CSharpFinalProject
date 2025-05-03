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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton2 = new ToolStripDropDownButton();
            loadToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            toolStripDropDownButton3 = new ToolStripDropDownButton();
            clearToolStripMenuItem = new ToolStripMenuItem();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            brushesToolStripMenuItem = new ToolStripMenuItem();
            penToolStripMenuItem = new ToolStripMenuItem();
            eraserToolStripMenuItem = new ToolStripMenuItem();
            eraToolStripMenuItem = new ToolStripMenuItem();
            squareToolStripMenuItem = new ToolStripMenuItem();
            circleToolStripMenuItem = new ToolStripMenuItem();
            textToolStripMenuItem = new ToolStripMenuItem();
            fillToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(17, 77);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(983, 517);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton2, toolStripDropDownButton3, toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.ShowItemToolTips = false;
            toolStrip1.Size = new Size(1026, 25);
            toolStrip1.TabIndex = 10;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton2
            // 
            toolStripDropDownButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton2.DropDownItems.AddRange(new ToolStripItem[] { loadToolStripMenuItem, saveToolStripMenuItem });
            toolStripDropDownButton2.Image = (Image)resources.GetObject("toolStripDropDownButton2.Image");
            toolStripDropDownButton2.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            toolStripDropDownButton2.Size = new Size(38, 22);
            toolStripDropDownButton2.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(100, 22);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += LoadButton_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(100, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += SaveButton_Click;
            // 
            // toolStripDropDownButton3
            // 
            toolStripDropDownButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton3.DropDownItems.AddRange(new ToolStripItem[] { clearToolStripMenuItem });
            toolStripDropDownButton3.Image = (Image)resources.GetObject("toolStripDropDownButton3.Image");
            toolStripDropDownButton3.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            toolStripDropDownButton3.Size = new Size(40, 22);
            toolStripDropDownButton3.Text = "Edit";
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(101, 22);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.Click += ClearButton_Click;
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { brushesToolStripMenuItem, eraToolStripMenuItem, textToolStripMenuItem, fillToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(48, 22);
            toolStripDropDownButton1.Text = "Tools";
            // 
            // brushesToolStripMenuItem
            // 
            brushesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { penToolStripMenuItem, eraserToolStripMenuItem });
            brushesToolStripMenuItem.Name = "brushesToolStripMenuItem";
            brushesToolStripMenuItem.Size = new Size(180, 22);
            brushesToolStripMenuItem.Text = "Brushes";
            brushesToolStripMenuItem.Click += brushToolStripMenuItem_Click;
            // 
            // penToolStripMenuItem
            // 
            penToolStripMenuItem.CheckOnClick = true;
            penToolStripMenuItem.Name = "penToolStripMenuItem";
            penToolStripMenuItem.Size = new Size(105, 22);
            penToolStripMenuItem.Text = "Pen";
            penToolStripMenuItem.Click += BrushButton_Click;
            // 
            // eraserToolStripMenuItem
            // 
            eraserToolStripMenuItem.Name = "eraserToolStripMenuItem";
            eraserToolStripMenuItem.Size = new Size(105, 22);
            eraserToolStripMenuItem.Text = "Eraser";
            eraserToolStripMenuItem.Click += EraserButton_Click;
            // 
            // eraToolStripMenuItem
            // 
            eraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { squareToolStripMenuItem, circleToolStripMenuItem });
            eraToolStripMenuItem.Name = "eraToolStripMenuItem";
            eraToolStripMenuItem.Size = new Size(180, 22);
            eraToolStripMenuItem.Text = "Shapes";
            // 
            // squareToolStripMenuItem
            // 
            squareToolStripMenuItem.Name = "squareToolStripMenuItem";
            squareToolStripMenuItem.Size = new Size(110, 22);
            squareToolStripMenuItem.Text = "Square";
            // 
            // circleToolStripMenuItem
            // 
            circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            circleToolStripMenuItem.Size = new Size(110, 22);
            circleToolStripMenuItem.Text = "Circle";
            // 
            // textToolStripMenuItem
            // 
            textToolStripMenuItem.Name = "textToolStripMenuItem";
            textToolStripMenuItem.Size = new Size(180, 22);
            textToolStripMenuItem.Text = "Text";
            // 
            // fillToolStripMenuItem
            // 
            fillToolStripMenuItem.CheckOnClick = true;
            fillToolStripMenuItem.Name = "fillToolStripMenuItem";
            fillToolStripMenuItem.Size = new Size(180, 22);
            fillToolStripMenuItem.Text = "Fill";
            fillToolStripMenuItem.Click += FillButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1026, 637);
            Controls.Add(toolStrip1);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
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
    }
}

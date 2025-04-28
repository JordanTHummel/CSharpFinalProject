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
            BrushButton = new Button();
            EraserButton = new Button();
            BrushColorButton = new Button();
            pictureBox1 = new PictureBox();
            SaveButton = new Button();
            LoadButton = new Button();
            ShapesButton = new Button();
            TextLabelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BrushButton
            // 
            BrushButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BrushButton.BackColor = Color.WhiteSmoke;
            BrushButton.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            BrushButton.FlatAppearance.BorderSize = 4;
            BrushButton.FlatStyle = FlatStyle.System;
            BrushButton.Font = new Font("Franklin Gothic Medium Cond", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BrushButton.ForeColor = SystemColors.ControlDarkDark;
            BrushButton.Location = new Point(24, 12);
            BrushButton.Name = "BrushButton";
            BrushButton.Size = new Size(111, 94);
            BrushButton.TabIndex = 0;
            BrushButton.Text = "Brush";
            BrushButton.UseVisualStyleBackColor = false;
            BrushButton.Click += this.BrushButton_Click;
            // 
            // EraserButton
            // 
            EraserButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            EraserButton.BackColor = Color.WhiteSmoke;
            EraserButton.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            EraserButton.FlatAppearance.BorderSize = 4;
            EraserButton.FlatStyle = FlatStyle.System;
            EraserButton.Font = new Font("Franklin Gothic Medium Cond", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EraserButton.ForeColor = SystemColors.ControlDarkDark;
            EraserButton.Location = new Point(160, 12);
            EraserButton.Name = "EraserButton";
            EraserButton.Size = new Size(111, 94);
            EraserButton.TabIndex = 1;
            EraserButton.Text = "Eraser";
            EraserButton.UseVisualStyleBackColor = false;
            EraserButton.Click += this.EraserButton_Click;
            // 
            // BrushColorButton
            // 
            BrushColorButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BrushColorButton.BackColor = Color.WhiteSmoke;
            BrushColorButton.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            BrushColorButton.FlatAppearance.BorderSize = 4;
            BrushColorButton.FlatStyle = FlatStyle.System;
            BrushColorButton.Font = new Font("Franklin Gothic Medium Cond", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BrushColorButton.ForeColor = SystemColors.ControlDarkDark;
            BrushColorButton.Location = new Point(296, 12);
            BrushColorButton.Name = "BrushColorButton";
            BrushColorButton.Size = new Size(145, 94);
            BrushColorButton.TabIndex = 2;
            BrushColorButton.Text = "Brush Color";
            BrushColorButton.UseVisualStyleBackColor = false;
            BrushColorButton.Click += this.BrushColorButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(24, 129);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1404, 860);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // SaveButton
            // 
            SaveButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SaveButton.BackColor = Color.WhiteSmoke;
            SaveButton.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            SaveButton.FlatAppearance.BorderSize = 4;
            SaveButton.FlatStyle = FlatStyle.System;
            SaveButton.Font = new Font("Franklin Gothic Medium Cond", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveButton.ForeColor = SystemColors.ControlDarkDark;
            SaveButton.Location = new Point(1318, 12);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(110, 94);
            SaveButton.TabIndex = 4;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += this.SaveButton_Click;
            // 
            // LoadButton
            // 
            LoadButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LoadButton.BackColor = Color.WhiteSmoke;
            LoadButton.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            LoadButton.FlatAppearance.BorderSize = 4;
            LoadButton.FlatStyle = FlatStyle.System;
            LoadButton.Font = new Font("Franklin Gothic Medium Cond", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoadButton.ForeColor = SystemColors.ControlDarkDark;
            LoadButton.Location = new Point(1188, 12);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(110, 94);
            LoadButton.TabIndex = 5;
            LoadButton.Text = "Load";
            LoadButton.UseVisualStyleBackColor = false;
            // 
            // ShapesButton
            // 
            ShapesButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ShapesButton.BackColor = Color.WhiteSmoke;
            ShapesButton.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            ShapesButton.FlatAppearance.BorderSize = 4;
            ShapesButton.FlatStyle = FlatStyle.System;
            ShapesButton.Font = new Font("Franklin Gothic Medium Cond", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShapesButton.ForeColor = SystemColors.ControlDarkDark;
            ShapesButton.Location = new Point(473, 12);
            ShapesButton.Name = "ShapesButton";
            ShapesButton.Size = new Size(122, 94);
            ShapesButton.TabIndex = 6;
            ShapesButton.Text = "Shapes";
            ShapesButton.UseVisualStyleBackColor = false;
            ShapesButton.Click += this.ShapesButton_Click;
            // 
            // TextLabelButton
            // 
            TextLabelButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TextLabelButton.BackColor = Color.WhiteSmoke;
            TextLabelButton.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            TextLabelButton.FlatAppearance.BorderSize = 4;
            TextLabelButton.FlatStyle = FlatStyle.System;
            TextLabelButton.Font = new Font("Franklin Gothic Medium Cond", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextLabelButton.ForeColor = SystemColors.ControlDarkDark;
            TextLabelButton.Location = new Point(625, 12);
            TextLabelButton.Name = "TextLabelButton";
            TextLabelButton.Size = new Size(122, 94);
            TextLabelButton.TabIndex = 7;
            TextLabelButton.Text = "Text";
            TextLabelButton.UseVisualStyleBackColor = false;
            TextLabelButton.Click += TextLabelButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1465, 1062);
            Controls.Add(TextLabelButton);
            Controls.Add(ShapesButton);
            Controls.Add(LoadButton);
            Controls.Add(SaveButton);
            Controls.Add(pictureBox1);
            Controls.Add(BrushColorButton);
            Controls.Add(EraserButton);
            Controls.Add(BrushButton);
            Name = "Form1";
            Text = "Painter? I hardly know her!";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BrushButton;
        private Button EraserButton;
        private Button BrushColorButton;
        private PictureBox pictureBox1;
        private Button SaveButton;
        private Button LoadButton;
        private Button ShapesButton;
        private Button TextLabelButton;
    }
}

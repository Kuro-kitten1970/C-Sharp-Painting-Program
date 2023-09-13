namespace Lab_Sheet_02
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSetValue = new System.Windows.Forms.Button();
            this.rbtArc = new System.Windows.Forms.RadioButton();
            this.rbtCircle = new System.Windows.Forms.RadioButton();
            this.rbtSquare = new System.Windows.Forms.RadioButton();
            this.rbtLine = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBrushSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtPenPink = new System.Windows.Forms.RadioButton();
            this.rbtPenBlack = new System.Windows.Forms.RadioButton();
            this.rbtPenGreen = new System.Windows.Forms.RadioButton();
            this.rbtPenYellow = new System.Windows.Forms.RadioButton();
            this.rbtPenBlue = new System.Windows.Forms.RadioButton();
            this.rbtPenRed = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(11, 9);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(119, 9);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnSetValue);
            this.panel1.Controls.Add(this.rbtArc);
            this.panel1.Controls.Add(this.rbtCircle);
            this.panel1.Controls.Add(this.rbtSquare);
            this.panel1.Controls.Add(this.rbtLine);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 60);
            this.panel1.TabIndex = 6;
            // 
            // btnSetValue
            // 
            this.btnSetValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSetValue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSetValue.Location = new System.Drawing.Point(152, 21);
            this.btnSetValue.Name = "btnSetValue";
            this.btnSetValue.Size = new System.Drawing.Size(75, 23);
            this.btnSetValue.TabIndex = 7;
            this.btnSetValue.Text = "Set";
            this.btnSetValue.UseVisualStyleBackColor = false;
            this.btnSetValue.Click += new System.EventHandler(this.btnSetValue_Click);
            // 
            // rbtArc
            // 
            this.rbtArc.AutoSize = true;
            this.rbtArc.Location = new System.Drawing.Point(87, 38);
            this.rbtArc.Name = "rbtArc";
            this.rbtArc.Size = new System.Drawing.Size(45, 20);
            this.rbtArc.TabIndex = 3;
            this.rbtArc.TabStop = true;
            this.rbtArc.Text = "Arc";
            this.rbtArc.UseVisualStyleBackColor = true;
            // 
            // rbtCircle
            // 
            this.rbtCircle.AutoSize = true;
            this.rbtCircle.Location = new System.Drawing.Point(87, 12);
            this.rbtCircle.Name = "rbtCircle";
            this.rbtCircle.Size = new System.Drawing.Size(59, 20);
            this.rbtCircle.TabIndex = 2;
            this.rbtCircle.TabStop = true;
            this.rbtCircle.Text = "Circle";
            this.rbtCircle.UseVisualStyleBackColor = true;
            // 
            // rbtSquare
            // 
            this.rbtSquare.AutoSize = true;
            this.rbtSquare.Location = new System.Drawing.Point(12, 37);
            this.rbtSquare.Name = "rbtSquare";
            this.rbtSquare.Size = new System.Drawing.Size(69, 20);
            this.rbtSquare.TabIndex = 1;
            this.rbtSquare.TabStop = true;
            this.rbtSquare.Text = "Square";
            this.rbtSquare.UseVisualStyleBackColor = true;
            // 
            // rbtLine
            // 
            this.rbtLine.AutoSize = true;
            this.rbtLine.Location = new System.Drawing.Point(12, 12);
            this.rbtLine.Name = "rbtLine";
            this.rbtLine.Size = new System.Drawing.Size(50, 20);
            this.rbtLine.TabIndex = 0;
            this.rbtLine.TabStop = true;
            this.rbtLine.Text = "Line";
            this.rbtLine.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.txtBrushSize);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.rbtPenPink);
            this.panel2.Controls.Add(this.rbtPenBlack);
            this.panel2.Controls.Add(this.rbtPenGreen);
            this.panel2.Controls.Add(this.rbtPenYellow);
            this.panel2.Controls.Add(this.rbtPenBlue);
            this.panel2.Controls.Add(this.rbtPenRed);
            this.panel2.Location = new System.Drawing.Point(240, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 60);
            this.panel2.TabIndex = 7;
            // 
            // txtBrushSize
            // 
            this.txtBrushSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtBrushSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrushSize.Location = new System.Drawing.Point(225, 32);
            this.txtBrushSize.Name = "txtBrushSize";
            this.txtBrushSize.Size = new System.Drawing.Size(67, 22);
            this.txtBrushSize.TabIndex = 7;
            this.txtBrushSize.Text = "5";
            this.txtBrushSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBrushSize.TextChanged += new System.EventHandler(this.txtBrushSize_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Brush Size";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // rbtPenPink
            // 
            this.rbtPenPink.AutoSize = true;
            this.rbtPenPink.Location = new System.Drawing.Point(158, 37);
            this.rbtPenPink.Name = "rbtPenPink";
            this.rbtPenPink.Size = new System.Drawing.Size(51, 20);
            this.rbtPenPink.TabIndex = 5;
            this.rbtPenPink.TabStop = true;
            this.rbtPenPink.Text = "Pink";
            this.rbtPenPink.UseVisualStyleBackColor = true;
            this.rbtPenPink.CheckedChanged += new System.EventHandler(this.rbtPenPink_CheckedChanged);
            // 
            // rbtPenBlack
            // 
            this.rbtPenBlack.AutoSize = true;
            this.rbtPenBlack.Location = new System.Drawing.Point(12, 11);
            this.rbtPenBlack.Name = "rbtPenBlack";
            this.rbtPenBlack.Size = new System.Drawing.Size(59, 20);
            this.rbtPenBlack.TabIndex = 4;
            this.rbtPenBlack.TabStop = true;
            this.rbtPenBlack.Text = "Black";
            this.rbtPenBlack.UseVisualStyleBackColor = true;
            this.rbtPenBlack.CheckedChanged += new System.EventHandler(this.rbtPenBlack_CheckedChanged);
            // 
            // rbtPenGreen
            // 
            this.rbtPenGreen.AutoSize = true;
            this.rbtPenGreen.Location = new System.Drawing.Point(87, 38);
            this.rbtPenGreen.Name = "rbtPenGreen";
            this.rbtPenGreen.Size = new System.Drawing.Size(62, 20);
            this.rbtPenGreen.TabIndex = 3;
            this.rbtPenGreen.TabStop = true;
            this.rbtPenGreen.Text = "Green";
            this.rbtPenGreen.UseVisualStyleBackColor = true;
            this.rbtPenGreen.CheckedChanged += new System.EventHandler(this.rbtPenGreen_CheckedChanged);
            // 
            // rbtPenYellow
            // 
            this.rbtPenYellow.AutoSize = true;
            this.rbtPenYellow.Location = new System.Drawing.Point(87, 12);
            this.rbtPenYellow.Name = "rbtPenYellow";
            this.rbtPenYellow.Size = new System.Drawing.Size(65, 20);
            this.rbtPenYellow.TabIndex = 2;
            this.rbtPenYellow.TabStop = true;
            this.rbtPenYellow.Text = "Yellow";
            this.rbtPenYellow.UseVisualStyleBackColor = true;
            this.rbtPenYellow.CheckedChanged += new System.EventHandler(this.rbtPenYellow_CheckedChanged);
            // 
            // rbtPenBlue
            // 
            this.rbtPenBlue.AutoSize = true;
            this.rbtPenBlue.Location = new System.Drawing.Point(12, 37);
            this.rbtPenBlue.Name = "rbtPenBlue";
            this.rbtPenBlue.Size = new System.Drawing.Size(52, 20);
            this.rbtPenBlue.TabIndex = 1;
            this.rbtPenBlue.TabStop = true;
            this.rbtPenBlue.Text = "Blue";
            this.rbtPenBlue.UseVisualStyleBackColor = true;
            this.rbtPenBlue.CheckedChanged += new System.EventHandler(this.rbtPenBlue_CheckedChanged);
            // 
            // rbtPenRed
            // 
            this.rbtPenRed.AutoSize = true;
            this.rbtPenRed.Location = new System.Drawing.Point(158, 11);
            this.rbtPenRed.Name = "rbtPenRed";
            this.rbtPenRed.Size = new System.Drawing.Size(51, 20);
            this.rbtPenRed.TabIndex = 0;
            this.rbtPenRed.TabStop = true;
            this.rbtPenRed.Text = "Red";
            this.rbtPenRed.UseVisualStyleBackColor = true;
            this.rbtPenRed.CheckedChanged += new System.EventHandler(this.rbtPenRed_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(545, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(441, 60);
            this.panel3.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painting Program";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtArc;
        private System.Windows.Forms.RadioButton rbtCircle;
        private System.Windows.Forms.RadioButton rbtSquare;
        private System.Windows.Forms.RadioButton rbtLine;
        private System.Windows.Forms.Button btnSetValue;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtPenPink;
        private System.Windows.Forms.RadioButton rbtPenBlack;
        private System.Windows.Forms.RadioButton rbtPenGreen;
        private System.Windows.Forms.RadioButton rbtPenYellow;
        private System.Windows.Forms.RadioButton rbtPenBlue;
        private System.Windows.Forms.RadioButton rbtPenRed;
        private System.Windows.Forms.TextBox txtBrushSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
    }
}


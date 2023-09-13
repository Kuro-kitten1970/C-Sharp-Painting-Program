using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace Lab_Sheet_02
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public byte rbtState { get; set; }

        private string[] lineArray;
        private string[] squareArray;
        private string[] circleArray;
        private string[] arcArray;
        List<string> list = new List<string>();

        private int x1, y1, x2, y2, w, h, strAngle, swpAngle;
        private int brushSize = 5;
        private Color color = Color.Black;
        private Pen colorPen;

        private void btnSave_Click(object sender, EventArgs e)
        {
            string dir = @"./saves";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            WriteSaves();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            ReadSaves();
        }

        private void btnSetValue_Click(object sender, EventArgs e)
        {
            SetModeForm setModeForm = new SetModeForm();

            if (rbtLine.Checked)
            {
                rbtState = 0;
            }
            else if (rbtSquare.Checked)
            {
                rbtState = 1;
            }
            else if (rbtCircle.Checked)
            {
                rbtState = 2;
            }
            else if (rbtArc.Checked)
            {
                rbtState = 3;
            }
            else
            {
                MessageBox.Show("Pls Select Your Pen Mode First.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            setModeForm.rtbValue = this.rbtState;

            DialogResult result = setModeForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                x1 = setModeForm.X1;
                y1 = setModeForm.Y1;
                x2 = setModeForm.X2;
                y2 = setModeForm.Y2;
                w = setModeForm.W;
                h = setModeForm.H;
                strAngle = setModeForm.STRAngle;
                swpAngle = setModeForm.SWPAngle;

                if (rbtLine.Checked)
                {
                    string data =
                        x1.ToString() + "," +
                        y1.ToString() + "," +
                        x2.ToString() + "," +
                        y2.ToString() + "," +
                        color.ToKnownColor() + "," +
                        brushSize.ToString() + "\n";

                    list.Add(data);
                    lineArray = list.ToArray();
                    DrawingLine(x1, y1, x2, y2);
                }
                else if (rbtSquare.Checked)
                {
                    string data =
                        x1.ToString() + "," +
                        y1.ToString() + "," +
                        w.ToString() + "," +
                        h.ToString() + "," +
                        color.ToKnownColor() + "," +
                        brushSize.ToString() + "\n";

                    list.Add(data);
                    squareArray = list.ToArray();
                    DrawingRectangle(x1, y1, w, h);
                }
                else if (rbtCircle.Checked)
                {
                    string data =
                        x1.ToString() + "," +
                        y1.ToString() + "," +
                        w.ToString() + "," +
                        h.ToString() + "," +
                        color.ToKnownColor() + "," +
                        brushSize.ToString() + "\n";

                    list.Add(data);
                    circleArray = list.ToArray();
                    DrawingCircle(x1, y1, w, h);
                }
                else if (rbtArc.Checked)
                {
                    string data =
                        x1.ToString() + "," +
                        y1.ToString() + "," +
                        w.ToString() + "," +
                        h.ToString() + "," +
                        strAngle.ToString() + "," +
                        swpAngle.ToString() + "," +
                        color.ToKnownColor() + "," +
                        brushSize.ToString() + "\n";

                    list.Add(data);
                    arcArray = list.ToArray();
                    DrawingArc(x1, y1, w, h, strAngle, swpAngle);
                }
                else
                {
                    return;
                }
            }

            setModeForm.Dispose();
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            h = e.X - x1;
            w = e.Y - y1;
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void DrawingLine(int x1, int y1, int x2, int y2)
        {
            Graphics graphics = this.CreateGraphics();
            colorPen = new Pen(color, brushSize);
            graphics.DrawLine(colorPen, x1, y1 + 60, x2, y2 +60);
        }

        private void DrawingRectangle(int x1, int y1, int w, int h)
        {
            Graphics graphics = this.CreateGraphics();
            colorPen = new Pen(color, brushSize);
            graphics.DrawRectangle(colorPen, x1, y1 + 60, w, h);
        }

        private void DrawingCircle(int x1, int y1, int w, int h)
        {
            Graphics graphics = this.CreateGraphics();
            colorPen = new Pen(color, brushSize);
            graphics.DrawEllipse(colorPen, x1, y1 +60, w, h);
        }

        private void DrawingArc(int x1, int y1, int w, int h, int strAngle, int swpAngle)
        {
            Graphics graphics = this.CreateGraphics();
            colorPen = new Pen(color, brushSize);
            graphics.DrawArc(colorPen, x1, y1 + 60, w, h, strAngle, swpAngle);
        }

        private void rbtPenRed_CheckedChanged(object sender, EventArgs e)
        {
            colorPen.Color = Color.Red;
        }

        private void rbtPenBlue_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Blue;
        }

        private void rbtPenYellow_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Yellow;
        }

        private void rbtPenGreen_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Green;
        }

        private void rbtPenBlack_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Black;
        }

        private void rbtPenPink_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Pink;
        }

        private void txtBrushSize_TextChanged(object sender, EventArgs e)
        {
            if (txtBrushSize.Text != "")
            {
                brushSize = Convert.ToInt32(txtBrushSize.Text);
            }
        }

        private void ReadSaves()
        {
            string savePath = @"./saves/";
            //Line
            using (StreamReader srLine = File.OpenText(savePath + "line.txt"))
            {
                string[] lines = File.ReadAllLines(savePath + "line.txt");
                string[] data = new string[6];
                foreach (string line in lines)
                {
                    if (line == null || line == "")
                    {
                        continue;
                    }

                    if (line.StartsWith("//"))
                    {
                        continue;
                    }

                    data = line.Split(',');
                    x1 = Convert.ToInt32(data[0].Trim());
                    y1 = Convert.ToInt32(data[1].Trim());
                    x2 = Convert.ToInt32(data[2].Trim());
                    y2 = Convert.ToInt32(data[3].Trim());
                    color = ColorTranslator.FromHtml(data[4].Trim());
                    brushSize = Convert.ToInt32(data[5].Trim());

                    DrawingLine(x1, y1, x2, y2);
                }
            }
            //Square
            using (StreamReader srSquare = File.OpenText(savePath + "square.txt"))
            {
                string[] lines = File.ReadAllLines(savePath + "square.txt");
                string[] data = new string[6];
                foreach (string line in lines)
                {
                    if (line == null || line == "")
                    {
                        continue;
                    }

                    if (line.StartsWith("//"))
                    {
                        continue;
                    }

                    data = line.Split(',');
                    x1 = Convert.ToInt32(data[0].Trim());
                    y1 = Convert.ToInt32(data[1].Trim());
                    w = Convert.ToInt32(data[2].Trim());
                    h = Convert.ToInt32(data[3].Trim());
                    color = ColorTranslator.FromHtml(data[4].Trim());
                    brushSize = Convert.ToInt32(data[5].Trim());

                    DrawingRectangle(x1, y1, w, h);
                }
            }
            //Circle
            using (StreamReader srCircle = File.OpenText(savePath + "circle.txt"))
            {
                string[] lines = File.ReadAllLines(savePath + "circle.txt");
                string[] data = new string[6];
                foreach (string line in lines)
                {
                    if (line == null || line == "")
                    {
                        continue;
                    }

                    if (line.StartsWith("//"))
                    {
                        continue;
                    }

                    data = line.Split(',');
                    x1 = Convert.ToInt32(data[0].Trim());
                    y1 = Convert.ToInt32(data[1].Trim());
                    w = Convert.ToInt32(data[2].Trim());
                    h = Convert.ToInt32(data[3].Trim());
                    color = ColorTranslator.FromHtml(data[4].Trim());
                    brushSize = Convert.ToInt32(data[5].Trim());

                    DrawingCircle(x1, y1, w, h);
                }
            }
            //Arc
            using (StreamReader srArc = File.OpenText(savePath + "arc.txt"))
            {
                string[] lines = File.ReadAllLines(savePath + "arc.txt");
                string[] data = new string[8];
                foreach (string line in lines)
                {
                    if (line == null || line == "")
                    {
                        continue;
                    }

                    if (line.StartsWith("//"))
                    {
                        continue;
                    }

                    data = line.Split(',');
                    x1 = Convert.ToInt32(data[0].Trim());
                    y1 = Convert.ToInt32(data[1].Trim());
                    h = Convert.ToInt32(data[2].Trim());
                    w = Convert.ToInt32(data[3].Trim());
                    strAngle = Convert.ToInt32(data[4].Trim());
                    swpAngle = Convert.ToInt32(data[5].Trim());
                    color = ColorTranslator.FromHtml(data[6].Trim());
                    brushSize = Convert.ToInt32(data[7].Trim());

                    DrawingArc(x1, y1, w, h, strAngle, swpAngle);
                }
            }
        }

        private void WriteSaves()
        {
            string savePath = @"./saves/";

            using (StreamWriter swLine = File.AppendText(savePath + "line.txt"))
            {
                if (lineArray != null)
                {
                    for (int i = 0; i < lineArray.Length; i++)
                    {
                        swLine.WriteLine(lineArray[i]);
                    }
                }
            }

            using (StreamWriter swSquare = File.AppendText(savePath + "square.txt"))
            {
                if (squareArray != null)
                {
                    for (int i = 0; i < squareArray.Length; i++)
                    {
                        swSquare.WriteLine(squareArray[i]);
                    }
                }
            }

            using (StreamWriter swCircle = File.AppendText(savePath + "circle.txt"))
            {
                if (circleArray != null)
                {
                    for (int i = 0; i < circleArray.Length; i++)
                    {
                        swCircle.WriteLine(circleArray[i]);
                    }
                }
            }

            using (StreamWriter swArc = File.AppendText(savePath + "arc.txt"))
            {
                if (arcArray != null)
                {
                    for (int i = 0; i < arcArray.Length; i++)
                    {
                        swArc.WriteLine(arcArray[i]);
                    }
                }
            }
        }
    }
}

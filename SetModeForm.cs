using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Sheet_02
{
    public partial class SetModeForm : Form
    {
        public SetModeForm()
        {
            InitializeComponent();
        }

        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }
        public int W { get; set; }
        public int H { get; set; }
        public int STRAngle { get; set; }
        public int SWPAngle { get; set; }
        public byte rtbValue { get; set; }

        private int x1, y1, x2, y2, w, h, strAngle, swpAngle;

        private void SetModeForm_Load(object sender, EventArgs e)
        {
            hideTXTAndLBL(false);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                x1 = Convert.ToInt32(txtXInput.Text);
                y1 = Convert.ToInt32(txtYInput.Text);
                x2 = Convert.ToInt32(txtWidthInput.Text);
                y2 = Convert.ToInt32(txtHeightInput.Text);
                w = Convert.ToInt32(txtWidthInput.Text);
                h = Convert.ToInt32(txtHeightInput.Text);
                strAngle = Convert.ToInt32(txtStartAngleInput.Text);
                swpAngle = Convert.ToInt32(txtSweepAngleInput.Text);
            }
            catch { }

            X1 = x1; Y1 = y1; X2 = x2; Y2 = y2; W = w; H = h;
            STRAngle = strAngle; SWPAngle = swpAngle;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
            Close();
        }

        private void hideTXTAndLBL(bool state)
        {
            if (rtbValue == 0) //Line
            {
                label3.Text = "X2";
                label4.Text = "Y2";
                label5.Visible = state;
                label6.Visible = state;
                txtStartAngleInput.Visible = state;
                txtSweepAngleInput.Visible = state;
            }
            else if (rtbValue == 1 || rtbValue == 2) //Square or Circle
            {
                label3.Text = "Width";
                label4.Text = "Height";
                label5.Visible = state;
                label6.Visible = state;
                txtStartAngleInput.Visible = state;
                txtSweepAngleInput.Visible = state;
            }
            else if (rtbValue == 3) //Arc
            {
                label3.Text = "Width";
                label4.Text = "Height";
            }
            else
            {
                return;
            }
        }
    }
}

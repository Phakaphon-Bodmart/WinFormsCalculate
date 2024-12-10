using System.Xml.Linq;

namespace WinFormsCalculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("ยินดีต้อนรับสู่ขุมนรก", "Welcome to the hell");
            clearForm();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("ยินดีต้อนรับสู่สวรรค์", "Welcome to the heaven!!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No)
            {
                e.Cancel = true; // ยกเลิกคำสั่งปิด Form
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Method แบบ void สำหรับแสดงผล
        private void DisplayResult(string result)
        {
            lblResult.Text = result;
        }

        // Method แบบ return สำหรับการคำนวณพื้นที่วงกลม
        private double CalculateCircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        private void btnCircleArea_Click(object sender, EventArgs e)
        {
            // รับค่า input
            double radius;
            if (!double.TryParse(txtRadius.Text, out radius))
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "Please, try again!!");
                txtRadius.Focus();
                txtRadius.SelectAll();
                return;
            }

            // คำนวณ
            double circleArea = CalculateCircleArea(radius);

            // แสดงผล
            DisplayResult(circleArea.ToString("0.00"));
            txtRadius.Focus();
            txtRadius.SelectAll();
        }

        // Method แบบ return สำหรับการคำนวณพื้นที่สามเหลี่ยม
        private double CalculateTriangleArea(double height, double width)
        {
            return 0.5 * height * width;
        }

        private void btnTriangleArea_Click(object sender, EventArgs e)
        {
            // รับค่า input
            double height, width;
            if (!double.TryParse(txtHeight.Text, out height))
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "Please, try again!!");
                txtHeight.Focus();
                txtHeight.SelectAll();
                return;
            }

            if (!double.TryParse(txtWidth.Text, out width))
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "Please, try again!!");
                txtWidth.Focus();
                txtWidth.SelectAll();
                return;
            }

            // คำนวณ
            double triangleArea = CalculateTriangleArea(height, width);

            // แสดงผล
            DisplayResult(triangleArea.ToString("0.00"));
            txtHeight.Focus();
            txtHeight.SelectAll();
        }

        // Method แบบ return สำหรับการคำนวณพื้นที่หกเหลี่ยม
        private double CalculateHexagonArea(double sideLength)
        {
            return (3 * Math.Sqrt(3) / 2) * Math.Pow(sideLength, 2);
        }

        private void btnHexagonArea_Click(object sender, EventArgs e)
        {
            // รับค่า input
            double sideLength;
            if (!double.TryParse(txtHexagonWidth.Text, out sideLength))
            {
                MessageBox.Show("กรุณาใส่ค่าความยาวด้านที่ถูกต้อง", "Please, try again!!");
                txtHexagonWidth.Focus();
                txtHexagonWidth.SelectAll();
                return;
            }

            // คำนวณ
            double hexagonArea = CalculateHexagonArea(sideLength);

            // แสดงผล
            DisplayResult(hexagonArea.ToString("0.00"));
            txtHexagonWidth.Focus();
            txtHexagonWidth.SelectAll();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }
        private void clearForm()
        {
            txtRadius.TextAlign = HorizontalAlignment.Center;   //จัดชิดขวา
            txtHeight.TextAlign = HorizontalAlignment.Center;
            txtWidth.TextAlign = HorizontalAlignment.Center;
            txtHexagonWidth.TextAlign = HorizontalAlignment.Center;

            txtRadius.Text = "0";
            txtHeight.Text = "0";
            txtWidth.Text = "0";
            txtHexagonWidth.Text = "0";
            lblResult.Text = "";
        }
    }
}

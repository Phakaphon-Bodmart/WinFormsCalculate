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
            MessageBox.Show("ยินดีต้อนรับสู่ขุมนรก,Welcome to the hell");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("ยินดีต้อนรับสู่สวรรค์", "Welcome to the heaven!!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No)
            {
                e.Cancel = true; //ยกเลิกคำสั่งปิด Form
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCircleArea_Click(object sender, EventArgs e)
        {
            //input รับค่าจาก Textboxชื่อ txtRadius (แปลงชนิดข้อมูลเป็น Double)
            double Radius = 0;
            //Radius = Convert.ToDouble(txtRadius.Text);
            if (double.TryParse(txtRadius.Text, out Radius) == false)
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "Please,try again!!");
                txtRadius.Focus();  //ให้มี Cursor ที่ Textbox
                txtRadius.SelectAll();  //ให้ Select (คลุมตัวอักษร)ข้อความใน Textbox
                return;
            }

            //process คำนวณพื้นที่ สูตร PI*r*r
            double CircleArea = Math.PI * Math.Pow(Radius, 2);
            //Math.PI ให้ค่า pi
            //Math.POW(X,Y)  X ยกกำลัง Y

            //output นำไปแสดงผลที่ txtResult
            lblResult.Text = CircleArea.ToString("0.00");
            txtRadius.Focus();
            txtRadius.SelectAll();
        }

        private void btnTriangleArea_Click(object sender, EventArgs e)
        {
            //input
            double Height = 0, Width = 0;
            if (double.TryParse(txtHeight.Text, out Height) == false)
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "Please,try again!!");
                txtHeight.Focus();  //ให้มี Cursor ที่ Textbox
                txtHeight.SelectAll();  //ให้ Select (คลุมตัวอักษร)ข้อความใน Textbox
                return;
            }
            if (double.TryParse(txtWidth.Text, out Width) == false)
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "Please,try again!!");
                txtWidth.Focus();  //ให้มี Cursor ที่ Textbox
                txtWidth.SelectAll();  //ให้ Select (คลุมตัวอักษร)ข้อความใน Textbox
                return;
            }
            //process
            double TriangleArea = 0.5 * Height * Width;
            //output
            lblResult.Text = TriangleArea.ToString("0.00");
            txtHeight.Focus();
            txtHeight.SelectAll();
        }

        private void btnHexagonArea_Click(object sender, EventArgs e)
        {
            // Input
            double Hexagon;
            if (!double.TryParse(txtHexagonWidth.Text, out Hexagon) || Hexagon <= 0)
            {
                MessageBox.Show("กรุณาใส่ค่าความยาวด้านที่ถูกต้อง", "Please,try again!!");
                txtHexagonWidth.Focus();
                txtHexagonWidth.SelectAll();
                return;
            }

            // Process
            double hexagonArea = (3 * Math.Sqrt(3) / 2) * Math.Pow(Hexagon, 2);

            // Output
            lblResult.Text = hexagonArea.ToString("0.00"); // แสดงผลในรูปแบบทศนิยม 2 ตำแหน่ง
            txtHexagonWidth.Focus();
            txtHexagonWidth.SelectAll();
        }

    }
}

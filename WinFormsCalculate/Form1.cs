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
            MessageBox.Show("�Թ�յ�͹�Ѻ������á", "Welcome to the hell");
            clearForm();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("�Թ�յ�͹�Ѻ������ä�", "Welcome to the heaven!!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No)
            {
                e.Cancel = true; // ¡��ԡ����觻Դ Form
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Method Ẻ void ����Ѻ�ʴ���
        private void DisplayResult(string result)
        {
            lblResult.Text = result;
        }

        // Method Ẻ return ����Ѻ��äӹǳ��鹷��ǧ���
        private double CalculateCircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        private void btnCircleArea_Click(object sender, EventArgs e)
        {
            // �Ѻ��� input
            double radius;
            if (!double.TryParse(txtRadius.Text, out radius))
            {
                MessageBox.Show("��͡���������١��ͧ", "Please, try again!!");
                txtRadius.Focus();
                txtRadius.SelectAll();
                return;
            }

            // �ӹǳ
            double circleArea = CalculateCircleArea(radius);

            // �ʴ���
            DisplayResult(circleArea.ToString("0.00"));
            txtRadius.Focus();
            txtRadius.SelectAll();
        }

        // Method Ẻ return ����Ѻ��äӹǳ��鹷������������
        private double CalculateTriangleArea(double height, double width)
        {
            return 0.5 * height * width;
        }

        private void btnTriangleArea_Click(object sender, EventArgs e)
        {
            // �Ѻ��� input
            double height, width;
            if (!double.TryParse(txtHeight.Text, out height))
            {
                MessageBox.Show("��͡���������١��ͧ", "Please, try again!!");
                txtHeight.Focus();
                txtHeight.SelectAll();
                return;
            }

            if (!double.TryParse(txtWidth.Text, out width))
            {
                MessageBox.Show("��͡���������١��ͧ", "Please, try again!!");
                txtWidth.Focus();
                txtWidth.SelectAll();
                return;
            }

            // �ӹǳ
            double triangleArea = CalculateTriangleArea(height, width);

            // �ʴ���
            DisplayResult(triangleArea.ToString("0.00"));
            txtHeight.Focus();
            txtHeight.SelectAll();
        }

        // Method Ẻ return ����Ѻ��äӹǳ��鹷��ˡ�������
        private double CalculateHexagonArea(double sideLength)
        {
            return (3 * Math.Sqrt(3) / 2) * Math.Pow(sideLength, 2);
        }

        private void btnHexagonArea_Click(object sender, EventArgs e)
        {
            // �Ѻ��� input
            double sideLength;
            if (!double.TryParse(txtHexagonWidth.Text, out sideLength))
            {
                MessageBox.Show("��س�����Ҥ�����Ǵ�ҹ���١��ͧ", "Please, try again!!");
                txtHexagonWidth.Focus();
                txtHexagonWidth.SelectAll();
                return;
            }

            // �ӹǳ
            double hexagonArea = CalculateHexagonArea(sideLength);

            // �ʴ���
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
            txtRadius.TextAlign = HorizontalAlignment.Center;   //�Ѵ�Դ���
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

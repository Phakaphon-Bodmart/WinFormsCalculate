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
            MessageBox.Show("�Թ�յ�͹�Ѻ������á,Welcome to the hell");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("�Թ�յ�͹�Ѻ������ä�", "Welcome to the heaven!!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No)
            {
                e.Cancel = true; //¡��ԡ����觻Դ Form
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCircleArea_Click(object sender, EventArgs e)
        {
            //input �Ѻ��Ҩҡ Textbox���� txtRadius (�ŧ��Դ�������� Double)
            double Radius = 0;
            //Radius = Convert.ToDouble(txtRadius.Text);
            if (double.TryParse(txtRadius.Text, out Radius) == false)
            {
                MessageBox.Show("��͡���������١��ͧ", "Please,try again!!");
                txtRadius.Focus();  //����� Cursor ��� Textbox
                txtRadius.SelectAll();  //��� Select (��������ѡ��)��ͤ���� Textbox
                return;
            }

            //process �ӹǳ��鹷�� �ٵ� PI*r*r
            double CircleArea = Math.PI * Math.Pow(Radius, 2);
            //Math.PI ����� pi
            //Math.POW(X,Y)  X ¡���ѧ Y

            //output ����ʴ��ŷ�� txtResult
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
                MessageBox.Show("��͡���������١��ͧ", "Please,try again!!");
                txtHeight.Focus();  //����� Cursor ��� Textbox
                txtHeight.SelectAll();  //��� Select (��������ѡ��)��ͤ���� Textbox
                return;
            }
            if (double.TryParse(txtWidth.Text, out Width) == false)
            {
                MessageBox.Show("��͡���������١��ͧ", "Please,try again!!");
                txtWidth.Focus();  //����� Cursor ��� Textbox
                txtWidth.SelectAll();  //��� Select (��������ѡ��)��ͤ���� Textbox
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
                MessageBox.Show("��س�����Ҥ�����Ǵ�ҹ���١��ͧ", "Please,try again!!");
                txtHexagonWidth.Focus();
                txtHexagonWidth.SelectAll();
                return;
            }

            // Process
            double hexagonArea = (3 * Math.Sqrt(3) / 2) * Math.Pow(Hexagon, 2);

            // Output
            lblResult.Text = hexagonArea.ToString("0.00"); // �ʴ�����ٻẺ�ȹ��� 2 ���˹�
            txtHexagonWidth.Focus();
            txtHexagonWidth.SelectAll();
        }

    }
}

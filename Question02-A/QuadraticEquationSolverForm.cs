namespace Question02_A
{
    public partial class QuadraticEquationSolverForm : Form
    {

        public QuadraticEquationSolverForm()
        {
            InitializeComponent();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txba.Text);
                double b = double.Parse(txbb.Text);
                double c = double.Parse(txbc.Text);

                // In ra phương trình người dùng nhập
                string equation = $"{a}x² + {b}x + {c} = 0";

                // Giải phương trình
                string result = QuadraticEquationSolver.SolveQuadratic(a, b, c);

                // Hiển thị phương trình + kết quả
                txtQuadraticEquation.Text = equation;
                txbResult.Text = result;
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txba.Clear();
            txbb.Clear();
            txbc.Clear();
            txtQuadraticEquation.Clear();
            txbResult.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void QuadraticEquationSolverForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // chặn tiếng "beep"

                // Nếu đang ở ô nhập c thì bấm Enter sẽ gọi nút Giải
                if (this.ActiveControl == txbc)
                {
                    btnSolve.PerformClick();
                }
                else
                {
                    // Còn lại thì Enter hoạt động như Tab
                    this.SelectNextControl(this.ActiveControl, true, true, true, true);
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnExit.PerformClick();
            }
            if (e.KeyCode == Keys.R)
            {
                btnClear.PerformClick();
            }
        }
    }
}

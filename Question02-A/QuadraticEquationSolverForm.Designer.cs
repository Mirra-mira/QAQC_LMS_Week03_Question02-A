namespace Question02_A
{
    partial class QuadraticEquationSolverForm
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
            QuadraticEquationSolverLb = new Label();
            lbla = new Label();
            lblb = new Label();
            lblc = new Label();
            txba = new TextBox();
            txbb = new TextBox();
            txbc = new TextBox();
            btnClear = new Button();
            btnSolve = new Button();
            btnExit = new Button();
            lblResult = new Label();
            txtQuadraticEquation = new TextBox();
            txbResult = new RichTextBox();
            SuspendLayout();
            // 
            // QuadraticEquationSolverLb
            // 
            QuadraticEquationSolverLb.AutoSize = true;
            QuadraticEquationSolverLb.Font = new Font("Segoe UI", 20F);
            QuadraticEquationSolverLb.Location = new Point(109, 60);
            QuadraticEquationSolverLb.Name = "QuadraticEquationSolverLb";
            QuadraticEquationSolverLb.Size = new Size(582, 46);
            QuadraticEquationSolverLb.TabIndex = 13;
            QuadraticEquationSolverLb.Text = "Chương Trình Giải Phương Trình Bậc 2";
            // 
            // lbla
            // 
            lbla.AutoSize = true;
            lbla.Location = new Point(168, 183);
            lbla.Name = "lbla";
            lbla.Size = new Size(60, 20);
            lbla.TabIndex = 6;
            lbla.Text = "Nhập a:";
            // 
            // lblb
            // 
            lblb.AutoSize = true;
            lblb.Location = new Point(168, 231);
            lblb.Name = "lblb";
            lblb.Size = new Size(61, 20);
            lblb.TabIndex = 8;
            lblb.Text = "Nhập b:";
            // 
            // lblc
            // 
            lblc.AutoSize = true;
            lblc.Location = new Point(168, 279);
            lblc.Name = "lblc";
            lblc.Size = new Size(59, 20);
            lblc.TabIndex = 7;
            lblc.Text = "Nhập c:";
            // 
            // txba
            // 
            txba.Location = new Point(238, 176);
            txba.Name = "txba";
            txba.Size = new Size(125, 27);
            txba.TabIndex = 0;
            // 
            // txbb
            // 
            txbb.Location = new Point(239, 224);
            txbb.Name = "txbb";
            txbb.Size = new Size(125, 27);
            txbb.TabIndex = 1;
            // 
            // txbc
            // 
            txbc.Location = new Point(237, 272);
            txbc.Name = "txbc";
            txbc.Size = new Size(125, 27);
            txbc.TabIndex = 2;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(348, 397);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 4;
            btnClear.Text = "Đặt lại";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSolve
            // 
            btnSolve.Location = new Point(168, 397);
            btnSolve.Name = "btnSolve";
            btnSolve.Size = new Size(94, 29);
            btnSolve.TabIndex = 3;
            btnSolve.Text = "Giải";
            btnSolve.UseVisualStyleBackColor = true;
            btnSolve.Click += btnSolve_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(527, 397);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 5;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(169, 320);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(63, 20);
            lblResult.TabIndex = 10;
            lblResult.Text = "Kết quả:";
            // 
            // txtQuadraticEquation
            // 
            txtQuadraticEquation.BackColor = SystemColors.Control;
            txtQuadraticEquation.BorderStyle = BorderStyle.None;
            txtQuadraticEquation.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtQuadraticEquation.Location = new Point(169, 125);
            txtQuadraticEquation.Name = "txtQuadraticEquation";
            txtQuadraticEquation.ReadOnly = true;
            txtQuadraticEquation.Size = new Size(453, 31);
            txtQuadraticEquation.TabIndex = 11;
            txtQuadraticEquation.TextAlign = HorizontalAlignment.Center;
            // 
            // txbResult
            // 
            txbResult.BorderStyle = BorderStyle.FixedSingle;
            txbResult.Location = new Point(237, 313);
            txbResult.Name = "txbResult";
            txbResult.Size = new Size(384, 61);
            txbResult.TabIndex = 14;
            txbResult.Text = "";
            // 
            // QuadraticEquationSolverForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(txbResult);
            Controls.Add(txtQuadraticEquation);
            Controls.Add(lblResult);
            Controls.Add(btnExit);
            Controls.Add(btnSolve);
            Controls.Add(btnClear);
            Controls.Add(txbc);
            Controls.Add(txbb);
            Controls.Add(txba);
            Controls.Add(lblc);
            Controls.Add(lblb);
            Controls.Add(lbla);
            Controls.Add(QuadraticEquationSolverLb);
            KeyPreview = true;
            Name = "QuadraticEquationSolverForm";
            Text = "Chương Trình Giải Phương Trình Bậc 2";
            KeyDown += QuadraticEquationSolverForm_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label QuadraticEquationSolverLb;
        private Label lbla;
        private Label lblb;
        private Label lblc;
        private TextBox txba;
        private TextBox txbb;
        private TextBox txbc;
        private Button btnClear;
        private Button btnSolve;
        private Button btnExit;
        private Label lblResult;
        private TextBox txtQuadraticEquation;
        private RichTextBox txbResult;
    }
}

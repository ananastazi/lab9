using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP
{
    public partial class Form1 : Form, IParallelogramView
    {
        private ParallelogramPresenter presenter;

        private TextBox txtA, txtB, txtAngle;
        private Button btnCalculateHeight, btnCalculateArea;
        private Label lblResult;

        public Form1()
        {
            InitializeComponent();

            presenter = new ParallelogramPresenter(this, new Parallelogram());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtA = new TextBox();
            txtB = new TextBox();
            txtAngle = new TextBox();
            btnCalculateHeight = new Button();
            btnCalculateArea = new Button();
            lblResult = new Label();

            // Set properties for txtA
            txtA.Location = new System.Drawing.Point(20, 20);
            txtA.Size = new System.Drawing.Size(100, 20);

            // Set properties for txtB
            txtB.Location = new System.Drawing.Point(20, 50);
            txtB.Size = new System.Drawing.Size(100, 20);

            // Set properties for txtAngle
            txtAngle.Location = new System.Drawing.Point(20, 80);
            txtAngle.Size = new System.Drawing.Size(100, 20);

            // Set properties for btnCalculateHeight
            btnCalculateHeight.Location = new System.Drawing.Point(20, 110);
            btnCalculateHeight.Size = new System.Drawing.Size(100, 23);
            btnCalculateHeight.Text = "Calculate Height";
            btnCalculateHeight.Click += new EventHandler(clickOnButton1);

            // Set properties for btnCalculateArea
            btnCalculateArea.Location = new System.Drawing.Point(140, 110);
            btnCalculateArea.Size = new System.Drawing.Size(100, 23);
            btnCalculateArea.Text = "Calculate Square";
            btnCalculateArea.Click += new EventHandler(clickOnButton2);

            // Set properties for lblResult
            lblResult.Location = new System.Drawing.Point(20, 140);
            lblResult.Size = new System.Drawing.Size(220, 23);
            lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            // Add controls to the form
            Controls.Add(txtA);
            Controls.Add(txtB);
            Controls.Add(txtAngle);
            Controls.Add(btnCalculateHeight);
            Controls.Add(btnCalculateArea);
            Controls.Add(lblResult);

            // Set form properties
            Text = "Parallelogram Calculator";
            Size = new System.Drawing.Size(400, 300);
        }

        void IParallelogramView.SetHeight(double height)
        {
            lblResult.Text = $"{height:N2}";
        }

        void IParallelogramView.SetSquare(double square)
        {
            lblResult.Text = $"{square:N2}";
        }

        void IParallelogramView.DisplayError(string message)
        {
            MessageBox.Show(message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void clickOnButton1(object sender, EventArgs e)
        {
            try
            {
                var a = Convert.ToDouble(txtA.Text);
                var b = Convert.ToDouble(txtB.Text);
                var angle = Convert.ToDouble(txtAngle.Text);
                presenter.LoadParallelogramHeight(a, b, angle);
            }
            catch (FormatException)
            {
                ((IParallelogramView)this).DisplayError("Please enter valid numbers for all fields.");
            }
        }

        private void clickOnButton2(object sender, EventArgs e)
        {
            try
            {
                var a = Convert.ToDouble(txtA.Text);
                var b = Convert.ToDouble(txtB.Text);
                var angle = Convert.ToDouble(txtAngle.Text);
                presenter.LoadParallelogramSquare(a, b, angle);
            }
            catch (FormatException)
            {
                ((IParallelogramView)this).DisplayError("Please enter valid numbers for all fields.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using Label = System.Windows.Forms.Label;
using TextBox = System.Windows.Forms.TextBox;

namespace MVC
{
    public partial class Form1 : Form
    {
        private TextBox txtA, txtB, txtAngle;
        private Button btnCalculateHeight, btnCalculateArea;
        private Label lblResult;

        ControllerParallelogram controller = new ControllerParallelogram();

        public Form1()
        {
            InitializeComponent();
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

        private void clickOnButton1(object sender, EventArgs e)
        {
            try
            {
                var a = Convert.ToDouble(txtA.Text);
                var b = Convert.ToDouble(txtB.Text);
                var angle = Convert.ToDouble(txtAngle.Text);
                var result = controller.Question1(a, b, angle);
                if (result.HasValue)
                    lblResult.Text = result.Value.ToString("N2");
                else
                    MessageBox.Show("Invalid input for the parallelogram dimensions or angle.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void clickOnButton2(object sender, EventArgs e)
        {
            try
            {
                var a = Convert.ToDouble(txtA.Text);
                var b = Convert.ToDouble(txtB.Text);
                var angle = Convert.ToDouble(txtAngle.Text);
                var result = controller.Question2(a, b, angle);
                if (result.HasValue)
                    lblResult.Text = result.Value.ToString("N2");
                else
                    MessageBox.Show("Invalid input for the parallelogram dimensions or angle.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

    }
}


namespace Calculator
{
    partial class Form1
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
            this.button9 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button_dot = new System.Windows.Forms.Button();
            this.displayBox = new System.Windows.Forms.TextBox();
            this.button_equal = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_root = new System.Windows.Forms.Button();
            this.button_inverse = new System.Windows.Forms.Button();
            this.button_multiplication = new System.Windows.Forms.Button();
            this.button_plusMinus = new System.Windows.Forms.Button();
            this.button_percentage = new System.Windows.Forms.Button();
            this.button_divide = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.digitPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.digitPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.digitPanel = new System.Windows.Forms.TableLayoutPanel();
            this.operationPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.operationPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.operationPanel = new System.Windows.Forms.TableLayoutPanel();
            this.C_OperationPanel = new System.Windows.Forms.TableLayoutPanel();
            this.button_C = new System.Windows.Forms.Button();
            this.button_CE = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
            this.M_Operation_button = new System.Windows.Forms.TableLayoutPanel();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.formPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.formPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.formPanel = new System.Windows.Forms.TableLayoutPanel();
            this.digitPanel1.SuspendLayout();
            this.digitPanel2.SuspendLayout();
            this.digitPanel.SuspendLayout();
            this.operationPanel1.SuspendLayout();
            this.operationPanel2.SuspendLayout();
            this.operationPanel.SuspendLayout();
            this.C_OperationPanel.SuspendLayout();
            this.M_Operation_button.SuspendLayout();
            this.formPanel1.SuspendLayout();
            this.formPanel2.SuspendLayout();
            this.formPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Location = new System.Drawing.Point(189, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(89, 61);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(189, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 62);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Location = new System.Drawing.Point(189, 70);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 61);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button_dot
            // 
            this.button_dot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_dot.Location = new System.Drawing.Point(190, 3);
            this.button_dot.Name = "button_dot";
            this.button_dot.Size = new System.Drawing.Size(88, 62);
            this.button_dot.TabIndex = 10;
            this.button_dot.Text = ".";
            this.button_dot.UseVisualStyleBackColor = true;
            // 
            // displayBox
            // 
            this.displayBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayBox.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.displayBox.Location = new System.Drawing.Point(3, 3);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(469, 78);
            this.displayBox.TabIndex = 1;
            this.displayBox.Text = "0";
            this.displayBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.displayBox.TextChanged += new System.EventHandler(this.displayBox_TextChanged);
            // 
            // button_equal
            // 
            this.button_equal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_equal.Location = new System.Drawing.Point(3, 204);
            this.button_equal.Name = "button_equal";
            this.button_equal.Size = new System.Drawing.Size(88, 130);
            this.button_equal.TabIndex = 10;
            this.button_equal.Text = "=";
            this.button_equal.UseVisualStyleBackColor = true;
            this.button_equal.Click += new System.EventHandler(this.button_equal_Click);
            // 
            // button_plus
            // 
            this.button_plus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_plus.Location = new System.Drawing.Point(3, 271);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(88, 63);
            this.button_plus.TabIndex = 11;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_minus
            // 
            this.button_minus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_minus.Location = new System.Drawing.Point(3, 204);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(88, 61);
            this.button_minus.TabIndex = 10;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_root
            // 
            this.button_root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_root.Location = new System.Drawing.Point(3, 3);
            this.button_root.Name = "button_root";
            this.button_root.Size = new System.Drawing.Size(88, 61);
            this.button_root.TabIndex = 16;
            this.button_root.Text = "√";
            this.button_root.UseVisualStyleBackColor = true;
            this.button_root.Click += new System.EventHandler(this.button_root_Click);
            // 
            // button_inverse
            // 
            this.button_inverse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_inverse.Location = new System.Drawing.Point(3, 137);
            this.button_inverse.Name = "button_inverse";
            this.button_inverse.Size = new System.Drawing.Size(88, 61);
            this.button_inverse.TabIndex = 13;
            this.button_inverse.Text = "1/x";
            this.button_inverse.UseVisualStyleBackColor = true;
            this.button_inverse.Click += new System.EventHandler(this.button_inverse_Click);
            // 
            // button_multiplication
            // 
            this.button_multiplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_multiplication.Location = new System.Drawing.Point(3, 137);
            this.button_multiplication.Name = "button_multiplication";
            this.button_multiplication.Size = new System.Drawing.Size(88, 61);
            this.button_multiplication.TabIndex = 12;
            this.button_multiplication.Text = "*";
            this.button_multiplication.UseVisualStyleBackColor = true;
            this.button_multiplication.Click += new System.EventHandler(this.button_multiplication_Click);
            // 
            // button_plusMinus
            // 
            this.button_plusMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_plusMinus.Location = new System.Drawing.Point(3, 3);
            this.button_plusMinus.Name = "button_plusMinus";
            this.button_plusMinus.Size = new System.Drawing.Size(88, 61);
            this.button_plusMinus.TabIndex = 11;
            this.button_plusMinus.Text = "±";
            this.button_plusMinus.UseVisualStyleBackColor = true;
            this.button_plusMinus.Click += new System.EventHandler(this.button_plusMinus_Click);
            // 
            // button_percentage
            // 
            this.button_percentage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_percentage.Location = new System.Drawing.Point(3, 70);
            this.button_percentage.Name = "button_percentage";
            this.button_percentage.Size = new System.Drawing.Size(88, 61);
            this.button_percentage.TabIndex = 15;
            this.button_percentage.Text = "%";
            this.button_percentage.UseVisualStyleBackColor = true;
            // 
            // button_divide
            // 
            this.button_divide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_divide.Location = new System.Drawing.Point(3, 70);
            this.button_divide.Name = "button_divide";
            this.button_divide.Size = new System.Drawing.Size(88, 61);
            this.button_divide.TabIndex = 14;
            this.button_divide.Text = "/";
            this.button_divide.UseVisualStyleBackColor = true;
            this.button_divide.Click += new System.EventHandler(this.button_divide_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Location = new System.Drawing.Point(96, 70);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 61);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(3, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 61);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(96, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 62);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Location = new System.Drawing.Point(3, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(87, 61);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Location = new System.Drawing.Point(96, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(87, 61);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button0
            // 
            this.button0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button0.Location = new System.Drawing.Point(3, 3);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(181, 62);
            this.button0.TabIndex = 9;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // digitPanel1
            // 
            this.digitPanel1.ColumnCount = 3;
            this.digitPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.digitPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.digitPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.digitPanel1.Controls.Add(this.button7, 0, 0);
            this.digitPanel1.Controls.Add(this.button8, 1, 0);
            this.digitPanel1.Controls.Add(this.button9, 2, 0);
            this.digitPanel1.Controls.Add(this.button2, 1, 2);
            this.digitPanel1.Controls.Add(this.button4, 0, 1);
            this.digitPanel1.Controls.Add(this.button5, 1, 1);
            this.digitPanel1.Controls.Add(this.button6, 2, 1);
            this.digitPanel1.Controls.Add(this.button1, 0, 2);
            this.digitPanel1.Controls.Add(this.button3, 2, 2);
            this.digitPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.digitPanel1.Location = new System.Drawing.Point(0, 0);
            this.digitPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.digitPanel1.Name = "digitPanel1";
            this.digitPanel1.RowCount = 3;
            this.digitPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.digitPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.digitPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.digitPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.digitPanel1.Size = new System.Drawing.Size(281, 202);
            this.digitPanel1.TabIndex = 17;
            // 
            // digitPanel2
            // 
            this.digitPanel2.ColumnCount = 2;
            this.digitPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.digitPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.digitPanel2.Controls.Add(this.button0, 0, 0);
            this.digitPanel2.Controls.Add(this.button_dot, 1, 0);
            this.digitPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.digitPanel2.Location = new System.Drawing.Point(0, 202);
            this.digitPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.digitPanel2.Name = "digitPanel2";
            this.digitPanel2.RowCount = 1;
            this.digitPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.digitPanel2.Size = new System.Drawing.Size(281, 68);
            this.digitPanel2.TabIndex = 18;
            // 
            // digitPanel
            // 
            this.digitPanel.ColumnCount = 1;
            this.digitPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.digitPanel.Controls.Add(this.digitPanel1, 0, 0);
            this.digitPanel.Controls.Add(this.digitPanel2, 0, 1);
            this.digitPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.digitPanel.Location = new System.Drawing.Point(0, 67);
            this.digitPanel.Margin = new System.Windows.Forms.Padding(0);
            this.digitPanel.Name = "digitPanel";
            this.digitPanel.RowCount = 2;
            this.digitPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.digitPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.digitPanel.Size = new System.Drawing.Size(281, 270);
            this.digitPanel.TabIndex = 19;
            // 
            // operationPanel1
            // 
            this.operationPanel1.ColumnCount = 1;
            this.operationPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.operationPanel1.Controls.Add(this.button_plusMinus, 0, 0);
            this.operationPanel1.Controls.Add(this.button_divide, 0, 1);
            this.operationPanel1.Controls.Add(this.button_multiplication, 0, 2);
            this.operationPanel1.Controls.Add(this.button_minus, 0, 3);
            this.operationPanel1.Controls.Add(this.button_plus, 0, 4);
            this.operationPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operationPanel1.Location = new System.Drawing.Point(0, 0);
            this.operationPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.operationPanel1.Name = "operationPanel1";
            this.operationPanel1.RowCount = 5;
            this.operationPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.operationPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.operationPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.operationPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.operationPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.operationPanel1.Size = new System.Drawing.Size(94, 337);
            this.operationPanel1.TabIndex = 20;
            // 
            // operationPanel2
            // 
            this.operationPanel2.ColumnCount = 1;
            this.operationPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.operationPanel2.Controls.Add(this.button_root, 0, 0);
            this.operationPanel2.Controls.Add(this.button_percentage, 0, 1);
            this.operationPanel2.Controls.Add(this.button_inverse, 0, 2);
            this.operationPanel2.Controls.Add(this.button_equal, 0, 3);
            this.operationPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operationPanel2.Location = new System.Drawing.Point(94, 0);
            this.operationPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.operationPanel2.Name = "operationPanel2";
            this.operationPanel2.RowCount = 4;
            this.operationPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.operationPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.operationPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.operationPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.operationPanel2.Size = new System.Drawing.Size(94, 337);
            this.operationPanel2.TabIndex = 21;
            // 
            // operationPanel
            // 
            this.operationPanel.ColumnCount = 2;
            this.operationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.operationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.operationPanel.Controls.Add(this.operationPanel1, 0, 0);
            this.operationPanel.Controls.Add(this.operationPanel2, 1, 0);
            this.operationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operationPanel.Location = new System.Drawing.Point(281, 0);
            this.operationPanel.Margin = new System.Windows.Forms.Padding(0);
            this.operationPanel.Name = "operationPanel";
            this.operationPanel.RowCount = 1;
            this.operationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.operationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 337F));
            this.operationPanel.Size = new System.Drawing.Size(188, 337);
            this.operationPanel.TabIndex = 22;
            // 
            // C_OperationPanel
            // 
            this.C_OperationPanel.ColumnCount = 3;
            this.C_OperationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.C_OperationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.C_OperationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.C_OperationPanel.Controls.Add(this.button_C, 0, 0);
            this.C_OperationPanel.Controls.Add(this.button_CE, 0, 0);
            this.C_OperationPanel.Controls.Add(this.button_del, 0, 0);
            this.C_OperationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.C_OperationPanel.Location = new System.Drawing.Point(0, 0);
            this.C_OperationPanel.Margin = new System.Windows.Forms.Padding(0);
            this.C_OperationPanel.Name = "C_OperationPanel";
            this.C_OperationPanel.RowCount = 1;
            this.C_OperationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.C_OperationPanel.Size = new System.Drawing.Size(281, 67);
            this.C_OperationPanel.TabIndex = 23;
            // 
            // button_C
            // 
            this.button_C.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_C.Location = new System.Drawing.Point(189, 3);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(89, 61);
            this.button_C.TabIndex = 11;
            this.button_C.Text = "C";
            this.button_C.UseVisualStyleBackColor = true;
            // 
            // button_CE
            // 
            this.button_CE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_CE.Location = new System.Drawing.Point(96, 3);
            this.button_CE.Name = "button_CE";
            this.button_CE.Size = new System.Drawing.Size(87, 61);
            this.button_CE.TabIndex = 10;
            this.button_CE.Text = "CE";
            this.button_CE.UseVisualStyleBackColor = true;
            // 
            // button_del
            // 
            this.button_del.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_del.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_del.Location = new System.Drawing.Point(3, 3);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(87, 61);
            this.button_del.TabIndex = 9;
            this.button_del.Text = "←";
            this.button_del.UseVisualStyleBackColor = true;
            // 
            // M_Operation_button
            // 
            this.M_Operation_button.ColumnCount = 5;
            this.M_Operation_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.M_Operation_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.M_Operation_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.M_Operation_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.M_Operation_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.M_Operation_button.Controls.Add(this.button14, 0, 0);
            this.M_Operation_button.Controls.Add(this.button13, 0, 0);
            this.M_Operation_button.Controls.Add(this.button12, 0, 0);
            this.M_Operation_button.Controls.Add(this.button11, 0, 0);
            this.M_Operation_button.Controls.Add(this.button10, 0, 0);
            this.M_Operation_button.Location = new System.Drawing.Point(0, 137);
            this.M_Operation_button.Margin = new System.Windows.Forms.Padding(0);
            this.M_Operation_button.Name = "M_Operation_button";
            this.M_Operation_button.RowCount = 1;
            this.M_Operation_button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.M_Operation_button.Size = new System.Drawing.Size(475, 68);
            this.M_Operation_button.TabIndex = 24;
            // 
            // button14
            // 
            this.button14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button14.Location = new System.Drawing.Point(288, 3);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(89, 62);
            this.button14.TabIndex = 14;
            this.button14.Text = "M+";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button13.Location = new System.Drawing.Point(383, 3);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(89, 62);
            this.button13.TabIndex = 13;
            this.button13.Text = "M-";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button12.Location = new System.Drawing.Point(193, 3);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(89, 62);
            this.button12.TabIndex = 12;
            this.button12.Text = "MS";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button11.Location = new System.Drawing.Point(3, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(89, 62);
            this.button11.TabIndex = 11;
            this.button11.Text = "MC";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button10.Location = new System.Drawing.Point(98, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(89, 62);
            this.button10.TabIndex = 10;
            this.button10.Text = "MR";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // formPanel1
            // 
            this.formPanel1.ColumnCount = 1;
            this.formPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.formPanel1.Controls.Add(this.C_OperationPanel, 0, 0);
            this.formPanel1.Controls.Add(this.digitPanel, 0, 1);
            this.formPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formPanel1.Location = new System.Drawing.Point(0, 0);
            this.formPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.formPanel1.Name = "formPanel1";
            this.formPanel1.RowCount = 2;
            this.formPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.formPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.formPanel1.Size = new System.Drawing.Size(281, 337);
            this.formPanel1.TabIndex = 25;
            // 
            // formPanel2
            // 
            this.formPanel2.ColumnCount = 2;
            this.formPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.formPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.formPanel2.Controls.Add(this.formPanel1, 0, 0);
            this.formPanel2.Controls.Add(this.operationPanel, 1, 0);
            this.formPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formPanel2.Location = new System.Drawing.Point(3, 208);
            this.formPanel2.Name = "formPanel2";
            this.formPanel2.RowCount = 1;
            this.formPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.formPanel2.Size = new System.Drawing.Size(469, 337);
            this.formPanel2.TabIndex = 26;
            // 
            // formPanel
            // 
            this.formPanel.ColumnCount = 1;
            this.formPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.formPanel.Controls.Add(this.displayBox, 0, 0);
            this.formPanel.Controls.Add(this.formPanel2, 0, 2);
            this.formPanel.Controls.Add(this.M_Operation_button, 0, 1);
            this.formPanel.Location = new System.Drawing.Point(12, 22);
            this.formPanel.Name = "formPanel";
            this.formPanel.RowCount = 3;
            this.formPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.formPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.formPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.formPanel.Size = new System.Drawing.Size(475, 548);
            this.formPanel.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 583);
            this.Controls.Add(this.formPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.digitPanel1.ResumeLayout(false);
            this.digitPanel2.ResumeLayout(false);
            this.digitPanel.ResumeLayout(false);
            this.operationPanel1.ResumeLayout(false);
            this.operationPanel2.ResumeLayout(false);
            this.operationPanel.ResumeLayout(false);
            this.C_OperationPanel.ResumeLayout(false);
            this.M_Operation_button.ResumeLayout(false);
            this.formPanel1.ResumeLayout(false);
            this.formPanel2.ResumeLayout(false);
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button_dot;
        private System.Windows.Forms.TextBox displayBox;
        private System.Windows.Forms.Button button_equal;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_inverse;
        private System.Windows.Forms.Button button_multiplication;
        private System.Windows.Forms.Button button_plusMinus;
        private System.Windows.Forms.Button button_root;
        private System.Windows.Forms.Button button_percentage;
        private System.Windows.Forms.Button button_divide;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.TableLayoutPanel digitPanel1;
        private System.Windows.Forms.TableLayoutPanel digitPanel2;
        private System.Windows.Forms.TableLayoutPanel digitPanel;
        private System.Windows.Forms.TableLayoutPanel operationPanel1;
        private System.Windows.Forms.TableLayoutPanel operationPanel2;
        private System.Windows.Forms.TableLayoutPanel operationPanel;
        private System.Windows.Forms.TableLayoutPanel C_OperationPanel;
        private System.Windows.Forms.Button button_C;
        private System.Windows.Forms.Button button_CE;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.TableLayoutPanel M_Operation_button;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TableLayoutPanel formPanel1;
        private System.Windows.Forms.TableLayoutPanel formPanel2;
        private System.Windows.Forms.TableLayoutPanel formPanel;
    }
}


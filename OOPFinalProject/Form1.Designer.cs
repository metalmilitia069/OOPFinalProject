namespace OOPFinalProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButtonDrawRectangle = new System.Windows.Forms.RadioButton();
            this.radioButtonDrawCircle = new System.Windows.Forms.RadioButton();
            this.textBoxInputSquareSide = new System.Windows.Forms.TextBox();
            this.labelRectangleSide = new System.Windows.Forms.Label();
            this.labelCircleRadius = new System.Windows.Forms.Label();
            this.textBoxInputCircleRadius = new System.Windows.Forms.TextBox();
            this.buttonSquareCreate = new System.Windows.Forms.Button();
            this.buttonCircleCreate = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(740, 623);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // radioButtonDrawRectangle
            // 
            this.radioButtonDrawRectangle.AutoSize = true;
            this.radioButtonDrawRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDrawRectangle.Location = new System.Drawing.Point(813, 70);
            this.radioButtonDrawRectangle.Name = "radioButtonDrawRectangle";
            this.radioButtonDrawRectangle.Size = new System.Drawing.Size(154, 24);
            this.radioButtonDrawRectangle.TabIndex = 1;
            this.radioButtonDrawRectangle.TabStop = true;
            this.radioButtonDrawRectangle.Text = "Draw a Rectangle";
            this.radioButtonDrawRectangle.UseVisualStyleBackColor = true;
            this.radioButtonDrawRectangle.CheckedChanged += new System.EventHandler(this.radioButtonDrawRectangle_CheckedChanged);
            // 
            // radioButtonDrawCircle
            // 
            this.radioButtonDrawCircle.AutoSize = true;
            this.radioButtonDrawCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDrawCircle.Location = new System.Drawing.Point(813, 294);
            this.radioButtonDrawCircle.Name = "radioButtonDrawCircle";
            this.radioButtonDrawCircle.Size = new System.Drawing.Size(120, 24);
            this.radioButtonDrawCircle.TabIndex = 2;
            this.radioButtonDrawCircle.TabStop = true;
            this.radioButtonDrawCircle.Text = "Draw a Circle";
            this.radioButtonDrawCircle.UseVisualStyleBackColor = true;
            this.radioButtonDrawCircle.CheckedChanged += new System.EventHandler(this.radioButtonDrawCircle_CheckedChanged);
            // 
            // textBoxInputSquareSide
            // 
            this.textBoxInputSquareSide.Location = new System.Drawing.Point(841, 137);
            this.textBoxInputSquareSide.Name = "textBoxInputSquareSide";
            this.textBoxInputSquareSide.Size = new System.Drawing.Size(100, 20);
            this.textBoxInputSquareSide.TabIndex = 3;
            // 
            // labelRectangleSide
            // 
            this.labelRectangleSide.AutoSize = true;
            this.labelRectangleSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRectangleSide.Location = new System.Drawing.Point(826, 110);
            this.labelRectangleSide.Name = "labelRectangleSide";
            this.labelRectangleSide.Size = new System.Drawing.Size(138, 20);
            this.labelRectangleSide.TabIndex = 4;
            this.labelRectangleSide.Text = "Input Square Side";
            // 
            // labelCircleRadius
            // 
            this.labelCircleRadius.AutoSize = true;
            this.labelCircleRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCircleRadius.Location = new System.Drawing.Point(826, 342);
            this.labelCircleRadius.Name = "labelCircleRadius";
            this.labelCircleRadius.Size = new System.Drawing.Size(143, 20);
            this.labelCircleRadius.TabIndex = 5;
            this.labelCircleRadius.Text = "Input Circle Radius";
            // 
            // textBoxInputCircleRadius
            // 
            this.textBoxInputCircleRadius.Location = new System.Drawing.Point(841, 371);
            this.textBoxInputCircleRadius.Name = "textBoxInputCircleRadius";
            this.textBoxInputCircleRadius.Size = new System.Drawing.Size(100, 20);
            this.textBoxInputCircleRadius.TabIndex = 6;
            // 
            // buttonSquareCreate
            // 
            this.buttonSquareCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSquareCreate.Location = new System.Drawing.Point(858, 169);
            this.buttonSquareCreate.Name = "buttonSquareCreate";
            this.buttonSquareCreate.Size = new System.Drawing.Size(75, 29);
            this.buttonSquareCreate.TabIndex = 7;
            this.buttonSquareCreate.Text = "Create";
            this.buttonSquareCreate.UseVisualStyleBackColor = true;
            this.buttonSquareCreate.Click += new System.EventHandler(this.buttonSquareCreate_Click);
            // 
            // buttonCircleCreate
            // 
            this.buttonCircleCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCircleCreate.Location = new System.Drawing.Point(858, 404);
            this.buttonCircleCreate.Name = "buttonCircleCreate";
            this.buttonCircleCreate.Size = new System.Drawing.Size(75, 29);
            this.buttonCircleCreate.TabIndex = 8;
            this.buttonCircleCreate.Text = "Create";
            this.buttonCircleCreate.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 648);
            this.Controls.Add(this.buttonCircleCreate);
            this.Controls.Add(this.buttonSquareCreate);
            this.Controls.Add(this.textBoxInputCircleRadius);
            this.Controls.Add(this.labelCircleRadius);
            this.Controls.Add(this.labelRectangleSide);
            this.Controls.Add(this.textBoxInputSquareSide);
            this.Controls.Add(this.radioButtonDrawCircle);
            this.Controls.Add(this.radioButtonDrawRectangle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButtonDrawRectangle;
        private System.Windows.Forms.RadioButton radioButtonDrawCircle;
        private System.Windows.Forms.TextBox textBoxInputSquareSide;
        private System.Windows.Forms.Label labelRectangleSide;
        private System.Windows.Forms.Label labelCircleRadius;
        private System.Windows.Forms.TextBox textBoxInputCircleRadius;
        private System.Windows.Forms.Button buttonSquareCreate;
        private System.Windows.Forms.Button buttonCircleCreate;
        private System.Windows.Forms.Timer timer1;
    }
}


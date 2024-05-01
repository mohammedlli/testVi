namespace WinFormsApp4
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
            pictureBox1=new PictureBox();
            pictureBox2=new PictureBox();
            pictureBox3=new PictureBox();
            pictureBox4=new PictureBox();
            saveFileDialog1=new SaveFileDialog();
            openFileDialog1=new OpenFileDialog();
            button1=new Button();
            button2=new Button();
            button3=new Button();
            pictureBox5=new PictureBox();
            pictureBox6=new PictureBox();
            button4=new Button();
            button5=new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location=new Point(12, 12);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(294, 292);
            pictureBox1.TabIndex=0;
            pictureBox1.TabStop=false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location=new Point(312, 310);
            pictureBox2.Name="pictureBox2";
            pictureBox2.Size=new Size(320, 284);
            pictureBox2.TabIndex=1;
            pictureBox2.TabStop=false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location=new Point(12, 310);
            pictureBox3.Name="pictureBox3";
            pictureBox3.Size=new Size(294, 284);
            pictureBox3.TabIndex=2;
            pictureBox3.TabStop=false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location=new Point(312, 12);
            pictureBox4.Name="pictureBox4";
            pictureBox4.Size=new Size(320, 292);
            pictureBox4.TabIndex=3;
            pictureBox4.TabStop=false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName="openFileDialog1";
            // 
            // button1
            // 
            button1.Location=new Point(991, 46);
            button1.Name="button1";
            button1.Size=new Size(118, 68);
            button1.TabIndex=4;
            button1.Text="button1";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // button2
            // 
            button2.Location=new Point(991, 142);
            button2.Name="button2";
            button2.Size=new Size(118, 60);
            button2.TabIndex=5;
            button2.Text="button2";
            button2.UseVisualStyleBackColor=true;
            button2.Click+=button2_Click;
            // 
            // button3
            // 
            button3.Location=new Point(1000, 231);
            button3.Name="button3";
            button3.Size=new Size(109, 56);
            button3.TabIndex=6;
            button3.Text="button3";
            button3.UseVisualStyleBackColor=true;
            button3.Click+=button3_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Location=new Point(638, 20);
            pictureBox5.Name="pictureBox5";
            pictureBox5.Size=new Size(320, 284);
            pictureBox5.TabIndex=7;
            pictureBox5.TabStop=false;
            // 
            // pictureBox6
            // 
            pictureBox6.Location=new Point(638, 310);
            pictureBox6.Name="pictureBox6";
            pictureBox6.Size=new Size(320, 284);
            pictureBox6.TabIndex=8;
            pictureBox6.TabStop=false;
            // 
            // button4
            // 
            button4.Location=new Point(1000, 310);
            button4.Name="button4";
            button4.Size=new Size(109, 56);
            button4.TabIndex=9;
            button4.Text="button4";
            button4.UseVisualStyleBackColor=true;
            button4.Click+=button4_Click;
            // 
            // button5
            // 
            button5.Location=new Point(1000, 398);
            button5.Name="button5";
            button5.Size=new Size(109, 56);
            button5.TabIndex=10;
            button5.Text="button5";
            button5.UseVisualStyleBackColor=true;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1121, 615);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name="Form1";
            Text="Form1";
            Load+=Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Button button4;
        private Button button5;
    }
}
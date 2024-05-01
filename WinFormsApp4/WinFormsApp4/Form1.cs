namespace WinFormsApp4
{
    public partial class Form1 : Form
    {

        Bitmap bmp, bmp1, bmp2, bmp3, bmp4, bmp5 ,bmp6;
        int w, h, W = 256, H = 256;
        byte[,] red;
        byte[,] green;
        byte[,] blue;

        byte[,] A, B, C, D;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Jpeg Images |*.jpg|Bmp Images|*.bmp";
            openFileDialog1.ShowDialog();
            bmp = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image=bmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            w=bmp.Width; h=bmp.Height;
            red = new byte[w, h];
            green = new byte[w, h];
            blue = new byte[w, h];

            bmp1 = new Bitmap(w, h);
            bmp2 = new Bitmap(w, h);
            bmp3 = new Bitmap(w, h);
            bmp4 = new Bitmap(w, h);

            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    Color p = bmp.GetPixel(i, j);

                    red[i, j] = p.R;
                    green[i, j]=p.G;
                    blue[i, j]=p.B;

                    bmp1.SetPixel(i, j, Color.FromArgb(red[i, j], 0, 0));
                    bmp2.SetPixel(i, j, Color.FromArgb(0, green[i, j], 0));
                    bmp3.SetPixel(i, j, Color.FromArgb(0, 0, blue[i, j]));
                    bmp4.SetPixel(i, j, Color.FromArgb(red[i, j], green[i, j], blue[i, j]));

                }
            }
            pictureBox1.Image = bmp1;
            pictureBox2.Image = bmp2;
            pictureBox3.Image = bmp3;
            pictureBox4.Image = bmp4;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            A = new byte[W, H];

            bmp5 = new Bitmap(W, H);

            for (int i = 0; i < W; i++)
            {
                for (int j = 0; j < H; j++)
                {
                    A[i, j] = (byte)i;

                    bmp5.SetPixel(i, j, Color.FromArgb(A[i, j], A[i, j], A[i, j]));
                }
            }
            pictureBox1.Image = bmp5;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            B = new byte[W, H];
            bmp6 = new Bitmap(W, H);

            for(int i = 0; i < W;i++)
            {
                for(int j = 0;j < H; j++)
                {
                    double dis = Math.Sqrt(((i -128) * (i-128)) + ((j-128)*(j-128)));
                    if (dis < 80)
                        B[i, j]=255;
                    else B[i, j]=0;

                    bmp6.SetPixel(i, j, Color.FromArgb(B[i, j], B[i, j], B[i, j]));
                }
            }
            pictureBox6.Image = bmp6;
        }


    }
}
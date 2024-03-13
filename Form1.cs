using System.Text;

namespace ImageProcessing
{
    public partial class MainForm : Form
    {
        #region Help

        public MainForm()
        {
            InitializeComponent();
            #region settings
            SelectInputFileDialog.Filter = @"Image Files| *.png; *.jpg; *.jpeg| All files | *.*";
            SourceImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            OutputImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            #endregion
        }
        #endregion

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            if (SelectInputFileDialog.ShowDialog() == DialogResult.OK)
                SourceImgBox.Image = Image.FromFile(SelectInputFileDialog.FileName);
        }

        private void ProcessImageButton_Click(object sender, EventArgs e)
        {
            int X = int.Parse(RectXTextBox.Text),
                Y = int.Parse(RectYTextBox.Text),
                W = int.Parse(RectWTextBox.Text),
                H = int.Parse(RectHTextBox.Text);


            Console.WriteLine(ProcessImage(SourceImgBox.Image, X, Y, W, H));
        }

        private void DrawLines_Click(object sender, EventArgs e)
        {
            int X = int.Parse(RectXTextBox.Text),
                Y = int.Parse(RectYTextBox.Text),
                W = int.Parse(RectWTextBox.Text),
                H = int.Parse(RectHTextBox.Text);
            var bmp = new Bitmap(SourceImgBox.Image);
            for (int x = X - W / 2; x < X + W / 2; x++)
                bmp.SetPixel(x, Y + H / 2, Color.Red);
            for (int x = X - W / 2; x < X + W / 2; x++)
                bmp.SetPixel(x, Y - H / 2, Color.Red);
            for (int y = Y - H / 2; y < Y + H / 2; y++)
                bmp.SetPixel(X - W / 2, y, Color.Red);
            for (int y = Y - H / 2; y < Y + H / 2; y++)
                bmp.SetPixel(X + W / 2, y, Color.Red);
            SourceImgBox.Image = bmp;
        }

        private int ProcessImage(Image input, int X, int Y, int W, int H)
        {
            var inputImage = new Bitmap(input);
            var numberArray = new List<bool>(32);
            int halfWidth = W / 2;
            int halfHeight = H / 2;

            for (int x = 0; x < inputImage.Width; x++)
                for (int y = 0; y < inputImage.Height; y++)
                    inputImage.SetPixel(x, y, GetGrayValue(inputImage.GetPixel(x, y))<190?Color.Black:Color.White);

            for (int y = Y-H/2; y < Y+H/2; y += 2)
            {
                int x = X-W/2;
                byte gray = GetGrayValue(inputImage.GetPixel(x, y));
                uint sum=0;
                while (x < X+W/2)
                {
                    gray = (byte)(GetGrayValue(inputImage.GetPixel(x, y))<190?0:1);
                    sum += (uint)(gray*x);

                    inputImage.SetPixel(x, y, Color.Red);

                    x += 2;
                }
                Console.WriteLine(sum);
            }
            OutputImgBox.Image = inputImage;

            //reverse array -> select all bools -> convert to byte -> sum all elements as image was binary representation of number
            return numberArray.Select((x) => (byte)(x ? 0 : 1)).Select((x, i) => (int)(x * Math.Pow(2, i))).Sum();
        }

        private static byte GetGrayValue(Color pixel)
        {
            return Clamp(MathF.Round((pixel.R + pixel.G + pixel.B) / 3));
        }

        private static byte Clamp(object v)
        {
            return (byte)Math.Clamp(Convert.ToInt32(v), 0, byte.MaxValue);
        }

        private void SourceImgBox_Click(object sender, EventArgs e)
        {

        }
    }
}
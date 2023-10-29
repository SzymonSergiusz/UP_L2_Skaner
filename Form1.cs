using System.Windows.Forms;
using WIA;

namespace UP_L2_Skaner
{
    public partial class Form1 : Form
    {
        Scanner scanner = new Scanner();
        public Form1()
        {
            InitializeComponent();
            formatsList.SelectedIndex = 0;
            scanPreview.Image = new Bitmap("D:\\Studia\\UP_L2_Skaner\\test.jpg");
            scanPreview.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            scanner.connect();

        }

        private void scanButton_Click(object sender, EventArgs e)
        {


            var wiaImg = scanner.scan();

            Image img = Image.FromStream(new System.IO.MemoryStream((byte[])wiaImg.FileData.get_BinaryData()));

            scanPreview.Image = new Bitmap(img);
            scanPreview.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void scanPreview_Click(object sender, EventArgs e)
        {

        }

        private void saveImage_Click(object sender, EventArgs e)
        {
            var extension = formatsList.SelectedItem.ToString();
            System.Diagnostics.Debug.WriteLine("ROZSZERZENIE: " + extension);
            scanner.saveImageAs(extension);


        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void rotateLeft_Click(object sender, EventArgs e)
        {
            scanPreview.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            scanPreview.Refresh();
        }

        private void rotateRightButton_Click(object sender, EventArgs e)
        {
            scanPreview.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            scanPreview.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
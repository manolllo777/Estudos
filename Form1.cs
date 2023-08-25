using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Aula9ExercicioVisualizadorImagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] arquivos = Directory.GetFiles(@"c:\windows\web\wallpaper", "*.jpg", SearchOption.AllDirectories);
            imagemListBox.Items.AddRange(arquivos);
        }

        private void imagemListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = imagemListBox.Text;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void adicionarButton_Click(object sender, EventArgs e)
        {
            favoritosListBox.Items.Add(imagemListBox.Text);
        }

        private void favoritosListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = favoritosListBox.Text;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
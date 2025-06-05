using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacMan
{
    public partial class Form1 : Form
    {

        private string yon = "";   //oyuncunun yönü

        private int score = 0; //oyuncunun skoru

        private Random rastgele = new Random(); // hayaletin rastgele hareketi


        public Form1()
        {
            InitializeComponent();
            this.KeyDown += Form1_Keydown;
            gameTimer.Tick += OyunZamanı_Tick;
            gameTimer.Start();


        }
        private void Form1_Keydown(object sender, KeyEventArgs e) // Klavye yön hareketi metotu
        {
            switch(e.KeyCode)
            {
                case Keys.Left:
                    yon = "Left";
                    break;
                case Keys.Right:
                    yon = "Right";
                    break;
                case Keys.Up:
                    yon = "Up";
                    break;
                case Keys.Down:
                    yon = "Down";
                    break;
            }
        }

        //timer çalıştıkça bu metot her 100ms de bir çalışır.
        private void OyunZamanı_Tick(object sender,EventArgs e)
        {
            PictureBox pbpacman=Controls.Find("pbpacman",true).FirstOrDefault() as PictureBox;  //pacman karakterini bulan metot
            if (pbpacman==null)
            {
                return;
            }
            Point oldPosition=pbpacman.Location; //hareketlerin önceki konumu

            switch(yon) //seçilen yöne pacmanin hareket etmesini sağlar
            {
                case "Left":
                    pbpacman.Left -= 5;
                    break;
                case "Right":
                    pbpacman.Left += 5;
                    break;
                case "Up":
                    pbpacman.Top -= 5;
                    break;
                case "Down":
                    pbpacman.Top += 5;
                    break;
            }
            foreach (Control ctrl in Controls)
            {
                if (ctrl is PictureBox && ctrl.Tag?.ToString() == "wall")
                {
                    if(pbpacman.Bounds.IntersectsWith(ctrl.Bounds))
                    {
                        pbpacman.Location = oldPosition;
                        break;
                    }
                }
            }
        }
    }
}

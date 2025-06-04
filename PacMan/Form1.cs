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

        }
    }
}

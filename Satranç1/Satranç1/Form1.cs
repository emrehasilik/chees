using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satranç1
{
    public partial class Form1 : Form
    {
        public static Button Button1;

        private void ResetColors()
        {
            // Reset all PictureBox colors to the default state
            pictureBox21.BackColor = Color.SteelBlue;

            PictureBox[] allPictureBoxes1 = {
            pictureBox2, pictureBox3, pictureBox5, pictureBox7, pictureBox10, pictureBox12,
            pictureBox14, pictureBox16, pictureBox25, pictureBox27, pictureBox29, pictureBox31,
            pictureBox18, pictureBox20, pictureBox22, pictureBox24, pictureBox41, pictureBox47,
            pictureBox43, pictureBox45, pictureBox34, pictureBox36, pictureBox38, pictureBox40,
            pictureBox57, pictureBox59, pictureBox61, pictureBox63, pictureBox50, pictureBox52,
             pictureBox54, pictureBox56
        };

            foreach (var pictureItem in allPictureBoxes1)
            {
                pictureItem.BackColor = Color.Black;
            }
            PictureBox[] remainingPictureBoxes = {
        pictureBox1, pictureBox4, pictureBox6, pictureBox8, pictureBox9, pictureBox11,
        pictureBox13, pictureBox15, pictureBox17, pictureBox19, pictureBox23, pictureBox26,
        pictureBox28, pictureBox30, pictureBox32, pictureBox33, pictureBox35, pictureBox37,
        pictureBox39, pictureBox42, pictureBox44, pictureBox46, pictureBox48, pictureBox49,
        pictureBox51, pictureBox53, pictureBox55, pictureBox58, pictureBox60, pictureBox62,
        pictureBox64
    };

            foreach (var pictureItem in remainingPictureBoxes)
            {
                pictureItem.BackColor = Color.White;
            }

        }



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        class SatrancTasi
        {
            // Polimorfizm örneği: Alt sınıflar bu metodu override edebilir
            public virtual void HareketEt()
            {

            }
            public virtual void button2_Click(object sender, EventArgs e)
            {
              
            }

            public virtual void button3_Click(object sender, EventArgs e)
            {
               
            }
            public virtual void button4_Click(object sender, EventArgs e)
            {

            }
            public virtual void button5_Click(object sender, EventArgs e)
            {

            }
            public virtual void button6_Click(object sender, EventArgs e)
            {

            }
            public virtual void button7_Click(object sender, EventArgs e)
            {

            }



        }

        // Alt sınıf 1
        class Kale : SatrancTasi
        {
            // Polimorfizm: Ana sınıftaki metodu override ediyor
            public override void HareketEt()
            {
                

            }
            public override void button2_Click(object sender, EventArgs e)
            {
              
                base.button2_Click(sender, e);
            }

        }

        // Alt sınıf 2
        class Fil : SatrancTasi
        {
            // Polimorfizm: Ana sınıftaki metodu override ediyor
            public override void HareketEt()
            {

            }
            public override void button3_Click(object sender, EventArgs e)
            {

                base.button3_Click(sender, e);
            }
        }
        class Sah : SatrancTasi
        {
            // Polimorfizm: Ana sınıftaki metodu override ediyor
            public override void HareketEt()
            {

            }
            public override void button7_Click(object sender, EventArgs e)
            {

                base.button7_Click(sender, e);
            }
        }
        class Vezir : SatrancTasi
        {
            // Polimorfizm: Ana sınıftaki metodu override ediyor
            public override void HareketEt()
            {

            }
            public override void button6_Click(object sender, EventArgs e)
            {

                base.button6_Click(sender, e);
            }
        }
        class At : SatrancTasi
        {
            // Polimorfizm: Ana sınıftaki metodu override ediyor
            public override void HareketEt()
            {

            }
            public override void button4_Click(object sender, EventArgs e)
            {

                base.button4_Click(sender, e);
            }
        }
        class Piyon : SatrancTasi
        {
            // Polimorfizm: Ana sınıftaki metodu override ediyor
            public override void HareketEt()
            {

            }
            public override void button5_Click(object sender, EventArgs e)
            {

                base.button5_Click(sender, e);
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            // Button1'e tıklanma durumunda yapılacak işlemleri buraya ekleyin
            // Örnek olarak PictureBox'ları renklendirme
            ResetColors();
            pictureBox21.BackColor =Color.IndianRed;
            PictureBox[] picture = { pictureBox22,pictureBox23, pictureBox24,pictureBox17,pictureBox18,pictureBox19,pictureBox20, pictureBox3 , pictureBox11 , pictureBox29, pictureBox45 , pictureBox37 , pictureBox61 , pictureBox53};
            foreach (var pictureItem in picture)
            {
                pictureItem.BackColor = Color.SteelBlue;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResetColors();
            pictureBox21.BackColor = Color.IndianRed;
            PictureBox[] picture = { pictureBox28, pictureBox13, pictureBox8, pictureBox46, pictureBox39, pictureBox64, pictureBox30, pictureBox9, pictureBox1, pictureBox44, pictureBox35, pictureBox58, pictureBox49 };
            foreach (var pictureItem in picture)
            {
                pictureItem.BackColor = Color.SteelBlue;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetColors();
            pictureBox21.BackColor = Color.IndianRed;
            PictureBox[] picture = { pictureBox14, pictureBox27, pictureBox12, pictureBox31, pictureBox36, pictureBox43, pictureBox38, pictureBox47};
            foreach (var pictureItem in picture)
            {
                pictureItem.BackColor = Color.SteelBlue;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ResetColors();
            pictureBox21.BackColor = Color.IndianRed;
            PictureBox[] picture = { pictureBox29};
            foreach (var pictureItem in picture)
            {
                pictureItem.BackColor = Color.SteelBlue;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ResetColors();
            pictureBox21.BackColor = Color.IndianRed;
            PictureBox[] picture = { pictureBox22, pictureBox23, pictureBox24, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox3, pictureBox11, pictureBox29, pictureBox45, pictureBox37, pictureBox61, pictureBox53, pictureBox28, pictureBox13, pictureBox8, pictureBox46, pictureBox39, pictureBox64, pictureBox30, pictureBox9, pictureBox1, pictureBox44, pictureBox35, pictureBox58, pictureBox49 };
            foreach (var pictureItem in picture)
            {
                pictureItem.BackColor = Color.SteelBlue;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ResetColors();
            pictureBox21.BackColor = Color.IndianRed;
            PictureBox[] picture = { pictureBox29 , pictureBox28, pictureBox30, pictureBox45 , pictureBox44 , pictureBox20, pictureBox22 , pictureBox46 };
            foreach (var pictureItem in picture)
            {
                pictureItem.BackColor = Color.SteelBlue;
            }
        }
    }
}

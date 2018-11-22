using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//kütüphaneyi ekledik.
using System.Diagnostics;

namespace Pc_Shutdown_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //başlat button
        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = 3600;
            //radiobuton değerlerini alalım.

            if (radioButton1.Checked == true)
            {
                sayi = 3600;
                MessageBox.Show("Bilgisayarınız 1 saat sonra kapatılacaktır.");
            }
            else if (radioButton2.Checked)
            {
                sayi = 3600 * 2;
                MessageBox.Show("Bilgisayarınız 2 saat sonra kapatılacaktır.");

            }

            else if (radioButton3.Checked == true)
            {
                sayi = 3600 * 3;
                MessageBox.Show("Bilgisayarınız 3 saat sonra kapatılacaktır.");
            }

            else if (radioButton4.Checked == true)
            {
                sayi = 3600 * 4;
                MessageBox.Show("Bilgisayarınız 4 saat sonra kapatılacaktır.");
            }

            else if (radioButton5.Checked == true)
            {
                sayi = 3600 * 5;
                MessageBox.Show("Bilgisayarınız 5 saat sonra kapatılacaktır.");
            }
            else if (radioButton6.Checked == true)
            {
                sayi = 3600 * 6;
                MessageBox.Show("Bilgisayarınız 6 saat sonra kapatılacaktır.");
            }
            else
            {

                if (textBox1.Text != "")
                {
                    try
                    {
                        textBox1.Enabled = true;
                        int deger =( int.Parse(textBox1.Text));

                        int saat=Convert.ToInt32(deger/60);//saat değeri aldık 1,4548458...

                        double kalan =(deger%60); //modu aldık ki 65 girilirse kalan 5 dakika olacak
                        double milisaniye = (deger*60);

                       System.Diagnostics.Process.Start("CMD.exe", "/C shutdown -s -t " + milisaniye);

                        MessageBox.Show("Bilgisayarınız " + deger + " dakika sonra kapatılacaktır.\n\n\nYani: " + saat + " saat " + kalan + " dakika sonra", " Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lütfen Sadece Tam Sayı Girin !", "Uyarı",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   

                }

                else
                {
                    textBox1.Text = "60";
                    textBox1.Enabled = true;
                
                    MessageBox.Show("Bilgisayarınız 1 saat sonra kapatılacaktır.\n", " Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            System.Diagnostics.Process.Start("CMD.exe", "/C shutdown -s -t " + sayi);



            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;
            radioButton6.Enabled = false;
            textBox1.Enabled = false;
            button1.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = true;

        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void button2_Click(object sender, EventArgs e) //İPTAL ET BUTTON
        {
            System.Diagnostics.Process.Start("CMD.exe", "/C shutdown -a");
            MessageBox.Show("Otomatik Bilgisayar Kapatma Sistemi\nDevre Dışı Bırakıldı!", " Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            radioButton5.Enabled = true;
            radioButton6.Enabled = true;
            textBox1.Enabled = true;
            button1.Enabled = true;
            button3.Enabled = true;

            /////
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            textBox1.Clear();

            button2.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)  //Elle Gir Button
        {

            radioButton1.Checked = false;//önce bunları false yaptık  ki elle gir butonuna  ilk tıklamada -
            radioButton2.Checked = false;// radiobutonlar pasif olsun textbox enabled olabilsin...
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;

            textBox1.Enabled = true;

            textBox1.BackColor = Color.White;
            textBox1.Focus();
            label2.Enabled = true;

           

        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            textBox1.Enabled = false;
            button2.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            label2.Visible = false;
            textBox1.BackColor = Color.Gray;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            label2.Visible = false;
            textBox1.BackColor = Color.Gray;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            label2.Visible = false;
            textBox1.BackColor = Color.Gray;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            label2.Visible = false;
            textBox1.BackColor = Color.Gray;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            label2.Visible = false;
            textBox1.BackColor = Color.Gray;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            label2.Visible = false;
            textBox1.BackColor = Color.Gray;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}

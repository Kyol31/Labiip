using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 400;
            this.Height = 300;
            pictureBox1.Width = 240;
            pictureBox1.Height = 240;
            panel1.Width = 260;
            panel1.Height = 260;
            button2.BackColor = Color.FromArgb(255, 36, 0);
            button1.BackColor = Color.FromArgb(11, 218, 81);
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Black, 80, 0, 80, 240);
            e.Graphics.DrawLine(Pens.Black, 160, 0, 160, 240);
            e.Graphics.DrawLine(Pens.Black, 0, 80, 240, 80);
            e.Graphics.DrawLine(Pens.Black, 0, 160, 240, 160);
        }
        //позиция
        int pos = 0;
        //Счетчик для кр и нл, не более 9
        int countZero = -999;
        int count = 0;
        //Позиции для предотвращения повторного клика
        int[] p = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //Комбинации победы для кр и нл
        int[] arrCombo = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int[] arrComboX = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        //Шаги бота
        int[] botStepCheckPos = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int botEnable = 0;
        //Логика игры
        private void pictureBox1_MouseClick(object sender, MouseEventArgs n)
        {
            Point click = n.Location;
            int x = click.X;
            int y = click.Y;
            //pos1
            if ((x > 0) & (x < 80) & ((y > 0) & (y < 80)))
            {
                if (p[0] == 1)
                {
                    count += 1;
                    pos = p[0];
                    countZero += 1;
                }
            }
            //pos2
            if ((x > 80) & (x < 160) & (y > 0) & (y < 80))
            {
                if (p[1] == 2)
                {
                    count += 1;
                    pos = p[1];
                    countZero += 1;
                }

            }
            //pos3
            if ((x > 160) & (x < 240) & (y > 0) & (y < 80))
            {
                if (p[2] == 3)
                {
                    count += 1;
                    pos = p[2];
                    countZero += 1;
                }

            }
            //pos4
            if ((x > 0) & (x < 80) & (y > 80) & (y < 160))
            {
                if (p[3] == 4)
                {
                    count += 1;
                    pos = p[3];
                    countZero += 1;
                }

            }
            //pos5
            if ((x > 80) & (x < 160) & (y > 80) & (y < 160))
            {
                if (p[4] == 5)
                {
                    count += 1;
                    pos = p[4];
                    countZero += 1;
                }

            }
            //pos6
            if ((x > 160) & (x < 240) & (y > 80) & (y < 160))
            {
                if (p[5] == 6)
                {
                    count += 1;
                    pos = p[5];
                    countZero += 1;
                }

            }
            //pos7
            if ((x > 0) & (x < 80) & (y > 160) & (y < 240))
            {
                if (p[6] == 7)
                {
                    count += 1;
                    pos = p[6];
                    countZero += 1;
                }

            }
            //pos8
            if ((x > 80) & (x < 160) & (y > 160) & (y < 240))
            {
                if (p[7] == 8)
                {
                    count += 1;
                    pos = p[7];
                    countZero += 1;
                }

            }
            //pos9
            if ((x > 160) & (x < 240) & (y > 160) & (y < 240))
            {
                if (p[8] == 9)
                {
                    count += 1;
                    countZero += 1;
                    pos = p[8];

                }

            }

            //если больше 9 то не будет кликаться
            if (count > 9 | countZero > 9)
            {
                count = -999;
                countZero = -999;
            }

            Graphics g = pictureBox1.CreateGraphics();

            if (count == 1 | count == 3 | count == 5 | count == 7 | count == 9 | countZero == 2 | countZero == 4 | countZero == 6 | countZero == 8)
            {
                switch (Convert.ToString(pos))
                {
                    case "1":
                        //g.FillRectangle(Brushes.Olive, 0, 0, 80, 80);
                        g.DrawLine(new Pen(Color.Blue, 3), 0, 0, 80, 80);
                        g.DrawLine(new Pen(Color.Blue, 3), 80, 0, 0, 80);
                        p[0] = -1;
                        pos = -1;
                        arrCombo[0] = 1;
                        break;
                    case "2":
                        //g.FillRectangle(Brushes.Olive, 80, 0, 80, 80);
                        g.DrawLine(new Pen(Color.Blue, 3), 80, 0, 160, 80);
                        g.DrawLine(new Pen(Color.Blue, 3), 160, 0, 80, 80);
                        p[1] = -1;
                        pos = -1;
                        arrCombo[1] = 1;
                        break;
                    case "3":
                        //g.FillRectangle(Brushes.Olive, 160, 0, 80, 80);
                        g.DrawLine(new Pen(Color.Blue, 3), 160, 0, 240, 80);
                        g.DrawLine(new Pen(Color.Blue, 3), 240, 0, 160, 80);
                        p[2] = -1;
                        pos = -1;
                        arrCombo[2] = 1;
                        break;
                    case "4":
                        //g.FillRectangle(Brushes.Olive, 0, 80, 80, 80);
                        g.DrawLine(new Pen(Color.Blue, 3), 0, 80, 80, 160);
                        g.DrawLine(new Pen(Color.Blue, 3), 80, 80, 0, 160);
                        p[3] = -1;
                        pos = -1;
                        arrCombo[3] = 1;
                        break;
                    case "5":
                        //g.FillRectangle(Brushes.Olive, 80, 80, 80, 80);
                        g.DrawLine(new Pen(Color.Blue, 3), 80, 80, 160, 160);
                        g.DrawLine(new Pen(Color.Blue, 3), 160, 80, 80, 160);
                        p[4] = -1;
                        pos = -1;
                        arrCombo[4] = 1;
                        break;
                    case "6":
                        //g.FillRectangle(Brushes.Olive, 160, 80, 80, 80);
                        g.DrawLine(new Pen(Color.Blue, 3), 160, 80, 240, 160);
                        g.DrawLine(new Pen(Color.Blue, 3), 240, 80, 160, 160);
                        p[5] = -1;
                        pos = -1;
                        arrCombo[5] = 1;
                        break;
                    case "7":
                        //g.FillRectangle(Brushes.Olive, 0, 160, 80, 80);
                        g.DrawLine(new Pen(Color.Blue, 3), 0, 160, 80, 240);
                        g.DrawLine(new Pen(Color.Blue, 3), 80, 160, 0, 240);
                        p[6] = -1;
                        pos = -1;
                        arrCombo[6] = 1;
                        break;
                    case "8":
                        //g.FillRectangle(Brushes.Olive, 80, 160, 80, 80);
                        g.DrawLine(new Pen(Color.Blue, 3), 80, 160, 160, 240);
                        g.DrawLine(new Pen(Color.Blue, 3), 160, 160, 80, 240);
                        p[7] = -1;
                        pos = -1;
                        arrCombo[7] = 1;
                        break;
                    case "9":
                        //g.FillRectangle(Brushes.Olive, 160, 160, 80, 80);
                        g.DrawLine(new Pen(Color.Blue, 3), 240, 160, 160, 240);
                        g.DrawLine(new Pen(Color.Blue, 3), 160, 160, 240, 240);
                        p[8] = -1;
                        pos = -1;
                        arrCombo[8] = 1;
                        break;
                }

            }
            if (count == 2 | count == 4 | count == 6 | count == 8 | countZero == 1 | countZero == 3 | countZero == 5 | countZero == 7 | countZero == 9)
            {

                switch (Convert.ToString(pos))
                {
                    case "1":
                        //g.FillRectangle(Brushes.Gold, 0, 0, 80, 80);
                        g.DrawEllipse(new Pen(Color.Red, 3), 0, 0, 80, 80);
                        p[0] = -1;
                        pos = -1;
                        arrComboX[0] = 1;
                        break;
                    case "2":
                        //g.FillRectangle(Brushes.Gold, 80, 0, 80, 80);
                        g.DrawEllipse(new Pen(Color.Red, 3), 80, 0, 80, 80);
                        p[1] = -1;
                        pos = -1;
                        arrComboX[1] = 1;
                        break;
                    case "3":
                        //g.FillRectangle(Brushes.Gold, 160, 0, 80, 80);
                        g.DrawEllipse(new Pen(Color.Red, 3), 160, 0, 80, 80);
                        p[2] = -1;
                        pos = -1;
                        arrComboX[2] = 1;
                        break;
                    case "4":
                        //g.FillRectangle(Brushes.Gold, 0, 80, 80, 80);
                        g.DrawEllipse(new Pen(Color.Red, 3), 0, 80, 80, 80);
                        p[3] = -1;
                        pos = -1;
                        arrComboX[3] = 1;
                        break;
                    case "5":
                        //g.FillRectangle(Brushes.Gold, 80, 80, 80, 80);
                        g.DrawEllipse(new Pen(Color.Red, 3), 80, 80, 80, 80);
                        p[4] = -1;
                        pos = -1;
                        arrComboX[4] = 1;
                        break;
                    case "6":
                        //g.FillRectangle(Brushes.Gold, 160, 80, 80, 80);
                        g.DrawEllipse(new Pen(Color.Red, 3), 160, 80, 80, 80);
                        p[5] = -1;
                        pos = -1;
                        arrComboX[5] = 1;
                        break;
                    case "7":
                        //g.FillRectangle(Brushes.Gold, 0, 160, 80, 80);
                        g.DrawEllipse(new Pen(Color.Red, 3), 0, 160, 80, 80);
                        p[6] = -1;
                        pos = -1;
                        arrComboX[6] = 1;
                        break;
                    case "8":
                        //g.FillRectangle(Brushes.Gold, 80, 160, 80, 80);
                        g.DrawEllipse(new Pen(Color.Red, 3), 80, 160, 80, 80);
                        p[7] = -1;
                        pos = -1;
                        arrComboX[7] = 1;
                        break;
                    case "9":
                        //g.FillRectangle(Brushes.Gold, 160, 160, 80, 80);
                        g.DrawEllipse(new Pen(Color.Red, 3), 160, 160, 80, 80);
                        p[8] = -1;
                        pos = -1;
                        arrComboX[8] = 1;
                        break;
                }

            }
            //Логика бота
            if (botEnable == 1)
            {
                Random rnd = new Random();
                int botStep = rnd.Next(0,8);
                //дабы бот не моросил и не занимал две очереди
                int flag = 0;
                while (botStepCheckPos[botStep] != p[botStep])
                {
                    if (count > 8 | countZero > 8)
                    {
                        break;
                    }
                    botStep = rnd.Next(0, 8);
                }
                //очередь бота
                if (botStepCheckPos[botStep] == p[botStep])
                {

                    if ((count == 2 | count == 4 | count == 6 | count == 8) || (countZero == 1 || countZero == 3 || countZero == 5 || countZero == 7 || countZero == 9) & flag == 0)
                    {
                        countZero++;
                        count++;
                        switch (Convert.ToString(botStepCheckPos[botStep]))
                        {
                            case "1":
                                g.DrawLine(new Pen(Color.Green, 3), 0, 0, 80, 80);
                                g.DrawLine(new Pen(Color.Green, 3), 80, 0, 0, 80);
                                p[0] = -1;
                                pos = -1;
                                arrCombo[0] = 1;
                                break;
                            case "2":
                                //g.FillRectangle(Brushes.Olive, 80, 0, 80, 80);
                                g.DrawLine(new Pen(Color.Green, 3), 80, 0, 160, 80);
                                g.DrawLine(new Pen(Color.Green, 3), 160, 0, 80, 80);
                                p[1] = -1;
                                pos = -1;
                                arrCombo[1] = 1;
                                break;
                            case "3":
                                //g.FillRectangle(Brushes.Olive, 160, 0, 80, 80);
                                g.DrawLine(new Pen(Color.Green, 3), 160, 0, 240, 80);
                                g.DrawLine(new Pen(Color.Green, 3), 240, 0, 160, 80);
                                p[2] = -1;
                                pos = -1;
                                arrCombo[2] = 1;
                                break;
                            case "4":
                                //g.FillRectangle(Brushes.Olive, 0, 80, 80, 80);
                                g.DrawLine(new Pen(Color.Green, 3), 0, 80, 80, 160);
                                g.DrawLine(new Pen(Color.Green, 3), 80, 80, 0, 160);
                                p[3] = -1;
                                pos = -1;
                                arrCombo[3] = 1;
                                break;
                            case "5":
                                //g.FillRectangle(Brushes.Olive, 80, 80, 80, 80);
                                g.DrawLine(new Pen(Color.Green, 3), 80, 80, 160, 160);
                                g.DrawLine(new Pen(Color.Green, 3), 160, 80, 80, 160);
                                p[4] = -1;
                                pos = -1;
                                arrCombo[4] = 1;
                                break;
                            case "6":
                                //g.FillRectangle(Brushes.Olive, 160, 80, 80, 80);
                                g.DrawLine(new Pen(Color.Green, 3), 160, 80, 240, 160);
                                g.DrawLine(new Pen(Color.Green, 3), 240, 80, 160, 160);
                                p[5] = -1;
                                pos = -1;
                                arrCombo[5] = 1;
                                break;
                            case "7":
                                //g.FillRectangle(Brushes.Olive, 0, 160, 80, 80);
                                g.DrawLine(new Pen(Color.Green, 3), 0, 160, 80, 240);
                                g.DrawLine(new Pen(Color.Green, 3), 80, 160, 0, 240);
                                p[6] = -1;
                                pos = -1;
                                arrCombo[6] = 1;
                                break;
                            case "8":
                                //g.FillRectangle(Brushes.Olive, 80, 160, 80, 80);
                                g.DrawLine(new Pen(Color.Green, 3), 80, 160, 160, 240);
                                g.DrawLine(new Pen(Color.Green, 3), 160, 160, 80, 240);
                                p[7] = -1;
                                pos = -1;
                                arrCombo[7] = 1;
                                break;
                            case "9":
                                //g.FillRectangle(Brushes.Olive, 160, 160, 80, 80);
                                g.DrawLine(new Pen(Color.Green, 3), 240, 160, 160, 240);
                                g.DrawLine(new Pen(Color.Green, 3), 160, 160, 240, 240);
                                p[8] = -1;
                                pos = -1;
                                arrCombo[8] = 1;
                                break;
                        }
                        flag = 1;
                    }
                    if ((count == 1 | count == 3 | count == 5 | count == 7 | count == 9) || (countZero == 2 || countZero == 4 || countZero == 6 || countZero == 8) & flag == 0)
                    {
                        countZero++;
                        count++;
                        switch (Convert.ToString(botStepCheckPos[botStep]))
                        {
                            case "1":
                                //g.FillRectangle(Brushes.Gold, 0, 0, 80, 80);
                                g.DrawEllipse(new Pen(Color.Green, 3), 0, 0, 80, 80);
                                p[0] = -1;
                                pos = -1;
                                arrComboX[0] = 1;
                                break;
                            case "2":
                                //g.FillRectangle(Brushes.Gold, 80, 0, 80, 80);
                                g.DrawEllipse(new Pen(Color.Green, 3), 80, 0, 80, 80);
                                p[1] = -1;
                                pos = -1;
                                arrComboX[1] = 1;
                                break;
                            case "3":
                                //g.FillRectangle(Brushes.Gold, 160, 0, 80, 80);
                                g.DrawEllipse(new Pen(Color.Green, 3), 160, 0, 80, 80);
                                p[2] = -1;
                                pos = -1;
                                arrComboX[2] = 1;
                                break;
                            case "4":
                                //g.FillRectangle(Brushes.Gold, 0, 80, 80, 80);
                                g.DrawEllipse(new Pen(Color.Green, 3), 0, 80, 80, 80);
                                p[3] = -1;
                                pos = -1;
                                arrComboX[3] = 1;
                                break;
                            case "5":
                                //g.FillRectangle(Brushes.Gold, 80, 80, 80, 80);
                                g.DrawEllipse(new Pen(Color.Green, 3), 80, 80, 80, 80);
                                p[4] = -1;
                                pos = -1;
                                arrComboX[4] = 1;
                                break;
                            case "6":
                                //g.FillRectangle(Brushes.Gold, 160, 80, 80, 80);
                                g.DrawEllipse(new Pen(Color.Green, 3), 160, 80, 80, 80);
                                p[5] = -1;
                                pos = -1;
                                arrComboX[5] = 1;
                                break;
                            case "7":
                                //g.FillRectangle(Brushes.Gold, 0, 160, 80, 80);
                                g.DrawEllipse(new Pen(Color.Green, 3), 0, 160, 80, 80);
                                p[6] = -1;
                                pos = -1;
                                arrComboX[6] = 1;
                                break;
                            case "8":
                                //g.FillRectangle(Brushes.Gold, 80, 160, 80, 80);
                                g.DrawEllipse(new Pen(Color.Green, 3), 80, 160, 80, 80);
                                p[7] = -1;
                                pos = -1;
                                arrComboX[7] = 1;
                                break;
                            case "9":
                                //g.FillRectangle(Brushes.Gold, 160, 160, 80, 80);
                                g.DrawEllipse(new Pen(Color.Green, 3), 160, 160, 80, 80);
                                p[8] = -1;
                                pos = -1;
                                arrComboX[8] = 1;
                                break;
                        }
                        flag = 1;
                    }

                }

            }
            //Горизонтальная Победа крестиков
            if (arrCombo[0] == 1 & arrCombo[1] == 1 & arrCombo[2] == 1)
                MessageBox.Show("Победа крестиков!");
            if (arrCombo[3] == 1 & arrCombo[4] == 1 & arrCombo[5] == 1)
                MessageBox.Show("Победа крестиков!");
            if (arrCombo[6] == 1 & arrCombo[7] == 1 & arrCombo[8] == 1)
                MessageBox.Show("Победа крестиков!");
            //Горизонтальная Победа ноликов
            if (arrComboX[6] == 1 & arrComboX[7] == 1 & arrComboX[8] == 1)
                MessageBox.Show("Победа ноликов!");
            if (arrComboX[0] == 1 & arrComboX[1] == 1 & arrComboX[2] == 1)
                MessageBox.Show("Победа ноликов!");
            if (arrComboX[3] == 1 & arrComboX[4] == 1 & arrComboX[5] == 1)
                MessageBox.Show("Победа ноликов!");
            //Вертикальная Победа крестиков
            if (arrCombo[0] == 1 & arrCombo[3] == 1 & arrCombo[6] == 1)
                MessageBox.Show("Победа крестиков!");
            if (arrCombo[1] == 1 & arrCombo[4] == 1 & arrCombo[7] == 1)
                MessageBox.Show("Победа крестиков!");
            if (arrCombo[2] == 1 & arrCombo[5] == 1 & arrCombo[8] == 1)
                MessageBox.Show("Победа крестиков!");
            //Вертикальная победа Ноликов
            if (arrComboX[2] == 1 & arrComboX[5] == 1 & arrComboX[8] == 1)
                MessageBox.Show("Победа ноликов!");
            if (arrComboX[0] == 1 & arrComboX[3] == 1 & arrComboX[6] == 1)
                MessageBox.Show("Победа ноликов!");
            if (arrComboX[1] == 1 & arrComboX[4] == 1 & arrComboX[7] == 1)
                MessageBox.Show("Победа ноликов!");
            //Диагональная победа крестиков
            if (arrCombo[0] == 1 & arrCombo[4] == 1 & arrCombo[8] == 1)
                MessageBox.Show("Победа крестиков!");
            if (arrCombo[2] == 1 & arrCombo[4] == 1 & arrCombo[6] == 1)
                MessageBox.Show("Победа крестиков!");
            //Диагональная победа ноликов
            if (arrComboX[0] == 1 & arrComboX[4] == 1 & arrComboX[8] == 1)
                MessageBox.Show("Победа ноликов!");
            if (arrComboX[2] == 1 & arrComboX[4] == 1 & arrComboX[6] == 1)
                MessageBox.Show("Победа ноликов!");


        }
        //Reset
        private void button5_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            g.DrawLine(Pens.Black, 80, 0, 80, 240);
            g.DrawLine(Pens.Black, 160, 0, 160, 240);
            g.DrawLine(Pens.Black, 0, 80, 240, 80);
            g.DrawLine(Pens.Black, 0, 160, 240, 160);
            pos = 0;
            count = 0;
            //Обнуление позиций
            for (int i = 0; i < arrCombo.Length; i++)
                arrCombo[i] = 0;
            for (int j = 0; j < arrComboX.Length; j++)
                arrComboX[j] = 0;
            //Обнуление позиций (чтобы повторно не кликались)
            p[0] = 1;
            p[1] = 2;
            p[2] = 3;
            p[3] = 4;
            p[4] = 5;
            p[5] = 6;
            p[6] = 7;
            p[7] = 8;
            p[8] = 9;
            //Обнуление очереди 
            button2.BackColor = Color.FromArgb(255, 255, 255);
            button1.BackColor = Color.FromArgb(255, 255, 255);
            button3.BackColor = Color.FromArgb(255, 255, 255);
            button4.BackColor = Color.FromArgb(255, 255, 255);
            count = 0;
            countZero = -999;
            botEnable = 0;
            int[] botStepCheckPos = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] botStepChecked = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        }
        //Режим с ботом
        private void button3_Click_1(object sender, EventArgs e)
        {
            botEnable = 1;
            button3.BackColor = Color.FromArgb(11, 218, 81);
            button4.BackColor = Color.FromArgb(255, 36, 0);
        }
        //Очередь крестиков
        private void button1_Click(object sender, EventArgs e)
        {
            count = 0;
            countZero = -999;
            button2.BackColor = Color.FromArgb(255, 36, 0);
            button1.BackColor = Color.FromArgb(11, 218, 81);
        }
        //Очередь ноликов
        private void button2_Click(object sender, EventArgs e)
        {
            countZero = 0;
            count = -999;
            button1.BackColor = Color.FromArgb(255, 36, 0);
            button2.BackColor = Color.FromArgb(11, 218, 81);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(11, 218, 81);
            button3.BackColor = Color.FromArgb(255, 36, 0);
        }
        //Режим с другом


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FifteenNumberGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 按钮的行，列数
        const int N = 4;
        // 按钮的数组
        Button[,] Buttons = new Button[N, N];
        private void Form1_Load(object sender, EventArgs e)
        {
            // 产生所有按钮
            GenerateAllButtons();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // 打乱顺序
            Shuffle();
        }
        
        // 产生所有按钮
        void GenerateAllButtons()
        {
            int x0 = 100, y0 = 10, w = 45, d = 50;
            for (int r = 0; r < N; r++)
            {
                for (int c = 0; c < N; c++)
                {
                    int num = r * N + c;
                    Button btn = new Button();
                    btn.Text = (num + 1).ToString();
                    btn.Top = y0 + r * d;
                    btn.Left = x0 + c * d;
                    btn.Width = w;
                    btn.Height = w;
                    btn.Visible = true;
                    // 这个数据用来表示按钮所在的行和列
                    btn.Tag = r * N + c;
                    // 注册事件
                    btn.Click += new EventHandler(btn_Click);

                    // 将生成的按钮放入数组中
                    Buttons[r, c] = btn;
                    // 将生成的按钮加到界面上
                    this.Controls.Add(btn);
                }
            }
             // 将最后一个按钮设为空白
            Buttons[N - 1, N - 1].Visible = false;
        }
        // 打乱顺序
        void Shuffle()
        {
            // 多次随机交换两个按钮
            Random rnd = new Random();
            for ( int i = 0; i < 100; i++ )
            {
                int r1 = rnd.Next(N);
                int c1 = rnd.Next(N);
                int r2 = rnd.Next(N);
                int c2 = rnd.Next(N);
                Swap(Buttons[r1, c1], Buttons[r2, c2]);
            }
        }
        // 交换两个按钮
        void Swap (Button btna, Button btnb)
        {
            string tmp = btna.Text;
            btna.Text = btnb.Text;
            btnb.Text = tmp;

            bool vis = btna.Visible;
            btna.Visible = btnb.Visible;
            btnb.Visible = vis;
        }
        void btn_Click(object sender, EventArgs e)
        {
            // 当前点中的按钮
            Button btn = sender as Button;
            // 空白按钮
            Button blank = FindHideButton();

            if ( IsNeighbor(btn ,blank))
            {
                Swap (btn, blank);
                blank.Focus();
            }

            // 判定是否完成了
            if ( ResuletIsOK() )
            {
                MessageBox.Show("OK");
            }
        }

        // 查找要隐藏的按钮
        Button FindHideButton()
        {
            for ( int r = 0; r < N; r++ )
            {
                for ( int c = 0; c < N; c++)
                {
                    if ( Buttons[r, c].Visible == false )
                    {
                        return Buttons[r, c];
                    }
                }
            }
            return null;
        }

        // 判断是否相邻
        bool IsNeighbor (Button btna, Button btnb)
        {
            // Tag中纪录了行列位置
            int a = (int)btna.Tag;
            int b = (int)btnb.Tag;
            int r1 = a/N, c1 = a%N;
            int r2 = b/N, c2 = b%N;
            // 左右相邻
            if (r1 == r2 && (c1 == c2 - 1 || c1 == c2 + 1)
                    || c1 == c2 && (r1 == r2 - 1 || r1 == r2 + 1))
            {
                return true;
            }
            return false;
        }

        // 检查是否完成
        bool ResuletIsOK ()
        {
            for ( int r = 0; r < N; r++ )
            {
                for ( int c = 0; c < N; c++)
                {
                    if ( Buttons[r ,c ].Text != ( r*N + c + 1).ToString() )
                    {
                            return false;
                    }
                }
            }
            return true;
        }

    }
}


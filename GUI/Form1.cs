using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_Client.DTO;
using Newtonsoft.Json;
namespace PBL3_Client.GUI
{
    public partial class Form1 : Form
    {
        public delegate void myDel();
        public myDel F { get; set; }
        List<ListFoodOrder> lor = new List<ListFoodOrder>();
        List<DVKH> LDV = new List<DVKH>()
        {
            new DVKH(1,"mo may"),
            new DVKH(2,"dong may - tinh tien"),
            new DVKH(3,"goi mon"),
            new DVKH(4,"nap tien")
        };
        connectCLIENT client = new connectCLIENT();
        TK tk;
        MAY may;
        int h = 0;
        int m = 0;
        public Form1()
        {
            InitializeComponent();

            // loadformlogin();
        }
        public Form1(connectCLIENT clientfromdn, TK tk, MAY may)
        {
            CheckForIllegalCrossThreadCalls = false;
            this.may = may;
            this.tk = tk;
            this.client = clientfromdn;
            InitializeComponent();
            load();
            loadlistfood();
        }
        void AddlistOreder(Food F,int n)
        {
            lor.Add(new ListFoodOrder() { IDFood = F.IDFood, Soluong = n, TongTien = n * Int32.Parse(F.Gia.ToString()) });
            AddPanelorder(F,n);
        }
        void AddPanelorder(Food O,int n)
        {
            Panel P = new Panel();
            Panel P1 = new Panel();
            P1.Dock = DockStyle.Right;
            P1.Size = new Size(100, 100);
            P1.BackColor = Color.Yellow;
            Label TenF = new Label();
            TenF.Font = new Font("arial", 7);
            TenF.ForeColor = Color.Red;
            TenF.Text = O.TenFood + "\n" + O.Gia.ToString() + "\n so luong : " + n.ToString();
            // TenF.Location = new Point(P.Location.X -10, P.Location.Y + 10);
            TenF.Dock = DockStyle.Left;
            P1.Controls.Add(TenF);
            P.BackColor = Color.Blue;
            P.Size = new Size(180, 50);
            P.Controls.Add(P1);
            // Button B = new Button();
            //B.Dock = DockStyle.Top;
            // B.Size = new Size(180, 50);
            flowLayoutPanel1.Controls.Add(P);
            //  flowLayoutPanel1.Controls.Add(new Button());
        }
        void load()
        {
            buttonout.Enabled = (tk.real == true) ? true : false;
            client.DelKH = new connectCLIENT.ClientDel2(DV);
            userControldvkh1.F = new UserControlDVKH.myDel(AddlistOreder);
            labelMay.Text = may.TenMay;
            labelTK.Text = tk.TenTK;
            labelTIEN.Text = tk.SoDu.ToString();
            labelTimePlayed.Text = h.ToString() + ":" + m.ToString();
            Thread time = new Thread(() => {
                while (true)
                {
                    tk.SoDu -=(may.gia/60);
                    if (tk.SoDu <= 0) {
                        tk.SoDu = 0;
                        this.Close(); }
                    m++;
                    if (m == 59)
                    {
                        m = 0;
                        h++;
                    }
                    labelTimePlayed.Text = h.ToString() + ":" + m.ToString();
                    labelTIEN.Text = tk.SoDu.ToString();
                    Thread.Sleep(1000);
                }
            });
            time.IsBackground = true;
            time.Start();
            if (tk.real)
            {
                client.send(new object[] { 0, LDV[0].MaDV, may.MaMay,tk.IDTK });
            }
            else
            {
                client.send(new object[] { 0, LDV[0].MaDV,null });
            }
            
        }
        void sendorder()
        {
            client.send(new object[] { 1, LDV[2].MaDV, may.MaMay, JsonConvert.SerializeObject(lor,Formatting.Indented) });
        }
        void DV(object[] dv)
        {
            //int s = Int32.Parse(LDV[1].ma.ToString());
            //switch (dv[1])
            //{
            //    case 0:
            //        userControldvkh1.loadlistfood(dv[2]);
            //        break;

            //    case 2:
            //        this.Close();
            //        break;
            //}

            int m = Int32.Parse(dv[1].ToString());
            if (m == 0) userControldvkh1.loadlistfood(dv[2],dv[3]);
            else if (m == Int32.Parse(LDV[1].MaDV.ToString())) this.Close();
            else if (m == Int32.Parse(LDV[3].MaDV.ToString())) { tk.SoDu += Int32.Parse(dv[2].ToString()); labelTIEN.Text = tk.SoDu.ToString(); };
        }
        void loadlistfood()
        {
            client.send(new object[] { 0, -2 });
        }
        private void buttonDVKH_Click(object sender, EventArgs e)
        {
            userControldvkh1.BringToFront();
        }

        private void buttonCHAT_Click(object sender, EventArgs e)
        {
            userControlchat1.BringToFront();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // client.close();
            F();
            client.send(new object[] { 1, LDV[1].MaDV, may.MaMay });
        }

        private void buttonThanhtoan_Click(object sender, EventArgs e)
        {
            sendorder();
        }

        private void buttonout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            labelTIEN.Text = 1000.ToString();
        }
    }
}

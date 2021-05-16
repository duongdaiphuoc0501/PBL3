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
    public partial class DANGNHAP : Form
    {
        List<DVKH> LDV = new List<DVKH>()
        {
            new DVKH(1,"mo may"),
            new DVKH(2,"dong may - tinh tien"),
            new DVKH(3,"goi mon")
        };
        Thread th;
        connectCLIENT client = new connectCLIENT();
        List<MAY> l = new List<MAY>();
        public DANGNHAP()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            // setCBB();
            client.connect();
            client.DelDN = new connectCLIENT.ClientDel(DV);
            // client.send(new object[] { 0, 0 });
            loadclient();
        }
        void loadclient()
        {
            client.send(new object[] { 0, -1 });
        }

        void DV(object[] obj)
        {
            int m = Int32.Parse(obj[1].ToString());
            if (m == 0) setCBB(obj);
            else if (m == Int32.Parse(LDV[0].MaDV.ToString())) ShowForm1(obj);
        }
        public void ShowForm1(object[] obj)
        {
            CBBitem idmay = comboBoxMay.SelectedItem as CBBitem;
            MAY M = (JsonConvert.DeserializeObject<MAY>(obj[2].ToString()));
            TK T= (JsonConvert.DeserializeObject<TK>(obj[3].ToString()));
            T.real = bool.Parse(obj[4].ToString());
            if (M.MaMay == idmay.id.ToString())
            {
                Form1 f1 = new Form1(client,T ,M);
                f1.F = new Form1.myDel(showagain);
               // f1.Show();
                this.Visible = false;
                th = new Thread(() =>
                {
                    f1.ShowDialog();
                    this.Visible = true;
                });
                th.IsBackground = true;
                th.Start();
            }
            else
            {
                //MessageBox.Show("khong tim thay may");
            }
        }
        void showagain()
        {
            this.Visible = true;
           // th.Abort();
        }
        void setCBB(object[] obj)
        {
            comboBoxMay.Items.Clear();
            //this.l.AddRange(obj[2] as List<MAY>);
            this.l = JsonConvert.DeserializeObject<List<MAY>>(obj[2].ToString());
           // this.l = obj[2] as List<MAY>;
            foreach (MAY i in l)
            {
                comboBoxMay.Items.Add(new CBBitem { id = i.MaMay, name = i.TenMay });
            }
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            client.send(new object[] {0,0,textBoxTK.Text,textBoxMK.Text,((CBBitem)comboBoxMay.SelectedItem).id });
        }
    }
}

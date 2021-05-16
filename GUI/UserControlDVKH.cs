using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_Client.DTO;
using Newtonsoft.Json;
namespace PBL3_Client.GUI
{
    public partial class UserControlDVKH : UserControl
    {
        List<DVKH> LDV = new List<DVKH>()
        {
            new DVKH(1,"mo may"),
            new DVKH(2,"dong may - tinh tien"),
            new DVKH(3,"goi mon")
        };
        public delegate void myDel(Food F,int n);
        public myDel F { get; set; }
        List<Food> LFood = new List<Food>();
        public Food selectedF;
        public List<TypeFood> LType = new List<TypeFood>();
        public UserControlDVKH()
        {
            InitializeComponent();
        }
        void loadTypeForm()
        {
            tabControl1.TabPages.Clear();
            FlowLayoutPanel fall = new FlowLayoutPanel()
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Silver,
            };
            TabPage Tall = new TabPage()
            {
                Name = "ALL",
                Text = "ALL"
            };
            foreach (Food j in LFood)
            {
                Panel a = new Panel();
                loaddv(j, a,fall);
            }
            Tall.Controls.Add(fall);
            this.BeginInvoke((Action)(() =>
            {
                tabControl1.Controls.Add(Tall);
            }));
           // tabControl1.Controls.Add(Tall);

            foreach (TypeFood i in LType)
            {
                FlowLayoutPanel f = new FlowLayoutPanel()
                {
                    Dock = DockStyle.Fill,
                    BackColor = Color.Silver,
                };
                TabPage T = new TabPage()
                {
                    Name = i.TenType,
                    Text = i.TenType
                };
                foreach (Food j in LFood)
                {
                    if (j.TypeF == i.IDType)
                    {
                        Panel a = new Panel();
                        loaddv(j, a, f);
                    }
                }
                T.Controls.Add(f);
                this.BeginInvoke((Action)(() =>
                {
                    tabControl1.Controls.Add(T);
                }));
            }
        }
        public void load()
        {
            loadTypeForm();
        }
        public void loadlistfood(object obj,object obj2)
        {
            //LFood.AddRange(obj as List<Food>);
            LType = JsonConvert.DeserializeObject<List<TypeFood>>(obj2.ToString());
            LFood = JsonConvert.DeserializeObject<List<Food>>(obj.ToString());
            loadTypeForm();
        }
        void setbutton(Button b, Food i)
        {
            b.Size = new Size(100, 100);
            b.BackgroundImage = new Bitmap("E:/c#/PBL3-test1/PBL3-test1/Resources/dv.png");
            b.BackgroundImageLayout = ImageLayout.Zoom;
            b.Tag = i;
            b.Click += B_Click;

        }


        void loaddv(Food i,Panel a,FlowLayoutPanel f)
        {
            a.Size = new Size(100, 120);
            Button b = new Button();
            Label c = new Label();
            c.Font = new Font("arial", 9);
            c.Text = i.TenFood;
            a.Controls.Add(b);
            a.Controls.Add(c);
            c.Dock = DockStyle.Bottom;
            b.Dock = DockStyle.Fill;
            setbutton(b, i);
            f.Controls.Add(a);
        }
        private void B_Click(object sender, EventArgs e)
        {
            selectedF = (sender as Button).Tag as Food;
        }

        private void buttonorder_Click(object sender, EventArgs e)
        {
            F(selectedF,Int32.Parse(numericUpDown1.Value.ToString()));
        }
    }
}

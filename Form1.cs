namespace BurgerKiosk
{
    public partial class BurgerKiosk : Form
    {
        public BurgerKiosk()
        {
            InitializeComponent();
        }
            public int totalcost = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            grpS.SendToBack();  
            grpM.SendToBack();
            groupBox3.SendToBack();
            groupBox4.SendToBack();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void gpM_Enter(object sender, EventArgs e)
        {

        }

        private void cancle_Click(object sender, EventArgs e)
        {
            RBOItaly.Checked = false;
            RBO2.Checked = false;
            RBO3.Checked = false;
            chkFF.Checked = false;
            chkOR.Checked = false;
            chkCS.Checked = false;
            chkGP.Checked = false;
            lstOrder.Items.Clear();
            totalcost = 0;
            lblp.Text = "총 금액: 0원";
        }

        private void order_Click(object sender, EventArgs e)
        {
            if (!RBOItaly.Checked && !RBO2.Checked && !RBO3.Checked)
            {
                MessageBox.Show("메뉴를 선택하세요.");
                return;
            }

            totalcost = 0;
            lstOrder.Items.Clear();

            if (RBOItaly.Checked) { totalcost += 5000; lstOrder.Items.Add("이탈리안 살사베르데 5,000원"); }
            else if (RBO2.Checked) { totalcost += 4000; lstOrder.Items.Add("통새우 와퍼 4,000원"); }
            else if (RBO3.Checked) { totalcost += 3000; lstOrder.Items.Add("비프불고기버거 3,000원"); }

            if (chkFF.Checked) { totalcost += 3500; lstOrder.Items.Add("프렌치 프라이 3,500원"); }
            if (chkOR.Checked) { totalcost += 2500; lstOrder.Items.Add("어니언링 2,500원"); }
            if (chkCS.Checked) { totalcost += 1500; lstOrder.Items.Add("치즈스틱 1,500원"); }
            if (chkGP.Checked) { totalcost += 500; lstOrder.Items.Add("고구마 파이 500원"); }

            lblp.Text = "총 금액: " + totalcost.ToString("N0") + "원";
        }
    }
}
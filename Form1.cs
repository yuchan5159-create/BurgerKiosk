namespace BurgerKiosk
{
    public partial class BurgerKiosk : Form
    {
        public BurgerKiosk()
        {
            InitializeComponent();
        }
            public int totalcost = 0;

            // 모든 선택 가능한 컨트롤 목록 (Tab 이동 순서)
            private Control[] allItems = null!;
            private int currentIndex = 0;

            private void Form1_Load(object sender, EventArgs e)
            {
                grpS.SendToBack();
                grpM.SendToBack();
                groupBox3.SendToBack();
                groupBox4.SendToBack();

                RBOItaly.Checked = false;
                RBO2.Checked = false;
                RBO3.Checked = false;
                lblerror.Visible = false;

                // 선택 변경 시 즉시 업데이트
                RBOItaly.CheckedChanged += Item_CheckedChanged;
                RBO2.CheckedChanged += Item_CheckedChanged;
                RBO3.CheckedChanged += Item_CheckedChanged;
                chkFF.CheckedChanged += Item_CheckedChanged;
                chkOR.CheckedChanged += Item_CheckedChanged;
                chkCS.CheckedChanged += Item_CheckedChanged;
                chkGP.CheckedChanged += Item_CheckedChanged;

                // Tab/방향키로 이동할 컨트롤 순서 정의
                allItems = [RBOItaly, RBO2, RBO3, chkFF, chkOR, chkCS, chkGP, order, cancle];
                currentIndex = 0;
                allItems[currentIndex].Focus();
            }

            private void Item_CheckedChanged(object? sender, EventArgs e)
            {
                UpdateOrder();
            }

            private void UpdateOrder()
            {
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
                lblerror.Visible = false;
            }

            protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
            {
                switch (keyData)
                {
                    case Keys.Tab:
                    case Keys.Down:
                        // 다음 항목으로 이동
                        currentIndex = (currentIndex + 1) % allItems.Length;
                        allItems[currentIndex].Focus();
                        return true;

                    case Keys.Shift | Keys.Tab:
                    case Keys.Up:
                        // 이전 항목으로 이동
                        currentIndex = (currentIndex - 1 + allItems.Length) % allItems.Length;
                        allItems[currentIndex].Focus();
                        return true;

                    case Keys.Space:
                        // 현재 항목 선택/토글
                        if (allItems[currentIndex] is RadioButton rb)
                            rb.Checked = true;
                        else if (allItems[currentIndex] is CheckBox chk)
                            chk.Checked = !chk.Checked;
                        return true;

                    case Keys.Enter:
                        // Enter는 항상 주문하기
                        order.PerformClick();
                        return true;
                }

                return base.ProcessCmdKey(ref msg, keyData);
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
                lblerror.Visible = true;
                return;
            }

            MessageBox.Show("주문이 완료되었습니다!\n" + lblp.Text, "주문 완료");


        }
    }
}
namespace BurgerKiosk
{
    public partial class BurgerKiosk : Form
    {
        public BurgerKiosk()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gpS.SendToBack();
            gpM.SendToBack();
            groupBox3.SendToBack();
            groupBox4.SendToBack();
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}

namespace BurgerKiosk
{
    partial class BurgerKiosk
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BurgerKiosk));
            LblAppName = new Label();
            RaBu1 = new RadioButton();
            RaBu2 = new RadioButton();
            RaBu3 = new RadioButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            FF = new CheckBox();
            OR = new CheckBox();
            CS = new CheckBox();
            GP = new CheckBox();
            gpS = new GroupBox();
            gpM = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            gpO = new GroupBox();
            cancle = new Button();
            order = new Button();
            lpay = new Label();
            pay = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            gpM.SuspendLayout();
            groupBox3.SuspendLayout();
            gpO.SuspendLayout();
            SuspendLayout();
            // 
            // LblAppName
            // 
            LblAppName.AutoSize = true;
            LblAppName.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblAppName.Location = new Point(4, 9);
            LblAppName.Name = "LblAppName";
            LblAppName.Size = new Size(658, 62);
            LblAppName.TabIndex = 0;
            LblAppName.Text = "BURGERKING EXPRESS ORDER";
            // 
            // RaBu1
            // 
            RaBu1.AutoSize = true;
            RaBu1.Location = new Point(35, 151);
            RaBu1.Name = "RaBu1";
            RaBu1.Size = new Size(169, 24);
            RaBu1.TabIndex = 1;
            RaBu1.TabStop = true;
            RaBu1.Text = "이탈리안 살사베르데";
            RaBu1.UseVisualStyleBackColor = true;
            // 
            // RaBu2
            // 
            RaBu2.AutoSize = true;
            RaBu2.Location = new Point(35, 230);
            RaBu2.Name = "RaBu2";
            RaBu2.Size = new Size(120, 24);
            RaBu2.TabIndex = 2;
            RaBu2.TabStop = true;
            RaBu2.Text = "통새우　와퍼";
            RaBu2.UseVisualStyleBackColor = true;
            // 
            // RaBu3
            // 
            RaBu3.AutoSize = true;
            RaBu3.Location = new Point(35, 313);
            RaBu3.Name = "RaBu3";
            RaBu3.Size = new Size(135, 24);
            RaBu3.TabIndex = 3;
            RaBu3.TabStop = true;
            RaBu3.Text = "비프불고기버거";
            RaBu3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(219, 132);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(219, 209);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(219, 291);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // FF
            // 
            FF.AutoSize = true;
            FF.Location = new Point(394, 170);
            FF.Name = "FF";
            FF.Size = new Size(125, 24);
            FF.TabIndex = 7;
            FF.Text = "프렌치 프라이";
            FF.ThreeState = true;
            FF.UseVisualStyleBackColor = true;
            // 
            // OR
            // 
            OR.AutoSize = true;
            OR.Location = new Point(394, 212);
            OR.Name = "OR";
            OR.Size = new Size(91, 24);
            OR.TabIndex = 8;
            OR.Text = "어니언링";
            OR.UseVisualStyleBackColor = true;
            // 
            // CS
            // 
            CS.AutoSize = true;
            CS.Location = new Point(395, 262);
            CS.Name = "CS";
            CS.Size = new Size(91, 24);
            CS.TabIndex = 9;
            CS.Text = "치즈스틱";
            CS.UseVisualStyleBackColor = true;
            // 
            // GP
            // 
            GP.AutoSize = true;
            GP.Location = new Point(395, 313);
            GP.Name = "GP";
            GP.Size = new Size(110, 24);
            GP.TabIndex = 10;
            GP.Text = "고구마 파이";
            GP.UseVisualStyleBackColor = true;
            // 
            // gpS
            // 
            gpS.Location = new Point(378, 110);
            gpS.Name = "gpS";
            gpS.Size = new Size(160, 289);
            gpS.TabIndex = 15;
            gpS.TabStop = false;
            gpS.Text = "사이드 선택";
            // 
            // gpM
            // 
            gpM.Controls.Add(groupBox3);
            gpM.Location = new Point(12, 87);
            gpM.Name = "gpM";
            gpM.Size = new Size(360, 318);
            gpM.TabIndex = 16;
            gpM.TabStop = false;
            gpM.Text = "메뉴 선택";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Location = new Point(378, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(128, 312);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // groupBox4
            // 
            groupBox4.Location = new Point(3, 23);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(366, 214);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox4";
            // 
            // gpO
            // 
            gpO.Controls.Add(cancle);
            gpO.Controls.Add(order);
            gpO.Controls.Add(lpay);
            gpO.Controls.Add(pay);
            gpO.Location = new Point(559, 81);
            gpO.Name = "gpO";
            gpO.Size = new Size(212, 324);
            gpO.TabIndex = 17;
            gpO.TabStop = false;
            gpO.Text = "주문 내역";
            // 
            // cancle
            // 
            cancle.BackColor = Color.Red;
            cancle.ForeColor = Color.Transparent;
            cancle.Location = new Point(106, 226);
            cancle.Name = "cancle";
            cancle.Size = new Size(94, 29);
            cancle.TabIndex = 21;
            cancle.Text = "초기화";
            cancle.UseVisualStyleBackColor = false;
            // 
            // order
            // 
            order.BackColor = Color.LimeGreen;
            order.ForeColor = Color.Transparent;
            order.Location = new Point(6, 226);
            order.Name = "order";
            order.Size = new Size(94, 29);
            order.TabIndex = 20;
            order.Text = "주문하기";
            order.UseVisualStyleBackColor = false;
            // 
            // lpay
            // 
            lpay.AutoSize = true;
            lpay.Location = new Point(19, 174);
            lpay.Name = "lpay";
            lpay.Size = new Size(50, 20);
            lpay.TabIndex = 19;
            lpay.Text = "label2";
            // 
            // pay
            // 
            pay.FormattingEnabled = true;
            pay.Location = new Point(0, 26);
            pay.Name = "pay";
            pay.Size = new Size(194, 124);
            pay.TabIndex = 18;
            // 
            // BurgerKiosk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 462);
            Controls.Add(gpO);
            Controls.Add(GP);
            Controls.Add(CS);
            Controls.Add(OR);
            Controls.Add(FF);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(RaBu3);
            Controls.Add(RaBu2);
            Controls.Add(RaBu1);
            Controls.Add(LblAppName);
            Controls.Add(gpS);
            Controls.Add(gpM);
            Name = "BurgerKiosk";
            Text = "BurgerKiosk v1.0";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            gpM.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            gpO.ResumeLayout(false);
            gpO.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblAppName;
        private RadioButton RaBu1;
        private RadioButton RaBu2;
        private RadioButton RaBu3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private CheckBox FF;
        private CheckBox OR;
        private CheckBox CS;
        private CheckBox GP;
        private GroupBox gpS;
        private GroupBox gpM;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox gpO;
        private Button cancle;
        private Button order;
        private Label lpay;
        private ListBox pay;
    }
}

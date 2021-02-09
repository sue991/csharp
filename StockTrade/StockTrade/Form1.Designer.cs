
namespace StockTrade
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_login = new System.Windows.Forms.Button();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.accountComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.axKHOpenAPI = new AxKHOpenAPILib.AxKHOpenAPI();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.총매도금액 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.매매수수료 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.매매세금 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.손익금 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.당일수익률 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo거래구분 = new System.Windows.Forms.ComboBox();
            this.btn주문 = new System.Windows.Forms.Button();
            this.cbo매매구분 = new System.Windows.Forms.ComboBox();
            this.txt원주문번호 = new System.Windows.Forms.TextBox();
            this.txt주문가격 = new System.Windows.Forms.TextBox();
            this.txt주문수량 = new System.Windows.Forms.TextBox();
            this.txt주문종목코드 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.종목코드 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.종목명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.현재가 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.저가 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.고가 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.시가 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.대비 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.등락률 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.거래량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.당일평균가 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.기호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.보유수량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.매입 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.평가금액 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.수익률 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(12, 12);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(83, 27);
            this.btn_login.TabIndex = 1;
            this.btn_login.Text = "login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.ItemHeight = 12;
            this.listBoxLog.Location = new System.Drawing.Point(12, 326);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(240, 232);
            this.listBoxLog.TabIndex = 2;
            // 
            // accountComboBox
            // 
            this.accountComboBox.FormattingEnabled = true;
            this.accountComboBox.Location = new System.Drawing.Point(12, 64);
            this.accountComboBox.Name = "accountComboBox";
            this.accountComboBox.Size = new System.Drawing.Size(100, 20);
            this.accountComboBox.TabIndex = 5;
            this.accountComboBox.SelectedIndexChanged += new System.EventHandler(this.accountComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "계좌 선택";
            // 
            // axKHOpenAPI
            // 
            this.axKHOpenAPI.Enabled = true;
            this.axKHOpenAPI.Location = new System.Drawing.Point(12, 565);
            this.axKHOpenAPI.Name = "axKHOpenAPI";
            this.axKHOpenAPI.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axKHOpenAPI.OcxState")));
            this.axKHOpenAPI.Size = new System.Drawing.Size(57, 20);
            this.axKHOpenAPI.TabIndex = 0;
            this.axKHOpenAPI.Visible = false;
            this.axKHOpenAPI.OnReceiveTrData += new AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEventHandler(this.axKHOpenAPI_OnReceiveTrData);
            this.axKHOpenAPI.OnReceiveRealData += new AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveRealDataEventHandler(this.axKHOpenAPI_OnReceiveRealData);
            this.axKHOpenAPI.OnReceiveMsg += new AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveMsgEventHandler(this.axKHOpenAPI_OnReceiveMsg);
            this.axKHOpenAPI.OnReceiveChejanData += new AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveChejanDataEventHandler(this.axKHOpenAPI_OnReceiveChejanData);
            this.axKHOpenAPI.OnEventConnect += new AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEventHandler(this.axKHOpenAPI_OnEventConnect);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.총매도금액,
            this.매매수수료,
            this.매매세금,
            this.손익금,
            this.당일수익률});
            this.dataGridView2.Location = new System.Drawing.Point(274, 45);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.RowHeadersWidth = 21;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(924, 39);
            this.dataGridView2.TabIndex = 31;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "예수금";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "주문가능액";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "유가잔고액";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "당일매수액";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // 총매도금액
            // 
            this.총매도금액.HeaderText = "당일매도액";
            this.총매도금액.Name = "총매도금액";
            // 
            // 매매수수료
            // 
            this.매매수수료.HeaderText = "매매수수료";
            this.매매수수료.Name = "매매수수료";
            // 
            // 매매세금
            // 
            this.매매세금.HeaderText = "매매세금";
            this.매매세금.Name = "매매세금";
            // 
            // 손익금
            // 
            this.손익금.HeaderText = "손익금";
            this.손익금.Name = "손익금";
            // 
            // 당일수익률
            // 
            this.당일수익률.HeaderText = "당일수익률";
            this.당일수익률.Name = "당일수익률";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo거래구분);
            this.groupBox1.Controls.Add(this.btn주문);
            this.groupBox1.Controls.Add(this.cbo매매구분);
            this.groupBox1.Controls.Add(this.txt원주문번호);
            this.groupBox1.Controls.Add(this.txt주문가격);
            this.groupBox1.Controls.Add(this.txt주문수량);
            this.groupBox1.Controls.Add(this.txt주문종목코드);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 216);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "주문입력";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbo거래구분
            // 
            this.cbo거래구분.FormattingEnabled = true;
            this.cbo거래구분.Items.AddRange(new object[] {
            "지정가",
            "시장가",
            "조건부지정가",
            "최유리지정가",
            "최우선지정가",
            "지정가IOC",
            "시장가IOC",
            "최유리IOC",
            "지정가FOK",
            "시장가FOK",
            "최유리FOK",
            "장개시전시간외",
            "시간외단일가매매",
            "시간외종가"});
            this.cbo거래구분.Location = new System.Drawing.Point(84, 46);
            this.cbo거래구분.Name = "cbo거래구분";
            this.cbo거래구분.Size = new System.Drawing.Size(141, 20);
            this.cbo거래구분.TabIndex = 10;
            // 
            // btn주문
            // 
            this.btn주문.Location = new System.Drawing.Point(84, 178);
            this.btn주문.Name = "btn주문";
            this.btn주문.Size = new System.Drawing.Size(141, 30);
            this.btn주문.TabIndex = 12;
            this.btn주문.Text = "주     문";
            this.btn주문.UseVisualStyleBackColor = true;
            this.btn주문.Click += new System.EventHandler(this.btn주문_Click);
            // 
            // cbo매매구분
            // 
            this.cbo매매구분.FormattingEnabled = true;
            this.cbo매매구분.Items.AddRange(new object[] {
            "신규매수",
            "신규매도",
            "매수취소",
            "매도취소",
            "매수정정",
            "매도정정"});
            this.cbo매매구분.Location = new System.Drawing.Point(84, 70);
            this.cbo매매구분.Name = "cbo매매구분";
            this.cbo매매구분.Size = new System.Drawing.Size(141, 20);
            this.cbo매매구분.TabIndex = 11;
            // 
            // txt원주문번호
            // 
            this.txt원주문번호.Location = new System.Drawing.Point(84, 151);
            this.txt원주문번호.Name = "txt원주문번호";
            this.txt원주문번호.Size = new System.Drawing.Size(141, 21);
            this.txt원주문번호.TabIndex = 9;
            // 
            // txt주문가격
            // 
            this.txt주문가격.Location = new System.Drawing.Point(84, 124);
            this.txt주문가격.Name = "txt주문가격";
            this.txt주문가격.Size = new System.Drawing.Size(141, 21);
            this.txt주문가격.TabIndex = 8;
            // 
            // txt주문수량
            // 
            this.txt주문수량.Location = new System.Drawing.Point(84, 97);
            this.txt주문수량.Name = "txt주문수량";
            this.txt주문수량.Size = new System.Drawing.Size(141, 21);
            this.txt주문수량.TabIndex = 7;
            this.txt주문수량.Text = "10";
            // 
            // txt주문종목코드
            // 
            this.txt주문종목코드.Location = new System.Drawing.Point(84, 20);
            this.txt주문종목코드.Name = "txt주문종목코드";
            this.txt주문종목코드.Size = new System.Drawing.Size(141, 21);
            this.txt주문종목코드.TabIndex = 6;
            this.txt주문종목코드.Text = "039490";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 5;
            this.label11.Text = "원주문번호";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "주문가격";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "주문수량";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "매매구분";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "거래구분";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "종목코드";
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.종목코드,
            this.종목명,
            this.현재가,
            this.저가,
            this.고가,
            this.시가,
            this.대비,
            this.등락률,
            this.거래량,
            this.당일평균가});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView3.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView3.Location = new System.Drawing.Point(274, 124);
            this.dataGridView3.Name = "dataGridView3";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView3.RowHeadersWidth = 21;
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(925, 152);
            this.dataGridView3.TabIndex = 64;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // 종목코드
            // 
            this.종목코드.HeaderText = "종목코드";
            this.종목코드.Name = "종목코드";
            this.종목코드.Width = 90;
            // 
            // 종목명
            // 
            this.종목명.HeaderText = "종목명";
            this.종목명.Name = "종목명";
            this.종목명.Width = 91;
            // 
            // 현재가
            // 
            this.현재가.HeaderText = "현재가";
            this.현재가.Name = "현재가";
            this.현재가.Width = 90;
            // 
            // 저가
            // 
            this.저가.HeaderText = "저가";
            this.저가.Name = "저가";
            this.저가.Width = 90;
            // 
            // 고가
            // 
            this.고가.HeaderText = "고가";
            this.고가.Name = "고가";
            this.고가.Width = 91;
            // 
            // 시가
            // 
            this.시가.HeaderText = "시가";
            this.시가.Name = "시가";
            this.시가.Width = 90;
            // 
            // 대비
            // 
            this.대비.HeaderText = "대비";
            this.대비.Name = "대비";
            this.대비.Width = 90;
            // 
            // 등락률
            // 
            this.등락률.HeaderText = "등락률";
            this.등락률.Name = "등락률";
            this.등락률.Width = 90;
            // 
            // 거래량
            // 
            this.거래량.HeaderText = "거래량";
            this.거래량.Name = "거래량";
            this.거래량.Width = 91;
            // 
            // 당일평균가
            // 
            this.당일평균가.HeaderText = "당일평균가";
            this.당일평균가.Name = "당일평균가";
            this.당일평균가.Width = 90;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 28);
            this.button1.TabIndex = 68;
            this.button1.Text = "관심종목";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(274, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 28);
            this.button2.TabIndex = 69;
            this.button2.Text = "주식보유현황";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.기호,
            this.보유수량,
            this.매입,
            this.평가금액,
            this.수익률});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.Location = new System.Drawing.Point(274, 326);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowHeadersWidth = 21;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(924, 241);
            this.dataGridView1.TabIndex = 70;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "종목코드";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 90;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "종목명";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 91;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "현재가";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 90;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "등락률";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 90;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "거래량";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 91;
            // 
            // 기호
            // 
            this.기호.HeaderText = "기호";
            this.기호.Name = "기호";
            this.기호.Width = 90;
            // 
            // 보유수량
            // 
            this.보유수량.HeaderText = "보유수량";
            this.보유수량.Name = "보유수량";
            this.보유수량.Width = 90;
            // 
            // 매입
            // 
            this.매입.HeaderText = "매입가";
            this.매입.Name = "매입";
            this.매입.Width = 90;
            // 
            // 평가금액
            // 
            this.평가금액.HeaderText = "평가금액";
            this.평가금액.Name = "평가금액";
            this.평가금액.Width = 91;
            // 
            // 수익률
            // 
            this.수익률.HeaderText = "수익률";
            this.수익률.Name = "수익률";
            this.수익률.Width = 90;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(274, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 28);
            this.button3.TabIndex = 71;
            this.button3.Text = "계좌정보확인";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 597);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accountComboBox);
            this.Controls.Add(this.listBoxLog);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.axKHOpenAPI);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.ComboBox accountComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn 총매도금액;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매매수수료;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매매세금;
        private System.Windows.Forms.DataGridViewTextBoxColumn 손익금;
        private System.Windows.Forms.DataGridViewTextBoxColumn 당일수익률;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbo거래구분;
        private System.Windows.Forms.Button btn주문;
        private System.Windows.Forms.ComboBox cbo매매구분;
        private System.Windows.Forms.TextBox txt원주문번호;
        private System.Windows.Forms.TextBox txt주문가격;
        private System.Windows.Forms.TextBox txt주문수량;
        private System.Windows.Forms.TextBox txt주문종목코드;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 종목코드;
        private System.Windows.Forms.DataGridViewTextBoxColumn 종목명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 현재가;
        private System.Windows.Forms.DataGridViewTextBoxColumn 저가;
        private System.Windows.Forms.DataGridViewTextBoxColumn 고가;
        private System.Windows.Forms.DataGridViewTextBoxColumn 시가;
        private System.Windows.Forms.DataGridViewTextBoxColumn 대비;
        private System.Windows.Forms.DataGridViewTextBoxColumn 등락률;
        private System.Windows.Forms.DataGridViewTextBoxColumn 거래량;
        private System.Windows.Forms.DataGridViewTextBoxColumn 당일평균가;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn 기호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 보유수량;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매입;
        private System.Windows.Forms.DataGridViewTextBoxColumn 평가금액;
        private System.Windows.Forms.DataGridViewTextBoxColumn 수익률;
        private System.Windows.Forms.Button button3;
    }
}


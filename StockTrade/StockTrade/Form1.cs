using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KiwoomCode;

namespace StockTrade
{
    public partial class Form1 : Form
    {
        private int _scrNum = 5000;
        private string GetScrNum()
        {
            if (_scrNum < 9999)
                _scrNum++;
            else
                _scrNum = 5000;

            return _scrNum.ToString();
        }

        public Form1()
        {
            InitializeComponent();

        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            if (axKHOpenAPI.CommConnect() == 0)
            {
                AddLog("로그인 시작");
            }
            else
            {
                AddLog("로그인 실패");
            }
        }

        private void AddLog(string s)
        {
            Func<int> del = delegate ()
            {
                if (listBoxLog.Items.Count > 200)
                {
                    listBoxLog.Items.RemoveAt(listBoxLog.Items.Count - 1);
                }
                listBoxLog.Items.Insert(0, s);
                return 0;
            };
            Invoke(del);
        }

        private void axKHOpenAPI_OnEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {

            //if (axKHOpenAPI.GetConnectState() == 1)
            //{
            //    AddLog("접속 성공");

            //    string accountlist = axKHOpenAPI.GetLoginInfo("ACCLIST");
            //    string[] account = accountlist.Split(';');
            //    for (int i = 0; i < account.Length; i++)
            //    {
            //        accountComboBox.Items.Add(account[i]);
            //    }
            //}
            //else if (axKHOpenAPI.GetConnectState() == 0)
            //{
            //    AddLog("접속 실패");
            //}

            AddLog("axKHOpenAPI_OnEventConnect");
            if (Error.IsError(e.nErrCode))
            {
                AddLog("// [로그인 처리결과] " + Error.GetErrorMessage());

                // 조건식 로컬저장 자동으로 진행하기
                System.Threading.Thread.Sleep(1000);         //  로그인 성공후 잠시 기다려서 조건식 불러오기 자동 실행하기
                int lRet;
                lRet = axKHOpenAPI.GetConditionLoad();

                // 계좌번호 불러오기
                //lbl아이디.Text = axKHOpenAPI.GetLoginInfo("USER_ID");
                //lbl이름.Text = axKHOpenAPI.GetLoginInfo("USER_NAME");
                string[] arrayAcount = axKHOpenAPI.GetLoginInfo("ACCNO").Split(';');
                accountComboBox.Items.AddRange(arrayAcount);
                accountComboBox.SelectedIndex = 0;
            }
            else
            {
                AddLog("로그인창 열기 실패");
                AddLog("로그인 실패로 조건식리스트 불러오기 실패");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cbo거래구분.SelectedIndex = 0;
            cbo매매구분.SelectedIndex = 0;
        }


        private void accountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void balanceCheck_Click(object sender, EventArgs e)
        {
            if (accountComboBox.Text.Length > 0)
            {
                //string accountNumber = accountComboBox.Text;

                //axKHOpenAPI.SetInputValue("계좌번호", accountNumber);
                //axKHOpenAPI.SetInputValue("비밀번호입력매체구분", "00");
                //axKHOpenAPI.SetInputValue("조회구분", "1");
                //axKHOpenAPI.CommRqData("계좌평가잔고내역요청","pow00018",0,"8100");

                string 계좌번호 = accountComboBox.Text.Trim();


                axKHOpenAPI.SetInputValue("계좌번호", 계좌번호);
                axKHOpenAPI.SetInputValue("비밀번호", "");
                axKHOpenAPI.SetInputValue("비밀번호입력매체구분", "00");
                axKHOpenAPI.SetInputValue("조회구분", "1");                                  // 조회구분 = 1:추정조회, 2:일반조회               
                axKHOpenAPI.SetInputValue("상장폐지조회구분", "0");               //상장폐지조회구분 = 0:전체, 1:상장폐지종목제외

                string today = DateTime.Now.ToString("yyyyMMdd"); //오늘날짜
                axKHOpenAPI.SetInputValue("시작일자", today);                                     // 당일날짜 
                axKHOpenAPI.SetInputValue("종료일자", today);                                     // 당일날짜 
                axKHOpenAPI.CommRqData("예수금상세현황요청", "OPW00001", 0, GetScrNum());
                axKHOpenAPI.CommRqData("계좌평가현황요청", "OPW00004", 0, GetScrNum());
                axKHOpenAPI.CommRqData("일자별실현손익요청", "opt10074", 0, GetScrNum());
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        private void axKHOpenAPI_OnReceiveTrData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {



            AddLog(e.sScrNo);
            AddLog(e.sRQName);
            AddLog(e.sTrCode);
            AddLog(e.sRecordName);
            AddLog(e.sPrevNext);

            if (e.sRQName == "예수금상세현황요청")
            {
                string str예수금 = axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, 0, "예수금").TrimStart('0');
                string str주문가능금액 = axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, 0, "주문가능금액").TrimStart('0');
                int int예수금, int주문가능금액;
                if (Int32.TryParse(str예수금, out int예수금))
                    str예수금 = String.Format("{0:#,# 원}", int예수금);
                if (Int32.TryParse(str주문가능금액, out int주문가능금액))
                    str주문가능금액 = String.Format("{0:#,# 원}", int주문가능금액);

                // 조회데이터 출력하기
                dataGridView2.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;                    // 텍스트 오른쪽 정렬 사용 MiddleRight
                dataGridView2.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView2.Rows[0].Cells[0].Value = str예수금;
                dataGridView2.Rows[0].Cells[1].Value = str주문가능금액;

                // Logger(Log.검색코드, e.sRQName + ">>> 예수금:{0},주문가능금액:{1}", str예수금, str주문가능금액);
            }

            else if (e.sRQName == "계좌평가현황요청")
            {
                string str유가잔고평가액 = axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, 0, "유가잔고평가액").Trim();
                int int유가잔고평가액;
                if (Int32.TryParse(str유가잔고평가액, out int유가잔고평가액))
                    str유가잔고평가액 = String.Format("{0:#,# 원}", int유가잔고평가액);

                // 조회데이터 출력하기
                dataGridView2.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView2.Rows[0].Cells[2].Value = str유가잔고평가액;



            }

            else if (e.sRQName == "일자별실현손익요청")
            {
                string str실현손익 = axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, 0, "실현손익").TrimStart('0');
                string str매수금액 = axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, 0, "매수금액").TrimStart('0');
                string str매도금액 = axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, 0, "매도금액").TrimStart('0');
                string str매매수수료 = axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, 0, "매매수수료").TrimStart('0');
                string str매매세금 = axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, 0, "매매세금").TrimStart('0');
                int int실현손익, int매수금액, int매도금액, int매매수수료, int매매세금;

                if (Int32.TryParse(str실현손익, out int실현손익))
                    str실현손익 = String.Format("{0:#,# 원}", int실현손익);
                if (Int32.TryParse(str매수금액, out int매수금액))
                    str매수금액 = String.Format("{0:#,# 원}", int매수금액);
                if (Int32.TryParse(str매도금액, out int매도금액))
                    str매도금액 = String.Format("{0:#,# 원}", int매도금액);
                if (Int32.TryParse(str매매수수료, out int매매수수료))
                    str매매수수료 = String.Format("{0:#,# 원}", int매매수수료);
                if (Int32.TryParse(str매매세금, out int매매세금))
                    str매매세금 = String.Format("{0:#,# 원}", int매매세금);

                double d실현손익;
                double d매수금액;
                double d당일수익률;
                d실현손익 = int실현손익;
                d매수금액 = int매수금액;

                d당일수익률 = d실현손익 / d매수금액 * 100;             // 당일 수익률 계산

                // 조회데이터 출력하기
                dataGridView2.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView2.Rows[0].Cells[7].Value = str실현손익;
                dataGridView2.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView2.Rows[0].Cells[3].Value = str매수금액;
                dataGridView2.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView2.Rows[0].Cells[4].Value = str매도금액;
                dataGridView2.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView2.Rows[0].Cells[5].Value = str매매수수료;
                dataGridView2.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView2.Rows[0].Cells[6].Value = str매매세금;
                dataGridView2.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView2.Rows[0].Cells[8].Value = Math.Round(d당일수익률, 2) + "%";            // 당일수익률 소수점 셋째자리 반올림Math.Round(대상,자릿수) 

                //    //richTextBox1.Text = str실현손익;                // 수익률 전광판
            }

            else if (e.sRQName == "관심종목")
            {

                int nCnt = axKHOpenAPI.GetRepeatCnt(e.sTrCode, e.sRQName);          // 데이터 갯수 얻기

                if (nCnt < 1)
                    return;

                dataGridView3.Rows.Add(nCnt + 1);

                {

                    for (int i = 0; i < nCnt; i++)
                    {
                        string str종목코드 = axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "종목코드").Trim();            // 종목코드가 종목번호로 사용됨(계좌잔고평가현황에서)
                        str종목코드 = str종목코드.Substring(str종목코드.Length - 6);                                      //<-- 모의투자는 종목코드 앞에 A가 붙이서 A 빼고 6자리로 만들기
                        string str종목명 = axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "종목명").Trim();
                        //str체결시간 = axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "체결시간").TrimStart('0');    //string data = "003210";   Console.WriteLine(data.TrimStart('0'));
                        string str저가 = axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "저가").TrimStart('0');        // 수신데이터 000000060  삭제 TrimStart('0')
                        string str고가 = axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "고가").TrimStart('0');    // 수신데이터 000000060  삭제 TrimStart('0')
                        string str시가 = axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "시가").TrimStart('0');
                        string str현재가 = axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "현재가").Trim();



                        //if (Int32.TryParse(str현재가, out int현재가))
                        //    str현재가 = String.Format("{0:###,###,##0 원}", Math.Abs(int현재가));         //Math.Abs(); 로 현재가앞에 - 부호 제거
                        //if (Int32.TryParse(str보유수량, out int보유수량))
                        //    str보유수량 = String.Format("{0:#,# 주}", int보유수량);                       //천단위 콤마 사용
                        //if (Int32.TryParse(str매입가, out int매입가))
                        //    str매입가 = String.Format("{0:#,# 원}", int매입가);                           //천단위 콤마 사용
                        //if (Int32.TryParse(str매입금액, out int매입금액))
                        //    str매입금액 = String.Format("{0:#,# 원}", int매입금액);                       //천단위 콤마 사용
                        //if (Int32.TryParse(str평가금액, out int평가금액))
                        //    str평가금액 = String.Format("{0:#,# 원}", int평가금액);                       //천단위 콤마 사용


                        // 데이터그리드뷰에 보유종목 현황 출력
                        //dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;          // 텍스트 오른쪽 정렬 사용 MiddleRight
                        dataGridView3.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        dataGridView3.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dataGridView3.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dataGridView3.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dataGridView3.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dataGridView3.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dataGridView3.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dataGridView3.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dataGridView3.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dataGridView3.Rows[i].Cells[0].Value = str종목코드;
                        dataGridView3.Rows[i].Cells[1].Value = str종목명;
                        dataGridView3.Rows[i].Cells[2].Value = str현재가;
                        dataGridView3.Rows[i].Cells[5].Value = str저가;
                        dataGridView3.Rows[i].Cells[6].Value = str고가;
                        dataGridView3.Rows[i].Cells[7].Value = str시가;


                    }

                }
            }

            else if (e.sRQName == "보유주식현황")
            {

                int int현재가;
                int int평가손익;
                int int매입금액;


                int nCnt = axKHOpenAPI.GetRepeatCnt(e.sTrCode, e.sRQName);          // 데이터 갯수 얻기

                // Logger(Log.검색코드, e.sRQName + ">>> 갯수= " + String.Format("{0:#,#}", nCnt));

                dataGridView1.Rows.Add(nCnt);

                //dataGridView1.Rows.Add(row1);
                //dataGridView1.Rows.Add(row);
                //dataGridView1.RowCount = nCnt;                    // 데이터그리드뷰 Row 카운트 (row 갯수 지정을 미리해서 직접 위치 지정해서 넣을수 있게 ?
                //dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1);
                {

                    for (int i = 0; i < nCnt; i++)
                    {
                        string str종목코드 = axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "종목번호").Trim();            // 종목코드가 종목번호로 사용됨(계좌잔고평가현황에서)
                        //str종목코드 = str종목코드.Substring(str종목코드.Length - 6);                                      //<-- 모의투자는 종목코드 앞에 A가 붙이서 A 빼고 6자리로 만들기
                        string str종목명 = axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "종목명").Trim();
                        string str보유수량 = axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "보유수량").TrimStart('0');    //string data = "003210";   Console.WriteLine(data.TrimStart('0'));
                        string str매입가 = axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "매입가").TrimStart('0');        // 수신데이터 000000060  삭제 TrimStart('0')
                        string str매입금액 = axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "매입금액").TrimStart('0');    // 수신데이터 000000060  삭제 TrimStart('0')
                        string str평가금액 = axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "평가금액").TrimStart('0');
                        string str수익률 = axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "수익률(%)").TrimStart('0');
                        string str현재가 = axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "현재가").Trim();
                        string str평가손익 = axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "평가손익").Trim();
                        string str등락률 = axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "등락율").Trim();
                        string str등락률old = str등락률;
                        float f등락률;

                        int int보유수량;
                        int int매입가;
                        int int평가금액;

                        if (Single.TryParse(str등락률, out f등락률))
                            str등락률 = string.Format("{0:###,##0.#0}", f등락률) + " %";
                        else
                            str등락률 = str등락률old;
                        if (Int32.TryParse(str현재가, out int현재가))
                            str현재가 = String.Format("{0:###,###,##0 원}", Math.Abs(int현재가));         //Math.Abs(); 로 현재가앞에 - 부호 제거
                        if (Int32.TryParse(str보유수량, out int보유수량))
                            str보유수량 = String.Format("{0:#,# 주}", int보유수량);                       //천단위 콤마 사용
                        if (Int32.TryParse(str매입가, out int매입가))
                            str매입가 = String.Format("{0:#,# 원}", int매입가);                           //천단위 콤마 사용
                        if (Int32.TryParse(str매입금액, out int매입금액))
                            str매입금액 = String.Format("{0:#,# 원}", int매입금액);                       //천단위 콤마 사용
                        if (Int32.TryParse(str평가금액, out int평가금액))
                            str평가금액 = String.Format("{0:#,# 원}", int평가금액);                       //천단위 콤마 사용
                        if (Int32.TryParse(str평가손익, out int평가손익))
                            str평가손익 = String.Format("{0:#,# 원}", int평가손익);

                        string str수익률old = str수익률;
                        float f수익률;
                        if (Single.TryParse(str수익률, out f수익률))
                            str수익률 = String.Format("{0:0.00}%", f수익률);

                        // 보유수량 헤더 타이틀 명칭 바꾸기 
                        DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
                        columnHeaderStyle.BackColor = Color.Beige;
                        dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
                        dataGridView1.Columns[3].HeaderText = "등락률";
                        dataGridView1.Columns[4].HeaderText = "평가손익";
                        dataGridView1.Columns[5].HeaderText = "매입금액";
                        dataGridView1.Columns[8].HeaderText = "총평가금액";

                        // 데이터그리드뷰에 보유종목 현황 출력
                        //dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;          // 텍스트 오른쪽 정렬 사용 MiddleRight
                        dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dataGridView1.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dataGridView1.Rows[i].Cells[0].Value = str종목코드;
                        dataGridView1.Rows[i].Cells[1].Value = str종목명;
                        dataGridView1.Rows[i].Cells[2].Value = str현재가;
                        dataGridView1.Rows[i].Cells[3].Value = str등락률;
                        dataGridView1.Rows[i].Cells[4].Value = str평가손익;
                        dataGridView1.Rows[i].Cells[5].Value = str매입금액;
                        dataGridView1.Rows[i].Cells[6].Value = str보유수량;
                        dataGridView1.Rows[i].Cells[7].Value = str매입가;
                        dataGridView1.Rows[i].Cells[8].Value = str평가금액;
                        dataGridView1.Rows[i].Cells[9].Value = str수익률;
                    }


                }

            }



        }

        // =======================================================<<실시간 f그리드업데이트 함수 최초 구현부>> ======================================//
        // 
        // 종목코드만 넣고 추가 값을 넣으면 알아서 그리드에서 종목코드 찾아서 그 위치에 넣어줌
        //
        //==========================================================================================================================================//
        private void f그리드업데이트(string str종목코드, string str현재가, string str고가,string str저가,string str시가, string str등락률, string str거래량,
                                     string str전일대비기호, string str보유수량, string str매입가, string str평가금액, string str수익률)
        {
            int IDX;
            string str종목코드2;

            // i 값 찾기  (종목코드 비교)
            IDX = -1;
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                // 종목코드와 그리드 종목코드를 비교하여 같으면 루프 돌리기 중단!!!
                str종목코드2 = dataGridView3.Rows[i].Cells[0].Value.ToString();
                str종목코드2 = str종목코드2.Trim();

                if (str종목코드 == str종목코드2)
                {
                    //Logger(Log.실시간, "@@@@@ 찾음>> i={0} | str종목코드 : {2}", i, str종목코드2);                               // 로그 찍는 연습 
                    IDX = i;
                    break;  // 루프 중단
                }
            }

            // 종목코드를 비교해서 찾았으면 아래에서 i 값을 이용해서 처리
            if (IDX > -1)
            {
                //Logger(Log.실시간, " >>!!!종목찾음=" + str종목코드 + "|" + dataGridView1.Rows[IDX].Cells[0].Value);            // 제대로 수신되는지 확인용 로그 작성 ******
                int int현재가, int고가, int저가, int시가;
                // 같으면 해당줄에 현재가 업데이트  
                if (Int32.TryParse(str현재가, out int현재가))
                    str현재가 = String.Format("{0:###,###,##0 원}", Math.Abs(int현재가));            //천단위 콤마 사용 및 현재가앞 - 부호 제거

                if (Int32.TryParse(str고가, out int고가))
                    str고가 = String.Format("{0:###,###,##0 원}", Math.Abs(int고가));            //천단위 콤마 사용 및 현재가앞 - 부호 제거

                if (Int32.TryParse(str저가, out int저가))
                    str저가 = String.Format("{0:###,###,##0 원}", Math.Abs(int저가));

                if (Int32.TryParse(str시가, out int시가))
                    str시가 = String.Format("{0:###,###,##0 원}", Math.Abs(int시가));

                string str등락률old, str수익률old;
                float f등락률, f수익률;
                int int거래량, int보유수량, int매입가, int평가금액;
                str등락률old = str등락률;
                if (Single.TryParse(str등락률, out f등락률))
                    str등락률 = string.Format(" {0:0.00}% ", f등락률);        // 등락률에 % 기호 추가
                else
                    str등락률 = str등락률old;
                if (Int32.TryParse(str거래량, out int거래량))
                    str거래량 = String.Format("{0:#,# 주}", int거래량);
                if (Int32.TryParse(str보유수량, out int보유수량))
                    str보유수량 = String.Format("{0:#,# 주}", int보유수량);
                if (Int32.TryParse(str매입가, out int매입가))
                    str매입가 = String.Format("{0:#,# 원}", int매입가);
                if (Int32.TryParse(str평가금액, out int평가금액))
                    str평가금액 = String.Format("{0:#,# 원}", int평가금액);

                str수익률old = str수익률;
                if (Single.TryParse(str수익률, out f수익률))
                    str수익률 = String.Format("{0:0.00}%", f수익률);

                //==============================================================
                // 전일대비기호를 그림(문자)으로 교체, 글자색 바꾸기 ,강조하기 
                //==============================================================
                {
                    if (str전일대비기호 != "")
                    {
                        if (str전일대비기호 == "2")             // 2번은 상승의미
                        {
                            str전일대비기호 = "상승";
                        }
                        else if (str전일대비기호 == "5")        // 5번은 하락의미
                        {
                            str전일대비기호 = "하락";
                        }
                        else if (str전일대비기호 == "1")        // 1번은 상한의미
                        {
                            str전일대비기호 = "상한";
                        }
                        else if (str전일대비기호 == "3")        // 3번은 보합의미
                        {
                            str전일대비기호 = "보합";
                        }
                        dataGridView3.Rows[IDX].Cells[5].Value = str전일대비기호;
                        dataGridView3.Rows[IDX].Cells[5].Style.Font = new Font("Fixsys", 9);                                       // Cell 폰트 지정하기
                        if (str전일대비기호 == "상승") dataGridView3.Rows[IDX].Cells[5].Style.ForeColor = Color.Red;               // 상승은 빨강색
                        else if (str전일대비기호 == "하락") dataGridView3.Rows[IDX].Cells[5].Style.ForeColor = Color.Blue;
                        else if (str전일대비기호 == "상한")
                        {
                            dataGridView3.Rows[IDX].Cells[5].Style.ForeColor = Color.Red;                                              // 상한가 빨강색 
                            dataGridView3.Rows[IDX].Cells[5].Style.Font = new Font("Fixsys", 9, FontStyle.Bold);                       // 상한가 강조
                        }
                        else if (str전일대비기호 == "보합") dataGridView3.Rows[IDX].Cells[5].Style.ForeColor = Color.Black;
                        else dataGridView3.Rows[IDX].Cells[5].Style.ForeColor = Color.Black;
                    }
                }

                dataGridView3.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;                    // 텍스트 오른쪽 정렬 사용 MiddleRight
                if (str현재가 != "") { dataGridView3.Rows[IDX].Cells[2].Value = str현재가; }                                       // 수신정보 비어있는 경우 갱신 안함 
                dataGridView3.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                if (str저가 != "") { dataGridView3.Rows[IDX].Cells[3].Value = str저가; }
                dataGridView3.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                if (str고가 != "") { dataGridView3.Rows[IDX].Cells[4].Value = str고가; }
                dataGridView3.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                if (str등락률 != "") { dataGridView3.Rows[IDX].Cells[7].Value = str등락률; }
                dataGridView3.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                if (str거래량 != "") { dataGridView3.Rows[IDX].Cells[8].Value = str거래량; }
                dataGridView3.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                if (str시가 != "") { dataGridView3.Rows[IDX].Cells[5].Value = str시가; }
                if (str전일대비기호 != "") { dataGridView3.Rows[IDX].Cells[6].Value = str전일대비기호; }
                if (str매입가 != "") { dataGridView3.Rows[IDX].Cells[7].Value = str매입가; }
                if (str평가금액 != "") { dataGridView3.Rows[IDX].Cells[8].Value = str평가금액; }
                if (str수익률 != "") { dataGridView3.Rows[IDX].Cells[9].Value = str수익률; }
            }
            return;
        }


        private void axKHOpenAPI_OnReceiveRealData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveRealDataEvent e)
        {


            if (e.sRealType == "주식체결")                  // "주식시세"가 안올때 "주식체결"로 수신함           
            {
                //Logger(Log.실시간, "종목코드 : {0} | 현재가 : {1:C} | 등락율 : {2} | 누적거래량 : {3:N0} ", e.sRealKey,
                //                     Int32.Parse(axKHOpenAPI.GetCommRealData(e.sRealType, 10).Trim()),
                //                    axKHOpenAPI.GetCommRealData(e.sRealType, 12).Trim(),
                //                     Int32.Parse(axKHOpenAPI.GetCommRealData(e.sRealType, 13).Trim()));

                // ========================================================================
                // 실시간 수신한 주식체결!!  데이터를 데이터그리드뷰에 업데이트해주는 부분
                // ========================================================================

                f그리드업데이트(e.sRealKey, axKHOpenAPI.GetCommRealData(e.sRealType, 10).Trim(),
                                            axKHOpenAPI.GetCommRealData(e.sRealType, 17).Trim(),
                                            axKHOpenAPI.GetCommRealData(e.sRealType, 18).Trim(),
                                            axKHOpenAPI.GetCommRealData(e.sRealType, 16).Trim(),
                                            axKHOpenAPI.GetCommRealData(e.sRealType, 12).Trim(),
                                            axKHOpenAPI.GetCommRealData(e.sRealType, 13).Trim(),
                                            axKHOpenAPI.GetCommRealData(e.sRealType, 25).Trim(), "", "", "", "");
            }
            else if (e.sRealType == "주식시세")
            {
                //Logger(Log.실시간, e.sRealType + " - 종목코드 : {0} | RealType : {1} | RealData : {2}", e.sRealKey, e.sRealType, e.sRealData);

                // ========================================================================
                // 실시간 수신한 주식시세!!   데이터를 데이터그리드뷰에 업데이트해주는 부분
                // ========================================================================
                f그리드업데이트(e.sRealKey, axKHOpenAPI.GetCommRealData(e.sRealType, 10).Trim(),
                                            axKHOpenAPI.GetCommRealData(e.sRealType, 17).Trim(),
                                            axKHOpenAPI.GetCommRealData(e.sRealType, 18).Trim(),
                                            axKHOpenAPI.GetCommRealData(e.sRealType, 16).Trim(),
                                            axKHOpenAPI.GetCommRealData(e.sRealType, 12).Trim(),
                                            axKHOpenAPI.GetCommRealData(e.sRealType, 13).Trim(),
                                            axKHOpenAPI.GetCommRealData(e.sRealType, 25).Trim(), "", "", "", "");
            }
        }
      
     

       
        private void btn주문_Click(object sender, EventArgs e)
        {

            // 종목코드 입력 여부 확인
            if (txt주문종목코드.TextLength != 6)
            {
                AddLog(Log.검색코드 + " 종목코드 6자리를 입력해 주세요");

                return;
            }

            // 주문수량 입력 여부 확인
            int n주문수량;

            if (txt주문수량.TextLength > 0)
            {
                n주문수량 = Int32.Parse(txt주문수량.Text.Trim());
            }
            else
            {
                AddLog(Log.검색코드 + " 주문수량을 입력하지 않았습니다");

                return;
            }

            if (n주문수량 < 1)
            {
                AddLog(Log.검색코드 + " 주문수량이 1보다 작습니다");

                return;
            }

            // ======================================================================
            // 거래구분 취득
            // 0:지정가, 3:시장가, 5:조건부지정가, 6:최유리지정가, 7:최우선지정가,
            // 10:지정가IOC, 13:시장가IOC, 16:최유리IOC, 20:지정가FOK, 23:시장가FOK,
            // 26:최유리FOK, 61:장개시전시간외, 62:시간외단일가매매, 81:시간외종가
            // ======================================================================
            string s거래구분;
            s거래구분 = KOACode.hogaGb[cbo거래구분.SelectedIndex].code;

            // 주문가격 입력 여부
            int n주문가격 = 0;

            if (txt주문가격.TextLength > 0)
            {
                n주문가격 = Int32.Parse(txt주문가격.Text.Trim());
            }

            if (s거래구분 == "3" || s거래구분 == "13" || s거래구분 == "23" && n주문가격 < 1)
            {
                AddLog(Log.검색코드 + " 주문가격이 1보다 작습니다");
            }

            // ====================================
            // 매매구분 취득
            // (1:신규매수, 2:신규매도 3:매수취소, 
            // 4:매도취소, 5:매수정정, 6:매도정정)
            // ====================================
            int n매매구분;
            n매매구분 = KOACode.orderType[cbo매매구분.SelectedIndex].code;

            // 원주문번호 입력 여부
            if (n매매구분 > 2 && txt원주문번호.TextLength < 1)
            {
                AddLog(Log.검색코드 + " 원주문번호를 입력해주세요");
            }

            // =============================
            // 주식 수동 매수/ 매도 처리부
            // =============================
            int lRet;
            string 계좌번호 = accountComboBox.Text.Trim();

            lRet = axKHOpenAPI.SendOrder("주식주문", GetScrNum(), 계좌번호,
                                        n매매구분, txt주문종목코드.Text.Trim(), n주문수량,
                                        n주문가격, s거래구분, txt원주문번호.Text.Trim());
            if (lRet == 0)
            {
                AddLog(Log.실시간 + " 주문이 전송 되었습니다");
            }
            else
            {
                AddLog(Log.실시간 + " 주문이 전송 실패 하였습니다. [에러] : " + lRet);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_real_Click(object sender, EventArgs e)
        {

            //string txt종목코드 = txtcode.Text.Trim();

            //int ret = axKHOpenAPI.CommKwRqData(txt종목코드, 0, 1, 0, "주식체결", GetScrNum());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strcode = "005930;039490";
            int ret = axKHOpenAPI.CommKwRqData(strcode, 1, 2, 0, "관심종목", GetScrNum());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();     //모든행의 값을 지운다.

            string 계좌번호 = accountComboBox.Text.Trim();

            axKHOpenAPI.SetInputValue("계좌번호", 계좌번호);
            axKHOpenAPI.SetInputValue("비밀번호", "");
            axKHOpenAPI.SetInputValue("비밀번호입력매체구분", "");
            axKHOpenAPI.SetInputValue("조회구분", "1");                              // 조회구분 = 1:합산, 2:개별               
            axKHOpenAPI.CommRqData("보유주식현황", "opw00018", 0, GetScrNum());      // 조회구분 = 0: 조회ㅣ, 2:연속 
                                                                               // 1차 조회후 연속데이터가 있을때 다시 2번을 요청하여 자료가 없을때까지 반복
                                                                               // 처음부터 연속조회요청 불가(타인계좌 사용할 수 없다 ~ 오류남)
        }

        private void axKHOpenAPI_OnReceiveMsg(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveMsgEvent e)
        {
            AddLog("=================<< Message >>=====================");
            string msg = String.Format("화면번호:{0} | RQName:{1} | TRCode:{2} | 메세지:{3}", e.sScrNo, e.sRQName, e.sTrCode, e.sMsg);
            AddLog(msg);
        }

        private void axKHOpenAPI_OnReceiveChejanData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveChejanDataEvent e)
        {
            if (e.sGubun == "0")
            {
                // this.dataGridView1.Rows.Add(axKHOpenAPI.GetChejanData(911));

                AddLog("구분 : 주문체결통보");             // 매수 매도후 주문 체결 출력하는 부분
                AddLog("주문/체결시간 : " + axKHOpenAPI.GetChejanData(908));
                AddLog("종목명 : " + axKHOpenAPI.GetChejanData(302));
                AddLog("주문수량 : " + axKHOpenAPI.GetChejanData(900));
                AddLog("주문가격 : " + axKHOpenAPI.GetChejanData(901));
                AddLog("체결수량 : " + axKHOpenAPI.GetChejanData(911));
                AddLog("체결가격 : " + axKHOpenAPI.GetChejanData(910));
                AddLog("=======================================");
            }
            else if (e.sGubun == "1")
            {
                AddLog("구분 : 잔고통보");
            }
            else if (e.sGubun == "3")
            {
                AddLog("구분 : 특이신호");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string 계좌번호 = accountComboBox.Text.Trim();


            axKHOpenAPI.SetInputValue("계좌번호", 계좌번호);
            axKHOpenAPI.SetInputValue("비밀번호", "");
            axKHOpenAPI.SetInputValue("비밀번호입력매체구분", "00");
            axKHOpenAPI.SetInputValue("조회구분", "1");                                  // 조회구분 = 1:추정조회, 2:일반조회               
            axKHOpenAPI.CommRqData("예수금상세현황요청", "opw00001", 0, GetScrNum());

            axKHOpenAPI.SetInputValue("계좌번호", 계좌번호);
            axKHOpenAPI.SetInputValue("비밀번호", "");
            axKHOpenAPI.SetInputValue("상장폐지조회구분", "0");               //상장폐지조회구분 = 0:전체, 1:상장폐지종목제외
            axKHOpenAPI.SetInputValue("비밀번호입력매체구분", "00");
            axKHOpenAPI.CommRqData("계좌평가현황요청", "OPW00004", 0, GetScrNum());


            string today = DateTime.Now.ToString("yyyyMMdd"); //오늘날짜

            axKHOpenAPI.SetInputValue("계좌번호", 계좌번호);
            axKHOpenAPI.SetInputValue("시작일자", today);                                     // 당일날짜 
            axKHOpenAPI.SetInputValue("종료일자", today);                                     // 당일날짜 
            axKHOpenAPI.CommRqData("일자별실현손익요청", "opt10074", 0, GetScrNum());
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

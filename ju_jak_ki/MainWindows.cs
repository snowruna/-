using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Logging;
using System;
using System.Runtime.CompilerServices;

namespace ju_jak_ki

{
    public partial class MainWindows : Form
    {
        StreamWriter fileCtrl;
        string LOGFILE = "recent.log";

        public MainWindows()
        {
            if (!File.Exists(LOGFILE))
            {
                fileCtrl = File.CreateText(LOGFILE);
                fileCtrl.Close();
            }
            fileCtrl = File.AppendText(LOGFILE);
            fileCtrl.WriteLine(string.Format("\n== {0} 부터 작성된 당첨 이력입니다. ==",DateTime.Now.ToString()));
            fileCtrl.Close();

            InitializeComponent();
        }

        // 입력란

        private void userButton(object sender, EventArgs e)
        {
            String temp = userInput.Text;
            if (!temp.Equals(""))
            {
                userList.Items.Add(temp);
                userInput.Text = "";
            }
        }

        private void itemButton(object sender, EventArgs e)
        {
            String temp = itemInput.Text;
            if (!temp.Equals(""))
            {
                itemList.Items.Add(temp);
                itemInput.Text = "";
            }
        }

        // 단일 추첨 버튼
        private void select_Click(object sender, EventArgs e)
        {
            if (itemList.Items.Count <= 0)
            {
                MessageBox.Show("추첨할 아이템이 없습니다.", "추첨 하지 못했습니다.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if(userList.Items.Count <= 0)
            {
                MessageBox.Show("추첨 대상이 없습니다.", "추첨 하지 못했습니다.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                userselect(false);
            }
            
        }
        // 다중 추첨 버튼
        private void for_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("같은 상품 하나로 여러명을 추첨하는 기능입니다.\n" +
                "아래 입력란에 추첨할 인원을 입력하고 추첨 해주세요.\n\n" +
                "계속 하시려면 확인을 누르세요.", "알림", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
            {
                return;
            }
            
            for (int i = 0; i < forNum.Value; i++)
            {
                if (itemList.Items.Count <= 0)
                {
                    MessageBox.Show("추첨할 아이템이 부족합니다.", "추첨 하지 못했습니다.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if(i != 0)
                    {
                        MessageBox.Show("추첨이 중간에서 끊겼습니다. 최근 추첨탭에서 확인하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return;
                }
                else if (userList.Items.Count <= 0)
                {
                    MessageBox.Show("추첨 대상이 부족합니다.", "추첨 하지 못했습니다.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (i != 0)
                    {
                        MessageBox.Show("추첨이 중간에서 끊겼습니다. 최근 추첨탭에서 확인하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return;
                }
                else
                {
                    userselect(true);
                }
            }
            if (!dontRemoveItem.Checked && itemList.Items.Count >= 1)
            {
                itemList.Items.RemoveAt(0);
            }
            MessageBox.Show("추첨이 완료 됐습니다. 최근 추첨탭에서 확인하세요.", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        // 추첨 코드
        private void userselect(bool isRe)
        {
            fileCtrl = File.AppendText(LOGFILE);
            Random ran = new Random();
            string log = "";
            int pickNum = ran.Next(userList.Items.Count);

            String pick = userList.Items[pickNum].ToString();
            log = string.Format("{0} : {1} - {2}", DateTime.Now.ToString(), itemList.Items[0], pick);

            result.Items.Add(log);
            fileCtrl.WriteLine(log);
            fileCtrl.Close();

            itemResult.Text = "상품 " + itemList.Items[0] + "의";
            userResult.Text = "당첨자는 " + pick + " 입니다.";

            if (!isRe && !dontRemoveItem.Checked)
            {
                itemList.Items.RemoveAt(0);
            }
            if (!rePick.Checked)
            {
                userList.Items.RemoveAt(pickNum);
            }
        }


        // 항목이 없을 때

        private void button1_Click(object sender, EventArgs e)
        {
            if(userList.SelectedIndex == -1)
            {
                MessageBox.Show("삭제 대상이 없습니다.", "삭제 하지 못했습니다.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                userList.Items.RemoveAt(userList.SelectedIndex);
            }
        }
        private void itemDel_Click(object sender, EventArgs e)
        {
            if (itemList.SelectedIndex == -1)
            {
                MessageBox.Show("삭제 대상이 없습니다.", "삭제 하지 못했습니다.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                itemList.Items.RemoveAt(itemList.SelectedIndex);
            }
        }

        // 저장 불러오기 버튼
        private void inputList(object sender, EventArgs e)
        {
            if(userList.Items.Count == 0)
            {
                MessageBox.Show("저장할 리스트가 없습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "텍스트 파일 (*.txt) | *.txt";
            DialogResult dia = saveFile.ShowDialog();

            if(dia == DialogResult.OK)
            {
                string fileName = saveFile.FileName;
                StreamWriter fileSave = new StreamWriter(fileName);
                foreach(var i in userList.Items)
                {
                    fileSave.WriteLine(i.ToString());
                }
                fileSave.Close();
            }
        }

        private void importList(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "텍스트 파일 (*.txt) | *.txt";
            DialogResult dia = openFile.ShowDialog();

            if (dia == DialogResult.OK)
            {
                if(MessageBox.Show("기존 내용을 초기화 할까요?", "초기화", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    userList.Items.Clear();
                }
                string fileName = openFile.FileName;
                StreamReader fileRead = new StreamReader(fileName);
                string text;
                while((text = fileRead.ReadLine()) != null)
                {
                    userList.Items.Add(text);
                }
                fileRead.Close();
            }
        }




        // 백그라운드에서 진행 되는 것들

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = "현재시각 : " +  DateTime.Now.ToString();
            userCount.Text = "추첨 인원 : " + userList.Items.Count + "명";
            itemCount.Text = "상품 수 : " + itemList.Items.Count + "개";
        }

        private void WindowsClose(object sender, FormClosingEventArgs e)
        {
            fileCtrl = File.AppendText(LOGFILE);
            fileCtrl.WriteLine("==========================================");
            fileCtrl.Close();
        }






        // 3번째 탭
        private void importUserList(object sender, EventArgs e)
        {
            if (userList.Items.Count >= 2)
            {
                state.Text = "대기 중";
                checkRandom.Items.Clear();
                foreach (var item in userList.Items)
                {
                    checkRandom.Items.Add(item);
                }
                checkStartButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("추첨 대상을 2명 이상 추가후 시도해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void checkStart(object sender, EventArgs e)
        {
            int rep = (int)repNum.Value;
            int arrSize = checkRandom.Items.Count;
            int[] result = new int[arrSize];
            state.Text = string.Format("반복 중... ({0} / {1})", 0, rep);

            if(rep > 10000)
            {
                MessageBox.Show("설장한 값이 매우 높습니다!\n컴퓨터 성능에 따라 검증까지 많은 시간이 소요될 수 있습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // 배열 초기화
            for (int i = 0; i < arrSize; i++)
            {
                result[i] = 0;
            }

            // 돌려
            for(int i = 0; i < rep; i++)
            {
                Random ran = new Random();
                result[ran.Next(arrSize)]++;
                state.Text = string.Format("반복 중... ({0} / {1})", i + 1, rep);
            }

            // 결과
            state.Text = "완료";
            int maxNum = 0;
            int minNum = 99999999;
            decimal temp;

            for (int i = 0; i < arrSize; i++)
            {
                if(maxNum < result[i])
                {
                    maxNum = result[i];
                }
                if(minNum > result[i])
                {
                    minNum = result[i];
                }
                temp = (decimal)result[i] / rep * 100;
                temp = Math.Round(temp, 2);
                checkRandom.Items[i] = string.Format("{0}\t\t  - {1}번 ({2}%)\t", checkRandom.Items[i], result[i], temp);
                checkRandom.Items[i] += string.Format("실제 확률이랑 {0}% 차이", ((decimal)100 / arrSize) - temp);
            }
            stateResult.Text = "";
            temp = (decimal)100 / arrSize;
            temp = Math.Round(temp, 2);
            stateResult.Text += string.Format("이론 확률 : {0}%   ", temp);
            temp = (decimal)maxNum / rep * 100;
            temp = Math.Round(temp, 2);
            stateResult.Text += string.Format("최고 확률 : {0}%   ", temp);
            temp = (decimal)minNum / rep * 100;
            temp = Math.Round(temp, 2);
            stateResult.Text += string.Format("최저 확률 : {0}%   ", temp);

            checkStartButton.Enabled = false;

        }
        // 디버그용

        private void button4_Click(object sender, EventArgs e)
        {
            for(int i = 1; i < 11; i++)
            {
                userList.Items.Add("유저" + i);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 6; i++)
            {
                itemList.Items.Add(i + "000원 상품권");
            }
        }


    }
}
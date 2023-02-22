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
            fileCtrl.WriteLine(string.Format("\n== {0} ���� �ۼ��� ��÷ �̷��Դϴ�. ==",DateTime.Now.ToString()));
            fileCtrl.Close();

            InitializeComponent();
        }

        // �Է¶�

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

        // ���� ��÷ ��ư
        private void select_Click(object sender, EventArgs e)
        {
            if (itemList.Items.Count <= 0)
            {
                MessageBox.Show("��÷�� �������� �����ϴ�.", "��÷ ���� ���߽��ϴ�.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if(userList.Items.Count <= 0)
            {
                MessageBox.Show("��÷ ����� �����ϴ�.", "��÷ ���� ���߽��ϴ�.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                userselect(false);
            }
            
        }
        // ���� ��÷ ��ư
        private void for_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("���� ��ǰ �ϳ��� �������� ��÷�ϴ� ����Դϴ�.\n" +
                "�Ʒ� �Է¶��� ��÷�� �ο��� �Է��ϰ� ��÷ ���ּ���.\n\n" +
                "��� �Ͻ÷��� Ȯ���� ��������.", "�˸�", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
            {
                return;
            }
            
            for (int i = 0; i < forNum.Value; i++)
            {
                if (itemList.Items.Count <= 0)
                {
                    MessageBox.Show("��÷�� �������� �����մϴ�.", "��÷ ���� ���߽��ϴ�.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if(i != 0)
                    {
                        MessageBox.Show("��÷�� �߰����� ������ϴ�. �ֱ� ��÷�ǿ��� Ȯ���ϼ���.", "���", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return;
                }
                else if (userList.Items.Count <= 0)
                {
                    MessageBox.Show("��÷ ����� �����մϴ�.", "��÷ ���� ���߽��ϴ�.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (i != 0)
                    {
                        MessageBox.Show("��÷�� �߰����� ������ϴ�. �ֱ� ��÷�ǿ��� Ȯ���ϼ���.", "���", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            MessageBox.Show("��÷�� �Ϸ� �ƽ��ϴ�. �ֱ� ��÷�ǿ��� Ȯ���ϼ���.", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        // ��÷ �ڵ�
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

            itemResult.Text = "��ǰ " + itemList.Items[0] + "��";
            userResult.Text = "��÷�ڴ� " + pick + " �Դϴ�.";

            if (!isRe && !dontRemoveItem.Checked)
            {
                itemList.Items.RemoveAt(0);
            }
            if (!rePick.Checked)
            {
                userList.Items.RemoveAt(pickNum);
            }
        }


        // �׸��� ���� ��

        private void button1_Click(object sender, EventArgs e)
        {
            if(userList.SelectedIndex == -1)
            {
                MessageBox.Show("���� ����� �����ϴ�.", "���� ���� ���߽��ϴ�.", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("���� ����� �����ϴ�.", "���� ���� ���߽��ϴ�.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                itemList.Items.RemoveAt(itemList.SelectedIndex);
            }
        }

        // ���� �ҷ����� ��ư
        private void inputList(object sender, EventArgs e)
        {
            if(userList.Items.Count == 0)
            {
                MessageBox.Show("������ ����Ʈ�� �����ϴ�.", "���", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "�ؽ�Ʈ ���� (*.txt) | *.txt";
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
            openFile.Filter = "�ؽ�Ʈ ���� (*.txt) | *.txt";
            DialogResult dia = openFile.ShowDialog();

            if (dia == DialogResult.OK)
            {
                if(MessageBox.Show("���� ������ �ʱ�ȭ �ұ��?", "�ʱ�ȭ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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




        // ��׶��忡�� ���� �Ǵ� �͵�

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = "����ð� : " +  DateTime.Now.ToString();
            userCount.Text = "��÷ �ο� : " + userList.Items.Count + "��";
            itemCount.Text = "��ǰ �� : " + itemList.Items.Count + "��";
        }

        private void WindowsClose(object sender, FormClosingEventArgs e)
        {
            fileCtrl = File.AppendText(LOGFILE);
            fileCtrl.WriteLine("==========================================");
            fileCtrl.Close();
        }






        // 3��° ��
        private void importUserList(object sender, EventArgs e)
        {
            if (userList.Items.Count >= 2)
            {
                state.Text = "��� ��";
                checkRandom.Items.Clear();
                foreach (var item in userList.Items)
                {
                    checkRandom.Items.Add(item);
                }
                checkStartButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("��÷ ����� 2�� �̻� �߰��� �õ����ּ���.", "���", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void checkStart(object sender, EventArgs e)
        {
            int rep = (int)repNum.Value;
            int arrSize = checkRandom.Items.Count;
            int[] result = new int[arrSize];
            state.Text = string.Format("�ݺ� ��... ({0} / {1})", 0, rep);

            if(rep > 10000)
            {
                MessageBox.Show("������ ���� �ſ� �����ϴ�!\n��ǻ�� ���ɿ� ���� �������� ���� �ð��� �ҿ�� �� �ֽ��ϴ�.", "���", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // �迭 �ʱ�ȭ
            for (int i = 0; i < arrSize; i++)
            {
                result[i] = 0;
            }

            // ����
            for(int i = 0; i < rep; i++)
            {
                Random ran = new Random();
                result[ran.Next(arrSize)]++;
                state.Text = string.Format("�ݺ� ��... ({0} / {1})", i + 1, rep);
            }

            // ���
            state.Text = "�Ϸ�";
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
                checkRandom.Items[i] = string.Format("{0}\t\t  - {1}�� ({2}%)\t", checkRandom.Items[i], result[i], temp);
                checkRandom.Items[i] += string.Format("���� Ȯ���̶� {0}% ����", ((decimal)100 / arrSize) - temp);
            }
            stateResult.Text = "";
            temp = (decimal)100 / arrSize;
            temp = Math.Round(temp, 2);
            stateResult.Text += string.Format("�̷� Ȯ�� : {0}%   ", temp);
            temp = (decimal)maxNum / rep * 100;
            temp = Math.Round(temp, 2);
            stateResult.Text += string.Format("�ְ� Ȯ�� : {0}%   ", temp);
            temp = (decimal)minNum / rep * 100;
            temp = Math.Round(temp, 2);
            stateResult.Text += string.Format("���� Ȯ�� : {0}%   ", temp);

            checkStartButton.Enabled = false;

        }
        // ����׿�

        private void button4_Click(object sender, EventArgs e)
        {
            for(int i = 1; i < 11; i++)
            {
                userList.Items.Add("����" + i);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 6; i++)
            {
                itemList.Items.Add(i + "000�� ��ǰ��");
            }
        }


    }
}
namespace ju_jak_ki
{
    partial class MainWindows
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindows));
            this.userList = new System.Windows.Forms.ListBox();
            this.itemList = new System.Windows.Forms.ListBox();
            this.rePick = new System.Windows.Forms.CheckBox();
            this.userResult = new System.Windows.Forms.Label();
            this.userConfirm = new System.Windows.Forms.Button();
            this.userInput = new System.Windows.Forms.TextBox();
            this.itemConfirm = new System.Windows.Forms.Button();
            this.itemInput = new System.Windows.Forms.TextBox();
            this.select = new System.Windows.Forms.Button();
            this.userDel = new System.Windows.Forms.Button();
            this.itemDel = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dontRemoveItem = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.itemCount = new System.Windows.Forms.Label();
            this.userCount = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.forNum = new System.Windows.Forms.NumericUpDown();
            this.itemResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.result = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.stateResult = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.Label();
            this.checkStartButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.repNum = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.checkRandom = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.forNum)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repNum)).BeginInit();
            this.SuspendLayout();
            // 
            // userList
            // 
            this.userList.FormattingEnabled = true;
            this.userList.ItemHeight = 15;
            this.userList.Location = new System.Drawing.Point(19, 90);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(182, 229);
            this.userList.TabIndex = 0;
            // 
            // itemList
            // 
            this.itemList.FormattingEnabled = true;
            this.itemList.ItemHeight = 15;
            this.itemList.Location = new System.Drawing.Point(216, 90);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(182, 229);
            this.itemList.TabIndex = 1;
            // 
            // rePick
            // 
            this.rePick.AutoSize = true;
            this.rePick.Location = new System.Drawing.Point(408, 107);
            this.rePick.Name = "rePick";
            this.rePick.Size = new System.Drawing.Size(74, 19);
            this.rePick.TabIndex = 2;
            this.rePick.Text = "중복허용";
            this.rePick.UseVisualStyleBackColor = true;
            // 
            // userResult
            // 
            this.userResult.AutoSize = true;
            this.userResult.Font = new System.Drawing.Font("나눔스퀘어OTF", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userResult.Location = new System.Drawing.Point(19, 418);
            this.userResult.Name = "userResult";
            this.userResult.Size = new System.Drawing.Size(158, 33);
            this.userResult.TabIndex = 3;
            this.userResult.Text = "추첨 대기중";
            // 
            // userConfirm
            // 
            this.userConfirm.Location = new System.Drawing.Point(19, 53);
            this.userConfirm.Name = "userConfirm";
            this.userConfirm.Size = new System.Drawing.Size(101, 23);
            this.userConfirm.TabIndex = 4;
            this.userConfirm.Text = "추가";
            this.userConfirm.UseVisualStyleBackColor = true;
            this.userConfirm.Click += new System.EventHandler(this.userButton);
            // 
            // userInput
            // 
            this.userInput.Location = new System.Drawing.Point(19, 19);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(182, 23);
            this.userInput.TabIndex = 5;
            // 
            // itemConfirm
            // 
            this.itemConfirm.Location = new System.Drawing.Point(216, 53);
            this.itemConfirm.Name = "itemConfirm";
            this.itemConfirm.Size = new System.Drawing.Size(101, 23);
            this.itemConfirm.TabIndex = 6;
            this.itemConfirm.Text = "추가";
            this.itemConfirm.UseVisualStyleBackColor = true;
            this.itemConfirm.Click += new System.EventHandler(this.itemButton);
            // 
            // itemInput
            // 
            this.itemInput.Location = new System.Drawing.Point(216, 19);
            this.itemInput.Name = "itemInput";
            this.itemInput.Size = new System.Drawing.Size(182, 23);
            this.itemInput.TabIndex = 7;
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(408, 19);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(124, 23);
            this.select.TabIndex = 8;
            this.select.Text = "주작!";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // userDel
            // 
            this.userDel.Location = new System.Drawing.Point(126, 53);
            this.userDel.Name = "userDel";
            this.userDel.Size = new System.Drawing.Size(75, 23);
            this.userDel.TabIndex = 9;
            this.userDel.Text = "항목삭제";
            this.userDel.UseVisualStyleBackColor = true;
            this.userDel.Click += new System.EventHandler(this.button1_Click);
            // 
            // itemDel
            // 
            this.itemDel.Location = new System.Drawing.Point(323, 53);
            this.itemDel.Name = "itemDel";
            this.itemDel.Size = new System.Drawing.Size(75, 23);
            this.itemDel.TabIndex = 11;
            this.itemDel.Text = "항목삭제";
            this.itemDel.UseVisualStyleBackColor = true;
            this.itemDel.Click += new System.EventHandler(this.itemDel_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(555, 493);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.dontRemoveItem);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.itemCount);
            this.tabPage1.Controls.Add(this.userCount);
            this.tabPage1.Controls.Add(this.time);
            this.tabPage1.Controls.Add(this.forNum);
            this.tabPage1.Controls.Add(this.itemResult);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.userResult);
            this.tabPage1.Controls.Add(this.userList);
            this.tabPage1.Controls.Add(this.select);
            this.tabPage1.Controls.Add(this.rePick);
            this.tabPage1.Controls.Add(this.itemDel);
            this.tabPage1.Controls.Add(this.itemList);
            this.tabPage1.Controls.Add(this.userDel);
            this.tabPage1.Controls.Add(this.userConfirm);
            this.tabPage1.Controls.Add(this.userInput);
            this.tabPage1.Controls.Add(this.itemInput);
            this.tabPage1.Controls.Add(this.itemConfirm);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(547, 465);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "추첨기";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(405, 291);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(127, 23);
            this.button6.TabIndex = 22;
            this.button6.Text = "추첨 대상 불러오기";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.importList);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(405, 262);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "추첨 대상 저장";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.inputList);
            // 
            // dontRemoveItem
            // 
            this.dontRemoveItem.AutoSize = true;
            this.dontRemoveItem.Location = new System.Drawing.Point(408, 131);
            this.dontRemoveItem.Name = "dontRemoveItem";
            this.dontRemoveItem.Size = new System.Drawing.Size(106, 19);
            this.dontRemoveItem.TabIndex = 19;
            this.dontRemoveItem.Text = "상품 제거 안함";
            this.dontRemoveItem.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(510, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "명";
            // 
            // itemCount
            // 
            this.itemCount.AutoSize = true;
            this.itemCount.Location = new System.Drawing.Point(216, 329);
            this.itemCount.Name = "itemCount";
            this.itemCount.Size = new System.Drawing.Size(77, 15);
            this.itemCount.TabIndex = 17;
            this.itemCount.Text = "상품 수 : 0개";
            // 
            // userCount
            // 
            this.userCount.AutoSize = true;
            this.userCount.Location = new System.Drawing.Point(19, 329);
            this.userCount.Name = "userCount";
            this.userCount.Size = new System.Drawing.Size(89, 15);
            this.userCount.TabIndex = 16;
            this.userCount.Text = "추첨 인원 : 0명";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("나눔스퀘어", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.time.Location = new System.Drawing.Point(22, 359);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(44, 16);
            this.time.TabIndex = 15;
            this.time.Text = "label1";
            // 
            // forNum
            // 
            this.forNum.Location = new System.Drawing.Point(408, 77);
            this.forNum.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.forNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.forNum.Name = "forNum";
            this.forNum.Size = new System.Drawing.Size(96, 23);
            this.forNum.TabIndex = 14;
            this.forNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.forNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // itemResult
            // 
            this.itemResult.AutoSize = true;
            this.itemResult.Font = new System.Drawing.Font("나눔스퀘어OTF", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itemResult.Location = new System.Drawing.Point(25, 386);
            this.itemResult.Name = "itemResult";
            this.itemResult.Size = new System.Drawing.Size(0, 24);
            this.itemResult.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "다중추첨";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.for_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.result);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(547, 465);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "최근 기록";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // result
            // 
            this.result.FormattingEnabled = true;
            this.result.ItemHeight = 15;
            this.result.Items.AddRange(new object[] {
            "===========================================",
            "",
            "                  여기에 최근 당첨 목록이 표시 됩니다.",
            "           추첨마다 폴더 내 recent.log 파일에 기록 됩니다.",
            "",
            "==========================================="});
            this.result.Location = new System.Drawing.Point(18, 15);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(510, 439);
            this.result.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.stateResult);
            this.tabPage3.Controls.Add(this.state);
            this.tabPage3.Controls.Add(this.checkStartButton);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.repNum);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.checkRandom);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(547, 465);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "확률 검증";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // stateResult
            // 
            this.stateResult.AutoSize = true;
            this.stateResult.Location = new System.Drawing.Point(17, 440);
            this.stateResult.Name = "stateResult";
            this.stateResult.Size = new System.Drawing.Size(0, 15);
            this.stateResult.TabIndex = 7;
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.state.Location = new System.Drawing.Point(124, 140);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(131, 15);
            this.state.TabIndex = 6;
            this.state.Text = "새로고침이 필요합니다";
            this.state.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkStartButton
            // 
            this.checkStartButton.Enabled = false;
            this.checkStartButton.Location = new System.Drawing.Point(456, 134);
            this.checkStartButton.Name = "checkStartButton";
            this.checkStartButton.Size = new System.Drawing.Size(75, 23);
            this.checkStartButton.TabIndex = 5;
            this.checkStartButton.Text = "검증 시작";
            this.checkStartButton.UseVisualStyleBackColor = true;
            this.checkStartButton.Click += new System.EventHandler(this.checkStart);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "반복 횟수";
            // 
            // repNum
            // 
            this.repNum.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.repNum.Location = new System.Drawing.Point(365, 136);
            this.repNum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.repNum.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.repNum.Name = "repNum";
            this.repNum.Size = new System.Drawing.Size(85, 23);
            this.repNum.TabIndex = 3;
            this.repNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.repNum.Value = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "새로고침";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.importUserList);
            // 
            // checkRandom
            // 
            this.checkRandom.FormattingEnabled = true;
            this.checkRandom.ItemHeight = 15;
            this.checkRandom.Location = new System.Drawing.Point(17, 169);
            this.checkRandom.Name = "checkRandom";
            this.checkRandom.Size = new System.Drawing.Size(514, 259);
            this.checkRandom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 102);
            this.label1.TabIndex = 0;
            this.label1.Text = "본 추첨기는 C# 기본 클래스인 Random 클래스를 기본으로 추첨합니다.\r\n추첨을 위한 난수 생성은 현재 시간을 시드로 이용해 추첨합니다.\r\n\r" +
    "\n대부분은 문제 없으나 시스템 타이머가 이상이 있으면 문제가 발생할 수 있습니다.\r\n\r\n이 페이지에서 확률을 검증할 수 있습니다.\r\n";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 517);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindows";
            this.Text = "가디언 테일즈 추첨기";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WindowsClose);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.forNum)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox userList;
        private ListBox itemList;
        private CheckBox rePick;
        private Label userResult;
        private Button userConfirm;
        private TextBox userInput;
        private Button itemConfirm;
        private TextBox itemInput;
        private Button select;
        private Button userDel;
        private Button itemDel;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button1;
        private NumericUpDown forNum;
        private Label itemResult;
        private Label time;
        private System.Windows.Forms.Timer timer1;
        private ListBox result;
        private Label itemCount;
        private Label userCount;
        private TabPage tabPage3;
        private Label label1;
        private Button button2;
        private ListBox checkRandom;
        private NumericUpDown repNum;
        private Button checkStartButton;
        private Label label2;
        private Label state;
        private Label label3;
        private Label stateResult;
        private CheckBox dontRemoveItem;
        private Button button6;
        private Button button3;
        private OpenFileDialog openFileDialog1;
    }
}
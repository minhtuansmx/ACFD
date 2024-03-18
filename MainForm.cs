using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACFD
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            RunMainForm();
        }
        #region declare

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        IntPtr channelProcessId;
        string channelName = "";
        int checkMainProcess, nbcm = 0, canLockCommand;
        bool isLockChannel = false, isLockCommand = false, tempAdd, tempDel, isChating, isCanChat = true;
        bool[] isNotSetEventTimer = new bool[999];
        Label[] lNumberCommand = new Label[999];
        Label[] lCommandLock = new Label[999];
        TextBox[] tbCommand = new TextBox[999];
        Label[] lDelayCommand = new Label[999];
        TextBox[] tbDelay = new TextBox[999];
        Label[] lDelayLock = new Label[999];
        Timer[] tmCommand = new Timer[999];
        Queue nextCommand = new Queue();

        #endregion

        #region function

        void RunMainForm()
        {
            AddCommand();
            cbSlowmode.SelectedIndex = 0;
            pbChannel.BackgroundImage = global::ACFD.Properties.Resources.bgUnlock;
            pbCommand.BackgroundImage = global::ACFD.Properties.Resources.bgUnlock;
            pbFindChannel.BackgroundImage = global::ACFD.Properties.Resources.bgFindChannel;
            pbSMx.BackgroundImage = global::ACFD.Properties.Resources.bgSMx;
        }

        void setTimeChatInterval(int value)
        {
            switch (cbSlowmode.SelectedIndex)
            {
                case 1:
                    tmChat.Interval = 2000 + 5000;
                    lSlowmodeChannelLock.Text = "5 seconds";
                    break;
                case 2:
                    tmChat.Interval = 2000 + 10000;
                    lSlowmodeChannelLock.Text = "10 seconds";
                    break;
                case 3:
                    tmChat.Interval = 2000 + 15000;
                    lSlowmodeChannelLock.Text = "15 seconds";
                    break;
                case 4:
                    tmChat.Interval = 2000 + 30000;
                    lSlowmodeChannelLock.Text = "30 seconds";
                    break;
                case 5:
                    tmChat.Interval = 2000 + 60000;
                    lSlowmodeChannelLock.Text = "1 minute";
                    break;
                case 6:
                    tmChat.Interval = 2000 + 120000;
                    lSlowmodeChannelLock.Text = "2 minutes";
                    break;
                case 7:
                    tmChat.Interval = 2000 + 300000;
                    lSlowmodeChannelLock.Text = "5 minutes";
                    break;
                case 8:
                    tmChat.Interval = 2000 + 600000;
                    lSlowmodeChannelLock.Text = "10 minutes";
                    break;
                case 9:
                    tmChat.Interval = 2000 + 900000;
                    lSlowmodeChannelLock.Text = "15 minutes";
                    break;
                case 10:
                    tmChat.Interval = 2000 + 1800000;
                    lSlowmodeChannelLock.Text = "30 minutes";
                    break;
                case 11:
                    tmChat.Interval = 2000 + 3600000;
                    lSlowmodeChannelLock.Text = "1 hour";
                    break;
                case 12:
                    tmChat.Interval = 2000 + 7200000;
                    lSlowmodeChannelLock.Text = "2 hours";
                    break;
                case 13:
                    tmChat.Interval = 2000 + 21600000;
                    lSlowmodeChannelLock.Text = "6 hours";
                    break;
                default:
                    tmChat.Interval = 200;
                    lSlowmodeChannelLock.Text = "Off";
                    break;
            }
        }

        void LockChannel()
        {
            pbChannel.BackgroundImage = global::ACFD.Properties.Resources.bgLock;
            cbSlowmode.Visible = false;
            lSlowmodeChannelLock.Visible = true;
            pbFindChannel.Visible = false;
            isLockChannel = true;
        }

        void UnlockChannel()
        {
            pbChannel.BackgroundImage = global::ACFD.Properties.Resources.bgUnlock;
            cbSlowmode.Visible = true;
            lSlowmodeChannelLock.Visible = false;
            pbFindChannel.Visible = true;
            isLockChannel = false;
        }

        void LockCommand()
        {
            canLockCommand = 0;
            for (int i = 0; i <= nbcm; i++)
            {
                try
                {
                    tmCommand[i].Interval = int.Parse(tbDelay[i].Text) * 1000 + 500;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delay of command#" + (i + 1) + " must be number", "Data input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbDelay[i].Text = "";
                    canLockCommand++;
                    break;
                }
            }
            if (canLockCommand == 0)
            {
                for (int j = 0; j <= nbcm; j++)
                {
                    lCommandLock[j].Text = tbCommand[j].Text;
                    lCommandLock[j].Visible = true;
                    tbCommand[j].Visible = false;
                    lDelayLock[j].Text = tbDelay[j].Text;
                    lDelayLock[j].Visible = true;
                    tbDelay[j].Visible = false;
                    pbCommand.BackgroundImage = global::ACFD.Properties.Resources.bgLock;
                    isLockCommand = true;
                }
                tempAdd = bAddCommand.Visible;
                tempDel = bDelCommand.Visible;
                bAddCommand.Visible = false;
                bDelCommand.Visible = false;
            }
        }

        void UnlockCommand()
        {
            pbCommand.BackgroundImage = global::ACFD.Properties.Resources.bgUnlock;
            for (int i = 0; i <= nbcm; i++)
            {
                lCommandLock[i].Visible = false;
                tbCommand[i].Visible = true;
                lDelayLock[i].Visible = false;
                tbDelay[i].Visible = true;
            }
            bAddCommand.Visible = tempAdd;
            bDelCommand.Visible = tempDel;
            isLockCommand = false;
        }

        void GetChannel()
        {
            foreach (Process process in Process.GetProcesses())
            {
                try
                {
                    if ((process.MainWindowTitle.IndexOf("#")) == 0)
                    {
                        channelName = process.MainWindowTitle;
                        channelProcessId = process.MainWindowHandle;
                    }
                }
                catch (Win32Exception ex)
                {

                }
            }
        }

        void GetMainProcess()
        {
            IntPtr activeWindow = GetForegroundWindow();
            foreach (Process process in Process.GetProcesses())
            {
                try
                {
                    if ((activeWindow == channelProcessId) && (process.MainWindowTitle.IndexOf(channelName)) == 0)
                    {
                        checkMainProcess++;
                    }
                }
                catch (Win32Exception ex)
                {

                }
            }
        }


        void AddCommand()
        {
            //lNumberCommand
            lNumberCommand[nbcm] = new Label();
            gbCommand.Controls.Add(lNumberCommand[nbcm]);
            lNumberCommand[nbcm].AutoSize = true;
            lNumberCommand[nbcm].Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lNumberCommand[nbcm].Location = new System.Drawing.Point(6, 30 + nbcm * 32);
            lNumberCommand[nbcm].Size = new System.Drawing.Size(30, 19);
            lNumberCommand[nbcm].TabIndex = 2;
            lNumberCommand[nbcm].Text = "#" + (nbcm + 1) + ":";
            //tbCommand
            tbCommand[nbcm] = new TextBox();
            gbCommand.Controls.Add(tbCommand[nbcm]);
            tbCommand[nbcm].Location = new System.Drawing.Point(42, 27 + nbcm * 32);
            tbCommand[nbcm].Size = new System.Drawing.Size(150, 26);
            tbCommand[nbcm].TabIndex = 8;
            //lCommandLock
            lCommandLock[nbcm] = new Label();
            gbCommand.Controls.Add(lCommandLock[nbcm]);
            lCommandLock[nbcm].AutoSize = true;
            lCommandLock[nbcm].Location = new System.Drawing.Point(42, 30 + nbcm * 32);
            lCommandLock[nbcm].Size = new System.Drawing.Size(0, 19);
            lCommandLock[nbcm].TabIndex = 6;
            lCommandLock[nbcm].Visible = false;
            //lDelay
            lDelayCommand[nbcm] = new Label();
            gbCommand.Controls.Add(lDelayCommand[nbcm]);
            lDelayCommand[nbcm].AutoSize = true;
            lDelayCommand[nbcm].Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lDelayCommand[nbcm].Location = new System.Drawing.Point(198, 30 + nbcm * 32);
            lDelayCommand[nbcm].Size = new System.Drawing.Size(71, 19);
            lDelayCommand[nbcm].TabIndex = 2;
            lDelayCommand[nbcm].Text = "Delay(s):";
            //tbDelay
            tbDelay[nbcm] = new TextBox();
            gbCommand.Controls.Add(tbDelay[nbcm]);
            tbDelay[nbcm].Location = new System.Drawing.Point(275, 27 + nbcm * 32);
            tbDelay[nbcm].Size = new System.Drawing.Size(75, 26);
            tbDelay[nbcm].TabIndex = 8;
            //lDelayLock
            lDelayLock[nbcm] = new Label();
            gbCommand.Controls.Add(lDelayLock[nbcm]);
            lDelayLock[nbcm].AutoSize = true;
            lDelayLock[nbcm].Location = new System.Drawing.Point(275, 30 + nbcm * 32);
            lDelayLock[nbcm].Size = new System.Drawing.Size(0, 19);
            lDelayLock[nbcm].TabIndex = 6;
            lDelayLock[nbcm].Visible = false;
            //tmCommand
            tmCommand[nbcm] = new Timer();
        }



        void DelCommand()
        {
            gbCommand.Controls.Remove(lNumberCommand[nbcm]);
            gbCommand.Controls.Remove(tbCommand[nbcm]);
            gbCommand.Controls.Remove(lCommandLock[nbcm]);
            gbCommand.Controls.Remove(lDelayCommand[nbcm]);
            gbCommand.Controls.Remove(tbDelay[nbcm]);
            gbCommand.Controls.Remove(lDelayLock[nbcm]);
        }

        void SendCommand()
        {
            isCanChat = false;
            int command = (int)nextCommand.Dequeue();
            string message = lCommandLock[command].Text;
            SendKeys.Send(message);
            SendKeys.Send("{Enter}");
            tmCommand[command].Start();
            tmChat.Start();
        }



        #endregion

        #region event

        private void cbSlowmode_SelectedIndexChanged(object sender, EventArgs e)
        {
            setTimeChatInterval(cbSlowmode.SelectedIndex);
        }

        private void pbChannel_Click(object sender, EventArgs e)
        {
            if (!isLockChannel)
            {
                LockChannel();
            }
            else
            {
                if (!isChating) UnlockChannel();
            }
        }

        private void tmCommand_Tick(object sender, EventArgs e, int i)
        {
            tmCommand[i].Stop();
            nextCommand.Enqueue(i);
        }

        private void tmChat_Tick(object sender, EventArgs e)
        {
            tmChat.Stop();
            isCanChat = true;
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            tmChat.Stop();
            tmCheckMainProcess.Stop();
            UnlockChannel();
            UnlockCommand();
            for (int i = 0; i <= nbcm; i++)
            {
                tmCommand[i].Stop();
            }
            nextCommand.Clear();
            isChating = false;
            lStateAuto.ForeColor = System.Drawing.Color.SpringGreen;
            lStateAuto.Text = "AUTO CHAT HAS STOP WORKING";
            bStop.Enabled = false;
            bStart.Enabled = true;
            cbEnqueue.Enabled = true;
        }

        private void llFacebook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://facebook.com/SMx.ForgetMeNot");
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            if (!isLockChannel) LockChannel();
            if (!isLockCommand) LockCommand();
            if (canLockCommand == 0)
            {
                tmCheckMainProcess.Start();
                for (int i = 0; i <= nbcm; i++)
                {
                    int temp = i;
                    if (!isNotSetEventTimer[temp])
                    {
                        tmCommand[temp].Tick += (object s, EventArgs a) => tmCommand_Tick(s, a, temp);
                        isNotSetEventTimer[temp] = true;
                    }
                }
                if (cbEnqueue.Checked) for (int i = 0; i <= nbcm; i++) nextCommand.Enqueue(i);
                else for (int i = 0; i <= nbcm; i++) tmCommand[i].Start();
                isChating = true;
                lStateAuto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
                lStateAuto.Text = "AUTO CHAT IS WORKING NOW";
                bStart.Enabled = false;
                bStop.Enabled = true;
                cbEnqueue.Enabled = false;
            }
        }

        private void pbFindChannel_Click(object sender, EventArgs e)
        {
            channelName = "";
            GetChannel();
            if (channelName == "") lNameChannelLock.Text = "Nothing"; else lNameChannelLock.Text = channelName.Substring(0, channelName.IndexOf(" "));
        }

        private void tmCheckMainProcess_Tick(object sender, EventArgs e)
        {
            checkMainProcess = 0;
            GetMainProcess();
            if ((checkMainProcess == 1) && (nextCommand.Count > 0) && (isCanChat))
            {
                SendCommand();
            }
        }

        private void bDelCommand_Click(object sender, EventArgs e)
        {
            DelCommand();
            nbcm--;
            if (nbcm < 1) bDelCommand.Visible = false;
            if (nbcm < 4) bAddCommand.Visible = true;
            bAddCommand.Location = new System.Drawing.Point(375, 27 + 32 * nbcm);
            bDelCommand.Location = new System.Drawing.Point(407, 27 + 32 * nbcm);
        }

        private void pbCommand_Click(object sender, EventArgs e)
        {
            if (!isLockCommand)
            {
                LockCommand();
            }
            else
            {
                if (!isChating) UnlockCommand();
            }
        }

        private void bAddCommand_Click(object sender, EventArgs e)
        {
            nbcm++;
            AddCommand();
            if (nbcm > 0) bDelCommand.Visible = true;
            if (nbcm > 3) bAddCommand.Visible = false;
            bAddCommand.Location = new System.Drawing.Point(375, 27 + 32 * nbcm);
            bDelCommand.Location = new System.Drawing.Point(407, 27 + 32 * nbcm);
        }

        #endregion

    }
}

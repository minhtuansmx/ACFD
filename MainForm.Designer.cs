namespace ACFD
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tmChat = new System.Windows.Forms.Timer(this.components);
            this.lNameChannel = new System.Windows.Forms.Label();
            this.lSlowmodeChannel = new System.Windows.Forms.Label();
            this.cbSlowmode = new System.Windows.Forms.ComboBox();
            this.lNameChannelLock = new System.Windows.Forms.Label();
            this.lSlowmodeChannelLock = new System.Windows.Forms.Label();
            this.gbChannel = new System.Windows.Forms.GroupBox();
            this.pbFindChannel = new System.Windows.Forms.PictureBox();
            this.pbChannel = new System.Windows.Forms.PictureBox();
            this.tmCheckMainProcess = new System.Windows.Forms.Timer(this.components);
            this.bAddCommand = new System.Windows.Forms.Button();
            this.bDelCommand = new System.Windows.Forms.Button();
            this.gbCommand = new System.Windows.Forms.GroupBox();
            this.cbEnqueue = new System.Windows.Forms.CheckBox();
            this.pbCommand = new System.Windows.Forms.PictureBox();
            this.bStart = new System.Windows.Forms.Button();
            this.bStop = new System.Windows.Forms.Button();
            this.lStateAuto = new System.Windows.Forms.Label();
            this.gbContact = new System.Windows.Forms.GroupBox();
            this.llDiscord = new System.Windows.Forms.Label();
            this.lFacebook = new System.Windows.Forms.Label();
            this.lDiscord = new System.Windows.Forms.Label();
            this.llFacebook = new System.Windows.Forms.LinkLabel();
            this.lContact = new System.Windows.Forms.Label();
            this.lDescription = new System.Windows.Forms.Label();
            this.lInformation = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.pbSMx = new System.Windows.Forms.PictureBox();
            this.gbChannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFindChannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChannel)).BeginInit();
            this.gbCommand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCommand)).BeginInit();
            this.gbContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSMx)).BeginInit();
            this.SuspendLayout();
            // 
            // tmChat
            // 
            this.tmChat.Interval = 200;
            this.tmChat.Tick += new System.EventHandler(this.tmChat_Tick);
            // 
            // lNameChannel
            // 
            resources.ApplyResources(this.lNameChannel, "lNameChannel");
            this.lNameChannel.ForeColor = System.Drawing.SystemColors.Info;
            this.lNameChannel.Name = "lNameChannel";
            // 
            // lSlowmodeChannel
            // 
            resources.ApplyResources(this.lSlowmodeChannel, "lSlowmodeChannel");
            this.lSlowmodeChannel.Name = "lSlowmodeChannel";
            // 
            // cbSlowmode
            // 
            this.cbSlowmode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbSlowmode, "cbSlowmode");
            this.cbSlowmode.FormattingEnabled = true;
            this.cbSlowmode.Items.AddRange(new object[] {
            resources.GetString("cbSlowmode.Items"),
            resources.GetString("cbSlowmode.Items1"),
            resources.GetString("cbSlowmode.Items2"),
            resources.GetString("cbSlowmode.Items3"),
            resources.GetString("cbSlowmode.Items4"),
            resources.GetString("cbSlowmode.Items5"),
            resources.GetString("cbSlowmode.Items6"),
            resources.GetString("cbSlowmode.Items7"),
            resources.GetString("cbSlowmode.Items8"),
            resources.GetString("cbSlowmode.Items9"),
            resources.GetString("cbSlowmode.Items10"),
            resources.GetString("cbSlowmode.Items11"),
            resources.GetString("cbSlowmode.Items12"),
            resources.GetString("cbSlowmode.Items13")});
            this.cbSlowmode.Name = "cbSlowmode";
            this.cbSlowmode.SelectedIndexChanged += new System.EventHandler(this.cbSlowmode_SelectedIndexChanged);
            // 
            // lNameChannelLock
            // 
            resources.ApplyResources(this.lNameChannelLock, "lNameChannelLock");
            this.lNameChannelLock.Name = "lNameChannelLock";
            // 
            // lSlowmodeChannelLock
            // 
            resources.ApplyResources(this.lSlowmodeChannelLock, "lSlowmodeChannelLock");
            this.lSlowmodeChannelLock.Name = "lSlowmodeChannelLock";
            // 
            // gbChannel
            // 
            this.gbChannel.BackColor = System.Drawing.Color.Transparent;
            this.gbChannel.Controls.Add(this.pbFindChannel);
            this.gbChannel.Controls.Add(this.lSlowmodeChannelLock);
            this.gbChannel.Controls.Add(this.lNameChannelLock);
            this.gbChannel.Controls.Add(this.pbChannel);
            this.gbChannel.Controls.Add(this.cbSlowmode);
            this.gbChannel.Controls.Add(this.lSlowmodeChannel);
            this.gbChannel.Controls.Add(this.lNameChannel);
            resources.ApplyResources(this.gbChannel, "gbChannel");
            this.gbChannel.ForeColor = System.Drawing.SystemColors.Info;
            this.gbChannel.Name = "gbChannel";
            this.gbChannel.TabStop = false;
            // 
            // pbFindChannel
            // 
            resources.ApplyResources(this.pbFindChannel, "pbFindChannel");
            this.pbFindChannel.Name = "pbFindChannel";
            this.pbFindChannel.TabStop = false;
            this.pbFindChannel.Click += new System.EventHandler(this.pbFindChannel_Click);
            // 
            // pbChannel
            // 
            this.pbChannel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pbChannel, "pbChannel");
            this.pbChannel.Name = "pbChannel";
            this.pbChannel.TabStop = false;
            this.pbChannel.Click += new System.EventHandler(this.pbChannel_Click);
            // 
            // tmCheckMainProcess
            // 
            this.tmCheckMainProcess.Interval = 25;
            this.tmCheckMainProcess.Tick += new System.EventHandler(this.tmCheckMainProcess_Tick);
            // 
            // bAddCommand
            // 
            resources.ApplyResources(this.bAddCommand, "bAddCommand");
            this.bAddCommand.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bAddCommand.Name = "bAddCommand";
            this.bAddCommand.UseVisualStyleBackColor = true;
            this.bAddCommand.Click += new System.EventHandler(this.bAddCommand_Click);
            // 
            // bDelCommand
            // 
            resources.ApplyResources(this.bDelCommand, "bDelCommand");
            this.bDelCommand.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bDelCommand.Name = "bDelCommand";
            this.bDelCommand.UseVisualStyleBackColor = true;
            this.bDelCommand.Click += new System.EventHandler(this.bDelCommand_Click);
            // 
            // gbCommand
            // 
            this.gbCommand.BackColor = System.Drawing.Color.Transparent;
            this.gbCommand.Controls.Add(this.cbEnqueue);
            this.gbCommand.Controls.Add(this.bDelCommand);
            this.gbCommand.Controls.Add(this.bAddCommand);
            this.gbCommand.Controls.Add(this.pbCommand);
            resources.ApplyResources(this.gbCommand, "gbCommand");
            this.gbCommand.ForeColor = System.Drawing.SystemColors.Info;
            this.gbCommand.Name = "gbCommand";
            this.gbCommand.TabStop = false;
            // 
            // cbEnqueue
            // 
            resources.ApplyResources(this.cbEnqueue, "cbEnqueue");
            this.cbEnqueue.Checked = true;
            this.cbEnqueue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEnqueue.Name = "cbEnqueue";
            this.cbEnqueue.UseVisualStyleBackColor = false;
            // 
            // pbCommand
            // 
            resources.ApplyResources(this.pbCommand, "pbCommand");
            this.pbCommand.Name = "pbCommand";
            this.pbCommand.TabStop = false;
            this.pbCommand.Click += new System.EventHandler(this.pbCommand_Click);
            // 
            // bStart
            // 
            this.bStart.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.bStart, "bStart");
            this.bStart.Name = "bStart";
            this.bStart.UseVisualStyleBackColor = false;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bStop
            // 
            this.bStop.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.bStop, "bStop");
            this.bStop.ForeColor = System.Drawing.Color.Black;
            this.bStop.Name = "bStop";
            this.bStop.UseVisualStyleBackColor = false;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // lStateAuto
            // 
            resources.ApplyResources(this.lStateAuto, "lStateAuto");
            this.lStateAuto.BackColor = System.Drawing.Color.Transparent;
            this.lStateAuto.ForeColor = System.Drawing.Color.SpringGreen;
            this.lStateAuto.Name = "lStateAuto";
            // 
            // gbContact
            // 
            this.gbContact.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.gbContact, "gbContact");
            this.gbContact.Controls.Add(this.llDiscord);
            this.gbContact.Controls.Add(this.lFacebook);
            this.gbContact.Controls.Add(this.lDiscord);
            this.gbContact.Controls.Add(this.llFacebook);
            this.gbContact.Controls.Add(this.lContact);
            this.gbContact.Controls.Add(this.lDescription);
            this.gbContact.Controls.Add(this.lInformation);
            this.gbContact.Controls.Add(this.lName);
            this.gbContact.Controls.Add(this.pbSMx);
            this.gbContact.ForeColor = System.Drawing.SystemColors.Info;
            this.gbContact.Name = "gbContact";
            this.gbContact.TabStop = false;
            // 
            // llDiscord
            // 
            resources.ApplyResources(this.llDiscord, "llDiscord");
            this.llDiscord.ForeColor = System.Drawing.Color.Cyan;
            this.llDiscord.Name = "llDiscord";
            // 
            // lFacebook
            // 
            resources.ApplyResources(this.lFacebook, "lFacebook");
            this.lFacebook.ForeColor = System.Drawing.SystemColors.Info;
            this.lFacebook.Name = "lFacebook";
            // 
            // lDiscord
            // 
            resources.ApplyResources(this.lDiscord, "lDiscord");
            this.lDiscord.ForeColor = System.Drawing.SystemColors.Info;
            this.lDiscord.Name = "lDiscord";
            // 
            // llFacebook
            // 
            this.llFacebook.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.llFacebook, "llFacebook");
            this.llFacebook.ForeColor = System.Drawing.Color.Cyan;
            this.llFacebook.LinkColor = System.Drawing.Color.Cyan;
            this.llFacebook.LinkVisited = true;
            this.llFacebook.Name = "llFacebook";
            this.llFacebook.TabStop = true;
            this.llFacebook.VisitedLinkColor = System.Drawing.Color.Cyan;
            this.llFacebook.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llFacebook_LinkClicked);
            // 
            // lContact
            // 
            this.lContact.AllowDrop = true;
            resources.ApplyResources(this.lContact, "lContact");
            this.lContact.ForeColor = System.Drawing.SystemColors.Info;
            this.lContact.Name = "lContact";
            // 
            // lDescription
            // 
            resources.ApplyResources(this.lDescription, "lDescription");
            this.lDescription.ForeColor = System.Drawing.SystemColors.Info;
            this.lDescription.Name = "lDescription";
            // 
            // lInformation
            // 
            resources.ApplyResources(this.lInformation, "lInformation");
            this.lInformation.ForeColor = System.Drawing.SystemColors.Info;
            this.lInformation.Name = "lInformation";
            // 
            // lName
            // 
            resources.ApplyResources(this.lName, "lName");
            this.lName.ForeColor = System.Drawing.SystemColors.Info;
            this.lName.Name = "lName";
            // 
            // pbSMx
            // 
            resources.ApplyResources(this.pbSMx, "pbSMx");
            this.pbSMx.Name = "pbSMx";
            this.pbSMx.TabStop = false;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ACFD.Properties.Resources.bgMainForm;
            this.Controls.Add(this.gbContact);
            this.Controls.Add(this.lStateAuto);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.gbCommand);
            this.Controls.Add(this.gbChannel);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.gbChannel.ResumeLayout(false);
            this.gbChannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFindChannel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChannel)).EndInit();
            this.gbCommand.ResumeLayout(false);
            this.gbCommand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCommand)).EndInit();
            this.gbContact.ResumeLayout(false);
            this.gbContact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSMx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmChat;
        private System.Windows.Forms.Label lNameChannel;
        private System.Windows.Forms.Label lSlowmodeChannel;
        private System.Windows.Forms.ComboBox cbSlowmode;
        private System.Windows.Forms.PictureBox pbChannel;
        private System.Windows.Forms.Label lNameChannelLock;
        private System.Windows.Forms.Label lSlowmodeChannelLock;
        private System.Windows.Forms.PictureBox pbFindChannel;
        private System.Windows.Forms.GroupBox gbChannel;
        private System.Windows.Forms.Timer tmCheckMainProcess;
        private System.Windows.Forms.PictureBox pbCommand;
        private System.Windows.Forms.Button bAddCommand;
        private System.Windows.Forms.Button bDelCommand;
        private System.Windows.Forms.GroupBox gbCommand;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Label lStateAuto;
        private System.Windows.Forms.GroupBox gbContact;
        private System.Windows.Forms.PictureBox pbSMx;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lInformation;
        private System.Windows.Forms.Label lContact;
        private System.Windows.Forms.Label lDescription;
        private System.Windows.Forms.Label lDiscord;
        private System.Windows.Forms.LinkLabel llFacebook;
        private System.Windows.Forms.Label llDiscord;
        private System.Windows.Forms.Label lFacebook;
        private System.Windows.Forms.CheckBox cbEnqueue;
    }
}


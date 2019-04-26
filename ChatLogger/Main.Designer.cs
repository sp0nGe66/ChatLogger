﻿namespace ChatLogger
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroTab_AddAcc = new MetroFramework.Controls.MetroTabPage();
            this.Acc_ScrollBar = new MetroFramework.Controls.MetroScrollBar();
            this.btn_editAcc = new MetroFramework.Controls.MetroButton();
            this.btn_addAcc = new MetroFramework.Controls.MetroButton();
            this.btn_login2selected = new MetroFramework.Controls.MetroButton();
            this.AccountsList_Grid = new MetroFramework.Controls.MetroGrid();
            this.Headerusername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSteamid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTab_Logger = new MetroFramework.Controls.MetroTabPage();
            this.btn_separationSave = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLink_ChatLogsJSONPath = new MetroFramework.Controls.MetroLink();
            this.txtBox_saveSeparator = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txtBox_logDir = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTab_settings = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.chck_Minimized = new MetroFramework.Controls.MetroCheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.toggle_startWindows = new MetroFramework.Controls.MetroToggle();
            this.toggle_playSound = new MetroFramework.Controls.MetroToggle();
            this.metroLink_spkMusic = new MetroFramework.Controls.MetroLink();
            this.metroLink_spk = new MetroFramework.Controls.MetroLink();
            this.lbl_currentUsername = new MetroFramework.Controls.MetroLabel();
            this.btnLabel_PersonaAndFlag = new System.Windows.Forms.Button();
            this.panel_steamStates = new MetroFramework.Controls.MetroPanel();
            this.picBox_SteamAvatar = new System.Windows.Forms.PictureBox();
            this.lbl_connecting = new MetroFramework.Controls.MetroLabel();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.Trolha = new System.Windows.Forms.Timer(this.components);
            this.btn_logout = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.metroTabControl.SuspendLayout();
            this.metroTab_AddAcc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsList_Grid)).BeginInit();
            this.metroTab_Logger.SuspendLayout();
            this.metroTab_settings.SuspendLayout();
            this.panel_steamStates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_SteamAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(237, 224);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(75, 23);
            this.metroLink1.TabIndex = 0;
            this.metroLink1.Text = "metroLink1";
            this.metroLink1.UseSelectable = true;
            // 
            // metroTabControl
            // 
            this.metroTabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.metroTabControl.Controls.Add(this.metroTab_AddAcc);
            this.metroTabControl.Controls.Add(this.metroTab_Logger);
            this.metroTabControl.Controls.Add(this.metroTab_settings);
            this.metroTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.metroTabControl.Location = new System.Drawing.Point(1, 67);
            this.metroTabControl.Multiline = true;
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 1;
            this.metroTabControl.ShowToolTips = true;
            this.metroTabControl.Size = new System.Drawing.Size(415, 465);
            this.metroTabControl.TabIndex = 4;
            this.metroTabControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTabControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl.UseSelectable = true;
            // 
            // metroTab_AddAcc
            // 
            this.metroTab_AddAcc.BackColor = System.Drawing.Color.Transparent;
            this.metroTab_AddAcc.Controls.Add(this.Acc_ScrollBar);
            this.metroTab_AddAcc.Controls.Add(this.btn_editAcc);
            this.metroTab_AddAcc.Controls.Add(this.btn_addAcc);
            this.metroTab_AddAcc.Controls.Add(this.btn_login2selected);
            this.metroTab_AddAcc.Controls.Add(this.AccountsList_Grid);
            this.metroTab_AddAcc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTab_AddAcc.HorizontalScrollbarBarColor = true;
            this.metroTab_AddAcc.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTab_AddAcc.HorizontalScrollbarSize = 10;
            this.metroTab_AddAcc.Location = new System.Drawing.Point(4, 41);
            this.metroTab_AddAcc.Name = "metroTab_AddAcc";
            this.metroTab_AddAcc.Size = new System.Drawing.Size(407, 420);
            this.metroTab_AddAcc.TabIndex = 0;
            this.metroTab_AddAcc.Text = "ACCOUNTS ";
            this.metroTab_AddAcc.UseCustomBackColor = true;
            this.metroTab_AddAcc.UseCustomForeColor = true;
            this.metroTab_AddAcc.UseStyleColors = true;
            this.metroTab_AddAcc.VerticalScrollbarBarColor = true;
            this.metroTab_AddAcc.VerticalScrollbarHighlightOnWheel = false;
            this.metroTab_AddAcc.VerticalScrollbarSize = 10;
            // 
            // Acc_ScrollBar
            // 
            this.Acc_ScrollBar.LargeChange = 10;
            this.Acc_ScrollBar.Location = new System.Drawing.Point(382, 22);
            this.Acc_ScrollBar.Maximum = 100;
            this.Acc_ScrollBar.Minimum = 0;
            this.Acc_ScrollBar.MouseWheelBarPartitions = 10;
            this.Acc_ScrollBar.Name = "Acc_ScrollBar";
            this.Acc_ScrollBar.Orientation = MetroFramework.Controls.MetroScrollOrientation.Vertical;
            this.Acc_ScrollBar.ScrollbarSize = 15;
            this.Acc_ScrollBar.Size = new System.Drawing.Size(15, 331);
            this.Acc_ScrollBar.Style = MetroFramework.MetroColorStyle.Purple;
            this.Acc_ScrollBar.TabIndex = 26;
            this.Acc_ScrollBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Acc_ScrollBar.UseBarColor = true;
            this.Acc_ScrollBar.UseSelectable = true;
            this.Acc_ScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Acc_ScrollBar_Scroll);
            // 
            // btn_editAcc
            // 
            this.btn_editAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_editAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_editAcc.Location = new System.Drawing.Point(3, 363);
            this.btn_editAcc.Name = "btn_editAcc";
            this.btn_editAcc.Size = new System.Drawing.Size(99, 57);
            this.btn_editAcc.TabIndex = 25;
            this.btn_editAcc.Text = "EDIT ACCOUNT";
            this.btn_editAcc.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_editAcc.UseCustomBackColor = true;
            this.btn_editAcc.UseCustomForeColor = true;
            this.btn_editAcc.UseSelectable = true;
            this.btn_editAcc.UseStyleColors = true;
            this.btn_editAcc.Click += new System.EventHandler(this.btn_editAcc_Click);
            // 
            // btn_addAcc
            // 
            this.btn_addAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_addAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_addAcc.Location = new System.Drawing.Point(108, 363);
            this.btn_addAcc.Name = "btn_addAcc";
            this.btn_addAcc.Size = new System.Drawing.Size(99, 57);
            this.btn_addAcc.TabIndex = 24;
            this.btn_addAcc.Text = "ADD ACCOUNT";
            this.btn_addAcc.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_addAcc.UseCustomBackColor = true;
            this.btn_addAcc.UseCustomForeColor = true;
            this.btn_addAcc.UseSelectable = true;
            this.btn_addAcc.UseStyleColors = true;
            this.btn_addAcc.Click += new System.EventHandler(this.btn_addAcc_Click);
            // 
            // btn_login2selected
            // 
            this.btn_login2selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_login2selected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_login2selected.Location = new System.Drawing.Point(298, 360);
            this.btn_login2selected.Name = "btn_login2selected";
            this.btn_login2selected.Size = new System.Drawing.Size(99, 57);
            this.btn_login2selected.TabIndex = 5;
            this.btn_login2selected.TabStop = false;
            this.btn_login2selected.Text = "LOGIN";
            this.btn_login2selected.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_login2selected.UseCustomBackColor = true;
            this.btn_login2selected.UseCustomForeColor = true;
            this.btn_login2selected.UseSelectable = true;
            this.btn_login2selected.UseStyleColors = true;
            this.btn_login2selected.Click += new System.EventHandler(this.btn_login2selected_Click);
            // 
            // AccountsList_Grid
            // 
            this.AccountsList_Grid.AllowUserToAddRows = false;
            this.AccountsList_Grid.AllowUserToDeleteRows = false;
            this.AccountsList_Grid.AllowUserToOrderColumns = true;
            this.AccountsList_Grid.AllowUserToResizeColumns = false;
            this.AccountsList_Grid.AllowUserToResizeRows = false;
            this.AccountsList_Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.AccountsList_Grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AccountsList_Grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.AccountsList_Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AccountsList_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AccountsList_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountsList_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Headerusername,
            this.HSteamid});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AccountsList_Grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.AccountsList_Grid.EnableHeadersVisualStyles = false;
            this.AccountsList_Grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AccountsList_Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.AccountsList_Grid.Location = new System.Drawing.Point(-42, 6);
            this.AccountsList_Grid.MultiSelect = false;
            this.AccountsList_Grid.Name = "AccountsList_Grid";
            this.AccountsList_Grid.ReadOnly = true;
            this.AccountsList_Grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AccountsList_Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.AccountsList_Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.AccountsList_Grid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AccountsList_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AccountsList_Grid.Size = new System.Drawing.Size(439, 348);
            this.AccountsList_Grid.TabIndex = 23;
            this.AccountsList_Grid.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AccountsList_Grid.UseCustomBackColor = true;
            this.AccountsList_Grid.UseCustomForeColor = true;
            this.AccountsList_Grid.UseStyleColors = true;
            this.AccountsList_Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccountsList_Grid_CellClick);
            // 
            // Headerusername
            // 
            this.Headerusername.HeaderText = "USERNAME";
            this.Headerusername.Name = "Headerusername";
            this.Headerusername.ReadOnly = true;
            this.Headerusername.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Headerusername.Width = 250;
            // 
            // HSteamid
            // 
            this.HSteamid.HeaderText = "STEAMID";
            this.HSteamid.Name = "HSteamid";
            this.HSteamid.ReadOnly = true;
            this.HSteamid.Width = 180;
            // 
            // metroTab_Logger
            // 
            this.metroTab_Logger.BackColor = System.Drawing.Color.Transparent;
            this.metroTab_Logger.Controls.Add(this.btn_separationSave);
            this.metroTab_Logger.Controls.Add(this.metroLabel1);
            this.metroTab_Logger.Controls.Add(this.metroLink_ChatLogsJSONPath);
            this.metroTab_Logger.Controls.Add(this.txtBox_saveSeparator);
            this.metroTab_Logger.Controls.Add(this.metroLabel5);
            this.metroTab_Logger.Controls.Add(this.metroButton1);
            this.metroTab_Logger.Controls.Add(this.txtBox_logDir);
            this.metroTab_Logger.Controls.Add(this.metroLabel4);
            this.metroTab_Logger.HorizontalScrollbarBarColor = true;
            this.metroTab_Logger.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTab_Logger.HorizontalScrollbarSize = 10;
            this.metroTab_Logger.Location = new System.Drawing.Point(4, 41);
            this.metroTab_Logger.Name = "metroTab_Logger";
            this.metroTab_Logger.Size = new System.Drawing.Size(407, 420);
            this.metroTab_Logger.TabIndex = 12;
            this.metroTab_Logger.Text = "LOGGER";
            this.metroTab_Logger.UseCustomBackColor = true;
            this.metroTab_Logger.VerticalScrollbarBarColor = true;
            this.metroTab_Logger.VerticalScrollbarHighlightOnWheel = false;
            this.metroTab_Logger.VerticalScrollbarSize = 10;
            // 
            // btn_separationSave
            // 
            this.btn_separationSave.Location = new System.Drawing.Point(311, 162);
            this.btn_separationSave.Name = "btn_separationSave";
            this.btn_separationSave.Size = new System.Drawing.Size(75, 23);
            this.btn_separationSave.TabIndex = 18;
            this.btn_separationSave.Text = "Save";
            this.btn_separationSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_separationSave.UseSelectable = true;
            this.btn_separationSave.UseStyleColors = true;
            this.btn_separationSave.Click += new System.EventHandler(this.btn_separationSave_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(41, 81);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "Go to folder:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLink_ChatLogsJSONPath
            // 
            this.metroLink_ChatLogsJSONPath.Location = new System.Drawing.Point(132, 76);
            this.metroLink_ChatLogsJSONPath.Name = "metroLink_ChatLogsJSONPath";
            this.metroLink_ChatLogsJSONPath.Size = new System.Drawing.Size(31, 31);
            this.metroLink_ChatLogsJSONPath.TabIndex = 16;
            this.metroLink_ChatLogsJSONPath.Text = "📁";
            this.metroLink_ChatLogsJSONPath.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLink_ChatLogsJSONPath.UseCustomBackColor = true;
            this.metroLink_ChatLogsJSONPath.UseSelectable = true;
            this.metroLink_ChatLogsJSONPath.Click += new System.EventHandler(this.metroLink_ChatLogsPath_Click);
            // 
            // txtBox_saveSeparator
            // 
            // 
            // 
            // 
            this.txtBox_saveSeparator.CustomButton.Image = null;
            this.txtBox_saveSeparator.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.txtBox_saveSeparator.CustomButton.Name = "";
            this.txtBox_saveSeparator.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBox_saveSeparator.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBox_saveSeparator.CustomButton.TabIndex = 1;
            this.txtBox_saveSeparator.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBox_saveSeparator.CustomButton.UseSelectable = true;
            this.txtBox_saveSeparator.CustomButton.Visible = false;
            this.txtBox_saveSeparator.Lines = new string[] {
        "───────────────────"};
            this.txtBox_saveSeparator.Location = new System.Drawing.Point(132, 162);
            this.txtBox_saveSeparator.MaxLength = 32767;
            this.txtBox_saveSeparator.Name = "txtBox_saveSeparator";
            this.txtBox_saveSeparator.PasswordChar = '\0';
            this.txtBox_saveSeparator.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBox_saveSeparator.SelectedText = "";
            this.txtBox_saveSeparator.SelectionLength = 0;
            this.txtBox_saveSeparator.SelectionStart = 0;
            this.txtBox_saveSeparator.ShortcutsEnabled = true;
            this.txtBox_saveSeparator.Size = new System.Drawing.Size(175, 23);
            this.txtBox_saveSeparator.TabIndex = 13;
            this.txtBox_saveSeparator.Text = "───────────────────";
            this.txtBox_saveSeparator.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtBox_saveSeparator.UseSelectable = true;
            this.txtBox_saveSeparator.UseStyleColors = true;
            this.txtBox_saveSeparator.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBox_saveSeparator.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(15, 162);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(111, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Separation string:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel5.UseStyleColors = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(311, 115);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 11;
            this.metroButton1.Text = "Browse";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            // 
            // txtBox_logDir
            // 
            // 
            // 
            // 
            this.txtBox_logDir.CustomButton.Image = null;
            this.txtBox_logDir.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.txtBox_logDir.CustomButton.Name = "";
            this.txtBox_logDir.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBox_logDir.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBox_logDir.CustomButton.TabIndex = 1;
            this.txtBox_logDir.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBox_logDir.CustomButton.UseSelectable = true;
            this.txtBox_logDir.CustomButton.Visible = false;
            this.txtBox_logDir.Lines = new string[0];
            this.txtBox_logDir.Location = new System.Drawing.Point(132, 115);
            this.txtBox_logDir.MaxLength = 32767;
            this.txtBox_logDir.Name = "txtBox_logDir";
            this.txtBox_logDir.PasswordChar = '\0';
            this.txtBox_logDir.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBox_logDir.SelectedText = "";
            this.txtBox_logDir.SelectionLength = 0;
            this.txtBox_logDir.SelectionStart = 0;
            this.txtBox_logDir.ShortcutsEnabled = true;
            this.txtBox_logDir.Size = new System.Drawing.Size(175, 23);
            this.txtBox_logDir.TabIndex = 10;
            this.txtBox_logDir.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtBox_logDir.UseSelectable = true;
            this.txtBox_logDir.UseStyleColors = true;
            this.txtBox_logDir.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBox_logDir.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(35, 119);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(91, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Log directory:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroTab_settings
            // 
            this.metroTab_settings.BackColor = System.Drawing.Color.Transparent;
            this.metroTab_settings.Controls.Add(this.metroLabel3);
            this.metroTab_settings.Controls.Add(this.metroComboBox1);
            this.metroTab_settings.Controls.Add(this.chck_Minimized);
            this.metroTab_settings.Controls.Add(this.richTextBox1);
            this.metroTab_settings.Controls.Add(this.metroLabel10);
            this.metroTab_settings.Controls.Add(this.metroLabel8);
            this.metroTab_settings.Controls.Add(this.toggle_startWindows);
            this.metroTab_settings.Controls.Add(this.toggle_playSound);
            this.metroTab_settings.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTab_settings.HorizontalScrollbarBarColor = true;
            this.metroTab_settings.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTab_settings.HorizontalScrollbarSize = 10;
            this.metroTab_settings.Location = new System.Drawing.Point(4, 41);
            this.metroTab_settings.Name = "metroTab_settings";
            this.metroTab_settings.Size = new System.Drawing.Size(407, 420);
            this.metroTab_settings.TabIndex = 11;
            this.metroTab_settings.Text = "SETTINGS";
            this.metroTab_settings.UseCustomBackColor = true;
            this.metroTab_settings.UseCustomForeColor = true;
            this.metroTab_settings.VerticalScrollbarBarColor = true;
            this.metroTab_settings.VerticalScrollbarHighlightOnWheel = false;
            this.metroTab_settings.VerticalScrollbarSize = 10;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.White;
            this.metroLabel3.Location = new System.Drawing.Point(72, 76);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(90, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "Theme Color:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(168, 66);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.TabIndex = 15;
            this.metroComboBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroComboBox1.UseSelectable = true;
            // 
            // chck_Minimized
            // 
            this.chck_Minimized.AutoSize = true;
            this.chck_Minimized.Location = new System.Drawing.Point(212, 169);
            this.chck_Minimized.Name = "chck_Minimized";
            this.chck_Minimized.Size = new System.Drawing.Size(79, 15);
            this.chck_Minimized.TabIndex = 13;
            this.chck_Minimized.Text = "Minimized";
            this.chck_Minimized.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chck_Minimized.UseSelectable = true;
            this.chck_Minimized.UseStyleColors = true;
            this.chck_Minimized.CheckedChanged += new System.EventHandler(this.chck_Minimized_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox1.DetectUrls = false;
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.richTextBox1.Location = new System.Drawing.Point(168, 170);
            this.richTextBox1.MaxLength = 50;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(42, 14);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "└───";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.ForeColor = System.Drawing.Color.White;
            this.metroLabel10.Location = new System.Drawing.Point(73, 141);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(128, 19);
            this.metroLabel10.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel10.TabIndex = 12;
            this.metroLabel10.Text = "Start with windows:";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel10.UseCustomBackColor = true;
            this.metroLabel10.UseCustomForeColor = true;
            this.metroLabel10.UseStyleColors = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.ForeColor = System.Drawing.Color.White;
            this.metroLabel8.Location = new System.Drawing.Point(73, 221);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(127, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel8.TabIndex = 11;
            this.metroLabel8.Text = "Play startup sound:";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseCustomForeColor = true;
            this.metroLabel8.UseStyleColors = true;
            // 
            // toggle_startWindows
            // 
            this.toggle_startWindows.AutoSize = true;
            this.toggle_startWindows.Location = new System.Drawing.Point(207, 141);
            this.toggle_startWindows.Name = "toggle_startWindows";
            this.toggle_startWindows.Size = new System.Drawing.Size(80, 17);
            this.toggle_startWindows.TabIndex = 10;
            this.toggle_startWindows.Text = "Off";
            this.toggle_startWindows.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toggle_startWindows.UseCustomBackColor = true;
            this.toggle_startWindows.UseCustomForeColor = true;
            this.toggle_startWindows.UseSelectable = true;
            this.toggle_startWindows.UseStyleColors = true;
            this.toggle_startWindows.CheckedChanged += new System.EventHandler(this.toggle_startWindows_CheckedChanged);
            // 
            // toggle_playSound
            // 
            this.toggle_playSound.AutoSize = true;
            this.toggle_playSound.Location = new System.Drawing.Point(207, 221);
            this.toggle_playSound.Name = "toggle_playSound";
            this.toggle_playSound.Size = new System.Drawing.Size(80, 17);
            this.toggle_playSound.TabIndex = 9;
            this.toggle_playSound.Text = "Off";
            this.toggle_playSound.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toggle_playSound.UseCustomBackColor = true;
            this.toggle_playSound.UseCustomForeColor = true;
            this.toggle_playSound.UseSelectable = true;
            this.toggle_playSound.UseStyleColors = true;
            this.toggle_playSound.CheckedChanged += new System.EventHandler(this.toggle_playSound_CheckedChanged);
            // 
            // metroLink_spkMusic
            // 
            this.metroLink_spkMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLink_spkMusic.Location = new System.Drawing.Point(388, 530);
            this.metroLink_spkMusic.Name = "metroLink_spkMusic";
            this.metroLink_spkMusic.Size = new System.Drawing.Size(29, 19);
            this.metroLink_spkMusic.TabIndex = 47;
            this.metroLink_spkMusic.Text = "🎶";
            this.metroLink_spkMusic.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLink_spkMusic.UseCustomBackColor = true;
            this.metroLink_spkMusic.UseSelectable = true;
            this.metroLink_spkMusic.Click += new System.EventHandler(this.metroLink_spkMusic_Click);
            // 
            // metroLink_spk
            // 
            this.metroLink_spk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLink_spk.Location = new System.Drawing.Point(332, 531);
            this.metroLink_spk.Name = "metroLink_spk";
            this.metroLink_spk.Size = new System.Drawing.Size(60, 19);
            this.metroLink_spk.TabIndex = 14;
            this.metroLink_spk.Text = "SP0OK3R";
            this.metroLink_spk.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLink_spk.UseCustomBackColor = true;
            this.metroLink_spk.UseSelectable = true;
            this.metroLink_spk.Click += new System.EventHandler(this.metroLink_spk_Click);
            // 
            // lbl_currentUsername
            // 
            this.lbl_currentUsername.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbl_currentUsername.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_currentUsername.Location = new System.Drawing.Point(196, 44);
            this.lbl_currentUsername.Name = "lbl_currentUsername";
            this.lbl_currentUsername.Size = new System.Drawing.Size(163, 18);
            this.lbl_currentUsername.TabIndex = 44;
            this.lbl_currentUsername.Text = "None";
            this.lbl_currentUsername.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_currentUsername.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbl_currentUsername.UseCustomBackColor = true;
            this.lbl_currentUsername.UseStyleColors = true;
            // 
            // btnLabel_PersonaAndFlag
            // 
            this.btnLabel_PersonaAndFlag.BackColor = System.Drawing.Color.Transparent;
            this.btnLabel_PersonaAndFlag.FlatAppearance.BorderSize = 0;
            this.btnLabel_PersonaAndFlag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLabel_PersonaAndFlag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLabel_PersonaAndFlag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLabel_PersonaAndFlag.ForeColor = System.Drawing.Color.White;
            this.btnLabel_PersonaAndFlag.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLabel_PersonaAndFlag.Location = new System.Drawing.Point(194, 57);
            this.btnLabel_PersonaAndFlag.Name = "btnLabel_PersonaAndFlag";
            this.btnLabel_PersonaAndFlag.Size = new System.Drawing.Size(168, 22);
            this.btnLabel_PersonaAndFlag.TabIndex = 44;
            this.btnLabel_PersonaAndFlag.Text = "None";
            this.btnLabel_PersonaAndFlag.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLabel_PersonaAndFlag.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLabel_PersonaAndFlag.UseVisualStyleBackColor = true;
            // 
            // panel_steamStates
            // 
            this.panel_steamStates.BackColor = System.Drawing.Color.Gray;
            this.panel_steamStates.Controls.Add(this.picBox_SteamAvatar);
            this.panel_steamStates.ForeColor = System.Drawing.Color.DimGray;
            this.panel_steamStates.HorizontalScrollbarBarColor = true;
            this.panel_steamStates.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_steamStates.HorizontalScrollbarSize = 10;
            this.panel_steamStates.Location = new System.Drawing.Point(362, 30);
            this.panel_steamStates.Name = "panel_steamStates";
            this.panel_steamStates.Size = new System.Drawing.Size(52, 52);
            this.panel_steamStates.TabIndex = 31;
            this.panel_steamStates.UseCustomBackColor = true;
            this.panel_steamStates.VerticalScrollbarBarColor = true;
            this.panel_steamStates.VerticalScrollbarHighlightOnWheel = false;
            this.panel_steamStates.VerticalScrollbarSize = 10;
            // 
            // picBox_SteamAvatar
            // 
            this.picBox_SteamAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.picBox_SteamAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox_SteamAvatar.Location = new System.Drawing.Point(1, 1);
            this.picBox_SteamAvatar.Name = "picBox_SteamAvatar";
            this.picBox_SteamAvatar.Size = new System.Drawing.Size(50, 50);
            this.picBox_SteamAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_SteamAvatar.TabIndex = 23;
            this.picBox_SteamAvatar.TabStop = false;
            // 
            // lbl_connecting
            // 
            this.lbl_connecting.AutoSize = true;
            this.lbl_connecting.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbl_connecting.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_connecting.Location = new System.Drawing.Point(288, 28);
            this.lbl_connecting.Name = "lbl_connecting";
            this.lbl_connecting.Size = new System.Drawing.Size(71, 15);
            this.lbl_connecting.Style = MetroFramework.MetroColorStyle.Purple;
            this.lbl_connecting.TabIndex = 31;
            this.lbl_connecting.Text = "Logged in as";
            this.lbl_connecting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_connecting.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbl_connecting.UseCustomBackColor = true;
            this.lbl_connecting.UseCustomForeColor = true;
            // 
            // metroLink2
            // 
            this.metroLink2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.metroLink2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLink2.Location = new System.Drawing.Point(312, 530);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(22, 19);
            this.metroLink2.TabIndex = 48;
            this.metroLink2.Text = "by";
            this.metroLink2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLink2.UseSelectable = true;
            // 
            // Trolha
            // 
            this.Trolha.Enabled = true;
            this.Trolha.Interval = 3000;
            this.Trolha.Tick += new System.EventHandler(this.Trolha_Tick);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_logout.Location = new System.Drawing.Point(362, 83);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(52, 17);
            this.btn_logout.Style = MetroFramework.MetroColorStyle.Purple;
            this.btn_logout.TabIndex = 49;
            this.btn_logout.Text = "LOGOUT";
            this.btn_logout.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_logout.UseCustomBackColor = true;
            this.btn_logout.UseCustomForeColor = true;
            this.btn_logout.UseSelectable = true;
            this.btn_logout.UseStyleColors = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 547);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.lbl_currentUsername);
            this.Controls.Add(this.btnLabel_PersonaAndFlag);
            this.Controls.Add(this.panel_steamStates);
            this.Controls.Add(this.metroLink2);
            this.Controls.Add(this.lbl_connecting);
            this.Controls.Add(this.metroTabControl);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.metroLink_spk);
            this.Controls.Add(this.metroLink_spkMusic);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Chat Logger";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Main_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.metroTabControl.ResumeLayout(false);
            this.metroTab_AddAcc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AccountsList_Grid)).EndInit();
            this.metroTab_Logger.ResumeLayout(false);
            this.metroTab_Logger.PerformLayout();
            this.metroTab_settings.ResumeLayout(false);
            this.metroTab_settings.PerformLayout();
            this.panel_steamStates.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_SteamAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private MetroFramework.Controls.MetroTabPage metroTab_AddAcc;
        private MetroFramework.Controls.MetroLink metroLink_spkMusic;
        private MetroFramework.Controls.MetroLink metroLink_spk;
        private MetroFramework.Controls.MetroGrid AccountsList_Grid;
        private MetroFramework.Controls.MetroButton btn_login2selected;
        private MetroFramework.Controls.MetroTabPage metroTab_settings;
        private MetroFramework.Controls.MetroButton btn_editAcc;
        private MetroFramework.Controls.MetroButton btn_addAcc;
        private MetroFramework.Controls.MetroScrollBar Acc_ScrollBar;
        private MetroFramework.Controls.MetroCheckBox chck_Minimized;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroToggle toggle_startWindows;
        private MetroFramework.Controls.MetroToggle toggle_playSound;
        private MetroFramework.Controls.MetroTabPage metroTab_Logger;
        private MetroFramework.Controls.MetroLabel lbl_currentUsername;
        private System.Windows.Forms.Button btnLabel_PersonaAndFlag;
        private MetroFramework.Controls.MetroPanel panel_steamStates;
        private System.Windows.Forms.PictureBox picBox_SteamAvatar;
        private MetroFramework.Controls.MetroLabel lbl_connecting;
        private MetroFramework.Controls.MetroLink metroLink2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.Timer Trolha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Headerusername;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSteamid;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox txtBox_logDir;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtBox_saveSeparator;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLink metroLink_ChatLogsJSONPath;
        private MetroFramework.Controls.MetroButton btn_logout;
        private MetroFramework.Controls.MetroButton btn_separationSave;
    }
}

﻿#region Copyright
//=======================================================================================
// Microsoft Azure Customer Advisory Team 
//
// This sample is supplemental to the technical guidance published on my personal
// blog at http://blogs.msdn.com/b/paolos/. 
// 
// Author: Paolo Salvatori
//=======================================================================================
// Copyright (c) Microsoft Corporation. All rights reserved.
// 
// LICENSED UNDER THE APACHE LICENSE, VERSION 2.0 (THE "LICENSE"); YOU MAY NOT USE THESE 
// FILES EXCEPT IN COMPLIANCE WITH THE LICENSE. YOU MAY OBTAIN A COPY OF THE LICENSE AT 
// http://www.apache.org/licenses/LICENSE-2.0
// UNLESS REQUIRED BY APPLICABLE LAW OR AGREED TO IN WRITING, SOFTWARE DISTRIBUTED UNDER THE 
// LICENSE IS DISTRIBUTED ON AN "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY 
// KIND, EITHER EXPRESS OR IMPLIED. SEE THE LICENSE FOR THE SPECIFIC LANGUAGE GOVERNING 
// PERMISSIONS AND LIMITATIONS UNDER THE LICENSE.
//=======================================================================================
#endregion

using ServiceBusExplorer.Controls;

namespace ServiceBusExplorer.Forms
{
    partial class OptionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        #region Private Fields
        private System.ComponentModel.IContainer components = null;
        #endregion

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
            ServiceBusExplorer.Controls.CheckBoxProperties checkBoxProperties1 = new ServiceBusExplorer.Controls.CheckBoxProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionForm));
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboConfigFile = new System.Windows.Forms.ComboBox();
            this.btnOpenConfig = new System.Windows.Forms.Button();
            this.tabOptionsControl = new System.Windows.Forms.TabControl();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.lblSaveCheckpointsOnExit = new System.Windows.Forms.Label();
            this.saveCheckpointsToFileCheckBox = new System.Windows.Forms.CheckBox();
            this.cboSelectedEntities = new ServiceBusExplorer.Controls.CheckBoxComboBox();
            this.lblSelectedEntities = new System.Windows.Forms.Label();
            this.monitorRefreshIntervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lblMonitorRefreshInterval = new System.Windows.Forms.Label();
            this.useAsciiCheckBox = new System.Windows.Forms.CheckBox();
            this.lblUseAscii = new System.Windows.Forms.Label();
            this.lblShowMessageCount = new System.Windows.Forms.Label();
            this.showMessageCountCheckBox = new System.Windows.Forms.CheckBox();
            this.lblEncoding = new System.Windows.Forms.Label();
            this.cboEncodingType = new System.Windows.Forms.ComboBox();
            this.serverTimeoutNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lblServerTimeout = new System.Windows.Forms.Label();
            this.treeViewNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lblTreeViewFontSize = new System.Windows.Forms.Label();
            this.logNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lblLogFontSize = new System.Windows.Forms.Label();
            this.tabPageReceiving = new System.Windows.Forms.TabPage();
            this.receiverThinkTimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lblReceiverThinkTime = new System.Windows.Forms.Label();
            this.prefetchCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lblPrefetchCount = new System.Windows.Forms.Label();
            this.receiveTimeoutNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lblReceiveTimeout = new System.Windows.Forms.Label();
            this.topNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lblTop = new System.Windows.Forms.Label();
            this.retryTimeoutNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lblRetryTimeout = new System.Windows.Forms.Label();
            this.retryCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lblRetryCount = new System.Windows.Forms.Label();
            this.tabPageSending = new System.Windows.Forms.TabPage();
            this.saveMessageToFileCheckBox = new System.Windows.Forms.CheckBox();
            this.lblMessageContentType = new System.Windows.Forms.Label();
            this.txtMessageContentType = new System.Windows.Forms.TextBox();
            this.cboDefaultMessageBodyType = new System.Windows.Forms.ComboBox();
            this.LabelDefaultMessageBodyType = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtMessageFile = new System.Windows.Forms.TextBox();
            this.lblMessageFile = new System.Windows.Forms.Label();
            this.txtMessageText = new System.Windows.Forms.TextBox();
            this.lblMessageText = new System.Windows.Forms.Label();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.lblLabel = new System.Windows.Forms.Label();
            this.senderThinkTimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lblSenderThinkTime = new System.Windows.Forms.Label();
            this.lblSavePropertiesOnExit = new System.Windows.Forms.Label();
            this.lblSaveMessageOnExit = new System.Windows.Forms.Label();
            this.savePropertiesToFileCheckBox = new System.Windows.Forms.CheckBox();
            this.tabPageConnectivity = new System.Windows.Forms.TabPage();
            this.useAmqpWebSocketsCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboConnectivityMode = new System.Windows.Forms.ComboBox();
            this.lblConnectivityMode = new System.Windows.Forms.Label();
            this.tabPageProxy = new System.Windows.Forms.TabPage();
            this.txtProxyPassword = new System.Windows.Forms.TextBox();
            this.useDefaultProxyCredentialsCheckBox = new System.Windows.Forms.CheckBox();
            this.lblProxyPassword = new System.Windows.Forms.Label();
            this.lblProxyDefaultCredentials = new System.Windows.Forms.Label();
            this.txtProxyUserName = new System.Windows.Forms.TextBox();
            this.lblProxyUser = new System.Windows.Forms.Label();
            this.bypassProxyOnLocalAddressesCheckBox = new System.Windows.Forms.CheckBox();
            this.lblBypassProxyOnLocalAddresses = new System.Windows.Forms.Label();
            this.txtProxyBypassList = new System.Windows.Forms.TextBox();
            this.lblProxyBypass = new System.Windows.Forms.Label();
            this.overrideDefaultProxyCheckBox = new System.Windows.Forms.CheckBox();
            this.lblOverrideProxy = new System.Windows.Forms.Label();
            this.txtProxyAddress = new System.Windows.Forms.TextBox();
            this.lblProxyAddress = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.tabOptionsControl.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monitorRefreshIntervalNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverTimeoutNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logNumericUpDown)).BeginInit();
            this.tabPageReceiving.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiverThinkTimeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prefetchCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiveTimeoutNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retryTimeoutNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retryCountNumericUpDown)).BeginInit();
            this.tabPageSending.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.senderThinkTimeNumericUpDown)).BeginInit();
            this.tabPageConnectivity.SuspendLayout();
            this.tabPageProxy.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Location = new System.Drawing.Point(576, 737);
            this.btnOk.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(144, 46);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            this.btnOk.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.btnOk.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.btnCancel.CausesValidation = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(736, 737);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(144, 46);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.btnCancel.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(1056, 737);
            this.btnReset.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(144, 46);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.btnReset.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(896, 737);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 46);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(9, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 569);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numericUpDown1.Location = new System.Drawing.Point(441, 273);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(107, 31);
            this.numericUpDown1.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 278);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "Log Font Size:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numericUpDown2.Location = new System.Drawing.Point(278, 31);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(107, 31);
            this.numericUpDown2.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 52;
            this.label3.Text = "Log Font Size:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuration File for Settings and Connection Strings:";
            // 
            // cboConfigFile
            // 
            this.cboConfigFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConfigFile.DropDownWidth = 156;
            this.cboConfigFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboConfigFile.FormattingEnabled = true;
            this.cboConfigFile.Location = new System.Drawing.Point(576, 19);
            this.cboConfigFile.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboConfigFile.Name = "cboConfigFile";
            this.cboConfigFile.Size = new System.Drawing.Size(440, 33);
            this.cboConfigFile.TabIndex = 1;
            this.cboConfigFile.SelectionChangeCommitted += new System.EventHandler(this.cboConfigFile_SelectionChangeCommitted);
            // 
            // btnOpenConfig
            // 
            this.btnOpenConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.btnOpenConfig.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnOpenConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnOpenConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnOpenConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenConfig.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnOpenConfig.Location = new System.Drawing.Point(1056, 15);
            this.btnOpenConfig.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnOpenConfig.Name = "btnOpenConfig";
            this.btnOpenConfig.Size = new System.Drawing.Size(144, 46);
            this.btnOpenConfig.TabIndex = 0;
            this.btnOpenConfig.Text = "O&pen";
            this.btnOpenConfig.UseVisualStyleBackColor = false;
            this.btnOpenConfig.Click += new System.EventHandler(this.btnOpenConfig_Click);
            // 
            // tabOptionsControl
            // 
            this.tabOptionsControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabOptionsControl.Controls.Add(this.tabPageGeneral);
            this.tabOptionsControl.Controls.Add(this.tabPageReceiving);
            this.tabOptionsControl.Controls.Add(this.tabPageSending);
            this.tabOptionsControl.Controls.Add(this.tabPageConnectivity);
            this.tabOptionsControl.Controls.Add(this.tabPageProxy);
            this.tabOptionsControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabOptionsControl.Location = new System.Drawing.Point(32, 75);
            this.tabOptionsControl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabOptionsControl.Name = "tabOptionsControl";
            this.tabOptionsControl.SelectedIndex = 0;
            this.tabOptionsControl.Size = new System.Drawing.Size(1168, 642);
            this.tabOptionsControl.TabIndex = 51;
            this.tabOptionsControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControlOptions_DrawItem);
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.tabPageGeneral.Controls.Add(this.lblSaveCheckpointsOnExit);
            this.tabPageGeneral.Controls.Add(this.saveCheckpointsToFileCheckBox);
            this.tabPageGeneral.Controls.Add(this.cboSelectedEntities);
            this.tabPageGeneral.Controls.Add(this.lblSelectedEntities);
            this.tabPageGeneral.Controls.Add(this.monitorRefreshIntervalNumericUpDown);
            this.tabPageGeneral.Controls.Add(this.lblMonitorRefreshInterval);
            this.tabPageGeneral.Controls.Add(this.useAsciiCheckBox);
            this.tabPageGeneral.Controls.Add(this.lblUseAscii);
            this.tabPageGeneral.Controls.Add(this.lblShowMessageCount);
            this.tabPageGeneral.Controls.Add(this.showMessageCountCheckBox);
            this.tabPageGeneral.Controls.Add(this.lblEncoding);
            this.tabPageGeneral.Controls.Add(this.cboEncodingType);
            this.tabPageGeneral.Controls.Add(this.serverTimeoutNumericUpDown);
            this.tabPageGeneral.Controls.Add(this.lblServerTimeout);
            this.tabPageGeneral.Controls.Add(this.treeViewNumericUpDown);
            this.tabPageGeneral.Controls.Add(this.lblTreeViewFontSize);
            this.tabPageGeneral.Controls.Add(this.logNumericUpDown);
            this.tabPageGeneral.Controls.Add(this.lblLogFontSize);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 34);
            this.tabPageGeneral.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPageGeneral.Size = new System.Drawing.Size(1160, 604);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "General";
            this.tabPageGeneral.Paint += new System.Windows.Forms.PaintEventHandler(this.tabPageGeneral_Paint);
            // 
            // lblSaveCheckpointsOnExit
            // 
            this.lblSaveCheckpointsOnExit.AutoSize = true;
            this.lblSaveCheckpointsOnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSaveCheckpointsOnExit.Location = new System.Drawing.Point(32, 408);
            this.lblSaveCheckpointsOnExit.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSaveCheckpointsOnExit.Name = "lblSaveCheckpointsOnExit";
            this.lblSaveCheckpointsOnExit.Size = new System.Drawing.Size(455, 25);
            this.lblSaveCheckpointsOnExit.TabIndex = 51;
            this.lblSaveCheckpointsOnExit.Text = "Save Event Hub Partition Checkpoints on Exit:";
            // 
            // saveCheckpointsToFileCheckBox
            // 
            this.saveCheckpointsToFileCheckBox.AutoSize = true;
            this.saveCheckpointsToFileCheckBox.Checked = true;
            this.saveCheckpointsToFileCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveCheckpointsToFileCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveCheckpointsToFileCheckBox.Location = new System.Drawing.Point(520, 408);
            this.saveCheckpointsToFileCheckBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.saveCheckpointsToFileCheckBox.Name = "saveCheckpointsToFileCheckBox";
            this.saveCheckpointsToFileCheckBox.Size = new System.Drawing.Size(28, 27);
            this.saveCheckpointsToFileCheckBox.TabIndex = 52;
            this.saveCheckpointsToFileCheckBox.UseVisualStyleBackColor = true;
            this.saveCheckpointsToFileCheckBox.CheckedChanged += new System.EventHandler(this.saveCheckpointsToFileCheckBox_CheckedChanged);
            // 
            // cboSelectedEntities
            // 
            checkBoxProperties1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboSelectedEntities.CheckBoxProperties = checkBoxProperties1;
            this.cboSelectedEntities.DisplayMemberSingleItem = "";
            this.cboSelectedEntities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectedEntities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSelectedEntities.FormattingEnabled = true;
            this.cboSelectedEntities.Location = new System.Drawing.Point(270, 669);
            this.cboSelectedEntities.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboSelectedEntities.Name = "cboSelectedEntities";
            this.cboSelectedEntities.Size = new System.Drawing.Size(716, 33);
            this.cboSelectedEntities.TabIndex = 50;
            // 
            // lblSelectedEntities
            // 
            this.lblSelectedEntities.AutoSize = true;
            this.lblSelectedEntities.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSelectedEntities.Location = new System.Drawing.Point(32, 529);
            this.lblSelectedEntities.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSelectedEntities.Name = "lblSelectedEntities";
            this.lblSelectedEntities.Size = new System.Drawing.Size(179, 25);
            this.lblSelectedEntities.TabIndex = 49;
            this.lblSelectedEntities.Text = "Selected Entities:";
            // 
            // monitorRefreshIntervalNumericUpDown
            // 
            this.monitorRefreshIntervalNumericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.monitorRefreshIntervalNumericUpDown.Location = new System.Drawing.Point(520, 229);
            this.monitorRefreshIntervalNumericUpDown.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.monitorRefreshIntervalNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.monitorRefreshIntervalNumericUpDown.Name = "monitorRefreshIntervalNumericUpDown";
            this.monitorRefreshIntervalNumericUpDown.Size = new System.Drawing.Size(160, 31);
            this.monitorRefreshIntervalNumericUpDown.TabIndex = 46;
            this.monitorRefreshIntervalNumericUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.monitorRefreshIntervalNumericUpDown.ValueChanged += new System.EventHandler(this.monitorRefreshIntervalNumericUpDown_ValueChanged);
            // 
            // lblMonitorRefreshInterval
            // 
            this.lblMonitorRefreshInterval.AutoSize = true;
            this.lblMonitorRefreshInterval.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMonitorRefreshInterval.Location = new System.Drawing.Point(32, 229);
            this.lblMonitorRefreshInterval.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMonitorRefreshInterval.Name = "lblMonitorRefreshInterval";
            this.lblMonitorRefreshInterval.Size = new System.Drawing.Size(348, 25);
            this.lblMonitorRefreshInterval.TabIndex = 45;
            this.lblMonitorRefreshInterval.Text = "Monitor Refresh Interval (seconds):";
            // 
            // useAsciiCheckBox
            // 
            this.useAsciiCheckBox.AutoSize = true;
            this.useAsciiCheckBox.Checked = true;
            this.useAsciiCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useAsciiCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.useAsciiCheckBox.Location = new System.Drawing.Point(520, 288);
            this.useAsciiCheckBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.useAsciiCheckBox.Name = "useAsciiCheckBox";
            this.useAsciiCheckBox.Size = new System.Drawing.Size(28, 27);
            this.useAsciiCheckBox.TabIndex = 40;
            this.useAsciiCheckBox.UseVisualStyleBackColor = true;
            this.useAsciiCheckBox.CheckedChanged += new System.EventHandler(this.useAscii_CheckedChanged);
            // 
            // lblUseAscii
            // 
            this.lblUseAscii.AutoSize = true;
            this.lblUseAscii.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUseAscii.Location = new System.Drawing.Point(32, 288);
            this.lblUseAscii.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUseAscii.Name = "lblUseAscii";
            this.lblUseAscii.Size = new System.Drawing.Size(115, 25);
            this.lblUseAscii.TabIndex = 39;
            this.lblUseAscii.Text = "Use ASCII:";
            // 
            // lblShowMessageCount
            // 
            this.lblShowMessageCount.AutoSize = true;
            this.lblShowMessageCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblShowMessageCount.Location = new System.Drawing.Point(32, 348);
            this.lblShowMessageCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblShowMessageCount.Name = "lblShowMessageCount";
            this.lblShowMessageCount.Size = new System.Drawing.Size(228, 25);
            this.lblShowMessageCount.TabIndex = 43;
            this.lblShowMessageCount.Text = "Show Message Count:";
            // 
            // showMessageCountCheckBox
            // 
            this.showMessageCountCheckBox.AutoSize = true;
            this.showMessageCountCheckBox.Checked = true;
            this.showMessageCountCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showMessageCountCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.showMessageCountCheckBox.Location = new System.Drawing.Point(520, 348);
            this.showMessageCountCheckBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.showMessageCountCheckBox.Name = "showMessageCountCheckBox";
            this.showMessageCountCheckBox.Size = new System.Drawing.Size(28, 27);
            this.showMessageCountCheckBox.TabIndex = 44;
            this.showMessageCountCheckBox.UseVisualStyleBackColor = true;
            this.showMessageCountCheckBox.CheckedChanged += new System.EventHandler(this.showMessageCountCheckBox_CheckedChanged);
            // 
            // lblEncoding
            // 
            this.lblEncoding.AutoSize = true;
            this.lblEncoding.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEncoding.Location = new System.Drawing.Point(32, 467);
            this.lblEncoding.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEncoding.Name = "lblEncoding";
            this.lblEncoding.Size = new System.Drawing.Size(108, 25);
            this.lblEncoding.TabIndex = 41;
            this.lblEncoding.Text = "Encoding:";
            // 
            // cboEncodingType
            // 
            this.cboEncodingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEncodingType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEncodingType.FormattingEnabled = true;
            this.cboEncodingType.Items.AddRange(new object[] {
            "ASCII",
            "UTF7",
            "UTF8",
            "UTF32",
            "Unicode"});
            this.cboEncodingType.Location = new System.Drawing.Point(520, 467);
            this.cboEncodingType.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboEncodingType.Name = "cboEncodingType";
            this.cboEncodingType.Size = new System.Drawing.Size(592, 33);
            this.cboEncodingType.TabIndex = 42;
            this.cboEncodingType.SelectedIndexChanged += new System.EventHandler(this.cboEncoding_SelectedIndexChanged);
            // 
            // serverTimeoutNumericUpDown
            // 
            this.serverTimeoutNumericUpDown.Location = new System.Drawing.Point(520, 167);
            this.serverTimeoutNumericUpDown.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.serverTimeoutNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.serverTimeoutNumericUpDown.Name = "serverTimeoutNumericUpDown";
            this.serverTimeoutNumericUpDown.Size = new System.Drawing.Size(160, 31);
            this.serverTimeoutNumericUpDown.TabIndex = 38;
            this.serverTimeoutNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.serverTimeoutNumericUpDown.ValueChanged += new System.EventHandler(this.sessionTimeoutNumericUpDown_ValueChanged);
            // 
            // lblServerTimeout
            // 
            this.lblServerTimeout.AutoSize = true;
            this.lblServerTimeout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblServerTimeout.Location = new System.Drawing.Point(32, 167);
            this.lblServerTimeout.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblServerTimeout.Name = "lblServerTimeout";
            this.lblServerTimeout.Size = new System.Drawing.Size(265, 25);
            this.lblServerTimeout.TabIndex = 37;
            this.lblServerTimeout.Text = "Server Timeout (seconds):";
            // 
            // treeViewNumericUpDown
            // 
            this.treeViewNumericUpDown.DecimalPlaces = 2;
            this.treeViewNumericUpDown.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.treeViewNumericUpDown.Location = new System.Drawing.Point(520, 108);
            this.treeViewNumericUpDown.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.treeViewNumericUpDown.Name = "treeViewNumericUpDown";
            this.treeViewNumericUpDown.Size = new System.Drawing.Size(160, 31);
            this.treeViewNumericUpDown.TabIndex = 36;
            this.treeViewNumericUpDown.ValueChanged += new System.EventHandler(this.treeViewNumericUpDown_ValueChanged);
            // 
            // lblTreeViewFontSize
            // 
            this.lblTreeViewFontSize.AutoSize = true;
            this.lblTreeViewFontSize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTreeViewFontSize.Location = new System.Drawing.Point(32, 108);
            this.lblTreeViewFontSize.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTreeViewFontSize.Name = "lblTreeViewFontSize";
            this.lblTreeViewFontSize.Size = new System.Drawing.Size(211, 25);
            this.lblTreeViewFontSize.TabIndex = 35;
            this.lblTreeViewFontSize.Text = "Tree View Font Size:";
            // 
            // logNumericUpDown
            // 
            this.logNumericUpDown.DecimalPlaces = 2;
            this.logNumericUpDown.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.logNumericUpDown.Location = new System.Drawing.Point(520, 48);
            this.logNumericUpDown.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.logNumericUpDown.Name = "logNumericUpDown";
            this.logNumericUpDown.Size = new System.Drawing.Size(160, 31);
            this.logNumericUpDown.TabIndex = 34;
            this.logNumericUpDown.ValueChanged += new System.EventHandler(this.logNumericUpDown_ValueChanged);
            // 
            // lblLogFontSize
            // 
            this.lblLogFontSize.AutoSize = true;
            this.lblLogFontSize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLogFontSize.Location = new System.Drawing.Point(32, 48);
            this.lblLogFontSize.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLogFontSize.Name = "lblLogFontSize";
            this.lblLogFontSize.Size = new System.Drawing.Size(151, 25);
            this.lblLogFontSize.TabIndex = 33;
            this.lblLogFontSize.Text = "Log Font Size:";
            // 
            // tabPageReceiving
            // 
            this.tabPageReceiving.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.tabPageReceiving.Controls.Add(this.receiverThinkTimeNumericUpDown);
            this.tabPageReceiving.Controls.Add(this.lblReceiverThinkTime);
            this.tabPageReceiving.Controls.Add(this.prefetchCountNumericUpDown);
            this.tabPageReceiving.Controls.Add(this.lblPrefetchCount);
            this.tabPageReceiving.Controls.Add(this.receiveTimeoutNumericUpDown);
            this.tabPageReceiving.Controls.Add(this.lblReceiveTimeout);
            this.tabPageReceiving.Controls.Add(this.topNumericUpDown);
            this.tabPageReceiving.Controls.Add(this.lblTop);
            this.tabPageReceiving.Controls.Add(this.retryTimeoutNumericUpDown);
            this.tabPageReceiving.Controls.Add(this.lblRetryTimeout);
            this.tabPageReceiving.Controls.Add(this.retryCountNumericUpDown);
            this.tabPageReceiving.Controls.Add(this.lblRetryCount);
            this.tabPageReceiving.Location = new System.Drawing.Point(4, 34);
            this.tabPageReceiving.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPageReceiving.Name = "tabPageReceiving";
            this.tabPageReceiving.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPageReceiving.Size = new System.Drawing.Size(1160, 604);
            this.tabPageReceiving.TabIndex = 1;
            this.tabPageReceiving.Text = "Receiving";
            // 
            // receiverThinkTimeNumericUpDown
            // 
            this.receiverThinkTimeNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.receiverThinkTimeNumericUpDown.Location = new System.Drawing.Point(520, 344);
            this.receiverThinkTimeNumericUpDown.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.receiverThinkTimeNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.receiverThinkTimeNumericUpDown.Name = "receiverThinkTimeNumericUpDown";
            this.receiverThinkTimeNumericUpDown.Size = new System.Drawing.Size(160, 31);
            this.receiverThinkTimeNumericUpDown.TabIndex = 34;
            this.receiverThinkTimeNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.receiverThinkTimeNumericUpDown.ValueChanged += new System.EventHandler(this.receiverThinkTimeNumericUpDown_ValueChanged);
            // 
            // lblReceiverThinkTime
            // 
            this.lblReceiverThinkTime.AutoSize = true;
            this.lblReceiverThinkTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblReceiverThinkTime.Location = new System.Drawing.Point(32, 344);
            this.lblReceiverThinkTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblReceiverThinkTime.Name = "lblReceiverThinkTime";
            this.lblReceiverThinkTime.Size = new System.Drawing.Size(353, 25);
            this.lblReceiverThinkTime.TabIndex = 33;
            this.lblReceiverThinkTime.Text = "Receiver Think Time (milliseconds):";
            // 
            // prefetchCountNumericUpDown
            // 
            this.prefetchCountNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.prefetchCountNumericUpDown.Location = new System.Drawing.Point(520, 229);
            this.prefetchCountNumericUpDown.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.prefetchCountNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.prefetchCountNumericUpDown.Name = "prefetchCountNumericUpDown";
            this.prefetchCountNumericUpDown.Size = new System.Drawing.Size(160, 31);
            this.prefetchCountNumericUpDown.TabIndex = 28;
            this.prefetchCountNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.prefetchCountNumericUpDown.ValueChanged += new System.EventHandler(this.prefetchCountNumericUpDown_ValueChanged);
            // 
            // lblPrefetchCount
            // 
            this.lblPrefetchCount.AutoSize = true;
            this.lblPrefetchCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrefetchCount.Location = new System.Drawing.Point(32, 229);
            this.lblPrefetchCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPrefetchCount.Name = "lblPrefetchCount";
            this.lblPrefetchCount.Size = new System.Drawing.Size(161, 25);
            this.lblPrefetchCount.TabIndex = 27;
            this.lblPrefetchCount.Text = "Prefetch Count:";
            // 
            // receiveTimeoutNumericUpDown
            // 
            this.receiveTimeoutNumericUpDown.Location = new System.Drawing.Point(520, 48);
            this.receiveTimeoutNumericUpDown.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.receiveTimeoutNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.receiveTimeoutNumericUpDown.Name = "receiveTimeoutNumericUpDown";
            this.receiveTimeoutNumericUpDown.Size = new System.Drawing.Size(160, 31);
            this.receiveTimeoutNumericUpDown.TabIndex = 24;
            this.receiveTimeoutNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.receiveTimeoutNumericUpDown.ValueChanged += new System.EventHandler(this.receiveTimeoutNumericUpDown_ValueChanged);
            // 
            // lblReceiveTimeout
            // 
            this.lblReceiveTimeout.AutoSize = true;
            this.lblReceiveTimeout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblReceiveTimeout.Location = new System.Drawing.Point(32, 48);
            this.lblReceiveTimeout.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblReceiveTimeout.Name = "lblReceiveTimeout";
            this.lblReceiveTimeout.Size = new System.Drawing.Size(280, 25);
            this.lblReceiveTimeout.TabIndex = 23;
            this.lblReceiveTimeout.Text = "Receive Timeout (seconds):";
            // 
            // topNumericUpDown
            // 
            this.topNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.topNumericUpDown.Location = new System.Drawing.Point(520, 288);
            this.topNumericUpDown.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.topNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.topNumericUpDown.Name = "topNumericUpDown";
            this.topNumericUpDown.Size = new System.Drawing.Size(160, 31);
            this.topNumericUpDown.TabIndex = 32;
            this.topNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.topNumericUpDown.ValueChanged += new System.EventHandler(this.topNumericUpDown_ValueChanged);
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTop.Location = new System.Drawing.Point(32, 288);
            this.lblTop.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(118, 25);
            this.lblTop.TabIndex = 31;
            this.lblTop.Text = "Top Count:";
            // 
            // retryTimeoutNumericUpDown
            // 
            this.retryTimeoutNumericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.retryTimeoutNumericUpDown.Location = new System.Drawing.Point(520, 167);
            this.retryTimeoutNumericUpDown.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.retryTimeoutNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.retryTimeoutNumericUpDown.Name = "retryTimeoutNumericUpDown";
            this.retryTimeoutNumericUpDown.Size = new System.Drawing.Size(160, 31);
            this.retryTimeoutNumericUpDown.TabIndex = 30;
            this.retryTimeoutNumericUpDown.ValueChanged += new System.EventHandler(this.retryTimeoutNumericUpDown_ValueChanged);
            // 
            // lblRetryTimeout
            // 
            this.lblRetryTimeout.AutoSize = true;
            this.lblRetryTimeout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRetryTimeout.Location = new System.Drawing.Point(32, 167);
            this.lblRetryTimeout.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRetryTimeout.Name = "lblRetryTimeout";
            this.lblRetryTimeout.Size = new System.Drawing.Size(290, 25);
            this.lblRetryTimeout.TabIndex = 29;
            this.lblRetryTimeout.Text = "Retry Timeout (milliseconds):";
            // 
            // retryCountNumericUpDown
            // 
            this.retryCountNumericUpDown.Location = new System.Drawing.Point(520, 108);
            this.retryCountNumericUpDown.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.retryCountNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.retryCountNumericUpDown.Name = "retryCountNumericUpDown";
            this.retryCountNumericUpDown.Size = new System.Drawing.Size(160, 31);
            this.retryCountNumericUpDown.TabIndex = 26;
            this.retryCountNumericUpDown.ValueChanged += new System.EventHandler(this.retryCountNumericUpDown_ValueChanged);
            // 
            // lblRetryCount
            // 
            this.lblRetryCount.AutoSize = true;
            this.lblRetryCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRetryCount.Location = new System.Drawing.Point(32, 108);
            this.lblRetryCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRetryCount.Name = "lblRetryCount";
            this.lblRetryCount.Size = new System.Drawing.Size(132, 25);
            this.lblRetryCount.TabIndex = 25;
            this.lblRetryCount.Text = "Retry Count:";
            // 
            // tabPageSending
            // 
            this.tabPageSending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.tabPageSending.Controls.Add(this.saveMessageToFileCheckBox);
            this.tabPageSending.Controls.Add(this.lblMessageContentType);
            this.tabPageSending.Controls.Add(this.txtMessageContentType);
            this.tabPageSending.Controls.Add(this.cboDefaultMessageBodyType);
            this.tabPageSending.Controls.Add(this.LabelDefaultMessageBodyType);
            this.tabPageSending.Controls.Add(this.btnOpen);
            this.tabPageSending.Controls.Add(this.txtMessageFile);
            this.tabPageSending.Controls.Add(this.lblMessageFile);
            this.tabPageSending.Controls.Add(this.txtMessageText);
            this.tabPageSending.Controls.Add(this.lblMessageText);
            this.tabPageSending.Controls.Add(this.txtLabel);
            this.tabPageSending.Controls.Add(this.lblLabel);
            this.tabPageSending.Controls.Add(this.senderThinkTimeNumericUpDown);
            this.tabPageSending.Controls.Add(this.lblSenderThinkTime);
            this.tabPageSending.Controls.Add(this.lblSavePropertiesOnExit);
            this.tabPageSending.Controls.Add(this.lblSaveMessageOnExit);
            this.tabPageSending.Controls.Add(this.savePropertiesToFileCheckBox);
            this.tabPageSending.Location = new System.Drawing.Point(4, 34);
            this.tabPageSending.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPageSending.Name = "tabPageSending";
            this.tabPageSending.Size = new System.Drawing.Size(1160, 604);
            this.tabPageSending.TabIndex = 2;
            this.tabPageSending.Text = "Sending";
            this.tabPageSending.Paint += new System.Windows.Forms.PaintEventHandler(this.tabPageSending_Paint);
            // 
            // saveMessageToFileCheckBox
            // 
            this.saveMessageToFileCheckBox.AutoSize = true;
            this.saveMessageToFileCheckBox.Checked = true;
            this.saveMessageToFileCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveMessageToFileCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveMessageToFileCheckBox.Location = new System.Drawing.Point(520, 108);
            this.saveMessageToFileCheckBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.saveMessageToFileCheckBox.Name = "saveMessageToFileCheckBox";
            this.saveMessageToFileCheckBox.Size = new System.Drawing.Size(28, 27);
            this.saveMessageToFileCheckBox.TabIndex = 67;
            this.saveMessageToFileCheckBox.UseVisualStyleBackColor = true;
            this.saveMessageToFileCheckBox.CheckedChanged += new System.EventHandler(this.saveMessageToFileCheckBox_CheckedChanged);
            // 
            // lblMessageContentType
            // 
            this.lblMessageContentType.AutoSize = true;
            this.lblMessageContentType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMessageContentType.Location = new System.Drawing.Point(32, 467);
            this.lblMessageContentType.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMessageContentType.Name = "lblMessageContentType";
            this.lblMessageContentType.Size = new System.Drawing.Size(241, 25);
            this.lblMessageContentType.TabIndex = 63;
            this.lblMessageContentType.Text = "Message Content Type:";
            // 
            // txtMessageContentType
            // 
            this.txtMessageContentType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessageContentType.Location = new System.Drawing.Point(520, 467);
            this.txtMessageContentType.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMessageContentType.Name = "txtMessageContentType";
            this.txtMessageContentType.Size = new System.Drawing.Size(600, 31);
            this.txtMessageContentType.TabIndex = 64;
            this.txtMessageContentType.TextChanged += new System.EventHandler(this.txtMessageContentType_TextChanged);
            // 
            // cboDefaultMessageBodyType
            // 
            this.cboDefaultMessageBodyType.BackColor = System.Drawing.SystemColors.Window;
            this.cboDefaultMessageBodyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDefaultMessageBodyType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDefaultMessageBodyType.FormattingEnabled = true;
            this.cboDefaultMessageBodyType.Items.AddRange(new object[] {
            "Stream",
            "String",
            "WCF"});
            this.cboDefaultMessageBodyType.Location = new System.Drawing.Point(520, 529);
            this.cboDefaultMessageBodyType.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboDefaultMessageBodyType.Name = "cboDefaultMessageBodyType";
            this.cboDefaultMessageBodyType.Size = new System.Drawing.Size(600, 33);
            this.cboDefaultMessageBodyType.TabIndex = 66;
            this.cboDefaultMessageBodyType.SelectedIndexChanged += new System.EventHandler(this.cboDefaultMessageBodyType_SelectedIndexChanged);
            // 
            // LabelDefaultMessageBodyType
            // 
            this.LabelDefaultMessageBodyType.AutoSize = true;
            this.LabelDefaultMessageBodyType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelDefaultMessageBodyType.Location = new System.Drawing.Point(32, 529);
            this.LabelDefaultMessageBodyType.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelDefaultMessageBodyType.Name = "LabelDefaultMessageBodyType";
            this.LabelDefaultMessageBodyType.Size = new System.Drawing.Size(279, 25);
            this.LabelDefaultMessageBodyType.TabIndex = 65;
            this.LabelDefaultMessageBodyType.Text = "Default message body type:";
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.btnOpen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOpen.Location = new System.Drawing.Point(1074, 408);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(48, 40);
            this.btnOpen.TabIndex = 62;
            this.btnOpen.Text = "...";
            this.btnOpen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtMessageFile
            // 
            this.txtMessageFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessageFile.Location = new System.Drawing.Point(520, 348);
            this.txtMessageFile.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMessageFile.Name = "txtMessageFile";
            this.txtMessageFile.Size = new System.Drawing.Size(600, 31);
            this.txtMessageFile.TabIndex = 59;
            this.txtMessageFile.TextChanged += new System.EventHandler(this.txtMessageFile_TextChanged);
            // 
            // lblMessageFile
            // 
            this.lblMessageFile.AutoSize = true;
            this.lblMessageFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMessageFile.Location = new System.Drawing.Point(32, 348);
            this.lblMessageFile.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMessageFile.Name = "lblMessageFile";
            this.lblMessageFile.Size = new System.Drawing.Size(156, 25);
            this.lblMessageFile.TabIndex = 58;
            this.lblMessageFile.Text = "Message Path:";
            // 
            // txtMessageText
            // 
            this.txtMessageText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessageText.Location = new System.Drawing.Point(520, 408);
            this.txtMessageText.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMessageText.Name = "txtMessageText";
            this.txtMessageText.Size = new System.Drawing.Size(528, 31);
            this.txtMessageText.TabIndex = 61;
            this.txtMessageText.TextChanged += new System.EventHandler(this.txtMessageText_TextChanged);
            // 
            // lblMessageText
            // 
            this.lblMessageText.AutoSize = true;
            this.lblMessageText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMessageText.Location = new System.Drawing.Point(32, 408);
            this.lblMessageText.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMessageText.Name = "lblMessageText";
            this.lblMessageText.Size = new System.Drawing.Size(154, 25);
            this.lblMessageText.TabIndex = 60;
            this.lblMessageText.Text = "Message Text:";
            // 
            // txtLabel
            // 
            this.txtLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLabel.Location = new System.Drawing.Point(520, 288);
            this.txtLabel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(600, 31);
            this.txtLabel.TabIndex = 57;
            this.txtLabel.TextChanged += new System.EventHandler(this.txtLabel_TextChanged);
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLabel.Location = new System.Drawing.Point(32, 288);
            this.lblLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(71, 25);
            this.lblLabel.TabIndex = 56;
            this.lblLabel.Text = "Label:";
            // 
            // senderThinkTimeNumericUpDown
            // 
            this.senderThinkTimeNumericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.senderThinkTimeNumericUpDown.Location = new System.Drawing.Point(520, 48);
            this.senderThinkTimeNumericUpDown.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.senderThinkTimeNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.senderThinkTimeNumericUpDown.Name = "senderThinkTimeNumericUpDown";
            this.senderThinkTimeNumericUpDown.Size = new System.Drawing.Size(160, 31);
            this.senderThinkTimeNumericUpDown.TabIndex = 52;
            this.senderThinkTimeNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.senderThinkTimeNumericUpDown.ValueChanged += new System.EventHandler(this.senderThinkTimeNumericUpDown_ValueChanged);
            // 
            // lblSenderThinkTime
            // 
            this.lblSenderThinkTime.AutoSize = true;
            this.lblSenderThinkTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSenderThinkTime.Location = new System.Drawing.Point(32, 48);
            this.lblSenderThinkTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSenderThinkTime.Name = "lblSenderThinkTime";
            this.lblSenderThinkTime.Size = new System.Drawing.Size(337, 25);
            this.lblSenderThinkTime.TabIndex = 51;
            this.lblSenderThinkTime.Text = "Sender Think Time (milliseconds):";
            // 
            // lblSavePropertiesOnExit
            // 
            this.lblSavePropertiesOnExit.AutoSize = true;
            this.lblSavePropertiesOnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSavePropertiesOnExit.Location = new System.Drawing.Point(32, 167);
            this.lblSavePropertiesOnExit.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSavePropertiesOnExit.Name = "lblSavePropertiesOnExit";
            this.lblSavePropertiesOnExit.Size = new System.Drawing.Size(402, 25);
            this.lblSavePropertiesOnExit.TabIndex = 54;
            this.lblSavePropertiesOnExit.Text = "Save Message Properties to File on Exit:";
            // 
            // lblSaveMessageOnExit
            // 
            this.lblSaveMessageOnExit.AutoSize = true;
            this.lblSaveMessageOnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSaveMessageOnExit.Location = new System.Drawing.Point(32, 108);
            this.lblSaveMessageOnExit.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSaveMessageOnExit.Name = "lblSaveMessageOnExit";
            this.lblSaveMessageOnExit.Size = new System.Drawing.Size(353, 25);
            this.lblSaveMessageOnExit.TabIndex = 53;
            this.lblSaveMessageOnExit.Text = "Save Message Body to File on Exit:";
            // 
            // savePropertiesToFileCheckBox
            // 
            this.savePropertiesToFileCheckBox.AutoSize = true;
            this.savePropertiesToFileCheckBox.Checked = true;
            this.savePropertiesToFileCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.savePropertiesToFileCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.savePropertiesToFileCheckBox.Location = new System.Drawing.Point(520, 167);
            this.savePropertiesToFileCheckBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.savePropertiesToFileCheckBox.Name = "savePropertiesToFileCheckBox";
            this.savePropertiesToFileCheckBox.Size = new System.Drawing.Size(28, 27);
            this.savePropertiesToFileCheckBox.TabIndex = 55;
            this.savePropertiesToFileCheckBox.UseVisualStyleBackColor = true;
            this.savePropertiesToFileCheckBox.CheckedChanged += new System.EventHandler(this.savePropertiesToFileCheckBox_CheckedChanged);
            // 
            // tabPageConnectivity
            // 
            this.tabPageConnectivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.tabPageConnectivity.Controls.Add(this.useAmqpWebSocketsCheckBox);
            this.tabPageConnectivity.Controls.Add(this.label4);
            this.tabPageConnectivity.Controls.Add(this.cboConnectivityMode);
            this.tabPageConnectivity.Controls.Add(this.lblConnectivityMode);
            this.tabPageConnectivity.Location = new System.Drawing.Point(4, 34);
            this.tabPageConnectivity.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPageConnectivity.Name = "tabPageConnectivity";
            this.tabPageConnectivity.Size = new System.Drawing.Size(1160, 604);
            this.tabPageConnectivity.TabIndex = 3;
            this.tabPageConnectivity.Text = "Connectivity";
            this.tabPageConnectivity.Paint += new System.Windows.Forms.PaintEventHandler(this.tabPageConnectivity_Paint);
            // 
            // useAmqpWebSocketsCheckBox
            // 
            this.useAmqpWebSocketsCheckBox.AutoSize = true;
            this.useAmqpWebSocketsCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.useAmqpWebSocketsCheckBox.Location = new System.Drawing.Point(768, 108);
            this.useAmqpWebSocketsCheckBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.useAmqpWebSocketsCheckBox.Name = "useAmqpWebSocketsCheckBox";
            this.useAmqpWebSocketsCheckBox.Size = new System.Drawing.Size(28, 27);
            this.useAmqpWebSocketsCheckBox.TabIndex = 68;
            this.useAmqpWebSocketsCheckBox.UseVisualStyleBackColor = true;
            this.useAmqpWebSocketsCheckBox.CheckedChanged += new System.EventHandler(this.useAmqpWebSocketsCheckBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(32, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(697, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Use AMQP Web Sockets for Microsoft.Azure.ServiceBus.dll (new client)";
            // 
            // cboConnectivityMode
            // 
            this.cboConnectivityMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConnectivityMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboConnectivityMode.FormattingEnabled = true;
            this.cboConnectivityMode.Location = new System.Drawing.Point(768, 48);
            this.cboConnectivityMode.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboConnectivityMode.Name = "cboConnectivityMode";
            this.cboConnectivityMode.Size = new System.Drawing.Size(364, 33);
            this.cboConnectivityMode.TabIndex = 28;
            this.cboConnectivityMode.SelectedIndexChanged += new System.EventHandler(this.cboConnectivityMode_SelectedIndexChanged);
            // 
            // lblConnectivityMode
            // 
            this.lblConnectivityMode.AutoSize = true;
            this.lblConnectivityMode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblConnectivityMode.Location = new System.Drawing.Point(32, 48);
            this.lblConnectivityMode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblConnectivityMode.Name = "lblConnectivityMode";
            this.lblConnectivityMode.Size = new System.Drawing.Size(619, 25);
            this.lblConnectivityMode.TabIndex = 27;
            this.lblConnectivityMode.Text = "Connectivity Mode for WindowsAzure.ServiceBus.dll (old client)";
            // 
            // tabPageProxy
            // 
            this.tabPageProxy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.tabPageProxy.Controls.Add(this.txtProxyPassword);
            this.tabPageProxy.Controls.Add(this.useDefaultProxyCredentialsCheckBox);
            this.tabPageProxy.Controls.Add(this.lblProxyPassword);
            this.tabPageProxy.Controls.Add(this.lblProxyDefaultCredentials);
            this.tabPageProxy.Controls.Add(this.txtProxyUserName);
            this.tabPageProxy.Controls.Add(this.lblProxyUser);
            this.tabPageProxy.Controls.Add(this.bypassProxyOnLocalAddressesCheckBox);
            this.tabPageProxy.Controls.Add(this.lblBypassProxyOnLocalAddresses);
            this.tabPageProxy.Controls.Add(this.txtProxyBypassList);
            this.tabPageProxy.Controls.Add(this.lblProxyBypass);
            this.tabPageProxy.Controls.Add(this.overrideDefaultProxyCheckBox);
            this.tabPageProxy.Controls.Add(this.lblOverrideProxy);
            this.tabPageProxy.Controls.Add(this.txtProxyAddress);
            this.tabPageProxy.Controls.Add(this.lblProxyAddress);
            this.tabPageProxy.Location = new System.Drawing.Point(4, 34);
            this.tabPageProxy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageProxy.Name = "tabPageProxy";
            this.tabPageProxy.Size = new System.Drawing.Size(1160, 604);
            this.tabPageProxy.TabIndex = 4;
            this.tabPageProxy.Text = "Proxy";
            // 
            // txtProxyPassword
            // 
            this.txtProxyPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProxyPassword.Location = new System.Drawing.Point(520, 408);
            this.txtProxyPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProxyPassword.Name = "txtProxyPassword";
            this.txtProxyPassword.Size = new System.Drawing.Size(600, 31);
            this.txtProxyPassword.TabIndex = 7;
            this.txtProxyPassword.UseSystemPasswordChar = true;
            this.txtProxyPassword.TextChanged += new System.EventHandler(this.txtProxyPassword_TextChanged);
            // 
            // useDefaultProxyCredentialsCheckBox
            // 
            this.useDefaultProxyCredentialsCheckBox.AutoSize = true;
            this.useDefaultProxyCredentialsCheckBox.Checked = true;
            this.useDefaultProxyCredentialsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useDefaultProxyCredentialsCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.useDefaultProxyCredentialsCheckBox.Location = new System.Drawing.Point(520, 288);
            this.useDefaultProxyCredentialsCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.useDefaultProxyCredentialsCheckBox.Name = "useDefaultProxyCredentialsCheckBox";
            this.useDefaultProxyCredentialsCheckBox.Size = new System.Drawing.Size(28, 27);
            this.useDefaultProxyCredentialsCheckBox.TabIndex = 5;
            this.useDefaultProxyCredentialsCheckBox.UseVisualStyleBackColor = true;
            this.useDefaultProxyCredentialsCheckBox.CheckedChanged += new System.EventHandler(this.useDefaultProxyCredentialsCheckBox_CheckedChanged);
            // 
            // lblProxyPassword
            // 
            this.lblProxyPassword.AutoSize = true;
            this.lblProxyPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProxyPassword.Location = new System.Drawing.Point(32, 408);
            this.lblProxyPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProxyPassword.Name = "lblProxyPassword";
            this.lblProxyPassword.Size = new System.Drawing.Size(112, 25);
            this.lblProxyPassword.TabIndex = 53;
            this.lblProxyPassword.Text = "Password:";
            // 
            // lblProxyDefaultCredentials
            // 
            this.lblProxyDefaultCredentials.AutoSize = true;
            this.lblProxyDefaultCredentials.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProxyDefaultCredentials.Location = new System.Drawing.Point(32, 288);
            this.lblProxyDefaultCredentials.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProxyDefaultCredentials.Name = "lblProxyDefaultCredentials";
            this.lblProxyDefaultCredentials.Size = new System.Drawing.Size(245, 25);
            this.lblProxyDefaultCredentials.TabIndex = 59;
            this.lblProxyDefaultCredentials.Text = "Use Default Credentials:";
            // 
            // txtProxyUserName
            // 
            this.txtProxyUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProxyUserName.Location = new System.Drawing.Point(520, 348);
            this.txtProxyUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProxyUserName.Name = "txtProxyUserName";
            this.txtProxyUserName.Size = new System.Drawing.Size(600, 31);
            this.txtProxyUserName.TabIndex = 6;
            this.txtProxyUserName.TextChanged += new System.EventHandler(this.txtProxyUser_TextChanged);
            // 
            // lblProxyUser
            // 
            this.lblProxyUser.AutoSize = true;
            this.lblProxyUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProxyUser.Location = new System.Drawing.Point(32, 348);
            this.lblProxyUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProxyUser.Name = "lblProxyUser";
            this.lblProxyUser.Size = new System.Drawing.Size(125, 25);
            this.lblProxyUser.TabIndex = 51;
            this.lblProxyUser.Text = "User Name:";
            // 
            // bypassProxyOnLocalAddressesCheckBox
            // 
            this.bypassProxyOnLocalAddressesCheckBox.AutoSize = true;
            this.bypassProxyOnLocalAddressesCheckBox.Checked = true;
            this.bypassProxyOnLocalAddressesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bypassProxyOnLocalAddressesCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bypassProxyOnLocalAddressesCheckBox.Location = new System.Drawing.Point(520, 228);
            this.bypassProxyOnLocalAddressesCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bypassProxyOnLocalAddressesCheckBox.Name = "bypassProxyOnLocalAddressesCheckBox";
            this.bypassProxyOnLocalAddressesCheckBox.Size = new System.Drawing.Size(28, 27);
            this.bypassProxyOnLocalAddressesCheckBox.TabIndex = 4;
            this.bypassProxyOnLocalAddressesCheckBox.UseVisualStyleBackColor = true;
            this.bypassProxyOnLocalAddressesCheckBox.CheckedChanged += new System.EventHandler(this.bypassProxyOnLocalAddressesCheckBox_CheckedChanged);
            // 
            // lblBypassProxyOnLocalAddresses
            // 
            this.lblBypassProxyOnLocalAddresses.AutoSize = true;
            this.lblBypassProxyOnLocalAddresses.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBypassProxyOnLocalAddresses.Location = new System.Drawing.Point(32, 228);
            this.lblBypassProxyOnLocalAddresses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBypassProxyOnLocalAddresses.Name = "lblBypassProxyOnLocalAddresses";
            this.lblBypassProxyOnLocalAddresses.Size = new System.Drawing.Size(338, 25);
            this.lblBypassProxyOnLocalAddresses.TabIndex = 57;
            this.lblBypassProxyOnLocalAddresses.Text = "Bypass Proxy for local addresses:";
            // 
            // txtProxyBypassList
            // 
            this.txtProxyBypassList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProxyBypassList.Location = new System.Drawing.Point(520, 168);
            this.txtProxyBypassList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProxyBypassList.Name = "txtProxyBypassList";
            this.txtProxyBypassList.Size = new System.Drawing.Size(600, 31);
            this.txtProxyBypassList.TabIndex = 3;
            this.txtProxyBypassList.TextChanged += new System.EventHandler(this.txtProxyBypassList_TextChanged);
            // 
            // lblProxyBypass
            // 
            this.lblProxyBypass.AutoSize = true;
            this.lblProxyBypass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProxyBypass.Location = new System.Drawing.Point(32, 168);
            this.lblProxyBypass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProxyBypass.Name = "lblProxyBypass";
            this.lblProxyBypass.Size = new System.Drawing.Size(181, 25);
            this.lblProxyBypass.TabIndex = 55;
            this.lblProxyBypass.Text = "Bypass Proxy for:";
            // 
            // overrideDefaultProxyCheckBox
            // 
            this.overrideDefaultProxyCheckBox.AutoSize = true;
            this.overrideDefaultProxyCheckBox.Checked = true;
            this.overrideDefaultProxyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.overrideDefaultProxyCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.overrideDefaultProxyCheckBox.Location = new System.Drawing.Point(520, 48);
            this.overrideDefaultProxyCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.overrideDefaultProxyCheckBox.Name = "overrideDefaultProxyCheckBox";
            this.overrideDefaultProxyCheckBox.Size = new System.Drawing.Size(28, 27);
            this.overrideDefaultProxyCheckBox.TabIndex = 1;
            this.overrideDefaultProxyCheckBox.UseVisualStyleBackColor = true;
            this.overrideDefaultProxyCheckBox.CheckedChanged += new System.EventHandler(this.overrideDefaultProxyCheckBox_CheckedChanged);
            // 
            // lblOverrideProxy
            // 
            this.lblOverrideProxy.AutoSize = true;
            this.lblOverrideProxy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOverrideProxy.Location = new System.Drawing.Point(32, 48);
            this.lblOverrideProxy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOverrideProxy.Name = "lblOverrideProxy";
            this.lblOverrideProxy.Size = new System.Drawing.Size(339, 25);
            this.lblOverrideProxy.TabIndex = 54;
            this.lblOverrideProxy.Text = "Override system/app.config proxy:";
            // 
            // txtProxyAddress
            // 
            this.txtProxyAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProxyAddress.Location = new System.Drawing.Point(520, 108);
            this.txtProxyAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProxyAddress.Name = "txtProxyAddress";
            this.txtProxyAddress.Size = new System.Drawing.Size(600, 31);
            this.txtProxyAddress.TabIndex = 2;
            this.txtProxyAddress.TextChanged += new System.EventHandler(this.txtProxyAddress_TextChanged);
            // 
            // lblProxyAddress
            // 
            this.lblProxyAddress.AutoSize = true;
            this.lblProxyAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProxyAddress.Location = new System.Drawing.Point(32, 108);
            this.lblProxyAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProxyAddress.Name = "lblProxyAddress";
            this.lblProxyAddress.Size = new System.Drawing.Size(158, 25);
            this.lblProxyAddress.TabIndex = 52;
            this.lblProxyAddress.Text = "Proxy Address:";
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.mainPanel.Controls.Add(this.tabOptionsControl);
            this.mainPanel.Controls.Add(this.btnOpenConfig);
            this.mainPanel.Controls.Add(this.cboConfigFile);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1228, 723);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // OptionForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1230, 802);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OptionForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.tabOptionsControl.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monitorRefreshIntervalNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverTimeoutNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logNumericUpDown)).EndInit();
            this.tabPageReceiving.ResumeLayout(false);
            this.tabPageReceiving.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiverThinkTimeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prefetchCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiveTimeoutNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retryTimeoutNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retryCountNumericUpDown)).EndInit();
            this.tabPageSending.ResumeLayout(false);
            this.tabPageSending.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.senderThinkTimeNumericUpDown)).EndInit();
            this.tabPageConnectivity.ResumeLayout(false);
            this.tabPageConnectivity.PerformLayout();
            this.tabPageProxy.ResumeLayout(false);
            this.tabPageProxy.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboConfigFile;
        private System.Windows.Forms.Button btnOpenConfig;
        private System.Windows.Forms.TabControl tabOptionsControl;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.Label lblSaveCheckpointsOnExit;
        private System.Windows.Forms.CheckBox saveCheckpointsToFileCheckBox;
        private CheckBoxComboBox cboSelectedEntities;
        private System.Windows.Forms.Label lblSelectedEntities;
        private System.Windows.Forms.NumericUpDown monitorRefreshIntervalNumericUpDown;
        private System.Windows.Forms.Label lblMonitorRefreshInterval;
        private System.Windows.Forms.CheckBox useAsciiCheckBox;
        private System.Windows.Forms.Label lblUseAscii;
        private System.Windows.Forms.Label lblShowMessageCount;
        private System.Windows.Forms.CheckBox showMessageCountCheckBox;
        private System.Windows.Forms.Label lblEncoding;
        private System.Windows.Forms.ComboBox cboEncodingType;
        private System.Windows.Forms.NumericUpDown serverTimeoutNumericUpDown;
        private System.Windows.Forms.Label lblServerTimeout;
        private System.Windows.Forms.NumericUpDown treeViewNumericUpDown;
        private System.Windows.Forms.Label lblTreeViewFontSize;
        private System.Windows.Forms.NumericUpDown logNumericUpDown;
        private System.Windows.Forms.Label lblLogFontSize;
        private System.Windows.Forms.TabPage tabPageReceiving;
        private System.Windows.Forms.NumericUpDown receiverThinkTimeNumericUpDown;
        private System.Windows.Forms.Label lblReceiverThinkTime;
        private System.Windows.Forms.NumericUpDown prefetchCountNumericUpDown;
        private System.Windows.Forms.Label lblPrefetchCount;
        private System.Windows.Forms.NumericUpDown receiveTimeoutNumericUpDown;
        private System.Windows.Forms.Label lblReceiveTimeout;
        private System.Windows.Forms.NumericUpDown topNumericUpDown;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.NumericUpDown retryTimeoutNumericUpDown;
        private System.Windows.Forms.Label lblRetryTimeout;
        private System.Windows.Forms.NumericUpDown retryCountNumericUpDown;
        private System.Windows.Forms.Label lblRetryCount;
        private System.Windows.Forms.TabPage tabPageSending;
        private System.Windows.Forms.CheckBox saveMessageToFileCheckBox;
        private System.Windows.Forms.Label lblMessageContentType;
        private System.Windows.Forms.TextBox txtMessageContentType;
        private System.Windows.Forms.ComboBox cboDefaultMessageBodyType;
        private System.Windows.Forms.Label LabelDefaultMessageBodyType;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtMessageFile;
        private System.Windows.Forms.Label lblMessageFile;
        private System.Windows.Forms.TextBox txtMessageText;
        private System.Windows.Forms.Label lblMessageText;
        private System.Windows.Forms.TextBox txtLabel;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.NumericUpDown senderThinkTimeNumericUpDown;
        private System.Windows.Forms.Label lblSenderThinkTime;
        private System.Windows.Forms.Label lblSavePropertiesOnExit;
        private System.Windows.Forms.Label lblSaveMessageOnExit;
        private System.Windows.Forms.CheckBox savePropertiesToFileCheckBox;
        private System.Windows.Forms.TabPage tabPageConnectivity;
        private System.Windows.Forms.ComboBox cboConnectivityMode;
        private System.Windows.Forms.Label lblConnectivityMode;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.CheckBox useAmqpWebSocketsCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPageProxy;
        private System.Windows.Forms.TextBox txtProxyPassword;
        private System.Windows.Forms.CheckBox useDefaultProxyCredentialsCheckBox;
        private System.Windows.Forms.Label lblProxyPassword;
        private System.Windows.Forms.Label lblProxyDefaultCredentials;
        private System.Windows.Forms.TextBox txtProxyUserName;
        private System.Windows.Forms.Label lblProxyUser;
        private System.Windows.Forms.CheckBox bypassProxyOnLocalAddressesCheckBox;
        private System.Windows.Forms.Label lblBypassProxyOnLocalAddresses;
        private System.Windows.Forms.TextBox txtProxyBypassList;
        private System.Windows.Forms.Label lblProxyBypass;
        private System.Windows.Forms.CheckBox overrideDefaultProxyCheckBox;
        private System.Windows.Forms.Label lblOverrideProxy;
        private System.Windows.Forms.TextBox txtProxyAddress;
        private System.Windows.Forms.Label lblProxyAddress;
    }
}

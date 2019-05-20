﻿#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.Base.Code.Exceptions;
using ExtendedControls.Base.Code.IO;
using ExtendedControls.Base.Code.Security;
using System;
using System.Drawing;
using System.IO;
using System.Text;

namespace ExtendedControls.ExtendedToolkit.UI.Dialogues
{
    /// <summary>
    /// Displays the properties of a file or directory.
    /// </summary>
    /// <seealso cref="ComponentFactory.Krypton.Toolkit.KryptonForm" />
    public class KryptonFileInformationDialog : KryptonForm
    {
        #region Designer Code
        private KryptonButton kbtnOk;
        private KryptonButton kbtnCancel;
        private System.Windows.Forms.Panel pnlSplitter;
        private KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator kryptonNavigator1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage2;
        private KryptonGroupBox kryptonGroupBox2;
        private KryptonGroupBox kryptonGroupBox1;
        private System.Windows.Forms.PictureBox pbxFileIcon;
        private KryptonTextBox ktbFileName;
        private KryptonLabel klblAccessed;
        private KryptonLabel klblModified;
        private KryptonLabel klblCreated;
        private System.Windows.Forms.Panel panel3;
        private KryptonLabel klblSizeOnDisk;
        private KryptonLabel klblFileSize;
        private KryptonLabel klblFileLocation;
        private System.Windows.Forms.Panel panel2;
        private KryptonLabel klblFileType;
        private System.Windows.Forms.Panel panel1;
        private KryptonComboBox kcmbHashType1;
        private KryptonLabel klblTotalFiles;
        private KryptonLabel klblRealFileHash;
        private KryptonButton kbtnValidate;
        private KryptonTextBox ktxtValidate;
        private KryptonComboBox kcmbValidatedHashType;
        private KryptonLabel kryptonLabel9;
        private KryptonButton kbtnCalculateFileHash;
        private System.Windows.Forms.ProgressBar pbCalculateFileHash;
        private System.ComponentModel.BackgroundWorker bgwMD5;
        private System.ComponentModel.BackgroundWorker bgwSHA1;
        private System.ComponentModel.BackgroundWorker bgwSHA256;
        private System.ComponentModel.BackgroundWorker bgwSHA384;
        private System.ComponentModel.BackgroundWorker bgwSHA512;
        private System.ComponentModel.BackgroundWorker bgwRIPEMD160;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage3;
        private KryptonGroupBox kryptonGroupBox3;
        private KryptonCheckBox kryptonCheckBox5;
        private KryptonCheckBox kryptonCheckBox4;
        private KryptonCheckBox kryptonCheckBox3;
        private KryptonCheckBox kryptonCheckBox2;
        private KryptonCheckBox kryptonCheckBox1;
        private KryptonCheckBox kryptonCheckBox16;
        private KryptonCheckBox kryptonCheckBox15;
        private KryptonCheckBox kryptonCheckBox14;
        private KryptonCheckBox kryptonCheckBox13;
        private KryptonCheckBox kryptonCheckBox12;
        private KryptonCheckBox kryptonCheckBox11;
        private KryptonCheckBox kryptonCheckBox6;
        private KryptonCheckBox kryptonCheckBox7;
        private KryptonCheckBox kryptonCheckBox8;
        private KryptonCheckBox kryptonCheckBox9;
        private KryptonCheckBox kryptonCheckBox10;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KryptonFileInformationDialog));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pnlSplitter = new System.Windows.Forms.Panel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonNavigator1 = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.kryptonPage1 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.klblAccessed = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblModified = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblCreated = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.klblSizeOnDisk = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblFileSize = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblFileLocation = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.klblFileType = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ktbFileName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pbxFileIcon = new System.Windows.Forms.PictureBox();
            this.kryptonPage2 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kbtnValidate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ktxtValidate = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kcmbValidatedHashType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.pbCalculateFileHash = new System.Windows.Forms.ProgressBar();
            this.kbtnCalculateFileHash = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.klblRealFileHash = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kcmbHashType1 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.klblTotalFiles = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.bgwMD5 = new System.ComponentModel.BackgroundWorker();
            this.bgwSHA1 = new System.ComponentModel.BackgroundWorker();
            this.bgwSHA256 = new System.ComponentModel.BackgroundWorker();
            this.bgwSHA384 = new System.ComponentModel.BackgroundWorker();
            this.bgwSHA512 = new System.ComponentModel.BackgroundWorker();
            this.bgwRIPEMD160 = new System.ComponentModel.BackgroundWorker();
            this.kryptonPage3 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonGroupBox3 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonCheckBox1 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonCheckBox2 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonCheckBox3 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonCheckBox4 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonCheckBox5 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonCheckBox6 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonCheckBox7 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonCheckBox8 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonCheckBox9 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonCheckBox10 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonCheckBox11 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonCheckBox12 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonCheckBox13 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonCheckBox14 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonCheckBox15 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonCheckBox16 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).BeginInit();
            this.kryptonNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            this.kryptonPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFileIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).BeginInit();
            this.kryptonPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbValidatedHashType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbHashType1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage3)).BeginInit();
            this.kryptonPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3.Panel)).BeginInit();
            this.kryptonGroupBox3.Panel.SuspendLayout();
            this.kryptonGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnOk);
            this.kryptonPanel1.Controls.Add(this.kbtnCancel);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 694);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(716, 50);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kbtnOk
            // 
            this.kbtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.kbtnOk.Location = new System.Drawing.Point(511, 9);
            this.kbtnOk.Name = "kbtnOk";
            this.kbtnOk.Size = new System.Drawing.Size(70, 29);
            this.kbtnOk.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.TabIndex = 15;
            this.kbtnOk.Values.Text = "O&k";
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnCancel.Location = new System.Drawing.Point(587, 9);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(117, 29);
            this.kbtnCancel.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 14;
            this.kbtnCancel.Values.Text = "&Cancel";
            // 
            // pnlSplitter
            // 
            this.pnlSplitter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlSplitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSplitter.Location = new System.Drawing.Point(0, 693);
            this.pnlSplitter.Name = "pnlSplitter";
            this.pnlSplitter.Size = new System.Drawing.Size(716, 1);
            this.pnlSplitter.TabIndex = 3;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonNavigator1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(716, 693);
            this.kryptonPanel2.TabIndex = 4;
            // 
            // kryptonNavigator1
            // 
            this.kryptonNavigator1.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.NextPrevious;
            this.kryptonNavigator1.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.kryptonNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.kryptonNavigator1.Location = new System.Drawing.Point(12, 12);
            this.kryptonNavigator1.Name = "kryptonNavigator1";
            this.kryptonNavigator1.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.kryptonPage1,
            this.kryptonPage2,
            this.kryptonPage3});
            this.kryptonNavigator1.SelectedIndex = 2;
            this.kryptonNavigator1.Size = new System.Drawing.Size(692, 675);
            this.kryptonNavigator1.StateCommon.Tab.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonNavigator1.StateCommon.Tab.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonNavigator1.TabIndex = 0;
            this.kryptonNavigator1.Text = "kryptonNavigator1";
            // 
            // kryptonPage1
            // 
            this.kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage1.Controls.Add(this.klblAccessed);
            this.kryptonPage1.Controls.Add(this.klblModified);
            this.kryptonPage1.Controls.Add(this.klblCreated);
            this.kryptonPage1.Controls.Add(this.panel3);
            this.kryptonPage1.Controls.Add(this.klblSizeOnDisk);
            this.kryptonPage1.Controls.Add(this.klblFileSize);
            this.kryptonPage1.Controls.Add(this.klblFileLocation);
            this.kryptonPage1.Controls.Add(this.panel2);
            this.kryptonPage1.Controls.Add(this.klblFileType);
            this.kryptonPage1.Controls.Add(this.panel1);
            this.kryptonPage1.Controls.Add(this.ktbFileName);
            this.kryptonPage1.Controls.Add(this.pbxFileIcon);
            this.kryptonPage1.Flags = 65534;
            this.kryptonPage1.LastVisibleSet = true;
            this.kryptonPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.Size = new System.Drawing.Size(690, 644);
            this.kryptonPage1.Text = "General";
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "c8e6d019e3df414d87a48f82aaa4b1e9";
            // 
            // klblAccessed
            // 
            this.klblAccessed.Location = new System.Drawing.Point(20, 461);
            this.klblAccessed.Name = "klblAccessed";
            this.klblAccessed.Size = new System.Drawing.Size(99, 24);
            this.klblAccessed.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblAccessed.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblAccessed.TabIndex = 10;
            this.klblAccessed.Values.Text = "Accessed: {0}";
            // 
            // klblModified
            // 
            this.klblModified.Location = new System.Drawing.Point(20, 410);
            this.klblModified.Name = "klblModified";
            this.klblModified.Size = new System.Drawing.Size(98, 24);
            this.klblModified.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblModified.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblModified.TabIndex = 9;
            this.klblModified.Values.Text = "Modified: {0}";
            // 
            // klblCreated
            // 
            this.klblCreated.Location = new System.Drawing.Point(20, 359);
            this.klblCreated.Name = "klblCreated";
            this.klblCreated.Size = new System.Drawing.Size(90, 24);
            this.klblCreated.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblCreated.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblCreated.TabIndex = 8;
            this.klblCreated.Values.Text = "Created: {0}";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Location = new System.Drawing.Point(20, 336);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(651, 1);
            this.panel3.TabIndex = 5;
            // 
            // klblSizeOnDisk
            // 
            this.klblSizeOnDisk.Location = new System.Drawing.Point(20, 284);
            this.klblSizeOnDisk.Name = "klblSizeOnDisk";
            this.klblSizeOnDisk.Size = new System.Drawing.Size(117, 24);
            this.klblSizeOnDisk.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblSizeOnDisk.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblSizeOnDisk.TabIndex = 7;
            this.klblSizeOnDisk.Values.Text = "Size on disk: {0}";
            // 
            // klblFileSize
            // 
            this.klblFileSize.Location = new System.Drawing.Point(20, 233);
            this.klblFileSize.Name = "klblFileSize";
            this.klblFileSize.Size = new System.Drawing.Size(64, 24);
            this.klblFileSize.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblFileSize.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblFileSize.TabIndex = 6;
            this.klblFileSize.Values.Text = "Size: {0}";
            // 
            // klblFileLocation
            // 
            this.klblFileLocation.Location = new System.Drawing.Point(20, 182);
            this.klblFileLocation.Name = "klblFileLocation";
            this.klblFileLocation.Size = new System.Drawing.Size(95, 24);
            this.klblFileLocation.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblFileLocation.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblFileLocation.TabIndex = 5;
            this.klblFileLocation.Values.Text = "Location: {0}";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(20, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 1);
            this.panel2.TabIndex = 4;
            // 
            // klblFileType
            // 
            this.klblFileType.Location = new System.Drawing.Point(20, 107);
            this.klblFileType.Name = "klblFileType";
            this.klblFileType.Size = new System.Drawing.Size(112, 24);
            this.klblFileType.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblFileType.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblFileType.TabIndex = 3;
            this.klblFileType.Values.Text = "Type of file: {0}";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(20, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 1);
            this.panel1.TabIndex = 2;
            // 
            // ktbFileName
            // 
            this.ktbFileName.Hint = "Filename.*.*";
            this.ktbFileName.Location = new System.Drawing.Point(91, 31);
            this.ktbFileName.Name = "ktbFileName";
            this.ktbFileName.Size = new System.Drawing.Size(580, 27);
            this.ktbFileName.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktbFileName.TabIndex = 1;
            // 
            // pbxFileIcon
            // 
            this.pbxFileIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbxFileIcon.Location = new System.Drawing.Point(20, 14);
            this.pbxFileIcon.Name = "pbxFileIcon";
            this.pbxFileIcon.Size = new System.Drawing.Size(64, 64);
            this.pbxFileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxFileIcon.TabIndex = 0;
            this.pbxFileIcon.TabStop = false;
            // 
            // kryptonPage2
            // 
            this.kryptonPage2.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage2.Controls.Add(this.kryptonGroupBox2);
            this.kryptonPage2.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPage2.Flags = 65534;
            this.kryptonPage2.LastVisibleSet = true;
            this.kryptonPage2.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage2.Name = "kryptonPage2";
            this.kryptonPage2.Size = new System.Drawing.Size(690, 644);
            this.kryptonPage2.Text = "Checksums";
            this.kryptonPage2.ToolTipTitle = "Page ToolTip";
            this.kryptonPage2.UniqueName = "fa8152ff43634150b3dc299a9631bdfc";
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Location = new System.Drawing.Point(20, 274);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.kbtnValidate);
            this.kryptonGroupBox2.Panel.Controls.Add(this.ktxtValidate);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kcmbValidatedHashType);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonLabel9);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(651, 221);
            this.kryptonGroupBox2.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox2.TabIndex = 1;
            this.kryptonGroupBox2.Values.Heading = "Validate Checksum";
            // 
            // kbtnValidate
            // 
            this.kbtnValidate.Enabled = false;
            this.kbtnValidate.Location = new System.Drawing.Point(473, 158);
            this.kbtnValidate.Name = "kbtnValidate";
            this.kbtnValidate.Size = new System.Drawing.Size(156, 27);
            this.kbtnValidate.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnValidate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnValidate.TabIndex = 10;
            this.kbtnValidate.Values.Text = "&Validate";
            this.kbtnValidate.Click += new System.EventHandler(this.KbtnValidate_Click);
            // 
            // ktxtValidate
            // 
            this.ktxtValidate.Location = new System.Drawing.Point(15, 81);
            this.ktxtValidate.Name = "ktxtValidate";
            this.ktxtValidate.Size = new System.Drawing.Size(614, 35);
            this.ktxtValidate.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtValidate.TabIndex = 9;
            this.ktxtValidate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ktxtValidate.TextChanged += new System.EventHandler(this.KtxtValidate_TextChanged);
            // 
            // kcmbValidatedHashType
            // 
            this.kcmbValidatedHashType.DropDownWidth = 220;
            this.kcmbValidatedHashType.Location = new System.Drawing.Point(109, 29);
            this.kcmbValidatedHashType.Name = "kcmbValidatedHashType";
            this.kcmbValidatedHashType.Size = new System.Drawing.Size(220, 25);
            this.kcmbValidatedHashType.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbValidatedHashType.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbValidatedHashType.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbValidatedHashType.TabIndex = 8;
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(15, 29);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(88, 24);
            this.kryptonLabel9.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.TabIndex = 7;
            this.kryptonLabel9.Values.Text = "Hash Type:";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(20, 14);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.pbCalculateFileHash);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kbtnCalculateFileHash);
            this.kryptonGroupBox1.Panel.Controls.Add(this.klblRealFileHash);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kcmbHashType1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.klblTotalFiles);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(651, 221);
            this.kryptonGroupBox1.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox1.TabIndex = 0;
            this.kryptonGroupBox1.Values.Heading = "Calculate Checksum";
            // 
            // pbCalculateFileHash
            // 
            this.pbCalculateFileHash.Location = new System.Drawing.Point(15, 154);
            this.pbCalculateFileHash.Name = "pbCalculateFileHash";
            this.pbCalculateFileHash.Size = new System.Drawing.Size(100, 23);
            this.pbCalculateFileHash.TabIndex = 10;
            this.pbCalculateFileHash.Visible = false;
            // 
            // kbtnCalculateFileHash
            // 
            this.kbtnCalculateFileHash.Enabled = false;
            this.kbtnCalculateFileHash.Location = new System.Drawing.Point(473, 151);
            this.kbtnCalculateFileHash.Name = "kbtnCalculateFileHash";
            this.kbtnCalculateFileHash.Size = new System.Drawing.Size(156, 27);
            this.kbtnCalculateFileHash.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCalculateFileHash.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCalculateFileHash.TabIndex = 9;
            this.kbtnCalculateFileHash.Values.Text = "Calculat&e";
            this.kbtnCalculateFileHash.Click += new System.EventHandler(this.KbtnCalculateFileHash_Click);
            // 
            // klblRealFileHash
            // 
            this.klblRealFileHash.AutoSize = false;
            this.klblRealFileHash.Location = new System.Drawing.Point(15, 84);
            this.klblRealFileHash.Name = "klblRealFileHash";
            this.klblRealFileHash.Size = new System.Drawing.Size(614, 52);
            this.klblRealFileHash.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblRealFileHash.StateCommon.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.klblRealFileHash.StateCommon.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.klblRealFileHash.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblRealFileHash.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.klblRealFileHash.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.klblRealFileHash.TabIndex = 7;
            this.klblRealFileHash.Values.Text = "";
            // 
            // kcmbHashType1
            // 
            this.kcmbHashType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbHashType1.DropDownWidth = 220;
            this.kcmbHashType1.Location = new System.Drawing.Point(109, 19);
            this.kcmbHashType1.Name = "kcmbHashType1";
            this.kcmbHashType1.Size = new System.Drawing.Size(220, 25);
            this.kcmbHashType1.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbHashType1.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbHashType1.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbHashType1.TabIndex = 6;
            // 
            // klblTotalFiles
            // 
            this.klblTotalFiles.Location = new System.Drawing.Point(15, 19);
            this.klblTotalFiles.Name = "klblTotalFiles";
            this.klblTotalFiles.Size = new System.Drawing.Size(88, 24);
            this.klblTotalFiles.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblTotalFiles.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblTotalFiles.TabIndex = 5;
            this.klblTotalFiles.Values.Text = "Hash Type:";
            // 
            // bgwMD5
            // 
            this.bgwMD5.WorkerReportsProgress = true;
            this.bgwMD5.WorkerSupportsCancellation = true;
            // 
            // bgwSHA1
            // 
            this.bgwSHA1.WorkerReportsProgress = true;
            this.bgwSHA1.WorkerSupportsCancellation = true;
            // 
            // bgwSHA256
            // 
            this.bgwSHA256.WorkerReportsProgress = true;
            this.bgwSHA256.WorkerSupportsCancellation = true;
            // 
            // bgwSHA384
            // 
            this.bgwSHA384.WorkerReportsProgress = true;
            this.bgwSHA384.WorkerSupportsCancellation = true;
            // 
            // bgwSHA512
            // 
            this.bgwSHA512.WorkerReportsProgress = true;
            this.bgwSHA512.WorkerSupportsCancellation = true;
            // 
            // bgwRIPEMD160
            // 
            this.bgwRIPEMD160.WorkerReportsProgress = true;
            this.bgwRIPEMD160.WorkerSupportsCancellation = true;
            // 
            // kryptonPage3
            // 
            this.kryptonPage3.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage3.Controls.Add(this.kryptonGroupBox3);
            this.kryptonPage3.Flags = 65534;
            this.kryptonPage3.LastVisibleSet = true;
            this.kryptonPage3.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage3.Name = "kryptonPage3";
            this.kryptonPage3.Size = new System.Drawing.Size(690, 644);
            this.kryptonPage3.Text = "File Attributes";
            this.kryptonPage3.ToolTipTitle = "Page ToolTip";
            this.kryptonPage3.UniqueName = "50a26aabd19c4b24a5d601dc8c8dcced";
            // 
            // kryptonGroupBox3
            // 
            this.kryptonGroupBox3.Location = new System.Drawing.Point(20, 14);
            this.kryptonGroupBox3.Name = "kryptonGroupBox3";
            // 
            // kryptonGroupBox3.Panel
            // 
            this.kryptonGroupBox3.Panel.Controls.Add(this.kryptonCheckBox16);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kryptonCheckBox15);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kryptonCheckBox14);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kryptonCheckBox13);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kryptonCheckBox12);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kryptonCheckBox11);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kryptonCheckBox6);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kryptonCheckBox7);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kryptonCheckBox8);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kryptonCheckBox9);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kryptonCheckBox10);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kryptonCheckBox5);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kryptonCheckBox4);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kryptonCheckBox3);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kryptonCheckBox2);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kryptonCheckBox1);
            this.kryptonGroupBox3.Size = new System.Drawing.Size(651, 243);
            this.kryptonGroupBox3.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox3.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox3.TabIndex = 2;
            this.kryptonGroupBox3.Values.Heading = "Validate Checksum";
            // 
            // kryptonCheckBox1
            // 
            this.kryptonCheckBox1.Location = new System.Drawing.Point(15, 19);
            this.kryptonCheckBox1.Name = "kryptonCheckBox1";
            this.kryptonCheckBox1.Size = new System.Drawing.Size(79, 26);
            this.kryptonCheckBox1.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckBox1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckBox1.TabIndex = 0;
            this.kryptonCheckBox1.ToolTipValues.Description = resources.GetString("resource.Description7");
            this.kryptonCheckBox1.ToolTipValues.Heading = "Archived";
            this.kryptonCheckBox1.Values.Text = "&Archive";
            // 
            // kryptonCheckBox2
            // 
            this.kryptonCheckBox2.Location = new System.Drawing.Point(529, 19);
            this.kryptonCheckBox2.Name = "kryptonCheckBox2";
            this.kryptonCheckBox2.Size = new System.Drawing.Size(97, 26);
            this.kryptonCheckBox2.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckBox2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckBox2.TabIndex = 1;
            this.kryptonCheckBox2.Values.Text = "&Encrypted";
            // 
            // kryptonCheckBox3
            // 
            this.kryptonCheckBox3.Location = new System.Drawing.Point(399, 19);
            this.kryptonCheckBox3.Name = "kryptonCheckBox3";
            this.kryptonCheckBox3.Size = new System.Drawing.Size(91, 26);
            this.kryptonCheckBox3.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckBox3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckBox3.TabIndex = 2;
            this.kryptonCheckBox3.Values.Text = "D&irectory";
            // 
            // kryptonCheckBox4
            // 
            this.kryptonCheckBox4.Location = new System.Drawing.Point(287, 19);
            this.kryptonCheckBox4.Name = "kryptonCheckBox4";
            this.kryptonCheckBox4.Size = new System.Drawing.Size(73, 26);
            this.kryptonCheckBox4.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckBox4.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckBox4.TabIndex = 3;
            this.kryptonCheckBox4.Values.Text = "D&evice";
            // 
            // kryptonCheckBox5
            // 
            this.kryptonCheckBox5.Location = new System.Drawing.Point(133, 19);
            this.kryptonCheckBox5.Name = "kryptonCheckBox5";
            this.kryptonCheckBox5.Size = new System.Drawing.Size(115, 26);
            this.kryptonCheckBox5.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckBox5.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckBox5.TabIndex = 4;
            this.kryptonCheckBox5.Values.Text = "C&ompressed";
            // 
            // kryptonCheckBox6
            // 
            this.kryptonCheckBox6.Location = new System.Drawing.Point(133, 67);
            this.kryptonCheckBox6.Name = "kryptonCheckBox6";
            this.kryptonCheckBox6.Size = new System.Drawing.Size(142, 26);
            this.kryptonCheckBox6.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckBox6.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckBox6.TabIndex = 9;
            this.kryptonCheckBox6.Values.Text = "I&ntegrity Stream";
            // 
            // kryptonCheckBox7
            // 
            this.kryptonCheckBox7.Location = new System.Drawing.Point(287, 67);
            this.kryptonCheckBox7.Name = "kryptonCheckBox7";
            this.kryptonCheckBox7.Size = new System.Drawing.Size(79, 26);
            this.kryptonCheckBox7.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckBox7.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckBox7.TabIndex = 8;
            this.kryptonCheckBox7.Values.Text = "No&rmal";
            // 
            // kryptonCheckBox8
            // 
            this.kryptonCheckBox8.Location = new System.Drawing.Point(399, 67);
            this.kryptonCheckBox8.Name = "kryptonCheckBox8";
            this.kryptonCheckBox8.Size = new System.Drawing.Size(131, 26);
            this.kryptonCheckBox8.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckBox8.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckBox8.TabIndex = 7;
            this.kryptonCheckBox8.Values.Text = "No &Scrub Data";
            // 
            // kryptonCheckBox9
            // 
            this.kryptonCheckBox9.Location = new System.Drawing.Point(15, 114);
            this.kryptonCheckBox9.Name = "kryptonCheckBox9";
            this.kryptonCheckBox9.Size = new System.Drawing.Size(176, 26);
            this.kryptonCheckBox9.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckBox9.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckBox9.TabIndex = 6;
            this.kryptonCheckBox9.Values.Text = "Not Co&ntext Indexed";
            // 
            // kryptonCheckBox10
            // 
            this.kryptonCheckBox10.Location = new System.Drawing.Point(15, 67);
            this.kryptonCheckBox10.Name = "kryptonCheckBox10";
            this.kryptonCheckBox10.Size = new System.Drawing.Size(78, 26);
            this.kryptonCheckBox10.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckBox10.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckBox10.TabIndex = 5;
            this.kryptonCheckBox10.ToolTipValues.Description = resources.GetString("resource.Description6");
            this.kryptonCheckBox10.ToolTipValues.Heading = "Archived";
            this.kryptonCheckBox10.Values.Text = "&Hidden";
            // 
            // kryptonCheckBox11
            // 
            this.kryptonCheckBox11.Location = new System.Drawing.Point(232, 114);
            this.kryptonCheckBox11.Name = "kryptonCheckBox11";
            this.kryptonCheckBox11.Size = new System.Drawing.Size(73, 26);
            this.kryptonCheckBox11.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckBox11.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckBox11.TabIndex = 10;
            this.kryptonCheckBox11.ToolTipValues.Description = resources.GetString("resource.Description5");
            this.kryptonCheckBox11.ToolTipValues.Heading = "Archived";
            this.kryptonCheckBox11.Values.Text = "O&ffline";
            // 
            // kryptonCheckBox12
            // 
            this.kryptonCheckBox12.Location = new System.Drawing.Point(348, 114);
            this.kryptonCheckBox12.Name = "kryptonCheckBox12";
            this.kryptonCheckBox12.Size = new System.Drawing.Size(100, 26);
            this.kryptonCheckBox12.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckBox12.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckBox12.TabIndex = 11;
            this.kryptonCheckBox12.ToolTipValues.Description = resources.GetString("resource.Description4");
            this.kryptonCheckBox12.ToolTipValues.Heading = "Archived";
            this.kryptonCheckBox12.Values.Text = "&Read Only";
            // 
            // kryptonCheckBox13
            // 
            this.kryptonCheckBox13.Location = new System.Drawing.Point(476, 114);
            this.kryptonCheckBox13.Name = "kryptonCheckBox13";
            this.kryptonCheckBox13.Size = new System.Drawing.Size(125, 26);
            this.kryptonCheckBox13.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckBox13.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckBox13.TabIndex = 12;
            this.kryptonCheckBox13.ToolTipValues.Description = resources.GetString("resource.Description3");
            this.kryptonCheckBox13.ToolTipValues.Heading = "Archived";
            this.kryptonCheckBox13.Values.Text = "Re&parse Point";
            // 
            // kryptonCheckBox14
            // 
            this.kryptonCheckBox14.Location = new System.Drawing.Point(15, 161);
            this.kryptonCheckBox14.Name = "kryptonCheckBox14";
            this.kryptonCheckBox14.Size = new System.Drawing.Size(102, 26);
            this.kryptonCheckBox14.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckBox14.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckBox14.TabIndex = 13;
            this.kryptonCheckBox14.ToolTipValues.Description = resources.GetString("resource.Description2");
            this.kryptonCheckBox14.ToolTipValues.Heading = "Archived";
            this.kryptonCheckBox14.Values.Text = "Spar&se File";
            // 
            // kryptonCheckBox15
            // 
            this.kryptonCheckBox15.Location = new System.Drawing.Point(133, 161);
            this.kryptonCheckBox15.Name = "kryptonCheckBox15";
            this.kryptonCheckBox15.Size = new System.Drawing.Size(77, 26);
            this.kryptonCheckBox15.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckBox15.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckBox15.TabIndex = 14;
            this.kryptonCheckBox15.ToolTipValues.Description = resources.GetString("resource.Description1");
            this.kryptonCheckBox15.ToolTipValues.Heading = "Archived";
            this.kryptonCheckBox15.Values.Text = "S&ystem";
            // 
            // kryptonCheckBox16
            // 
            this.kryptonCheckBox16.Location = new System.Drawing.Point(232, 161);
            this.kryptonCheckBox16.Name = "kryptonCheckBox16";
            this.kryptonCheckBox16.Size = new System.Drawing.Size(103, 26);
            this.kryptonCheckBox16.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckBox16.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckBox16.TabIndex = 15;
            this.kryptonCheckBox16.ToolTipValues.Description = resources.GetString("resource.Description");
            this.kryptonCheckBox16.ToolTipValues.Heading = "Archived";
            this.kryptonCheckBox16.Values.Text = "Te&mporary";
            // 
            // KryptonFileInformationDialog
            // 
            this.ClientSize = new System.Drawing.Size(716, 744);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.pnlSplitter);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KryptonFileInformationDialog";
            this.Text = "{0} Properties";
            this.Load += new System.EventHandler(this.KryptonFileInformationDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).EndInit();
            this.kryptonNavigator1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            this.kryptonPage1.ResumeLayout(false);
            this.kryptonPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFileIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).EndInit();
            this.kryptonPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kcmbValidatedHashType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kcmbHashType1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage3)).EndInit();
            this.kryptonPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3.Panel)).EndInit();
            this.kryptonGroupBox3.Panel.ResumeLayout(false);
            this.kryptonGroupBox3.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3)).EndInit();
            this.kryptonGroupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        private string _filePath = null;
        #endregion

        #region Properties        
        /// <summary>
        /// Gets or sets the file path.
        /// </summary>
        /// <value>
        /// The file path.
        /// </value>
        public string FilePath { get => _filePath; set => _filePath = value; }
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="KryptonFileInformationDialog"/> class.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        public KryptonFileInformationDialog(string filePath)
        {
            InitializeComponent();

            FilePath = filePath;
        }

        private void KryptonFileInformationDialog_Load(object sender, EventArgs e)
        {
            LoadWindow();
        }

        private void KbtnValidate_Click(object sender, EventArgs e)
        {
            HashingHelper.ValidateFileHash(klblRealFileHash, ktxtValidate);
        }

        private void LoadWindow()
        {
            HashingHelper.PropagateHashInput(kcmbHashType1);

            HashingHelper.PropagateHashInput(kcmbValidatedHashType);

            UpdateWindowTitle(FilePath);

            ktbFileName.Text = Path.GetFileName(FilePath);

            GetFileInformation(FilePath);

            UpdateWindowIcon(FilePath);
        }

        /// <summary>
        /// Updates the window icon.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        private void UpdateWindowIcon(string filePath)
        {
            Icon = GetFileIcon(filePath);

            pbxFileIcon.Image = GetFileIconImage(filePath);
        }

        /// <summary>
        /// Gets the file icon image.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        private Image GetFileIconImage(string filePath)
        {
            return Icon.ExtractAssociatedIcon(filePath).ToBitmap();
        }

        /// <summary>
        /// Gets the file icon.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        private Icon GetFileIcon(string filePath)
        {
            return Icon.ExtractAssociatedIcon(filePath);
        }

        /// <summary>
        /// Gets the file information.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <exception cref="ArgumentNullException"></exception>
        private void GetFileInformation(string filePath)
        {
            try
            {
                if (filePath == string.Empty) throw new ArgumentNullException();

                FileInfo fileInfo = new FileInfo(filePath);

                klblFileType.Text = $"Type of file: *{ Path.GetExtension(filePath) }";

                klblFileLocation.Text = $"Location: { Path.GetFullPath(filePath) }";

                klblFileSize.Text = $"Size: { FileUtilities.GetReadableFileSize(fileInfo.Length) } ({ fileInfo.Length.ToString() } bytes)";

                klblSizeOnDisk.Text = $"Size on disk: { FileUtilities.GetReadableFileSize(FileUtilities.GetFileSizeOnDisk(filePath)) }";

                klblCreated.Text = $"Created: { GetDateTimeAsString(fileInfo.CreationTime) }";

                klblAccessed.Text = $"Accessed: { GetDateTimeAsString(fileInfo.LastAccessTime) }";

                klblModified.Text = $"Modified: { GetDateTimeAsString(fileInfo.LastWriteTime) }";
            }
            catch (Exception exc)
            {
                ExceptionHandler.CaptureException(exc);
            }
        }

        /// <summary>
        /// Updates the window title.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <param name="showExtension">if set to <c>true</c> [show extension].</param>
        private void UpdateWindowTitle(string filePath, bool showExtension = false)
        {
            if (showExtension)
            {
                Text = $"{ Path.GetFileName(filePath) } Properties";
            }
            else
            {
                Text = $"{ Path.GetFileNameWithoutExtension(filePath) } Properties";
            }
        }

        /// <summary>
        /// Constructs the m d5 hash string.
        /// </summary>
        /// <param name="hashBytes">The hash bytes.</param>
        /// <returns></returns>
        private static string ConstructMD5HashString(byte[] hashBytes)
        {
            StringBuilder hashBuilder = new StringBuilder(32);

            foreach (byte b in hashBytes)
            {
                hashBuilder.Append(b.ToString("X2").ToLower());
            }

            return hashBuilder.ToString();
        }

        /// <summary>
        /// Gets the date time as string.
        /// </summary>
        /// <param name="dateTime">The date time.</param>
        /// <returns></returns>
        private static string GetDateTimeAsString(DateTime dateTime)
        {
            return dateTime.ToLongDateString();
        }

        private void KbtnCalculateFileHash_Click(object sender, EventArgs e)
        {
            if (kcmbHashType1.Text == "MD5")
            {
                bgwMD5.RunWorkerAsync(ktbFileName.Text);
            }
            else if (kcmbHashType1.Text == "SHA-1")
            {
                bgwSHA1.RunWorkerAsync(ktbFileName.Text);
            }
            else if (kcmbHashType1.Text == "SHA-256")
            {
                bgwSHA256.RunWorkerAsync(ktbFileName.Text);
            }
            else if (kcmbHashType1.Text == "SHA-384")
            {
                bgwSHA384.RunWorkerAsync(ktbFileName.Text);
            }
            else if (kcmbHashType1.Text == "SHA-512")
            {
                bgwSHA512.RunWorkerAsync(ktbFileName.Text);
            }
            else if (kcmbHashType1.Text == "RIPEMD-160")
            {
                bgwRIPEMD160.RunWorkerAsync(ktbFileName.Text);
            }

            kbtnCalculateFileHash.Enabled = false;
        }

        private void KtxtValidate_TextChanged(object sender, EventArgs e)
        {
            HashingHelper.UpdateHashType(kcmbValidatedHashType, ktxtValidate.Text.Length);
        }
    }
}
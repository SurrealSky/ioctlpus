namespace ioctlpus
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPanes = new System.Windows.Forms.TableLayoutPanel();
            this.gbRightPane = new System.Windows.Forms.GroupBox();
            this.hbOutput = new Be.Windows.Forms.HexBox();
            this.gbLeftPane = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hbInputCb = new System.Windows.Forms.CheckBox();
            this.hbInputTb = new System.Windows.Forms.TextBox();
            this.hbInput = new Be.Windows.Forms.HexBox();
            this.tlpTop = new System.Windows.Forms.TableLayoutPanel();
            this.pnlReqParams = new System.Windows.Forms.Panel();
            this.lblOutputSize = new System.Windows.Forms.Label();
            this.nudOutputSize = new System.Windows.Forms.NumericUpDown();
            this.lblRepeat = new System.Windows.Forms.Label();
            this.nudRepeat = new System.Windows.Forms.NumericUpDown();
            this.lblInputSize = new System.Windows.Forms.Label();
            this.lblIOCTLCode = new System.Windows.Forms.Label();
            this.tbIOCTL = new System.Windows.Forms.TextBox();
            this.tbDevicePath = new System.Windows.Forms.TextBox();
            this.lblDevPath = new System.Windows.Forms.Label();
            this.nudInputSize = new System.Windows.Forms.NumericUpDown();
            this.btnSend = new System.Windows.Forms.Button();
            this.gbRequestHistory = new System.Windows.Forms.GroupBox();
            this.btnSaveDB = new System.Windows.Forms.Button();
            this.tbFilters = new System.Windows.Forms.TextBox();
            this.btnStarRequest = new System.Windows.Forms.Button();
            this.btnDeleteRequest = new System.Windows.Forms.Button();
            this.btnOpenDB = new System.Windows.Forms.Button();
            this.tlvRequestHistory = new BrightIdeasSoftware.TreeListView();
            this.olvColumnRequest = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnRetVal = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnBytesReturned = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tlpMain.SuspendLayout();
            this.tlpPanes.SuspendLayout();
            this.gbRightPane.SuspendLayout();
            this.gbLeftPane.SuspendLayout();
            this.tlpTop.SuspendLayout();
            this.pnlReqParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutputSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRepeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInputSize)).BeginInit();
            this.gbRequestHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlvRequestHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpPanes, 0, 1);
            this.tlpMain.Controls.Add(this.tlpTop, 0, 0);
            this.tlpMain.Controls.Add(this.gbRequestHistory, 0, 2);
            this.tlpMain.Location = new System.Drawing.Point(12, 11);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpMain.Size = new System.Drawing.Size(848, 613);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpPanes
            // 
            this.tlpPanes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpPanes.ColumnCount = 2;
            this.tlpPanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPanes.Controls.Add(this.gbRightPane, 1, 0);
            this.tlpPanes.Controls.Add(this.gbLeftPane, 0, 0);
            this.tlpPanes.Location = new System.Drawing.Point(3, 86);
            this.tlpPanes.Name = "tlpPanes";
            this.tlpPanes.RowCount = 1;
            this.tlpPanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 314F));
            this.tlpPanes.Size = new System.Drawing.Size(842, 312);
            this.tlpPanes.TabIndex = 0;
            // 
            // gbRightPane
            // 
            this.gbRightPane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRightPane.Controls.Add(this.hbOutput);
            this.gbRightPane.Location = new System.Drawing.Point(424, 3);
            this.gbRightPane.Name = "gbRightPane";
            this.gbRightPane.Size = new System.Drawing.Size(415, 306);
            this.gbRightPane.TabIndex = 1;
            this.gbRightPane.TabStop = false;
            this.gbRightPane.Text = "Output Buffer";
            // 
            // hbOutput
            // 
            this.hbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hbOutput.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hbOutput.InfoForeColor = System.Drawing.Color.Empty;
            this.hbOutput.Location = new System.Drawing.Point(6, 18);
            this.hbOutput.Name = "hbOutput";
            this.hbOutput.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hbOutput.Size = new System.Drawing.Size(403, 283);
            this.hbOutput.TabIndex = 0;
            // 
            // gbLeftPane
            // 
            this.gbLeftPane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLeftPane.Controls.Add(this.hbInput);
            this.gbLeftPane.Location = new System.Drawing.Point(3, 3);
            this.gbLeftPane.Name = "gbLeftPane";
            this.gbLeftPane.Size = new System.Drawing.Size(415, 306);
            this.gbLeftPane.TabIndex = 0;
            this.gbLeftPane.TabStop = false;
            this.gbLeftPane.Text = "Input Buffer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "输入字符串：";
            // 
            // hbInputCb
            // 
            this.hbInputCb.AutoSize = true;
            this.hbInputCb.Location = new System.Drawing.Point(722, 49);
            this.hbInputCb.Name = "hbInputCb";
            this.hbInputCb.Size = new System.Drawing.Size(60, 16);
            this.hbInputCb.TabIndex = 3;
            this.hbInputCb.Text = "宽字节";
            this.hbInputCb.UseVisualStyleBackColor = true;
            // 
            // hbInputTb
            // 
            this.hbInputTb.Location = new System.Drawing.Point(395, 45);
            this.hbInputTb.Name = "hbInputTb";
            this.hbInputTb.Size = new System.Drawing.Size(319, 21);
            this.hbInputTb.TabIndex = 0;
            this.hbInputTb.TextChanged += new System.EventHandler(this.hbInputTb_TextChanged);
            // 
            // hbInput
            // 
            this.hbInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hbInput.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hbInput.InfoForeColor = System.Drawing.Color.Empty;
            this.hbInput.Location = new System.Drawing.Point(6, 18);
            this.hbInput.Name = "hbInput";
            this.hbInput.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hbInput.Size = new System.Drawing.Size(403, 283);
            this.hbInput.TabIndex = 0;
            // 
            // tlpTop
            // 
            this.tlpTop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpTop.ColumnCount = 1;
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTop.Controls.Add(this.pnlReqParams, 0, 0);
            this.tlpTop.Location = new System.Drawing.Point(3, 3);
            this.tlpTop.Name = "tlpTop";
            this.tlpTop.RowCount = 1;
            this.tlpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTop.Size = new System.Drawing.Size(842, 77);
            this.tlpTop.TabIndex = 2;
            // 
            // pnlReqParams
            // 
            this.pnlReqParams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlReqParams.Controls.Add(this.label1);
            this.pnlReqParams.Controls.Add(this.lblOutputSize);
            this.pnlReqParams.Controls.Add(this.hbInputCb);
            this.pnlReqParams.Controls.Add(this.nudOutputSize);
            this.pnlReqParams.Controls.Add(this.hbInputTb);
            this.pnlReqParams.Controls.Add(this.lblRepeat);
            this.pnlReqParams.Controls.Add(this.nudRepeat);
            this.pnlReqParams.Controls.Add(this.lblInputSize);
            this.pnlReqParams.Controls.Add(this.lblIOCTLCode);
            this.pnlReqParams.Controls.Add(this.tbIOCTL);
            this.pnlReqParams.Controls.Add(this.tbDevicePath);
            this.pnlReqParams.Controls.Add(this.lblDevPath);
            this.pnlReqParams.Controls.Add(this.nudInputSize);
            this.pnlReqParams.Controls.Add(this.btnSend);
            this.pnlReqParams.Location = new System.Drawing.Point(3, 3);
            this.pnlReqParams.Name = "pnlReqParams";
            this.pnlReqParams.Size = new System.Drawing.Size(836, 71);
            this.pnlReqParams.TabIndex = 0;
            // 
            // lblOutputSize
            // 
            this.lblOutputSize.AutoSize = true;
            this.lblOutputSize.Location = new System.Drawing.Point(244, 49);
            this.lblOutputSize.Name = "lblOutputSize";
            this.lblOutputSize.Size = new System.Drawing.Size(77, 12);
            this.lblOutputSize.TabIndex = 10;
            this.lblOutputSize.Text = "Output Size:";
            // 
            // nudOutputSize
            // 
            this.nudOutputSize.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudOutputSize.Hexadecimal = true;
            this.nudOutputSize.Location = new System.Drawing.Point(330, 48);
            this.nudOutputSize.Maximum = new decimal(new int[] {
            1048576,
            0,
            0,
            0});
            this.nudOutputSize.Name = "nudOutputSize";
            this.nudOutputSize.Size = new System.Drawing.Size(50, 20);
            this.nudOutputSize.TabIndex = 5;
            this.nudOutputSize.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // lblRepeat
            // 
            this.lblRepeat.AutoSize = true;
            this.lblRepeat.Location = new System.Drawing.Point(279, 28);
            this.lblRepeat.Name = "lblRepeat";
            this.lblRepeat.Size = new System.Drawing.Size(47, 12);
            this.lblRepeat.TabIndex = 8;
            this.lblRepeat.Text = "Repeat:";
            // 
            // nudRepeat
            // 
            this.nudRepeat.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRepeat.Location = new System.Drawing.Point(330, 26);
            this.nudRepeat.Name = "nudRepeat";
            this.nudRepeat.Size = new System.Drawing.Size(50, 20);
            this.nudRepeat.TabIndex = 3;
            // 
            // lblInputSize
            // 
            this.lblInputSize.AutoSize = true;
            this.lblInputSize.Location = new System.Drawing.Point(106, 48);
            this.lblInputSize.Name = "lblInputSize";
            this.lblInputSize.Size = new System.Drawing.Size(71, 12);
            this.lblInputSize.TabIndex = 6;
            this.lblInputSize.Text = "Input Size:";
            // 
            // lblIOCTLCode
            // 
            this.lblIOCTLCode.AutoSize = true;
            this.lblIOCTLCode.Location = new System.Drawing.Point(106, 28);
            this.lblIOCTLCode.Name = "lblIOCTLCode";
            this.lblIOCTLCode.Size = new System.Drawing.Size(71, 12);
            this.lblIOCTLCode.TabIndex = 5;
            this.lblIOCTLCode.Text = "IOCTL Code:";
            // 
            // tbIOCTL
            // 
            this.tbIOCTL.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIOCTL.Location = new System.Drawing.Point(181, 25);
            this.tbIOCTL.Name = "tbIOCTL";
            this.tbIOCTL.Size = new System.Drawing.Size(90, 20);
            this.tbIOCTL.TabIndex = 2;
            this.tbIOCTL.TextChanged += new System.EventHandler(this.tbIOCTL_TextChanged);
            // 
            // tbDevicePath
            // 
            this.tbDevicePath.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDevicePath.Location = new System.Drawing.Point(192, 4);
            this.tbDevicePath.Name = "tbDevicePath";
            this.tbDevicePath.Size = new System.Drawing.Size(188, 20);
            this.tbDevicePath.TabIndex = 1;
            this.tbDevicePath.TextChanged += new System.EventHandler(this.tbDevicePath_TextChanged);
            // 
            // lblDevPath
            // 
            this.lblDevPath.AutoSize = true;
            this.lblDevPath.Location = new System.Drawing.Point(107, 6);
            this.lblDevPath.Name = "lblDevPath";
            this.lblDevPath.Size = new System.Drawing.Size(77, 12);
            this.lblDevPath.TabIndex = 2;
            this.lblDevPath.Text = "Path / GUID:";
            // 
            // nudInputSize
            // 
            this.nudInputSize.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudInputSize.Hexadecimal = true;
            this.nudInputSize.Location = new System.Drawing.Point(181, 47);
            this.nudInputSize.Maximum = new decimal(new int[] {
            1048576,
            0,
            0,
            0});
            this.nudInputSize.Name = "nudInputSize";
            this.nudInputSize.Size = new System.Drawing.Size(57, 20);
            this.nudInputSize.TabIndex = 4;
            this.nudInputSize.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Image = global::ioctlpus.Properties.Resources.lightning;
            this.btnSend.Location = new System.Drawing.Point(0, 0);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(105, 72);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "&Send";
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // gbRequestHistory
            // 
            this.gbRequestHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRequestHistory.Controls.Add(this.btnSaveDB);
            this.gbRequestHistory.Controls.Add(this.tbFilters);
            this.gbRequestHistory.Controls.Add(this.btnStarRequest);
            this.gbRequestHistory.Controls.Add(this.btnDeleteRequest);
            this.gbRequestHistory.Controls.Add(this.btnOpenDB);
            this.gbRequestHistory.Controls.Add(this.tlvRequestHistory);
            this.gbRequestHistory.Location = new System.Drawing.Point(3, 404);
            this.gbRequestHistory.Name = "gbRequestHistory";
            this.gbRequestHistory.Size = new System.Drawing.Size(842, 206);
            this.gbRequestHistory.TabIndex = 3;
            this.gbRequestHistory.TabStop = false;
            this.gbRequestHistory.Text = "Request History";
            // 
            // btnSaveDB
            // 
            this.btnSaveDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveDB.Enabled = false;
            this.btnSaveDB.Image = global::ioctlpus.Properties.Resources.database_save;
            this.btnSaveDB.Location = new System.Drawing.Point(804, 53);
            this.btnSaveDB.Name = "btnSaveDB";
            this.btnSaveDB.Size = new System.Drawing.Size(32, 30);
            this.btnSaveDB.TabIndex = 3;
            this.toolTip.SetToolTip(this.btnSaveDB, "Save Database");
            this.btnSaveDB.UseVisualStyleBackColor = true;
            // 
            // tbFilters
            // 
            this.tbFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilters.Enabled = false;
            this.tbFilters.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilters.Location = new System.Drawing.Point(6, 179);
            this.tbFilters.Name = "tbFilters";
            this.tbFilters.Size = new System.Drawing.Size(792, 20);
            this.tbFilters.TabIndex = 1;
            this.tbFilters.TextChanged += new System.EventHandler(this.tbFilters_TextChanged);
            // 
            // btnStarRequest
            // 
            this.btnStarRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStarRequest.Image = global::ioctlpus.Properties.Resources.star;
            this.btnStarRequest.Location = new System.Drawing.Point(804, 88);
            this.btnStarRequest.Name = "btnStarRequest";
            this.btnStarRequest.Size = new System.Drawing.Size(32, 30);
            this.btnStarRequest.TabIndex = 4;
            this.toolTip.SetToolTip(this.btnStarRequest, "Star Request");
            this.btnStarRequest.UseVisualStyleBackColor = true;
            this.btnStarRequest.Click += new System.EventHandler(this.btnStarRequest_Click);
            // 
            // btnDeleteRequest
            // 
            this.btnDeleteRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteRequest.Enabled = false;
            this.btnDeleteRequest.Image = global::ioctlpus.Properties.Resources.delete;
            this.btnDeleteRequest.Location = new System.Drawing.Point(804, 123);
            this.btnDeleteRequest.Name = "btnDeleteRequest";
            this.btnDeleteRequest.Size = new System.Drawing.Size(32, 30);
            this.btnDeleteRequest.TabIndex = 5;
            this.toolTip.SetToolTip(this.btnDeleteRequest, "Remove Request");
            this.btnDeleteRequest.UseVisualStyleBackColor = true;
            // 
            // btnOpenDB
            // 
            this.btnOpenDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenDB.Enabled = false;
            this.btnOpenDB.Image = global::ioctlpus.Properties.Resources.database_add;
            this.btnOpenDB.Location = new System.Drawing.Point(804, 18);
            this.btnOpenDB.Name = "btnOpenDB";
            this.btnOpenDB.Size = new System.Drawing.Size(32, 30);
            this.btnOpenDB.TabIndex = 2;
            this.toolTip.SetToolTip(this.btnOpenDB, "Load Database");
            this.btnOpenDB.UseVisualStyleBackColor = true;
            this.btnOpenDB.Click += new System.EventHandler(this.btnOpenDB_Click);
            // 
            // tlvRequestHistory
            // 
            this.tlvRequestHistory.AllColumns.Add(this.olvColumnRequest);
            this.tlvRequestHistory.AllColumns.Add(this.olvColumnRetVal);
            this.tlvRequestHistory.AllColumns.Add(this.olvColumnBytesReturned);
            this.tlvRequestHistory.AllColumns.Add(this.olvColumnTime);
            this.tlvRequestHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlvRequestHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnRequest,
            this.olvColumnRetVal,
            this.olvColumnBytesReturned,
            this.olvColumnTime});
            this.tlvRequestHistory.Cursor = System.Windows.Forms.Cursors.Default;
            this.tlvRequestHistory.HideSelection = false;
            this.tlvRequestHistory.Location = new System.Drawing.Point(6, 18);
            this.tlvRequestHistory.Name = "tlvRequestHistory";
            this.tlvRequestHistory.OwnerDraw = true;
            this.tlvRequestHistory.ShowGroups = false;
            this.tlvRequestHistory.Size = new System.Drawing.Size(792, 156);
            this.tlvRequestHistory.TabIndex = 0;
            this.tlvRequestHistory.UseCompatibleStateImageBehavior = false;
            this.tlvRequestHistory.View = System.Windows.Forms.View.Details;
            this.tlvRequestHistory.VirtualMode = true;
            // 
            // olvColumnRequest
            // 
            this.olvColumnRequest.AspectName = "RequestName";
            this.olvColumnRequest.CellPadding = null;
            this.olvColumnRequest.MinimumWidth = 230;
            this.olvColumnRequest.Text = "Request";
            this.olvColumnRequest.Width = 230;
            // 
            // olvColumnRetVal
            // 
            this.olvColumnRetVal.AspectName = "ReturnValueString";
            this.olvColumnRetVal.CellPadding = null;
            this.olvColumnRetVal.IsEditable = false;
            this.olvColumnRetVal.MinimumWidth = 260;
            this.olvColumnRetVal.Text = "Return Value";
            this.olvColumnRetVal.Width = 260;
            // 
            // olvColumnBytesReturned
            // 
            this.olvColumnBytesReturned.AspectName = "BytesReturned";
            this.olvColumnBytesReturned.CellPadding = null;
            this.olvColumnBytesReturned.IsEditable = false;
            this.olvColumnBytesReturned.MinimumWidth = 90;
            this.olvColumnBytesReturned.Text = "Bytes Returned";
            this.olvColumnBytesReturned.Width = 90;
            // 
            // olvColumnTime
            // 
            this.olvColumnTime.AspectName = "Timestamp";
            this.olvColumnTime.CellPadding = null;
            this.olvColumnTime.FillsFreeSpace = true;
            this.olvColumnTime.IsEditable = false;
            this.olvColumnTime.Text = "Time";
            this.olvColumnTime.Width = 80;
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 250;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(872, 635);
            this.Controls.Add(this.tlpMain);
            this.MinimumSize = new System.Drawing.Size(830, 557);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "ioctlpus";
            this.tlpMain.ResumeLayout(false);
            this.tlpPanes.ResumeLayout(false);
            this.gbRightPane.ResumeLayout(false);
            this.gbLeftPane.ResumeLayout(false);
            this.tlpTop.ResumeLayout(false);
            this.pnlReqParams.ResumeLayout(false);
            this.pnlReqParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutputSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRepeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInputSize)).EndInit();
            this.gbRequestHistory.ResumeLayout(false);
            this.gbRequestHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlvRequestHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpPanes;
        private System.Windows.Forms.TableLayoutPanel tlpTop;
        private Be.Windows.Forms.HexBox hbInput;
        private Be.Windows.Forms.HexBox hbOutput;
        private System.Windows.Forms.Panel pnlReqParams;
        private System.Windows.Forms.Label lblIOCTLCode;
        private System.Windows.Forms.TextBox tbIOCTL;
        private System.Windows.Forms.TextBox tbDevicePath;
        private System.Windows.Forms.Label lblDevPath;
        private System.Windows.Forms.NumericUpDown nudInputSize;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblInputSize;
        private System.Windows.Forms.Label lblRepeat;
        private System.Windows.Forms.NumericUpDown nudRepeat;
        private System.Windows.Forms.Label lblOutputSize;
        private System.Windows.Forms.NumericUpDown nudOutputSize;
        private System.Windows.Forms.GroupBox gbLeftPane;
        private System.Windows.Forms.GroupBox gbRightPane;
        private System.Windows.Forms.GroupBox gbRequestHistory;
        private System.Windows.Forms.Button btnStarRequest;
        private System.Windows.Forms.Button btnDeleteRequest;
        private System.Windows.Forms.Button btnOpenDB;
        private BrightIdeasSoftware.TreeListView tlvRequestHistory;
        private BrightIdeasSoftware.OLVColumn olvColumnRequest;
        private BrightIdeasSoftware.OLVColumn olvColumnTime;
        private BrightIdeasSoftware.OLVColumn olvColumnRetVal;
        private BrightIdeasSoftware.OLVColumn olvColumnBytesReturned;
        private System.Windows.Forms.TextBox tbFilters;
        private System.Windows.Forms.Button btnSaveDB;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.CheckBox hbInputCb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hbInputTb;
    }
}


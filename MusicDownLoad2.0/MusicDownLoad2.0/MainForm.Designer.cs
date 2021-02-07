namespace MusicDownLoad2._0
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lbl_SongOrSinger = new CCWin.SkinControl.SkinLabel();
            this.btn_Query = new CCWin.SkinControl.SkinButton();
            this.grb_QueryCondition = new System.Windows.Forms.GroupBox();
            this.txt_SongOrSinger = new System.Windows.Forms.TextBox();
            this.dgv_Songs = new CCWin.SkinControl.SkinDataGridView();
            this.songName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumPic = new System.Windows.Forms.DataGridViewLinkColumn();
            this.albumPic120 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.musicRid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu = new CCWin.SkinControl.SkinContextMenuStrip();
            this.menuBtn_DownLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtn_CopyDownLoadUrl = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pro_QueryProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.lbl_QueryProgress = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog_Music = new System.Windows.Forms.SaveFileDialog();
            this.lbl_saveFilePath = new System.Windows.Forms.ToolStripStatusLabel();
            this.grb_QueryCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Songs)).BeginInit();
            this.menu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_SongOrSinger
            // 
            this.lbl_SongOrSinger.AutoSize = true;
            this.lbl_SongOrSinger.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SongOrSinger.BorderColor = System.Drawing.Color.White;
            this.lbl_SongOrSinger.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_SongOrSinger.Location = new System.Drawing.Point(117, 28);
            this.lbl_SongOrSinger.Name = "lbl_SongOrSinger";
            this.lbl_SongOrSinger.Size = new System.Drawing.Size(101, 21);
            this.lbl_SongOrSinger.TabIndex = 1;
            this.lbl_SongOrSinger.Text = "歌曲/歌手名:";
            // 
            // btn_Query
            // 
            this.btn_Query.BackColor = System.Drawing.Color.Transparent;
            this.btn_Query.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Query.DownBack = null;
            this.btn_Query.Location = new System.Drawing.Point(410, 27);
            this.btn_Query.MouseBack = null;
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.NormlBack = null;
            this.btn_Query.Size = new System.Drawing.Size(83, 26);
            this.btn_Query.TabIndex = 2;
            this.btn_Query.Text = "检索";
            this.btn_Query.UseVisualStyleBackColor = false;
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // grb_QueryCondition
            // 
            this.grb_QueryCondition.Controls.Add(this.txt_SongOrSinger);
            this.grb_QueryCondition.Controls.Add(this.btn_Query);
            this.grb_QueryCondition.Controls.Add(this.lbl_SongOrSinger);
            this.grb_QueryCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.grb_QueryCondition.Location = new System.Drawing.Point(0, 0);
            this.grb_QueryCondition.Name = "grb_QueryCondition";
            this.grb_QueryCondition.Size = new System.Drawing.Size(647, 68);
            this.grb_QueryCondition.TabIndex = 3;
            this.grb_QueryCondition.TabStop = false;
            this.grb_QueryCondition.Text = "检索条件";
            // 
            // txt_SongOrSinger
            // 
            this.txt_SongOrSinger.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_SongOrSinger.Location = new System.Drawing.Point(224, 25);
            this.txt_SongOrSinger.Name = "txt_SongOrSinger";
            this.txt_SongOrSinger.Size = new System.Drawing.Size(176, 29);
            this.txt_SongOrSinger.TabIndex = 3;
            this.txt_SongOrSinger.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SongOrSinger_KeyDown);
            // 
            // dgv_Songs
            // 
            this.dgv_Songs.AllowUserToAddRows = false;
            this.dgv_Songs.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.dgv_Songs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Songs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Songs.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_Songs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Songs.ColumnFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgv_Songs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Songs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Songs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Songs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.songName,
            this.artist,
            this.albumPic,
            this.albumPic120,
            this.musicRid});
            this.dgv_Songs.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_Songs.ContextMenuStrip = this.menu;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Songs.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Songs.EnableHeadersVisualStyles = false;
            this.dgv_Songs.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgv_Songs.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgv_Songs.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_Songs.Location = new System.Drawing.Point(0, 68);
            this.dgv_Songs.MultiSelect = false;
            this.dgv_Songs.Name = "dgv_Songs";
            this.dgv_Songs.ReadOnly = true;
            this.dgv_Songs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Songs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_Songs.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Songs.RowTemplate.Height = 23;
            this.dgv_Songs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Songs.Size = new System.Drawing.Size(647, 484);
            this.dgv_Songs.TabIndex = 4;
            this.dgv_Songs.TitleBack = null;
            this.dgv_Songs.TitleBackColorBegin = System.Drawing.Color.White;
            this.dgv_Songs.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            this.dgv_Songs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Songs_CellContentClick);
            this.dgv_Songs.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Songs_CellMouseDown);
            // 
            // songName
            // 
            this.songName.DataPropertyName = "songName";
            this.songName.FillWeight = 93.27411F;
            this.songName.HeaderText = "歌曲名称";
            this.songName.Name = "songName";
            this.songName.ReadOnly = true;
            // 
            // artist
            // 
            this.artist.DataPropertyName = "artist";
            this.artist.FillWeight = 93.27411F;
            this.artist.HeaderText = "歌手";
            this.artist.Name = "artist";
            this.artist.ReadOnly = true;
            // 
            // albumPic
            // 
            this.albumPic.DataPropertyName = "albumPic";
            this.albumPic.FillWeight = 93.27411F;
            this.albumPic.HeaderText = "歌手图片";
            this.albumPic.Name = "albumPic";
            this.albumPic.ReadOnly = true;
            this.albumPic.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.albumPic.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // albumPic120
            // 
            this.albumPic120.DataPropertyName = "albumPic120";
            this.albumPic120.FillWeight = 93.27411F;
            this.albumPic120.HeaderText = "专辑图片";
            this.albumPic120.Name = "albumPic120";
            this.albumPic120.ReadOnly = true;
            this.albumPic120.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.albumPic120.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // musicRid
            // 
            this.musicRid.DataPropertyName = "musicRid";
            this.musicRid.HeaderText = "歌曲Id";
            this.musicRid.Name = "musicRid";
            this.musicRid.ReadOnly = true;
            this.musicRid.Visible = false;
            // 
            // menu
            // 
            this.menu.Arrow = System.Drawing.Color.Black;
            this.menu.Back = System.Drawing.Color.White;
            this.menu.BackRadius = 4;
            this.menu.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.menu.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.menu.Fore = System.Drawing.Color.Black;
            this.menu.HoverFore = System.Drawing.Color.White;
            this.menu.ItemAnamorphosis = true;
            this.menu.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menu.ItemBorderShow = true;
            this.menu.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menu.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menu.ItemRadius = 4;
            this.menu.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBtn_DownLoad,
            this.menuBtn_CopyDownLoadUrl});
            this.menu.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menu.Name = "menu";
            this.menu.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.menu.Size = new System.Drawing.Size(149, 48);
            this.menu.SkinAllColor = true;
            this.menu.TitleAnamorphosis = true;
            this.menu.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.menu.TitleRadius = 4;
            this.menu.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // menuBtn_DownLoad
            // 
            this.menuBtn_DownLoad.Name = "menuBtn_DownLoad";
            this.menuBtn_DownLoad.Size = new System.Drawing.Size(148, 22);
            this.menuBtn_DownLoad.Text = "下载";
            this.menuBtn_DownLoad.Click += new System.EventHandler(this.menuBtn_DownLoad_Click);
            // 
            // menuBtn_CopyDownLoadUrl
            // 
            this.menuBtn_CopyDownLoadUrl.Name = "menuBtn_CopyDownLoadUrl";
            this.menuBtn_CopyDownLoadUrl.Size = new System.Drawing.Size(148, 22);
            this.menuBtn_CopyDownLoadUrl.Text = "复制下载链接";
            this.menuBtn_CopyDownLoadUrl.Click += new System.EventHandler(this.menuBtn_CopyDownLoadUrl_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pro_QueryProgress,
            this.lbl_QueryProgress,
            this.lbl_saveFilePath});
            this.statusStrip1.Location = new System.Drawing.Point(0, 555);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(647, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pro_QueryProgress
            // 
            this.pro_QueryProgress.Name = "pro_QueryProgress";
            this.pro_QueryProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // lbl_QueryProgress
            // 
            this.lbl_QueryProgress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_QueryProgress.Name = "lbl_QueryProgress";
            this.lbl_QueryProgress.Size = new System.Drawing.Size(56, 17);
            this.lbl_QueryProgress.Text = "查询完毕";
            // 
            // lbl_saveFilePath
            // 
            this.lbl_saveFilePath.IsLink = true;
            this.lbl_saveFilePath.Name = "lbl_saveFilePath";
            this.lbl_saveFilePath.Size = new System.Drawing.Size(0, 17);
            this.lbl_saveFilePath.Click += new System.EventHandler(this.lbl_saveFilePath_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 577);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgv_Songs);
            this.Controls.Add(this.grb_QueryCondition);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(663, 616);
            this.MinimumSize = new System.Drawing.Size(663, 616);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicDownLoad";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grb_QueryCondition.ResumeLayout(false);
            this.grb_QueryCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Songs)).EndInit();
            this.menu.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinControl.SkinLabel lbl_SongOrSinger;
        private CCWin.SkinControl.SkinButton btn_Query;
        private System.Windows.Forms.GroupBox grb_QueryCondition;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar pro_QueryProgress;
        private System.Windows.Forms.ToolStripStatusLabel lbl_QueryProgress;
        private CCWin.SkinControl.SkinContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuBtn_DownLoad;
        private System.Windows.Forms.ToolStripMenuItem menuBtn_CopyDownLoadUrl;
        private CCWin.SkinControl.SkinDataGridView dgv_Songs;
        private System.Windows.Forms.TextBox txt_SongOrSinger;
        private System.Windows.Forms.DataGridViewTextBoxColumn songName;
        private System.Windows.Forms.DataGridViewTextBoxColumn artist;
        private System.Windows.Forms.DataGridViewLinkColumn albumPic;
        private System.Windows.Forms.DataGridViewLinkColumn albumPic120;
        private System.Windows.Forms.DataGridViewTextBoxColumn musicRid;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_Music;
        private System.Windows.Forms.ToolStripStatusLabel lbl_saveFilePath;
    }
}


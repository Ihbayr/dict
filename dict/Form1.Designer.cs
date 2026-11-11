namespace dict
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tblTop = new TableLayoutPanel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblLang = new Label();
            cmbLang = new ComboBox();
            tblCenter = new TableLayoutPanel();
            lblWordsDb = new Label();
            lblSavedDb = new Label();
            gridWords = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colEn = new DataGridViewTextBoxColumn();
            colMn = new DataGridViewTextBoxColumn();
            colRu = new DataGridViewTextBoxColumn();
            gridSaved = new DataGridView();
            colSaved = new DataGridViewTextBoxColumn();
            pnlBottom = new Panel();
            flowButtons = new FlowLayoutPanel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDel = new Button();
            btnClear = new Button();
            btnSave = new Button();
            tblInputs = new TableLayoutPanel();
            lblEn = new Label();
            txtEn = new TextBox();
            lblMn = new Label();
            txtMn = new TextBox();
            lblRu = new Label();
            txtRu = new TextBox();
            statusStrip = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            tblTop.SuspendLayout();
            tblCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridWords).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridSaved).BeginInit();
            pnlBottom.SuspendLayout();
            flowButtons.SuspendLayout();
            tblInputs.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // tblTop
            // 
            tblTop.ColumnCount = 4;
            tblTop.ColumnStyles.Add(new ColumnStyle());
            tblTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblTop.ColumnStyles.Add(new ColumnStyle());
            tblTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tblTop.Controls.Add(lblSearch, 0, 0);
            tblTop.Controls.Add(txtSearch, 1, 0);
            tblTop.Controls.Add(lblLang, 2, 0);
            tblTop.Controls.Add(cmbLang, 3, 0);
            tblTop.Dock = DockStyle.Top;
            tblTop.Location = new Point(0, 0);
            tblTop.Name = "tblTop";
            tblTop.Padding = new Padding(16, 14, 16, 6);
            tblTop.RowCount = 1;
            tblTop.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblTop.Size = new Size(1348, 64);
            tblTop.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.Anchor = AnchorStyles.Left;
            lblSearch.AutoSize = true;
            lblSearch.ForeColor = Color.FromArgb(120, 120, 120);
            lblSearch.Location = new Point(19, 17);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(81, 37);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Хайх:";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 11F);
            txtSearch.Location = new Point(109, 17);
            txtSearch.Margin = new Padding(6, 3, 20, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Хайх үг...";
            txtSearch.Size = new Size(982, 47);
            txtSearch.TabIndex = 0;
            // 
            // lblLang
            // 
            lblLang.Anchor = AnchorStyles.Left;
            lblLang.AutoSize = true;
            lblLang.ForeColor = Color.FromArgb(120, 120, 120);
            lblLang.Location = new Point(1114, 17);
            lblLang.Name = "lblLang";
            lblLang.Size = new Size(65, 37);
            lblLang.TabIndex = 1;
            lblLang.Text = "Хэл:";
            // 
            // cmbLang
            // 
            cmbLang.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbLang.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLang.Font = new Font("Segoe UI", 11F);
            cmbLang.FormattingEnabled = true;
            cmbLang.Items.AddRange(new object[] { "Бүгд", "Англи", "Монгол", "Орос" });
            cmbLang.Location = new Point(1188, 17);
            cmbLang.Margin = new Padding(6, 3, 0, 3);
            cmbLang.Name = "cmbLang";
            cmbLang.Size = new Size(144, 48);
            cmbLang.TabIndex = 1;
            // 
            // tblCenter
            // 
            tblCenter.ColumnCount = 2;
            tblCenter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68F));
            tblCenter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32F));
            tblCenter.Controls.Add(lblWordsDb, 0, 0);
            tblCenter.Controls.Add(lblSavedDb, 1, 0);
            tblCenter.Controls.Add(gridWords, 0, 1);
            tblCenter.Controls.Add(gridSaved, 1, 1);
            tblCenter.Dock = DockStyle.Fill;
            tblCenter.Location = new Point(0, 64);
            tblCenter.Name = "tblCenter";
            tblCenter.Padding = new Padding(16, 4, 16, 8);
            tblCenter.RowCount = 2;
            tblCenter.RowStyles.Add(new RowStyle());
            tblCenter.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblCenter.Size = new Size(1348, 512);
            tblCenter.TabIndex = 1;
            // 
            // lblWordsDb
            // 
            lblWordsDb.AutoSize = true;
            lblWordsDb.Font = new Font("Segoe UI", 9F);
            lblWordsDb.ForeColor = Color.FromArgb(120, 120, 120);
            lblWordsDb.Location = new Point(16, 4);
            lblWordsDb.Margin = new Padding(0, 0, 0, 6);
            lblWordsDb.Name = "lblWordsDb";
            lblWordsDb.Size = new Size(202, 32);
            lblWordsDb.TabIndex = 0;
            lblWordsDb.Text = "🗄  toli.db · words";
            // 
            // lblSavedDb
            // 
            lblSavedDb.AutoSize = true;
            lblSavedDb.Font = new Font("Segoe UI", 9F);
            lblSavedDb.ForeColor = Color.FromArgb(120, 120, 120);
            lblSavedDb.Location = new Point(922, 4);
            lblSavedDb.Margin = new Padding(12, 0, 0, 6);
            lblSavedDb.Name = "lblSavedDb";
            lblSavedDb.Size = new Size(300, 32);
            lblSavedDb.TabIndex = 1;
            lblSavedDb.Text = "🗄  saved.db · saved_words";
            // 
            // gridWords
            // 
            gridWords.AllowUserToAddRows = false;
            gridWords.AllowUserToDeleteRows = false;
            gridWords.AllowUserToResizeRows = false;
            gridWords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridWords.BackgroundColor = Color.White;
            gridWords.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle1.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(40, 40, 40);
            gridWords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridWords.ColumnHeadersHeight = 34;
            gridWords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridWords.Columns.AddRange(new DataGridViewColumn[] { colNo, colEn, colMn, colRu });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridWords.DefaultCellStyle = dataGridViewCellStyle2;
            gridWords.Dock = DockStyle.Fill;
            gridWords.EnableHeadersVisualStyles = false;
            gridWords.GridColor = Color.FromArgb(222, 226, 230);
            gridWords.Location = new Point(16, 42);
            gridWords.Margin = new Padding(0);
            gridWords.MultiSelect = false;
            gridWords.Name = "gridWords";
            gridWords.ReadOnly = true;
            gridWords.RowHeadersVisible = false;
            gridWords.RowHeadersWidth = 82;
            gridWords.RowTemplate.Height = 32;
            gridWords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridWords.Size = new Size(894, 462);
            gridWords.TabIndex = 0;
            // 
            // colNo
            // 
            colNo.FillWeight = 8F;
            colNo.HeaderText = "№";
            colNo.MinimumWidth = 10;
            colNo.Name = "colNo";
            colNo.ReadOnly = true;
            // 
            // colEn
            // 
            colEn.FillWeight = 30F;
            colEn.HeaderText = "Англи";
            colEn.MinimumWidth = 10;
            colEn.Name = "colEn";
            colEn.ReadOnly = true;
            // 
            // colMn
            // 
            colMn.FillWeight = 32F;
            colMn.HeaderText = "Монгол";
            colMn.MinimumWidth = 10;
            colMn.Name = "colMn";
            colMn.ReadOnly = true;
            // 
            // colRu
            // 
            colRu.FillWeight = 30F;
            colRu.HeaderText = "Орос";
            colRu.MinimumWidth = 10;
            colRu.Name = "colRu";
            colRu.ReadOnly = true;
            // 
            // gridSaved
            // 
            gridSaved.AllowUserToAddRows = false;
            gridSaved.AllowUserToDeleteRows = false;
            gridSaved.AllowUserToResizeRows = false;
            gridSaved.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridSaved.BackgroundColor = Color.White;
            gridSaved.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(200, 230, 201);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(27, 94, 32);
            dataGridViewCellStyle3.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(200, 230, 201);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(27, 94, 32);
            gridSaved.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            gridSaved.ColumnHeadersHeight = 34;
            gridSaved.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridSaved.Columns.AddRange(new DataGridViewColumn[] { colSaved });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            gridSaved.DefaultCellStyle = dataGridViewCellStyle4;
            gridSaved.Dock = DockStyle.Fill;
            gridSaved.EnableHeadersVisualStyles = false;
            gridSaved.GridColor = Color.FromArgb(222, 226, 230);
            gridSaved.Location = new Point(922, 42);
            gridSaved.Margin = new Padding(12, 0, 0, 0);
            gridSaved.MultiSelect = false;
            gridSaved.Name = "gridSaved";
            gridSaved.ReadOnly = true;
            gridSaved.RowHeadersVisible = false;
            gridSaved.RowHeadersWidth = 82;
            gridSaved.RowTemplate.Height = 32;
            gridSaved.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridSaved.Size = new Size(410, 462);
            gridSaved.TabIndex = 1;
            // 
            // colSaved
            // 
            colSaved.HeaderText = "Санасан үг";
            colSaved.MinimumWidth = 10;
            colSaved.Name = "colSaved";
            colSaved.ReadOnly = true;
            // 
            // pnlBottom
            // 
            pnlBottom.Controls.Add(flowButtons);
            pnlBottom.Controls.Add(tblInputs);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 576);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(1348, 124);
            pnlBottom.TabIndex = 2;
            // 
            // flowButtons
            // 
            flowButtons.Controls.Add(btnAdd);
            flowButtons.Controls.Add(btnEdit);
            flowButtons.Controls.Add(btnDel);
            flowButtons.Controls.Add(btnClear);
            flowButtons.Controls.Add(btnSave);
            flowButtons.Dock = DockStyle.Fill;
            flowButtons.Location = new Point(0, 56);
            flowButtons.Name = "flowButtons";
            flowButtons.Padding = new Padding(16, 4, 16, 0);
            flowButtons.Size = new Size(1348, 68);
            flowButtons.TabIndex = 1;
            flowButtons.WrapContents = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(200, 204, 208);
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(244, 246, 248);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.FromArgb(40, 40, 40);
            btnAdd.Location = new Point(16, 4);
            btnAdd.Margin = new Padding(0, 0, 8, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(118, 38);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "＋  Нэмэх";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.White;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderColor = Color.FromArgb(200, 204, 208);
            btnEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(244, 246, 248);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.FromArgb(40, 40, 40);
            btnEdit.Location = new Point(142, 4);
            btnEdit.Margin = new Padding(0, 0, 8, 0);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(118, 38);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "✎  Засах";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.White;
            btnDel.Cursor = Cursors.Hand;
            btnDel.FlatAppearance.BorderColor = Color.FromArgb(200, 204, 208);
            btnDel.FlatAppearance.MouseOverBackColor = Color.FromArgb(244, 246, 248);
            btnDel.FlatStyle = FlatStyle.Flat;
            btnDel.ForeColor = Color.FromArgb(40, 40, 40);
            btnDel.Location = new Point(268, 4);
            btnDel.Margin = new Padding(0, 0, 8, 0);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(118, 38);
            btnDel.TabIndex = 2;
            btnDel.Text = "✖  Устгах";
            btnDel.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(200, 204, 208);
            btnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(244, 246, 248);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.FromArgb(40, 40, 40);
            btnClear.Location = new Point(394, 4);
            btnClear.Margin = new Padding(0, 0, 8, 0);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(118, 38);
            btnClear.TabIndex = 3;
            btnClear.Text = "⟳  Цэвэрлэх";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(46, 160, 67);
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(244, 250, 245);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.FromArgb(46, 160, 67);
            btnSave.Location = new Point(520, 4);
            btnSave.Margin = new Padding(0, 0, 8, 0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(118, 38);
            btnSave.TabIndex = 4;
            btnSave.Text = "💾  Санах";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // tblInputs
            // 
            tblInputs.ColumnCount = 6;
            tblInputs.ColumnStyles.Add(new ColumnStyle());
            tblInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3F));
            tblInputs.ColumnStyles.Add(new ColumnStyle());
            tblInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3F));
            tblInputs.ColumnStyles.Add(new ColumnStyle());
            tblInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.4F));
            tblInputs.Controls.Add(lblEn, 0, 0);
            tblInputs.Controls.Add(txtEn, 1, 0);
            tblInputs.Controls.Add(lblMn, 2, 0);
            tblInputs.Controls.Add(txtMn, 3, 0);
            tblInputs.Controls.Add(lblRu, 4, 0);
            tblInputs.Controls.Add(txtRu, 5, 0);
            tblInputs.Dock = DockStyle.Top;
            tblInputs.Location = new Point(0, 0);
            tblInputs.Name = "tblInputs";
            tblInputs.Padding = new Padding(16, 10, 16, 6);
            tblInputs.RowCount = 1;
            tblInputs.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblInputs.Size = new Size(1348, 56);
            tblInputs.TabIndex = 0;
            // 
            // lblEn
            // 
            lblEn.Anchor = AnchorStyles.Left;
            lblEn.AutoSize = true;
            lblEn.ForeColor = Color.FromArgb(120, 120, 120);
            lblEn.Location = new Point(19, 11);
            lblEn.Name = "lblEn";
            lblEn.Size = new Size(90, 37);
            lblEn.TabIndex = 0;
            lblEn.Text = "Англи";
            // 
            // txtEn
            // 
            txtEn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtEn.Location = new Point(120, 13);
            txtEn.Margin = new Padding(8, 3, 16, 3);
            txtEn.Name = "txtEn";
            txtEn.Size = new Size(313, 43);
            txtEn.TabIndex = 0;
            // 
            // lblMn
            // 
            lblMn.Anchor = AnchorStyles.Left;
            lblMn.AutoSize = true;
            lblMn.ForeColor = Color.FromArgb(120, 120, 120);
            lblMn.Location = new Point(452, 11);
            lblMn.Name = "lblMn";
            lblMn.Size = new Size(113, 37);
            lblMn.TabIndex = 1;
            lblMn.Text = "Монгол";
            // 
            // txtMn
            // 
            txtMn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMn.Location = new Point(576, 13);
            txtMn.Margin = new Padding(8, 3, 16, 3);
            txtMn.Name = "txtMn";
            txtMn.Size = new Size(313, 43);
            txtMn.TabIndex = 1;
            // 
            // lblRu
            // 
            lblRu.Anchor = AnchorStyles.Left;
            lblRu.AutoSize = true;
            lblRu.ForeColor = Color.FromArgb(120, 120, 120);
            lblRu.Location = new Point(908, 11);
            lblRu.Name = "lblRu";
            lblRu.Size = new Size(81, 37);
            lblRu.TabIndex = 2;
            lblRu.Text = "Орос";
            // 
            // txtRu
            // 
            txtRu.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtRu.Location = new Point(1000, 13);
            txtRu.Margin = new Padding(8, 3, 0, 3);
            txtRu.Name = "txtRu";
            txtRu.Size = new Size(332, 43);
            txtRu.TabIndex = 2;
            // 
            // statusStrip
            // 
            statusStrip.BackColor = Color.White;
            statusStrip.ImageScalingSize = new Size(32, 32);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip.Location = new Point(0, 700);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1348, 42);
            statusStrip.SizingGrip = false;
            statusStrip.TabIndex = 3;
            // 
            // lblStatus
            // 
            lblStatus.ForeColor = Color.FromArgb(120, 120, 120);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(269, 32);
            lblStatus.Text = "Нийт: 10 үг · Санасан: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(192F, 192F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1348, 742);
            Controls.Add(tblCenter);
            Controls.Add(pnlBottom);
            Controls.Add(statusStrip);
            Controls.Add(tblTop);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(780, 520);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Гурван хэлний толь бичиг";
            tblTop.ResumeLayout(false);
            tblTop.PerformLayout();
            tblCenter.ResumeLayout(false);
            tblCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridWords).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridSaved).EndInit();
            pnlBottom.ResumeLayout(false);
            flowButtons.ResumeLayout(false);
            tblInputs.ResumeLayout(false);
            tblInputs.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblTop;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblLang;
        private System.Windows.Forms.ComboBox cmbLang;
        private System.Windows.Forms.TableLayoutPanel tblCenter;
        private System.Windows.Forms.Label lblWordsDb;
        private System.Windows.Forms.Label lblSavedDb;
        private System.Windows.Forms.DataGridView gridWords;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRu;
        private System.Windows.Forms.DataGridView gridSaved;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaved;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.FlowLayoutPanel flowButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel tblInputs;
        private System.Windows.Forms.Label lblEn;
        private System.Windows.Forms.TextBox txtEn;
        private System.Windows.Forms.Label lblMn;
        private System.Windows.Forms.TextBox txtMn;
        private System.Windows.Forms.Label lblRu;
        private System.Windows.Forms.TextBox txtRu;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}
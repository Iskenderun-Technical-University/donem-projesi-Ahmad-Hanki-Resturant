
namespace resturant
{
    partial class Cart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sipariş = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Home = new System.Windows.Forms.Button();
            this.databaseBUT = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.BackToOriginal = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.delete = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 100);
            this.panel1.TabIndex = 1;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(1004, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(17, 17);
            this.close.TabIndex = 10;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseEnter += new System.EventHandler(this.close_MouseEnter);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(339, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tavuk  Günü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display Semil", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(442, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 46);
            this.label2.TabIndex = 4;
            this.label2.Text = "Geri dön";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(12, 257);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1009, 10);
            this.panel2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display Semil", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(356, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 46);
            this.label3.TabIndex = 6;
            this.label3.Text = "Verdiğiniz sipereşler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idd,
            this.Sipariş,
            this.Fiyat,
            this.Adı,
            this.Telefon});
            this.dataGridView1.Location = new System.Drawing.Point(12, 370);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1008, 229);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idd
            // 
            this.idd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idd.HeaderText = "ID";
            this.idd.MinimumWidth = 6;
            this.idd.Name = "idd";
            this.idd.ReadOnly = true;
            this.idd.Width = 50;
            // 
            // Sipariş
            // 
            this.Sipariş.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Sipariş.HeaderText = "Sipariş";
            this.Sipariş.MinimumWidth = 6;
            this.Sipariş.Name = "Sipariş";
            this.Sipariş.ReadOnly = true;
            this.Sipariş.Width = 191;
            // 
            // Fiyat
            // 
            this.Fiyat.HeaderText = "Fiyat";
            this.Fiyat.MinimumWidth = 6;
            this.Fiyat.Name = "Fiyat";
            // 
            // Adı
            // 
            this.Adı.HeaderText = "Adı Soyadı";
            this.Adı.MinimumWidth = 6;
            this.Adı.Name = "Adı";
            // 
            // Telefon
            // 
            this.Telefon.HeaderText = "Telefon No";
            this.Telefon.MinimumWidth = 6;
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // Home
            // 
            this.Home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Home.BackgroundImage")));
            this.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Home.ForeColor = System.Drawing.Color.Red;
            this.Home.Location = new System.Drawing.Point(78, 171);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(865, 79);
            this.Home.TabIndex = 3;
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // databaseBUT
            // 
            this.databaseBUT.AllowAnimations = true;
            this.databaseBUT.AllowMouseEffects = true;
            this.databaseBUT.AllowToggling = false;
            this.databaseBUT.AnimationSpeed = 200;
            this.databaseBUT.AutoGenerateColors = false;
            this.databaseBUT.AutoRoundBorders = true;
            this.databaseBUT.AutoSizeLeftIcon = true;
            this.databaseBUT.AutoSizeRightIcon = true;
            this.databaseBUT.BackColor = System.Drawing.Color.Transparent;
            this.databaseBUT.BackColor1 = System.Drawing.Color.Black;
            this.databaseBUT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("databaseBUT.BackgroundImage")));
            this.databaseBUT.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.databaseBUT.ButtonText = "veritabanında saklanan tüm verileri göster";
            this.databaseBUT.ButtonTextMarginLeft = 0;
            this.databaseBUT.ColorContrastOnClick = 45;
            this.databaseBUT.ColorContrastOnHover = 45;
            this.databaseBUT.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.databaseBUT.CustomizableEdges = borderEdges1;
            this.databaseBUT.DialogResult = System.Windows.Forms.DialogResult.None;
            this.databaseBUT.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.databaseBUT.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.databaseBUT.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.databaseBUT.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.databaseBUT.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databaseBUT.ForeColor = System.Drawing.Color.White;
            this.databaseBUT.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.databaseBUT.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.databaseBUT.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.databaseBUT.IconMarginLeft = 11;
            this.databaseBUT.IconPadding = 10;
            this.databaseBUT.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.databaseBUT.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.databaseBUT.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.databaseBUT.IconSize = 25;
            this.databaseBUT.IdleBorderColor = System.Drawing.Color.Black;
            this.databaseBUT.IdleBorderRadius = 37;
            this.databaseBUT.IdleBorderThickness = 1;
            this.databaseBUT.IdleFillColor = System.Drawing.Color.Black;
            this.databaseBUT.IdleIconLeftImage = null;
            this.databaseBUT.IdleIconRightImage = null;
            this.databaseBUT.IndicateFocus = false;
            this.databaseBUT.Location = new System.Drawing.Point(12, 605);
            this.databaseBUT.Name = "databaseBUT";
            this.databaseBUT.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.databaseBUT.OnDisabledState.BorderRadius = 1;
            this.databaseBUT.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.databaseBUT.OnDisabledState.BorderThickness = 1;
            this.databaseBUT.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.databaseBUT.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.databaseBUT.OnDisabledState.IconLeftImage = null;
            this.databaseBUT.OnDisabledState.IconRightImage = null;
            this.databaseBUT.onHoverState.BorderColor = System.Drawing.Color.White;
            this.databaseBUT.onHoverState.BorderRadius = 1;
            this.databaseBUT.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.databaseBUT.onHoverState.BorderThickness = 1;
            this.databaseBUT.onHoverState.FillColor = System.Drawing.Color.Black;
            this.databaseBUT.onHoverState.ForeColor = System.Drawing.Color.White;
            this.databaseBUT.onHoverState.IconLeftImage = null;
            this.databaseBUT.onHoverState.IconRightImage = null;
            this.databaseBUT.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.databaseBUT.OnIdleState.BorderRadius = 1;
            this.databaseBUT.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.databaseBUT.OnIdleState.BorderThickness = 1;
            this.databaseBUT.OnIdleState.FillColor = System.Drawing.Color.Black;
            this.databaseBUT.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.databaseBUT.OnIdleState.IconLeftImage = null;
            this.databaseBUT.OnIdleState.IconRightImage = null;
            this.databaseBUT.OnPressedState.BorderColor = System.Drawing.Color.Red;
            this.databaseBUT.OnPressedState.BorderRadius = 1;
            this.databaseBUT.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.databaseBUT.OnPressedState.BorderThickness = 1;
            this.databaseBUT.OnPressedState.FillColor = System.Drawing.Color.Black;
            this.databaseBUT.OnPressedState.ForeColor = System.Drawing.Color.Red;
            this.databaseBUT.OnPressedState.IconLeftImage = null;
            this.databaseBUT.OnPressedState.IconRightImage = null;
            this.databaseBUT.Size = new System.Drawing.Size(524, 39);
            this.databaseBUT.TabIndex = 11;
            this.databaseBUT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.databaseBUT.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.databaseBUT.TextMarginLeft = 0;
            this.databaseBUT.TextPadding = new System.Windows.Forms.Padding(0);
            this.databaseBUT.UseDefaultRadiusAndThickness = true;
            this.databaseBUT.Click += new System.EventHandler(this.Side_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 370);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1008, 229);
            this.dataGridView2.TabIndex = 12;
            // 
            // BackToOriginal
            // 
            this.BackToOriginal.AllowAnimations = true;
            this.BackToOriginal.AllowMouseEffects = true;
            this.BackToOriginal.AllowToggling = false;
            this.BackToOriginal.AnimationSpeed = 200;
            this.BackToOriginal.AutoGenerateColors = false;
            this.BackToOriginal.AutoRoundBorders = true;
            this.BackToOriginal.AutoSizeLeftIcon = true;
            this.BackToOriginal.AutoSizeRightIcon = true;
            this.BackToOriginal.BackColor = System.Drawing.Color.Transparent;
            this.BackToOriginal.BackColor1 = System.Drawing.Color.Black;
            this.BackToOriginal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackToOriginal.BackgroundImage")));
            this.BackToOriginal.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BackToOriginal.ButtonText = "orijinal tabloya geri dön";
            this.BackToOriginal.ButtonTextMarginLeft = 0;
            this.BackToOriginal.ColorContrastOnClick = 45;
            this.BackToOriginal.ColorContrastOnHover = 45;
            this.BackToOriginal.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.BackToOriginal.CustomizableEdges = borderEdges2;
            this.BackToOriginal.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BackToOriginal.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BackToOriginal.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BackToOriginal.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BackToOriginal.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BackToOriginal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToOriginal.ForeColor = System.Drawing.Color.White;
            this.BackToOriginal.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BackToOriginal.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BackToOriginal.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BackToOriginal.IconMarginLeft = 11;
            this.BackToOriginal.IconPadding = 10;
            this.BackToOriginal.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BackToOriginal.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BackToOriginal.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BackToOriginal.IconSize = 25;
            this.BackToOriginal.IdleBorderColor = System.Drawing.Color.Black;
            this.BackToOriginal.IdleBorderRadius = 37;
            this.BackToOriginal.IdleBorderThickness = 1;
            this.BackToOriginal.IdleFillColor = System.Drawing.Color.Black;
            this.BackToOriginal.IdleIconLeftImage = null;
            this.BackToOriginal.IdleIconRightImage = null;
            this.BackToOriginal.IndicateFocus = false;
            this.BackToOriginal.Location = new System.Drawing.Point(12, 605);
            this.BackToOriginal.Name = "BackToOriginal";
            this.BackToOriginal.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BackToOriginal.OnDisabledState.BorderRadius = 1;
            this.BackToOriginal.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BackToOriginal.OnDisabledState.BorderThickness = 1;
            this.BackToOriginal.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BackToOriginal.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BackToOriginal.OnDisabledState.IconLeftImage = null;
            this.BackToOriginal.OnDisabledState.IconRightImage = null;
            this.BackToOriginal.onHoverState.BorderColor = System.Drawing.Color.White;
            this.BackToOriginal.onHoverState.BorderRadius = 1;
            this.BackToOriginal.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BackToOriginal.onHoverState.BorderThickness = 1;
            this.BackToOriginal.onHoverState.FillColor = System.Drawing.Color.Black;
            this.BackToOriginal.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BackToOriginal.onHoverState.IconLeftImage = null;
            this.BackToOriginal.onHoverState.IconRightImage = null;
            this.BackToOriginal.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.BackToOriginal.OnIdleState.BorderRadius = 1;
            this.BackToOriginal.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BackToOriginal.OnIdleState.BorderThickness = 1;
            this.BackToOriginal.OnIdleState.FillColor = System.Drawing.Color.Black;
            this.BackToOriginal.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BackToOriginal.OnIdleState.IconLeftImage = null;
            this.BackToOriginal.OnIdleState.IconRightImage = null;
            this.BackToOriginal.OnPressedState.BorderColor = System.Drawing.Color.Red;
            this.BackToOriginal.OnPressedState.BorderRadius = 1;
            this.BackToOriginal.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BackToOriginal.OnPressedState.BorderThickness = 1;
            this.BackToOriginal.OnPressedState.FillColor = System.Drawing.Color.Black;
            this.BackToOriginal.OnPressedState.ForeColor = System.Drawing.Color.Red;
            this.BackToOriginal.OnPressedState.IconLeftImage = null;
            this.BackToOriginal.OnPressedState.IconRightImage = null;
            this.BackToOriginal.Size = new System.Drawing.Size(524, 39);
            this.BackToOriginal.TabIndex = 13;
            this.BackToOriginal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BackToOriginal.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BackToOriginal.TextMarginLeft = 0;
            this.BackToOriginal.TextPadding = new System.Windows.Forms.Padding(0);
            this.BackToOriginal.UseDefaultRadiusAndThickness = true;
            this.BackToOriginal.Click += new System.EventHandler(this.BackToOriginal_Click);
            // 
            // delete
            // 
            this.delete.AllowAnimations = true;
            this.delete.AllowMouseEffects = true;
            this.delete.AllowToggling = false;
            this.delete.AnimationSpeed = 200;
            this.delete.AutoGenerateColors = false;
            this.delete.AutoRoundBorders = true;
            this.delete.AutoSizeLeftIcon = true;
            this.delete.AutoSizeRightIcon = true;
            this.delete.BackColor = System.Drawing.Color.Transparent;
            this.delete.BackColor1 = System.Drawing.Color.Black;
            this.delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete.BackgroundImage")));
            this.delete.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.delete.ButtonText = "Tablodaki tüm satırları sil";
            this.delete.ButtonTextMarginLeft = 0;
            this.delete.ColorContrastOnClick = 45;
            this.delete.ColorContrastOnHover = 45;
            this.delete.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.delete.CustomizableEdges = borderEdges3;
            this.delete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.delete.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.delete.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.delete.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.delete.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.delete.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.delete.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.delete.IconMarginLeft = 11;
            this.delete.IconPadding = 10;
            this.delete.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delete.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.delete.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.delete.IconSize = 25;
            this.delete.IdleBorderColor = System.Drawing.Color.Black;
            this.delete.IdleBorderRadius = 37;
            this.delete.IdleBorderThickness = 1;
            this.delete.IdleFillColor = System.Drawing.Color.Black;
            this.delete.IdleIconLeftImage = null;
            this.delete.IdleIconRightImage = null;
            this.delete.IndicateFocus = false;
            this.delete.Location = new System.Drawing.Point(714, 605);
            this.delete.Name = "delete";
            this.delete.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.delete.OnDisabledState.BorderRadius = 1;
            this.delete.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.delete.OnDisabledState.BorderThickness = 1;
            this.delete.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.delete.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.delete.OnDisabledState.IconLeftImage = null;
            this.delete.OnDisabledState.IconRightImage = null;
            this.delete.onHoverState.BorderColor = System.Drawing.Color.White;
            this.delete.onHoverState.BorderRadius = 1;
            this.delete.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.delete.onHoverState.BorderThickness = 1;
            this.delete.onHoverState.FillColor = System.Drawing.Color.Black;
            this.delete.onHoverState.ForeColor = System.Drawing.Color.White;
            this.delete.onHoverState.IconLeftImage = null;
            this.delete.onHoverState.IconRightImage = null;
            this.delete.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.delete.OnIdleState.BorderRadius = 1;
            this.delete.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.delete.OnIdleState.BorderThickness = 1;
            this.delete.OnIdleState.FillColor = System.Drawing.Color.Black;
            this.delete.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.delete.OnIdleState.IconLeftImage = null;
            this.delete.OnIdleState.IconRightImage = null;
            this.delete.OnPressedState.BorderColor = System.Drawing.Color.Red;
            this.delete.OnPressedState.BorderRadius = 1;
            this.delete.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.delete.OnPressedState.BorderThickness = 1;
            this.delete.OnPressedState.FillColor = System.Drawing.Color.Black;
            this.delete.OnPressedState.ForeColor = System.Drawing.Color.Red;
            this.delete.OnPressedState.IconLeftImage = null;
            this.delete.OnPressedState.IconRightImage = null;
            this.delete.Size = new System.Drawing.Size(306, 39);
            this.delete.TabIndex = 14;
            this.delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delete.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.delete.TextMarginLeft = 0;
            this.delete.TextPadding = new System.Windows.Forms.Padding(0);
            this.delete.UseDefaultRadiusAndThickness = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(450, 347);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 17);
            this.label.TabIndex = 15;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1033, 745);
            this.Controls.Add(this.label);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.BackToOriginal);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.databaseBUT);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Name = "Cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sepet";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.DataGridViewTextBoxColumn idd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sipariş;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adı;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton databaseBUT;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BackToOriginal;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton delete;
        private System.Windows.Forms.Label label;
    }
}
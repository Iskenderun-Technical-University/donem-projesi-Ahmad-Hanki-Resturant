
namespace resturant
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.view = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sipariş = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 100);
            this.panel1.TabIndex = 1;
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
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
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
            // view
            // 
            this.view.AllowAnimations = true;
            this.view.AllowMouseEffects = true;
            this.view.AllowToggling = false;
            this.view.AnimationSpeed = 200;
            this.view.AutoGenerateColors = false;
            this.view.AutoRoundBorders = false;
            this.view.AutoSizeLeftIcon = true;
            this.view.AutoSizeRightIcon = true;
            this.view.BackColor = System.Drawing.Color.Transparent;
            this.view.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.view.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("view.BackgroundImage")));
            this.view.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.view.ButtonText = "sipariş göster";
            this.view.ButtonTextMarginLeft = 0;
            this.view.ColorContrastOnClick = 45;
            this.view.ColorContrastOnHover = 45;
            this.view.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.view.CustomizableEdges = borderEdges2;
            this.view.DialogResult = System.Windows.Forms.DialogResult.None;
            this.view.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.view.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.view.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.view.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.view.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.view.ForeColor = System.Drawing.Color.White;
            this.view.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.view.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.view.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.view.IconMarginLeft = 11;
            this.view.IconPadding = 10;
            this.view.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.view.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.view.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.view.IconSize = 25;
            this.view.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.view.IdleBorderRadius = 1;
            this.view.IdleBorderThickness = 1;
            this.view.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.view.IdleIconLeftImage = null;
            this.view.IdleIconRightImage = null;
            this.view.IndicateFocus = false;
            this.view.Location = new System.Drawing.Point(13, 634);
            this.view.Name = "view";
            this.view.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.view.OnDisabledState.BorderRadius = 1;
            this.view.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.view.OnDisabledState.BorderThickness = 1;
            this.view.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.view.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.view.OnDisabledState.IconLeftImage = null;
            this.view.OnDisabledState.IconRightImage = null;
            this.view.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.view.onHoverState.BorderRadius = 1;
            this.view.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.view.onHoverState.BorderThickness = 1;
            this.view.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.view.onHoverState.ForeColor = System.Drawing.Color.White;
            this.view.onHoverState.IconLeftImage = null;
            this.view.onHoverState.IconRightImage = null;
            this.view.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.view.OnIdleState.BorderRadius = 1;
            this.view.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.view.OnIdleState.BorderThickness = 1;
            this.view.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.view.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.view.OnIdleState.IconLeftImage = null;
            this.view.OnIdleState.IconRightImage = null;
            this.view.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.view.OnPressedState.BorderRadius = 1;
            this.view.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.view.OnPressedState.BorderThickness = 1;
            this.view.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.view.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.view.OnPressedState.IconLeftImage = null;
            this.view.OnPressedState.IconRightImage = null;
            this.view.Size = new System.Drawing.Size(150, 69);
            this.view.TabIndex = 8;
            this.view.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.view.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.view.TextMarginLeft = 0;
            this.view.TextPadding = new System.Windows.Forms.Padding(0);
            this.view.UseDefaultRadiusAndThickness = true;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Sipariş,
            this.Fiyat});
            this.dataGridView1.Location = new System.Drawing.Point(13, 326);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1008, 277);
            this.dataGridView1.TabIndex = 9;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 150;
            // 
            // Sipariş
            // 
            this.Sipariş.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sipariş.HeaderText = "Sipariş";
            this.Sipariş.MinimumWidth = 6;
            this.Sipariş.Name = "Sipariş";
            this.Sipariş.ReadOnly = true;
            // 
            // Fiyat
            // 
            this.Fiyat.HeaderText = "Fiyat";
            this.Fiyat.MinimumWidth = 6;
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.ReadOnly = true;
            this.Fiyat.Width = 150;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1033, 745);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.view);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton view;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sipariş;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiyat;
    }
}
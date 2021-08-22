
namespace WindowsFormsApp4
{
    partial class Issue_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Issue_Info));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.IssueImage = new System.Windows.Forms.PictureBox();
            this.Heading = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UserIDBox = new Bunifu.Framework.BunifuCustomTextbox();
            this.UserAmountBox = new Bunifu.Framework.BunifuCustomTextbox();
            this.FndBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label5 = new System.Windows.Forms.Label();
            this.LoaderImage = new System.Windows.Forms.PictureBox();
            this.IssueType = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.IssueImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoaderImage)).BeginInit();
            this.SuspendLayout();
            // 
            // IssueImage
            // 
            this.IssueImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IssueImage.Location = new System.Drawing.Point(27, 64);
            this.IssueImage.Name = "IssueImage";
            this.IssueImage.Size = new System.Drawing.Size(193, 182);
            this.IssueImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IssueImage.TabIndex = 0;
            this.IssueImage.TabStop = false;
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.Location = new System.Drawing.Point(259, 39);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(126, 19);
            this.Heading.TabIndex = 2;
            this.Heading.Text = "Issue Statement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Add Fund to Issue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(261, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "User ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(256, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Amount";
            // 
            // UserIDBox
            // 
            this.UserIDBox.BorderColor = System.Drawing.Color.SeaGreen;
            this.UserIDBox.Location = new System.Drawing.Point(326, 201);
            this.UserIDBox.Name = "UserIDBox";
            this.UserIDBox.Size = new System.Drawing.Size(149, 20);
            this.UserIDBox.TabIndex = 8;
            // 
            // UserAmountBox
            // 
            this.UserAmountBox.BorderColor = System.Drawing.Color.SeaGreen;
            this.UserAmountBox.Location = new System.Drawing.Point(326, 232);
            this.UserAmountBox.Name = "UserAmountBox";
            this.UserAmountBox.Size = new System.Drawing.Size(149, 20);
            this.UserAmountBox.TabIndex = 9;
            // 
            // FndBtn
            // 
            this.FndBtn.AllowToggling = false;
            this.FndBtn.AnimationSpeed = 200;
            this.FndBtn.AutoGenerateColors = false;
            this.FndBtn.BackColor = System.Drawing.Color.Transparent;
            this.FndBtn.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.FndBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FndBtn.BackgroundImage")));
            this.FndBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.FndBtn.ButtonText = "Add Fund";
            this.FndBtn.ButtonTextMarginLeft = 0;
            this.FndBtn.ColorContrastOnClick = 45;
            this.FndBtn.ColorContrastOnHover = 45;
            this.FndBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.FndBtn.CustomizableEdges = borderEdges3;
            this.FndBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.FndBtn.DisabledBorderColor = System.Drawing.Color.Empty;
            this.FndBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.FndBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.FndBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.FndBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.FndBtn.ForeColor = System.Drawing.Color.White;
            this.FndBtn.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.FndBtn.IconMarginLeft = 11;
            this.FndBtn.IconPadding = 10;
            this.FndBtn.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.FndBtn.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.FndBtn.IdleBorderRadius = 3;
            this.FndBtn.IdleBorderThickness = 1;
            this.FndBtn.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.FndBtn.IdleIconLeftImage = null;
            this.FndBtn.IdleIconRightImage = null;
            this.FndBtn.IndicateFocus = false;
            this.FndBtn.Location = new System.Drawing.Point(481, 201);
            this.FndBtn.Name = "FndBtn";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties5.BorderRadius = 3;
            stateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties5.BorderThickness = 1;
            stateProperties5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties5.ForeColor = System.Drawing.Color.White;
            stateProperties5.IconLeftImage = null;
            stateProperties5.IconRightImage = null;
            this.FndBtn.onHoverState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.BorderRadius = 3;
            stateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties6.BorderThickness = 1;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.ForeColor = System.Drawing.Color.White;
            stateProperties6.IconLeftImage = null;
            stateProperties6.IconRightImage = null;
            this.FndBtn.OnPressedState = stateProperties6;
            this.FndBtn.Size = new System.Drawing.Size(106, 45);
            this.FndBtn.TabIndex = 10;
            this.FndBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FndBtn.TextMarginLeft = 0;
            this.FndBtn.UseDefaultRadiusAndThickness = true;
            this.FndBtn.Click += new System.EventHandler(this.FndBtn_Click);
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.Red;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "Delete This Issue";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges4;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.Empty;
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.IdleBorderRadius = 3;
            this.bunifuButton1.IdleBorderThickness = 1;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.Red;
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(12, 288);
            this.bunifuButton1.Name = "bunifuButton1";
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.BorderRadius = 3;
            stateProperties7.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties7.BorderThickness = 1;
            stateProperties7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.ForeColor = System.Drawing.Color.White;
            stateProperties7.IconLeftImage = null;
            stateProperties7.IconRightImage = null;
            this.bunifuButton1.onHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties8.BorderRadius = 3;
            stateProperties8.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties8.BorderThickness = 1;
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties8.ForeColor = System.Drawing.Color.White;
            stateProperties8.IconLeftImage = null;
            stateProperties8.IconRightImage = null;
            this.bunifuButton1.OnPressedState = stateProperties8;
            this.bunifuButton1.Size = new System.Drawing.Size(122, 45);
            this.bunifuButton1.TabIndex = 11;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Issue Image";
            // 
            // LoaderImage
            // 
            this.LoaderImage.Image = ((System.Drawing.Image)(resources.GetObject("LoaderImage.Image")));
            this.LoaderImage.Location = new System.Drawing.Point(562, 12);
            this.LoaderImage.Name = "LoaderImage";
            this.LoaderImage.Size = new System.Drawing.Size(50, 50);
            this.LoaderImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoaderImage.TabIndex = 13;
            this.LoaderImage.TabStop = false;
            // 
            // IssueType
            // 
            this.IssueType.AutoEllipsis = false;
            this.IssueType.AutoSize = false;
            this.IssueType.AutoSizeHeightOnly = true;
            this.IssueType.CursorType = null;
            this.IssueType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueType.Location = new System.Drawing.Point(260, 68);
            this.IssueType.Name = "IssueType";
            this.IssueType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IssueType.Size = new System.Drawing.Size(322, 23);
            this.IssueType.TabIndex = 14;
            this.IssueType.Text = "bunifuLabel1";
            this.IssueType.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.IssueType.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Issue_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 345);
            this.Controls.Add(this.IssueType);
            this.Controls.Add(this.LoaderImage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bunifuButton1);
            this.Controls.Add(this.FndBtn);
            this.Controls.Add(this.UserAmountBox);
            this.Controls.Add(this.UserIDBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Heading);
            this.Controls.Add(this.IssueImage);
            this.Name = "Issue_Info";
            this.Text = "Issue_Info";
            this.Load += new System.EventHandler(this.Issue_Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IssueImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoaderImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox IssueImage;
        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.BunifuCustomTextbox UserIDBox;
        private Bunifu.Framework.BunifuCustomTextbox UserAmountBox;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton FndBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox LoaderImage;
        private Bunifu.UI.WinForms.BunifuLabel IssueType;
    }
}
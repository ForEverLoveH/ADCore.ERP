using System.ComponentModel;

namespace AD.Core.DepartMentManager.DepartMent.DepartManagerWindow
{
    partial class PersonDepartMentManagerWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            HZH_Controls.Controls.NavigationMenuItem navigationMenuItem1 = new HZH_Controls.Controls.NavigationMenuItem();
            HZH_Controls.Controls.NavigationMenuItem navigationMenuItem2 = new HZH_Controls.Controls.NavigationMenuItem();
            HZH_Controls.Controls.NavigationMenuItem navigationMenuItem3 = new HZH_Controls.Controls.NavigationMenuItem();
            HZH_Controls.Controls.NavigationMenuItem navigationMenuItem4 = new HZH_Controls.Controls.NavigationMenuItem();
            HZH_Controls.Controls.NavigationMenuItem navigationMenuItem5 = new HZH_Controls.Controls.NavigationMenuItem();
            this.uiTitlePanel1 = new Sunny.UI.UITitlePanel();
            this.uiTabControl1 = new Sunny.UI.UITabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ucNavigationMenu1 = new HZH_Controls.Controls.UCNavigationMenu();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.uiTitlePanel1.SuspendLayout();
            this.uiTabControl1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.Controls.Add(this.uiTabControl1);
            this.uiTitlePanel1.Controls.Add(this.ucNavigationMenu1);
            this.uiTitlePanel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel1.Location = new System.Drawing.Point(4, 4);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.uiTitlePanel1.ShowText = false;
            this.uiTitlePanel1.Size = new System.Drawing.Size(1410, 787);
            this.uiTitlePanel1.TabIndex = 0;
            this.uiTitlePanel1.Text = "人事部信息";
            this.uiTitlePanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTabControl1
            // 
            this.uiTabControl1.Controls.Add(this.tabPage1);
            this.uiTabControl1.Controls.Add(this.tabPage2);
            this.uiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTabControl1.ItemSize = new System.Drawing.Size(150, 40);
            this.uiTabControl1.Location = new System.Drawing.Point(4, 86);
            this.uiTabControl1.MainPage = "";
            this.uiTabControl1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.uiTabControl1.Name = "uiTabControl1";
            this.uiTabControl1.SelectedIndex = 0;
            this.uiTabControl1.Size = new System.Drawing.Size(1403, 698);
            this.uiTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControl1.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiTabControl1.TabIndex = 1;
            this.uiTabControl1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTabControl1.SelectedIndexChanged += new System.EventHandler(this.uiTabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(0, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1403, 658);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "个人信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(0, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1403, 658);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "账号设置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ucNavigationMenu1
            // 
            this.ucNavigationMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.ucNavigationMenu1.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucNavigationMenu1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            navigationMenuItem1.AnchorRight = false;
            navigationMenuItem1.DataSource = null;
            navigationMenuItem1.HasSplitLintAtTop = false;
            navigationMenuItem1.Icon = null;
            navigationMenuItem1.Items = null;
            navigationMenuItem1.ItemWidth = 100;
            navigationMenuItem1.ShowTip = false;
            navigationMenuItem1.Text = "成员管理";
            navigationMenuItem1.TipText = null;
            navigationMenuItem2.AnchorRight = false;
            navigationMenuItem2.DataSource = null;
            navigationMenuItem2.HasSplitLintAtTop = false;
            navigationMenuItem2.Icon = null;
            navigationMenuItem2.Items = null;
            navigationMenuItem2.ItemWidth = 100;
            navigationMenuItem2.ShowTip = false;
            navigationMenuItem2.Text = "任务管理";
            navigationMenuItem2.TipText = null;
            navigationMenuItem3.AnchorRight = true;
            navigationMenuItem3.DataSource = null;
            navigationMenuItem3.HasSplitLintAtTop = false;
            navigationMenuItem3.Icon = null;
            navigationMenuItem3.Items = null;
            navigationMenuItem3.ItemWidth = 100;
            navigationMenuItem3.ShowTip = false;
            navigationMenuItem3.Text = "面试系统";
            navigationMenuItem3.TipText = null;
            navigationMenuItem4.AnchorRight = false;
            navigationMenuItem4.DataSource = null;
            navigationMenuItem4.HasSplitLintAtTop = false;
            navigationMenuItem4.Icon = null;
            navigationMenuItem4.Items = null;
            navigationMenuItem4.ItemWidth = 100;
            navigationMenuItem4.ShowTip = false;
            navigationMenuItem4.Text = "雇佣系统";
            navigationMenuItem4.TipText = null;
            navigationMenuItem5.AnchorRight = false;
            navigationMenuItem5.DataSource = null;
            navigationMenuItem5.HasSplitLintAtTop = false;
            navigationMenuItem5.Icon = null;
            navigationMenuItem5.Items = null;
            navigationMenuItem5.ItemWidth = 100;
            navigationMenuItem5.ShowTip = false;
            navigationMenuItem5.Text = "上传系统";
            navigationMenuItem5.TipText = null;
            this.ucNavigationMenu1.Items = new HZH_Controls.Controls.NavigationMenuItem[] {
        navigationMenuItem1,
        navigationMenuItem2,
        navigationMenuItem3,
        navigationMenuItem4,
        navigationMenuItem5};
            this.ucNavigationMenu1.Location = new System.Drawing.Point(0, 38);
            this.ucNavigationMenu1.Name = "ucNavigationMenu1";
            this.ucNavigationMenu1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ucNavigationMenu1.Size = new System.Drawing.Size(1407, 42);
            this.ucNavigationMenu1.TabIndex = 0;
            this.ucNavigationMenu1.TipColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.ucNavigationMenu1.ClickItemed += new System.EventHandler(this.ucNavigationMenu1_ClickItemed);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 796);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1414, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // PersonDepartMentManagerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 818);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.uiTitlePanel1);
            this.Name = "PersonDepartMentManagerWindow";
            this.Text = "人事部长";
            this.Load += new System.EventHandler(this.PersonDepartMentManagerWindow_Load);
            this.uiTitlePanel1.ResumeLayout(false);
            this.uiTabControl1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private Sunny.UI.UITabControl uiTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private HZH_Controls.Controls.UCNavigationMenu ucNavigationMenu1;
    }
}
namespace myScrumBoard
{
    partial class Form1
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
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            this.tileBar = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroupTables = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tileBarItem1 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem2 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem3 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.employeesNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlDone = new System.Windows.Forms.Panel();
            this.pnlInProgress = new System.Windows.Forms.Panel();
            this.pnlNotStarted = new System.Windows.Forms.Panel();
            this.pnlStory = new System.Windows.Forms.Panel();
            this.boardControl = new DevExpress.XtraEditors.LabelControl();
            this.customersNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.btnAddStory = new DevExpress.XtraEditors.SimpleButton();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtStoryAuthor = new System.Windows.Forms.TextBox();
            this.txtStory_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StoryControl = new DevExpress.XtraEditors.LabelControl();
            this.TaskControl = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.btnTaskEkle = new DevExpress.XtraEditors.SimpleButton();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.dtpDeadLine = new System.Windows.Forms.DateTimePicker();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTask_Header = new System.Windows.Forms.TextBox();
            this.cbStorys = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.employeesNavigationPage.SuspendLayout();
            this.panel5.SuspendLayout();
            this.customersNavigationPage.SuspendLayout();
            this.TaskControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tileBar
            // 
            this.tileBar.AllowDrag = false;
            this.tileBar.AllowGlyphSkinning = true;
            this.tileBar.AllowSelectedItem = true;
            this.tileBar.AppearanceGroupText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.tileBar.AppearanceGroupText.Options.UseForeColor = true;
            this.tileBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tileBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar.DropDownButtonWidth = 30;
            this.tileBar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar.Groups.Add(this.tileBarGroupTables);
            this.tileBar.IndentBetweenGroups = 10;
            this.tileBar.IndentBetweenItems = 10;
            this.tileBar.ItemPadding = new System.Windows.Forms.Padding(8, 6, 12, 6);
            this.tileBar.Location = new System.Drawing.Point(0, 0);
            this.tileBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tileBar.MaxId = 6;
            this.tileBar.MaximumSize = new System.Drawing.Size(0, 110);
            this.tileBar.MinimumSize = new System.Drawing.Size(100, 110);
            this.tileBar.Name = "tileBar";
            this.tileBar.Padding = new System.Windows.Forms.Padding(29, 11, 29, 11);
            this.tileBar.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.None;
            this.tileBar.SelectionBorderWidth = 2;
            this.tileBar.SelectionColorMode = DevExpress.XtraBars.Navigation.SelectionColorMode.UseItemBackColor;
            this.tileBar.ShowGroupText = false;
            this.tileBar.Size = new System.Drawing.Size(757, 110);
            this.tileBar.TabIndex = 1;
            this.tileBar.Text = "tileBar";
            this.tileBar.WideTileWidth = 150;
            this.tileBar.SelectedItemChanged += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBar_SelectedItemChanged);
            // 
            // tileBarGroupTables
            // 
            this.tileBarGroupTables.Items.Add(this.tileBarItem1);
            this.tileBarGroupTables.Items.Add(this.tileBarItem2);
            this.tileBarGroupTables.Items.Add(this.tileBarItem3);
            this.tileBarGroupTables.Name = "tileBarGroupTables";
            this.tileBarGroupTables.Text = "TABLES";
            // 
            // tileBarItem1
            // 
            this.tileBarItem1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            tileItemElement4.Text = "Board";
            this.tileBarItem1.Elements.Add(tileItemElement4);
            this.tileBarItem1.Id = 3;
            this.tileBarItem1.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem1.Name = "tileBarItem1";
            // 
            // tileBarItem2
            // 
            this.tileBarItem2.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            tileItemElement5.Text = "Add Story";
            this.tileBarItem2.Elements.Add(tileItemElement5);
            this.tileBarItem2.Id = 4;
            this.tileBarItem2.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem2.Name = "tileBarItem2";
            // 
            // tileBarItem3
            // 
            this.tileBarItem3.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            tileItemElement6.Text = "Add Task";
            this.tileBarItem3.Elements.Add(tileItemElement6);
            this.tileBarItem3.Id = 5;
            this.tileBarItem3.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem3.Name = "tileBarItem3";
            // 
            // navigationFrame
            // 
            this.navigationFrame.Controls.Add(this.employeesNavigationPage);
            this.navigationFrame.Controls.Add(this.customersNavigationPage);
            this.navigationFrame.Controls.Add(this.TaskControl);
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(0, 110);
            this.navigationFrame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.employeesNavigationPage,
            this.customersNavigationPage,
            this.TaskControl});
            this.navigationFrame.SelectedPage = this.employeesNavigationPage;
            this.navigationFrame.Size = new System.Drawing.Size(757, 611);
            this.navigationFrame.TabIndex = 0;
            this.navigationFrame.Text = "navigationFrame";
            // 
            // employeesNavigationPage
            // 
            this.employeesNavigationPage.Caption = "employeesNavigationPage";
            this.employeesNavigationPage.Controls.Add(this.panel5);
            this.employeesNavigationPage.Controls.Add(this.boardControl);
            this.employeesNavigationPage.Name = "employeesNavigationPage";
            this.employeesNavigationPage.Size = new System.Drawing.Size(757, 611);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.pnlDone);
            this.panel5.Controls.Add(this.pnlInProgress);
            this.panel5.Controls.Add(this.pnlNotStarted);
            this.panel5.Controls.Add(this.pnlStory);
            this.panel5.Location = new System.Drawing.Point(12, 8);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(733, 559);
            this.panel5.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.YellowGreen;
            this.label14.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(606, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "Done";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Peru;
            this.label13.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(405, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "In Progress";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.PeachPuff;
            this.label12.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(233, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Not Started";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Teal;
            this.label11.Font = new System.Drawing.Font("Trajan Pro", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(38, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 34);
            this.label11.TabIndex = 2;
            this.label11.Text = "Stories";
            // 
            // pnlDone
            // 
            this.pnlDone.AllowDrop = true;
            this.pnlDone.AutoScroll = true;
            this.pnlDone.BackColor = System.Drawing.Color.YellowGreen;
            this.pnlDone.Location = new System.Drawing.Point(555, 41);
            this.pnlDone.Name = "pnlDone";
            this.pnlDone.Size = new System.Drawing.Size(168, 511);
            this.pnlDone.TabIndex = 1;
            this.pnlDone.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.pnlDone.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            // 
            // pnlInProgress
            // 
            this.pnlInProgress.AllowDrop = true;
            this.pnlInProgress.AutoScroll = true;
            this.pnlInProgress.BackColor = System.Drawing.Color.Peru;
            this.pnlInProgress.Location = new System.Drawing.Point(381, 41);
            this.pnlInProgress.Name = "pnlInProgress";
            this.pnlInProgress.Size = new System.Drawing.Size(168, 511);
            this.pnlInProgress.TabIndex = 1;
            this.pnlInProgress.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.pnlInProgress.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            // 
            // pnlNotStarted
            // 
            this.pnlNotStarted.AllowDrop = true;
            this.pnlNotStarted.AutoScroll = true;
            this.pnlNotStarted.BackColor = System.Drawing.Color.PeachPuff;
            this.pnlNotStarted.Location = new System.Drawing.Point(207, 41);
            this.pnlNotStarted.Name = "pnlNotStarted";
            this.pnlNotStarted.Size = new System.Drawing.Size(168, 511);
            this.pnlNotStarted.TabIndex = 1;
            this.pnlNotStarted.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.pnlNotStarted.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            // 
            // pnlStory
            // 
            this.pnlStory.AutoScroll = true;
            this.pnlStory.BackColor = System.Drawing.Color.Teal;
            this.pnlStory.Location = new System.Drawing.Point(3, 41);
            this.pnlStory.Name = "pnlStory";
            this.pnlStory.Size = new System.Drawing.Size(198, 511);
            this.pnlStory.TabIndex = 0;
            // 
            // boardControl
            // 
            this.boardControl.Appearance.Font = new System.Drawing.Font("Tahoma", 25.25F);
            this.boardControl.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.boardControl.Appearance.Options.UseFont = true;
            this.boardControl.Appearance.Options.UseForeColor = true;
            this.boardControl.Appearance.Options.UseTextOptions = true;
            this.boardControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.boardControl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.boardControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.boardControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boardControl.Location = new System.Drawing.Point(0, 0);
            this.boardControl.Name = "boardControl";
            this.boardControl.Size = new System.Drawing.Size(757, 611);
            this.boardControl.TabIndex = 2;
            // 
            // customersNavigationPage
            // 
            this.customersNavigationPage.Caption = "customersNavigationPage";
            this.customersNavigationPage.Controls.Add(this.btnAddStory);
            this.customersNavigationPage.Controls.Add(this.txtDescription);
            this.customersNavigationPage.Controls.Add(this.txtStoryAuthor);
            this.customersNavigationPage.Controls.Add(this.txtStory_Name);
            this.customersNavigationPage.Controls.Add(this.label4);
            this.customersNavigationPage.Controls.Add(this.label3);
            this.customersNavigationPage.Controls.Add(this.label2);
            this.customersNavigationPage.Controls.Add(this.label1);
            this.customersNavigationPage.Controls.Add(this.StoryControl);
            this.customersNavigationPage.Name = "customersNavigationPage";
            this.customersNavigationPage.Size = new System.Drawing.Size(757, 611);
            // 
            // btnAddStory
            // 
            this.btnAddStory.Appearance.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddStory.Appearance.Options.UseFont = true;
            this.btnAddStory.Location = new System.Drawing.Point(19, 444);
            this.btnAddStory.Name = "btnAddStory";
            this.btnAddStory.Size = new System.Drawing.Size(726, 82);
            this.btnAddStory.TabIndex = 10;
            this.btnAddStory.Text = "Add Story";
            this.btnAddStory.Click += new System.EventHandler(this.btnAddStory_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(159, 235);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(586, 164);
            this.txtDescription.TabIndex = 9;
            // 
            // txtStoryAuthor
            // 
            this.txtStoryAuthor.Location = new System.Drawing.Point(159, 168);
            this.txtStoryAuthor.Name = "txtStoryAuthor";
            this.txtStoryAuthor.Size = new System.Drawing.Size(586, 21);
            this.txtStoryAuthor.TabIndex = 8;
            // 
            // txtStory_Name
            // 
            this.txtStory_Name.Location = new System.Drawing.Point(159, 114);
            this.txtStory_Name.Name = "txtStory_Name";
            this.txtStory_Name.Size = new System.Drawing.Size(586, 21);
            this.txtStory_Name.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(16, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(16, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Author :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trajan Pro", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add Story";
            // 
            // StoryControl
            // 
            this.StoryControl.Appearance.Font = new System.Drawing.Font("Tahoma", 25.25F);
            this.StoryControl.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.StoryControl.Appearance.Options.UseFont = true;
            this.StoryControl.Appearance.Options.UseForeColor = true;
            this.StoryControl.Appearance.Options.UseTextOptions = true;
            this.StoryControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.StoryControl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.StoryControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.StoryControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StoryControl.Location = new System.Drawing.Point(0, 0);
            this.StoryControl.Name = "StoryControl";
            this.StoryControl.Size = new System.Drawing.Size(757, 611);
            this.StoryControl.TabIndex = 2;
            // 
            // TaskControl
            // 
            this.TaskControl.Caption = "TaskControl";
            this.TaskControl.Controls.Add(this.btnTaskEkle);
            this.TaskControl.Controls.Add(this.rtbDescription);
            this.TaskControl.Controls.Add(this.dtpDeadLine);
            this.TaskControl.Controls.Add(this.txtAuthor);
            this.TaskControl.Controls.Add(this.txtTask_Header);
            this.TaskControl.Controls.Add(this.cbStorys);
            this.TaskControl.Controls.Add(this.label10);
            this.TaskControl.Controls.Add(this.label9);
            this.TaskControl.Controls.Add(this.label8);
            this.TaskControl.Controls.Add(this.label7);
            this.TaskControl.Controls.Add(this.label6);
            this.TaskControl.Controls.Add(this.label5);
            this.TaskControl.Name = "TaskControl";
            this.TaskControl.Size = new System.Drawing.Size(757, 611);
            // 
            // btnTaskEkle
            // 
            this.btnTaskEkle.Location = new System.Drawing.Point(12, 492);
            this.btnTaskEkle.Name = "btnTaskEkle";
            this.btnTaskEkle.Size = new System.Drawing.Size(733, 82);
            this.btnTaskEkle.TabIndex = 11;
            this.btnTaskEkle.Text = "Add Task";
            this.btnTaskEkle.Click += new System.EventHandler(this.btnTaskEkle_Click);
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(172, 316);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(573, 155);
            this.rtbDescription.TabIndex = 10;
            this.rtbDescription.Text = "";
            // 
            // dtpDeadLine
            // 
            this.dtpDeadLine.Location = new System.Drawing.Point(172, 263);
            this.dtpDeadLine.Name = "dtpDeadLine";
            this.dtpDeadLine.Size = new System.Drawing.Size(573, 21);
            this.dtpDeadLine.TabIndex = 9;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(172, 211);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(573, 21);
            this.txtAuthor.TabIndex = 8;
            // 
            // txtTask_Header
            // 
            this.txtTask_Header.Location = new System.Drawing.Point(172, 156);
            this.txtTask_Header.Name = "txtTask_Header";
            this.txtTask_Header.Size = new System.Drawing.Size(573, 21);
            this.txtTask_Header.TabIndex = 7;
            // 
            // cbStorys
            // 
            this.cbStorys.FormattingEnabled = true;
            this.cbStorys.Location = new System.Drawing.Point(172, 98);
            this.cbStorys.Name = "cbStorys";
            this.cbStorys.Size = new System.Drawing.Size(573, 21);
            this.cbStorys.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(15, 315);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Description : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(15, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Deadline : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(15, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Author : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(15, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Task Name : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(15, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Story Name : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trajan Pro", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(12, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 41);
            this.label5.TabIndex = 0;
            this.label5.Text = "Add Task";
            // 
            // Form1
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 721);
            this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.tileBar);
            this.Name = "Form1";
            this.Text = "UtkuEzran ScrumBoard";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.employeesNavigationPage.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.customersNavigationPage.ResumeLayout(false);
            this.customersNavigationPage.PerformLayout();
            this.TaskControl.ResumeLayout(false);
            this.TaskControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar tileBar;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroupTables;
        private DevExpress.XtraBars.Navigation.NavigationPage employeesNavigationPage;
        private DevExpress.XtraBars.Navigation.NavigationPage customersNavigationPage;
        private DevExpress.XtraEditors.LabelControl boardControl;
        private DevExpress.XtraEditors.LabelControl StoryControl;
        private DevExpress.XtraBars.Navigation.NavigationPage TaskControl;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem1;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem2;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem3;
        private DevExpress.XtraEditors.SimpleButton btnAddStory;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtStoryAuthor;
        private System.Windows.Forms.TextBox txtStory_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btnTaskEkle;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.DateTimePicker dtpDeadLine;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTask_Header;
        private System.Windows.Forms.ComboBox cbStorys;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnlDone;
        private System.Windows.Forms.Panel pnlInProgress;
        private System.Windows.Forms.Panel pnlNotStarted;
        private System.Windows.Forms.Panel pnlStory;
    }
}
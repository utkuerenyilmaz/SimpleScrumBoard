using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;


namespace myScrumBoard
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private static Form1 Instance;
        public Form1()
        {
            InitializeComponent();

            //frmMain
           // SQLHelper.SQLStart("Data Source=EZRANPC;Initial Catalog=ScrumTableDB;Integrated Security=True");
            SQLHelper.SQLStart("Data Source=DESKTOP-PPE8EJF;Initial Catalog=ScrumTableDB;Integrated Security=True");
            

            //frmTaskEkle
            foreach (PictureBoxInfo User in SQLHelper.Select())
            {
                cbStorys.Items.Add(User.Story_Name);
            }
        }

        //MENÜ
        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
            boardControl.Refresh();
            TaskControl.Refresh();
            StoryControl.Refresh();
        }

        public static Form1 GetInstance
        {
            get
            {
                if (Instance == null || Instance.IsDisposed)
                {
                    Instance = new Form1();
                }
                return Instance;
            }
        }


        //BOARD
        Button MouseDownPB;
        void panel_DragDrop(object sender, DragEventArgs e)
        {
            ((Button)e.Data.GetData(typeof(Button))).Parent = (Panel)sender;
            if (((Panel)sender) == pnlNotStarted)
            {
                SQLHelper.UpdateTask((int)(MouseDownPB.Tag), 0);
            }
            else if (((Panel)sender) == pnlInProgress)
            {
                SQLHelper.UpdateTask((int)(MouseDownPB.Tag), 1);
            }
            else if (((Panel)sender) == pnlDone)
            {
                SQLHelper.UpdateTask((int)(MouseDownPB.Tag), 2);
            }
        }


        void AllPB_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseDownPB = (sender as Button);
                ((Button)sender).DoDragDrop(((Button)sender), DragDropEffects.Move);
            }
            string[] R;
            if (e.Button == MouseButtons.Right)
            {
                int SenderValue = (int)((Button)sender).Tag;
                R = SQLHelper.GetTaskInfo(SenderValue, 0).Split('/');
                switch (R[5])
                {
                    case "0":
                        Status = "Başlanmadı(Not Started)";
                        break;
                    case "1":
                        Status = "İşlemde(In Progress)";
                        break;
                    case "2":
                        Status = "Bitirildi!(Done!)";
                        break;
                    default:
                        break;
                }
                MessageBox.Show(this, "" + R[0] + "\n" + R[1] + "\n" + R[3] + "\n Task Durumu : " + Status + "\n" + R[6] + "\n" + R[7], "TASK BİLGİLERİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void panel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        public void RefreshEvent()
        {
            ClearPanelEvent();
            List<PictureBoxInfo> Datas = SQLHelper.Select();
            foreach (PictureBoxInfo PBDatas in Datas)
            {
                Button PB = new Button();
                PB.Margin = new Padding(0);
                PB.Font = new Font("Trajan Pro", 10, FontStyle.Regular);
                PB.Size = PBDatas.PB_Size;
                PB.MouseDown += Story_RightClicked;
                PB.BackColor = Color.FromArgb(Int32.Parse(PBDatas.PB_BackColor));
                pnlStory.Controls.Add(PB);
                PB.Location = PBDatas.PB_Location;
                PB.Tag = PBDatas.Story_ID;
                PB.Text = "Name:" + PBDatas.Story_Name + "\nDate:" + PBDatas.Story_AddDate + "\nDesc:" + PBDatas.Story_Description;
                PB.ForeColor = Color.Black;
            }

            List<PictureBoxInfo> Datam = SQLHelper.SelectTask();
            foreach (PictureBoxInfo PBData in Datam)
            {
                Button PB = new Button();
                PB.Margin = new Padding(0);
                PB.Font = new Font("Trajan Pro", 10, FontStyle.Regular);
                PB.Size = PBData.PB_Size;
                PB.BackColor = Color.FromArgb(Int32.Parse(PBData.PB_BackColor));
                PB.Tag = PBData.Task_ID;
                PB.DragDrop += panel_DragDrop;
                PB.MouseDown += AllPB_MouseDown;
                PB.Text = PBData.Task_Header;
                PB.ForeColor = Color.Black;
                switch (PBData.Task_Status)
                {
                    case 0:
                        pnlNotStarted.Controls.Add(PB);

                        break;
                    case 1:
                        pnlInProgress.Controls.Add(PB);

                        break;
                    case 2:
                        pnlDone.Controls.Add(PB);

                        break;
                    default:
                        break;
                }
                PB.Location = PBData.PB_Location;
            }
            pnlNotStarted.Size = new Size(pnlNotStarted.Size.Width, panel5.Size.Height);
            pnlInProgress.Size = new Size(pnlNotStarted.Size.Width, panel5.Size.Height);
            pnlDone.Size = new Size(pnlNotStarted.Size.Width, panel5.Size.Height);
        }

        public void ClearPanelEvent()
        {
            pnlStory.Controls.Clear();
            pnlNotStarted.Controls.Clear();
            pnlInProgress.Controls.Clear();
            pnlDone.Controls.Clear();
        }

        
        string Status;

        private void Story_RightClicked(object sender, MouseEventArgs e)
        {
            string[] R;
            if (e.Button == MouseButtons.Right)
            {
                int SenderValue = (int)((Button)sender).Tag;
                R = SQLHelper.GetTaskInfo(0, SenderValue).Split('/');
                MessageBox.Show(this, "" + R[0] + "\n" + R[2] + "\n" + R[8] + "\n" + R[9] + "\n", "STORY BİLGİLERİ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }



        //STORY
        private void btnAddStory_Click(object sender, EventArgs e)
        {
            Button PB = new Button();
            List<PictureBoxInfo> Datas = SQLHelper.Select();
            Story StoryPass = new Story();
            Form1 frm = Form1.GetInstance;
            Random Rnd = new Random();
            PB.BackColor = Color.FromArgb(Rnd.Next(0, 256), Rnd.Next(0, 256), Rnd.Next(0, 256));
            foreach (Panel Panel in frm.Controls.OfType<Panel>())
            {
                if (Panel.Name == "panel5")
                {
                    foreach (Panel Panels in Panel.Controls.OfType<Panel>())
                    {
                        if (Panels.Name == "pnlStory")
                        {
                            Panels.Refresh();
                            PB.Location = SQLHelper.GetLastRow(); //9,9
                        }
                    }
                }
            }
            if (Datas.Count == 0)
            {
                StoryPass.StoryLocationX = PB.Location.X + 5;
            }
            else
                StoryPass.StoryLocationX = PB.Location.X;

            StoryPass.StoryLocationY = PB.Location.Y;
            StoryPass.Story_Color = PB.BackColor.GetHashCode().ToString();
            StoryPass.Story_Description = txtDescription.Text;
            StoryPass.Story_Name = txtStory_Name.Text;
            StoryPass.Story_AddDate = DateTime.Now.Date.ToString("dd/MM/yy");
            StoryPass.Story_Author = txtStoryAuthor.Text;
            SQLHelper.InsertStory(StoryPass);

            
            MessageBox.Show("Story Eklendi");
            Application.Restart();
            
        }



        //TASK

        private void SearchStoryID(string Story_Name)
        {
            foreach (PictureBoxInfo Items in SQLHelper.Select())
            {
                if (Items.Story_Name == cbStorys.Text)
                {
                    ThisStory_ID = Items.Story_ID;
                }
            }
        }
        int IsFirst;
        Point FirstTaskStoryLocation;
        int ThisStory_ID;

        private void btnTaskEkle_Click(object sender, EventArgs e)
        {
            SearchStoryID(cbStorys.Text);
            Form1 frm = Form1.GetInstance;
            Button PB = new Button();
            Task TaskPass = new Task();
            List<PictureBoxInfo> Data = SQLHelper.Select();
            foreach (PictureBoxInfo Instance in Data)
            {
                if (ThisStory_ID == Instance.Story_ID)
                {
                    IsFirst = Instance.Story_Task_Count;
                    FirstTaskStoryLocation = Instance.PB_Location;
                    PB.BackColor = Color.FromArgb(Convert.ToInt32(Instance.PB_BackColor));
                }
            }
            foreach (Panel Panel in frm.Controls.OfType<Panel>())
            {
                if (Panel.Name == "panel5")
                {
                    foreach (Panel Panels in Panel.Controls.OfType<Panel>())
                    {
                        if (Panels.Name == "pnlNotStarted")
                        {
                            Panels.Refresh();
                            PB.Location = SQLHelper.GetLastRowTask(ThisStory_ID);
                            if (IsFirst == 0)
                            {
                                PB.Location = FirstTaskStoryLocation;
                            }
                        }
                    }
                }
            }

            TaskPass.Task_BackColor = PB.BackColor.GetHashCode().ToString();
            TaskPass.TaskLocationX = PB.Location.X;
            TaskPass.TaskLocationY = PB.Location.Y;
            TaskPass.Task_Author = txtAuthor.Text;
            TaskPass.Task_DeadLine = dtpDeadLine.Value.ToString();
            TaskPass.Task_Description = rtbDescription.Text;
            TaskPass.Task_Status = 0;//Not Started 0...
            TaskPass.Story_ID = ThisStory_ID;
            TaskPass.Task_Header = txtTask_Header.Text;
            SQLHelper.InsertTask(TaskPass);
           

            MessageBox.Show("Task Eklendi");
            Application.Restart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshEvent();
        }

        
    }
}
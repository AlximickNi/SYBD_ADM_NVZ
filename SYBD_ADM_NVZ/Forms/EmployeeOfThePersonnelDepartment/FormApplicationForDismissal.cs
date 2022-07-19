using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYBD_ADM_NVZ.Forms.EmployeeOfThePersonnelDepartment
{
    public partial class FormApplicationForDismissal : Form
    {
        class ItemAppli : Panel
        {
            public System.Windows.Forms.PictureBox PbxPhoto;
            public System.Windows.Forms.Label LblFIO;
            public System.Windows.Forms.Label LblSysNumber;
            public System.Windows.Forms.Label LBLRole;
            public string Id_Worker = "";
            public ItemAppli()
            {
                this.PbxPhoto = new System.Windows.Forms.PictureBox();
                this.LblFIO = new System.Windows.Forms.Label();
                this.LBLRole = new System.Windows.Forms.Label();
                this.LblSysNumber = new System.Windows.Forms.Label();

                // 
                // PnlWorker
                // 
                this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.Controls.Add(this.LblSysNumber);
                this.Controls.Add(this.LBLRole);
                this.Controls.Add(this.LblFIO);
                this.Controls.Add(this.PbxPhoto);
                this.Location = new System.Drawing.Point(288, 103);
                this.Name = "PnlWorker";
                this.Size = new System.Drawing.Size(386, 182);
                this.TabIndex = 0;
                // 
                // PbxPhoto
                // 
                this.PbxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.PbxPhoto.Location = new System.Drawing.Point(3, 3);
                this.PbxPhoto.Name = "PbxPhoto";
                this.PbxPhoto.Size = new System.Drawing.Size(145, 173);
                this.PbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                this.PbxPhoto.TabIndex = 0;
                this.PbxPhoto.TabStop = false;
                // 
                // LblFIO
                // 
                this.LblFIO.Font = new System.Drawing.Font("Segoe UI", 14.25F);
                this.LblFIO.ForeColor = System.Drawing.Color.Black;
                this.LblFIO.Location = new System.Drawing.Point(154, 3);
                this.LblFIO.Name = "LblFIO";
                this.LblFIO.Size = new System.Drawing.Size(240, 73);
                this.LblFIO.TabIndex = 131;
                this.LblFIO.Text = "ФИО:";
                // 
                // LBLRole
                // 
                this.LBLRole.Font = new System.Drawing.Font("Segoe UI", 14.25F);
                this.LBLRole.ForeColor = System.Drawing.Color.Black;
                this.LBLRole.Location = new System.Drawing.Point(154, 76);
                this.LBLRole.Name = "LBLRole";
                this.LBLRole.Size = new System.Drawing.Size(240, 68);
                this.LBLRole.TabIndex = 132;
                this.LBLRole.Text = "Должность:";
                // 
                // LblSysNumber
                // 
                this.LblSysNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F);
                this.LblSysNumber.ForeColor = System.Drawing.Color.Black;
                this.LblSysNumber.Location = new System.Drawing.Point(154, 144);
                this.LblSysNumber.Name = "LblSysNumber";
                this.LblSysNumber.Size = new System.Drawing.Size(251, 32);
                this.LblSysNumber.TabIndex = 133;
                this.LblSysNumber.Text = "Системный номер:";
            }
        }
        ItemAppli CurrentItemAppli = new ItemAppli();
        string Id_Worker = "";
        void FillPanelAppli()
        {
            FPNLWorkers.Controls.Clear();
            SqlConnection Con = new SqlConnection(FormMain.TxtCon);
            Con.Open();
            string TxtQuarty1 = $@"
select Id_Worker, Fam, Name, Otch, Role, Photo, Gender
from Worker
where Date_of_dismissal is null";
            SqlCommand Quarty1 = new SqlCommand(TxtQuarty1, Con);
            SqlDataReader Res = Quarty1.ExecuteReader();
            while (Res.Read())
            {
                ItemAppli NewItemAppli = new ItemAppli();
                string Gender = Res["Gender"].ToString();
                string TxtPhoto = Res["Photo"].ToString();
                if (TxtPhoto != "")
                {
                    var Photo = Image.FromStream(new MemoryStream(Convert.FromBase64String(TxtPhoto)));
                    NewItemAppli.PbxPhoto.Image = Photo;
                }
                else
                {
                    switch (Gender)
                    {
                        case "М":
                            NewItemAppli.PbxPhoto.Image = global::SYBD_ADM_NVZ.Properties.Resources._4086641;
                            ;
                            break;
                        case "Ж":
                            NewItemAppli.PbxPhoto.Image = global::SYBD_ADM_NVZ.Properties.Resources._4086569;
                            break;
                    }
                }
                string Otch = Res["Otch"].ToString();

                NewItemAppli.LblFIO.Text = $@"ФИО: {Res["Fam"]} {Res["Name"]} {Otch}";
                NewItemAppli.LBLRole.Text = $@"Должность: {Res["Role"]}";
                NewItemAppli.LblSysNumber.Text = $@"Системный номер: {Res["Id_Worker"]}";
                NewItemAppli.Id_Worker = Res["Id_Worker"].ToString();

                NewItemAppli.PbxPhoto.Click += ControlPnlWorker_Click;
                NewItemAppli.LblFIO.Click += ControlPnlWorker_Click;
                NewItemAppli.LBLRole.Click += ControlPnlWorker_Click;
                NewItemAppli.LblSysNumber.Click += ControlPnlWorker_Click;
                NewItemAppli.Click += ObjectPnlWorker_Click;
                NewItemAppli.Dock = DockStyle.Bottom;
                FPNLWorkers.Controls.Add(NewItemAppli);

                if (FPNLWorkers.Controls.Count == 1)
                {
                    CurrentItemAppli = NewItemAppli;
                    Id_Worker = CurrentItemAppli.Id_Worker;
                    CurrentItemAppli.BackColor = FormMain.PrimaryColor;
                    CurrentItemAppli.LblFIO.ForeColor = Color.White;
                    CurrentItemAppli.LBLRole.ForeColor = Color.White;
                    CurrentItemAppli.LblSysNumber.ForeColor = Color.White;
                    GetDateWorker();
                }
            }
            Con.Close();
        }

        private void ObjectPnlWorker_Click(object sender, EventArgs e)
        {
            if (CurrentItemAppli != sender as ItemAppli)
            {
                CurrentItemAppli.BackColor = Color.White;
                CurrentItemAppli.LblFIO.ForeColor = Color.Black;
                CurrentItemAppli.LBLRole.ForeColor = Color.Black;
                CurrentItemAppli.LblSysNumber.ForeColor = Color.Black;
                CurrentItemAppli = sender as ItemAppli;
                Id_Worker = CurrentItemAppli.Id_Worker;
                CurrentItemAppli.BackColor = FormMain.PrimaryColor;
                CurrentItemAppli.LblFIO.ForeColor = Color.White;
                CurrentItemAppli.LBLRole.ForeColor = Color.White;
                CurrentItemAppli.LblSysNumber.ForeColor = Color.White;
                GetDateWorker();
            }
        }

        private void ControlPnlWorker_Click(object sender, EventArgs e)
        {
            if (CurrentItemAppli != (sender as Control).Parent as ItemAppli)
            {
                CurrentItemAppli.BackColor = Color.White;
                CurrentItemAppli.LblFIO.ForeColor = Color.Black;
                CurrentItemAppli.LBLRole.ForeColor = Color.Black;
                CurrentItemAppli.LblSysNumber.ForeColor = Color.Black;
                CurrentItemAppli = (sender as Control).Parent as ItemAppli;
                Id_Worker = CurrentItemAppli.Id_Worker;
                CurrentItemAppli.BackColor = FormMain.PrimaryColor;
                CurrentItemAppli.LblFIO.ForeColor = Color.White;
                CurrentItemAppli.LBLRole.ForeColor = Color.White;
                CurrentItemAppli.LblSysNumber.ForeColor = Color.White;
                GetDateWorker();
            }
        }

        public void GetDateWorker()
        {
            SqlConnection Con = new SqlConnection(FormMain.TxtCon);
            Con.Open();
            string TxtQuarty1 = $@"
select *
from Worker
where Id_Worker = {Id_Worker}";
            SqlCommand Quarty1 = new SqlCommand(TxtQuarty1, Con);
            SqlDataReader Res = Quarty1.ExecuteReader();
            Res.Read();
            TbxFam.Text = Res["Fam"].ToString();
            TbxName.Text = Res["Name"].ToString();
            string Otch = Res["Otch"].ToString();
            if (Otch != "")
            {
                TbxOtch.Text = Otch;
            }
            else
            {
                TbxOtch.Text = "";
            }
            TbxPhone.Text = Res["Phone_number"].ToString();
            TbxRole.Text = Res["Role"].ToString();
            TbxSalary.Text = Res["Salary"].ToString();
        }
        public FormApplicationForDismissal()
        {
            InitializeComponent();
        }

        private void FormApplicationForDismissal_Load(object sender, EventArgs e)
        {
            BtnCreateApplication.BackColor = FormMain.PrimaryColor;
            FillPanelAppli();
        }

        private void BtnCreateApplication_Click(object sender, EventArgs e)
        {
            if (TbxReason.Text == "")
            {
                MessageBox.Show("Вами не была описана причина увольнения работника!");
                return;
            }
            if (MessageBox.Show("Вы уверены, что хотите сформировать заявку?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection Con = new SqlConnection(FormMain.TxtCon);
                Con.Open();
                string TxtQuarty1 = $@"
select W.Id_Worker as 'Id_Secretary',
((select top(1) COUNT(AFE.Id_Secretary) as countAppliForDismissal
from Application_For_Dismissal AFE
where W.Id_Worker = AFE.Id_Secretary and AFE.Applications_Status = 'Ожидание'
group by Id_Secretary
order by countAppliForDismissal asc)) as countAppli
from Worker W
where W.Role = 'Секретарь' 
order by countAppli asc";
                SqlCommand Quarty1 = new SqlCommand(TxtQuarty1, Con);
                SqlDataReader Res = Quarty1.ExecuteReader();

                if (Res.HasRows)
                {
                    Res.Read();
                    string IdSecretary = Res["Id_Secretary"].ToString();
                    Res.Close();

                    TxtQuarty1 = $@"Insert into Application_For_Dismissal(Id_Worker, Reason, Applications_Status, Id_Employee_Of_The_Personnel_Department, 
Id_Secretary, Date_of_the_final_decision_of_the_application)
values({Id_Worker}, '{TbxReason.Text}', 'Ожидание', {FormMain.Id_Special_Worker}, {IdSecretary}, NULL)";

                    Quarty1 = new SqlCommand(TxtQuarty1, Con);
                    Quarty1.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show(@"Заявка сформирована и успешно отправлена. 
Заявке присвоен статус - Ожидания. 
Статус изменится, когда Секретарь расмотрит её и вынесет решение.");
                }
                else
                {
                    Res.Close();

                    TxtQuarty1 = $@"Insert into Application_For_Dismissal(Id_Worker, Reason, Applications_Status, Id_Employee_Of_The_Personnel_Department, 
Id_Secretary, Date_of_the_final_decision_of_the_application)
values({Id_Worker}, '{TbxReason.Text}', 'Принято', {FormMain.Id_Special_Worker}, NULL, '{DateTime.Now.ToString("MM.dd.yyyy")}')";

                    Quarty1 = new SqlCommand(TxtQuarty1, Con);
                    Quarty1.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show(@"Заявка была сформирована и Принята. 
Т.к. система не обнаружила Секретаря, который бы мог её рассмотреть");
                }
                Con.Close();
            }
        }
    }
}

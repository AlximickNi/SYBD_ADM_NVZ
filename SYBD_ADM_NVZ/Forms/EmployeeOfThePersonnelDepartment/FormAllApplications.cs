using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYBD_ADM_NVZ.Forms.EmployeeOfThePersonnelDepartment
{
    public partial class FormAllApplications : Form
    {
        public FormAllApplications()
        {
            InitializeComponent();
        }

        class ItemAppli : Panel
        {
            public System.Windows.Forms.Panel PnlColorStatus;
            public System.Windows.Forms.Label LblApplicationType;
            public System.Windows.Forms.Label LblDateEnd;
            public System.Windows.Forms.Label LblStatus;
            public System.Windows.Forms.Label LblOtherInformation;
            public ItemAppli()
            {
                this.LblApplicationType = new System.Windows.Forms.Label();
                this.LblOtherInformation = new System.Windows.Forms.Label();
                this.LblStatus = new System.Windows.Forms.Label();
                this.LblDateEnd = new System.Windows.Forms.Label();
                this.PnlColorStatus = new System.Windows.Forms.Panel();
                // 
                // PnlAppli
                // 
                this.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
                this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.Controls.Add(this.LblOtherInformation);
                this.Controls.Add(this.LblStatus);
                this.Controls.Add(this.LblApplicationType);
                this.Controls.Add(this.LblDateEnd);
                this.Controls.Add(this.PnlColorStatus);
                this.Location = new System.Drawing.Point(82, 38);
                this.Name = "PnlAppli";
                this.Size = new System.Drawing.Size(696, 241);
                this.TabIndex = 0;
                // 
                // LblApplicationType
                // 
                this.LblApplicationType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
                this.LblApplicationType.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.LblApplicationType.Location = new System.Drawing.Point(3, 0);
                this.LblApplicationType.Name = "LblApplicationType";
                this.LblApplicationType.Size = new System.Drawing.Size(361, 60);
                this.LblApplicationType.TabIndex = 4;
                this.LblApplicationType.Text = "Тип заявкии её системный номер:";
                // 
                // LblOtherInformation
                // 
                this.LblOtherInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
                this.LblOtherInformation.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.LblOtherInformation.Location = new System.Drawing.Point(3, 80);
                this.LblOtherInformation.Name = "LblOtherInformation";
                this.LblOtherInformation.Size = new System.Drawing.Size(537, 241);
                this.LblOtherInformation.TabIndex = 5;
                this.LblOtherInformation.Text = "Прочая информация по заявке:";
                // 
                // LblStatus
                // 
                this.LblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                this.LblStatus.AutoSize = true;
                this.LblStatus.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.LblStatus.Location = new System.Drawing.Point(370, -1);
                this.LblStatus.Name = "LblStatus";
                this.LblStatus.Size = new System.Drawing.Size(80, 30);
                this.LblStatus.TabIndex = 6;
                this.LblStatus.Text = "Статус:";
                // 
                // LblDateEnd
                // 
                this.LblDateEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                this.LblDateEnd.AutoSize = true;
                this.LblDateEnd.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.LblDateEnd.Location = new System.Drawing.Point(370, 30);
                this.LblDateEnd.Name = "LblDateEnd";
                this.LblDateEnd.Size = new System.Drawing.Size(161, 30);
                this.LblDateEnd.TabIndex = 7;
                this.LblDateEnd.Text = "Дата принятия:";
                // 
                // PnlColorStatus
                // 
                this.PnlColorStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.PnlColorStatus.Dock = System.Windows.Forms.DockStyle.Right;
                this.PnlColorStatus.Location = new System.Drawing.Point(574, 0);
                this.PnlColorStatus.Name = "PnlColorStatus";
                this.PnlColorStatus.Size = new System.Drawing.Size(31, 330);
                this.PnlColorStatus.TabIndex = 8;
            }
        }

        void FillPanelAppli()
        {
            FPNLAllAppli.Controls.Clear();

            string Dop = "";
            string NewOrOld = "desc";

            if(CbxTimeCreate.SelectedIndex == 1)
            {
                NewOrOld = "asc";
            }
            if (CbxStatusAppli.SelectedIndex != 0)
            {
                switch (CbxStatusAppli.SelectedItem)
                {
                    case "Ожидание":
                        Dop = "and Applications_Status = 'Ожидание'";
                        break;
                    case "Принято":
                        Dop = "and Applications_Status = 'Принято'";
                        break;
                    case "Отклонено":
                        Dop = "and Applications_Status = 'Отклонено'";
                        break;
                }
            }

            if (CbxTypeAppli.SelectedIndex == 0 || CbxTypeAppli.SelectedIndex == 1)
            {
                SqlConnection Con = new SqlConnection(FormMain.TxtCon);
                Con.Open();
                string TxtQuarty1 = $@"
select *
from Applications_For_Employment
where Id_Employee_Of_The_Personnel_Department = {FormMain.Id_Special_Worker} {Dop}
order by Id_Application {NewOrOld}";
                SqlCommand Quarty1 = new SqlCommand(TxtQuarty1, Con);
                SqlDataReader Res = Quarty1.ExecuteReader();
                while (Res.Read())
                {
                    ItemAppli Appli = new ItemAppli();
                    Appli.LblApplicationType.Text = $@"Тип заявки: Принятие на работу | Сис.№: {Res["Id_Application"]}";
                    string Status = Res["Applications_Status"].ToString().Trim();
                    switch (Status)
                    {
                        case "Ожидание":
                            Appli.LblStatus.Text = $@"Статус: Ожидание";
                            Appli.LblStatus.ForeColor = Color.FromArgb(255, 165, 0);
                            Appli.PnlColorStatus.BackColor = Color.FromArgb(255, 165, 0);
                            break;
                        case "Принято":
                            Appli.LblStatus.Text = $@"Статус: Принято";
                            Appli.LblStatus.ForeColor = Color.FromArgb(46, 139, 87);
                            Appli.PnlColorStatus.BackColor = Color.FromArgb(46, 139, 87);
                            break;
                        case "Отклонено":
                            Appli.LblStatus.Text = $@"Статус: Отклонено";
                            Appli.LblStatus.ForeColor = Color.FromArgb(128, 0, 0);
                            Appli.PnlColorStatus.BackColor = Color.FromArgb(128, 0, 0);
                            break;
                    }
                    string DateEnd = Res["Date_of_the_final_decision_of_the_application"].ToString();
                    if (DateEnd == "")
                    {
                        Appli.LblDateEnd.Text = $@"Дата решения: Неизвестно";
                        Appli.LblDateEnd.ForeColor = Color.FromArgb(112, 128, 144);
                    }
                    else
                    {

                        Appli.LblDateEnd.Text = $@"Дата решения: {Convert.ToDateTime(DateEnd).ToShortDateString()}";
                        Appli.LblDateEnd.ForeColor = Color.FromArgb(112, 128, 144);
                    }
                    string Otch = Res["Otch"].ToString();
                    if (Otch != "")
                    {
                        Otch = " " + Otch;
                    }
                    Appli.LblOtherInformation.Text = $@"Заявление принятия на работу человека с ФИО: {Res["Fam"]} {Res["Name"]}{Otch}.
На Должность: {Res["Role"]}.
С Окладом равным {Res["Salary"]} р. 
С графиком работы - {Res["Tariff_category"]}. ";
                    Appli.Dock = DockStyle.Top;
                    FPNLAllAppli.Controls.Add(Appli);
                }
                Res.Close();
                Con.Close();
            }

            if (CbxTypeAppli.SelectedIndex == 0 || CbxTypeAppli.SelectedIndex == 2)
            {
                SqlConnection Con = new SqlConnection(FormMain.TxtCon);
                Con.Open();
                string TxtQuarty1 = $@"
select *
from Application_For_Changing_Personal_Data
where Id_Employee_Of_The_Personnel_Department = {FormMain.Id_Special_Worker} {Dop}
order by Id_Application {NewOrOld}";
                SqlCommand Quarty1 = new SqlCommand(TxtQuarty1, Con);
                SqlDataReader Res = Quarty1.ExecuteReader();
                while (Res.Read())
                {
                    ItemAppli Appli = new ItemAppli();
                    Appli.LblApplicationType.Text = $@"Тип заявки: Изменение личных данных сотрудника | Сис.№: {Res["Id_Application"]}";
                    string Status = Res["Applications_Status"].ToString().Trim();
                    switch (Status)
                    {
                        case "Ожидание":
                            Appli.LblStatus.Text = $@"Статус: Ожидание";
                            Appli.LblStatus.ForeColor = Color.FromArgb(255, 165, 0);
                            Appli.PnlColorStatus.BackColor = Color.FromArgb(255, 165, 0);
                            break;
                        case "Принято":
                            Appli.LblStatus.Text = $@"Статус: Принято";
                            Appli.LblStatus.ForeColor = Color.FromArgb(46, 139, 87);
                            Appli.PnlColorStatus.BackColor = Color.FromArgb(46, 139, 87);
                            break;
                        case "Отклонено":
                            Appli.LblStatus.Text = $@"Статус: Отклонено";
                            Appli.LblStatus.ForeColor = Color.FromArgb(128, 0, 0);
                            Appli.PnlColorStatus.BackColor = Color.FromArgb(128, 0, 0);
                            break;
                    }
                    string DateEnd = Res["Date_of_the_final_decision_of_the_application"].ToString();
                    if (DateEnd == "")
                    {
                        Appli.LblDateEnd.Text = $@"Дата решения: Неизвестно";
                        Appli.LblDateEnd.ForeColor = Color.FromArgb(112, 128, 144);
                    }
                    else
                    {

                        Appli.LblDateEnd.Text = $@"Дата решения: {Convert.ToDateTime(DateEnd).ToShortDateString()}";
                        Appli.LblDateEnd.ForeColor = Color.FromArgb(112, 128, 144);
                    }
                    string Otch = Res["Otch"].ToString();
                    if (Otch != "")
                    {
                        Otch = " " + Otch;
                    }
                    Appli.LblOtherInformation.Text = $@"Заявление изменения личных данных сотрудника с ФИО: {Res["Fam"]} {Res["Name"]}{Otch}.
На Должность: {Res["Role"]}.
С Окладом равным {Res["Salary"]} р. 
С графиком работы - {Res["Tariff_category"]}. ";
                    Appli.Dock = DockStyle.Top;
                    FPNLAllAppli.Controls.Add(Appli);
                }
                Res.Close();
                Con.Close();
            }

            if (CbxTypeAppli.SelectedIndex == 0 || CbxTypeAppli.SelectedIndex == 3)
            {
                SqlConnection Con = new SqlConnection(FormMain.TxtCon);
                Con.Open();
                string TxtQuarty1 = $@"
select W.Fam, W.Name, W.Otch, W.Role, AFD.*
from Application_For_Dismissal AFD, Worker W
where Id_Employee_Of_The_Personnel_Department = {FormMain.Id_Special_Worker} and W.Id_Worker = AFD.Id_Worker {Dop}
order by Id_Application  {NewOrOld}";

                SqlCommand Quarty1 = new SqlCommand(TxtQuarty1, Con);
                SqlDataReader Res = Quarty1.ExecuteReader();

                while (Res.Read())
                {                
                    ItemAppli Appli = new ItemAppli();
                    Appli.LblApplicationType.Text = $@"Тип заявки: Увольнительная | Сис.№: {Res["Id_Application"]}";
                    string Status = Res["Applications_Status"].ToString().Trim();
                    switch (Status)
                    {
                        case "Ожидание":
                            Appli.LblStatus.Text = $@"Статус: Ожидание";
                            Appli.LblStatus.ForeColor = Color.FromArgb(255, 165, 0);
                            Appli.PnlColorStatus.BackColor = Color.FromArgb(255, 165, 0);
                            break;
                        case "Принято":
                            Appli.LblStatus.Text = $@"Статус: Принято";
                            Appli.LblStatus.ForeColor = Color.FromArgb(46, 139, 87);
                            Appli.PnlColorStatus.BackColor = Color.FromArgb(46, 139, 87);
                            break;
                        case "Отклонено":
                            Appli.LblStatus.Text = $@"Статус: Отклонено";
                            Appli.LblStatus.ForeColor = Color.FromArgb(128, 0, 0);
                            Appli.PnlColorStatus.BackColor = Color.FromArgb(128, 0, 0);
                            break;
                    }
                    string DateEnd = Res["Date_of_the_final_decision_of_the_application"].ToString();
                    if (DateEnd == "")
                    {
                        Appli.LblDateEnd.Text = $@"Дата решения: Неизвестно";
                        Appli.LblDateEnd.ForeColor = Color.FromArgb(112, 128, 144);
                    }
                    else
                    {

                        Appli.LblDateEnd.Text = $@"Дата решения: {Convert.ToDateTime(DateEnd).ToShortDateString()}";
                        Appli.LblDateEnd.ForeColor = Color.FromArgb(112, 128, 144);
                    }
                    string Otch = Res["Otch"].ToString();
                    if (Otch != "")
                    {
                        Otch = " " + Otch;
                    }
                    Appli.LblOtherInformation.Text = $@"Заявление увольнения сотрудника с ФИО: {Res["Fam"]} {Res["Name"]}{Otch}.
На Должность: {Res["Role"]}. 
По причине: {Res["Reason"]}";
                    Appli.Dock = DockStyle.Top;
                    FPNLAllAppli.Controls.Add(Appli);
                }
                Res.Close();
                Con.Close();
            }

            if (CbxTypeAppli.SelectedIndex == 0 || CbxTypeAppli.SelectedIndex == 4)
            {
                SqlConnection Con = new SqlConnection(FormMain.TxtCon);
                Con.Open();
                string TxtQuarty1 = $@"
select W.Fam, W.Name, W.Otch, W.Role, AFD.*
from Applications_Vacation_Or_Sick_Leave AFD, Worker W
where Id_Employee_Of_The_Personnel_Department = {FormMain.Id_Special_Worker} and W.Id_Worker = AFD.Id_Worker {Dop}
order by Id_Application {NewOrOld}";

                SqlCommand Quarty1 = new SqlCommand(TxtQuarty1, Con);
                SqlDataReader Res = Quarty1.ExecuteReader();

                while (Res.Read())
                {
                    ItemAppli Appli = new ItemAppli();
                    Appli.LblApplicationType.Text = $@"Тип заявки: {Res["Reason"]} | Сис.№: {Res["Id_Application"]}";
                    string Status = Res["Applications_Status"].ToString().Trim();
                    switch (Status)
                    {
                        case "Ожидание":
                            Appli.LblStatus.Text = $@"Статус: Ожидание";
                            Appli.LblStatus.ForeColor = Color.FromArgb(255, 165, 0);
                            Appli.PnlColorStatus.BackColor = Color.FromArgb(255, 165, 0);
                            break;
                        case "Принято":
                            Appli.LblStatus.Text = $@"Статус: Принято";
                            Appli.LblStatus.ForeColor = Color.FromArgb(46, 139, 87);
                            Appli.PnlColorStatus.BackColor = Color.FromArgb(46, 139, 87);
                            break;
                        case "Отклонено":
                            Appli.LblStatus.Text = $@"Статус: Отклонено";
                            Appli.LblStatus.ForeColor = Color.FromArgb(128, 0, 0);
                            Appli.PnlColorStatus.BackColor = Color.FromArgb(128, 0, 0);
                            break;
                    }
                    string DateEnd = Res["Date_of_the_final_decision_of_the_application"].ToString();
                    if (DateEnd == "")
                    {
                        Appli.LblDateEnd.Text = $@"Дата решения: Неизвестно";
                        Appli.LblDateEnd.ForeColor = Color.FromArgb(112, 128, 144);
                    }
                    else
                    {

                        Appli.LblDateEnd.Text = $@"Дата решения: {Convert.ToDateTime(DateEnd).ToShortDateString()}";
                        Appli.LblDateEnd.ForeColor = Color.FromArgb(112, 128, 144);
                    }
                    string Otch = Res["Otch"].ToString();
                    if (Otch != "")
                    {
                        Otch = " " + Otch;
                    }
                    Appli.LblOtherInformation.Text = $@"Заявление на {Res["Reason"]} сотрудника с ФИО: {Res["Fam"]} {Res["Name"]}{Otch}.
Должности: {Res["Role"]}.
Продолжительностью с {Convert.ToDateTime(Res["Date_Start"]).ToShortDateString()} до {Convert.ToDateTime(Res["Date_End"]).ToShortDateString()} включительно.";
                    Appli.Dock = DockStyle.Top;
                    FPNLAllAppli.Controls.Add(Appli);
                }
                Res.Close();
                Con.Close();
            }
            FPNLAllAppli.AutoScroll = true;
        }

        private void FormAllApplications_Load(object sender, EventArgs e)
        {
            CbxStatusAppli.SelectedIndex = 0;
            CbxTypeAppli.SelectedIndex = 0;
            CbxTimeCreate.SelectedIndex = 0;
            FillPanelAppli();
        }

        private void CbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillPanelAppli();
        }

        private void CbxTypeAppli_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillPanelAppli();
        }

        private void CbxTimeCreate_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillPanelAppli();
        }
    }
}

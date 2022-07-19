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

namespace SYBD_ADM_NVZ.Forms.SystemAdministrator
{
    public partial class FormMakeChangesToTheDatabaseDasedOnTheAcceptedStatements : Form
    {
        public string Currrent_Id_Appli = "";
        public string Currrent_TypeTably_Appli = "";
        ItemAppli CurrentItemAppli = new ItemAppli();
        class ItemAppli : Panel
        {
            public System.Windows.Forms.Panel PnlColorStatus;
            public System.Windows.Forms.Label LblApplicationType;
            public System.Windows.Forms.Label LblDateEnd;
            public System.Windows.Forms.Label LblStatus;
            public System.Windows.Forms.Label LblOtherInformation;
            public string Id_Appli = "";
            public string TypeTably_Appli = "";
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
            SqlConnection Con = new SqlConnection(FormMain.TxtCon);
            Con.Open();
            string TxtQuarty1 = $@"
select *
from Applications_For_Employment
where Applications_Status = 'Принято' and Date_of_the_final_decision_of_the_application is null
order by Id_Application";
            SqlCommand Quarty1 = new SqlCommand(TxtQuarty1, Con);
            SqlDataReader Res = Quarty1.ExecuteReader();
            while (Res.Read())
            {
                ItemAppli Appli = new ItemAppli();
                Appli.LblApplicationType.Text = $@"Тип заявки: Принятие на работу | Сис.№: {Res["Id_Application"]}";
                Appli.LblStatus.Text = $@"Статус: Принято";
                Appli.LblStatus.ForeColor = Color.FromArgb(46, 139, 87);
                Appli.PnlColorStatus.BackColor = Color.FromArgb(46, 139, 87);

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

                Appli.Id_Appli = $@"{Res["Id_Application"]}";
                Appli.TypeTably_Appli = "Applications_For_Employment";

                Appli.Click += Appli_Click;
                Appli.LblApplicationType.Click += ControlAppli_Click;
                Appli.LblStatus.Click += ControlAppli_Click;
                Appli.LblDateEnd.Click += ControlAppli_Click;
                Appli.LblOtherInformation.Click += ControlAppli_Click;

                FPNLAllAppli.Controls.Add(Appli);
            }
            Res.Close();
            Con.Close();

            Con = new SqlConnection(FormMain.TxtCon);
            Con.Open();
            TxtQuarty1 = $@"
select *
from Application_For_Changing_Personal_Data
where Applications_Status = 'Принято' and Date_of_the_final_decision_of_the_application is null
order by Id_Application";
            Quarty1 = new SqlCommand(TxtQuarty1, Con);
            Res = Quarty1.ExecuteReader();
            while (Res.Read())
            {
                ItemAppli Appli = new ItemAppli();
                Appli.LblApplicationType.Text = $@"Тип заявки: Изменение личных данных сотрудника | Сис.№: {Res["Id_Application"]}";
                Appli.LblStatus.Text = $@"Статус: Принято";
                Appli.LblStatus.ForeColor = Color.FromArgb(46, 139, 87);
                Appli.PnlColorStatus.BackColor = Color.FromArgb(46, 139, 87);
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

                Appli.Id_Appli = $@"{Res["Id_Application"]}";
                Appli.TypeTably_Appli = "Application_For_Changing_Personal_Data";

                Appli.Click += Appli_Click;
                Appli.LblApplicationType.Click += ControlAppli_Click;
                Appli.LblStatus.Click += ControlAppli_Click;
                Appli.LblDateEnd.Click += ControlAppli_Click;
                Appli.LblOtherInformation.Click += ControlAppli_Click;

                FPNLAllAppli.Controls.Add(Appli);
            }
            Res.Close();
            Con.Close();

            Con = new SqlConnection(FormMain.TxtCon);
            Con.Open();
            TxtQuarty1 = $@"
select W.Fam, W.Name, W.Otch, W.Role, AFD.*
from Application_For_Dismissal AFD, Worker W
where W.Id_Worker = AFD.Id_Worker and Applications_Status = 'Принято' and Date_of_the_final_decision_of_the_application is null
order by Id_Application";

            Quarty1 = new SqlCommand(TxtQuarty1, Con);
            Res = Quarty1.ExecuteReader();

            while (Res.Read())
            {
                ItemAppli Appli = new ItemAppli();
                Appli.LblApplicationType.Text = $@"Тип заявки: Увольнительная | Сис.№: {Res["Id_Application"]}";
                Appli.LblStatus.Text = $@"Статус: Принято";
                Appli.LblStatus.ForeColor = Color.FromArgb(46, 139, 87);
                Appli.PnlColorStatus.BackColor = Color.FromArgb(46, 139, 87);
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

                Appli.Id_Appli = $@"{Res["Id_Application"]}";
                Appli.TypeTably_Appli = "Application_For_Dismissal";

                Appli.Click += Appli_Click;
                Appli.LblApplicationType.Click += ControlAppli_Click;
                Appli.LblStatus.Click += ControlAppli_Click;
                Appli.LblDateEnd.Click += ControlAppli_Click;
                Appli.LblOtherInformation.Click += ControlAppli_Click;

                FPNLAllAppli.Controls.Add(Appli);
            }
            Res.Close();
            Con.Close();          
        }

        private void ControlAppli_Click(object sender, EventArgs e)
        {
            if (CurrentItemAppli != (sender as Control).Parent as ItemAppli)
            {
                if (CurrentItemAppli != null)
                {
                    CurrentItemAppli.BackColor = Color.White;
                    CurrentItemAppli.LblApplicationType.ForeColor = Color.Black;
                    CurrentItemAppli.LblStatus.ForeColor = Color.FromArgb(46, 139, 87);
                    CurrentItemAppli.LblDateEnd.ForeColor = Color.FromArgb(112, 128, 144);
                    CurrentItemAppli.LblOtherInformation.ForeColor = Color.Black;
                    CurrentItemAppli.PnlColorStatus.ForeColor = Color.FromArgb(255, 165, 0);
                }
                CurrentItemAppli = (sender as Control).Parent as ItemAppli;
                Currrent_Id_Appli = CurrentItemAppli.Id_Appli;
                Currrent_TypeTably_Appli = CurrentItemAppli.TypeTably_Appli;
                CurrentItemAppli.BackColor = FormMain.PrimaryColor;
                CurrentItemAppli.LblApplicationType.ForeColor = Color.White;
                CurrentItemAppli.LblStatus.ForeColor = Color.White;
                CurrentItemAppli.PnlColorStatus.ForeColor = Color.White;
                CurrentItemAppli.LblDateEnd.ForeColor = Color.White;
                CurrentItemAppli.LblOtherInformation.ForeColor = Color.White;
            }
        }

        private void Appli_Click(object sender, EventArgs e)
        {
            if (CurrentItemAppli != sender as ItemAppli)
            {
                if (CurrentItemAppli != null)
                {
                    CurrentItemAppli.BackColor = Color.White;
                    CurrentItemAppli.LblApplicationType.ForeColor = Color.Black;
                    CurrentItemAppli.LblStatus.ForeColor = Color.FromArgb(46, 139, 87);
                    CurrentItemAppli.LblDateEnd.ForeColor = Color.FromArgb(112, 128, 144);
                    CurrentItemAppli.LblOtherInformation.ForeColor = Color.Black;
                    CurrentItemAppli.PnlColorStatus.ForeColor = Color.FromArgb(255, 165, 0);
                }
                CurrentItemAppli = sender as ItemAppli;
                Currrent_Id_Appli = CurrentItemAppli.Id_Appli;
                Currrent_TypeTably_Appli = CurrentItemAppli.TypeTably_Appli;
                CurrentItemAppli.BackColor = FormMain.PrimaryColor;
                CurrentItemAppli.LblApplicationType.ForeColor = Color.White;
                CurrentItemAppli.LblStatus.ForeColor = Color.White;
                CurrentItemAppli.PnlColorStatus.ForeColor = Color.White;
                CurrentItemAppli.LblDateEnd.ForeColor = Color.White;
                CurrentItemAppli.LblOtherInformation.ForeColor = Color.White;
            }
        }

        public FormMakeChangesToTheDatabaseDasedOnTheAcceptedStatements()
        {
            InitializeComponent();
        }

        private void FormMakeChangesToTheDatabaseDasedOnTheAcceptedStatements_Load(object sender, EventArgs e)
        {
            BtnCreate.BackColor = FormMain.PrimaryColor;
            FillPanelAppli();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (Currrent_Id_Appli == "" || Currrent_TypeTably_Appli == "")
            {
                MessageBox.Show("Выберите заявку чтобы Выполнить её.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Вы уверены, что хотите выполнить заявку?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection Con = new SqlConnection(FormMain.TxtCon);
                Con.Open();
                string TxtQuarty1 = $@"";
                string TxtQuarty2 = $@"";
                SqlCommand Quarty1;
                SqlDataReader Res;
                switch (Currrent_TypeTably_Appli)
                {
                    case "Applications_For_Employment":
                        TxtQuarty1 = $@"select *
from Applications_For_Employment
where Id_Application = {Currrent_Id_Appli}";
                        Quarty1 = new SqlCommand(TxtQuarty1, Con);
                        Res = Quarty1.ExecuteReader();
                        Res.Read();
                        string Otch = Res["Otch"].ToString();
                        if (Otch == "")
                        {
                            Otch = "NULL";
                        }
                        else
                        {
                            Otch = "'" + Otch + "'";
                        }
                        string Photo = Res["Photo"].ToString();
                        if (Photo == "")
                        {
                            Photo = "NULL";
                        }
                        else
                        {
                            Photo = "'" + Photo + "'";
                        }
                        string Apartment_number = Res["Apartment_number"].ToString();
                        if (Apartment_number == "")
                        {
                            Apartment_number = "NULL";
                        }
                        TxtQuarty2 = $@"
Insert into Worker(Fam, Name, Otch, Phone_number, Role, Salary, Tariff_category, Change, Hours_per_day, Birthdate, Passport_series_number, INN, 
Country_of_residence, Postcode, City, Street, House_number, Apartment_number, Gender, Photo, Date_of_employment, Date_of_dismissal)
values ('{Res["Fam"]}', '{Res["Name"]}', {Otch}, '{Res["Phone_number"]}', '{Res["Role"]}', {Res["Salary"]}, '{Res["Tariff_category"]}', '{Res["Change"]}', {Res["Hours_per_day"]}, '{Convert.ToDateTime(Res["Birthdate"]).ToString("MM.dd.yyyy")}', '{Res["Passport_series_number"]}', '{Res["INN"]}', 
'{Res["Country_of_residence"]}', {Res["Postcode"]}, '{Res["City"]}', '{Res["Street"]}', {Res["House_number"]}, {Apartment_number}, '{Res["Gender"]}', {Photo}, '{DateTime.Now.ToString("MM.dd.yyyy")}', NULL)";
                        Res.Close();
                        Quarty1 = new SqlCommand(TxtQuarty2, Con);
                        Quarty1.ExecuteNonQuery();
                        TxtQuarty1 = $@"
update Applications_For_Employment
set Date_of_the_final_decision_of_the_application = '{DateTime.Now.ToString("MM.dd.yyyy")}'
where Id_Application = {Currrent_Id_Appli}";
                        Quarty1 = new SqlCommand(TxtQuarty1, Con);
                        Quarty1.ExecuteNonQuery();
                        break;
                    case "Application_For_Changing_Personal_Data":
                        TxtQuarty1 = $@"
select *
from Application_For_Changing_Personal_Data
where Id_Application = {Currrent_Id_Appli}";
                        Quarty1 = new SqlCommand(TxtQuarty1, Con);
                        Res = Quarty1.ExecuteReader();
                        Res.Read();
                        Otch = Res["Otch"].ToString();
                        if (Otch == "")
                        {
                            Otch = "NULL";
                        }
                        else
                        {
                            Otch = "'" + Otch + "'";
                        }
                        Photo = Res["Photo"].ToString();
                        if (Photo == "")
                        {
                            Photo = "NULL";
                        }
                        else
                        {
                            Photo = "'" + Photo + "'";
                        }
                        Apartment_number = Res["Apartment_number"].ToString();
                        if (Apartment_number == "")
                        {
                            Apartment_number = "NULL";
                        }
                        TxtQuarty2 = $@"
update Worker
set Fam = '{Res["Fam"]}',
Name = '{Res["Name"]}',
Otch = {Otch},
Phone_number = '{Res["Phone_number"]}',
Role = '{Res["Role"]}',
Salary = {Res["Salary"]},
Tariff_category = '{Res["Tariff_category"]}',
Change = '{Res["Change"]}',
Hours_per_day = {Res["Hours_per_day"]},
Birthdate = '{Convert.ToDateTime(Res["Birthdate"]).ToString("MM.dd.yyyy")}',
Passport_series_number = '{Res["Passport_series_number"]}',
INN = '{Res["INN"]}',
Country_of_residence = '{Res["Country_of_residence"]}',
Postcode = {Res["Postcode"]},
City = '{Res["City"]}',
Street = '{Res["Street"]}',
House_number = {Res["House_number"]},
Apartment_number = {Apartment_number},
Gender = '{Res["Gender"]}',
Photo = {Photo}
where Id_Worker = {Res["Id_Worker"]}";
                        Res.Close();
                        Quarty1 = new SqlCommand(TxtQuarty2, Con);
                        Quarty1.ExecuteNonQuery();

                        TxtQuarty2 = $@"
update Application_For_Changing_Personal_Data
set Date_of_the_final_decision_of_the_application = '{DateTime.Now.ToString("MM.dd.yyyy")}'
where Id_Application = {Currrent_Id_Appli}";
                        Quarty1 = new SqlCommand(TxtQuarty2, Con);
                        Quarty1.ExecuteNonQuery();

                        break;
                    case "Application_For_Dismissal":
                        TxtQuarty1 = $@"
select Id_Worker
from Application_For_Dismissal
where Id_Application = {Currrent_Id_Appli}";
                        Quarty1 = new SqlCommand(TxtQuarty1, Con);
                        Res = Quarty1.ExecuteReader();
                        Res.Read();
                        TxtQuarty2 = $@"
update Worker
set Date_of_dismissal = '{DateTime.Now.ToString("MM.dd.yyyy")}'
where Id_Worker = {Res["Id_Worker"]}";
                        Res.Close();
                        Quarty1 = new SqlCommand(TxtQuarty2, Con);
                        Quarty1.ExecuteNonQuery();

                        TxtQuarty2 = $@"
update Application_For_Dismissal
set Date_of_the_final_decision_of_the_application = '{DateTime.Now.ToString("MM.dd.yyyy")}'
where Id_Application = {Currrent_Id_Appli}";
                        Quarty1 = new SqlCommand(TxtQuarty2, Con);
                        Quarty1.ExecuteNonQuery();
                        break;
                }
                Con.Close();
                MessageBox.Show(@"Заявка успешно выполнена.");
                FillPanelAppli();
                Currrent_Id_Appli = "";
                Currrent_TypeTably_Appli = "";
            }
        }
    }
}

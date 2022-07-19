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
    public partial class FormApplicationForChangingPersonalData : Form
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
        string Id_Worker = "";
        ItemAppli CurrentItemAppli = new ItemAppli();
        string PhotoBase64 = "NULL";
        string Otch = "NULL";
        string NumberAppart = "NULL";

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

                NewItemAppli.Dock = DockStyle.Top;
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
            string Gender = Res["Gender"].ToString();
            switch (Gender)
            {
                case "М":
                    CbxGender.SelectedIndex = 0;
                    break;
                case "Ж":
                    CbxGender.SelectedIndex = 1;
                    break;
            }
            TbxPhone.Text = Res["Phone_number"].ToString();
            TbxRole.Text = Res["Role"].ToString();
            TbxSalary.Text = Res["Salary"].ToString();
            string Graff = Res["Tariff_category"].ToString();
            switch (Graff)
            {
                case "5/2":
                    CbxGraff.SelectedItem = "5/2";
                    break;
                case "2/2":
                    CbxGraff.SelectedItem = "2/2";
                    break;
            }
            string Change = Res["Change"].ToString();
            switch (Change)
            {
                case "Д (Дневная)":
                    CbxChange.SelectedItem = "Д (Дневная)";
                    break;
                case "Н (Ночная)":
                    CbxChange.SelectedItem = "Н (Ночная)";
                    break;
            }
            string CountHours = Res["Hours_per_day"].ToString();
            switch (CountHours)
            {
                case "4":
                    CbxCountHours.SelectedItem = "4";
                    break;
                case "8":
                    CbxCountHours.SelectedItem = "8";
                    break;
            }
            string DateBirthday = Res["Birthdate"].ToString();
            DTPBirthdate.Value = Convert.ToDateTime(DateBirthday);
            TbxPassportSeriesNumber.Text = Res["Passport_series_number"].ToString();
            TbxINN.Text = Res["INN"].ToString();
            TbxCountryOfResidence.Text = Res["Country_of_residence"].ToString();
            TbxCity.Text = Res["City"].ToString();
            TbxIndex.Text = Res["Postcode"].ToString();
            TbxStreet.Text = Res["Street"].ToString();
            TbxHouseNumber.Text = Res["House_number"].ToString();
            string ApartmentNumber = Res["Apartment_number"].ToString();
            if (ApartmentNumber != "")
            {
                TbxApartmentNumber.Text = ApartmentNumber;
            }
            else
            {
                TbxApartmentNumber.Text = "";
            }
            string TxtPhoto = Res["Photo"].ToString();
            if (TxtPhoto != "")
            {
                PhotoBase64 = "'"+TxtPhoto+"'";
                var Photo = Image.FromStream(new MemoryStream(Convert.FromBase64String(TxtPhoto)));
                PbxPhoto.Image = Photo;
            }
            else
            {
                switch (Gender)
                {
                    case "М":
                        PbxPhoto.Image = global::SYBD_ADM_NVZ.Properties.Resources._4086641;
                        ;
                        break;
                    case "Ж":
                        PbxPhoto.Image = global::SYBD_ADM_NVZ.Properties.Resources._4086569;
                        break;
                }
            }

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

        public FormApplicationForChangingPersonalData()
        {
            InitializeComponent();
        }

        private void FormApplicationForChangingPersonalData_Load(object sender, EventArgs e)
        {
            BtnAddPhoto.BackColor = FormMain.PrimaryColor;
            BtnCreateApplication.BackColor = FormMain.PrimaryColor;
            FillPanelAppli();
        }

        private void BtnAddPhoto_Click(object sender, EventArgs e)
        {
            if (OFD1.ShowDialog() == DialogResult.OK)
            {
                PhotoBase64 = Convert.ToBase64String(File.ReadAllBytes(OFD1.FileName));
                var Photo = Image.FromStream(new MemoryStream(Convert.FromBase64String(PhotoBase64)));
                PhotoBase64 = "'" + PhotoBase64 + "'";
                PbxPhoto.Image = Photo;
            }
        }

        private void BtnClearPhoto_Click(object sender, EventArgs e)
        {
            PbxPhoto.Image = null;
            PhotoBase64 = "NULL";
        }

        private void BtnCreateApplication_Click(object sender, EventArgs e)
        {
            if (TbxFam.Text == "")
            {
                MessageBox.Show("Введите Фамилию!");
                return;
            }
            else if (TbxName.Text == "")
            {
                MessageBox.Show("Введите Имя!");
                return;
            }
            else if (TbxPhone.Text == "")
            {
                MessageBox.Show("Введите Номер телефона!");
                return;
            }
            else if (TbxRole.Text == "")
            {
                MessageBox.Show("Введите Должность!");
                return;
            }
            else if (TbxSalary.Text == "")
            {
                MessageBox.Show("Введите Оклад!");
                return;
            }
            else if (TbxPassportSeriesNumber.Text == "")
            {
                MessageBox.Show("Введите Серию и Номер паспорта!");
                return;
            }
            else if (TbxINN.Text == "")
            {
                MessageBox.Show("Введите ИНН!");
                return;
            }
            else if (TbxCountryOfResidence.Text == "")
            {
                MessageBox.Show("Введите Страну проживания!");
                return;
            }
            else if (TbxCity.Text == "")
            {
                MessageBox.Show("Введите Город!");
                return;
            }
            else if (TbxStreet.Text == "")
            {
                MessageBox.Show("Введите Улицу!");
                return;
            }
            else if (TbxHouseNumber.Text == "")
            {
                MessageBox.Show("Введите Номер дома!");
                return;
            }
            else if (TbxIndex.Text == "")
            {
                MessageBox.Show("Введите Индекс!");
                return;
            }
            try
            {
                Convert.ToInt32(TbxSalary.Text);
                Convert.ToInt32(TbxHouseNumber.Text);
                if (NumberAppart != "NULL")
                {
                    Convert.ToInt32(NumberAppart);
                }
            }
            catch
            {
                MessageBox.Show("Некоторые данные заполнены Неверно!");
                return;
            }

            if (MessageBox.Show("Вы уверены, что хотите сформировать заявку?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection Con = new SqlConnection(FormMain.TxtCon);
                Con.Open();
                string TxtQuarty1 = "";
                TxtQuarty1 = $@"
select W.Id_Worker as 'Id_Secretary',
((select top(1) COUNT(AFE.Id_Secretary) as countAppliForChangingPersonalData
from Application_For_Changing_Personal_Data AFE
where W.Id_Worker = AFE.Id_Secretary and AFE.Applications_Status = 'Ожидание'
group by Id_Secretary
order by countAppliForChangingPersonalData asc)) as countAppli
from Worker W
where W.Role = 'Секретарь' 
order by countAppli asc";

                string Fam = TbxFam.Text;
                string Name = TbxName.Text;
                string Phone = TbxPhone.Text;
                string Role = TbxRole.Text;
                string Salary = TbxSalary.Text;
                string Graff = CbxGraff.SelectedItem.ToString();
                string Change = CbxChange.SelectedItem.ToString();
                string CountHours = CbxCountHours.SelectedItem.ToString();
                string PassportSeriesNumber = TbxPassportSeriesNumber.Text;
                string INN = TbxINN.Text;
                string CountryOfResidence = TbxCountryOfResidence.Text;
                string Index = TbxIndex.Text;
                string City = TbxCity.Text;
                string Street = TbxStreet.Text;
                string HouseNumber = TbxHouseNumber.Text;

                SqlCommand Quarty1 = new SqlCommand(TxtQuarty1, Con);
                SqlDataReader Res = Quarty1.ExecuteReader();
                if (Res.HasRows)
                {
                    Res.Read();
                    string IdSecretary = Res["Id_Secretary"].ToString();
                    Res.Close();

                    TxtQuarty1 = $@"
Insert into Application_For_Changing_Personal_Data(Id_Worker, Fam, Name, Otch, Phone_number, Role, Salary, Tariff_category, Change, Hours_per_day, Birthdate, Passport_series_number, INN, 
Country_of_residence, Postcode, City, Street, House_number, Apartment_number, Gender, Photo, Applications_Status, Id_Employee_Of_The_Personnel_Department, 
Id_Secretary, Date_of_the_final_decision_of_the_application)
values ({Id_Worker},'{Fam}','{Name}',{Otch},'{Phone}','{Role}', {Salary}, '{Graff}', 
'{Change}', {CountHours},'{DTPBirthdate.Value.ToString("MM.dd.yyyy")}',
'{PassportSeriesNumber}','{INN}', '{CountryOfResidence}', {Index}, '{City}', '{Street}', 
{HouseNumber}, {NumberAppart},'{CbxGender.SelectedItem}', {PhotoBase64}, 'Ожидание', {FormMain.Id_Special_Worker}, {IdSecretary}, NULL)";

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

                    TxtQuarty1 = $@"
Insert into Application_For_Changing_Personal_Data(Id_Worker, Fam, Name, Otch, Phone_number, Role, Salary, Tariff_category, Change, Hours_per_day, Birthdate, Passport_series_number, INN, 
Country_of_residence, Postcode, City, Street, House_number, Apartment_number, Gender, Photo, Applications_Status, Id_Employee_Of_The_Personnel_Department, 
Id_Secretary, Date_of_the_final_decision_of_the_application)
values ({Id_Worker},'{Fam}','{Name}',{Otch},'{Phone}','{Role}', {Salary}, '{Graff}', 
'{Change}', {CountHours},'{DTPBirthdate.Value.ToString("MM.dd.yyyy")}',
'{PassportSeriesNumber}','{INN}', '{CountryOfResidence}', {Index}, '{City}', '{Street}', 
{HouseNumber}, {NumberAppart},'{CbxGender.SelectedItem}', {PhotoBase64}, 'Принято', {FormMain.Id_Special_Worker}, NULL, '{DateTime.Now.ToString("MM.dd.yyyy")}')";

                    Quarty1 = new SqlCommand(TxtQuarty1, Con);
                    Quarty1.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show(@"Заявка была сформирована и Принята. 
Т.к. система не обнаружила Секретаря, который бы мог её рассмотреть");
                }
                Con.Close();
            }
        }

        private void TbxOtch_TextChanged(object sender, EventArgs e)
        {
            Otch = TbxOtch.Text;
            if (TbxOtch.Text == "")
            {
                Otch = "NULL";
            }
            else
            {
                Otch = "'" + TbxOtch.Text + "'";
            }
        }

        private void TbxApartmentNumber_TextChanged(object sender, EventArgs e)
        {
            NumberAppart = TbxApartmentNumber.Text;
            if (TbxApartmentNumber.Text == "")
            {
                NumberAppart = "NULL";
            }
        }
    }
}

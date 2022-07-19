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
    public partial class FormApplicationForEmployment : Form
    {
        public FormApplicationForEmployment()
        {
            InitializeComponent();
        }

        string PhotoBase64 = "NULL";
        string Otch = "NULL";
        string NumberAppart = "NULL";

        private void LoadTheme()
        {
            BtnCreateApplication.BackColor = FormMain.PrimaryColor;
            BtnCreateApplication.ForeColor = Color.White;
            BtnAddPhoto.BackColor = FormMain.PrimaryColor;
            BtnAddPhoto.ForeColor = Color.White;
            LblMessage.ForeColor = FormMain.PrimaryColor;
            Lbl1.ForeColor = FormMain.PrimaryColor;
            Lbl2.ForeColor = FormMain.PrimaryColor;
        }

        private void FormApplicationForEmployment_Load(object sender, EventArgs e)
        {
            LoadTheme();
            LblMessage.Text = "";
            CbxGender.SelectedIndex = 0;
            CbxGraff.SelectedIndex = 0;
            CbxChange.SelectedIndex = 0;
            CbxCountHours.SelectedIndex = 0;
        }

        private void BtnCreateApplication_Click(object sender, EventArgs e)
        {
            if (CbxGender.SelectedIndex == 0)
            {
                LblMessage.Text = "Выберите пол!";
                return;
            }
            else if (TbxFam.Text == "")
            {
                LblMessage.Text = "Введите Фамилию!";
                return;
            }
            else if (TbxName.Text == "")
            {
                LblMessage.Text = "Введите Имя!";
                return;
            }
            else if (TbxPhone.Text == "")
            {
                LblMessage.Text = "Введите Номер телефона!";
                return;
            }
            else if (TbxRole.Text == "")
            {
                LblMessage.Text = "Введите Должность!";
                return;
            }
            else if (TbxSalary.Text == "")
            {
                LblMessage.Text = "Введите Оклад!";
                return;
            }
            else if (CbxGraff.SelectedIndex == 0)
            {
                LblMessage.Text = "Выберите График работы!";
                return;
            }
            else if (CbxChange.SelectedIndex == 0)
            {
                LblMessage.Text = "Выберите Смену!";
                return;
            }
            else if (CbxCountHours.SelectedIndex == 0)
            {
                LblMessage.Text = "Выберите Кол-во часов работы в день!";
                return;
            }
            else if (TbxPassportSeriesNumber.Text == "")
            {
                LblMessage.Text = "Введите Серию и Номер паспорта!";
                return;
            }
            else if (TbxINN.Text == "")
            {
                LblMessage.Text = "Введите ИНН!";
                return;
            }
            else if (TbxCountryOfResidence.Text == "")
            {
                LblMessage.Text = "Введите Страну проживания!";
                return;
            }
            else if (TbxCity.Text == "")
            {
                LblMessage.Text = "Введите Город!";
                return;
            }
            else if (TbxStreet.Text == "")
            {
                LblMessage.Text = "Введите Улицу!";
                return;
            }
            else if (TbxHouseNumber.Text == "")
            {
                LblMessage.Text = "Введите Номер дома!";
                return;
            }
            else if (TbxIndex.Text == "")
            {
                LblMessage.Text = "Введите Индекс!";
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
                LblMessage.Text = "Некоторые данные заполнены Неверно!";
                return;
            }

            SqlConnection Con = new SqlConnection(FormMain.TxtCon);
            Con.Open();
            string TxtQuarty1 = "";
            TxtQuarty1 = $@"
select W.Id_Worker as 'Id_Secretary',
((select top(1) COUNT(AFE.Id_Secretary) as countAppliForEmployment
from Applications_For_Employment AFE
where W.Id_Worker = AFE.Id_Secretary and AFE.Applications_Status = 'Ожидание'
group by Id_Secretary
order by countAppliForEmployment asc)) as countAppli
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

            if (MessageBox.Show("Вы уверены, что хотите сформировать заявку?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand Quarty1 = new SqlCommand(TxtQuarty1, Con);
                SqlDataReader Res = Quarty1.ExecuteReader();
                if (Res.HasRows)
                {
                    Res.Read();
                    string IdSecretary = Res["Id_Secretary"].ToString();
                    Res.Close();

                    TxtQuarty1 = $@"
Insert into Applications_For_Employment(Fam, Name, Otch, Phone_number, Role, Salary, Tariff_category, Change, Hours_per_day, Birthdate, Passport_series_number, INN, 
Country_of_residence, Postcode, City, Street, House_number, Apartment_number, Gender, Photo, Applications_Status, Id_Employee_Of_The_Personnel_Department, 
Id_Secretary, Date_of_the_final_decision_of_the_application)
values ('{Fam}','{Name}',{Otch},'{Phone}','{Role}', {Salary}, '{Graff}', 
'{Change}', {CountHours},'{DTPBirthdate.Value.ToString("MM.dd.yyyy")}',
'{PassportSeriesNumber}','{INN}', '{CountryOfResidence}', {Index}, '{City}', '{Street}', 
{HouseNumber}, {NumberAppart},'{CbxGender.SelectedItem}', {PhotoBase64}, 'Ожидание', {FormMain.Id_Special_Worker}, {IdSecretary}, NULL)";

                    Quarty1 = new SqlCommand(TxtQuarty1, Con);
                    Quarty1.ExecuteNonQuery();
                    Con.Close();
                    LblMessage.Text = "";
                    MessageBox.Show(@"Заявка сформирована и успешно отправлена. 
Заявке присвоен статус - Ожидания. 
Статус изменится, когда Секретарь расмотрит её и вынесет решение.");
                }
                else
                {
                    Res.Close();

                    TxtQuarty1 = $@"
Insert into Applications_For_Employment(Fam, Name, Otch, Phone_number, Role, Salary, Tariff_category, Change, Hours_per_day, Birthdate, Passport_series_number, INN, 
Country_of_residence, Postcode, City, Street, House_number, Apartment_number, Gender, Photo, Applications_Status, Id_Employee_Of_The_Personnel_Department, 
Id_Secretary, Date_of_the_final_decision_of_the_application)
values ('{Fam}','{Name}',{Otch},'{Phone}','{Role}', {Salary}, '{Graff}', 
'{Change}', {CountHours},'{DTPBirthdate.Value.ToString("MM.dd.yyyy")}',
'{PassportSeriesNumber}','{INN}', '{CountryOfResidence}', {Index}, '{City}', '{Street}', 
{HouseNumber}, {NumberAppart},'{CbxGender.SelectedItem}', {PhotoBase64}, 'Принято', {FormMain.Id_Special_Worker}, NULL, '{DateTime.Now.ToString("MM.dd.yyyy")}')";

                    Quarty1 = new SqlCommand(TxtQuarty1, Con);
                    Quarty1.ExecuteNonQuery();
                    Con.Close();
                    LblMessage.Text = "";
                    MessageBox.Show(@"Заявка была сформирована и Принята. 
Т.к. система не обнаружила Секретаря, который бы мог её рассмотреть");
                }
            }
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

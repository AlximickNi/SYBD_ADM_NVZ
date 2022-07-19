using SYBD_ADM_NVZ.Properties;
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

namespace SYBD_ADM_NVZ.Forms
{
    public partial class FormProfile : Form
    {
        public FormProfile()
        {
            InitializeComponent();
            GetEmployeeData();
        }

        public void GetEmployeeData()
        {
            SqlConnection Con = new SqlConnection(FormMain.TxtCon);
            Con.Open();
            string TXtQuarty1 = $@"
select  W.*, AOSW.PinCode
from Worker W, Account_Of_Special_Worker AOSW
where Id_Worker = {FormMain.Id_Special_Worker} and W.Id_Worker = AOSW.Id_Special_Worker
";
            SqlCommand Quarty1 = new SqlCommand(TXtQuarty1, Con);
            SqlDataReader Res = Quarty1.ExecuteReader();
            Res.Read();
            LblFIO.Text = $"ФИО: {Res["Fam"]} {Res["Name"]} {Res["Otch"]}";
            LblDateOfEmployment.Text = $"Дата приёма на работу: {Convert.ToDateTime(Res["Date_of_employment"]).ToShortDateString()}";
            LblRole.Text = $"Должность: {Res["Role"]}";
            LblSalary.Text = $"Оклад: {Res["Salary"]}";
            LblAdress.Text = $"Место проживания: {Res["Country_of_residence"]} {Res["City"]}  {Res["Street"]} {Res["House_number"]} {Res["Apartment_number"]}";
            LblPinCode.Text = $@"Ваш Pin-Cod: {Res["PinCode"]}";
            string Gender = Res["Gender"].ToString();
            TXtQuarty1 = $@"
select Photo
from Worker
where Id_Worker = {FormMain.Id_Special_Worker}";
            Res.Close();
            Quarty1 = new SqlCommand(TXtQuarty1, Con);
            Res = Quarty1.ExecuteReader();
            if (Res.HasRows)
            {
                Res.Read();
                if (Res["Photo"].ToString() != "")
                {
                    try
                    {
                        var Photo = Image.FromStream(new MemoryStream(Convert.FromBase64String(Res["Photo"].ToString())));
                        PbxPhoto.Image = Photo;
                    }
                    catch
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
            Con.Close();
        }

        private void BtnEditPhoto_Click(object sender, EventArgs e)
        {
            if(OFD1.ShowDialog() == DialogResult.OK)
            {
                string PhotoBase64 = Convert.ToBase64String(File.ReadAllBytes(OFD1.FileName));
                SqlConnection Con = new SqlConnection(FormMain.TxtCon);
                Con.Open();
                string TXtQuarty1 = $@"
update Worker
set Photo = '{PhotoBase64}'
where Id_Worker = {FormMain.Id_Special_Worker}
";
                SqlCommand Quarty1 = new SqlCommand(TXtQuarty1, Con);
                Quarty1.ExecuteNonQuery();
                TXtQuarty1 = $@"
select Photo
from Worker
where Id_Worker = {FormMain.Id_Special_Worker}";
                Quarty1 = new SqlCommand(TXtQuarty1, Con);
                SqlDataReader Res = Quarty1.ExecuteReader();
                Res.Read();
                var Photo = Image.FromStream(new MemoryStream(Convert.FromBase64String(Res["Photo"].ToString())));
                PbxPhoto.Image = Photo;
                Con.Close();
            }
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {

        }
    }
}

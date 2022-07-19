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

namespace SYBD_ADM_NVZ.Forms
{
    public partial class FormAuthorization : Form
    {
        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void FormAuthorization_Load(object sender, EventArgs e)
        {
            LoadTheme();
            CbxRoles.SelectedIndex = 0;
            LblMessage.Text = "";
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = FormMain.PrimaryColor;
                    btn.ForeColor = Color.White;
                }
            }
            LblMessage.ForeColor = FormMain.PrimaryColor;
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if(CbxRoles.SelectedIndex == 0)
            {
                LblMessage.Text = "Выберите роль!";
                return;
            }
            else if(TbxLogin.Text == "")
            {
                LblMessage.Text = "Введите логин!";
                return;
            }
            else if (TbxPassword.Text == "")
            {
                LblMessage.Text = "Введите пароль!";
                return;
            }
            else if (TbxPinCode.Text == "" && CbxRoles.SelectedItem == "Системный администратор")
            {
               LblMessage.Text = "Введите пин-код!";
               return;
            }

            SqlConnection Con = new SqlConnection(FormMain.TxtCon);
            Con.Open();
            string TXtQuarty1 = $@"
select AOSW.Id_Special_Worker as Id_Worker
from Worker W, Account_Of_Special_Worker AOSW
where W.Id_Worker = AOSW.Id_Special_Worker 
and W.Role = '{CbxRoles.SelectedItem}' 
and AOSW.Login = '{TbxLogin.Text}'
and AOSW.Password = '{TbxPassword.Text}'
and W.Date_of_dismissal is null";
            SqlCommand Quarty1 = new SqlCommand(TXtQuarty1, Con);
            SqlDataReader Res = Quarty1.ExecuteReader();
            if (Res.HasRows)
            {
                Res.Read();
                FormMain.Id_Special_Worker = Res["Id_Worker"].ToString();
                FormMain.Role_Special_Worker = CbxRoles.SelectedItem.ToString();
                FormMain.Authorized = true;
                LblMessage.Text = "";
            }
            else
            {             
                LblMessage.Text = "Сотрудника с подобными данными не найдено!\r\n" +
                    "Попробуйте ещё раз.";
            }
            Con.Close();
        }

        private void CbxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CbxRoles.SelectedItem == "Системный администратор")
            {
                TbxPinCode.Text = "";
                TbxPinCode.Visible = true;
                PnlPinCode.Visible = true;
                PbxPincode.Visible = true;
                LblPin.Visible = true;
            }
            else
            {
                TbxPinCode.Text = "";
                TbxPinCode.Visible = false;
                PnlPinCode.Visible = false;
                PbxPincode.Visible = false;
                LblPin.Visible = false;
            }
        }
    }
}

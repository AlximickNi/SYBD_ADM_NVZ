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
    public partial class FormCheckAndIssueLoginDetailsForSpecialWorkers : Form
    {
        class ItemWorker : Panel
        {
            public System.Windows.Forms.Panel panel6;
            public System.Windows.Forms.Label LblFIO;
            public System.Windows.Forms.TextBox TbxPinCode;
            public System.Windows.Forms.Label LblPinCode;
            public System.Windows.Forms.TextBox TbxPassword;
            public System.Windows.Forms.Panel panel5;
            public System.Windows.Forms.Label LblPassword;
            public System.Windows.Forms.TextBox TbxLogin;
            public System.Windows.Forms.Panel panel4;
            public System.Windows.Forms.Label LblLogine;
            public System.Windows.Forms.TextBox TbxRole;
            public System.Windows.Forms.Panel panel3;
            public System.Windows.Forms.Label LblRole;
            public System.Windows.Forms.TextBox TbxFIO;
            public System.Windows.Forms.Panel panel2;
            public System.Windows.Forms.Button BtnCheckAndSave;
            public System.Windows.Forms.Panel panel8;
            public System.Windows.Forms.Panel panel7;
            public string ID_Worker = "";
            public string Login = "";
            public string Password = "";
            public string PINCODE = "";
            public ItemWorker()
            {
                this.LblFIO = new System.Windows.Forms.Label();
                this.TbxFIO = new System.Windows.Forms.TextBox();
                this.panel2 = new System.Windows.Forms.Panel();
                this.LblRole = new System.Windows.Forms.Label();
                this.TbxRole = new System.Windows.Forms.TextBox();
                this.panel3 = new System.Windows.Forms.Panel();
                this.TbxLogin = new System.Windows.Forms.TextBox();
                this.panel4 = new System.Windows.Forms.Panel();
                this.LblLogine = new System.Windows.Forms.Label();
                this.TbxPassword = new System.Windows.Forms.TextBox();
                this.panel5 = new System.Windows.Forms.Panel();
                this.LblPassword = new System.Windows.Forms.Label();
                this.TbxPinCode = new System.Windows.Forms.TextBox();
                this.panel6 = new System.Windows.Forms.Panel();
                this.LblPinCode = new System.Windows.Forms.Label();
                this.BtnCheckAndSave = new System.Windows.Forms.Button();
                this.panel7 = new System.Windows.Forms.Panel();
                this.panel8 = new System.Windows.Forms.Panel();

                // 
                // panel1
                // 
                this.BackColor = System.Drawing.Color.WhiteSmoke;
                this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.Controls.Add(this.panel8);
                this.Controls.Add(this.panel7);
                this.Location = new System.Drawing.Point(223, 63);
                this.Name = "panel1";
                this.Size = new System.Drawing.Size(439, 283);
                this.TabIndex = 0;
                // 
                // LblFIO
                // 
                this.LblFIO.AutoSize = true;
                this.LblFIO.Font = new System.Drawing.Font("Segoe UI", 14.25F);
                this.LblFIO.ForeColor = System.Drawing.Color.Gray;
                this.LblFIO.Location = new System.Drawing.Point(15, 7);
                this.LblFIO.Name = "LblFIO";
                this.LblFIO.Size = new System.Drawing.Size(58, 25);
                this.LblFIO.TabIndex = 15;
                this.LblFIO.Text = "ФИО:";
                // 
                // TbxFIO
                // 
                this.TbxFIO.BackColor = System.Drawing.Color.WhiteSmoke;
                this.TbxFIO.BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.TbxFIO.Font = new System.Drawing.Font("Segoe UI", 14.25F);
                this.TbxFIO.ForeColor = System.Drawing.Color.Black;
                this.TbxFIO.Location = new System.Drawing.Point(79, 6);
                this.TbxFIO.Name = "TbxFIO";
                this.TbxFIO.ReadOnly = true;
                this.TbxFIO.Size = new System.Drawing.Size(336, 26);
                this.TbxFIO.TabIndex = 16;
                // 
                // panel2
                // 
                this.panel2.BackColor = System.Drawing.Color.Black;
                this.panel2.Location = new System.Drawing.Point(79, 33);
                this.panel2.Name = "panel2";
                this.panel2.Size = new System.Drawing.Size(346, 1);
                this.panel2.TabIndex = 17;
                // 
                // LblRole
                // 
                this.LblRole.AutoSize = true;
                this.LblRole.Font = new System.Drawing.Font("Segoe UI", 14.25F);
                this.LblRole.ForeColor = System.Drawing.Color.Gray;
                this.LblRole.Location = new System.Drawing.Point(15, 45);
                this.LblRole.Name = "LblRole";
                this.LblRole.Size = new System.Drawing.Size(58, 25);
                this.LblRole.TabIndex = 18;
                this.LblRole.Text = "Роль:";
                // 
                // TbxRole
                // 
                this.TbxRole.BackColor = System.Drawing.Color.WhiteSmoke;
                this.TbxRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.TbxRole.Font = new System.Drawing.Font("Segoe UI", 14.25F);
                this.TbxRole.ForeColor = System.Drawing.Color.Black;
                this.TbxRole.Location = new System.Drawing.Point(79, 45);
                this.TbxRole.Name = "TbxRole";
                this.TbxRole.ReadOnly = true;
                this.TbxRole.Size = new System.Drawing.Size(336, 26);
                this.TbxRole.TabIndex = 19;
                // 
                // panel3
                // 
                this.panel3.BackColor = System.Drawing.Color.Black;
                this.panel3.Location = new System.Drawing.Point(79, 72);
                this.panel3.Name = "panel3";
                this.panel3.Size = new System.Drawing.Size(346, 1);
                this.panel3.TabIndex = 20;
                // 
                // TbxLogin
                // 
                this.TbxLogin.BackColor = System.Drawing.Color.WhiteSmoke;
                this.TbxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.TbxLogin.Font = new System.Drawing.Font("Segoe UI", 14.25F);
                this.TbxLogin.ForeColor = System.Drawing.Color.Black;
                this.TbxLogin.Location = new System.Drawing.Point(111, 93);
                this.TbxLogin.Name = "TbxLogin";
                this.TbxLogin.Size = new System.Drawing.Size(304, 26);
                this.TbxLogin.TabIndex = 22;
                // 
                // panel4
                // 
                this.panel4.BackColor = System.Drawing.Color.Black;
                this.panel4.Location = new System.Drawing.Point(111, 120);
                this.panel4.Name = "panel4";
                this.panel4.Size = new System.Drawing.Size(314, 1);
                this.panel4.TabIndex = 23;
                // 
                // LblLogine
                // 
                this.LblLogine.AutoSize = true;
                this.LblLogine.Font = new System.Drawing.Font("Segoe UI", 14.25F);
                this.LblLogine.ForeColor = System.Drawing.Color.Gray;
                this.LblLogine.Location = new System.Drawing.Point(15, 96);
                this.LblLogine.Name = "LblLogine";
                this.LblLogine.Size = new System.Drawing.Size(82, 25);
                this.LblLogine.TabIndex = 21;
                this.LblLogine.Text = "* Логин:";
                // 
                // TbxPassword
                // 
                this.TbxPassword.BackColor = System.Drawing.Color.WhiteSmoke;
                this.TbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.TbxPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F);
                this.TbxPassword.ForeColor = System.Drawing.Color.Black;
                this.TbxPassword.Location = new System.Drawing.Point(111, 127);
                this.TbxPassword.Name = "TbxPassword";
                this.TbxPassword.Size = new System.Drawing.Size(304, 26);
                this.TbxPassword.TabIndex = 25;
                // 
                // panel5
                // 
                this.panel5.BackColor = System.Drawing.Color.Black;
                this.panel5.Location = new System.Drawing.Point(111, 154);
                this.panel5.Name = "panel5";
                this.panel5.Size = new System.Drawing.Size(314, 1);
                this.panel5.TabIndex = 26;
                // 
                // LblPassword
                // 
                this.LblPassword.AutoSize = true;
                this.LblPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F);
                this.LblPassword.ForeColor = System.Drawing.Color.Gray;
                this.LblPassword.Location = new System.Drawing.Point(7, 130);
                this.LblPassword.Name = "LblPassword";
                this.LblPassword.Size = new System.Drawing.Size(95, 25);
                this.LblPassword.TabIndex = 24;
                this.LblPassword.Text = "* Пароль:";
                // 
                // TbxPinCode
                // 
                this.TbxPinCode.BackColor = System.Drawing.Color.WhiteSmoke;
                this.TbxPinCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.TbxPinCode.Font = new System.Drawing.Font("Segoe UI", 14.25F);
                this.TbxPinCode.ForeColor = System.Drawing.Color.Black;
                this.TbxPinCode.Location = new System.Drawing.Point(116, 196);
                this.TbxPinCode.Name = "TbxPinCode";
                this.TbxPinCode.Size = new System.Drawing.Size(97, 26);
                this.TbxPinCode.TabIndex = 28;
                // 
                // panel6
                // 
                this.panel6.BackColor = System.Drawing.Color.Black;
                this.panel6.Location = new System.Drawing.Point(111, 224);
                this.panel6.Name = "panel6";
                this.panel6.Size = new System.Drawing.Size(107, 1);
                this.panel6.TabIndex = 29;
                // 
                // LblPinCode
                // 
                this.LblPinCode.AutoSize = true;
                this.LblPinCode.Font = new System.Drawing.Font("Segoe UI", 14.25F);
                this.LblPinCode.ForeColor = System.Drawing.Color.Gray;
                this.LblPinCode.Location = new System.Drawing.Point(7, 197);
                this.LblPinCode.Name = "LblPinCode";
                this.LblPinCode.Size = new System.Drawing.Size(103, 25);
                this.LblPinCode.TabIndex = 27;
                this.LblPinCode.Text = "* Пин-код:";
                // 
                // BtnCheckAndSave
                // 
                this.BtnCheckAndSave.BackColor = System.Drawing.Color.Silver;
                this.BtnCheckAndSave.FlatAppearance.BorderSize = 0;
                this.BtnCheckAndSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.BtnCheckAndSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.BtnCheckAndSave.ForeColor = System.Drawing.Color.White;
                this.BtnCheckAndSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
                this.BtnCheckAndSave.Location = new System.Drawing.Point(273, 183);
                this.BtnCheckAndSave.Name = "BtnCheckAndSave";
                this.BtnCheckAndSave.Size = new System.Drawing.Size(152, 42);
                this.BtnCheckAndSave.TabIndex = 30;
                this.BtnCheckAndSave.Text = "Проверить и сохранить";
                this.BtnCheckAndSave.UseVisualStyleBackColor = false;
                // 
                // panel7
                // 
                this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
                this.panel7.Location = new System.Drawing.Point(0, 0);
                this.panel7.Name = "panel7";
                this.panel7.Size = new System.Drawing.Size(437, 42);
                this.panel7.TabIndex = 0;
                // 
                // panel8
                // 
                this.panel8.Controls.Add(this.BtnCheckAndSave);
                this.panel8.Controls.Add(this.TbxFIO);
                this.panel8.Controls.Add(this.panel4);
                this.panel8.Controls.Add(this.TbxPinCode);
                this.panel8.Controls.Add(this.LblLogine);
                this.panel8.Controls.Add(this.TbxLogin);
                this.panel8.Controls.Add(this.panel6);
                this.panel8.Controls.Add(this.TbxRole);
                this.panel8.Controls.Add(this.LblFIO);
                this.panel8.Controls.Add(this.LblPassword);
                this.panel8.Controls.Add(this.LblPinCode);
                this.panel8.Controls.Add(this.panel3);
                this.panel8.Controls.Add(this.panel2);
                this.panel8.Controls.Add(this.panel5);
                this.panel8.Controls.Add(this.TbxPassword);
                this.panel8.Controls.Add(this.LblRole);
                this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
                this.panel8.Location = new System.Drawing.Point(0, 42);
                this.panel8.Name = "panel8";
                this.panel8.Size = new System.Drawing.Size(437, 239);
                this.panel8.TabIndex = 1;
            }
        }

        void FillPanelWorkers()
        {
            FPNLSpWorkers.Controls.Clear();
            SqlConnection Con = new SqlConnection(FormMain.TxtCon);
            Con.Open();
            string TxtQuarty1 = $@"
select W.Id_Worker, W.Fam, W.Name, W.Otch, W.Role, (select ACOSW.Login
from Account_Of_Special_Worker ACOSW
where ACOSW.Id_Special_Worker = W.Id_Worker) as 'Login', 
(select ACOSW.Password
from Account_Of_Special_Worker ACOSW
where ACOSW.Id_Special_Worker = W.Id_Worker) as 'Password', 
(select ACOSW.PinCode
from Account_Of_Special_Worker ACOSW
where ACOSW.Id_Special_Worker = W.Id_Worker) as 'Pincode'
from Worker W
where W.Date_of_dismissal is null
and W.Role = 'Секретарь' or W.Role = 'Специалист по кадрам' or W.Role = 'Системный администратор'";
            SqlCommand Quarty1 = new SqlCommand(TxtQuarty1, Con);
            SqlDataReader Res = Quarty1.ExecuteReader();
            while (Res.Read())
            {
                ItemWorker NewWorker = new ItemWorker();
                string Otch = Res["Otch"].ToString();
                NewWorker.TbxFIO.Text = $@"{Res["Fam"]} {Res["Name"]} {Otch}";
                NewWorker.TbxRole.Text = $@"{Res["Role"]}";
                NewWorker.ID_Worker = $@"{Res["Id_Worker"]}";

                NewWorker.Login = $@"{Res["Login"]}";
                NewWorker.Password = $@"{Res["Password"]}";
                NewWorker.PINCODE = $@"{Res["Pincode"]}";

                if (NewWorker.Login != "" && NewWorker.Password != "" && NewWorker.PINCODE != "")
                {
                    NewWorker.TbxLogin.ReadOnly = true;
                    NewWorker.TbxPassword.ReadOnly = true;
                    NewWorker.TbxPinCode.ReadOnly = false;
                    NewWorker.TbxLogin.Text = "Есть";
                    NewWorker.TbxPassword.Text = "Есть";
                    NewWorker.TbxLogin.ForeColor = Color.Gray;
                    NewWorker.TbxPassword.ForeColor = Color.Gray;
                    NewWorker.TbxPinCode.Text = "";
                }
                else
                {
                    NewWorker.TbxLogin.ReadOnly = false;
                    NewWorker.TbxPassword.ReadOnly = false;
                    NewWorker.TbxPinCode.ReadOnly = false;
                    NewWorker.TbxLogin.Text = "Нет";
                    NewWorker.TbxPassword.Text = "Нет";
                    NewWorker.TbxPinCode.Text = "";
                }

                NewWorker.BtnCheckAndSave.Click += BtnCheckAndSave_Click;
                NewWorker.BtnCheckAndSave.BackColor = FormMain.PrimaryColor;
                NewWorker.panel7.BackColor = FormMain.PrimaryColor;
                FPNLSpWorkers.Controls.Add(NewWorker);
            }
            Con.Close();
        }

        private void BtnCheckAndSave_Click(object sender, EventArgs e)
        {
            ItemWorker Worker = ((sender as Control).Parent).Parent as ItemWorker;
            if (Worker.PINCODE != "")
            {
                if (Worker.TbxPinCode.Text == Worker.PINCODE)
                {
                    if (Worker.TbxLogin.Text == "Есть" && Worker.TbxPassword.Text == "Есть" && Worker.TbxLogin.ReadOnly && Worker.TbxPassword.ReadOnly)
                    {
                        Worker.TbxLogin.ForeColor = Color.Black;
                        Worker.TbxPassword.ForeColor = Color.Black;
                        Worker.TbxLogin.ReadOnly = false;
                        Worker.TbxPassword.ReadOnly = false;
                        Worker.TbxLogin.Text = Worker.Login;
                        Worker.TbxPassword.Text = Worker.Password;
                    }
                    else
                    {
                        if (Worker.TbxLogin.Text == "" || Worker.TbxPassword.Text == ""
                         || Worker.TbxLogin.Text == "Нет" || Worker.TbxPassword.Text == "Нет"
                         || Worker.TbxLogin.Text == "Есть" || Worker.TbxPassword.Text == "Есть")
                        {
                            MessageBox.Show("Логин и пароль не могут быть пустыми или равнятся системным обозначениям!");
                            return;
                        }
                        SqlConnection Con = new SqlConnection(FormMain.TxtCon);
                        Con.Open();
                        string TxtQuarty1 = $@"
update Account_Of_Special_Worker
set Login = '{Worker.TbxLogin.Text}',
Password = '{Worker.TbxPassword.Text}',
Pincode = '{Worker.TbxPinCode.Text}'
where Id_Special_Worker = {Worker.ID_Worker}";
                        SqlCommand Quarty1 = new SqlCommand(TxtQuarty1, Con);
                        Quarty1.ExecuteNonQuery();
                        Quarty1 = new SqlCommand(TxtQuarty1, Con);
                        Quarty1.ExecuteNonQuery();
                        Con.Close();
                        MessageBox.Show("Данные для входа сотрудника обновлены!");
                        FillPanelWorkers();
                    }
                }
                else
                {
                    Worker.TbxLogin.Text = "Есть";
                    Worker.TbxPassword.Text = "Есть";
                    MessageBox.Show("PINCODE сотрудника не верный!");
                }
            }
            else
            {
                if (Worker.TbxPinCode.Text.Length != 4 || Worker.TbxPinCode.Text == "")
                {
                    MessageBox.Show("ПИНКОД должен состоять из четырёх символов!");
                    return;
                }
                if (Worker.TbxLogin.Text == "" || Worker.TbxPassword.Text == ""
                    || Worker.TbxLogin.Text == "Нет" || Worker.TbxPassword.Text == "Нет"
                    || Worker.TbxLogin.Text == "Есть" || Worker.TbxPassword.Text == "Есть")
                {
                    MessageBox.Show("Логин и пароль не могут быть пустыми или равнятся системным обозначениям!");
                    return;
                }
                SqlConnection Con = new SqlConnection(FormMain.TxtCon);
                Con.Open();
                string TxtQuarty1 = $@"
insert Account_Of_Special_Worker(Id_Special_Worker, Login, Password, PinCode)
values({Worker.ID_Worker}, '{Worker.TbxLogin.Text}', '{Worker.TbxPassword.Text}', '{Worker.TbxPinCode.Text}')";
                SqlCommand Quarty1 = new SqlCommand(TxtQuarty1, Con);
                Quarty1.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Данные для входа сотрудника добавлены!");
                FillPanelWorkers();
            }
        }

        public FormCheckAndIssueLoginDetailsForSpecialWorkers()
        {
            InitializeComponent();
        }

        private void FormCheckAndIssueLoginDetailsForSpecialWorkers_Load(object sender, EventArgs e)
        {
            FillPanelWorkers();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace SYBD_ADM_NVZ
{
    public partial class FormMain : Form
    {
        public void AddButtonExitProfile()
        {
            Button BtnExitProfile = new Button();
            BtnExitProfile.Dock = DockStyle.Top;
            BtnExitProfile.FlatStyle = FlatStyle.Flat;
            BtnExitProfile.Text = "Выйти из кабинета";
            BtnExitProfile.TextAlign = ContentAlignment.MiddleLeft;
            BtnExitProfile.Click += BtnExitProfile_Click;
            BtnExitProfile.ForeColor = Color.Gainsboro;
            BtnExitProfile.FlatAppearance.BorderSize = 0;
            BtnExitProfile.Size = new Size(214, 70);
            BtnExitProfile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            PnlMenu.Controls.Add(BtnExitProfile);
        }

        private void BtnExitProfile_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы хотите выйти из личного кабинета?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Id_Special_Worker = "";
                Role_Special_Worker = "";
                Authorized = false;
                PnlMenu.Controls.Clear();
                PnlDesktopForm.Controls.Clear();
                AddButtonOpenAuthorization();
                ResetMain();
            }
        }

        public void AddButtonOpenAuthorization()
        {
            Button BtnOpenAuthorization = new Button();
            BtnOpenAuthorization.Dock = DockStyle.Top;
            BtnOpenAuthorization.FlatStyle = FlatStyle.Flat;
            BtnOpenAuthorization.Text = "Вход в личный кабинет";
            BtnOpenAuthorization.TextAlign = ContentAlignment.MiddleLeft;
            BtnOpenAuthorization.Click += BtnOpenAuthorization_Click;
            BtnOpenAuthorization.ForeColor = Color.Gainsboro;
            BtnOpenAuthorization.FlatAppearance.BorderSize = 0;
            BtnOpenAuthorization.Size = new Size(214, 70);
            BtnOpenAuthorization.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            PnlMenu.Controls.Add(BtnOpenAuthorization);
        }

        private void BtnOpenAuthorization_Click(object sender, EventArgs e)
        {
            if (Id_Special_Worker == "" && Authorized == false)
            {
                TmMain.Enabled = true;
            }
            OpenChildForm(new Forms.FormAuthorization(), sender);
        }

        public void AddButtonsFromEmployeeOfThePersonnelDepartment()
        {                      
            Button BtnOpenApplicationForDismissal = new Button();
            BtnOpenApplicationForDismissal.Dock = DockStyle.Top;
            BtnOpenApplicationForDismissal.FlatStyle = FlatStyle.Flat;
            BtnOpenApplicationForDismissal.Text = "Заявление для увольнения работника";
            BtnOpenApplicationForDismissal.TextAlign = ContentAlignment.MiddleLeft;
            BtnOpenApplicationForDismissal.Click += BtnOpenFormsEmployeeOfThePersonnelDepartment_Click;
            BtnOpenApplicationForDismissal.ForeColor = Color.Gainsboro;
            BtnOpenApplicationForDismissal.FlatAppearance.BorderSize = 0;
            BtnOpenApplicationForDismissal.Size = new Size(214, 70);
            BtnOpenApplicationForDismissal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            PnlMenu.Controls.Add(BtnOpenApplicationForDismissal);
            Button BtnOpenApplicationsVacationOrSickLeave = new Button();
            BtnOpenApplicationsVacationOrSickLeave.Dock = DockStyle.Top;
            BtnOpenApplicationsVacationOrSickLeave.FlatStyle = FlatStyle.Flat;
            BtnOpenApplicationsVacationOrSickLeave.Text = "Заявление для отпуска или больничного";
            BtnOpenApplicationsVacationOrSickLeave.TextAlign = ContentAlignment.MiddleLeft;
            BtnOpenApplicationsVacationOrSickLeave.Click += BtnOpenFormsEmployeeOfThePersonnelDepartment_Click;
            BtnOpenApplicationsVacationOrSickLeave.ForeColor = Color.Gainsboro;
            BtnOpenApplicationsVacationOrSickLeave.FlatAppearance.BorderSize = 0;
            BtnOpenApplicationsVacationOrSickLeave.Size = new Size(214, 70);
            BtnOpenApplicationsVacationOrSickLeave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            PnlMenu.Controls.Add(BtnOpenApplicationsVacationOrSickLeave);
            Button BtnOpenApplicationForChangingPersonal_Data = new Button();
            BtnOpenApplicationForChangingPersonal_Data.Dock = DockStyle.Top;
            BtnOpenApplicationForChangingPersonal_Data.FlatStyle = FlatStyle.Flat;
            BtnOpenApplicationForChangingPersonal_Data.Text = "Заявление для изменения личных данных сотрудника";
            BtnOpenApplicationForChangingPersonal_Data.TextAlign = ContentAlignment.MiddleLeft;
            BtnOpenApplicationForChangingPersonal_Data.Click += BtnOpenFormsEmployeeOfThePersonnelDepartment_Click;
            BtnOpenApplicationForChangingPersonal_Data.ForeColor = Color.Gainsboro;
            BtnOpenApplicationForChangingPersonal_Data.FlatAppearance.BorderSize = 0;
            BtnOpenApplicationForChangingPersonal_Data.Size = new Size(214, 70);
            BtnOpenApplicationForChangingPersonal_Data.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            PnlMenu.Controls.Add(BtnOpenApplicationForChangingPersonal_Data);
            Button BtnOpenApplicationForEmployment = new Button();
            BtnOpenApplicationForEmployment.Dock = DockStyle.Top;
            BtnOpenApplicationForEmployment.FlatStyle = FlatStyle.Flat;
            BtnOpenApplicationForEmployment.Text = "Заявление для принятия на работу";
            BtnOpenApplicationForEmployment.TextAlign = ContentAlignment.MiddleLeft;
            BtnOpenApplicationForEmployment.Click += BtnOpenFormsEmployeeOfThePersonnelDepartment_Click; ;
            BtnOpenApplicationForEmployment.ForeColor = Color.Gainsboro;
            BtnOpenApplicationForEmployment.FlatAppearance.BorderSize = 0;
            BtnOpenApplicationForEmployment.Size = new Size(214, 70);
            BtnOpenApplicationForEmployment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            PnlMenu.Controls.Add(BtnOpenApplicationForEmployment);
            Button BtnOpenAllApplication = new Button();
            BtnOpenAllApplication.Dock = DockStyle.Top;
            BtnOpenAllApplication.FlatStyle = FlatStyle.Flat;
            BtnOpenAllApplication.Text = "Все ваши заявки";
            BtnOpenAllApplication.TextAlign = ContentAlignment.MiddleLeft;
            BtnOpenAllApplication.Click += BtnOpenFormsEmployeeOfThePersonnelDepartment_Click; ;
            BtnOpenAllApplication.ForeColor = Color.Gainsboro;
            BtnOpenAllApplication.FlatAppearance.BorderSize = 0;
            BtnOpenAllApplication.Size = new Size(214, 70);
            BtnOpenAllApplication.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            PnlMenu.Controls.Add(BtnOpenAllApplication);
        }

        public void BtnOpenFormsEmployeeOfThePersonnelDepartment_Click(object sender, EventArgs e)
        {        
            Button BtnNow = (Button)sender;
            switch (BtnNow.Text)
            {
                case "Заявление для принятия на работу":
                    OpenChildForm(new Forms.EmployeeOfThePersonnelDepartment.FormApplicationForEmployment(), sender);
                    break;
                case "Заявление для изменения личных данных сотрудника":
                    OpenChildForm(new Forms.EmployeeOfThePersonnelDepartment.FormApplicationForChangingPersonalData(), sender);
                    break;
                case "Заявление для отпуска или больничного":
                    OpenChildForm(new Forms.EmployeeOfThePersonnelDepartment.FormApplicationsVacationOrSickLeave(), sender);
                    break;
                case "Заявление для увольнения работника":
                    OpenChildForm(new Forms.EmployeeOfThePersonnelDepartment.FormApplicationForDismissal(), sender);
                    break;
                case "Все ваши заявки":
                    OpenChildForm(new Forms.EmployeeOfThePersonnelDepartment.FormAllApplications(), sender);
                    break;
            }
        }

        public void AddButtonsFromSecretary()
        {
            Button BtnOpenApplicationsApplicationsForConsideration = new Button();
            BtnOpenApplicationsApplicationsForConsideration.Dock = DockStyle.Top;
            BtnOpenApplicationsApplicationsForConsideration.FlatStyle = FlatStyle.Flat;
            BtnOpenApplicationsApplicationsForConsideration.Text = "Заявления на рассмотрения";
            BtnOpenApplicationsApplicationsForConsideration.TextAlign = ContentAlignment.MiddleLeft;
            BtnOpenApplicationsApplicationsForConsideration.Click += BtnOpenApplicationFromSecretary_Click;
            BtnOpenApplicationsApplicationsForConsideration.ForeColor = Color.Gainsboro;
            BtnOpenApplicationsApplicationsForConsideration.FlatAppearance.BorderSize = 0;
            BtnOpenApplicationsApplicationsForConsideration.Size = new Size(214, 70);
            BtnOpenApplicationsApplicationsForConsideration.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            PnlMenu.Controls.Add(BtnOpenApplicationsApplicationsForConsideration);
            Button BtnCreateDocExel = new Button();
            BtnCreateDocExel.Dock = DockStyle.Top;
            BtnCreateDocExel.FlatStyle = FlatStyle.Flat;
            BtnCreateDocExel.Text = "Создать Exel файл со всеми данными сотрудников";
            BtnCreateDocExel.TextAlign = ContentAlignment.MiddleLeft;
            BtnCreateDocExel.Click += BtnOpenApplicationFromSecretary_Click;
            BtnCreateDocExel.ForeColor = Color.Gainsboro;
            BtnCreateDocExel.FlatAppearance.BorderSize = 0;
            BtnCreateDocExel.Size = new Size(214, 70);
            BtnCreateDocExel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            PnlMenu.Controls.Add(BtnCreateDocExel);
        }

        private void BtnOpenApplicationFromSecretary_Click(object sender, EventArgs e)
        {
            Button BtnNow = (Button)sender;
            switch (BtnNow.Text)
            {
                case "Заявления на рассмотрения":
                    OpenChildForm(new Forms.Secretary.FormApplicationsApplicationsForConsideration(), sender);
                    break;
                case "Создать Exel файл со всеми данными сотрудников":
                    Excel.Application exapp = new Excel.Application(); 
                    exapp.Visible = false;
                    exapp.Workbooks.Open(Application.StartupPath + "\\Шаблон сотрудников.XLSX", Type.Missing, true);
                    Excel.Worksheet list1 = exapp.Worksheets.get_Item(1);
                    int CountLine = 3;
                    int NumberWorker = 0;
                    string TxtQuarty1 = $@"
select *
from Worker";
                    SqlConnection Con = new SqlConnection(TxtCon);
                    Con.Open();
                    SqlCommand Quarty1 = new SqlCommand(TxtQuarty1, Con);
                    SqlDataReader Res = Quarty1.ExecuteReader();
                    while (Res.Read())
                    {
                        NumberWorker++;
                        list1.get_Range("A" + CountLine).Value = $@"{NumberWorker}.";
                        list1.get_Range("B" + CountLine).Value = $@"{Res["Fam"]}";
                        list1.get_Range("C" + CountLine).Value = $@"{Res["Name"]}";
                        list1.get_Range("D" + CountLine).Value = $@"{Res["Otch"]}";
                        list1.get_Range("E" + CountLine).Value = $@"{Res["Phone_number"]}";
                        list1.get_Range("F" + CountLine).Value = $@"{Res["Role"]}";
                        list1.get_Range("G" + CountLine).Value = $@"{Res["Salary"]}";
                        list1.get_Range("H" + CountLine).Value = $@"{Res["Tariff_category"]}";
                        list1.get_Range("I" + CountLine).Value = $@"{Res["Change"]}";
                        list1.get_Range("J" + CountLine).Value = $@"{Res["Hours_per_day"]}";
                        list1.get_Range("K" + CountLine).Value = $@"{Convert.ToDateTime(Res["Birthdate"]).ToShortDateString()}";
                        list1.get_Range("L" + CountLine).Value = $@"{Res["Passport_series_number"]}";
                        list1.get_Range("M" + CountLine).Value = $@"{Res["INN"]}";
                        list1.get_Range("N" + CountLine).Value = $@"{Res["Country_of_residence"]}";
                        list1.get_Range("O" + CountLine).Value = $@"{Res["Postcode"]}";
                        list1.get_Range("P" + CountLine).Value = $@"{Res["City"]}";
                        list1.get_Range("Q" + CountLine).Value = $@"{Res["Street"]}";
                        list1.get_Range("R" + CountLine).Value = $@"{Res["House_number"]}";
                        list1.get_Range("S" + CountLine).Value = $@"{Res["Apartment_number"]}";
                        string Range = String.Format("A{0}:S{1}", 3, CountLine);
                        list1.get_Range(Range).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                        CountLine++;
                    }
                    Con.Close();
                    exapp.Visible = true;
                    break;
            }
        }

        public void AddButtonsFromSystemAdministrator()
        {
            Button BtnOpenMakeChangesToTheDatabaseDasedOnTheAcceptedStatements = new Button();
            BtnOpenMakeChangesToTheDatabaseDasedOnTheAcceptedStatements.Dock = DockStyle.Top;
            BtnOpenMakeChangesToTheDatabaseDasedOnTheAcceptedStatements.FlatStyle = FlatStyle.Flat;
            BtnOpenMakeChangesToTheDatabaseDasedOnTheAcceptedStatements.Text = "Произвести изменения в бд исходя из принятых заявлений";
            BtnOpenMakeChangesToTheDatabaseDasedOnTheAcceptedStatements.TextAlign = ContentAlignment.MiddleLeft;
            BtnOpenMakeChangesToTheDatabaseDasedOnTheAcceptedStatements.Click += BtnOpenApplicationFromSystemAdministrator_Click;
            BtnOpenMakeChangesToTheDatabaseDasedOnTheAcceptedStatements.ForeColor = Color.Gainsboro;
            BtnOpenMakeChangesToTheDatabaseDasedOnTheAcceptedStatements.FlatAppearance.BorderSize = 0;
            BtnOpenMakeChangesToTheDatabaseDasedOnTheAcceptedStatements.Size = new Size(214, 70);
            BtnOpenMakeChangesToTheDatabaseDasedOnTheAcceptedStatements.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            PnlMenu.Controls.Add(BtnOpenMakeChangesToTheDatabaseDasedOnTheAcceptedStatements);
            Button BtnOpenCheckAndIssueLoginDetailsForSpecialWorkers = new Button();
            BtnOpenCheckAndIssueLoginDetailsForSpecialWorkers.Dock = DockStyle.Top;
            BtnOpenCheckAndIssueLoginDetailsForSpecialWorkers.FlatStyle = FlatStyle.Flat;
            BtnOpenCheckAndIssueLoginDetailsForSpecialWorkers.Text = "Проверить и выдать данные для входа специальных работников";
            BtnOpenCheckAndIssueLoginDetailsForSpecialWorkers.TextAlign = ContentAlignment.MiddleLeft;
            BtnOpenCheckAndIssueLoginDetailsForSpecialWorkers.Click += BtnOpenApplicationFromSystemAdministrator_Click;
            BtnOpenCheckAndIssueLoginDetailsForSpecialWorkers.ForeColor = Color.Gainsboro;
            BtnOpenCheckAndIssueLoginDetailsForSpecialWorkers.FlatAppearance.BorderSize = 0;
            BtnOpenCheckAndIssueLoginDetailsForSpecialWorkers.Size = new Size(214, 70);
            BtnOpenCheckAndIssueLoginDetailsForSpecialWorkers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            PnlMenu.Controls.Add(BtnOpenCheckAndIssueLoginDetailsForSpecialWorkers);
        }

        private void BtnOpenApplicationFromSystemAdministrator_Click(object sender, EventArgs e)
        {
            Button BtnNow = (Button)sender;
            switch (BtnNow.Text)
            {
                case "Произвести изменения в бд исходя из принятых заявлений":
                    OpenChildForm(new Forms.SystemAdministrator.FormMakeChangesToTheDatabaseDasedOnTheAcceptedStatements(), sender);
                    break;
                case "Проверить и выдать данные для входа специальных работников":
                    OpenChildForm(new Forms.SystemAdministrator.FormCheckAndIssueLoginDetailsForSpecialWorkers(), sender);
                    break;
            }
        }

        public FormMain()
        {
            InitializeComponent();
            BtnCloseChildForm.Visible = false;
            AddButtonOpenAuthorization();
        }

        private List<string> ColorList = new List<string>() { "#3F51B5", "#009688", "#FF5722", "#9C2780", "#2196F3", "#EA677C", "#E41A4A", "#0E3441" };
        public static Color PrimaryColor { get; set; }

        private Button currentButton;
        private Random rnd = new Random();
        private int tempIndex;
        private Form ActiveForm;

        public static string TxtCon = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DB_ADM_NVZ1.mdf;Integrated Security = True; Connect Timeout = 30";
        public static string Id_Special_Worker = "";
        public static string Role_Special_Worker = "";
        public static bool Authorized = false;

        private Color SelectTheneColor()
        {
            int index = rnd.Next(ColorList.Count);
            while (tempIndex == index)
            {
                index = rnd.Next(ColorList.Count);
            }
            tempIndex = index;
            string color = ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActiveButton(object BtnSender)
        {
            if (BtnSender != null)
            {
                if (currentButton != (Button)BtnSender)
                {
                    DisableButton();
                    Color color = SelectTheneColor();
                    currentButton = (Button)BtnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    currentButton.Size = new Size(214, 120);
                    PnlTitleBar.BackColor = color;
                    PrimaryColor = color;
                    BtnCloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previosBtn in PnlMenu.Controls)
            {
                if (previosBtn.GetType() == typeof(Button))
                {
                    previosBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previosBtn.ForeColor = Color.Gainsboro;
                    previosBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    previosBtn.Size = new Size(214, 70);
                }
            }
        }

        private void OpenChildForm(Form childForm, object BtnSender)
        {
            if (currentButton != (Button)BtnSender)
            {
                if (ActiveForm != null)
                {
                    ActiveForm.Close();
                }
                ActiveButton(BtnSender);
                ActiveForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                PnlDesktopForm.Controls.Add(childForm);
                PnlDesktopForm.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
                LblTitle.Text = childForm.Text;
            }
        }
        private void OpenProfileForm(Form ProfileForm)
        {
            ActiveForm = ProfileForm;
            ProfileForm.TopLevel = false;
            ProfileForm.FormBorderStyle = FormBorderStyle.None;
            ProfileForm.Dock = DockStyle.Fill;
            PnlDesktopForm.Controls.Add(ProfileForm);
            PnlDesktopForm.Tag = ProfileForm;
            ProfileForm.BringToFront();
            ProfileForm.Show();
            LblTitle.Text = ProfileForm.Text;
        }

        private void BtnCloseChildForm_Click(object sender, EventArgs e)
        {
            if(TmMain.Enabled == true)
            {
                TmMain.Enabled = false;
            }
            if (ActiveForm != null)
            {
                ActiveForm.Close();
                if (Id_Special_Worker != "" && Authorized == true)
                {
                    ResetProfile();
                }
                else
                {
                    ResetMain();
                }
            }
        }

        private void ResetMain()
        {
            DisableButton();
            LblTitle.Text = "ГЛАВНАЯ СТРАНИЦА";
            PnlTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            currentButton = null;
            BtnCloseChildForm.Visible = false;
        }

        public void ResetProfile()
        {
            DisableButton();
            LblTitle.Text = "ЛИЧНЫЙ КАБИНЕТ";
            PnlTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            currentButton = null;
            BtnCloseChildForm.Visible = false;
            OpenProfileForm(new Forms.FormProfile());
        }

        private void TmMain_Tick(object sender, EventArgs e)
        {
            if(Id_Special_Worker != "" && Authorized == true)
            {
                BtnCloseChildForm_Click(null, null);
                DisableButton();
                PnlMenu.Controls.Clear();
                ActiveForm.Close();
                AddButtonExitProfile();             
                OpenProfileForm(new Forms.FormProfile());              
                switch (Role_Special_Worker)
                {
                    case "Секретарь":
                        AddButtonsFromSecretary();
                        break;
                    case "Специалист по кадрам":
                        AddButtonsFromEmployeeOfThePersonnelDepartment();
                        break;
                    case "Системный администратор":
                        AddButtonsFromSystemAdministrator();
                        break;
                }
                TmMain.Enabled = false;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void PbxHelpPicture_DoubleClick(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "\\help.chm");
        }
    }
}

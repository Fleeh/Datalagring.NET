using ErrandHandler.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ErrandHandler.Views
{
    /// <summary>
    /// Interaction logic for NewErrandView.xaml
    /// </summary>
    public partial class NewErrandView : UserControl
    {
        private readonly IErrandService errandService = new ErrandService();        
        private readonly IRoleService roleService = new RoleService();
        private readonly IAdminService adminService = new AdminService();
        public NewErrandView()
        {
            InitializeComponent();
            ClearFields();
            cbRole.SelectedValuePath = "Key";
            cbRole.DisplayMemberPath = "Value";
            
            PopulateRoles();
            PopulateAdmins();
            cbAdmin.SelectedValuePath = "Key";
            cbAdmin.DisplayMemberPath = "Value";

            
            FormatCTime();
            


        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbEmail.Text) && !string.IsNullOrEmpty(tbErrandTitle.Text) && !string.IsNullOrEmpty(tbErrandDesc.Text) && !string.IsNullOrEmpty(MyTBLK.Text) && !string.IsNullOrEmpty(MyTBLM.Text))
            {
                if (errandService.Create(tbEmail.Text, tbErrandTitle.Text, tbErrandDesc.Text, MyTBLK.Text, MyTBLM.Text, (int)cbRole.SelectedValue, (int)cbAdmin.SelectedValue))
                    ClearFields();
             
                else
                    lbErrors.Content = "A User with the same email adress have already posted a errand.";
            }
        }
        private void ClearFields()
        {
            tbEmail.Text = "";
            tbErrandTitle.Text = "";
            tbErrandDesc.Text = "";
            MyTBLK.Text = "";
            MyTBLM.Text = ""; 
            
            lbErrors.Content = "";
        }
        private void PopulateRoles()
        {

            cbRole.Items.Clear();
            foreach (var role in roleService.GetAll())
                cbRole.Items.Add(new KeyValuePair<int, string>(role.Id, role.Name));
        }

        private void PopulateAdmins()
        {

            cbAdmin.Items.Clear();
            foreach (var admin in adminService.GetAll())
                cbAdmin.Items.Add(new KeyValuePair<int, string>(admin.Id, admin.Name));
        }


        private void FormatCTime()
        {
            FileInfo fi = new(@"C:\Users\Ralley\Desktop\Skola\ERRANDS\ErrandHandler\TEXT.txt");
            var created = fi.CreationTime;
            MyTBLK.Text = created.ToString("d");           
            MyTBLM.Text = fi.LastWriteTime.ToString("d");
        }
    }
}

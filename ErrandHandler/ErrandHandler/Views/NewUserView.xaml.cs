using ErrandHandler.Models;
using ErrandHandler.Services;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for NewUserView.xaml
    /// </summary>
    public partial class NewUserView : UserControl
    {
        private readonly IUserService userService = new UserService();
        public NewUserView()
        {
            InitializeComponent();
            
            ClearFields();           
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbFirstName.Text) && !string.IsNullOrEmpty(tbLastName.Text) && !string.IsNullOrEmpty(tbEmail.Text) && !string.IsNullOrEmpty(tbNumber.Text) && !string.IsNullOrEmpty(tbAdress.Text) && !string.IsNullOrEmpty(tbZipcode.Text) && !string.IsNullOrEmpty(tbCity.Text) && !string.IsNullOrEmpty(tbCountry.Text))
            {
                if (userService.Create(tbFirstName.Text, tbLastName.Text, tbEmail.Text, tbNumber.Text, tbAdress.Text, tbZipcode.Text, tbCity.Text, tbCountry.Text))
                    ClearFields();
                else
                    lbError.Content = "A user with the same email adress already exists.";
            }
        }

        private void ClearFields()
        {
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbEmail.Text = "";
            tbNumber.Text = "";
            tbAdress.Text = "";
            tbZipcode.Text = "";
            tbCity.Text = "";
            tbCountry.Text = "";
            lbError.Content = "";
        }
      
        }
    }

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
    /// Interaction logic for ErrandView.xaml
    /// </summary>
    public partial class ErrandView : UserControl

       
    {
        private readonly IErrandService errandService = new ErrandService();       
        public ErrandView()
        {
            InitializeComponent();
            
            


            lvErrand.Items.Clear();
            foreach (var errand in errandService.GetAll())
            {
                lvErrand.Items.Add(errand);
            }
   
        }

        

    }
}

﻿using System;
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
using ApplicationManager;

namespace Telemedycyna
{
    /// <summary>
    /// Interaction logic for NewUser.xaml
    /// </summary>
    public partial class NewUser : Page
    {
        
        DatabaseService databaseService;
        public NewUser()
        {
            InitializeComponent();
            databaseService = new DatabaseService();
        }

        private void NewAccountBTN_Click(object sender, RoutedEventArgs e)
        {
            if (pbNewPassOne.Password == pbNewPassTwo.Password && tbUsername.Text != "")
            {
                databaseService.RegisterNewUser(tbUsername.Text, pbNewPassTwo.Password);
                this.NavigationService.GoBack();
            }
            else
            {
                MessageBox.Show("Błąd! Sprawdź poprawność wpisanych danych.");
                tbUsername.Clear();
                pbNewPassOne.Clear();
                pbNewPassTwo.Clear();
            }
        }
    }
}

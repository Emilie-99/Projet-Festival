using FestivalAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using wpfFestival.ControllersAPI;

namespace wpfFestival
{
    /// <summary>
    /// Logique d'interaction pour Connexion.xaml
    /// </summary>
    public partial class Connexion : Page
    {

        private readonly ICollection<Gestionnaire> ListeGestionnaires;
        private bool authoriser = false;

        public Connexion()
        {
            InitializeComponent();
            //Récupération de tous les gestionnaires 
            ListeGestionnaires = API.Instance.GetGestionnaire().Result;
        }


        private void Se_connecter(object sender, RoutedEventArgs e)
        {
            

            if (LoginTextBox.Text != "" && MdpTextBox.Text != "")
            {
                foreach(Gestionnaire gestionnaire in ListeGestionnaires)
                { 
                    if (gestionnaire.Email == LoginTextBox.Text && gestionnaire.Mot_de_passe == MdpTextBox.Text)
                    {
                        authoriser = true;
                    }
                    
                }

                if(authoriser == true)
                {
                    Menu menu = new Menu();
                    this.NavigationService.Navigate(menu);
                }
               
                 else
                {

                    MessageBox.Show("Login et/ou Mot de passe incorrect(s) ", "Erreur de connexion !", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }




        }
        private void MdpTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}

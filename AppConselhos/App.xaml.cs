using AppConselhos.Model;

using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppConselhos.Helper;
using System.IO;
using System.Collections.ObjectModel;

namespace AppConselhos
{
    public partial class App : Application
    { 
        static SQLiteDatabaseHelper database;
        public static ObservableCollection<Conselho> ListaConselhos = new ObservableCollection<Conselho>();

        public static SQLiteDatabaseHelper Database
        {
            get
            {
                if (database == null)
                {
                    string path = Path.Combine(
                        Environment.GetFolderPath(
                            Environment.SpecialFolder.LocalApplicationData), "arquivo.db3");

                    database = new SQLiteDatabaseHelper(path);
                }

                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

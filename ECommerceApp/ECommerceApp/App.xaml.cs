﻿
using ECommerceApp.Pages;
using Xamarin.Forms;

namespace ECommerceApp
{
    public partial class App : Application
    {
        #region Properties
        public static NavigationPage Navigator { get; internal set; }
        public static MasterPage Master { get; internal set; }

        #endregion

        #region Constructors
        public App()
        {
            InitializeComponent();
            // The root page of your application
            MainPage = new  LoginPage();
        }

        #endregion
        
        #region Methods
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        } 
        #endregion
    }
}

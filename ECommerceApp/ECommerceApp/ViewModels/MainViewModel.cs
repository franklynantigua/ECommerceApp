﻿using System.Collections.ObjectModel;

namespace ECommerceApp.ViewModels
{
    public  class MainViewModel
    {
        #region Properties

        public ObservableCollection<MenuItemViewModel> Menu { get; set; }
        public LoginViewModel NewLogin { get; set; }

        #endregion

        #region Constructors
        public MainViewModel()
        {
          
            Menu = new ObservableCollection<MenuItemViewModel>();
            NewLogin = new LoginViewModel();
            LoadMenu();
        }


        #endregion


        #region Methods
        private void LoadMenu()
        {
           Menu.Add( new MenuItemViewModel
               {
                   Icon = "ic_action_product.png",
                   PageName = "ProductsPage",
                   Title = "Productos"
           });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_action_customer.png",
                PageName = "CustomersPage",
                Title = "Clientes"
            });
            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_action_order.png",
                PageName = "OrdersPage",
                Title = "Pedidos"
            });
            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_action_delivery.png",
                PageName = "DeliveryPage",
                Title = "Entregas"
            });
            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_action_sync.png",
                PageName = "SyncPage",
                Title = "Sincronizar"
            });
            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_action_setup.png",
                PageName = "SetupPage",
                Title = "Configuracion"
            });
            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_action_logout.png",
                PageName ="LogoutPage",
                Title = "Salir"
            });

        }


        #endregion



    }
}

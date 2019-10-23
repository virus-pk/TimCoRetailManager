using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDesktopUI.ViewModels
{
    public class SalesViewModel : Screen
    {
        private BindingList<string> _products;
        private BindingList<string> _cart;
        private int _itemQuantity;
        
        public string SubTotal
        {
            get
            {
                // TODO Replace with calculation
                return "$0.00";
            }
        }

        public string Tax
        {
            get
            {
                // TODO Replace with calculation
                return "$0.00";
            }
        }

        public string Total
        {
            get
            {
                // TODO Replace with calculation
                return "$0.00";
            }
        }


        public BindingList<string> Cart
        {
            get { return _cart; }
            set
            {
                _cart = value;
                NotifyOfPropertyChange(() => Cart);
            }
        }

        public int ItemQuantity
        {
            get { return _itemQuantity; }
            set
            {
                _itemQuantity = value;
                NotifyOfPropertyChange(() => ItemQuantity);
            }
        }

        public BindingList<string> Products
        {
            get { return _products; }
            set
            {
                _products = value;
                NotifyOfPropertyChange(() => Products);
            }
        }

        public bool CanAddToCart
        {
            get
            {
                bool output = false;

                // TODO Make sure something is selected
                // TODO Make sure there is an item quantity

                return output;
            }
        }

        public void AddToCart()
        {

        }

        public bool CanRemoveFromCart
        {
            get
            {
                bool output = false;

                // TODO Make sure something is selected

                return output;
            }
        }

        public void RemoveFromCart()
        {

        }
        
        public bool CanCheckOut
        {
            get
            {
                bool output = false;

                // TODO Make sure there is something in the cart

                return output;
            }
        }

        public void CheckOut()
        {

        }
    }
}

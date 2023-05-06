using CleverCore.Application.ViewModels.Common;
using CleverCore.Application.ViewModels.Product;
using CleverCore.Data.Enums;
using CleverCore.Utilities.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CleverCore.WebApp.Models
{
    public class CheckoutViewModel : BillViewModel
    {
        public List<ShoppingCartViewModel> Carts { get; set; }

        public List<EnumModel> PaymentMethods
        {
            get
            {
                return ((PaymentMethod[])Enum.GetValues(typeof(PaymentMethod)))
                    .Select(c => new EnumModel
                    {
                        Value = (int)c,
                        Name = c.GetDescription()
                    }).ToList();
            }
        }
    }
}
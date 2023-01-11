using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParfumShopApp.Models;

namespace ParfumShopApp.Views.Templates
{
    public class ProductDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ResultsTemplate { get; set; }
        public DataTemplate ProductTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var product = (Product)item;

            if (product.IsEmpty())
                return ResultsTemplate;

            return ProductTemplate;
        }
    }
}

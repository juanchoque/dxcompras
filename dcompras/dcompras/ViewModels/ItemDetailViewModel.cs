using System;

using dcompras.Models;

namespace dcompras.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Purchase Item { get; set; }
        public ItemDetailViewModel(Purchase item = null)
        {
            Title = item?.Description;
            Item = item;
        }
    }
}

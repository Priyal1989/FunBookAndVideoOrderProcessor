using FunBooksAndVideos_ViewModel.Interface;
using System.Collections.Generic;

namespace FunBooksAndVideos_ViewModel
{
    public class PurchaseOrderViewModel
    {
        public int POID { get; set; }
        public CustomerViewModel objCustomer { get; set; }
        public List<IItems> lstIems { get; set; }
    }
}

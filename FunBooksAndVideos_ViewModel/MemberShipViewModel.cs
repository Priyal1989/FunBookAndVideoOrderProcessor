using FunBooksAndVideos_ViewModel.Interface;

namespace FunBooksAndVideos_ViewModel
{
    public class MemberShipViewModel : INonPhysical
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public decimal cost { get; set; }
    }
}

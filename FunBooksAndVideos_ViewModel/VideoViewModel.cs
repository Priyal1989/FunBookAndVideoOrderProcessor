using FunBooksAndVideos_ViewModel.Interface;

namespace FunBooksAndVideos_ViewModel
{
    public class VideoViewModel : INonPhysical
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public decimal cost { get; set; }
    }
}

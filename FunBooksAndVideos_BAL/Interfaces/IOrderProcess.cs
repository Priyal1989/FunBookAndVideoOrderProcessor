using FunBooksAndVideos_ViewModel;


namespace FunBooksAndVideos_BAL.Interfaces
{
    public interface IOrderProcess
    {
        void ProcessOnOrder(PurchaseOrderViewModel objPurchaseOrderViewModel);
    }
}

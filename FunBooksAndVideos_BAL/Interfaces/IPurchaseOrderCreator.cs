using FunBooksAndVideos_ViewModel;

namespace FunBooksAndVideos_BAL.Interfaces
{
   public interface IPurchaseOrderCreator
    {
        bool InsertPurchaseOrder(PurchaseOrderViewModel objPurchaseOrderViewModel);
    }
}

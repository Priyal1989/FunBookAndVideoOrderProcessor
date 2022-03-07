using FunBooksAndVideos_ViewModel;

namespace FunBooksAndVideos_BAL.Interfaces
{
    public interface IShipmentSlipCreator
    {
        bool generateShipmentSlip(PurchaseOrderViewModel objPurchaseOrderViewModel);
    }
}

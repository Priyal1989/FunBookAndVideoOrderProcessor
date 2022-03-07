using FunBooksAndVideos_BAL.Interfaces;
using FunBooksAndVideos_ViewModel;
using FunBooksAndVideos_ViewModel.Interface;
using System.Linq;

namespace FunBooksAndVideos_BAL.Services
{
    public class ShipmentSlipCreator : IShipmentSlipCreator
    {
        public bool generateShipmentSlip(PurchaseOrderViewModel objPurchaseOrderViewModel)
        {
           //write logic here
            return true;
        }
    }
}

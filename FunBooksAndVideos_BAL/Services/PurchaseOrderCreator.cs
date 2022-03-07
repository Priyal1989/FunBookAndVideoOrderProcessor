using FunBooksAndVideos_ViewModel;
using FunBooksAndVideos_BAL.Interfaces;

namespace FunBooksAndVideos_BAL.Services
{
    public class PurchaseOrderCreator : IPurchaseOrderCreator
    {
        private readonly IPurchaseOrderCreator _iPurchaseOrderCreator;
        public PurchaseOrderCreator(IPurchaseOrderCreator iPurchaseOrderCreator)
        {
            _iPurchaseOrderCreator = iPurchaseOrderCreator;
        }

        public bool InsertPurchaseOrder(PurchaseOrderViewModel objPurchaseOrderViewModel)
        {
            bool retValue = true;
            //Write logic here
            retValue = _iPurchaseOrderCreator.InsertPurchaseOrder(objPurchaseOrderViewModel);
            return retValue;
        }
    }
}

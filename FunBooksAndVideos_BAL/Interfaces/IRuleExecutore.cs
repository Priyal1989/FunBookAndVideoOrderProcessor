using FunBooksAndVideos_ViewModel;
using System.Collections.Generic;

namespace FunBooksAndVideos_BAL.Interfaces
{
    public interface IRuleExecutore
    {
        void executeRule(PurchaseOrderViewModel objPurchaseOrderViewModel, List<RuleSeqViewModel> lstruleSeqViewModels);
    }
}

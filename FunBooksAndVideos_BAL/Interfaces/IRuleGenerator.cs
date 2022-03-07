using FunBooksAndVideos_ViewModel;
using System.Collections.Generic;


namespace FunBooksAndVideos_BAL.Interfaces
{
   public interface IRuleGenerator
    {
        List<RuleSeqViewModel> GetAllAppliedRuleInSequence(PurchaseOrderViewModel PurchaseOrderViewModel);
    }
}

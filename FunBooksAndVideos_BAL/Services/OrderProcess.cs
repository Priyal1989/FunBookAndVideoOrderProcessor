using FunBooksAndVideos_BAL.Interfaces;
using FunBooksAndVideos_ViewModel;
using FunBooksAndVideos_ViewModel.Interface;
using System.Collections.Generic;
using System.Linq;

namespace FunBooksAndVideos_BAL.Services
{
    public class OrderProcess : IOrderProcess
    {
    
        private readonly IRuleExecutore _iRuleExecutore;
        private readonly IRuleGenerator _iRuleGenerator;
        public OrderProcess(IRuleExecutore iRuleExecutore,
                            IRuleGenerator iRuleGenerator)
        {
            _iRuleExecutore = iRuleExecutore;
            _iRuleGenerator = iRuleGenerator;
        }

        public void ProcessOnOrder(PurchaseOrderViewModel objPurchaseOrderViewModel)
        {
            List<RuleSeqViewModel> lstruleSeqViewModels = new List<RuleSeqViewModel>();
            //First decide what rule is applicable and what is sequence of execution
            lstruleSeqViewModels = _iRuleGenerator.GetAllAppliedRuleInSequence(objPurchaseOrderViewModel);
            //Based on rule sequence and Order model execute the rule
            _iRuleExecutore.executeRule(objPurchaseOrderViewModel, lstruleSeqViewModels);
        }
    }
}

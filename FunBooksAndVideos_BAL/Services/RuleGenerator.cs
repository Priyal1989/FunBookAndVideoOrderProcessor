using FunBooksAndVideos_BAL.Interfaces;
using FunBooksAndVideos_ViewModel;
using System.Collections.Generic;
using FunBooksAndVideos_BAL.Enumration;
using System.Linq;
using FunBooksAndVideos_ViewModel.Interface;

namespace FunBooksAndVideos_BAL.Services
{
    public class RuleGenerator : IRuleGenerator
    {
       
        public List<RuleSeqViewModel> GetAllAppliedRuleInSequence(PurchaseOrderViewModel PurchaseOrderViewModel)
        {
            List<RuleSeqViewModel> lstruleSeqViewModels = new List<RuleSeqViewModel>();
            Dictionary<string, int> dcRules = new  Dictionary<string, int>();
            //First add all global/common rule
            if (PurchaseOrderViewModel.lstIems.Count() > 0)
            {
                //Check for Premium membership
                if (PurchaseOrderViewModel.lstIems.Where(a => a is IMembershipActivate).Count() > 0)
                {
                    dcRules.Add(businessRules.MemberShip.ToString(), (int)businessRules.MemberShip);
                }

                //Check for Shippingslip
                if (PurchaseOrderViewModel.lstIems.Where(a => a is INonPhysical).Count() > 0)
                {
                    dcRules.Add(businessRules.ShippingSlip.ToString(), (int)businessRules.ShippingSlip);
                }
            }
            lstruleSeqViewModels = dcRules.Select(p => new RuleSeqViewModel { RuleName = p.Key, Rulesequence = p.Value }).ToList();
            return lstruleSeqViewModels;
        }
    }
}

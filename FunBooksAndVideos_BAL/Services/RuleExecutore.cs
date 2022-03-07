using FunBooksAndVideos_BAL.Enumration;
using FunBooksAndVideos_BAL.Interfaces;
using FunBooksAndVideos_ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace FunBooksAndVideos_BAL.Services
{
    public class RuleExecutore : IRuleExecutore
    {

        private readonly IPurchaseOrderCreator _iPurchaseOrderCreator;
        private readonly IMembershipActivate _iMembershipActivate;
        private readonly IShipmentSlipCreator _iShipmentSlipCreator;
        public RuleExecutore(IPurchaseOrderCreator iPurchaseOrderCreator,
                                   IMembershipActivate iMembershipActivate,
                                   IShipmentSlipCreator iShipmentSlipCreator)
        {
            _iPurchaseOrderCreator = iPurchaseOrderCreator;
            _iMembershipActivate = iMembershipActivate;
            _iShipmentSlipCreator = iShipmentSlipCreator;
        }

        public void executeRule(PurchaseOrderViewModel objPurchaseOrderViewModel, List<RuleSeqViewModel> lstruleSeqViewModels)
        {
            //Execute all common rule first
            _iPurchaseOrderCreator.InsertPurchaseOrder(objPurchaseOrderViewModel);
            //Based on rule generator execure rule according to rule sequence
            List<RuleSeqViewModel> flstruleSeqViewModels = lstruleSeqViewModels.OrderBy(p => p.Rulesequence).ToList();
            foreach (var item in flstruleSeqViewModels)
            {
                bool retValue = false;
                var obj = (businessRules)item.Rulesequence;
                switch (obj)
                {
                    case businessRules.MemberShip:
                        {
                            retValue = _iMembershipActivate.activateMembership(objPurchaseOrderViewModel);
                            break;
                        }
                    case businessRules.ShippingSlip:
                        {
                            retValue = _iShipmentSlipCreator.generateShipmentSlip(objPurchaseOrderViewModel);
                            break;
                        }
                    default:
                        break;

                }
            }
        }
    }
}


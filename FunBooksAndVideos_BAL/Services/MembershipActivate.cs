using FunBooksAndVideos_BAL.Interfaces;
using FunBooksAndVideos_ViewModel;
using FunBooksAndVideos_ViewModel.Interface;
using System.Linq;

namespace FunBooksAndVideos_BAL.Services
{
    public class MembershipActivate : IMembershipActivate
    {
        private readonly IMembershipActivate _iMembershipActivate;

        public MembershipActivate(IMembershipActivate iMembershipActivate)
        {
            _iMembershipActivate = iMembershipActivate;
        }

        public bool activateMembership(PurchaseOrderViewModel objPurchaseOrderViewModel)
        {
            bool retVal = true;
            int cntMemebershipItem = objPurchaseOrderViewModel.lstIems.Where(p => p is MemberShipViewModel).Count();
            if (cntMemebershipItem > 0)
            {
                retVal = _iMembershipActivate.activateMembership(objPurchaseOrderViewModel);
            }
            return retVal;
        }
    }
}


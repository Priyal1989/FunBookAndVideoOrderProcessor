using FunBooksAndVideos_BAL.Interfaces;
using FunBooksAndVideos_ViewModel;
using FunBooksAndVideos_ViewModel.Interface;
using System.Linq;

namespace FunBooksAndVideos_BAL.Services
{
    public class VideoServiceActivator : IMembershipActivate
    {
        private readonly IMembershipActivate _iMembershipActivate;

        public VideoServiceActivator(IMembershipActivate iMembershipActivate)
        {
            _iMembershipActivate = iMembershipActivate;
        }

        public bool activateMembership(PurchaseOrderViewModel objPurchaseOrderViewModel)
        {
            bool retVal = true;
            int cntMemebershipItem = objPurchaseOrderViewModel.lstIems.Where(p => p is VideoViewModel).Count();
            if (cntMemebershipItem > 0)
            {
                //write logic here
                retVal = _iMembershipActivate.activateMembership(objPurchaseOrderViewModel);
            }
            return retVal;
        }
    }
}

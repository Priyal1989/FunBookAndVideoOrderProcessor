using FunBooksAndVideos_ViewModel;

namespace FunBooksAndVideos_BAL.Interfaces
{
    public interface IMembershipActivate
    {
        bool activateMembership(PurchaseOrderViewModel poModel);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunBooksAndVideos_ViewModel.Interface
{
    public interface IItems
    {
        int productID { get; set; }
        string productName { get; set; }
        decimal cost { get; set; }
    }
}

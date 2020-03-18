using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
namespace Guestbook.Models
{
    public class UserListViewModel
    {
     
        public SelectList Mail { get; set; }
        public string Name { get; set; }
    }
}
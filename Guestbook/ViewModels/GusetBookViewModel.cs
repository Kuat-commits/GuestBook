using System;

namespace Guestbook.ViewModels
{
    public class GusetBookViewModel
    {
        public  int Id { get; set; }
        
        public  string Mail { get; set; }
        public  string Name { get; set; }
        public  string Message { get; set; }
        public DateTime? DateAdded { get; set; }
    }
}
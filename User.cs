using Microsoft.AspNetCore.Mvc;
using System.Runtime.ConstrainedExecution;

namespace CsKitchen.Models
{
    public class User : Controller
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public string userPassword { get; set; }
        public string userEmail { get; set; }
        private int accessLevel = 1;
    }
}

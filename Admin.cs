using Microsoft.AspNetCore.Mvc;
using System.Runtime.ConstrainedExecution;

namespace CsKitchen.Models
{
    public class Admin : User
    {
        private int accessLevel = 2;
    }
}

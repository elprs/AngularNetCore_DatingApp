using Microsoft.EntityFrameworkCore;

namespace AngularNetCore_DatingApp.Data
{
    public class DataContext : DbContext
    {
        public int MyProperty { get; set; }
    }
}
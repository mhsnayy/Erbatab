using Identity.Domain.Common;

namespace Identity.Domain.Entities
{
    public class User : BaseEntity
    {
        public required string FullName { get; set; }
        public required string Email { get; set; }
        public required string HashedPassword { get; set; }
        public required string PhoneNumber { get; set; }
        
    }
}

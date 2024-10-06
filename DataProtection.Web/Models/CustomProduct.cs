using System.ComponentModel.DataAnnotations.Schema;

namespace DataProtection.Web.Models
{
    public partial class Products
    {
        [NotMapped]
        public string EncryptedId { get; set; }
    }
}

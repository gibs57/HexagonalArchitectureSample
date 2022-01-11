using System.ComponentModel.DataAnnotations;

namespace HexaArchitecture.DomainApi
{
    public class BaseEntity<TKey>
    {
        [Key]
        public TKey Id { get; set; }
    }
}

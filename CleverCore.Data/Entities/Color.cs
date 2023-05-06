using CleverCore.Infrastructure.SharedKernel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleverCore.Data.Entities
{
    [Table("Colors")]
    public class Color : DomainEntity<int>
    {
        [MaxLength(250)]
        public string Name
        {
            get; set;
        }

        [MaxLength(250)]
        public string Code { get; set; }
    }
}
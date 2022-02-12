using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApi.Model;

namespace TodoApi.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string FullName { get; set; }
        [MaxLength(50)]
        public string AddressNo { get; set; }
        [MaxLength(200)]
        public string Street { get; set; }
        [MaxLength(50)]
        [Required]
        public string City { get; set; }
        [Required]
        [MaxLength(50)]
        public string JobRole { get; set; }
        public ICollection<Todo> Todos { get; set; } = new List<Todo>();

    }
}

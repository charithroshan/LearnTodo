using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApi.Services.ViewModels
{
    public class AuthorViewModel
    {
        public int Id { get; set; }

        public string FullName { get; set; }
        public string Address { get; set; }
        public string JobRole { get; set; }
    }
}

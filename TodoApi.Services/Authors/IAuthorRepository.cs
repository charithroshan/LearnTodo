using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi.Services.Authors
{
    public interface IAuthorRepository
    {
        public List<Author> GetAllAuthors();
        public Author GetAuthor(int Id);
    }
}

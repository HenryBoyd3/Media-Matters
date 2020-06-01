using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Media_Matters.Models
{
    public interface IBookRepo
    {
        IEnumerable<Book> GetBooks();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Utilities.Search.Entities
{
    public class PagedList<T>
    {
        public PagedList(int count, int pageNumber, int pageSize)
        {
            CurrentPage = pageNumber;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            PageSize = pageSize;
            TotalCount = count;
        }
        public IEnumerable<T> Data { get; set; }

        public int TotalPages { get; }

        public int CurrentPage { get; }
        public int PageSize { get; set; }
        public int TotalCount { get; }
    }
}

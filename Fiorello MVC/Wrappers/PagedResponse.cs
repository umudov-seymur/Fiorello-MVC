using System;
using System.Collections.Generic;
using System.Linq;

namespace Fiorello_MVC.Wrappers
{
    public class PagedResponse<T>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public int TotalRecords { get; set; }
        

        public int PreviousPage
        {
            get
            {
                return PageNumber >= 1 ? PageNumber - 1 : 1;
            }
        }
        
        public int NextPage
        {
            get
            {
                return PageNumber < TotalPages ? PageNumber + 1 : 1;
            }
        }
        
        public int TotalPages
        {
            get
            {
                var totalPages =  (double)((decimal)TotalRecords / Convert.ToDecimal(PageSize));
                return (int)Math.Ceiling(totalPages);
            }
        }

        public PagedResponse(List<T> data, int pageNumber, int pageSize, int totalRecords)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
            Data = data;
            TotalRecords = totalRecords;
        }

        public List<T> Data { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStateWebDotNet7Api.CrossApp.Common
{
    public class ResponsePag<T> : ResponseGeneric<T>
    {
        public int PageNum { get; set; }
        public int TotalPages { get; set; }
        public int TotalRecords { get; set; }
        public bool HasPreviousPage => PageNum > 1;
        public bool HasNextPage => PageNum < TotalRecords;
    }
}

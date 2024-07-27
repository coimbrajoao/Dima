using System.Text.Json.Serialization;

namespace Dima.Core.Responses
{
    public class PagedResponse<TData> : Response<TData>
    {

        [JsonConstructor]
        public PagedResponse(TData? data, int totalCount, int currentPage, int pageSize) : base(data)
      {
            Data = data;
            totalCount = TotalCount;
            currentPage = CurrentPage;
            pageSize = PageSize;
            
        }

        public PagedResponse(TData? data, int code = 200, string? message= null) : base(data, code, message)
        {
            
        }
        public int CurrentPage { get; set; }
        public int TotalPages 
                => (int)Math.Ceiling(TotalCount / (double)PageSize);
        public int PageSize { get; set; } = 10;
        public int TotalCount { get; set; }
    }
}
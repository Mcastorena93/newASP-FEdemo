namespace CityInfo.API.Services
{
    public class PaginationMetadata
    {
        public int TotalItemCount { get; set; }

        public int TotalPageCount { get; set; }

        public int PageSize { get; set; }

        public int CurrentPage { get ; set; }

        public PaginationMetadata(int totalIntemCount, int pageSize, int currentPage) 
        { 
            TotalItemCount = totalIntemCount;
            PageSize = pageSize;
            CurrentPage = currentPage;  
            TotalPageCount = (int)Math.Ceiling(TotalItemCount / (double)pageSize);
        }
    }
}

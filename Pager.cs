using System.Collections.Generic;
using System;
using System.Linq;

namespace GenericsExample
{
    // Type parameter <T>- variable
    public class Pager<T>
    {
        // Allows Program to only access books or movies page by page, not all of them at once
        private List<T> _allRecords;

        public int CurrentPage { get; set; }
        public int RecordsPerPage { get; set; } = 5;

        public Pager(List<T> allRecords)
        {
            _allRecords = allRecords;
        }

        public List<T> GetCurrentPage()
        {
            var skipAmount = CurrentPage * RecordsPerPage;
            return _allRecords.Skip(skipAmount)
            .Take(RecordsPerPage)
            .ToList();
        }
        public List<T> GetPreviousPage()
        {
            CurrentPage--;
            return GetCurrentPage();
        }
        public List<T> GetNextPage()
        {
            CurrentPage++;
            return GetCurrentPage();
        }

    }
}
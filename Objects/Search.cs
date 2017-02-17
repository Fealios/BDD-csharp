using System;

namespace BDD.Objects
{
    public class Search
    {
        private string _toBeSearched;
        private string _searchTerm;

        public Search(string searchItem, string searchTerm)
        {
            _toBeSearched = searchItem;
            _searchTerm = searchTerm;
        }
        
    }
}

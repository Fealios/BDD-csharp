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

        public string GetSearchedString()
        {
            return _toBeSearched;
        }

        public bool DoesItMatch(string toBeSearched, string searchTerm)
        {
            if(toBeSearched == searchTerm)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

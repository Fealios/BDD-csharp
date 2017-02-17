using System;

namespace BDD.Objects
{
    public class Search
    {
        private string _toBeSearched;
        private string _searchTerm;
        private int _matchCounter = 0;

        public Search(string searchItem, string searchTerm)
        {
            _toBeSearched = searchItem;
            _searchTerm = searchTerm;
            SentenceChecker();
        }

        public string GetSearchedString()
        {
            return _toBeSearched;
        }

        public string GetSearchTerm()
        {
            return _searchTerm;
        }

        public bool DoesItMatch(string toBeSearched, string searchTerm)
        {
            if(toBeSearched == searchTerm)
            {
                _matchCounter++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SentenceChecker()
        {
            string[] wordArray = _toBeSearched.Split(null);
            // Console.WriteLine(wordArray.Length);
            if(wordArray.Length >= 2)
            {
                for(int i = 0; i<wordArray.Length; i++)
                {
                    DoesItMatch(wordArray[i], _searchTerm);
                }
            }
            else
            {
                DoesItMatch(_toBeSearched, _searchTerm);
            }

            if(_matchCounter != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetCounterCount()
        {
            return _matchCounter;
        }
    }
}

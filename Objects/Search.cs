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

            if(wordArray.Length >= 2)
            {
                for(int i = 0; i<wordArray.Length; i++)
                {
                    if(DoesItMatch(wordArray[i], _searchTerm))
                    {
                        _matchCounter++;
                    }
                    else
                    {
                        continue;
                    }
                }
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
    }
}


// public bool SentenceChecker()
// {
//
//     string[] wordArray = _toBeSearched.Split(null);
//     if (wordArray.Length < 2)
//     {
//         return DoesItMatch(_toBeSearched, _searchTerm);
//     }
//     else
//     {
//         for(int i=0;i<wordArray.Length;i++)
//         {
//             if(DoesItMatch(wordArray[i], _searchTerm))
//             {
//                 return DoesItMatch(wordArray[i], _searchTerm);
//             }
//             else
//             {
//                 continue;
//             }
//         }
//         if(_matchCounter == 0)
//         {
//             return false;
//         }
//     }
// }

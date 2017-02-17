using Xunit;
using System.Collections.Generic;

namespace BDD.Objects
{
    public class SearchTest
    {
        [Fact]
        public void GetSearchedString_ReturnsSameString_true()
        {
            Search testSearch = new Search("word", "more");
            Assert.Equal("word", testSearch.GetSearchedString());
        }

        [Fact]
        public void DoesItMatch_TwoMatchingStrings_true()
        {
            Search testSearch = new Search("word", "word");
            Assert.Equal(true, testSearch.DoesItMatch("word", "word"));
        }

        [Fact]
        public void DoesItMatch_TwoNonMatchingStrings_false()
        {
            Search testSearch = new Search("word", "other");
            Assert.Equal(false, testSearch.DoesItMatch("word", "other"));
        }
    }
}

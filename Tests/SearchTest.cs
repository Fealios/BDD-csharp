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
        public void GetSearchedTerm_ReturnsSameString_true()
        {
            Search testSearch = new Search("word", "more");
            Assert.Equal("more", testSearch.GetSearchTerm());
        }

        [Fact]
        public void DoesItMatch_TwoMatchingStrings_true()
        {
            Search testSearch = new Search("melvin", "melvin");
            Assert.Equal(true, testSearch.DoesItMatch("melvin", "melvin"));
        }

        [Fact]
        public void DoesItMatch_TwoNonMatchingStrings_false()
        {
            Search testSearch = new Search("word", "other");
            Assert.Equal(false, testSearch.DoesItMatch("word", "other"));
        }

        [Fact]
        public void SentenceChecker_WordInSentence_true()
        {
            Search testSearch = new Search("hello my name is melvin", "melvin");
            Assert.Equal(true, testSearch.SentenceChecker());
        }

        [Fact]
        public void SentenceChecker_MultipleWordMatch_3()
        {
            Search testSearch = new Search("word this this this word", "this");
            Assert.Equal(3, testSearch.GetCounterCount());
        }
        
        [Fact]
        public void SentenceChecker_MultipleWordMatch_False()
        {
            Search newSearch = new Search("hello my friend", "enemy");
            // testSearch.SentenceChecker();
            Assert.Equal(false, testSearch.SentenceChecker());
        }

    }
}

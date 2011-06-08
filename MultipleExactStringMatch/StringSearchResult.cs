﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExactStringSearch
{
    /// <summary>
    /// Structure containing results of search 
    /// (keyword and position in original text)
    /// </summary>
    public struct StringSearchResult
    {
        #region Members

        private int _index;
        private string _keyword;

        /// <summary>
        /// Initialize string search result
        /// </summary>
        /// <param name="index">Index in text</param>
        /// <param name="keyword">Found keyword</param>
        public StringSearchResult(int index, string keyword)
        {
            _index = index; _keyword = keyword;
        }


        /// <summary>
        /// Returns index of found keyword in original text
        /// </summary>
        public int Index
        {
            get { return _index; }
        }


        /// <summary>
        /// Returns keyword found by this result
        /// </summary>
        public string Keyword
        {
            get { return _keyword; }
        }


        /// <summary>
        /// Returns empty search result
        /// </summary>
        public static StringSearchResult Empty
        {
            get { return new StringSearchResult(-1, ""); }
        }

        #endregion
    }
}

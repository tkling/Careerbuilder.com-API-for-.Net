﻿using System;
using System.Collections.Generic;
namespace CBApi.Models.Responses {
    [Serializable]
    public class ResponseJobSearch {
        public DateTime TimeResponseSent { get; set; }
        public float TimeElapsed { get; set; }
        public int TotalPages { get; set; }
        public int TotalCount { get; set; }
        public int FirstItemIndex { get; set; }
        public int LastItemIndex { get; set; }
        public List<JobSearchResult> Results { get; set; }
    }
}
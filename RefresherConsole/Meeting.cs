﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RefresherConsole
{
    public class Meeting
    {
        public int StartTime { get; set; }

        public int EndTime { get; set; }

        public Meeting(int startTime, int endTime)
        {
            // Number of 30 min blocks past 9:00 am
            StartTime = startTime;
            EndTime = endTime;
        }

        public override string ToString()
        {
            return $"({StartTime}, {EndTime})";
        }

        public IEnumerable<Meeting>  MergeRanges(IEnumerable<Meeting> meetings)
        {




            return new List<Meeting>();
        
        }
    }
}

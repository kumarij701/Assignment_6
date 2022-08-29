using System;
using System.Collections.Generic;

namespace Assignment_6_WebApi.Models
{
    public partial class Task
    {
        public int TaskId { get; set; }
        public TimeSpan Time { get; set; }
        public string? TaskOwner { get; set; }
        public string? TaskStatus { get; set; }
        public string? StoryDescription { get; set; }
    }
}

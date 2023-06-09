﻿using System.ComponentModel.DataAnnotations;

namespace TrackingApi.Models
{
    public class Issue
    {
        public int Id { get; set; }
        [Required]
        public  string Title  { get; set; }
        [Required]
        public string Description { get; set; }
        public priority Priority { get; set; }
        public IssueType issueType { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Completed { get; set; }
    }

    public enum priority 
    {
        Low , Medium, High 
    
    }
    public enum IssueType 
    {
        Feature , Bug , Documentation 
    
    }
}

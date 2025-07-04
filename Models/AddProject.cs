﻿using System.ComponentModel.DataAnnotations;
using Freelancing.Models.Entities;

namespace Freelancing.Models
{
    public class AddProject
    {
        public Guid UserId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public string Budget { get; set; }
        public string Category { get; set; }
        public List<Project> Projects { get; set; } = new();
    }
}

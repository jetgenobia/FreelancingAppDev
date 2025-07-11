﻿namespace Freelancing.Models.Entities
{
    public class Project
    {
        public Guid Id { get; set; }
        public ICollection<Bidding> Biddings { get; set; }
        public Guid UserId { get; set; }
        public UserAccount User { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public string Budget { get; set; }
        public string Category { get; set; }
        public Guid? AcceptedBidId { get; set; }
        public Bidding? AcceptedBid { get; set; }
    }
}

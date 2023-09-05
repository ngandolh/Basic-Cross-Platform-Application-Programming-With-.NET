using System;

namespace BusinessObject
{
    public class ProjectObject
    {
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public DateTime EstimatedStartDate { get; set; }
        public DateTime EstimatedEndDate { get; set; }
        public string ProjectDescription { get; set; }
        public string ProjectAddress { get; set; }
        public string ProjectCity { get; set; }
    }
}

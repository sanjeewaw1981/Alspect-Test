using Alspec.Api.Service.Models;

namespace Alspec.Api.Service.Helpers
{
    public class SeedDataHelper
    {
        public List<Job> GetJob()
        {
            return new List<Job>()
            {
                new Job() {
                    Id = "1",
                    Title = "Job 1",
                    Description = "Alspec Product",
                    SubItems = this.GetSubItem()
                }
            };
        }

        private List<SubItem> GetSubItem()
        {
            return new List<SubItem>()
            {
                new SubItem()
                {
                    ItemId = "1",
                    Title = "Sub Item 1",
                    Description = "Sub-item description",
                    Status = "Pending"
                },
                new SubItem()
                {
                    ItemId = "2",
                    Title = "Sub Item 2",
                    Description = "Sub-item description2",
                    Status = "In Progress"
                },
                new SubItem()
                {
                    ItemId = "3",
                    Title = "Sub Item 3",
                    Description = "Sub-item description3",
                    Status = "Completed"
                }
            };
        }
    }
}

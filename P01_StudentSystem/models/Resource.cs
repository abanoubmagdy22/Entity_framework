using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.models
{
    public class Resource
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public ResourceType Type { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;
    }
}

using System;

namespace ProcessNote
{
    public class SingleProcess
    {
        public string Name { get; set; }
        public int  Id { get; set; }
        public DateTime StartTime { get; set; }
        public int MemoryUsage { get; set; }
        public int CPUUsage { get; set; }
    }
}
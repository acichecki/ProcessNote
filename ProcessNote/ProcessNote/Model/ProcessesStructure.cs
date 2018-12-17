using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ProcessNote
{
    public class ProcessesStructure
    {
        public List<SingleProcess> CreateStructure()
        {
           return GetProcesses().Select(process => new SingleProcess { Name = process.ProcessName, Id = process.Id, StartTime = process.StartTime} ).ToList();
        }

        private IEnumerable<Process> GetProcesses()
        {
            var localAll = Process.GetProcesses();
            return localAll;
        }
    }
}
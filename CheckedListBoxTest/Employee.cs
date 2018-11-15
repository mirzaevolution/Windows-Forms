using System;

namespace CheckedListBoxTest
{
    public class Employee
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string FullName { get; set; }
        public override string ToString()
        {
            return FullName;
        }
    }
}

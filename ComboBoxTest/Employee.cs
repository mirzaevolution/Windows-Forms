using System;

namespace ComboBoxTest
{
    public class Employee
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string FullName { get; set; }
    }
}

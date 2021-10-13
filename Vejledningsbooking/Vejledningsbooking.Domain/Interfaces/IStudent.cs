using System;

namespace Vejledningsbooking.Domain.Interfaces
{
    public interface IStudent
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        byte[] Rowversion { get; set; }
    }
}

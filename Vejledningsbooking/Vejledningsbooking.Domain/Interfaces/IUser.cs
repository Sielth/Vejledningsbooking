using System;

namespace Vejledningsbooking.Domain.Interfaces
{
    public interface IUser
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        byte[] Rowversion { get; set; }
    }
}

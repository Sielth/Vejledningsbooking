using System;
using System.Collections.Generic;

namespace Vejledningsbooking.Domain.Interfaces
{
    public interface IClass
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<IUser> Students { get; set; }
        byte[] Rowversion { get; set; }
    }
}

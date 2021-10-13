using System;
using System.Collections.Generic;
using Vejledningsbooking.Domain.Interfaces;

namespace Vejledningsbooking.Domain.Entities
{
    public class Class : IClass
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<IUser> Students { get; set; }
        public byte[] Rowversion { get; set; }

        public Class() { }
    }
}

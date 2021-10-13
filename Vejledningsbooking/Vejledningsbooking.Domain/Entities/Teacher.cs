using System;
using Vejledningsbooking.Domain.Interfaces;

namespace Vejledningsbooking.Domain.Entities
{
    public class Teacher : ITeacher, IUser
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public byte[] Rowversion { get; set; }

        public Teacher() { }
    }
}

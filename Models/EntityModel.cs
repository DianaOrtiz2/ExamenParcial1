using System;
namespace WAExamenParcial1.Models
using Microsoft.AspNetCore.Mvc;
{
    public EntityModel()
        {
        }
    public class EntityBase
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
    }
}

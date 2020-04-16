using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Plane
    {
        public string Id { get;}
        public string Model { get; }

        public Plane(string id, string model)
        {
            Id = id;
            Model = model;
        }
        public Plane()
        {

        }
    }
}

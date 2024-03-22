using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CarImage : BaseEntity<Guid>
    {
        public Guid CarId { get; set; }
        public string ImagePath { get; set; }
        public Car Car { get; set; }

        public CarImage()
        {

        }
        public CarImage(Guid id, Guid carId, string imagePath) : this()
        {
            Id = id;
            CarId = carId;
            ImagePath = imagePath;
        }
    }
}

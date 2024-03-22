using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CarImageService
{
    public class CarImageRequest
    {
        public Guid CarId { get; set; }
        public string ImagePath { get; set; }
    }
}

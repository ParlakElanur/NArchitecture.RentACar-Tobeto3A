using Application.Features.Cars.Models;
using Core.Application.Requests;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Cars.Queries.GetListPagination
{
    public class GetListPaginationCarQuery : IRequest<CarListModel>
    {
        public PageRequest PageRequest { get; set; }
    }
}

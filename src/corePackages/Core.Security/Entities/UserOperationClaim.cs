using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Security.Entities
{
    public class UserOperationClaim : BaseEntity<Guid>
    {
        public Guid UserId { get; set; }
        public Guid OperationClaimId { get; set; }

        public User User { get; set; }
        public OperationClaim OperationClaim { get; set; }

        public UserOperationClaim()
        {
        }
        public UserOperationClaim(Guid id, Guid userId, Guid operationClaimId)
        {
            Id = id;
            UserId = userId;
            OperationClaimId = operationClaimId;
        }
    }
}

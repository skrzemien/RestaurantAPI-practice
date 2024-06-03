using Microsoft.AspNetCore.Authorization;

namespace RestaurantAPI.Authorization
{
    public enum ResourceOpeartion
    {
        Create,
        Read,
        Update,
        Delete
    }
    public class ResourceOperationRequirement : IAuthorizationRequirement
    {
        public ResourceOperationRequirement(ResourceOpeartion resourceOpeartion)
        {
            ResourceOpeartion = resourceOpeartion;
        }
        public ResourceOpeartion ResourceOpeartion { get;}
    }
}

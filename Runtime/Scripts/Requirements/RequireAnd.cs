using System.Linq;
using UnityEngine;

namespace HHG.Requirements
{
    public class RequireAnd : IRequirement
    {
        [SerializeReference, SerializeReferenceDropdown] private IRequirement[] requirements;

        public bool IsRequirementMet(MonoBehaviour invoker)
        {
            return requirements.All(r => r.IsRequirementMet(invoker));
        }
    }
}
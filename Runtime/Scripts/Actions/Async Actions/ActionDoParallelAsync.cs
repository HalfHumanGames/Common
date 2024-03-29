using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HHG.Common.Runtime
{
    public class ActionDoParallelAsync : IActionAsync
    {
        [SerializeReference, SerializeReferenceDropdown] private List<IActionAsync> actions = new List<IActionAsync>();

        public IEnumerator DoAction(MonoBehaviour invoker)
        {
            List<Coroutine> coroutines = new List<Coroutine>();

            foreach (IActionAsync action in actions)
            {
                coroutines.Add(invoker.StartCoroutine(action?.DoAction(invoker)));
            }

            foreach (Coroutine coroutine in coroutines)
            {
                yield return coroutine;
            }
        }
    }
}
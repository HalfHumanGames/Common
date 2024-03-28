using UnityEngine;

namespace HHG.Common
{
    [CreateAssetMenu(fileName = "String", menuName = "HHG/Assets/Variable/String")]
    public class StringNameAsset : VariableAssetBase<string>
    {
        private void OnValidate()
        {
            value = name;
        }
    }
}
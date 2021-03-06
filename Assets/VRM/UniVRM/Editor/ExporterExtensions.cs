using System.Linq;
using UnityEngine;

namespace VRM
{
    public static class ExporterExtensions
    {
        public static bool EnableForExport(this Component mono)
        {
            if (mono.transform.GetComponentsInParent<Transform>().Any(x => !x.gameObject.activeSelf))
            {
                // 自分か祖先に !activeSelf がいる
                return false;
            }
            return true;
        }
    }
}

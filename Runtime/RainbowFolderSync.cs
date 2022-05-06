using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
using Borodar.RainbowHierarchy;
#endif

namespace WinuXGames.AssetUtility.BorodarRainbow
{
    [ExecuteAlways]
    public class RainbowFolderSync : MonoBehaviour
    {
        #if UNITY_EDITOR
        private void OnEnable() { HierarchyRulesetV2.OnRulesetChangeCallback += OnRulesetChange; }

        private void OnDisable() { HierarchyRulesetV2.OnRulesetChangeCallback -= OnRulesetChange; }

        private void OnRulesetChange() { PrefabUtility.ApplyPrefabInstance(gameObject, InteractionMode.UserAction); }
        #endif
    }
}
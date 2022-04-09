using Borodar.RainbowHierarchy;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace WinuXGames.AssetUtility.BorodarRainbow
{
    [ExecuteAlways]
    public class RainbowFolderSync : MonoBehaviour
    {
        #if UNITY_EDITOR
        private void OnEnable() { HierarchyRuleset.OnRulesetChangeCallback += OnRulesetChange; }

        private void OnDisable() { HierarchyRuleset.OnRulesetChangeCallback -= OnRulesetChange; }

        private void OnRulesetChange() { PrefabUtility.ApplyPrefabInstance(gameObject, InteractionMode.UserAction); }
        #endif
    }
}
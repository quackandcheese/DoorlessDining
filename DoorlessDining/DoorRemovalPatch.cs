using Kitchen;
using KitchenLib;
using KitchenMods;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using HarmonyLib;

namespace DoorlessDining
{
    [HarmonyPatch(typeof(LayoutBuilder))]
    public static class DoorRemovalPatch
    {
        [HarmonyPrefix]
        [HarmonyPatch(nameof(LayoutBuilder.BuildDoorBetween))]
        public static bool BuildDoorBetween_Prefix()
        {
            return false;
        }
    }
}

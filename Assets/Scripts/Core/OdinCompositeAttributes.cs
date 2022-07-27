using System;
using Sirenix.OdinInspector;

namespace Core
{
    [IncludeMyAttributes] [PropertyOrder(0)] [FoldoutGroup("Status", Expanded = true)] [ReadOnly] public class Status : Attribute {}
    [IncludeMyAttributes] [PropertyOrder(1)] [FoldoutGroup("Config", Expanded = true)] [Required] public class Config : Attribute {}
    [IncludeMyAttributes] [PropertyOrder(1)] [FoldoutGroup("Config", Expanded = true)] public class OptionalConfig : Attribute {}
    [IncludeMyAttributes] [PropertyOrder(2)] [FoldoutGroup("Ref", Expanded = true)] [Required] public class Ref : Attribute {}
    [IncludeMyAttributes] [PropertyOrder(2)] [FoldoutGroup("Ref", Expanded = true)] public class OptionalRef : Attribute {}

    [IncludeMyAttributes]
    [AssetSelector(Paths = "Assets/Prefabs/Actors", FlattenTreeView = true, DropdownWidth = 500)]
    public class ActorSelector : Attribute
    {
    }
    
    [IncludeMyAttributes]
    [AssetSelector(Paths = "Assets/ScriptableObjects/Loots", Filter = "t:Loot", FlattenTreeView = true, DropdownWidth = 500)]
    public class LootSelector : Attribute
    {
    }
}
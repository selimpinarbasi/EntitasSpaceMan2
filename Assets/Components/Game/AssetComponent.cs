using UnityEngine;
using UnityEditor;
using Entitas;

[Game]
public sealed class AssetComponent : IComponent
{
    public string name;
}
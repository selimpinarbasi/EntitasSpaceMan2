using UnityEngine;
using UnityEditor;
using Entitas;

[Game]
public sealed class ViewComponent : IComponent
{
    public GameObject gameObject;
}
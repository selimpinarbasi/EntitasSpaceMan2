using UnityEngine;
using UnityEditor;
using Entitas;

public sealed class ViewSystem : Feature
{
    public ViewSystem(Contexts contexts) : base("View Systems")
    {
        Add(new RemoveViewSystem(contexts));
        Add(new AddViewSystem(contexts));
        Add(new RenderPositionSystem(contexts));
    }
}
using UnityEngine;
using UnityEditor;
using Entitas;

public sealed class InputSystem : IExecuteSystem
{
    readonly InputContext _context;

    public InputSystem(Contexts contexts)
    {
        _context = contexts.ınput;
    }
    public void Execute()
    {
        _context.isAccelerating =
            Input.GetButton("Fire1") ||
            Input.GetAxisRaw("Vertical") > 0;/*
        _context.isMoveSpaceMan =
            Input.GetMouseButtonDown(0) || Input.GetAxisRaw("Vertical") > 0; */
    }

}
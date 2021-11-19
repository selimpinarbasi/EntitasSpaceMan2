using UnityEngine;
using UnityEditor;
using Entitas;
using System.Collections;

public class InitBackGroundSystem : IInitializeSystem
{
    readonly GameContext _context;
    float time;
    public InitBackGroundSystem(Contexts contexts)
    {
        _context = contexts.game;
    }

    public void Initialize()
    {
        
        const string resourceName = "backGround2";
        var e = _context.CreateEntity();
        e.AddAsset(resourceName);
        e.AddPosition(0, 12.78f, -1);//12.78f aslolan
        e.AddMove(0, 0.5f);
        e.isBackGround = true;
        e.isAcceleratable = true;
        
        /*time += Time.deltaTime;
        do
        {
            const string resourceName = "backGround2";
            var e = _context.CreateEntity();
            e.AddAsset(resourceName);
            e.AddPosition(0, 12.78f, 10);//12.78f aslolan

            e.AddMove(0, 0.025f);
            e.isBackGround = true;
            e.isAcceleratable = true;
            time = 0;

        }
        while (time > 1.5);*/
    }

}
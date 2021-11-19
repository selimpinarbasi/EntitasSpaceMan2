using UnityEngine;
using UnityEditor;
using Entitas;

public class InitAndExecuteBackGroundSystem : IExecuteSystem
{
    readonly IGroup<GameEntity> _group;
    float degisimZaman = 0;
    readonly GameContext _context;
    public InitAndExecuteBackGroundSystem(Contexts contexts)
    {
        _group = contexts.game.GetGroup(Matcher<GameEntity>.AllOf(/*GameMatcher.Position, GameMatcher.Acceleratable, GameMatcher.Move,*/ GameMatcher.BackGround));
        _context = contexts.game;
    }
    
    public void Execute()
    {
        foreach (var e in _group.GetEntities())
        {
            if (e.position.y <= -0.92f && e.position.y >= -0.99f)
            {
                var e2 = _context.CreateEntity();
                e2.AddAsset("backGround2");
                e2.AddPosition(0, 22.71f, -1);
                e2.AddMove(0, 0.5f);
                e2.isAcceleratable = true;
                e2.isBackGround = true;
            }
        }
        
        /*degisimZaman += Time.deltaTime;
        if (degisimZaman > 4.78f)//4.3f aslolan
        {
            var e2 = _context.CreateEntity();
            const string resourceName = "backGround2";
            e2.AddAsset(resourceName);
            e2.AddPosition(0, 22.77999f, 10);//22.77999f aslolan
            e2.AddMove(0, 0.00025f);
            e2.isAcceleratable = true;
            e2.isBackGround = true;
            if (e2.position.y == -0.92f)
            {
                e2.ReplacePosition(0, 22.77999f, 0);
            }
            degisimZaman = 0;
        }*/
        /*foreach (var e in _group.GetEntities())
        {
            var position = e.position;
            e.ReplacePosition(position.x, position.y + (-0.000009488f), position.z);
        }*/
        /*
        var e = _context.CreateEntity();
        const string resourceName = "backGround";
        e.AddAsset(resourceName); 
        e.AddPosition(0, 12.78f, 10);
        e.AddMove(0, -1);
        e.isAcceleratable = true;
        e.isBackGround = true;
        if (e.position.y == -0.92f)
        {
            e.AddAsset(resourceName);
            e.AddPosition(0, 12.78f, 10);
            e.AddMove(0, -1);
            e.isAcceleratable = true;
            e.isBackGround = true;
        }*/
    }
}
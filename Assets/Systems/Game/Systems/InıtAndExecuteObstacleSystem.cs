using UnityEngine;
using UnityEditor;
using Entitas;

public class InıtAndExecuteObstacleSystem : IExecuteSystem
{
    int lastIndex = -1;
    bool isDuplicated = false;
    float[] engellerArray = { 1.75f, -1.75f, 0 };
    public int getRandomExcept()
    {
        int tmpIndex = Random.Range(0, 3);
        if (tmpIndex == lastIndex)
        {
            if (isDuplicated)
            {
                return getRandomExcept();
            }
            else
            {
                isDuplicated = true;
            }

        }
        lastIndex = tmpIndex;
        return tmpIndex;
    }
    readonly IGroup<GameEntity> _group;
    readonly GameContext _context;
    float degisimZaman = 0;
    public InıtAndExecuteObstacleSystem(Contexts contexts)
    {
        _group = contexts.game.GetGroup(Matcher<GameEntity>.AllOf(GameMatcher.Position, GameMatcher.Acceleratable, GameMatcher.Move));
        _context = contexts.game;
    }
    public void Execute()
    {
        int eksen = getRandomExcept();
        const string resourceName = "Score2";
        degisimZaman += Time.deltaTime;
        if (degisimZaman > 1.15f)
        {
            var e = _context.CreateEntity();
            e.AddAsset(resourceName);
            e.AddPosition(engellerArray[eksen], 5.5f, 1);
            e.AddMove(0, -1);
            e.isAcceleratable = true;
            degisimZaman = 0;
        }
        float time = Time.time;

        Debug.Log("obstacle time : " + time);

        foreach (var e in _group.GetEntities())
        {
            var position = e.position;
            e.ReplacePosition(position.x, position.y + (-0.048f), position.z);
        }
    }
}
using UnityEngine;
using UnityEditor;
using Entitas;

public class GameSystems : Feature
{
    public GameSystems(Contexts contexts) : base("Game Systems")
    {
        Add(new AccelerateSystem(contexts));
        //Add(new MoveSystem(contexts));
        Add(new ReachedFinishSystem(contexts));
        Add(new MoveSpaceManSystem(contexts));
        //Add(new MoveObstaclesSystem(contexts));
        Add(new InıtAndExecuteObstacleSystem(contexts));
        //Add(new MoveBackGroundSystem(contexts));
        Add(new InitAndExecuteBackGroundSystem(contexts));
    }
}
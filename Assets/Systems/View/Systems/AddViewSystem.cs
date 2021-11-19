
using System;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public sealed class AddViewSystem : ReactiveSystem<GameEntity>
{
    readonly Transform _viewContainer = new GameObject("Views").transform;
    public AddViewSystem(Contexts contexts) : base(contexts.game)
    {

    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Asset);
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasAsset;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var e in entities)
        {
            var assetName = Resources.Load<GameObject>(e.asset.name);
            GameObject gameObject = null;
            try
            {
                gameObject = UnityEngine.Object.Instantiate(assetName);
            }
            catch (Exception)
            {
                Debug.Log("Cannot instantiate " + assetName);
                Debug.Log("Entity has asset " + Filter(e));
            }

            if (gameObject != null)
            {
                gameObject.transform.parent = _viewContainer;
                e.AddView(gameObject);
            }
        }
    }
}
/*
using System;
using System.Collections.Generic;
using Entitas;
using UnityEngine;


public sealed class AddViewSystem : ReactiveSystem<GameEntity>
{
    public AddViewSystem(Contexts contexts) : base(contexts.game)
    {

    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasAsset;
    }
    readonly Transform _viewContainer = new GameObject("Views").transform;

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var e in entities)
        {
                        var assetName = Resources.Load<GameObject>(e.asset.name);
            GameObject gameObject = null;
            try
            {
                gameObject = UnityEngine.Object.Instantiate(assetName);
            }
            catch (Exception)
            {
                Debug.Log("Cannot Instantiate " + assetName); 
            }
            if (gameObject != null)
            {
                gameObject.transform.parent = _viewContainer;
                e.AddView(gameObject);
            }
            
        }
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.AllOf(GameMatcher.Asset));
    }
}*/
/*using UnityEngine;
using UnityEditor;
using Entitas;
using System.Collections.Generic;

public sealed class AddViewSystem : ReactiveSystem<GameEntity>
{
    public AddViewSystem(Contexts contexts) : base(contexts.game)
    {
    }
    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var e in entities)
        {
            var assetName = Resources.Load<GameObject>(e.asset.name);
            GameObject gameObject = null;
            try
            {
                gameObject = Object.Instantiate(assetName);
            }
            catch (System.Exception)
            {
                Debug.Log("Cannot Instantiate " + assetName);
            }
            if (gameObject != null)
            {
                gameObject.transform.parent = _viewContainer;
                e.AddView(gameObject);
            }
        }
    }
    readonly Transform _viewContainer = new GameObject("Views").transform;

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasAsset;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Asset);
    }
}*/

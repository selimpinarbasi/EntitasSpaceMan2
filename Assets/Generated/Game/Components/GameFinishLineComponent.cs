//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity finishLineEntity { get { return GetGroup(GameMatcher.FinishLine).GetSingleEntity(); } }

    public bool isFinishLine {
        get { return finishLineEntity != null; }
        set {
            var entity = finishLineEntity;
            if (value != (entity != null)) {
                if (value) {
                    CreateEntity().isFinishLine = true;
                } else {
                    entity.Destroy();
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly FinishLineComponent finishLineComponent = new FinishLineComponent();

    public bool isFinishLine {
        get { return HasComponent(GameComponentsLookup.FinishLine); }
        set {
            if (value != isFinishLine) {
                var index = GameComponentsLookup.FinishLine;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : finishLineComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherFinishLine;

    public static Entitas.IMatcher<GameEntity> FinishLine {
        get {
            if (_matcherFinishLine == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.FinishLine);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherFinishLine = matcher;
            }

            return _matcherFinishLine;
        }
    }
}

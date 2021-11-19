//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputContext {

    public InputEntity acceleratingEntity { get { return GetGroup(InputMatcher.Accelerating).GetSingleEntity(); } }

    public bool isAccelerating {
        get { return acceleratingEntity != null; }
        set {
            var entity = acceleratingEntity;
            if (value != (entity != null)) {
                if (value) {
                    CreateEntity().isAccelerating = true;
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
public partial class InputEntity {

    static readonly AcceleratingComponent acceleratingComponent = new AcceleratingComponent();

    public bool isAccelerating {
        get { return HasComponent(InputComponentsLookup.Accelerating); }
        set {
            if (value != isAccelerating) {
                var index = InputComponentsLookup.Accelerating;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : acceleratingComponent;

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
public sealed partial class InputMatcher {

    static Entitas.IMatcher<InputEntity> _matcherAccelerating;

    public static Entitas.IMatcher<InputEntity> Accelerating {
        get {
            if (_matcherAccelerating == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.Accelerating);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherAccelerating = matcher;
            }

            return _matcherAccelerating;
        }
    }
}

using UnityEngine;

public class CollectableReverseMovement : Collectable
{
    protected override void Awake()
    {
        base.Awake();
        collectableName = "CollectableReverse";
    }

    public override void ApplyEffect()
    {
        if (controller != null)
        {
            controller.ReverseMovement(true);
        }
    }
}
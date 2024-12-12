using UnityEngine;

public class CollectableAddSpeed : Collectable
{
    protected override void Awake()
    {
        base.Awake();
        SetCollectableName("CollectableAddSpeed");
    }

    public override void OnCollect(Collider other)
    {
        base.OnCollect(other);

        Debug.Log("Collected a CollectableAddSpeed object!");
    }
}
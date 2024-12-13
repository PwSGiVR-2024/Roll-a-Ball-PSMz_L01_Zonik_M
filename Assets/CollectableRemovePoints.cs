using UnityEngine;

public class CollectableRemovePoints : Collectable
{
    protected override void Awake()
    {
        base.Awake();
        SetCollectableName("CollectablePoints");
        points = -5;
    }


    public override void OnCollect(Collider other)
    {
        base.OnCollect(other);

        Debug.Log("Collected a CollectablePoints object!");
    }
}

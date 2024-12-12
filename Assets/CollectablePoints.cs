using UnityEngine;

public class CollectablePoints : Collectable
{
    protected override void Awake()
    {
        base.Awake();
        SetCollectableName("CollectablePoints");
        reverseMovement = true;
    }


    public override void OnCollect(Collider other)
    {
        base.OnCollect(other); 

        Debug.Log("Collected a CollectablePoints object!");
    }
}

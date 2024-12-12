using UnityEngine;

public class CollectableReverseMovement : Collectable
{
    protected override void Awake()
    {
        base.Awake(); 
        SetCollectableName("CollectableReverse"); 
        reverseMovement = true;
    }

    public override void OnCollect(Collider other)
    {
        base.OnCollect(other);

        Debug.Log("Collected a CollectableReverseMovement object!");
    }
}
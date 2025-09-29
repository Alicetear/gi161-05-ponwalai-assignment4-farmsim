using UnityEngine;

public class NewFarm : Abstractanimal
{
    public int NewResource { get; protected set; }
    public override void MakeSound()
    {
        Debug.Log($"{name} croak, happiness increases.");
    }

    public override string Produce()
    {
        throw new System.NotImplementedException();
    }




}

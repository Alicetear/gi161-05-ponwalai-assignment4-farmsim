using UnityEngine;

public class Cow : Abstractanimal
{

    public float Milk { get; private set; }


    public override void Init (string newName)
    {
        base.Init(newName);
        FavoriteFood = FoodType.Hay;
    }

    public override void MakeSound()
    {
        Debug.Log($"{name} say Moo!");
    }


    public override string Produce()
    {
        if (Happiness >= 70)
        {
            float TotalMilk = Happiness / 10;
            Milk += TotalMilk ;
            Debug.Log($"{name} produced {TotalMilk} units of Milk , Total Milk: {Milk} units");
        }
        else
        {
            Debug.Log($"{name} is not happy enough to produce milk.");
        }
        return $"total Milk : {Milk}";
    }



    public void Moo()
    {
        AdjustHappiness(10);
        Debug.Log($"{name} say moo!, happiness increase!");

    }
























}

using UnityEngine;

public class Duck : Abstractanimal
{
    public override void MakeSound()
    {
        Debug.Log($"{name} say quack!");
    }


    public override void Init (string newName)
    {
        base.Init(newName);
        FavoriteFood = FoodType.insect;
    }

    public override string Produce()
    {
        int eggs = 0;
        int feathers = 0;

        if (Happiness <= 45)
        {
            Debug.Log($"{Name} is too unhappy to lay eggs.");
        }
        else if (Happiness >= 46 && Happiness <= 75)
        {
            eggs = 1;
            feathers = 1;
            Debug.Log($"{Name} poduct {eggs} units, Total feathers : {feathers}");
        }
        else
        {
            eggs = 2;
            feathers = 2;
            Debug.Log($"{Name} poduct {eggs} units, Total feathers : {feathers}");
        }

        return $"{Name} Total Duck Eggs: {eggs}, Total Feathers: {feathers}";

    }



}

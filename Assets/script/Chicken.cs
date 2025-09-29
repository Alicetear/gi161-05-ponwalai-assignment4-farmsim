using UnityEngine;

public class Chicken : Abstractanimal
{

    public int Eggs { get; private set; }



    public  override void Init (string newName)
    {
        base.Init(newName);
        Eggs = 0;
        FavoriteFood = FoodType.Corn;
    }



    public override void MakeSound()
    {
        Debug.Log($"{name} say cock-a-doodle-doo!");
    }

    public override string Produce()
    {
        int TotalEggs = 0;
        if (Happiness <= 50)
        {
            Eggs = 0;
            Debug.Log($"{name} is too unhappy to lay eggs.");
        }
        else if (Happiness >= 51 & Happiness <= 79)
        {
            Eggs = 2;
            TotalEggs = Happiness / 10;
            Debug.Log($"{name} produced {Happiness} eggs. Total Milk: {TotalEggs} units");
        }
        else //Happiness ????? 80 ??????  
        {
            Eggs = 3;
        }

        TotalEggs += Eggs;
        return $"{Name} produced {Eggs} Eggs. Total Eggs: {TotalEggs} eggs";

    }




    public void Sleep() 
    {
        AdjustHunger(5);
        AdjustHappiness(10);
        Debug.Log($"{name} are sleeping, their happiness and food value increase!");

    }





















}

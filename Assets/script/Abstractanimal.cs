using UnityEngine;

public enum FoodType
{
    Hay, //Cow like hay.
    Corn, //Chicken like Corn.
    insect, //Duck like insect.
    RottenFood, //spoiled food. ????????????????????
    AnimalFood, //convenience food. ??????????????
}

public abstract class Abstractanimal : MonoBehaviour //abstract can't use to construct  obj only for inherit
{

    private string animalname;
    public string Name {get => name; private set => name = string.IsNullOrEmpty (value) ? "Unknown" : value;}


    public int Hunger { get; private set; }

    public int Happiness { get; private set; }

    public FoodType FavoriteFood { get; protected set; }





    public virtual void Init(string newName)
    {
        name = newName;
        Hunger = 50 ;
        Happiness = 50 ;
    }


    public abstract void MakeSound();

    public abstract string Produce();




    public void AdjustHunger(int Amount)
    {
        //Hunger -= Amount;
        Hunger = Mathf.Clamp(Hunger, 0, 100);

        Debug.Log($"Your {name} are hungry.");
    }   




        public void AdjustHappiness(int amount)
        {
            Happiness += amount;
            Happiness = Mathf.Clamp(Happiness, 0, 100);
            Debug.Log($"The happiness value of the {name} is decreasing.");

        }


        public void Feed(int feed)
        {
            Hunger -= feed;
            Happiness += feed /2 ;
            Debug.Log($"{name} was fed {feed} units of generic food. Current Happiness : {Happiness}");
        }




        public void Feeds(FoodType AnimalFeed, int feedAnimal)
        {
            switch (AnimalFeed)
            {
               case FoodType.RottenFood:
                    Hunger -= feedAnimal;
                    Happiness += 15;
                    Debug.Log($"{name} was fed {AnimalFeed} units of preferred food: {FavoriteFood} , Happiness increased {Happiness} units, Current Happiness: {feedAnimal}  ");
                    break;
               default:
                  if (AnimalFeed == FavoriteFood)
                  {
                    Happiness -= 20;
                    Debug.Log($"{name} was fed {AnimalFeed} RottenFood. Unhappy! Happiness deceased 20 units, : {feedAnimal}.");

                  }
                  else 
                  {
                    Feed(feedAnimal);
                  }
                break;

            }
        }


        public void GetStatus()
        {
            Debug.Log($" Name : {name} | Hunger : {Hunger} | Happiness : {Happiness} | Prefered Food : {FavoriteFood}");
        }













    /*private int hunger;
    public int Hunger
    {
        get { return hunger; }
        private set
        {
            if (value < 0) hunger = 0;
            else if (value > 100) hunger = 100;
            else hunger = value;

        }
    }*/




    /*private int happiness;

    public int Happiness
    {
        get { return happiness; }
        private set
        {
            if (value < 0) hunger = 0;
            else if (value > 100) happiness = 100;
            else happiness = value;
        }
    }*/





























    
}

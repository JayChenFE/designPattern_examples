namespace KFC
{
    public abstract class MealBuilder
    {
       protected readonly Meal Meal = new Meal();

        public abstract void BuildFood();

        public abstract void BuildDrink();

        public Meal GetMeal()
        {
            return Meal;
        }
    }
}
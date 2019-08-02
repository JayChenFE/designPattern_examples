namespace KFC
{
    public class MealA : MealBuilder
    {
        public void buildDrink()
        {
            Meal.setDrink("可乐");
        }

        public void buildFood()
        {
            Meal.setFood("薯条");
        }

        public override void BuildFood()
        {
            throw new System.NotImplementedException();
        }

        public override void BuildDrink()
        {
            throw new System.NotImplementedException();
        }
    }
}
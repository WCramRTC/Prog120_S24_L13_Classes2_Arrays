namespace Prog120_S24_L13_Classes2_Arrays
{
    internal class Program
    {

        // Creating an array to hold the FoodItem objects
        static FoodItem[] foodItems = new FoodItem[10];


        static void Main(string[] args)
        {
            Preload();

            Console.WriteLine("Hello, World!");
        } // Main


        public static void Preload()
        {
            // Adding items to the array
            foodItems[0] = new FoodItem("Apple", 7, 95);
            foodItems[1] = new FoodItem("Banana", 4, 105);
            foodItems[2] = new FoodItem("Chicken Breast", 8, 165);
            foodItems[3] = new FoodItem("Broccoli", 5, 55);
            foodItems[4] = new FoodItem("Almonds", 7, 70);
            foodItems[5] = new FoodItem("Rice", 3, 206);
            foodItems[6] = new FoodItem("Orange", 7, 62);
            foodItems[7] = new FoodItem("Salmon", 8, 233);
            foodItems[8] = new FoodItem("Yogurt", 5, 100);
            foodItems[9] = new FoodItem("Avocado", 4, 234);
        }

    } // class

    public class FoodItem
    {
        // Public fields
        public string Name;
        public int Quantity;
        public int Calories;

        // Default constructor with placeholder data
        public FoodItem()
        {
            Name = "Placeholder";
            Quantity = 1;
            Calories = 0;
        }

        // Constructor to initialize all fields
        public FoodItem(string name, int quantity, int calories)
        {
            Name = name;
            Quantity = quantity;
            Calories = calories;
        }

        // Method to calculate total calories
        public int CalculateTotalCalories()
        {
            return Quantity * Calories;
        }

        // Method to display food item details
        public void DisplayFoodItem()
        {
            Console.WriteLine($"Name: {Name}, Quantity: {Quantity}, Calories per unit: {Calories}, Total Calories: {CalculateTotalCalories()}");
        }
    }
} // namespace

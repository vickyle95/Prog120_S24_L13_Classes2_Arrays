using System.Diagnostics;

namespace Prog120_S24_L13_Classes2_Arrays
{
    internal class Program
    {
        // Name: Vicky Le
        // Date: 5/28/24
        // Assignment: Classes2_Arrays

        // Array
        // Create a FoodItem with a size of 5
        static FoodItem[] foodItems = new FoodItem[5];

        static void Main()
        {
            Preload();

            FoodItem kiwi = new FoodItem("Kiwi", 1, 42);

            try
            {
                AddNewFoodItem(kiwi);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            DoubleArraySize();

            AddNewFoodItem(kiwi);

            foreach (FoodItem singleFoodItem in foodItems)
            {
                if(singleFoodItem != null)
                {
                    Console.WriteLine(singleFoodItem.DisplayFoodInformation());
                }
               
            }
            


            // foreach (Type variablename in collection)
            //foreach (FoodItem singleitem in foodItems)
            //{
            //    Console.WriteLine(singleitem.DisplayFoodInformation());
            //}

        } // Main

        public static void AddNewFoodItem(FoodItem newFoodItem)
        {
            // Loop through my food Item Array
            // Check for an empty spot
            // If and empty spot is found, add to space
            // else return error no space found

            for (int i = 0; i < foodItems.Length; i++)
            {
                // Check for an empty spot
                if (foodItems[i] == null)
                {
                    // If an mepty spot is found, add to space
                    foodItems[i] = newFoodItem;
                    // You can use the return keyword in a method that is void. To leave the method
                    return;
                }

            }
            // Throw a new exception
            throw new Exception("No more room in the array");
        }

        // DoubleArraySize()
        public static void DoubleArraySize()
        {
            int arraySize = foodItems.Length;
            int newSize = arraySize * 2;

            FoodItem[] tempArray = new FoodItem[newSize];

            for (int i = 0; i < foodItems.Length; i++)
            {
                tempArray[i] = foodItems[i];
            }
            foodItems = tempArray;

            foodItems = new FoodItem[newSize];


        } // DoubleArraySize()

        public static void DoubleArraySizeExample()
        {
            int ogArraySize = foodItems.Length;

            Console.WriteLine($"Original Array Size: {foodItems.Length}");

            DoubleArraySize();

            int doubleArraySize = ogArraySize * 2;
            bool isArraySizeDouble = doubleArraySize == foodItems.Length;

            if (isArraySizeDouble)
            {
                Console.WriteLine("The array size has doubled");

                foreach (FoodItem singleitem in foodItems)
                {
                    // How do we prevent a null exception error
                    // We check to see if something is not null

                    if (singleitem != null)
                    {
                        Console.WriteLine(singleitem.DisplayFoodInformation());
                    }
                    else
                    {
                        Console.WriteLine("Item Not Found");
                    }
                }
            }
            else
            {
                Console.WriteLine("The array size did not double");
            }
        } // DoubleArraySizeExample
        public static void Preload()
        {
            // Apple  7  95  665
            foodItems[0] = new FoodItem("Apple", 7, 95);

            // Banana 4  105 420
            foodItems[1] = new FoodItem("Banana", 4, 105);

            // Chicken Breast  8  165  1320
            foodItems[2] = new FoodItem("Chicken Breast", 8, 165);

            // Broccoli  5  55  275
            foodItems[3] = new FoodItem("Broccoli", 5, 55);

            // Almond 7 70 490
            foodItems[4] = new FoodItem("Almond", 7, 490);
        }

        public static void ClassMethodExample()
        {
            // FoodItem() ; Default Constructor
            // New Constructor : FoodItem(string, double, double)
            FoodItem apple = new FoodItem("Apple", 7, 95);
            FoodItem noValues = new FoodItem();

            // FoodItem
            // Name
            // Qty
            // Calories

            Console.WriteLine(apple.DisplayFoodInformation());
            apple.Qty = 9;

            //Console.WriteLine(apple.Calories);
            //Console.WriteLine(apple.TotalCalories());
        }


        // Talk about throwing exceptions
        // Class Methods
        // Arrays

    } // Class

    // Creating a class
    // access modifier class keyword name ( starts with an uppercase, and is singular )

    public class FoodItem
    {
        // Fields
        public string Name;
        public double Qty;
        public double Calories;

        // Constructors
        // Name of Class
        public FoodItem(string name, double qty, double calories)
        {
            // Fields = argument
            Name = name;
            Qty = qty;
            Calories = calories;

        } // FoodItem

        // Overloading methods
        // Overloading methods allows you to name similar methods the same name, but with different parameters

        public FoodItem()
        {
            Name = "Placeholder";
            Qty = 1;
            Calories = 0;
        }
        
        // Methods
        // Total Calories : Return the Qty * Calories
        // public static void: ClassMethodExample();
        public double TotalCalories()
        {
            return Qty * Calories;

        } // TotalCalories

        // Display Data
        // Name | Qty | Calories | Total Calories
        public string DisplayFoodInformation()
        {
            return $"{Name} | {Qty} | {Calories} | {TotalCalories}"; 
        }


    } // class FoodItem

} // Namespace

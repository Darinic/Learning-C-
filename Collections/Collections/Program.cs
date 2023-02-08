// See https://aka.ms/new-console-template for more information
namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare 2D array
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            //declare 3D array
            string[,,] threeD;

            //two dimensional array
            int[,] array2D = new int[,]
            {
                {1,2,3 },
                { 4,5,6},
                { 7,8,9}
        };



            Console.WriteLine("Central value is {0}", array2D[1, 1]);
            Console.WriteLine("7th value is {0}", array2D[2, 0]);

            //3D array
            string[,,] array3D = new string[,,]
            {
                {
                    {"00","01","02" },
                    {"10","11","12" },
                    {"20","21","22" }
                },
                {
                    {"00","01","02" },
                    {"10","11","12" },
                    {"20","21","22" }
                }
            };

            Console.WriteLine("The value is {0}", array3D[1,1,0]);

            string[,] array2DString = new string[3, 2]
            {
                   { "one", "two" },
                   { "three", "four" },
                   { "five", "six" }
            };

            array2DString[1, 1] = "chicken";

            int dimensions = array2DString.Rank;

            Console.WriteLine("The value is {0}", array2DString[1, 1]);

            Console.WriteLine("The value is {0}", dimensions);

            int[,] array2D2 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };


            foreach (int num in matrix)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("\n This is our 2d array printed using nested for loop");
            for(int i=0; i< matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        Console.WriteLine("Even: {0}", matrix[i, j]);
                    }
                    else
                    {
                        Console.WriteLine("Odd: {0}", matrix[i, j]);
                    }
                }
            }

            for(int i=0, j=2; i< matrix.GetLength(0); i++, j--)
            {
                Console.WriteLine(matrix[i, j]);
            }




            Console.Read();



            //
            Boolean valid = false;
            string inputValueType;

            Console.WriteLine("Enter a value");
            string inputValue = Console.ReadLine();

            Console.WriteLine("Select the Data type to validate the input you have entered");
            Console.WriteLine("Press 1 for String");
            Console.WriteLine("Press 2 for Integer");
            Console.WriteLine("Press 3 for Boolean");

            Console.Write("Enter:");
            int inputType = Convert.ToInt32(Console.ReadLine());

            switch(inputType)
            {
                case 1:
                    valid = isAllphabetic(inputValue);
                    inputValueType = "String";
                    break;
                case 2:
                    int retValue = 0;
                    valid = int.TryParse(inputValue, out retValue);
                    inputValueType = "Integer";
                    break;
                case 3:
                    bool retFlag = false;
                    valid = bool.TryParse(inputValue, out retFlag);
                    inputValueType = "Bolean";
                    break;
                default:
                    inputValueType = "unknown";
                    Console.WriteLine("Not able to detect the input type, something is wrong");
                    break;
            }

            Console.WriteLine($"You have entered a value {inputValue}");
            if (valid)
            {
                Console.WriteLine($"It is valid : {inputValueType}");
            }
            else
            {
                Console.WriteLine("It is an invalid : {0}", inputValueType);
            }

            Console.ReadKey();

            static bool isAllphabetic(string value)
            {
                foreach(char c in value)
                {
                    if (!char.IsLetter(c))
                        return false;
                }
                return true;
            }



            string[] myFriends = { "Michael", "Wlad", "Ilja", "Andy", "Daniel" };

            foreach (string name in myFriends)
            {
                Console.WriteLine($"Hello {name}, my friend");
            }


                int[] nums = new int[10];
            for (int i = 0; i < 10; i++)
            {
                nums[i] = i + 10;
            }

            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("Element{0} = {1}", j, nums[j]);
            }

            int counter = 0;
            foreach(int k in nums)
            {
                Console.WriteLine("Element{0} = {1}", counter, k);
                counter++;
            }

            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 12;
            grades[3] = 9;
            grades[4] = 7;

            Console.WriteLine("grades at index 0: " + grades[0]);

            string input = Console.ReadLine();
            grades[0] = int.Parse(input);

            Console.WriteLine("grades at index 0: " + grades[0]);

            int[] gradesOfMathStudents = { 20, 13, 12, 8, 8 };
            int[] gradesOfMathStudentsB = new int[] { 15, 20, 3, 17, 18, 15 };
                 
        }
    }
}

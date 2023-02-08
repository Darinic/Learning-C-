
using System.Collections;
using System.Linq;

namespace JaggedArrays
{
    class Program
    { 

        // Key - value
        // Auto - car

        static void Main(string[] args)
        {
            Queue<Order> orderQueue = new Queue<Order>();

            foreach(Order order in ReceiveOrdersFromBranch1())
            {
                orderQueue.Enqueue(order);
            }

            foreach (Order order in ReceiveOrdersFromBranch2())
            {
                orderQueue.Enqueue(order);
            }

            while (orderQueue.Count > 0)
            {
                Order currentOrder = orderQueue.Dequeue();
                currentOrder.ProcessOrder();
            }

            Console.ReadKey();
            //QUEUES

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            Console.WriteLine("The value at the front of the queue is : {0}", queue.Peek());
            queue.Enqueue(3);
            Console.WriteLine("The value at the front of the queue is : {0}", queue.Peek());
            queue.Enqueue(2);

            while ( queue.Count > 0 )
            {
                Console.WriteLine("The front value {0} was removed from the queue", queue.Dequeue());
                Console.WriteLine("Current queue count is {0}", queue.Count);
            }

            



            //STACKS
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            Console.WriteLine("Top value in the stack is: {0}", stack.Peek());
            stack.Push(2);
            Console.WriteLine("Top value in the stack is: {0}", stack.Peek());
            stack.Push(3);

            int myStackItem = stack.Pop();
            Console.WriteLine("popped item: {0}", myStackItem );
            Console.WriteLine("Top value in the stack is: {0}", stack.Peek());

            int[] numbers = new int[] { 8, 2, 3, 4, 7, 5, 2 };

            Stack<int> myStack = new Stack<int>();

            foreach(int number in numbers)
            {
                Console.Write(number + " ");
                myStack.Push(number);
            }

            Console.WriteLine("");
            Console.WriteLine("the numbers in reverse: ");

            while (myStack.Count > 0)
            {
                int number = myStack.Pop();
                Console.Write(number + " ");
            }



            Console.ReadKey();
            
            Employee[] employees = 
            {
            new Employee("CEO", "Gwyn", 95, 200),
            new Employee("Manager", "Joe", 35, 25),
            new Employee("HR", "Lora", 32, 21),
            new Employee("Secretary", "Petra", 28, 18),
            new Employee("Lead Developer", "Artorias", 55, 35),
            new Employee("Intern", "Ernest", 22, 8),
            };

            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();
            foreach(Employee emp in employees)
            {
                employeesDirectory.Add(emp.Role, emp);
            }

            //update
            string KeyToUpdate = "HR";
            if (employeesDirectory.ContainsKey(KeyToUpdate))
            {
                employeesDirectory[KeyToUpdate] = new Employee("HR", "Eleka", 26, 18);
                Console.WriteLine("Employee with Role/Key {0} was updated!.", KeyToUpdate);
            }
            else
            {
                Console.WriteLine("Employee with Role/Key {0} was not found!.", KeyToUpdate);
            }

            //remove

            string KeyToRemove = "Intern";
            if(employeesDirectory.Remove(KeyToRemove))
            {
                Console.WriteLine("Employee with Role/Key {0} was removed", KeyToRemove);
            }
            else
            {
                Console.WriteLine("Employee with Role/Key {0} was not found", KeyToRemove);
            }

            for(int i =0; i <employeesDirectory.Count; i++)
            {
                KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i);

                Console.WriteLine("Key: {0}", keyValuePair.Key);

                Employee employeeValue = keyValuePair.Value;

                Console.WriteLine($"Employee Name: {employeeValue.Name}, Role: {employeeValue.Role}, Age: {employeeValue.Age}, Salary: {employeeValue.Salary}");
            }

            
            string key = "HR";
            if (employeesDirectory.ContainsKey(key))
            {
                Employee emp1 = employeesDirectory[key];
                Console.WriteLine($"Employee Name: {emp1.Name} , Role: {emp1.Role}, Salary: {emp1.Salary}");
            }
            else
            {
                Console.WriteLine($"Employee with role {key} not found");
            }

            Employee result = null;
            if(employeesDirectory.TryGetValue("Intern", out result))
            {
                Console.WriteLine("Value retrieved!");

                Console.WriteLine("Employees Name: {0}, Role: {1}, Age: {2} Salary: {3}", result.Name, result.Role, result.Age, result.Salary);
            }
            else
            {
                Console.WriteLine("Key does not exist");
            }
            
        
            Console.ReadKey();

            Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
                { 1, "one" },
                { 2, "two" },
                {3, "three" }

            };





            Hashtable table = new Hashtable();


            Student[] students = new Student[5];
            students[0] = new Student(1, "Denis", 88);
            students[1] = new Student(2, "Olaf", 97);
            students[2] = new Student(6, "Ragner", 65);
            students[3] = new Student(1, "Luise", 73);
            students[4] = new Student(4, "Levi", 58);

            foreach (Student student in students)
            {
                if (!table.ContainsKey(student.Id))
                {
                    table.Add(student.Id, student);
                    Console.WriteLine($"Student with ID {student.Id} was added");
                }
                else
                {
                    Console.WriteLine("Sorry, a student with same ID already exists, ID: {0}", student.Id);
                }
            }

            Console.ReadKey();

            /*
            Hashtable studentsTable = new Hashtable();

            Student stud1 = new Student(1, "Maria", 98);
            Student stud2 = new Student(2, "Jason", 76);
            Student stud3 = new Student(3, "Clara", 43);
            Student stud4 = new Student(4, "Steve", 55);

            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);
           
            //retreave individual item with known ID
            Student storedStudent1 = (Student)studentsTable[1];

            //retrieve all values from a Hasthtable
            foreach(DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine("Student ID:{0}, Name: {1}, GPA : {2}", temp.Id, temp.Name, temp.GPA);
            }

            foreach (Student value in studentsTable.Values)
            {
                
            }

            Console.WriteLine("Student ID:{0}, Name: {1}, GPA : {2}", storedStudent1.Id, storedStudent1.Name, storedStudent1.GPA );
            Console.ReadKey();
             */




            //declaring an arraylist with undefined amount of objects
            ArrayList myArrayList = new ArrayList();
            //declaring an arraylist with defined amount of objects
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(13.37);
            myArrayList.Add(13);
            myArrayList.Add(128);
            myArrayList.Add(25.3);
            myArrayList.Add(13);

            //delete element with specific value from the arraylist
            myArrayList.Remove(13);
            //delete element at specific position
            myArrayList.RemoveAt(0);

            Console.WriteLine(myArrayList.Count);

            double sum = 0;
            foreach (object obj in myArrayList)
            {
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if (obj is double)
                {
                    sum += (double)obj;
                }
                else if (obj is string)
                {
                    Console.WriteLine(obj);
                }

            }

            Console.WriteLine(sum);
            Console.ReadKey();




            int min = MinV2(6, 4, 2, 8, -11, -40, 5);

            Console.WriteLine($"The minimum is {min}");

            Console.ReadKey();


            Console.WriteLine("price is {0}, pi is {1}, at is {2 }", 32, 3.14, '@');

            int price = 50;
            float pi = 3.14f;
            char at = '@';
            string book = "The Hobbit";

            ParamsMethod("This", " is", " a ", "long ", "string ", "I ", "have", " no ", "idea ", "when ", "it's ", "going", " to ", "end");
            ParamsMethod2(price, pi, at, book);
            ParamsMethod2("Hello", 5.3, '$');
            Console.ReadKey();



            int[] happiness = new int[5] { 3, 2, 5, 4, 5 };
            IncreaseHappiness(happiness);

            foreach (int h in happiness)
            {
                Console.WriteLine(h);
            }

            Console.ReadKey();




            int[] studentsGrades = new int[] { 15, 13, 8, 12, 6, 16 };
            double averageResult = GetAverage(studentsGrades);

            foreach (int grade in studentsGrades)
            {
                Console.WriteLine(grade);
            }

            Console.WriteLine($"The average is {averageResult}");
            Console.ReadKey();





            string[][] jaggedFriendsArray = new string[3][];
            jaggedFriendsArray[0] = new string[2] { "John", "Mary" };
            jaggedFriendsArray[1] = new string[2] { "Peter", "Paul" };
            jaggedFriendsArray[2] = new string[2] { "Tom", "Jerry" };

            for (int i = 0; i < jaggedFriendsArray.Length; i++)
            {
                for (int j = 0; j < jaggedFriendsArray[i].Length; j++)
                {
                    Console.WriteLine("Hi {0}, meet {1}", jaggedFriendsArray[i][j], jaggedFriendsArray[i][j == 0 ? 1 : 0]);
                    break;
                }
            }

            Console.ReadLine();




            //declare jaggedArray
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 };
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 13, 21 };

            //alternative way

            int[][] jaggedArray2 = new int[][]
            {
                new int[] {2, 3, 5, 7, 11 },
                new int[] { 1, 2, 3 },
                new int[] { 13, 21 }
            };

            Console.WriteLine("The value in the middle of the first entry is {0}", jaggedArray2[0][2]);

            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                Console.WriteLine("Element {0}", i);
                for (int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.WriteLine("Element [{0}][{1}] = {2}", i, j, jaggedArray2[i][j]);
                }
            }
            Console.ReadKey();
        }

        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }
            average = (double)sum / size;
            return average;
        }

        static void IncreaseHappiness(int[] happiness)
        {
            for (int i = 0; i < happiness.Length; i++)
            {
                happiness[i] += 2;
            }
        }

        public static void ParamsMethod(params string[] sentence)
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                Console.Write(sentence[i] + " ");
            }
        }
        public static void ParamsMethod2(params object[] stuff)
        {
            foreach (object obj in stuff)
            {
                Console.Write(obj + " ");
            }
        }

        public static int MinV2(params int[] numb)
        {
            int min = int.MaxValue;
            foreach (int num in numb)
            {
                if (num < min)
                    min = num;
            }
            return min;
        }
    
        static Order[] ReceiveOrdersFromBranch1()
        {
            Order[] orders = new Order[]
            {
                new Order(1,5),
                new Order(2, 4),
                new Order(6, 10)
            };

            return orders;
        }
        static Order[] ReceiveOrdersFromBranch2()
        {
            Order[] orders = new Order[]
            {
                new Order(3,5),
                new Order(4, 4),
                new Order(5, 10)
            };

            return orders;
        }

    }
    
    class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public float GPA { get; set; }

        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }

    class Employee
    {
        public string Role { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public float Rate { get; set; }

        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
            
        }

        public Employee(string role, string name, int age, float rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = rate;
            {
            }
        }    
    }
    class Order
    {
        public int OrderId { get; set; }

        public int OrderQuantity { get; set; }

        public Order(int id, int orderQuantity)
        {
            this.OrderId = id;
            this.OrderQuantity = orderQuantity;

        }
        
        public void ProcessOrder()
        {
            Console.WriteLine($"Order {OrderId} has been processed");
        }
    }
}
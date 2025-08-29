using Demo01;
using Demo01.Data;
using System.ComponentModel.DataAnnotations;
using static Demo01.ListGenerator;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace LinqDemo
{
    internal class Program
    {
        //public static void Print(dynamic x)
        //{
        //    Console.WriteLine(x);
        //}
        //public static void Print(object x)
        //{
        //    Console.WriteLine(x);
        //}
        static void Main(string[] args)
        {
            #region Implicitly Typed Local Variable [Var , Dynamic]
            #region Var => Compile Time
            // Compiler will detect data type based on initial value at compilation time
            // Must be Initialized
            // Can not initialize with null
            // Can not change the datatype after initialization
            //var x = "Ahmed";

            //x = "Ali";
            #endregion

            #region Dynamic
            // Compiler will detect data type based on last value at run time
            // may be Initialized
            // Can be initialized with null
            // Can change the datatype after initialization

            //dynamic x = 10;

            //x = "Ahmed";
            #endregion
            #endregion

            #region Extension Method
            //int x = 123456;

            //int result  = IntExtensions.Reverse(x);
            //int result  = x.Reverse();

            //Console.WriteLine(result);
            #endregion

            #region Anonymous Type
            //var person = new { Id = 1, Name = "Test", Age = 10 };

            //var person2 = new { Id = 2, Name = "Test2", Age = 20 };
            // Compiler will always generate same anonymous type as long as :
            // Same Number Of Properties
            // Same Name Of Properties (Case Sensitive)
            // Same Order
            //Console.WriteLine(person.GetType().Name);
            //Console.WriteLine(person2.GetType().Name);

            // person2.Age = 10; // Invalid as it read-only

            //var person3 = person2 with { Name = "Ahmed" };

            //Console.WriteLine(person2);
            //Console.WriteLine(person3);
            #endregion

            #region Linq Syntax
            //List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            #region Fluent Syntax
            // as Static Method
            // 1.1 Call "LINQ Operators" as Static Method
            //var oddNumbers = Enumerable.Where(numbers, x => x % 2 == 1);

            // 1.2 Call "LINQ Operators" As Extension Method[Recommended]
            //var oddNumbers = numbers.Where(x => x % 2 == 1);

            //foreach (var number in oddNumbers)
            //    Console.WriteLine(number);
            #endregion

            #region Query Syntax
            // select *
            // from numbers
            // where x % 2 == 1

            //var oddNumbers = from number in numbers
            //                 where number % 2 == 1
            //                 select number;

            //foreach (var number in oddNumbers)
            //    Console.WriteLine(number);
            #endregion
            #endregion

            #region LINQ Execution Ways
            // List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            #region Deferred Execution

            //var query = numbers.Where(x => x % 2 == 0);

            //numbers.AddRange(new int[] { 11, 12, 13, 14, 15, 16, 17, 18 , 19 , 20 });

            //foreach ( var number in query)
            //    Console.WriteLine(number);
            #endregion

            #region Immediate Execution
            //var query = numbers.Where(x => x % 2 == 0).ToList();

            //numbers.AddRange(new int[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 });

            //foreach (var number in query)
            //    Console.WriteLine(number);
            #endregion
            #endregion

            #region Data Setup
            //Console.WriteLine(ProductList[0]);
            //Console.WriteLine(CustomerList[0]);
            #endregion

            #region Filteration (Restrictions) Operators [Where]
            //var result = ProductList.Where(product => product.UnitsInStock == 0);

            //var result = from product in ProductList
            //         where product.UnitsInStock == 0
            //         select product;

            //var result = ProductList.Where(product => product.UnitsInStock > 0 && product.Category == "Meat/Poultry");

            //result = from product in ProductList
            //             where product.UnitsInStock > 0 && product.Category == "Meat/Poultry"
            //             select product;

            //foreach (var unit in result)
            //    Console.WriteLine(unit);

            // Indexed Where
            // Indexed Where Is Valid Only In Fluent Syntax , can not be written using query syntax
            //var result = ProductList.Where((product, index) => index < 10 && product.UnitsInStock == 0);

            //foreach (var unit in result)
            //    Console.WriteLine(unit);

            #endregion

            #region Transformation (Projection) Operators [Select , Select Many]
            //var result = ProductList.Select(product => product.ProductName);

            //result = from product in ProductList
            //         select product.ProductName;

            //foreach (var item in result) 
            //    Console.WriteLine(item);

            //var customerOrders = CustomerList.SelectMany(customer => customer.Orders);

            //customerOrders = from customer in CustomerList
            //                 from order in customer.Orders
            //                 select order;


            //foreach (var customer in customerOrders)
            //    Console.WriteLine(customer);

            //var result = ProductList.Select(product => new Product { ProductID = product.ProductID, ProductName = product.ProductName });
            //var result = ProductList.Select(product => new { Id = product.ProductID, Name = product.ProductName }); 
            //.Where(x => x.Name.StartsWith('S'));


            //result = from product in ProductList
            //         select new { Id = product.ProductID, Name = product.ProductName };

            //foreach (var item in result) 
            //    Console.WriteLine(item);

            //var discountedList = ProductList.Where(product => product.UnitsInStock > 0)
            //                                .Select(product => new
            //                                {
            //                                    Id = product.ProductID,
            //                                    Name = product.ProductName,
            //                                    NewPrice = product.UnitPrice - (product.UnitPrice * 0.1M)
            //                                });

            //discountedList = from product in ProductList
            //                 where product.UnitsInStock > 0
            //                 select new
            //                 {
            //                     Id = product.ProductID,
            //                     Name = product.ProductName,
            //                     NewPrice = product.UnitPrice - (product.UnitPrice * 0.1M)
            //                 };

            //foreach (var discounted in discountedList)
            //    Console.WriteLine(discounted);

            // Indexed Select
            //var result = ProductList.Where(product => product.UnitsInStock > 0)
            //                        .Select((product, index) => new
            //                        {
            //                            Index  =index,
            //                            Name = product.ProductName
            //                        });

            //foreach (var item in result) 
            //    Console.WriteLine(item);
            #endregion

            #region Ordering Operators
            //var result = ProductList.OrderBy(product => product.UnitPrice);

            //result = from product in ProductList
            //         orderby product.UnitPrice
            //         select product;

            //var result = ProductList.OrderByDescending(product => product.UnitPrice);

            //result = from product in ProductList
            //         orderby product.UnitPrice descending
            //         select product;

            //var result = ProductList.OrderBy(product => product.UnitsInStock).ThenByDescending(product => product.UnitPrice);

            //result = from product in ProductList
            //         orderby product.UnitsInStock, product.UnitPrice descending
            //         select product;

            // Reverse

            //var result = ProductList.Where(product => product.UnitsInStock == 0).Reverse();

            //foreach (var item in result) 
            //    Console.WriteLine(item);
            #endregion


            //========================== Assignment ==========================\\
            #region ========================== Assignment ==========================

            #region LINQ - Transformation Operators

            #region 1.
            //foreach (var product in ProductList)
            //    Console.WriteLine(product.ProductName);
            #endregion

            #region 2.

            //string[] words = { "aPPLE", "BLUeBeRry", "cHeRry" };

            //var result = words.Select(word => new
            //{
            //    Original = word,
            //    Upper = word.ToUpper(),
            //    Lower = word.ToLower()
            //});

            //foreach (var word in result)
            //{
            //    Console.WriteLine($"Original: {word.Original}, Upper: {word.Upper}, Lower: {word.Lower}");
            //}

            #endregion

            #region 3.

            //int[] numbersA = [0, 2, 4, 5, 6, 8, 9];
            //int[] numbersB = [1, 3, 5, 7, 8];

            //var result = from a in numbersA
            //             from b in numbersB
            //             where a < b
            //             select new { A = a, B = b };

            //foreach (var num in result)
            //{
            //    Console.WriteLine($"{num.A} is less than {num.B}");
            //}

            #endregion

            #region 4.

            //var result = from customer in CustomerList
            //             from order in customer.Orders
            //             where order.Total < 500
            //             select order;

            //foreach (var order in result)
            //    Console.WriteLine(order);

            #endregion

            #region 5.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Where((num, index) => num == index);

            //foreach (var num in result)
            //    Console.WriteLine(num);

            #endregion

            #endregion

            #region LINQ - Restriction Operators

            #region 1.

            //var result = ProductList.Where(product => product.UnitsInStock == 0);

            //foreach (var product in result)
            //    Console.WriteLine(product);

            #endregion

            #region 2.
            //var result = ProductList.Where(product => product.UnitsInStock > 0 && product.UnitPrice > 3);

            //foreach (var product in result)
            //    Console.WriteLine(product);
            #endregion

            #region 3.

            //int[] Arr = { 3, 4, 2, 0, 1, 5, 6 };

            //var result = Arr.Where((num, index) => num == index);

            //foreach (var num in result)
            //    Console.WriteLine(num);

            #endregion

            #region 4.
            //var result = ProductList.Select(product => new { Name = product.ProductName, Price = product.UnitPrice });

            //foreach (var product in result)
            //    Console.WriteLine(product);
            #endregion

            #region 5.
            //var result = from customer in CustomerList
            //             from order in customer.Orders
            //             where order.OrderDate.Year >= 1998
            //             select order;


            //foreach (var order in result)
            //    Console.WriteLine(order);
            #endregion

            #endregion

            #region LINQ - Ordering Operators

            #region 1.
            //var result = ProductList.OrderBy(product => product.ProductName);

            //foreach (var product in result)
            //    Console.WriteLine(product);
            #endregion

            #region 2.
            //var result = ProductList.OrderByDescending(product => product.UnitsInStock);

            //foreach (var product in result)
            //    Console.WriteLine(product);
            #endregion

            #region 3.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr.OrderBy(word => word.Length).ThenBy(word => word);        

            //foreach (var word in result)
            //    Console.WriteLine(word);
            #endregion

            #region 4.
            //var result = ProductList.OrderBy(product => product.Category).ThenByDescending(product => product.UnitPrice);

            //foreach (var product in result)
            //    Console.WriteLine(product);
            #endregion

            #region 5.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(word => word.Length).ThenByDescending(word => word.ToLower());

            //foreach (var word in result)
            //    Console.WriteLine(word);
            #endregion

            #region 6.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr.Where(word => word.Length >= 2 && word[1] == 'i').Reverse().ToList();                                       

            //foreach (var word in result)
            //    Console.WriteLine(word);
            #endregion

            #endregion

            #endregion
        }
    }
}

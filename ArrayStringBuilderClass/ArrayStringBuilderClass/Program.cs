using System.Text;

namespace ArrayStringBuilderClass
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1

            //Console.WriteLine(Reverse("Salam P320 Qrupu"));

            #endregion

            #region Task 2

            //bool isLogin = Login("admin", "admin123");
            //if (isLogin)
            //{
            //    Console.WriteLine("Welcome");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}

            #endregion

            #region Array

            //int[] arr = { 1, 3, 4, 6, 6, 8 };
            //int[] arr3 = new int[] { 1, 3, 4, 6, 6, 8 };
            //int[] arr2 = new int[10] { 1,2,3,4,5,6,7,8,9,10};

            //foreach (int item in arr2)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] arr = { 2, 3, 1, 9, 6, 8 };

            //Array.Sort(arr);
            //Array.Reverse(arr);

            //foreach (int item in arr)
            //{
            //    Console.Write(item + " ");
            //}

            //string[] arr = new string[3];
            //string[] arr = { "Orkhan", "Elnur", "Elvin" };

            //string result = string.Join(", ", arr);
            //Console.WriteLine(result);

            #endregion

            #region StringBuilder

            //StringBuilder sb = new StringBuilder();
            //sb.Append("Elnur P320 Elnur Elnur");
            ////sb.Insert(1, "Salam");
            //sb.Replace("Elnur", "Mr.Elnur");

            //Console.WriteLine(sb);

            #endregion

            #region Class

            //string s1Name = "Elnur";
            //string s1Surname = "Meherremli";
            //int s1Age = 28;

            //Console.WriteLine($"{s1Name} {s1Surname} {s1Age}");

            //string s2Name = "Elnur";
            //string s2Surname = "Meherremli";
            //int s2Age = 28;
            //Console.WriteLine($"{s1Name} {s1Surname} {s1Age}");

            //Student s1 = new Student();
            //s1.Name = "Elnur";
            //s1.Surname = "Meherremli";
            //s1.Age = 28;

            //Instance almaq
            Student s1 = new Student
            {
                Name = "Elnur",
                Surname = "Meherremli",
                Age = 28
            };
            //s1.PrintFullName();

            Student s2 = new Student
            {
                Name = "A",
                Surname = "B",
                Age = 28
            };
            //s2.PrintFullName();

            Student s3 = new Student
            {
                Name = "Elnur",
                Surname = "Meherremli",
                Age = 28
            };
            //s3.PrintFullName();

            Student s4 = new Student();
            //s4.PrintFullName();

            //Student[] students = { s1, s2, s3, s4 };
            //foreach (Student item in students)
            //{
            //    item.PrintFullName();
            //}

            #endregion

            //1. Custom join. Input string array, string separator.
            //Output string
            //2. Custom int array sort
        }

        #region Task 1

        static string Reverse(string text)
        {
            string[] arr = text.Split(" ");
            //string result = "";
            StringBuilder result = new StringBuilder();

            foreach (string item in arr)
            {
                for (int i = item.Length - 1; i >= 0; i--)
                {
                    //result += item[i];
                    result.Append(item[i]);
                }

                //result += " ";
                result.Append(" ");
            }

            return result.ToString().TrimEnd();
        }

        #endregion

        #region Task 2

        static bool Login(string username, string password)
        {
            string existUsername = "Admin";
            string existPassword = "Admin123";

            //bool isAuth = false;

            //if (username.ToLower().Equals(existUsername.ToLower()) &&
            //    password.ToLower().Equals(existPassword.ToLower()))
            //{
            //    isAuth = true;
            //}

            //return isAuth;

            //bool isAuth = username.ToLower().Equals(existUsername.ToLower()) &&
            //                password.ToLower().Equals(existPassword.ToLower());

            //return isAuth;

            if (username.ToLower().Equals(existUsername.ToLower()) &&
                password.ToLower().Equals(existPassword.ToLower()))
            {
                return true;
            }

            return false;
        }

        #endregion
    }
}

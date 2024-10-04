namespace iron_project


{
    public class Program
    {
        public void Main(string[] args)
        {
            Console.WriteLine("Введите через запятую целые числа и нажмите Enter");
            string[] nums = Console.ReadLine().Split(new char[] { ',' });
            int[] intArray = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                intArray[i] = int.Parse(nums[i]);
            }

            Class1.GnomeSort(intArray);

            Console.WriteLine("\r\nОтсортированный массив:");
            foreach (int value in intArray)
            {
                Console.Write($"{value} ");
            }
        }
    }
}

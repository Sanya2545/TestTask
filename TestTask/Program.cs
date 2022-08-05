// See https://aka.ms/new-console-template for more information

namespace TestTask
{
    public class Program
    {
        public static uint [] BubbleSortByWeight(uint[] nums, uint[] sums )
        {
            //Console.WriteLine("Исходный массив");
            //Console.WriteLine(string.Join(" ", nums.Select(x => x.ToString()).ToArray()));
            //var v = nums.OrderBy(s => int.Parse((s.ToString().ToCharArray()[0]).ToString())
            //    + int.Parse((s.ToString().ToCharArray()[1]).ToString()));
            //Console.WriteLine("последовательность по возрастанию сумм цифр");
            //Console.WriteLine(string.Join(" ", v.Select(x => x.ToString()).ToArray()));
            //Console.ReadKey();
            //return nums;

            uint tempNum = 0;
            uint tempSum = 0;
            for (int j = 0; j <= nums.Length - 2; j++)
            {
                for (int i = 0; i <= nums.Length - 2; i++)
                {
                    if (sums[i] > sums[i + 1])
                    {
                        tempNum = nums[i + 1];
                        tempSum = sums[i + 1];

                        nums[i + 1] = nums[i];
                        sums[i + 1] = sums[i];

                        nums[i] = tempNum;
                        sums[i] = tempSum;
                    }
                    else if (sums[i] == sums[i + 1])
                    {
                        if (nums[i].ToString().CompareTo(nums[i + 1].ToString()) > 0)
                        {
                            tempNum = nums[i + 1];
                            tempSum = sums[i + 1];

                            nums[i + 1] = nums[i];
                            sums[i + 1] = sums[i];

                            nums[i] = tempNum;
                            sums[i] = tempSum;
                        }
                    }
                }
            }
            return nums;

        }
        public static string PrepareForSortByWeight(string weights = "")
        {
            //char[] charsToTrim = { ' ' }; 
            weights = weights.Trim();
            string[] weightsArray = weights.Split(' ');
            uint[] nums = new uint[weightsArray.Length];
            uint[] sums = new uint[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                uint.TryParse(weightsArray[i], out nums[i]);
                uint temp = 1;
                temp = nums[i];
                while (temp > 0)
                {
                    sums[i] = sums[i] + temp % 10;
                    temp= temp / 10;
                    //nums[i] = nums[i] / 10;

                }
                Console.WriteLine(sums[i]);
            }
            nums = BubbleSortByWeight(nums, sums);
            string numberArrays = "";
            foreach (int i in nums)
            {
                numberArrays += i.ToString() + "\t";
            }
            return numberArrays;
        }

        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string str = PrepareForSortByWeight("45 34 24 108 76 58 64 130 80");
            Console.WriteLine(str);
        }
    }
    
}

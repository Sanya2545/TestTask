// See https://aka.ms/new-console-template for more information

namespace TestTask
{
    public class Program
    {
        public static string Order(string weights = "")
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
                //Console.WriteLine(sums[i]);
            }
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

            string numberArrays = "";
            foreach (int i in nums)
            {
                numberArrays += i.ToString() + " ";
            }
            return numberArrays;
        }

        
        static void Main(string[] args)
        {
            
            string str1 = Order("45 34 24 108 76 58 64 130 80");
            Console.WriteLine($"Sorted Line #1 :\n{str1}");
            string str2 = Order("    2022 70 123    3344 13 ");
            Console.WriteLine($"Sorted Line #1 :\n{str2}");
        }
    }
    
}

    public class Solution
    {
        public static IEnumerable<long> FindMissingNumbers(long[] nums)
        {
            ArgumentNullException.ThrowIfNull(nums);

            var set = new HashSet<long>(nums);
            var max = nums.Length > 0 ? nums.Max() : 0;

            if (max <= nums.Length)
                yield break;

            for (long i = 0; i <= max; i++)
            {
                if (!set.Contains(i))
                    yield return i;
            }
        }
        
        public static void DisplayMissingNumbers(long[] nums)
        {
            var missingNumbers = FindMissingNumbers(nums);
        
            Console.WriteLine("Отсутствующие числа:");
            foreach (var num in missingNumbers)
            {
                Console.Write(num);
                Console.Write(" ");
                if (Console.CursorLeft > 70)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
    }
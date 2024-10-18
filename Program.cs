namespace Binary_Search_Find_X
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] arr = [-1, 0, 3, 5, 9, 12];
            int target = 9;
            //Console.WriteLine(Search(arr, target));
            Console.WriteLine(Recur(arr, target, 0, arr.Length -1));
        }

        public static int Search(int[] nums, int target)
        {
            int n = nums.Length;
            int low = 0, high = n - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] > target)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return -1;
        }

        public static int Recur(int[] nums, int target, int low, int high)
        {
            if (low > high)
                return -1;

            int mid = (low + high) / 2;
            if (nums[mid] == target)
                return mid;
            else if (target > nums[mid])
                return Recur(nums, target, mid + 1, high);
            else
                return Recur(nums, target, low, mid - 1);
        }
    }
}

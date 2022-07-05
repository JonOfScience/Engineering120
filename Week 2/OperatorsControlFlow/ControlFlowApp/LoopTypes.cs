namespace ControlFlowApp
{
    public static class LoopTypes
    {
        public static int HighestForEachLoop(List<int> nums)
        {
            if (nums.Count < 1)
                throw new ArgumentException();

            int highest = int.MinValue;
            foreach (int value in nums)
            {
                if (value > highest)
                {
                    highest = value;
                }
            }
            return highest;
        }

        public static int LowestForEachLoop(List<int> nums)
        {
            if (nums.Count < 1)
                throw new ArgumentException();

            int lowest = int.MaxValue;
            foreach (int value in nums)
                if (value < lowest)
                    lowest = value;
            return lowest;
        }

        public static int HighestForLoop(List<int> nums)
        {
            if (nums.Count < 1)
                throw new ArgumentException();

            int highest = int.MinValue;
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] > highest)
                    highest = nums[i];
            }
            return highest;
        }

        public static int HighestWhileLoop(List<int> nums)
        {
            if (nums.Count < 1)
                throw new ArgumentException();

            int highest = int.MinValue;
            int i = 0;
            while (i < nums.Count)
            {
                if (nums[i] > highest)
                    highest = nums[i];
                i++;
            }
            return highest;
        }

        public static int HighestDoWhileLoop(List<int> nums)
        {
            if (nums.Count < 1)
                throw new ArgumentException();

            int highest = int.MinValue;
            int i = 0;
            do
            {
                if (nums[i] > highest)
                    highest = nums[i];
                i++;
            } while (i < nums.Count);
            return highest;
        }
    }
}

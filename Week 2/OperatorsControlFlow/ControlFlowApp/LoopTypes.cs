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
                highest = value > highest ? value : highest;
            return highest;
        }

        public static int LowestForEachLoop(List<int> nums)
        {
            if (nums.Count < 1)
                throw new ArgumentException();

            int lowest = int.MaxValue;
            foreach (int value in nums)
                lowest = value < lowest ? value : lowest;
            return lowest;
        }

        public static int HighestForLoop(List<int> nums)
        {
            if (nums.Count < 1)
                throw new ArgumentException();

            int highest = int.MinValue;
            for (int i = 0; i < nums.Count; i++)
            {
                highest = nums[i] > highest ? nums[i] : highest;
                i++;
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
                highest = nums[i] > highest ? nums[i] : highest;
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
                highest = nums[i] > highest ? nums[i] : highest;
                i++;
            } while (i < nums.Count);
            return highest;
        }
    }
}

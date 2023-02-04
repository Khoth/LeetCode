namespace Problems.Problem0018
{
    public class Solution
    {
        private const int _resultElementsCount = 4;

        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            if (nums.Length < _resultElementsCount)
            {
                return new List<IList<int>>(0);
            }

            var result = new List<IList<int>>();

            if (HasSameElements(nums))
            {
                var items = ResultFromSameElements(nums, target);

                if (items.Count > 0)
                {
                    result.Add(items);
                    return result;
                }
            }

            for (int a = 0; a < nums.Length; a++)
            {
                for (int b = a + 1; b < nums.Length; b++)
                {
                    for (int c = b + 1; c < nums.Length; c++)
                    {
                        for (int d = c + 1; d < nums.Length; d++)
                        {
                            if (nums[a] + nums[b] + nums[c] + nums[d] == target)
                            {
                                var items = new[] { nums[a], nums[b], nums[c], nums[d] };

                                if (HasSameElements(items))
                                {
                                    items = ResultFromSameElements(items, target).ToArray();
                                }
                                if (items.Length == 0)
                                {
                                    continue;
                                }

                                Array.Sort(items);

                                if (result.Any(x => x.SequenceEqual(items)))
                                {
                                    continue;
                                }

                                result.Add(items);
                            }
                        }
                    }
                }
            }

            return result;
        }

        private static bool IsInRange(int value) =>
            value > int.MinValue / _resultElementsCount &&
            value < int.MaxValue / _resultElementsCount;

        private static bool HasSameElements(int[] nums) =>
            nums.Distinct().Count() == 1;

        private static IList<int> ResultFromSameElements(int[] nums, int target)
        {
            if (nums[0] * _resultElementsCount == target)
            {
                if (!IsInRange(nums[0]))
                {
                    return Array.Empty<int>();
                }

                return Enumerable.Repeat(nums[0], _resultElementsCount).ToList();
            }

            return Array.Empty<int>();
        }
    }
}

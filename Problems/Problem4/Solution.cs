namespace Problem4
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length == 0 && nums2.Length == 0)
            {
                return 0;
            }

            var mergedArray = Merge(nums1, nums2);

            if (mergedArray.Length % 2 != 0)
            {
                return mergedArray[mergedArray.Length / 2];
            }
            else
            {
                return (double)(mergedArray[mergedArray.Length / 2] + mergedArray[mergedArray.Length / 2 - 1]) / 2;
            }
        }

        private int[] Merge(int[] nums1, int[] nums2)
        {
            if (nums1.Length == 0)
            {
                return nums2;
            }
            else if (nums2.Length == 0)
            {
                return nums1;
            }
            else
            {
                var result = new int[nums1.Length + nums2.Length];
                var i1 = 0;
                var i2 = 0;

                for (int i = 0; i < result.Length; i++)
                {
                    if (nums1[i1] < nums2[i2])
                    {
                        result[i] = nums1[i1];
                        i1++;

                        if (i1 == nums1.Length)
                        {
                            Copy(ref result, i + 1, nums2, i2);
                            break;
                        }
                    }
                    else
                    {
                        result[i] = nums2[i2];
                        i2++;

                        if (i2 == nums2.Length)
                        {
                            Copy(ref result, i + 1, nums1, i1);
                            break;
                        }
                    }
                }

                return result;
            }
        }

        private void Copy(ref int[] target, int targetFrom, int[] source, int sourceFrom)
        {
            for (int i = 0; i < target.Length - targetFrom; i++)
            {
                target[targetFrom + i] = source[sourceFrom + i];
            }
        }
    }
}
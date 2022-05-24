using System;

namespace Maximum_Product_Subarray
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] nums = new int[] { -2, 3, -4 };
      Solution s = new Solution();
      var result = s.MaxProduct(nums);
      Console.WriteLine(result);
    }
  }

  public class Solution
  {
    public int MaxProduct(int[] nums)
    {
      int result = nums[0];
      int imax = result;
      int imin = result;
      for (int i = 1; i < nums.Length; i++)
      {
        if (nums[i] < 0)
          (imax, imin) = Swap(imax, imin);

        if (nums[i] == 0)
        {
          imax = 0;
          imin = 0;
        }

        imax = Math.Max(nums[i], nums[i] * imax);
        imin = Math.Min(nums[i], nums[i] * imin);

        result = Math.Max(imax, result);
      }

      return result;
    }

    private (int, int) Swap(int imax, int imin)
    {
      int temp = imax;
      imax = imin;
      imin = temp;

      return (imax, imin);
    }
  }
}

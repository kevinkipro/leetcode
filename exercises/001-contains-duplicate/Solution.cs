public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> h = new HashSet<int>();
        foreach (var num in nums)
        {
            if (h.Contains(num))
            {
                return true;
            }
            h.Add(num);
        }
        return false;
    }
}

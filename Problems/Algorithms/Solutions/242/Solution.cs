public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        // Dictionary<string, int> table = new  Dictionary<string, int> ();

        // char[] newS = s.ToCharArray();
        // char[] newT = t.ToCharArray();

        // Array.Sort(newS);
        // Array.Sort(newT);

        // table.Add(new string(newS), 1);
        // return !table.TryAdd(new string(newT), 1);

        if (s.Length != t.Length) return false;
        int[] counting = new int[26];

        for (int i = 0; i < s.Length; i++)
        {
            int cs = s[i] - 'a';
            int ct = t[i] - 'a';
            counting[cs]++;
            counting[ct]--;
        }

        for (int i = 0; i < counting.Length; i++)
        {
            if (counting[i] != 0) return false;
        }

        return true;
    }
}

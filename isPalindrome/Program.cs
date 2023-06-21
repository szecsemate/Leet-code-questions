
public class Solution {
    public bool IsPalindrome(int x) {

        string converted = Convert.ToString(x);
        
        

        for(int i =0; i < converted.Length/2; i++)
        {
            int a = i +1;
            if(converted[i]!=converted[^a])
            {
                return false;
            }
        }

        return true;
        
    }

}
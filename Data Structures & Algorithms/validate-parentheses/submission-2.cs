public class Solution {
    public bool IsValid(string s) {
        Stack<char> x= new Stack<char>();
if (s.Length==0 ||s.Length==1)
{
    return false;
}
foreach (char ch in s)
{
    if (ch=='('||ch=='['||ch=='{')
    {
        x.Push(ch);
    }
    else
    {
        if (x.Count == 0)
        {
            return false;
        }
        char open = x.Pop();
        if (ch == ')' && open != '(' || ch == ']' && open != '[' || ch == '}' && open != '{') 
        {
            return false;
        }
    }
}
return  x.Count == 0;
    }
}

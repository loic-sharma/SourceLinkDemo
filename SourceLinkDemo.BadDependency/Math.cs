using System;

namespace SourceLinkDemo.BadDependency
{
    public static class Math
    {
        public static int Add(int left, int right)
        {
            if (left == 5) throw new InvalidOperationException("Oh no this is an unexpected bug");

            return left + right;
        }
    }
}

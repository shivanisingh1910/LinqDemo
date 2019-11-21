using System;
using System.Collections.Generic;
using System.Text;

namespace LINQDemo
{
    public static class MethodDemo
    {
      public static int WordCount(this string msg)//extension method using this
        {
            return msg.Split().Length;
        }
    }
}

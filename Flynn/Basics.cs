using System;
using System.Reflection;

namespace Flynn
{
    public class Basics
    {
        public void RepeatFunc(int times, string name)
        {
            int i;
            for (i = 0; i < times; i++)
            {
                Type thisType = this.GetType();
                MethodInfo theMethod = thisType.GetMethod(name);
                theMethod.Invoke(this, null);
            }
        }
    }
}
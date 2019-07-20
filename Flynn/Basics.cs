using System;
using System.Reflection;

namespace Flynn
{
    public class Basics
    {
        public void RepeatFunc(int times, string funcName)
        {
            int i;
            for (i = 0; i < times; i++)
            {
                Type thisType = this.GetType();
                MethodInfo theMethod = thisType.GetMethod(funcName);
                theMethod.Invoke(this, null);
            }
        }

        public void AlternateBool(bool boolean)
        {
            if (boolean)
            {
                boolean = false;
            } else if (!boolean)
            {
                boolean = true;
            }
        }
    }
}
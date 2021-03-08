using System;
using System.IO;
using System.Runtime.InteropServices;

namespace MagicTrick
{
    public class MagicTrick
    {
        [UnmanagedCallersOnly(EntryPoint = "gmod13_open")]
        public static int gmod13_open(IntPtr lua_state)
        {
            File.WriteAllText("./MagicTrick.txt", "IT WORKS!!!");
            return 0;
        }

        [UnmanagedCallersOnly(EntryPoint = "gmod13_close")]
        public static int gmod13_close(IntPtr lua_state)
        {
            return 0;
        }
    }
}

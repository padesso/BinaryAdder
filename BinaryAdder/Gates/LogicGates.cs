using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryAdder.Gates
{
    public static class LogicGates
    {
        public static bool AndGate(bool a, bool b)
        {
            return a & b;
        }

        public static bool XOrGate(bool a, bool b)
        {
            return a ^ b;
        }

        public static bool OrGate(bool a, bool b)
        {
            return a | b;
        }
    }
}

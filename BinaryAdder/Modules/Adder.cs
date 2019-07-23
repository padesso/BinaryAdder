using BinaryAdder.Gates;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryAdder.Modules
{
    public static class Adder
    {
        public static BitArray Add(BitArray numerator, BitArray denominator)
        {
            if (numerator.Length != denominator.Length)
                throw (new Exception("Numerator and denominator but be of equal length"));

            BitArray result = new BitArray(numerator.Length + 1); //Result can be on bit longer due to carry bit

            bool carry = false;
            for(int i = numerator.Length - 1; i >= 0; i--)
            {
                bool a = numerator[i];
                bool b = denominator[i];

                bool sum = LogicGates.XOrGate(LogicGates.XOrGate(a, b), carry);

                carry = LogicGates.OrGate(LogicGates.AndGate(LogicGates.XOrGate(a, b), carry), LogicGates.AndGate(a, b));

                result[i + 1] = sum;
                result[i] = carry;
            }

            return result;
        }
    }
}

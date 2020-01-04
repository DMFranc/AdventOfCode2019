﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Intcode.Instructions
{
    public class Halt : IInstruction
    {
        public OpCode OpCode => OpCode.Halt;

        public int Execute(List<int> memory, int pointerPosition, int input, Action<int> outputDelegate)
            => throw new NotSupportedException();
    }
}

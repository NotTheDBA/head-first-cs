﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DuckBehaviors
{
    class MuteQuack : IQuackBehavior
    {
        public void quack()
        {
            System.Console.WriteLine("<< Silence >>");
        }

    }
}

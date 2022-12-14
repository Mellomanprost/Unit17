﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateRealExample.States
{
    /// <summary>
    /// Интерфейс состояния лифта
    /// </summary>
    interface IElevatorState
    {
        void Up(Elevator elevator);
        void Down(Elevator elevator);
    }
}

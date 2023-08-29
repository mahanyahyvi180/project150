﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp112
{
    class AutoPolicy
    {
        public int AccountNumber { get; set; }
        public string MakeAndModel { get; set; }
        public string State { get; set; }

        public AutoPolicy(int accountNumber, string makeAndModel, string state)
        {
            AccountNumber = accountNumber;
            MakeAndModel = makeAndModel;
            State = state;
        }

        public bool IsNoFaultState
        {
            get
            {
                bool noFaultState;

                switch (State)
                {
                    case "MA":
                    case "NJ":
                    case "NY":
                    case "PA":
                        noFaultState = true;
                        break;
                    default:
                        noFaultState = false;
                        break;
                }
                return noFaultState;
            }
        }
    }
}

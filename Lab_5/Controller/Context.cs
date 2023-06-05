using System;
using System.Collections.Generic;
using System.Text;

namespace Controller
{
    public class Context
    {
        private IState currentState;

        public int money { get; set; }

        public Context(IState state)
        {
            SetState(state);
            money = 1500;
            currentState.SetATM(this);
        }

        public void ChangeMoney(int amount)
        {
            money -= amount;
        }
        public void SetState(IState state)
        {
            currentState = state;
            currentState.SetATM(this);
        }

        public IState GetState()
        {
            return this.currentState;
        }

        public Context GetContext()
        {
            return this;
        }
    }
}

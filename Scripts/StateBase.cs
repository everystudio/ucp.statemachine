using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace anogame
{
    public abstract class StateBase<T> where T : StateMachineBase<T>
    {
        protected T machine;
        public StateBase(T machine)
        {
            this.machine = machine;
        }

        public virtual void OnEnterState()
        {
        }
        public virtual void OnUpdateState()
        {
        }
        public virtual void OnFixedUpdateState()
        {
        }
        public virtual void OnExitState()
        {
        }
        public void ChangeState(StateBase<T> state)
        {
            machine.ChangeState(state);
        }
    }
}

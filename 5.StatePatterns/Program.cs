using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.StatePatterns
{
    class Program
    {
        public interface IContext
        {
            IState CurrentState { get; set; }
            void UpdateContext();
            void ChangeState(IState state);
        }

        public interface IState
        {
            void OnEnter(IContext context);
            void UpdateState(IContext context);
            void OnExit(IContext context);
        }

        public class GameStateContext : IContext
        {
            private IState currentstate;
            public IState CurrentState
            {
                get { return currentstate; }

                set { currentstate = value; }
            }

            public void ChangeState(IState state)
            {
                CurrentState.OnExit(this);
                CurrentState = state;
                CurrentState.OnEnter(this);
            }

            public void UpdateContext()
            {
                throw new NotImplementedException();
            }
        }
        public class GameStartState : IState
        {
            public void OnEnter(IContext context)
            {
                throw new NotImplementedException();
            }

            public void OnExit(IContext context)
            {
                throw new NotImplementedException();
            }

            public void UpdateState(IContext context)
            {
            }
        }

        public class GameRunningState : IState
        {
            public void OnEnter(IContext context)
            {
                throw new NotImplementedException();
            }

            public void OnExit(IContext context)
            {
                throw new NotImplementedException();
            }

            public void UpdateState(IContext context)
            {
                throw new NotImplementedException();
            }
        }

        public class GameExitState : IState
        {
            public void OnEnter(IContext context)
            {
                throw new NotImplementedException();
            }

            public void OnExit(IContext context)
            {
                throw new NotImplementedException();
            }

            public void UpdateState(IContext context)
            {
                throw new NotImplementedException();
            }
        }
        static void Main(string[] args)
        {
        }
    }
}

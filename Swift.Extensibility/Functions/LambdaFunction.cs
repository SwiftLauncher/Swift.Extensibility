using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace Swift.Extensibility.Functions
{
    public sealed class LambdaFunction : Function
    {
        private Action _executeAction;

        [Export]
        public Function Export
        {
            get
            {
                return this;
            }
        }

        public LambdaFunction(string displayName, string callName, Action executionDelegate, IEnumerable<string> aliases, IEnumerable<ParameterInfo> parameters)
            : base(displayName, callName)
        {
            _executeAction = executionDelegate;
        }

        public override void Execute()
        {
            if (_executeAction != null) _executeAction();
        }
    }
}

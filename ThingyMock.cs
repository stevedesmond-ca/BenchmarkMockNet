﻿using PCLMock;

namespace BenchmarkMockNet
{
    // you wouldn't normally write this by hand, but would instead use one of the code generators provided by PCLMock
    public sealed class ThingyMock : MockBase<IThingy>, IThingy
    {
        public ThingyMock(MockBehavior behavior = MockBehavior.Loose)
            : base(behavior)
        {
            if (behavior == MockBehavior.Loose) {
                ConfigureLooseBehavior();
            }
        }

        public void DoNothing() =>
            this.Apply(x => x.DoNothing());

        public void DoSomething() =>
            this.Apply(x => x.DoSomething());

        public int One() =>
            this.Apply(x => x.One());

        public int Zero() =>
            this.Apply(x => x.Zero());

        private void ConfigureLooseBehavior()
        {
            this.When(x => x.One()).Return(1);
            this.When(x => x.Zero()).Return(0);
        }
    }
}
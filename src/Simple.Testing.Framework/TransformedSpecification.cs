﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Simple.Testing.Framework
{
    public class TransformedSpecification<TGiven, TWhen, TResult> : TypedSpecification<TResult>
    {
        public Action Before;
        public Func<TGiven> On;
        public Func<TGiven, TWhen> When;
        public Func<TWhen, TResult> AndTransformedBy;
        public List<Expression<Func<TResult, bool>>> Expect = new List<Expression<Func<TResult, bool>>>();
        public Action Finally;
        public string Name;

        public Action GetBefore() { return Before; }
        public Delegate GetOn() { return On; }
        public Delegate GetWhen() { return When; }
        public IEnumerable<Expression<Func<TResult, bool>>> GetAssertions() { return Expect; }
        public Action GetFinally() { return Finally; }
        public string GetName() { return Name; }
    }
}

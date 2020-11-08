using System;
using System.Collections;
using System.Collections.Generic;


namespace _02_02
{
    public class Squad
    {
        protected virtual string Name { get; set; }
        protected virtual float Position { get; set; }
        protected virtual float Health { get; set; }
        protected Stack<object> squadstack = new Stack<object>();

        protected virtual void Move() {

        }
    }
}

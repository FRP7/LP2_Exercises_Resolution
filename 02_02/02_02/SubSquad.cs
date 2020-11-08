using System;
using System.Collections;
using System.Collections.Generic;

namespace _02_02
{
    public class SubSquad : Squad
    {
        protected override string Name { get; set; }
        protected override float Position { get; set; }
        protected override float Health { get; set; }
        protected Stack<object> subsquadstack = new Stack<object>();

        protected override void Move() {

        }
    }
}

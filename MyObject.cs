using System;
using System.Collections.Generic;
using System.Text;

namespace MyTask
{
    public abstract class MyObject
    {
        public int Id { get; set; }
        public MyObject(int id)
        {
            this.Id = id;
        }
        public abstract void Display();
        public abstract void Update();
        public abstract MyObject Generate();
    }
}

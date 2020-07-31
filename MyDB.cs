using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace MyTask
{
    public class MyDB
    {
        private List<MyObject> objects;

        public MyDB()
        {
            this.objects = new List<MyObject>();
        }
        public Request GetAll()
        {
            int[] sequence = new int[objects.Count];
            for (int i = 0; i < sequence.Length; i++)
            {
                sequence[i] = objects[i].Id;
            }
            Request request = new Request(sequence);
            return request;
        }
        public void DisplayAll()
        {
            foreach (var item in this.objects)
            {
                item.Display();
            }
        }
        public void Add(MyObject myObject)
        {
            this.objects.Add(myObject);
        }
        public void Remove(int id)
        {
            this.objects.Remove(FindObject(id));
        }
        private MyObject FindObject(int id)
        {
            return this.objects.Single(o => o.Id == id);
        }
        public void Update(int id)
        {
            FindObject(id).Update();
        }
    }
}

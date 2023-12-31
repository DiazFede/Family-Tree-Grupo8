using System;

namespace Library
{
    public abstract class Visitor
    {
        public abstract void Visit (Person persona);
        public abstract void Visit (Node<Person> node);
    }
}
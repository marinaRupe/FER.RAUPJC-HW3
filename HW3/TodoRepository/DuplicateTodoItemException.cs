using System;
using System.Runtime.Serialization;

namespace TodoRepository
{
    public class DuplicateTodoItemException : Exception
    {
        public DuplicateTodoItemException() { }

        public DuplicateTodoItemException(string message) : base(message) { }
    }
}
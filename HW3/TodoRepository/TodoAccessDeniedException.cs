using System;
using System.Runtime.Serialization;

namespace TodoRepository
{
    public class TodoAccessDeniedException : Exception
    {
        public TodoAccessDeniedException() { }

        public TodoAccessDeniedException(string message) : base(message) { }
    }
}
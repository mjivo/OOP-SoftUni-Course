﻿namespace CommandPattern.Core.Commands
{
    using Models.Contracts;
    public class HelloCommand : ICommand
    {
        public string Execute(string[] args)
        {
            return $"Hello, {args[0]}";
        }
    }
}

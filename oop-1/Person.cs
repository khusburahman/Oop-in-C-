﻿namespace oop_1;

internal class Person
{
    public string Name { get; set; }
    public Person(string name)
    {
        Name = name;
    }
    public override string ToString()
    {
        return "Hello! My name is " +Name;
    }
}

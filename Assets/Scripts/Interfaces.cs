using UnityEngine;

public interface Command
{
    string Name { get; }
    bool Test();
    bool Use();
}
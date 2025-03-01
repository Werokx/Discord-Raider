using Costura;
using System;

internal class Module
{
    static Module()
    {
        AssemblyLoader.Attach();
    }
}

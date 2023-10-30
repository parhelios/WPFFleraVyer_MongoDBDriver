using System;

namespace WPFFleraVyer.Models;

public class CounterModel
{
    private int _counter;

    public int Counter
    {
        get { return _counter; }
        set
        {
            _counter = value;
            CounterChanged.Invoke();
        }
    }

    public event Action CounterChanged;
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingObjects;

public class Vehicle : IMovable
{
    protected int _capacity;
    private int _numPassengers;

    public int NumPassengers
    {
        get { return _numPassengers; }
        set { _numPassengers = (value > _capacity || value < 0) ? throw new ArgumentOutOfRangeException() : value; }
    }

    public int Position { get; set; }
    public int Speed { get; }

    public Vehicle()
    {
        Speed = 10;
    }

    public Vehicle(int capacity, int speed = 10)
    {
        _capacity = capacity >= 0 ? capacity : throw new ArgumentOutOfRangeException();
        // _capacity = capacity; TODO
        Speed = speed;
    }

    public virtual string Move()
    {
        Position += Speed;
        return "Moving along";
    }

    public virtual string Move(int times)
    {
        if (times < 0) throw new ArgumentOutOfRangeException();
        Position += (times * Speed);
        return $"Moving along {times} times";
    }
}

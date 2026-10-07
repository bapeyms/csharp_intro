using System;
using System.Collections.Generic;
using System.Text;
namespace practice07102026;

public class Cat
{
    private string _name;
    private ushort _age;
    public Cat(string name)
    {
        this._name = name;
    }
    public void SetAge(ushort age)
    {
        this._age = age;
    }
    public override string ToString()
    {
        return $"Cat : {this._name} Age : {this._age}";
    }

}

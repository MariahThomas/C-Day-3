using System.IO;
using System;

class Class3
{
    int a;
    int b;
    
    Class3 (int _a, int _b)
    {
        a= _a;
        b= _b;
    }
    public static Class3 operator+(Class3 _obj1,Class3_obj2)
    {
        Class3 _obj3 = new Class3(0,0);
        _obj3.a = _obj1.a + _obj2.a;
        _obj3.b = _obj1.b + _obj2.b;
        return _obj3;
    }
    public static void Showvalues(Class3 _obj)
    {
        Console.WriteLine("a =" +_obj.a);
        Console.WriteLine("b =" +_obj.b);
    }
    public static void Main()
    {
        Class3 Obj1 = new Class3(1,2);
        Class3 Obj2 = new Class3(1,2);
        Class3 Obj3 = new Class3(0,0);
        Obj3 = Obj1 + Obj2;
        Class3 = Obj1 + Obj2;
        Class3.Showvalues(Obj3);
        Console.Readline();
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Lab4_Serialize_
{ 
    [Serializable]
    class Complex
{
    public int a;
    public int b;

    public Complex(int _a, int _b)
    {
        a = _a;
        b = _b;
    }
    public static int GCD(int n, int m)
    {
        while (m != n)
        {
            if (m > n)
                m = m - n;
            else
                n = n - m;
        }
        return m;
    }
    public static int LCM(int n, int m)
    {
        return m * n / GCD(m, n);
    }
    public override string ToString()
    {
        return a + "/" + b;
    }
    public static Complex operator +(Complex w1, Complex w2)
    {
        int lll = LCM(w1.b, w2.b);
        Complex w = new Complex((w1.a*w2.b + w2.a*w1.b), (w1.b * w2.b));
        w.Simplify();
        return w;
    }
    public static Complex operator -(Complex w1, Complex w2)
    {
        int lll = LCM(w1.b, w2.b);

        Complex w = new Complex(w1.a * w2.b - w2.a * w1.b, lll);
        w.Simplify();
        return w;
    }
    public static Complex operator *(Complex w1, Complex w2)
    {

        Complex w = new Complex(w1.a * w2.a, w1.b * w2.b);
        w.Simplify();
        return w;
    }
    public static Complex operator /(Complex w1, Complex w2)
    {//                          5*2              1*6      6     2  

        Complex w = new Complex(w1.a * w2.b, w1.b * w2.a);
        w.Simplify();
        return w;
    }

    public void Simplify()
    {
        int _a = this.a;
        int _b = this.b;
        while (_a > 0 && _b > 0)
        {
            if (_a > _b)
                _a = _a % _b;
            else
                _b = _b % _a;
        }
        int nod = _a + _b;
        a /= nod;
        b /= nod;
    }
}
}

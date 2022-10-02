using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2
{
    class Fraction {
        public int num;
        public int den;
        public Fraction()
        {
            den = 1;
            Console.WriteLine("A new object");
        }
        public Fraction(int num, int den = 1)
        {
            this.num = num;
            this.den = den;
        }
        public override string ToString()
        {

            return simplify(num, den) + " ";
        }

        public string simplify(int num1, int num2) {
            string res = "";
            for(int i = Math.Max(num1, num2); i > 1; i--) {
                if(num1% i == 0 && num2 % i == 0) {
                    num1 /= i; 
                    num2 /= i;
                } 
            }
            if(num2 == 1) {
                res = num1 + "";
            }else {
                res = num1 + "/" + num2;
            }
            return res;
        }
        //F(x), Sum(a, b) 
        // a+b = 
        // a>b = 
        public static Fraction operator +(Fraction a, Fraction b)
        {
            Fraction c = new Fraction();
            c.num = a.num * b.den + b.num * a.den;
            c.den = a.den * b.den;
            return c;
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            Fraction c = new Fraction();
            c.num = a.num * b.den - b.num * a.den;
            c.den = a.den * b.den;
            return c;
        }
        public static Fraction operator /(Fraction a, Fraction b) {
            Fraction c = new Fraction();
            c.num = a.num * b.den;
            c.den = b.num * a.den;
            return c;
        }
        public static Fraction operator *(Fraction a, Fraction b) {
            Fraction c = new Fraction(); 
            c.num = a.num * b.num; 
            c.den = a.den * b.den;
            return c;
        } 
        public static bool operator >(Fraction a, Fraction b)
        {
            return a.num * b.den > b.num * a.den;
        }
        public static bool operator <(Fraction a, Fraction b)
        {
            return a.num * b.den < b.num * a.den;
        }
        public static bool operator >=(Fraction a, Fraction b) {
            return a.num * b.den >= b.num * a.den; 
        }
        public static bool operator <=(Fraction a, Fraction b) {
            return a.num * b.den <= b.num * a.den;
        }
        public static bool operator ==(Fraction a, Fraction b) {
            return a.num * b.den == b.num * a.den;
        } 
        public static bool operator !=(Fraction a, Fraction b) {
            return a.num * b.den != b.num * a.den;
        }

    }
}
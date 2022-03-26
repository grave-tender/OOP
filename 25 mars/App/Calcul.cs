using System;

namespace App
{
    class Calcul
    {
        public int Sum(byte a, byte b){
            return a + b;
        }
        public int Sum(int a, int b){
            return a + b;
        }
        public double Sum(double a, double b){
            return a + b;
        }
        public float Sum(float a, float b){ 
            return a + b;
        }
        public int Minus(byte a, byte b){ return a - b; }
        public int Minus(int a, int b){ return a - b; }
        public double Minus(double a, double b){ return a - b; }
        public float Minus(float a, float b){ return a - b; }
        public int Multiply(int a, int b){ return a * b; }
        public double Divide(int a, int b){ if(b==0) return 0; return a / b; }
        public double Divide(byte a, byte b){ if(b==0) return 0; return a / b; }
        public double Divide(double a, double b){ if(b==0) return 0; return a / b; }
        public double Divide(float a, float b){ if(b==0) return 0; return a / b; }
    }
}

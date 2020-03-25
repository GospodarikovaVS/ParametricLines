using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyParamLibrary
{
    public class Painting
    {
        //public Graphics g;
        public int I1, I2, J1, J2;     // границы рисунка в экранных координатах
        private double X1, X2, Y1, Y2;  // границы рисунка в бумажных координатах
        public double wx, wy, wx0, wy0, r0, r1;

        public Painting(int width, int height)
        {
            I1 = 10;
            I2 = width - 50;
            J1 = 30;
            J2 = height - 50;
            X1 = Y1 = -5;
            X2 = Y2 = 5;
        }

        public int JJ(double y)
        {
            return J2 - (int)((y - Y1) * (J2 - J1) / (Y2 - Y1));
        }

        public int II(double x)
        {
            return I1 + (int)((x - X1) * (I2 - I1) / (X2 - X1));
        }

        public double XX(int i)
        {
            return X1 + (i - I1) * (X2 - X1) / (I2 - I1);
        }

        public void ColorAct(int v, ref int c1, ref int c2, ref int c3)
        {
            switch (v)
            {
                case 15:
                    {
                        c1 = 0;
                        c2 = 0;
                        c3 = 0;
                        break;
                    };
                case 17:
                    {
                        c1 = 255;
                        c2 = 0;
                        c3 = 0;
                        break;
                    }; 
                case 16:
                    {
                        c1 = 0;
                        c2 = 0;
                        c3 = 255;
                        break;
                    };
                default: break;
            }
        }

        public void ColorBckgr(int v, ref int c1, ref int c2, ref int c3)
        {
            switch (v)
            {
                case 18:
                    {
                        c1 = 255;
                        c2 = 255;
                        c3 = 255;
                        break;
                    };
                case 19:
                    {
                        c1 = 173;
                        c2 = 216;
                        c3 = 230;
                        break;
                    };
                case 20:
                    {
                        c1 = 255;
                        c2 = 255;
                        c3 = 224;
                        break;
                    };
                default: break;
            }
        }

        public double FX(double t, int v)
        {
            switch (v)
            {
                case 1:
                    return r0 * Math.Cos(wx * t + wx0);  // Фигуры Лиссажу
                case 2:
                    return (r0 + r1 * t) * Math.Cos(wx * t + wx0) / 20;  // Спираль Архимеда
                case 3:
                    return r0 * Math.Exp(r1 * t) * Math.Cos(wx * t + wx0) / 50;  // Спираль Бернулли
                case 4:
                    return (r0 + r1 * Math.Sqrt(t)) * Math.Cos(wx * t + wx0); // Параболическая спираль
                case 5:
                    return r0 * (t - Math.Sin(wx * t + wx0)); // Циклоида
                case 6:
                    return (r0 * Math.Cos(t) + r1) * Math.Cos(wx * t + wx0);  // Улитка Паскаля
                case 7:
                    double tmp = Math.Cos(t);
                    tmp = tmp >= 0 && tmp < 1e-5 ? tmp = 1e-5 : tmp;
                    tmp = tmp < 0 && tmp > -1e-5 ? tmp = -1e-5 : tmp;
                    return (r0 * tmp - r1 / tmp) * Math.Cos(wx * t + wx0); // Трисектрисса
                case 8:
                    return r0 * Math.Sin(wx * t + wx0) * Math.Cos(t);
                case 9:

                case 10:
                    return (1 + Math.Cos(wx * t + wx0) + Math.Sin(wx * t + wx0) * Math.Sin(wx * t + wx0)) * Math.Cos(t) * r0;
                default:
                    return 0;
            }
        }

        public double FY(double t, int v)
        {
            switch (v)
            {
                case 1:
                    return r1 * Math.Sin(wy * t + wy0);   // Фигуры Лиссажу
                case 2:
                    return (r0 + r1 * t) * Math.Sin(wy * t + wy0) / 20;  // Спираль Архимеда
                case 3:
                    return r0 * Math.Exp(r1 * t) * Math.Sin(wy * t + wy0) / 50;   // Спираль Бернулли
                case 4:
                    return (r0 + r1 * Math.Sqrt(t)) * Math.Sin(wy * t + wy0);  // Параболическая спираль
                case 5:
                    return r0 * (1 - Math.Cos(wy * t + wy0));   // Циклоида
                case 6:
                    return (r0 * Math.Cos(t) + r1) * Math.Sin(wy * t + wy0);  // Улитка Паскаля
                case 7:
                    double tmp = Math.Cos(t);
                    tmp = tmp >= 0 && tmp < 1e-5 ? tmp = 1e-5 : tmp;
                    tmp = tmp < 0 && tmp > -1e-5 ? tmp = -1e-5 : tmp;
                    return (r0 * tmp - r1 / tmp) * Math.Sin(wy * t + wy0);      // Трисектрисса
                case 8:
                    return r0 * Math.Sin(wy * t + wy0) * Math.Sin(t);
                case 9:

                case 10:
                    return r0 * (1 + Math.Cos(wy * t + wy0) + Math.Sin(wy * t + wy0) * Math.Sin(wy * t + wy0)) * Math.Sin(t);
                default:
                    return 0;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    public interface Shape
    {
        double GetArea();
        bool IsLegal();
        string GetType();
        string GetPara();
    }
    class IllegalParameter : Exception
    {
        public IllegalParameter(string message) : base(message)
        {

        }
    }
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height{ get; set; }
        public Rectangle(double width,double height)
        {
                this.Width = width;
                this.Height = height;
            if (!IsLegal())
                throw new IllegalParameter("参数非法");
        }
        public bool IsLegal()
        {
            return (this.Width > 0 && this.Height > 0) ? true : false;
        }
        public double GetArea()
        {
            return IsLegal() ? (this.Width * this.Height) : -1;
        }
        public string GetType()
        {
            return "长方形";
        }
        public string GetPara()
        {
            return this.Height.ToString() + "  "+this.Width.ToString();
        }
    }
    class Square : Shape
    {
        public double Side { get; set; }
        public Square(double side)
        {
                this.Side = side;
            if (!IsLegal())
                throw new IllegalParameter("参数非法");
        }
        public bool IsLegal()
        {
            return (this.Side>0) ? true : false;
        }
        public double GetArea()
        {
            return IsLegal() ? (this.Side*this.Side) : -1;
        }
        public string GetType()
        {
            return "正方形";
        }
        public string GetPara()
        {
            return this.Side.ToString();
        }
    }
    class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public Triangle(double a, double b, double c)
        {
                this.SideA = a;
                this.SideB = b;
                this.SideC = c;
            if(!IsLegal())
                throw new IllegalParameter("参数非法");
        }
        public Triangle() { }
        public bool IsLegal()
        {
            if (this.SideA > 0 && this.SideB > 0 && this.SideC > 0)
                return (this.SideA + this.SideB > this.SideC && this.SideA + this.SideC > this.SideB && this.SideB + this.SideC > this.SideA) ? true : false;
            return false;
        }
        public double GetArea()
        {
            if (IsLegal())
            {
                double p = (this.SideA + this.SideB + this.SideC) / 2;
                return Math.Sqrt(p * (p - this.SideA) * (p - this.SideB) * (p - this.SideC));
            }
            return -1;
        }
        public string GetType()
        {
            return "三角形";
        }
        public string GetPara()
        {
            return this.SideA.ToString() + "  " + this.SideB.ToString() + "  " + this.SideC.ToString();
        }
    }
    class Circle : Shape
    {
        const double PI = 3.1415926;
        public double Radius { get; set; }
        public Circle(double r)
        {
            this.Radius = r;
            if (!IsLegal())
                throw new IllegalParameter("参数非法");
        }
        public bool IsLegal()
        {
            return (this.Radius > 0) ? true : false;
        }
        public double GetArea()
        {
            if (IsLegal())
                return Math.Pow(this.Radius, 2.0) * PI;
            return -1;
        }
        public string GetType()
        {
            return "圆形";
        }
        public string GetPara()
        {
            return this.Radius.ToString();
        }
    }
    class ShapeFactory
    {
        public Shape CreatShape(int type,double[] value)
        {
            Shape newShape = new Triangle();
            switch (type)
            {
                case 1:newShape = new Rectangle(value[0], value[1]);
                    break;
                case 2:newShape = new Square(value[0]);
                    break;
                case 3:newShape = new Triangle(value[0], value[1], value[2]);
                    break;
                case 4:newShape = new Circle(value[0]);
                    break;
                default:
                    break;
            }
            return newShape;
        }
    }
    class Program
    {
        public static void GenerateRandomParameters(int i,out double[] Para, Random rnd)
        {
            Triangle triangle = new Triangle();
            int j;
            switch (i)
            {
                case 1:
                    Para = new double[2];
                    for(j=0;j<=1;j++)
                    {
                        Para[j] = rnd.NextDouble() * rnd.Next(1, 1000);
                    }
                    break;
                case 2:
                    Para = new double[2];
                    Para[0]= rnd.NextDouble() * rnd.Next(1, 1000);
                    break;
                case 3:
                    Para = new double[3];
                    while (!triangle.IsLegal())
                    {
                        for (j = 0; j <= 2; j++)
                            Para[j] = rnd.NextDouble() * rnd.Next(1, 1000);
                        triangle.SideA = Para[0];
                        triangle.SideB = Para[1];
                        triangle.SideC = Para[2];
                    }
                    break;
                case 4:
                    Para = new double[1];
                    Para[0] = rnd.NextDouble() * rnd.Next(1, 1000);
                    break;
                default:
                    Para = null;
                    break;
            }
        }
        public static void Input(string s,ShapeFactory MyFactory,Random rnd,out double SingleArea)
        {
            SingleArea = new double();
            double[] Para=null;
            int r = rnd.Next(1, 5);
            GenerateRandomParameters(r,out Para,rnd);
            Shape Myshape = MyFactory.CreatShape(r,Para);
            Console.WriteLine($"随机生成了{Myshape.GetType()},参数为：{Myshape.GetPara()},其面积为{Myshape.GetArea()}");
            SingleArea += Myshape.GetArea();
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            while (true)
            {
                ShapeFactory MyFactory=new ShapeFactory();
                Console.WriteLine("----------随机生成常见几何图形并求面积----------");
                Console.WriteLine("-------------请输入随机图形生成数量-------------");
                string s=Console.ReadLine();
                int Num = 0;
                if (int.TryParse(s, out Num))
                    Num = int.Parse(s);
                else
                {
                    Console.WriteLine("输入有误，按任意键重新输入");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                double Sum=0;
                double SingleArea = 0;
                for (int i=1;i<=Num;i++)
                { Input(s, MyFactory,rnd,out SingleArea);
                    Sum += SingleArea;
                }
                Console.WriteLine($"-----------面积和为{Sum}------------");
                Console.WriteLine("-----------------按任意键继续------------------");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}

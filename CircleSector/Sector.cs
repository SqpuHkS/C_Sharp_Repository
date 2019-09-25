using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleSector
{
    public class Sector
    {
        private double m_angle;
        public double angle
        {
            get { return m_angle; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Angle must => 0");
                else
                    m_angle = value;
            }
        }

        private double m_r;
        public double r
        {
            get { return m_r; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Radius must > 0");
                else m_r = value;
            }
        }

        private void Init(double angle, double r)
        {
            m_angle = angle;
            m_r = r;
        }

        public Sector()
        {
            Init(0.0, 1.0);
        }

        public Sector(double angle, double r)
        {
            Init(angle, r);
        }

        public Sector(Sector circle)
        {
            Init(circle.m_angle, circle.m_r);
        }

        public bool IsSectorsEquals(Sector sector)
        {
            double tempThis = SectorArea();
            double tempThat = sector.SectorArea();
            if (tempThis == tempThat)
                return true;
            else
                return false;
        }

        public double SectorArea()
        {
            return (Math.PI * Math.Pow(m_r, 2) * (m_angle / 360));
        }

        public double RainbowLength()
        {
            return ((Math.PI * m_r * m_angle) / 180);
        }

        public void Input()
        {
            double m_angle = Convert.ToDouble(Console.ReadLine());
            double m_r = Convert.ToDouble(Console.ReadLine());

            Init(m_angle, m_r);
        }

        public void Print()
        {
            Console.WriteLine("Angle = " + m_angle + "\n" + "r = " + r + "\n");
        }



        static void Main(string[] args)
        {
            Sector sector1 = new Sector();
            Sector sector2 = new Sector(35.0, 3.2);
            Console.WriteLine("Insert Sector 1 parameters " + "\n");
            sector1.Input();
            Console.WriteLine("Sector1 parameters are \n");
            sector1.Print();
            Console.WriteLine("Sector2 parameters are \n");
            sector2.Print();
            Console.WriteLine("Sector1 rainbow length is " + sector1.RainbowLength() + "\n");
            Console.WriteLine("Sector2 rainbow length is " + sector2.RainbowLength() + "\n");
            Console.WriteLine("Sector1 area is " + sector1.SectorArea() + "\n");
            Console.WriteLine("Sector2 area is " + sector2.SectorArea() + "\n");
            Console.WriteLine("Is Sector1 and Sector2 Equals " + sector1.IsSectorsEquals(sector2) + "\n");
            Console.ReadKey();


        }
    }
}

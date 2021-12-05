using System;
using System.Drawing;

namespace exercice_calcule
{
    class Point
    {
        private double x, y;

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public Point(double x = 0, double y = 0)
        {
            this.x = x;
            this.y = y;
        }
        public void Afficher()
        {
            Console.WriteLine("POINT({0},{1})", x, y);
        }
        public double Distance(Point origine)
        {
            double x0 = origine.x, y0 = origine.y;
            return Math.Sqrt(((x - x0) * (x - x0)) + ((y - y0) * (y - y0))); // Racine( (x-x0)² + (y-y0)² )

        }
    }

    class Cercle
    {
        private Point centre;
        private double rayon;

        public double Rayon
        {
            get { return rayon; }
            set { rayon = value; }
        }

        public Point Centre
        {
            get { return centre; }
            set { centre = value; }
        }

        public Cercle(Point centre, double rayon = 0)
        {
            this.centre = centre;
            this.rayon = rayon;
        }

        public Cercle()
        {
            centre = new Point();
            centre.X = 0;
            centre.Y = 0;
            rayon = 0;
        }

        public double getPerimetre()
        {
            return 2 * Math.PI * rayon;
        }
        public double getSurface()
        {
            return Math.PI * rayon * rayon;
        }
        public bool appartient(Point Pt)
        {
            if (Pt.Distance(centre) <= rayon)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Afficher()
        {
            Console.WriteLine("CERCLE( ({0},{1}) , {2} )", centre.X, centre.Y, rayon);
        }

        public double CircleArea()
        {
            return Math.PI * (rayon * rayon);
        }
    }


    class Program
    {
        
        static void Main(string[] args)
        {
            Cercle C = new Cercle();
            //--------------------------------------------------------------------
            Action<string> msg = s => Console.Write(s);
            //--------------------------------------------------------------------
            msg("Caractéristiques d'un cercle\n\n");
            msg("Entrez les coordonnées (x,y) du point centre du cercle:\n");
            msg("\tx = "); C.Centre.X = double.Parse(Console.ReadLine());
            msg("\ty = "); C.Centre.Y = double.Parse(Console.ReadLine());
            msg("Entrez le rayon (R) du cercle:\n");
            msg("\tR = "); C.Rayon = double.Parse(Console.ReadLine());
            //---------------------------------------------------------------------
            msg("\nExpression représentative du cercle:\n\t");
            C.Afficher();
            //---------------------------------------------------------------------
            msg("\nPérimètre (P) du cercle:\n\t");
            msg("P = " + C.getPerimetre().ToString(".##"));
            //---------------------------------------------------------------------
            msg("\n\nSurface du (S) cercle:\n\t");
            msg("S = " + C.getSurface().ToString(".##"));
            //---------------------------------------------------------------------
            msg("\n\nVérifier si un point (M) de coordonnées (a,b) appartient au cercle:\n");
            Point M = new Point();
            msg("\ta = "); M.X = double.Parse(Console.ReadLine());
            msg("\tb = "); M.Y = double.Parse(Console.ReadLine());
            if (C.appartient(M))
            {
                msg("\nLe point (M) APPARTIENT au cercle.");
            }
            else
            {
                msg("\nLe point (M) N'appartient PAS au cercle.");
            }
            //---------------------------------------------------------------------   
            Console.ReadKey();

            // circonference

           

            Console.WriteLine("l'aire d'un cercle de " + C.Rayon + " cm est " + C.CircleArea + "cm2");
        }
    }

}

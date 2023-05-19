using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Nyelvvizsga
{
    internal class Nyelvvizsga
    {

        string nyelv;
        int ev2009;
        int ev2010;
        int ev2011;
        int ev2012;
        int ev2013;
        int ev2014;
        int ev2015;
        int ev2016;
        int ev2017;
        int ev2018;
        int nepszeruseg;

        public Nyelvvizsga(string CSVsor)
        {
            var mezok = CSVsor.Split(';');
            nyelv = mezok[0];
            ev2009 = int.Parse(mezok[1]);
            ev2010 = int.Parse(mezok[2]);
            ev2011 = int.Parse(mezok[3]);
            ev2012 = int.Parse(mezok[4]);
            ev2013 = int.Parse(mezok[5]);
            ev2014 = int.Parse(mezok[6]);
            ev2015 = int.Parse(mezok[7]);
            ev2016 = int.Parse(mezok[8]);
            ev2017 = int.Parse(mezok[9]);
            ev2018 = int.Parse(mezok[10]);
            nepszeruseg = ev2009 + ev2010 + ev2011 + ev2012 + ev2013 + ev2014 + ev2015 + ev2016 + ev2017 + ev2018;
        }

        public Nyelvvizsga(string nyelv, int ev2009, int ev2010, int ev2011, int ev2012, int ev2013, int ev2014, int ev2015, int ev2016, int ev2017, int ev2018, int nepszeruseg)
        {
            this.nyelv = nyelv;
            this.ev2009 = ev2009;
            this.ev2010 = ev2010;
            this.ev2011 = ev2011;
            this.ev2012 = ev2012;
            this.ev2013 = ev2013;
            this.ev2014 = ev2014;
            this.ev2015 = ev2015;
            this.ev2016 = ev2016;
            this.ev2017 = ev2017;
            this.ev2018 = ev2018;
            this.nepszeruseg = nepszeruseg;
        }

        public string Nyelv { get => nyelv; set => nyelv = value; }
        public int Ev2009 { get => ev2009; set => ev2009 = value; }
        public int Ev2010 { get => ev2010; set => ev2010 = value; }
        public int Ev2011 { get => ev2011; set => ev2011 = value; }
        public int Ev2012 { get => ev2012; set => ev2012 = value; }
        public int Ev2013 { get => ev2013; set => ev2013 = value; }
        public int Ev2014 { get => ev2014; set => ev2014 = value; }
        public int Ev2015 { get => ev2015; set => ev2015 = value; }
        public int Ev2016 { get => ev2016; set => ev2016 = value; }
        public int Ev2017 { get => ev2017; set => ev2017 = value; }
        public int Ev2018 { get => ev2018; set => ev2018 = value; }
        public int Nepszeruseg { get => nepszeruseg; set => nepszeruseg = value; }
    }
}

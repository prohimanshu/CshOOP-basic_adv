using System;

namespace Composition.com.Module
{
    class Univercity
    {
        public Art Ar { get; set; }
        public Computer Comp { get; set; }

        public void IniArt(string name, int Nostu, string director)
        {
            this.Ar = new Art();
            Ar.Director = director;
            Ar.Name = name;
            Ar.NoStudent = Nostu;
        }
        public void IniComp(string name, int Nolab, string director)
        {
            this.Comp = new Computer();
            Comp.Director = director;
            Comp.Name = name;
            Comp.NoLab = Nolab;
        }
    }
}

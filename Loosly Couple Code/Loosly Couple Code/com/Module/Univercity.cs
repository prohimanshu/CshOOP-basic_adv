using System;
using System.Collections.Generic;

namespace Loosly_Couple_Code.com.Module
{
    enum Dep{
        art,
        comp
    }
    class Univercity
    {
        public List<Department> department { get; set; } = new List<Department>();

        public void AddDepartment(string Name,string Director,Dep dep,int no)
        {
            if (dep == Dep.art)
            {
                Art art = new Art();
                art.Name = Name;
                art.Director = Director;
                art.NoStudent = no;
                department.Add(art);
            }
            else if(dep==Dep.comp)
            {
                Computer comp = new Computer();
                comp.Name = Name;
                comp.Director = Director;
                comp.NoLab = no;
                department.Add(comp);
            }
        }

    }
}

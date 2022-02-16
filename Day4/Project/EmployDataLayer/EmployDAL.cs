using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmployEntity;
using System.Threading.Tasks;

namespace EmployDataLayer
{
    public class EmployDAL
    {
        static List<Employ> employlist;
        static EmployDAL()
        {
            employlist = new List<Employ>();    
        }
        public string DeleteEmployDAL(int empno)
        {
           Employ employFound = SearchEmployDAL(empno);
            if(employFound != null)
            {
                employlist.Remove(employFound);
                return "Employ Record Deleted...";
            }
            return "Employ Record Not Found...";
        }
        public Employ SearchEmployDAL(int empno)
        {
            foreach (Employ employ in employlist)
            {
                if(employ.Empno == empno)
                {
                    return employ;
                }
                //return null;
            }
            return null;    
        }
        public string AddEmployDAL(Employ employ)
        {
            // Employ employ = new Employ();   
            employlist.Add(employ);
            return "Employ Record Added...";
        }
        public List<Employ> ShowEmployDAL()
        {
            return employlist;
        }
        public string UpdateEmployDAL(Employ employ)
        {
         //   Employ employlist = new Employ();
         int empno = employ.Empno;  
            int index= -1;
            foreach(Employ e in employlist)
            {
                if (e.Empno == empno)
                {
                    index++;
                    break;
                }
                else
                {
                    index++;
                }
            }
            if(index!= -1)
            employlist[index] = employ;
            return "Employ Updated...";
        }
    }
}

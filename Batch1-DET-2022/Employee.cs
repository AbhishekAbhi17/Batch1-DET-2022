using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Employee
    {
        int rollno;
        string name;
        string address;
        int pincode;
        int phonenum;
        int grosssal;
        int pf;


        public Employee(int rollno,string name,string address,int pincode,int phonenum,int grosssal,int pf)
        {
            this.rollno = rollno;
            this.name = name;
            this.address = address;
            this.pincode = pincode;
            this.phonenum = phonenum;
            this.grosssal = grosssal;
            this.pf = pf;
        }
        public int GetNetSalary()
        {
            return (grosssal - pf);

        }
        public string GetGrade()
        {
            float net = GetNetSalary();
            if(net > 10000)
            {
                return "A";
            }
            else if (net > 5000 && net < 10000)
            {
                return "B";
            }
            else
            {
                return "C";
            }
        }
    }
}

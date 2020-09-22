using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Person
    {
        public int age;
        public DateTime birthDate;
        public string name;
        public IdInfo idInfo;

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person clone = (Person)this.MemberwiseClone();
            clone.age = this.age;
            clone.birthDate = this.birthDate;
            clone.name = string.Copy(this.name);
            clone.idInfo = new IdInfo(this.idInfo.idNumber);
            return clone;
        }
    }
}

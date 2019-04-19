using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
[Serializable]
public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Movie Movie{ get; set; }

        public Person()
        {

        }
    public Person(string name, int age, Movie movie)
    {

    }
}

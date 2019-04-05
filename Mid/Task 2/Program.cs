using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie firstMovie = new Movie("Emoji movie", 2017);
            Movie secondMovie = new Movie("50 shades of gray", 2015);
            Movie thirdMovie = new Movie("Shrek", 1999);
            Movie fourthMovie = new Movie("NinjaCop", 1987);

            Person akbar = new Person("Akbar", 29, secondMovie);
            Person ramesh = new Person("Ramesh", 20, firstMovie);
            Person durga = new Person("Durga", 43, fourthMovie);
            Person daler = new Person("Daler", 38, thirdMovie);
            
            List<Person> array = new List<Person>() { akbar, ramesh, durga, daler };

            FileStream fs = new FileStream("People.xml", FileMode.Create, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(array.GetType());

            xs.Serialize(fs, array);
            fs.Close();
            Des(array);

        }
        static void Des(List<Person> array)
        {
            FileStream fs = new FileStream("People.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(array.GetType());
            List<Person> arraysave = xs.Deserialize(fs) as List<Person>;

            fs.Close();
        }
    }

}



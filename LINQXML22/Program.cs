using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQXML22
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQXML22
            /*
             Даны XML-документ и строка S. В строке записано
имя одного из некорневых элементов исходного документа. Удалить
из документа все элементы с именем S.
            */
            Console.WriteLine("LINQXML22");

            XDocument LINQXML22 = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),

                new XElement("Woods",

                    new XElement("Sosna", new XAttribute("Kolvo", 1),
                        new XElement("Name", "Sosna Alpiyskaya"),
                        new XElement("Location", "Alpi"),
                        new XElement("MaxHeight", 100)),

                    new XElement("Dub", new XAttribute("Kolvo", 5),
                        new XElement("Name", "Dub Pichundsy"),
                        new XElement("Location", "Pichunda"),
                        new XElement("MaxHeight", 120)),

                    new XElement("Olha", new XAttribute("Kolvo", 142),
                        new XElement("Name", "Olha Permskay"),
                        new XElement("Location", "Perm"),
                        new XElement("MaxHeight", 2)),

                    new XElement("Olha", new XAttribute("Kolvo", 127),
                        new XElement("Name", "Olha Pishnaya"),
                        new XElement("Location", "Moscow"),
                        new XElement("MaxHeight", 50)),

                    new XElement("Kedr", new XAttribute("Kolvo", 6),
                        new XElement("Name", "Kedr Berezovskogo"),
                        new XElement("Location", "Berezino"),
                        new XElement("MaxHeight", 28)),

                    new XElement("Lipa", new XAttribute("Kolvo", 318),
                        new XElement("Name", "Lipa Tut"),
                        new XElement("Location", "Tuta"),
                        new XElement("MaxHeight", 10))));

            Console.WriteLine(LINQXML22);

            Console.WriteLine("Введите строку - имя некорневого элемента исходного файла");
            string s1=Console.ReadLine();
            /*foreach (var e in LINQXML22.Root.Elements(s1))
            {
                e.Remove();
            }
            */
            LINQXML22.Root.Elements(s1).Remove();

            Console.WriteLine(LINQXML22);
        }
    }
}

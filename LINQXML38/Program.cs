using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQXML38
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Дан XML-документ. Для каждого элемента, кроме
корня, изменить его имя, добавив к нему слева исходные имена всех
его предков, разделенные символом «-» (дефис). Например, если
корневой элемент имеет имя root, то элемент bb второго уровня,
родительский элемент которого имеет имя aa, должен получить имя
root-aa-bb.
Указание. Перебирая все элементы последовательности Descen dants корневого элемента, использовать их свойства Parent
и Name.
             * */
            Console.WriteLine("LINQXML38");

            XDocument LINQXML38 = new XDocument(
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

            Console.WriteLine(LINQXML38);

            foreach (var e in LINQXML38.Root.Descendants())
                e.Name = $"{e.Parent.Name}-{e.Name}";

            Console.WriteLine(LINQXML38);
        }
    }
}

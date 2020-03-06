using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQXML
{
    class LINQXML6
    {
        static void Main(string[] args)
        {
            //LINQXML6
            /*
             * Даны имена существующего текстового файла и создаваемого XML-документа. Каждая строка текстового файла содержит
несколько (одно или более) целых чисел, разделенных ровно одним
пробелом. Создать XML-документ с корневым элементом root, элементами первого уровня line и элементами второго уровня number.
Элементы line соответствуют строкам исходного файла и не содержат дочерних текстовых узлов, элементы number каждого элемента
line содержат по одному числу из соответствующей строки (числа
располагаются в порядке убывания). Элемент line должен содержать
атрибут sum, равный сумме всех чисел из соответствующей строки
             */
            Console.WriteLine("LINQXML6");
            List<Chisla> list = new List<Chisla>();
            list = File.ReadAllLines("LINQXML6.txt").Select(line1 => new Chisla(line1)).ToList();

            XDocument d = new XDocument
                (
            new XDeclaration(null, "windows-1251", null),
            new XElement("root", 
            list.Select(s => new XElement("line", (new XAttribute("sum", s.Chislo.Sum())),
            new XElement("number", s.Chislo.Select(e => e + " "))))));
            //new XElement("number", string.Join(" ", s.Chislo).Split(' ').OrderBy(g => g).Select(g => g + " "))))));

            Console.WriteLine(d);
        }
    }
}

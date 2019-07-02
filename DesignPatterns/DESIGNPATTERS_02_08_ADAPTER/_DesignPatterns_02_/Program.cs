using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _DesignPatterns_02_
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            cliente.Nome = "Victor";
            cliente.Endereco = "Rua Vergueiro";
            cliente.DataDeNascimento = DateTime.Now;

            XmlSerializer serializer = new XmlSerializer(cliente.GetType());
            StringWriter writer = new StringWriter();
            serializer.Serialize(writer, cliente);
            String xml = writer.ToString();


            String xml1 = new GeradorDeXml().GeraXml(cliente);
            Console.WriteLine(xml);

            Console.ReadKey();
        }

        
    }
}

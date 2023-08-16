using DesignPatterns.PatternsComportamental.TemplateMethod.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DesignPatterns.PatternsComportamental.TemplateMethod
{
    public class ObtemDadosAPI
    {
        public static string EndPointXML()
        {
            List<Pessoa> pessoas = GetPessoas();
            XmlSerializer serializer = new XmlSerializer(pessoas.GetType());
            string xml = string.Empty;

            using (var sw = new StringWriter())
            {
                serializer.Serialize(sw, pessoas);
                xml = sw.ToString();
            }
            return xml;
        }

        public static string EndPointJSON()
        {
            List<Pessoa> pessoas = GetPessoas();

            var json = JsonConvert.SerializeObject(pessoas, Formatting.Indented);

            return json;
        }

        private static List<Pessoa> GetPessoas()
        {
            return new List<Pessoa> {
                new Pessoa {
                    Nome = "José",
                    CPF = "123.123.123-44",
                    Acoes = new List<Acoes>() {
                        new Acoes("MGLU3", 50, 15.00),
                        new Acoes("BDS3", 100, 30.00),
                    } 
                },
                new Pessoa {
                    Nome = "Daiani",
                    CPF = "345.123.123-44",
                    Acoes = new List<Acoes>() {
                        new Acoes("MXLF11", 50, 15.00),
                        new Acoes("BCFF11", 100, 30.00),
                    } 
                }, 
            };
        }
    }
}

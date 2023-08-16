using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.TemplateMethod
{
    public class ClientTemplateMethod
    {
        public void ConsumirEndPointXML()
        {
            Console.WriteLine($"\n______________XML_______________\n");

            var xml = ObtemDadosAPI.EndPointXML();
            ConverteXML converteXML = new ConverteXML(xml);
            converteXML.ProcessarXML();
        }

        public void ConsumirEndPointJSON()
        {
            Console.WriteLine($"\n______________JSON_______________\n");

            var json = ObtemDadosAPI.EndPointJSON();
            ConverteJSON converteJSON = new ConverteJSON(json);
            converteJSON.ProcessarJSON();
        }
    }
}

﻿using DesignPatterns.PatternsComportamental.TemplateMethod.AbstractModel;
using DesignPatterns.PatternsComportamental.TemplateMethod.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsComportamental.TemplateMethod
{
    public class ConverteJSON : ProcessaDados
    {
        public ConverteJSON(string json) : base(json:json)
        {
            
        }

        public override void ProcessarJSON()
        {
            this.pessoas = JsonConvert.DeserializeObject<List<Pessoa>>(this.json);
            this.ApresentarValores();
        }


    }
}

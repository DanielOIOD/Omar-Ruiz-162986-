﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json.Linq;

namespace PracticaDos
{
    class Memoria
    {
        public void GuardadMemoria()
        {
            string ArchivoDB = "../../../db.json";
            StreamReader reader = new StreamReader(ArchivoDB);
            var dbJSON = reader.ReadToEnd();
            var dbObject = JObject.Parse(dbJSON);
            //Prueba de lectura de archivo db
            //var result = dbObject.ToString();
            //var result = dbObject["arreglo"].ToString();
            //var result = dbObject["arreglo"][0].ToString();
           
            //lectuea de json iterable
            foreach((var item, var key) in dbObject)
            {
                Console.WriteLine("dato en memoria:");
                MemoriaData memoriaData = new MemoriaData(DateTime.Now, item ["operation"].ToString(), (int)item ["resultado"];
                Console.WriteLine(item.ToString());
            }
        }
    }

    class MemoriaData
    {
        public DateTime fecha;
        public String operacion;
        public int resultado;

        public MemoriaData( DateTime fecha, String operation, int resultado) //la clase la llamaos a una clase y alli le decimos que tipo de datos se utilizaran
        {
            fecha = fecha;
            operacion = operacion;
            resultado = resultado;
        }
    }
}

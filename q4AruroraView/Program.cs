using System;
using System.Collections.Generic;

namespace q4AruroraView
{
    class Program
    {
        public Dictionary<string, string> oldDictionary = new Dictionary<string, string>();
        public Dictionary<string, string> newDictionary = new Dictionary<string, string>();
        public string valueForAll = null;
         static void Main(string[] args)
        {
            Program prog = new Program();
            prog.oldDictionary.Add("red","2");
            prog.oldDictionary.Add("green", "7");
            prog.oldDictionary.Add("yellow", "6");
            string green= prog.getByKey("green");
            string yellow = prog.getByKey("yellow");
            Console.WriteLine("green={0} yellow= {1}", green, yellow);
            prog.setAll("30");
            green = prog.getByKey("green");
            yellow = prog.getByKey("yellow");
            string red = prog.getByKey("red");
            Console.WriteLine("green={0} yellow= {1},red= {2}", green, yellow, red);
            prog.setByKey("red", "40");
            Console.WriteLine("red={0}", prog.getByKey("red"));







        }
         string getByKey(string byKey) 
        {
            if (oldDictionary.ContainsKey(byKey))
            {
                if (newDictionary.ContainsKey(byKey))
                {
                    Console.WriteLine(" your Value {0} to the key {1}", newDictionary[byKey], byKey);
                    return newDictionary[byKey];
                }
                if (valueForAll != null)
                {
                    return valueForAll;
                }
                Console.WriteLine(" your Value {0} to the key {1}", oldDictionary[byKey], byKey);
                return oldDictionary[byKey];
            }
            Console.WriteLine(" your key doesn't");
            return null;
        }
         void setByKey(string byKey, string byValue)
        {
            if (newDictionary.ContainsKey(byKey))
            { newDictionary[byKey] = byValue; }
            else 
            {
                if (valueForAll == null) 
                {
                    oldDictionary[byKey]= byValue;
                }
                else
                {
                    if (oldDictionary.ContainsKey(byKey))
                    {
                        newDictionary.Add(byKey, byValue);
                    }
                    else 
                    {
                        oldDictionary.Add(byKey, byValue);
                        newDictionary.Add(byKey, byValue);
                    }


                }
            }
        }
          void setAll(string byValue)
        {
            newDictionary.Clear();
            valueForAll = byValue;
        }
    }
}

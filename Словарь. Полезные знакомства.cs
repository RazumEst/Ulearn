using System;
using System.Collections.Generic;

namespace Словарь._Полезные_знакомства
{
    internal class Program
    {
        private static Dictionary<string, List<string>> OptimizeContacts(List<string> contacts)
        {
            var dictionary = new Dictionary<string, List<string>>();
            string[] splittedContacts = new string[contacts.Count];//кол-во элементов в contacts

            for(int i = 0; i < contacts.Count; i++)
            {
                splittedContacts[i] = contacts[i].Split(':')[0];
                if(splittedContacts[i].Length >= 2) splittedContacts[i] = splittedContacts[i].Substring(0,2);
                if (splittedContacts[i].Length == 0) splittedContacts[i] = ":";

                if(!dictionary.ContainsKey(splittedContacts[i])) dictionary[splittedContacts[i]] = new List<string>();

                if (splittedContacts[i].Length >= 2) dictionary[splittedContacts[i]].Add(contacts[i]);
                else if (splittedContacts[i].Length == 1) dictionary[splittedContacts[i]].Add(contacts[i]);
                else if (splittedContacts[i].Length == 0) dictionary[splittedContacts[i]].Add(contacts[i]);
            }

            return dictionary;
        }
        static void Main(string[] args)
        {
            {
                var contacts = new List<string>();

                contacts.Add("Sasha:sasha@gmail.com");
                contacts.Add("Sancho:sancho@mail.ru");
                contacts.Add("Roma:roma@gmail.com");
                contacts.Add("Gusein:gusein@mail.com");
                contacts.Add("G:gusein@mail.com");
                contacts.Add(":");
                contacts.Add("");
                contacts.Add("Gusein:");
                contacts.Add("Gu:gusein@mail.com");
                contacts.Add("G:gusein@mail.com");
                contacts.Add("Roma:4567@gmail.com");
                contacts.Add("Sasha:sa@gm.com");
                contacts.Add(":gusein@mail.com");
                contacts.Add("Roma:");
                contacts.Add($"{null}:sa@gm.com:priz@rty.com");
                contacts.Add($"{null}:{null}");
                contacts.Add($"Sasha:{null}");
                contacts.Add(":gusein@mail.com");
                contacts.Add("Roma:");

                OptimizeContacts(contacts);
            }
        }
    }
}
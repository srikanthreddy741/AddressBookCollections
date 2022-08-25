﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProblems
{
    class FileWriter
    {
        public static string path = @"C:\Users\VANDANA\Desktop\RFP\AddressBook\AddressBook\AddressBook\AddressBook.txt";
        public static void WriteUsingStreamWriter(List<ContactPerson> data)
        {

            if (File.Exists(path))
            {
                File.WriteAllText(path, String.Empty);
                using (StreamWriter streamWriter = File.AppendText(path))
                {
                    streamWriter.WriteLine("FirstName\tLastName\t Address\t City\t State\t Zip\t Contact\t Email");
                    foreach (ContactPerson contacts in data)
                    {
                        streamWriter.WriteLine(contacts.firstName + "\t" + contacts.lastName + "\t" + contacts.address + "\t" + contacts.city + "\t" + contacts.state + "\t" + contacts.zip + "\t" + contacts.contact + "\t" + contacts.email);
                    }
                    streamWriter.Close();
                }
            }
            else
            {
                Console.WriteLine("File not avilable..");
            }
        }

        public static void readFile()
        {
            if (File.Exists(path))
            {
                using (StreamReader streamReader = File.OpenText(path))
                {
                    string data = "";
                    while ((data = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(data);
                    }
                }
            }
            else
            {
                Console.WriteLine("File not avilable..");
            }
        }
    }
}
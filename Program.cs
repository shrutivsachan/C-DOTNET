using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices.Marshalling;

namespace Practice
{
    internal class Program
    {
        public static void Main(String[] args)
        {
        Console.WriteLine("Hello, C#!");

                    //// 1 byte is made up of 8 bits 00000000 - these bits can be used to store a number as follows
            // //// Each bit can be worth 0 or 1 of the value it is placed in
            // ////// From the right we start with a value of 1 and double for each digit to the left
            // //// 00000000 = 0
            // //// 00000001 = 1
            // //// 00000010 = 2
            // //// 00000011 = 3
            // //// 00000100 = 4
            // //// 00000101 = 5
            // //// 00000110 = 6
            // //// 00000111 = 7
            // //// 00001000 = 8
 
            // // 1 byte (8 bit) unsigned, where signed means it can be negative
            // byte myByte = 255;
            // byte mySecondByte = 0;
 
            // // 1 byte (8 bit) signed, where signed means it can be negative
            // sbyte mySbyte = 127;
            // sbyte mySecondSbyte = -128;
 
 
            // // 2 byte (16 bit) unsigned, where signed means it can be negative
            // ushort myUshort = 65535;
 
            // // 2 byte (16 bit) signed, where signed means it can be negative
            // short myShort = -32768;
 
            // // 4 byte (32 bit) signed, where signed means it can be negative
            // int myInt = 2147483647;
            // int mySecondInt = -2147483648;
 
            // // 8 byte (64 bit) signed, where signed means it can be negative
            // long myLong = -9223372036854775808;
 
 
            // // 4 byte (32 bit) floating point number
            // float myFloat = 0.751f;
            // float mySecondFloat = 0.75f;
 
            // // 8 byte (64 bit) floating point number
            // double myDouble = 0.751;
            // double mySecondDouble = 0.75d;
 
            // // 16 byte (128 bit) floating point number
            // decimal myDecimal = 0.751m;
            // decimal mySecondDecimal = 0.75m;
 
            // Console.WriteLine(myFloat - mySecondFloat);
            // Console.WriteLine(myDouble - mySecondDouble);
            // Console.WriteLine(myDecimal - mySecondDecimal);
 
 
 
            // string myString = "Hello World";
            // // Console.WriteLine(myString);
            // string myStringWithSymbols = "!@#$@^$%%^&(&%^*__)+%^@##$!@%123589071340698ughedfaoig137";
            // // Console.WriteLine(myStringWithSymbols);
 
            // bool myBool = true;

            // Data Structures -- One dimesnionsnal Array
                string[] mygroceryarray = new string[2];
                mygroceryarray[0] = "Bread";
                mygroceryarray[1] = "Jam";

                Console.WriteLine(mygroceryarray[0]);
                Console.WriteLine(mygroceryarray[1]);
                //unhandled exception error wil be thrown here. because arrays are put of bound.
                //Console.WriteLine(mygroceryarray[2]);

                string[] mygroceryarray1 = ["Cheese", "Egg"];
                Console.WriteLine(mygroceryarray1[0]);
                Console.WriteLine(mygroceryarray1[1]);

             // List

                List<string> mygrocerylist = new List<string>(){"Chicken","Kheema"};

                Console.WriteLine(mygrocerylist[0]);
                Console.WriteLine(mygrocerylist[1]);

                mygrocerylist.Add("Mutton");
                Console.WriteLine(mygrocerylist[2]);

            // Enum

                IEnumerable<string> mygroceryenum = mygrocerylist;
                Console.WriteLine(mygroceryenum.First());

            
            // Multi Dimensional Array
                string[,] mytwodimensionalarray = new string[,]{
                    {"Cheese", "Egg"},
                    {"Chicken","Kheema"}
                };

                Console.WriteLine(mytwodimensionalarray[0,0]);

            // Dictionary it stores the data in key value pair. It can contain array
            
                // Dictionary<string,string> mygrocerydictionary = new Dictionary<string, string>(){
                //     {"Key", "Value"}    
                // };  

                 Dictionary<string,string[]> mygrocerydictionary = new Dictionary<string, string[]>(){
                    {"Key", new string[]{"Value","Value1","Value2"}}    
                };
                
                Console.WriteLine(mygrocerydictionary["Key"][2]); 

        }
    }
}



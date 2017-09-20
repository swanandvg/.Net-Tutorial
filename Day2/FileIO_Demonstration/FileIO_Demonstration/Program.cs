﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileIO_Demonstration
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Write to File
            //FileStream fs = new FileStream(@"C:\.Net Training\Info.txt", FileMode.Create, FileAccess.Write);
            //StreamWriter wr = new StreamWriter(fs);
            //try
            //{
            //    wr.WriteLine(DateTime.Now.ToLongTimeString());
            //    wr.WriteLine("Hello and Welcome");
            //    wr.WriteLine("Today is Tuesday");
            //    wr.WriteLine("Its a sunny day");
            //}
            //catch (IOException ie)
            //{
            //    Console.Write(ie.Message);
            //}
            //catch (Exception e)
            //{

            //    Console.Write(e.Message);
            //}
            //finally
            //{
            //    wr.Close();
            //    fs.Close();
            //}
            #endregion

            #region Read a File  
            //FileStream fs = new FileStream(@"C:\.Net Training\Info.txt", FileMode.Open, FileAccess.Read);
            //StreamReader rd = new StreamReader(fs);

            //try
            //{
            //    //Console.WriteLine(rd.ReadLine());
            //    //Console.WriteLine(rd.ReadLine());
            //    //Console.WriteLine(rd.ReadLine());

            //    Console.WriteLine(rd.ReadToEnd());
            //}
            //catch(IOException ie)
            //{
            //    Console.WriteLine(ie.Message);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //rd.Close();
            //fs.Close();
            #endregion

            #region Autogenerated account number
            //Accounts acc = new Accounts();
            //Console.WriteLine("Account Created");
            //Console.WriteLine("Account Number is "+acc.AccountNumber);
            #endregion

            #region Binary Serialization
            //Accounts accObj = new Accounts()
            //{
            //    AccountName = "Vijay Dinanath Chauhan",
            //    AccountType = "Savings",
            //    AccountBalance = 4000
            //};

            //FileStream myFile = new FileStream(accObj.AccountNumber+".txt", FileMode.Create, FileAccess.Write);

            //BinaryFormatter bf = new BinaryFormatter();
            //bf.Serialize(myFile, accObj);
            //Console.WriteLine("Object Saved to to File system");
            #endregion

            #region Binary Deserialization
            //FileStream fs = new FileStream("104.txt", FileMode.Open, FileAccess.Read);
            //BinaryFormatter bf = new BinaryFormatter();
            //Accounts acc = (Accounts)bf.Deserialize(fs);
            //Console.WriteLine(acc.AccountBalance);
            //Console.WriteLine(acc.AccountName);
            //Console.WriteLine(acc.AccountNumber);
            //Console.WriteLine(acc.AccountType);
            #endregion

            #region XML Serailization
            //Accounts accObj = new Accounts();
            //Console.WriteLine("Please enter name: ");
            //accObj.AccountName = Console.ReadLine();
            //Console.WriteLine("PleaseEnter Initial Balance: ");
            //accObj.AccountBalance = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Please Enter Account Type: ");
            //accObj.AccountType = Console.ReadLine();

            //FileStream myFile = new FileStream(accObj.AccountNumber + ".xml", FileMode.Create, FileAccess.Write);
            ////We need to put typeof(Object) here
            //XmlSerializer xs= new XmlSerializer(typeof(Accounts));
            //xs.Serialize(myFile, accObj);
            #endregion

            #region XML Deserialization
            //Console.WriteLine("Enter Accont Number: ");
            //int accNo = Convert.ToInt32(Console.ReadLine());
            //try
            //{
            //    FileStream fs = new FileStream(accNo + ".xml", FileMode.Open, FileAccess.Read);
            //    XmlSerializer xs = new XmlSerializer(typeof(Accounts));
            //    Accounts accObj = (Accounts)xs.Deserialize(fs);
            //    Console.WriteLine("Account Number: "+accObj.AccountNumber);
            //    Console.WriteLine("Account Name: "+accObj.AccountName);
            //    Console.WriteLine("Account Type: "+accObj.AccountType);
            //    Console.WriteLine("Account Balance: "+accObj.AccountBalance);
            //}
            //catch (FileNotFoundException)
            //{
            //    Console.WriteLine("Account with account number "+accNo+" not found");
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine("Exception occurs: "+e.Message);
            //}
            #endregion

            #region SOAP Serailization
            //Accounts accObj = new Accounts();
            //Console.WriteLine("Please enter name: ");
            //accObj.AccountName = Console.ReadLine();
            //Console.WriteLine("PleaseEnter Initial Balance: ");
            //accObj.AccountBalance = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Please Enter Account Type: ");
            //accObj.AccountType = Console.ReadLine();

            //FileStream myFile = new FileStream(@".\soap\"+accObj.AccountNumber + ".xml", FileMode.Create, FileAccess.Write);
            ////We need to put typeof(Object) here
            //SoapFormatter sf = new SoapFormatter();
            //sf.Serialize(myFile, accObj);
            #endregion

            #region SOAP Deserialization
            //Console.WriteLine("Enter Accont Number: ");
            //int accNo = Convert.ToInt32(Console.ReadLine());
            //try
            //{
            //    FileStream fs = new FileStream(@".\soap\"+accNo + ".xml", FileMode.Open, FileAccess.Read);
            //    SoapFormatter sf = new SoapFormatter();
            //    Accounts accObj = (Accounts)sf.Deserialize(fs);
            //    fs.Close();
            //    Console.WriteLine("Account balance is "+accObj.AccountBalance);
            //    Console.WriteLine("MENU\n1.Widraw\n2.Deposit");
            //    Console.WriteLine("Enter your choice: ");
            //    int ch = Convert.ToInt32(Console.ReadLine());
            //    double amt;
            //    switch(ch)
            //    {
            //        case 1:
            //            Console.WriteLine("Write amount to widraw");
            //            amt = Convert.ToDouble(Console.ReadLine());
            //            accObj.Widraw1(amt);
            //            break;
            //        case 2:
            //            Console.WriteLine("Write amount to deposit");
            //            amt = Convert.ToDouble(Console.ReadLine());
            //            accObj.Deposit1(amt);
            //            break;
            //        default:
            //            Console.WriteLine("Wrong Choice");
            //            break;
            //    }
            //    if (ch == 1 || ch == 2)
            //    {
            //        FileStream myFile = new FileStream(@".\soap\" + accObj.AccountNumber + ".xml", FileMode.Create, FileAccess.Write);
            //        sf.Serialize(myFile, accObj);
            //    }

            //}
            //catch (FileNotFoundException)
            //{
            //    Console.WriteLine("Account with account number " + accNo + " not found");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Exception occurs: " + e.Message);
            //}
            #endregion

            #region Nikhil's Code (SOAP Serialization and Deserialization)
            Console.WriteLine("Please Enter Account Number");
            int accNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Choice");
            Console.WriteLine("1. Widraw");
            Console.WriteLine("2. Deposit");

            int choice = Convert.ToInt32(Console.ReadLine());
            Accounts acc = new Accounts();
            acc.AccountNumber = accNo;

            Console.WriteLine("Please Enter Amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (choice == 1)
                {
                    acc.Widraw(amount, accNo);
                }
                else if (choice == 2)
                {
                    acc.Deposit(amount, accNo);
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            }
            catch (Exception es)
            {
                Console.WriteLine(es.Message);

            }
            #endregion
        }
    }
}

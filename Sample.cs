using NPOI.XSSF.UserModel;
using System;
using System.Collections;
public abstract class Accounts
{
    public abstract void createPwd();
    public abstract void newmethod();
    public void fun()
    {
        Console.WriteLine("This is normal");
    }

}

interface Cars
{
    public void brake();
    public void color();
}
interface Bikes
{
    const int x= 10;
    public void brand();
}


public class Sample
{ 
    public static void Main(string[] args)
    {
       string data =  File.ReadAllText("F:/SeleniumC#/ObsquraTrainingC#/session.txt");
        Console.WriteLine(data);
        File.Delete("F:/SeleniumC#/ObsquraTrainingC#/session1.txt");

        Console.WriteLine(File.Exists("F:/SeleniumC#/ObsquraTrainingC#/session1.txt"));
    }
    }



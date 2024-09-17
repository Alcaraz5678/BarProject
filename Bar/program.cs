using System;
using BarProject.Bar.src.models;
using BarProject.Bar.src.controllers;
class Program
{
    static void Main()
    {
        BarManager barManager = new();
        Console.WriteLine("tenia un monton de cosas extrañas");
        Console.WriteLine(barManager.ViewSummaryWaiter());
        
    }
}
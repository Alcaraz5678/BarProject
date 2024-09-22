using System;
using BarProject.Bar.src.models;

namespace BarProject.Bar.src.controllers
{
    public class BarManager
    {
        public models.Bar bar = new();

        public BarManager()
        {
            //Constructor por defecto
        }

        public void ViewSummaryWaiter()
        {
            bar.ViewSummaryWaiter();
        
        }

        public void ViewSummaryTable()
        {
            bar.ViewSummaryTables(); // Call the method from Bar class
        }

        public void AddAdmin()
        {
            //Implementar
        }

        public void AddWaiter()
        {
            //Implementar
        }

        public void GenerateOrder()
        {
            //Implementar
        }

        public void PayOrder()
        {
            //Implementar
        }
    }
}
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

        public int ViewSummaryWaiter()
        {
            return bar.ViewSummaryWaiter(09);
        
        }

        public void ViewSummaryTable()
        {
            bar.ViewSummaryTables(0); // Call the method from Bar class
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
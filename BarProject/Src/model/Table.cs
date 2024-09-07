using System;

namespace BarProject.Src
{
    public class Table
    {
        public int idTable { get; set; }
        public List<Order> orders { get; set; }
        public double totalTable { get; set; }


        public Table
        {
            orders = new List<Order> ()
        }

        public void ResetTable
        {
            //Implementar
        } 
        

        public void ViewSummary
        {
            //Implementar
        }

        public void CalculateTotalTable
        {
            //Implementar
        }
    }
}    
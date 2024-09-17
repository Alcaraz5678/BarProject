using System;
using System.Collections.Generic;

namespace BarProject.Bar.src.models
{
    public class Bar
    {
        public string NameBar { get; set; }
        public List<Table> Tables { get; set; }
        public List<Admin> Admins { get; set; }
        public List<Waiter> Waiters { get; set; }
        public Inventory Inventory { get; set; }

        public Bar()
        {
            Tables = new List<Table>();
            Admins = new List<Admin>();
            Waiters = new List<Waiter>();
        }

        public int ViewSummaryWaiter(int IdWaiter)
        {
            return 0;
        }
        
          public void ViewSummaryTables(int IdTable)
        {
            //Implementar
        }  

    }


}
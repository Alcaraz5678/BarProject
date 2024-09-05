using System;

namespace BarProject.Src
{
    public class Bar
    {
        public string nameBar { get; set; }
        public List<Table> tables { get; set; }
        public List<Admin> admins { get; set; }
        public List<Waiter> waiters { get; set; }
        public Inventory inventory { get; set; }

        public Bar()
        {
            tables = new List<Table>();
            admins = new List<Admin>();
            waiters = new List<Waiter>();
        }

        public void ViewSummaryWaiter(Waiter waiter)
        {
            //Implementar
        }
          public void ViewSummaryTables(Table table)
        {
            //Implementar
        }  

    }


}
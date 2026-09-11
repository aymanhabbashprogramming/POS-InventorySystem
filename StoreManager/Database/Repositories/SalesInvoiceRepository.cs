using System.Collections.Generic;
using System.Linq;

namespace StoreManager.Database.Repositories
{
    internal class SalesInvoiceRepository
    {
        private StoreManagerDBEntities StoreManagerDB = new StoreManagerDBEntities();

        public List<SalesBillTabel> GetAllBills()
        {
            return StoreManagerDB.SalesBillTabels.ToList();
        }

        public SalesBillTabel GetBillById(int id)
        {
            return StoreManagerDB.SalesBillTabels.FirstOrDefault(x => x.Id == id);
        }

        public void DeleteBillDetails(int billId)
        {
            var details = StoreManagerDB.SalesBillDetailsTabels
                            .Where(d => d.SalesBill_ID == billId)
                            .ToList();

            foreach (var detail in details)
                StoreManagerDB.SalesBillDetailsTabels.Remove(detail);
        }

        public void DeleteBill(SalesBillTabel bill)
        {
            StoreManagerDB.SalesBillTabels.Remove(bill);
            StoreManagerDB.SaveChanges();
        }
    }
}
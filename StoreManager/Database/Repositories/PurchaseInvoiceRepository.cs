using System.Collections.Generic;
using System.Linq;

namespace StoreManager.Database.Repositories
{
    internal class PurchaseInvoiceRepository
    {
        private StoreManagerDBEntities StoreManagerDB = new StoreManagerDBEntities();

        public List<PurchaseBillTabel> GetAllBills()
        {
            return StoreManagerDB.PurchaseBillTabels.ToList();
        }

        public PurchaseBillTabel GetBillById(int id)
        {
            return StoreManagerDB.PurchaseBillTabels.FirstOrDefault(x => x.Id == id);
        }

        public void DeleteBillDetails(int billId)
        {
            var details = StoreManagerDB.PurchaseBillDetailsTabels
                            .Where(d => d.PurchaseBill_ID == billId)
                            .ToList();

            foreach (var detail in details)
                StoreManagerDB.PurchaseBillDetailsTabels.Remove(detail);
        }

        public void DeleteBill(PurchaseBillTabel bill)
        {
            StoreManagerDB.PurchaseBillTabels.Remove(bill);
            StoreManagerDB.SaveChanges();
        }
    }
}
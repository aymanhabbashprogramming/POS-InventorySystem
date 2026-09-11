using StoreManager.Database;

namespace StoreManager.Classes.BusinessLogic
{
    internal class SalesInvoiceService
    {
        private StoreManager.Database.Repositories.SalesInvoiceRepository _Repository;

        public SalesInvoiceService()
        {
            _Repository = new StoreManager.Database.Repositories.SalesInvoiceRepository();
        }

        public System.Collections.Generic.List<SalesBillTabel> GetAllBills()
        {
            return _Repository.GetAllBills();
        }

        public SalesBillTabel GetBillById(int id)
        {
            return _Repository.GetBillById(id);
        }

        public void DeleteBill(int billId)
        {
            var bill = _Repository.GetBillById(billId);
            if (bill != null)
            {
                _Repository.DeleteBillDetails(billId);
                _Repository.DeleteBill(bill);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _BusinessLayer
{

        public enum database_PreliminaryAccounting
        {
            CurrentCards,
            Stocks,
            Bills,
            Banks
        }
        public class Creater
        {
            public db_operation FactoryMethod(database_PreliminaryAccounting i_PreliminaryAccounting)
            {
                db_operation _db_operation = null;
                switch (i_PreliminaryAccounting)
                {
                        case database_PreliminaryAccounting.CurrentCards:
                            _db_operation = new CurrentCardsBusiness();
                        break;
                        case database_PreliminaryAccounting.Stocks:
                           _db_operation = new StockBusiness();
                        break;
                        case database_PreliminaryAccounting.Bills:
                            _db_operation = new BillBusiness();
                        break;
                        case database_PreliminaryAccounting.Banks:
                            _db_operation = new BankBusiness();
                        break;
                }
                return _db_operation;

            }
        }
}


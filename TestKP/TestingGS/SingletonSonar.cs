using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KPSonar
{
    public sealed class SingletonSonar
    {
        private static readonly SingletonSonar instance = new SingletonSonar();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static SingletonSonar()
        {
        }

        private SingletonSonar()
        {
        }

        public static SingletonSonar Instance
        {
            get
            {
                return instance;
            }
        }

        public string OrderSelectQuery(bool bValue, string strDate, int nCustomerID)
        {
            string strQuery;
            strQuery =
                "SELECT order_txn.id, "
            + "       customer.firstname, "
            + "       customer.phone_no, "
            + "       product.NAME, "
            + "       product.details, "
            + "       category.type, "
            + "       order_txn.quantity, "
            + "       order_txn.price, "
            + "       order_txn.cgst, "
            + "       order_txn.sgst, "
            + "       order_txn.total_price, "
            + "       order_txn.modifiedon "
            + "FROM   order_txn "
            + "       JOIN customer "
            + "         ON ( customer.id = order_txn.customer_id ) "
            + "       JOIN product "
            + "         ON ( product.id = order_txn.product_id ) "
            + "       JOIN category "
            + "         ON ( product.category_id = category.id ) "
            + "WHERE  1 = 1 "
            + "       AND customer_id = {0} "
            ;
            string strNewQuery = String.Format(strQuery, nCustomerID);

            if (bValue == true)
            {
                string strDateQuery = "       AND order_txn.modifiedon = '{0}' ";
                string strNewDateQuery = String.Format(strDateQuery, strDate);

                strNewQuery = strNewQuery + strNewDateQuery;
            }

            return strNewQuery;
        }
        public string CustomerInsertQuery(string strFName, string strMName, string strLName,
                                    string strAddress, string strPhone)
        {
            string strQuery;
            strQuery =
                "INSERT INTO customer "
                + "            (firstname, "
                + "             middlename, "
                + "             lastname, "
                + "             address, "
                + "             phone_no) "
                + "VALUES('{0}', "
                + "            '{1}', "
                + "            '{2}', "
                + "            '{3}', "
                + "            '{4}') "
                ;
            string strNewQuery = String.Format(strQuery, strFName, strMName, strLName,
                                    strAddress, strPhone);
            return strNewQuery;
        }
        public string CustomerUpdateQuery(string strFName, string strMName, string strLName,
                                    string strAddress, string strPhone,int nID)
        {
            string strQuery;
            strQuery =
                "UPDATE customer "
                + "SET firstname = '{0}', "
                + "       middlename = '{1}', "
                + "       lastname = '{2}', "
                + "       address = '{3}', "
                + "       phone_no = '{4}' "
                + "WHERE id = {5} "
            ;
            string strNewQuery = String.Format(strQuery, strFName, strMName, strLName,
                                    strAddress, strPhone, nID);
            return strNewQuery;
        }
        public string CustomerDeleteQuery(int nID)
        {
            string strQuery;
            strQuery =
                "DELETE FROM customer  "
                + "            WHERE  id = {0}  "
                ;
                ;
            string strNewQuery = String.Format(strQuery, nID);
            return strNewQuery;
        }
        public string OrderInvoiceSelectQuery(int nInvoiceID)
        {
            string strQuery;
            strQuery = 
                "SELECT invoices.id, "
                + "       invoice_date_created, "
                + "       invoice_date_modified, "
                + "       paid_price_1, "
                + "       paid_price_2, "
                + "       payment_method, "
                + "       (SELECT Sum(total_price) "
                + "        FROM order_txn "
                + "        WHERE order_txn.invoice_id = invoices.id) total_amount, "
                + "       (SELECT Sum(total_price) "
                + "        FROM   order_txn "
                + "        WHERE  order_txn.invoice_id = invoices.id) "
                + "       - ( paid_price_1 + paid_price_2 ) Balance "
                + "FROM   invoices "
                + "WHERE  1 = 1  "
                + "       AND invoices.id = {0}  "
                ;
            string strNewQuery = String.Format(strQuery, nInvoiceID);
            return strNewQuery;
        }
        public string InvoiceSelectQuery(bool bValue, string strDate, int nCustomerID)
        {
            string strQuery;
            strQuery =
                "SELECT invoices.id, "
                + "       invoice_date_created, "
                + "       invoice_date_modified, "
                + "       paid_price_1, "
                + "       paid_price_2, "
                + "       payment_method, "
                + "       (SELECT Sum(total_price) "
                + "        FROM   order_txn "
                + "        WHERE  order_txn.invoice_id = invoices.id) total_amount, "
                + "       (SELECT Sum(total_price) "
                + "        FROM   order_txn "
                + "        WHERE  order_txn.invoice_id = invoices.id) "
                + "       - ( paid_price_1 + paid_price_2 ) Balance "
                + "FROM   invoices "
                + "       JOIN customer "
                + "         ON ( customer.id = invoices.customer_id ) "
                + "WHERE  1 = 1 "
                + "       AND customer.id = {0} "
            ;
            string strNewQuery = String.Format(strQuery, nCustomerID);

            if (bValue == true)
            {
                string strDateQuery = "       AND invoices.invoice_date_modified = '{0}' ";
                string strNewDateQuery = String.Format(strDateQuery, strDate);

                strNewQuery = strNewQuery + strNewDateQuery;
            }

            return strNewQuery;
        }
        public string InvoiceUpdateQuery(string strPayment1, string strPayment2, int nID)
        {
            string strQuery;
            strQuery =
                    "UPDATE invoices "
                    + "SET paid_price_1='{0}', "
                    + "    paid_price_2='{1}' "
                    + "WHERE id={2} "
                    ;
            string strNewQuery = String.Format(strQuery, strPayment1, strPayment2, nID);
            return strNewQuery;
        }
    }
}

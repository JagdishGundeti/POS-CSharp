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

        public string SettingSelectQuery(bool bValue, string strDate)
        {
            string strQuery;
            strQuery =
                "SELECT daily_rates_ex.id,  "
                + "       type,  "
                + "       value,  "
                + "       daily_rates_ex.modifiedon  "
                + "FROM   daily_rates_ex  "
                + "       JOIN category  "
                + "         ON ( daily_rates_ex.category_id = category.id )  "
                + "WHERE  1 = 1  "
                ;

            string strNewQuery = strQuery;

            if (bValue == true)
            {
                string strDateQuery = "       AND daily_rates_ex.modifiedon = '{0}' ";
                string strNewDateQuery = String.Format(strDateQuery, strDate);

                strNewQuery = strNewQuery + strNewDateQuery;
            }

            return strNewQuery;
        }
        
        public string SettingGetValueQuery(int nCategoryId)
        {

            string strQuery;
            strQuery =
		        "SELECT value  "
		        +"FROM   daily_rates_ex  "
		        +"       JOIN category  "
		        +"         ON ( daily_rates_ex.category_id = category.id )  "
		        +"WHERE  1 = 1  "
		        +"       AND daily_rates_ex.modifiedon = '{0}'  "
		        +"       AND category.id = {1}  "
		        ;
            string strNewQuery = String.Format(strQuery, DateTime.Now.ToString("yyyy-MM-dd"), nCategoryId);
            return strNewQuery;
        }
        public string SettingInsertQuery(int nCategoryId, string strValue)
        {

            string strQuery;
            strQuery =
		    "INSERT INTO daily_rates_ex  "
		    +"            (category_id,  "
		    +"             value,  "
		    +"             modifiedon)  "
		    +"VALUES     ({0},  "
		    +"            {1},  "
		    +"            '{2}')  "
		    ;

            string strNewQuery = String.Format(strQuery, nCategoryId, strValue, DateTime.Now.ToString("yyyy-MM-dd"));
            return strNewQuery;
        }



        public string SettingUpdateQuery(int nID, string strValue)
        {

            string strQuery;
            strQuery =
                "UPDATE daily_rates_ex  "
                +"SET    value = '{0}',  "
                +"       modifiedon = '{1}'  "
                +"WHERE  id = {2}  "
                ;

            string strNewQuery = String.Format(strQuery, strValue, DateTime.Now.ToString("yyyy-MM-dd"),nID);
            return strNewQuery;
        }
        
        public string SettingUpdateQueryWithDate(int nCategoryId, string strValue)
        {

            string strQuery;
            strQuery =
		        "UPDATE daily_rates_ex  "
		        +"SET    value = '{0}'  "
		        +"WHERE  category_id = {1}  "
		        +"       AND daily_rates_ex.modifiedon = '{2}'  "
		        ;

            string strNewQuery = String.Format(strQuery, strValue, nCategoryId, DateTime.Now.ToString("yyyy-MM-dd"));
            return strNewQuery;
        }
        public string OrderSelectQuery(bool bValue, string strDate, int nCustomerID)
        {
            string strQuery;
            strQuery =
                "SELECT order_txn.id, "
            + "       customer.firstname, "
            //+ "       customer.phone_no, "
            + "       product.NAME, "
            //+ "       product.details, "
            + "       category.type, "
            + "       order_txn.quantity, "
            + "       order_txn.price, "
            + "       order_txn.cgst, "
            + "       order_txn.sgst, "
            + "       employee.firstname as ename, "
            + "       order_txn.total_price, "
            + "       order_txn.modifiedon "
            + "FROM   order_txn "
            + "       JOIN customer "
            + "         ON ( customer.id = order_txn.customer_id ) "
            + "       JOIN product "
            + "         ON ( product.id = order_txn.product_id ) "
            + "       JOIN category "
            + "         ON ( category.id = product.category_id ) "
            + "       JOIN employee "
            + "         ON ( employee.id = order_txn.employee_id ) "
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
            strNewQuery = strNewQuery + "ORDER BY order_txn.modifiedon DESC";

            return strNewQuery;
        }

        public string OrderDistinctInvoiceSelectQuery(int m_nCustomerID, string strDate)
        {
            string strQuery;
            strQuery =
                "SELECT DISTINCT invoice_id  "
                + "FROM   order_txn  "
                + "WHERE  1 = 1  "
                + "       AND customer_id = {0}  "
               ;
            string strNewQuery = String.Format(strQuery, m_nCustomerID);

            //if (bValue == true)
            {
                string strDateQuery = "       AND order_txn.modifiedon = '{0}'  ";
                string strNewDateQuery = String.Format(strDateQuery, strDate);
                strNewQuery = strNewQuery + strNewDateQuery;
            }
            return strNewQuery;
        }

        public string OrderInvoiceColCountSelectQuery()
        {
            string strQuery;
            strQuery =
                "SELECT COUNT(*) COL  "
                + "FROM invoices  "
            ;
            return strQuery;
        }


        public string OrderInvoiceColCountSelectQuery(int nInvoiceID)
        {
            string strQuery;
            strQuery =
                "SELECT COUNT(*) COL  "
                + "FROM invoices  "
                + "WHERE 1 = 1 "
                + "  AND id = {0} "
                ;

            string strNewQuery = String.Format(strQuery, nInvoiceID);
            return strNewQuery;
        }

        public string OrderInvoiceMaxIDSelectQuery()
        {
            string strQuery;
            strQuery =
                "SELECT MAX(id) COL  "
                + "FROM  invoices  "
            ;
            return strQuery;
        }


        public string OrderInsertQuery(int nCustomerID, int nProductID, int nEmployeeID, string strQuantity, string strCalAmount,
            string strCGST, string strSGST, string strAmount, int nInvoiceID)
        {
            string strQuery;
            strQuery =
            "INSERT INTO order_txn  "
            + "            (customer_id,  "
            + "             product_id,  "
            + "             employee_id,  "
            + "             quantity,  "
            + "             price,  "
            + "             sgst,  "
            + "             cgst,  "
            + "             total_price,  "
            + "             invoice_id,  "
            + "             modifiedon)  "
            + "VALUES     ({0},  "
            + "            {1},  "
            + "            {2},  "
            + "            {3},  "
            + "            {4},  "
            + "            {5},  "
            + "            {6},  "
            + "            {7},  "
            + "            {8},  "
            + "            '{9}')  "
            ;

            string strNewQuery = String.Format(strQuery, nCustomerID, nProductID, nEmployeeID, strQuantity, strCalAmount,
                                    strCGST, strSGST, strAmount, nInvoiceID, DateTime.Now.ToString("yyyy-MM-dd"));

            return strNewQuery;
        }

        public string OrderInvoiceInsertQuery(int nCustomerID, int nInvoiceID)
        {
            string strQuery;
            strQuery =
            "INSERT INTO invoices"
            + "            (customer_id, "
            + "            invoice_date_created, "
            + "            invoice_date_modified, "
            + "            id) "
            + "VALUES     ({0},  "
            + "            '{1}',  "
            + "            '{2}',  "
            + "            {3} )  "
            ;
            ;
            
            string strNewQuery = String.Format(strQuery, nCustomerID, DateTime.Now.ToString("yyyy-MM-dd"),
                DateTime.Now.ToString("yyyy-MM-dd"), nInvoiceID);

            return strNewQuery;
        }

        public string OrderDeleteQuery(int nOrderID)
        {
            string strQuery;
            strQuery =
               "DELETE FROM order_txn "
               + "WHERE id = {0} ";

            string strNewQuery = String.Format(strQuery, nOrderID);
            return strNewQuery;
        }
        public string OrderDailyRateValueQuery(int nProductID)
        {
            string strQuery;
            strQuery =
                "SELECT value "
                + "FROM daily_rates_ex "
                + "JOIN category ON (daily_rates_ex.category_id = category.id) "
                + "JOIN product ON (product.category_id = category.id) "
                + "WHERE 1 = 1 "
                + "  AND daily_rates_ex.ModifiedOn = '{0}' "
                + "  AND product.id={1} "
                ;

            string strNewQuery = String.Format(strQuery, DateTime.Now.ToString("yyyy-MM-dd"), nProductID);
            return strNewQuery;
        }

        public string ProductSelectQuery(string strName, string strDetails, 
                    string strCategory)
        {
            string strQuery;
            strQuery =
            "SELECT product.id,  "
            + "       product.NAME,  "
            + "       product.details,  "
            + "       category.type  "
            + "FROM   product  "
            + "       JOIN category  "
            + "         ON ( product.category_id = category.id )  "
            + "WHERE  1 = 1  "
            + "       AND NAME LIKE '%{0}%'  "
            + "       AND details LIKE '%{1}%'  "
            + "       AND category.type LIKE '%{2}%'  "
            ;
            string strNewQuery = String.Format(strQuery, strName, strDetails,
                                    strCategory);
            
            return strNewQuery;
        }

        public string ProductInsertQuery(string strName, string strDetails,
                    int nID)
        {

            string strQuery;
            strQuery =
                "INSERT INTO product  "
                + "            (NAME,  "
                + "             details,  "
                + "             category_id)  "
                + "VALUES     ('{0}',  "
                + "            '{1}',  "
                + "            {2})  "
                ;
            string strNewQuery = String.Format(strQuery, strName, strDetails,
                                    nID);
            return strNewQuery;
        }

        public string ProductUpdatetQuery(string strName, string strDetails, string strCategory,
                    int nID)
        {
            string strQuery;
            strQuery =
            "UPDATE product  "
            + "SET    NAME = '{0}',  "
            + "       details = '{1}',  "
            + "       category = '{2}'  "
            + "WHERE  id = {3}  "
            ;
            ;
            string strNewQuery = String.Format(strQuery, strName, strDetails, strCategory,
                                    nID);
            return strNewQuery;
        }
        public string ProductDeleteQuery(int nID)
        {
            string strQuery;
            strQuery =
            "DELETE FROM product  "
            + "WHERE  id = {0}  "
            ;
            string strNewQuery = String.Format(strQuery, nID);
            return strNewQuery;
        }
        public string CustomerSelectQuery(string strFName, string strMName, string strLName,
                                    string strAddress, string strPhone)
        {
            string strQuery;
            strQuery =
                "SELECT *  "
                + "FROM   customer  "
                + "WHERE  1 = 1  "
                + "       AND firstname LIKE '%{0}%'  "
                + "       AND middlename LIKE '%{1}%'  "
                + "       AND lastname LIKE '%{2}%'  "
                + "       AND address LIKE '%{3}%'  "
                + "       AND phone_no LIKE '%{4}%' "
                ;
            string strNewQuery = String.Format(strQuery, strFName, strMName, strLName,
                                    strAddress, strPhone);
            return strNewQuery;
        }

        public string EmployeeSelectQuery(string strCode, string strFName, string strMName, string strLName,
                                    string strAddress, string strPhone)
        {
            string strQuery;
            strQuery =
                "SELECT *  "
                + "FROM   employee  "
                + "WHERE  1 = 1  "
                + "       AND code LIKE '%{0}%' "
                + "       AND firstname LIKE '%{1}%'  "
                + "       AND middlename LIKE '%{2}%'  "
                + "       AND lastname LIKE '%{3}%'  "
                + "       AND address LIKE '%{4}%'  "
                + "       AND phone_no LIKE '%{5}%' "
                ;
            string strNewQuery = String.Format(strQuery, strCode, strFName, strMName, strLName,
                                    strAddress, strPhone);
            return strNewQuery;
        }

        public string AssignmentSelectQuery(bool bValue, string strDate, int nEmployeeID)
        {
            string strQuery;
            strQuery =
                "SELECT order_txn.id, "
            + "       employee.firstname, "
            + "       order_txn.type, "
            + "       order_txn.work_start_date, "
            + "       order_txn.work_end_date, "
            + "       order_txn.modifiedon "
            + "FROM   order_txn "
            + "       JOIN employee "
            + "         ON ( employee.id = order_txn.employee_id ) "
            + "WHERE  1 = 1 "
            + "       AND employee.id = {0} "
            
            ;
            string strNewQuery = String.Format(strQuery, nEmployeeID);

            if (bValue == true)
            {
                string strDateQuery = "       AND order_txn.modifiedon = '{0}' ";
                string strNewDateQuery = String.Format(strDateQuery, strDate);

                strNewQuery = strNewQuery + strNewDateQuery;
            }
            strNewQuery = strNewQuery + "ORDER BY order_txn.modifiedon DESC";

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
        public string EmployeeInsertQuery(string strCode, string strFName, string strMName, string strLName,
                                    string strAddress, string strPhone)
        {
            string strQuery;
            strQuery =
                "INSERT INTO employee ("
                + "            code, "
                + "            firstname, "
                + "             middlename, "
                + "             lastname, "
                + "             address, "
                + "             phone_no) "
                + "VALUES('{0}', "
                + "            '{1}', "
                + "            '{2}', "
                + "            '{3}', "
                + "            '{4}', "
                + "            '{5}') "
                ;
            string strNewQuery = String.Format(strQuery, strCode, strFName, strMName, strLName,
                                    strAddress, strPhone);
            return strNewQuery;
        }
        public string CustomerUpdateQuery(string strFName, string strMName, string strLName,
                                    string strAddress, string strPhone, int nID)
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
        public string EmployeeUpdateQuery(string strCode, string strFName, string strMName, string strLName,
                                    string strAddress, string strPhone, int nID)
        {
            string strQuery;
            strQuery =
                "UPDATE employee "
                + "SET "
                + "       code = '{0}', "
                + "       firstname = '{1}', "
                + "       middlename = '{2}', "
                + "       lastname = '{3}', "
                + "       address = '{4}', "
                + "       phone_no = '{5}' "
                + "WHERE id = {6} "
            ;
            string strNewQuery = String.Format(strQuery, strCode, strFName, strMName, strLName,
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


        public string EmployeeDeleteQuery(int nID)
        {
            string strQuery;
            strQuery =
                "DELETE FROM employee  "
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

        public string ProductCategorySelectQuery(string strCategoryType)
        {
            string strQuery;
            strQuery =
                "SELECT id  "
                + "FROM   category  "
                + "WHERE  1 = 1  "
                + "       AND category.type LIKE '%{0}%'  "
                ; 
            string strNewQuery = String.Format(strQuery, strCategoryType);

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

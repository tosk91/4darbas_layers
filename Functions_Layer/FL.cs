using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Item_Layer;
using Database_Layer;

namespace Functions_Layer
{
    public class FL
    {
        public DataTable GetAllItems(Item daiktas)
        {
            DBL itemDBL = new DBL();
            return itemDBL.ExtractAll().Tables[0];
        }
        public DataTable GetItemByID(int id)
        {
            DBL itemDBL = new DBL();
            return itemDBL.GetByID(id).Tables[0];
        }
        public DataTable GetByPriceMoreThanAVG()
        {
            DBL dbl = new DBL();
            return dbl.GetByPriceMoreThanAVG().Tables[0];
        }
        public DataTable GetByPriceLessThanAVG()
        {
            DBL dbl = new DBL();
            return dbl.GetByPriceLessThanAVG().Tables[0];
        }
        public DataTable GetTotalPrice()
        {
            DBL dbl = new DBL();
            return dbl.GetTotalPrice().Tables[0];
        }
        public double GetAveragePrice()
        {
            DBL dbl = new DBL();
            return dbl.GetAveragePrice().Tables[0].Rows[0].Field<double>("avg_price");
        }

        // pagrindinis sitos uzduoties tikslas buvo paziureti, kaip studentai suformuos sita sudetine uzklausa:
        // man nepaejo, nespejau pabaigti.

        //public DataTable GetByParameters(int a, double p, int r, string t)
        //{
        //    DBL dbl = new DBL();
        //    DataTable dt = new DataTable();
        //    //int amount = Convert.ToInt32(a);
        //    //int rgb = Convert.ToInt32(r);
        //double price = Convert.ToDouble(p);
        //string type = "";
        //if (a.Length > 0) //amount = a;
        ////    if (p.Length > 0) //price = p;
        ////        if (r.Length > 0) //rgb = r;
        ////            if (t.Length > 0) //type = t;
        ////            { dbl.ExtractAll().Tables[0].DefaultView.RowFilter = "amount = '@amount' and price = '@price' and rgb = '@rgb' and type = '@t'"; return dbl.GetTotalPrice().Tables[0].DefaultView.ToTable(); }
        ////            else { dbl.ExtractAll().Tables[0].DefaultView.RowFilter = "amount = '@amount' and price = '@price' and rgb = '@rgb'"; return dbl.GetTotalPrice().Tables[0].DefaultView.ToTable(); }
        ////        else { dbl.ExtractAll().Tables[0].DefaultView.RowFilter = "amount = '@amount' and price = '@price'"; return dbl.GetTotalPrice().Tables[0].DefaultView.ToTable(); }
        ////    else { dbl.ExtractAll().Tables[0].DefaultView.RowFilter = "amount = '@amount'"; return dbl.GetTotalPrice().Tables[0].DefaultView.ToTable(); }
        ////else { return dbl.ExtractAll().Tables[0]; }

        //    if (a != 0 && p != 0 && (r == 1 || r == 0) && t != "")
        //    {
        //        dbl.ExtractAll().Tables[0].DefaultView.RowFilter = "amount = 7 and price = 50 and rgb = 0 and type = '@t'";
        //        return dbl.GetTotalPrice().Tables[0].DefaultView.ToTable();
        //    }
        //    return dbl.ExtractAll().Tables[0];
        //}
    }
}

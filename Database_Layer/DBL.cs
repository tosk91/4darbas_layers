using System.Data;
using System.Data.SqlClient;

namespace Database_Layer
{
    public class DBL
    {
        SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tomas\OneDrive - Vilniaus kolegija\3_Kursas\PSI\4darbas_layers\UI_Layer\Database.mdf;Integrated Security=True");

        public DataSet GetByID(int id)
        {
            DataSet dataset = new DataSet();
            SqlCommand sqlcmd = new SqlCommand("select * from Preke where id = @id", sqlConn);
            sqlcmd.Parameters.AddWithValue("id", id);

            SqlDataAdapter dap = new SqlDataAdapter(sqlcmd);

            dap.Fill(dataset);
            return dataset;
        }
        public DataSet GetByRGB(int rgb)
        {
            DataSet dataset = new DataSet();
            SqlCommand sqlcmd = new SqlCommand("select * from Preke where rgb = @rgb", sqlConn);
            sqlcmd.Parameters.AddWithValue("rgb", rgb);
            SqlDataAdapter dap = new SqlDataAdapter(sqlcmd);
            dap.Fill(dataset);
            return dataset;
        }
        public DataSet GetByType(string type)
        {
            DataSet dataset = new DataSet();
            SqlCommand sqlcmd = new SqlCommand("select * from Preke where type = @type", sqlConn);
            sqlcmd.Parameters.AddWithValue("type", type);
            SqlDataAdapter dap = new SqlDataAdapter(sqlcmd);
            dap.Fill(dataset);
            return dataset;
        }
        public DataSet GetByPriceMoreThanAVG()
        {
            DataSet dataset = new DataSet();
            SqlCommand sqlcmd = new SqlCommand("select * from Preke where price >= (select avg(price) from Preke);", sqlConn);
            SqlDataAdapter dap = new SqlDataAdapter(sqlcmd);
            dap.Fill(dataset);
            return dataset;
        }
        public DataSet GetByPriceLessThanAVG()
        {
            DataSet dataset = new DataSet();
            SqlCommand sqlcmd = new SqlCommand("select * from Preke where price <= (select avg(price) from Preke);", sqlConn);
            SqlDataAdapter dap = new SqlDataAdapter(sqlcmd);
            dap.Fill(dataset);
            return dataset;
        }
        public DataSet GetAveragePrice()
        {
            DataSet dataset = new DataSet();
            SqlCommand sqlcmd = new SqlCommand("select avg(price) as avg_price from Preke;", sqlConn);
            SqlDataAdapter dap = new SqlDataAdapter(sqlcmd);
            dap.Fill(dataset);
            return dataset;
        }
        public DataSet ExtractByAmount(string type)
        {
            DataSet dataset = new DataSet();
            SqlCommand sqlcmd = new SqlCommand("select * from Preke where type=@type", sqlConn);
            sqlcmd.Parameters.AddWithValue("type", type);
            SqlDataAdapter dap = new SqlDataAdapter(sqlcmd);
            dap.Fill(dataset);
            return dataset;
        }
        public DataSet GetTotalPrice()
        {
            DataSet dataset = new DataSet();
            SqlCommand sqlcmd = new SqlCommand("select sum(price) as 'Total cost of all items' from Preke;", sqlConn);
            SqlDataAdapter dap = new SqlDataAdapter(sqlcmd);
            dap.Fill(dataset);
            return dataset;
        }
        public DataSet ExtractAll()
        {
            DataSet dataset = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter("select * from Preke", sqlConn);
            dap.Fill(dataset);
            return dataset;
        }
    }
}

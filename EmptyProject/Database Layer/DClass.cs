//DClass.cs
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;
using System.Windows.Forms;
using EmptyProject.Bussiness_Layer;
using System.Data;

namespace EmptyProject.Database_Layer
{
    internal class DatabaseClass
    {
        public static SqlConnection GetConnection()
        {
            
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-RTV4G1L\\SQLEXPRESS;Initial Catalog=MyDb9;Integrated Security=True");
            con.Open();
            return con;
        }


        public static DataTable GetPizzaList()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    string query = "SELECT id, name, descr, price, type FROM addpiza";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
            return dt;
        }

        public static void AddPizza(Owner obj)
        {
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    string Qurey = "INSERT INTO addpiza(id, name, descr, price, type) VALUES('" + obj.pizza_id + "', '" + obj.pizza_name + "', '" + obj.description + "', '" + obj.price + "', '" + obj.select_type + "');";
                    SqlCommand str = new SqlCommand(Qurey, con);
                    str.ExecuteNonQuery();
                    MessageBox.Show("New Pizza Information Saved Successfully..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving pizza: " + ex.Message);
            }
        }

        public static void update(Owner Obj)
        {
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    string str = "Update addpiza set name='" + Obj.pizza_name + "',descr='" + Obj.description + "',price='" + Obj.price + "',type='" + Obj.select_type + "' where id='" + Obj.pizza_id + "'";
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(Obj.pizza_id + "'s Details Updated Successfully..");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        

        public static DataTable GetOrderList()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    
                    string query = @"SELECT 
                                o_id, 
                                p_id, 
                                name, 
                                descr, 
                                qnt, 
                                price, 
                                (CAST(price AS INT) * CAST(qnt AS INT)) AS total_price, 
                                c_id, 
                                c_name, 
                                mobile, 
                                addr, 
                                d_order, 
                                status 
                             FROM ordpiza 
                             order BY o_id DESC"; 

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.Fill(dt);
                }
            }
            catch (Exception ex) { MessageBox.Show("Grid Error: " + ex.Message); }
            return dt;
        }

        public static void order(Owner obj)
        {
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    
                    string query = @"INSERT INTO ordpiza(p_id, name, descr, qnt, price, c_id, c_name, mobile, addr) 
                             VALUES(@pid, @pname, @desc, @qnt, @price, @cid, @cname, @mob, @addr)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@pid", obj.pizza_id);
                    cmd.Parameters.AddWithValue("@pname", obj.pizza_name);
                    cmd.Parameters.AddWithValue("@desc", obj.description);
                    cmd.Parameters.AddWithValue("@qnt", obj.quantity);
                    cmd.Parameters.AddWithValue("@price", obj.price);
                    cmd.Parameters.AddWithValue("@cid", obj.cust_id);
                    cmd.Parameters.AddWithValue("@cname", obj.name);
                    cmd.Parameters.AddWithValue("@mob", obj.mobile);
                    cmd.Parameters.AddWithValue("@addr", obj.address);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Placed Successfully!");
                }
            }
            catch (Exception ex) { MessageBox.Show("Insert Error: " + ex.Message); }
        }

        public static void payment(Owner obj)
        {
            try
            {
                using (SqlConnection con = GetConnection())
                {
                  
                    string payQuery = "INSERT INTO pay (id, amnt, type) VALUES (@id, @amnt, @type)";
                    SqlCommand cmd1 = new SqlCommand(payQuery, con);
                    cmd1.Parameters.AddWithValue("@id", obj.order_id);                     cmd1.Parameters.AddWithValue("@amnt", obj.amount);
                    cmd1.Parameters.AddWithValue("@type", obj.select_type);
                    cmd1.ExecuteNonQuery();

                    
                    string updateQuery = "UPDATE ordpiza SET status = 'Paid' WHERE c_id = @id AND status = 'Unpaid'";
                    SqlCommand cmd2 = new SqlCommand(updateQuery, con);
                    cmd2.Parameters.AddWithValue("@id", obj.order_id);
                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("Payment Successful and Status Updated to Paid.");
                }
            }
            catch (Exception ex) { MessageBox.Show("Payment Error: " + ex.Message); }
        }


        public static void feedback(Customer obj)
        {
            try
            {
                using (SqlConnection con = GetConnection()) 
                {
                    
                    string query = "INSERT INTO fdbk (name, feedb) VALUES (@name, @feed)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", obj.name);
                    cmd.Parameters.AddWithValue("@feed", obj.feedback);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thank you for your feedback!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }
        public static DataTable GetCustomerList()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    
                    string query = "SELECT name, mobi, addr, c_id FROM customer";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.Fill(dt);
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading customers: " + ex.Message); }
            return dt;
        }
        public static void saveCustomer(Owner obj)
        {
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    
                    string str = "INSERT INTO customer(name, mobi, addr) VALUES('" + obj.name + "','" + obj.mobile + "','" + obj.address + "'); ";
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Information Saved Successfully..");
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        public static void deletePizza(Owner obj)
        {
            SqlConnection con = GetConnection();

            string Qurey = "delete addpiza where id = '" + obj.pizza_id + "'";

            SqlCommand cmd = new SqlCommand(Qurey, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void deleteOrder(Owner obj)
        {
            try
            {
                using (SqlConnection con = GetConnection())
                {
                   
                    string query = "DELETE FROM ordpiza WHERE o_id = @oid";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@oid", obj.order_id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Delete Error: " + ex.Message);
            }
        }

        public static void deleteCustomer(Owner obj)
        {
            SqlConnection con = GetConnection();

            string Qurey = "delete customer where c_id = '" + obj.cust_id + "'";

            SqlCommand cmd = new SqlCommand(Qurey, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        

        public static string GetPendingAmount(string orderId)
        {
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    
                    string statusQuery = "SELECT status FROM ordpiza WHERE o_id = @oid";
                    SqlCommand statusCmd = new SqlCommand(statusQuery, con);
                    statusCmd.Parameters.AddWithValue("@oid", orderId);
                    object statusResult = statusCmd.ExecuteScalar();

                    if (statusResult == null)
                        return "NOT_FOUND";

                    
                    if (statusResult.ToString().Trim().ToLower() == "paid")
                        return "ALREADY_PAID";

                    
                    string calcQuery = "SELECT (CAST(price AS INT) * CAST(qnt AS INT)) FROM ordpiza WHERE o_id = @oid";
                    SqlCommand calcCmd = new SqlCommand(calcQuery, con);
                    calcCmd.Parameters.AddWithValue("@oid", orderId);
                    object totalResult = calcCmd.ExecuteScalar();

                    return totalResult != null ? totalResult.ToString() : "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
                return "ERROR";
            }
        }

        public static bool ProcessPayment(Owner obj)
        {
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    
                    string checkQuery = "SELECT status FROM ordpiza WHERE o_id = @id";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@id", obj.order_id);
                    object currentStatus = checkCmd.ExecuteScalar();

                    if (currentStatus != null && currentStatus.ToString().Trim().ToLower() == "paid")
                    {
                        MessageBox.Show("This order has already been paid.", "Alert");
                        return false;
                    }

                    
                    string payQuery = "INSERT INTO pay (id, amnt, type) VALUES (@id, @amnt, @type)";
                    SqlCommand cmd1 = new SqlCommand(payQuery, con);
                    cmd1.Parameters.AddWithValue("@id", obj.order_id);
                    cmd1.Parameters.AddWithValue("@amnt", obj.amount);
                    cmd1.Parameters.AddWithValue("@type", obj.select_type);
                    cmd1.ExecuteNonQuery();

                    
                    string updateQuery = "UPDATE ordpiza SET status = 'Paid' WHERE o_id = @id";
                    SqlCommand cmd2 = new SqlCommand(updateQuery, con);
                    cmd2.Parameters.AddWithValue("@id", obj.order_id);
                    int rowsAffected = cmd2.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Order ID not found. Status could not be updated.");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Payment Error: " + ex.Message);
                return false;
            }
        }
 
        public static string GetDatabaseContext()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SHOP DATABASE RECORDS:");
            string[] tables = { "addpiza", "ordpiza", "pay", "fdbk", "customer" };

            using (SqlConnection con = GetConnection())
            {
                foreach (string tableName in tables)
                {
                    sb.AppendLine($"\nTable [{tableName}]:");
                    string query = $"SELECT * FROM {tableName}";
                    SqlCommand cmd = new SqlCommand(query, con);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            for (int i = 0; i < dr.FieldCount; i++)
                                sb.Append(dr[i].ToString() + " | ");
                            sb.AppendLine();
                        }
                    }
                }
            }
            return sb.ToString();
        }



    }
}

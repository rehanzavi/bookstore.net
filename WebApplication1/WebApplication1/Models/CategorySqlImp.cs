using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Http.Results;

namespace WebApplication1.Models
{
    public class CategorySqlImp: ICategoryRepository
    {
        SqlCommand comm;
        SqlConnection conn;

        public CategorySqlImp()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString);
            comm = new SqlCommand();
        }
        public List<Category> GetAllCategory()
        {
            List<Category> list = new List<Category>();
            comm.CommandText = "select * from category";
            comm.Connection = conn;
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["CatId"]);
                string catName = reader["Name"].ToString();
                string catDesc = reader["Description"].ToString();
                string img = reader["Image"].ToString();
                int position = Convert.ToInt32(reader["Position"]);
                int status = Convert.ToInt32(reader["Status"]);
                string createdat = reader["CreatedAt"].ToString();
                list.Add(new Category(id, catName, catDesc, img, status, position, createdat));
            }
            conn.Close();
            return list;

        }
        public Category GetCategoryByID(int catId)
        {
            Category cat = new Category();
            comm.CommandText = "select * from Category where CategoryId = " + catId;
            comm.Connection = conn;
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["CatId"]);
                string catName = reader["Name"].ToString();
                string catDesc = reader["Description"].ToString();
                string img = reader["Image"].ToString();
                int position = Convert.ToInt32(reader["Position"]);
                int status = Convert.ToInt32(reader["Status"]);
                string createdat = reader["CreatedAt"].ToString();
                cat = new Category(id, catName, catDesc, img, status, position, createdat);
            }
            conn.Close();
            return cat;
        }
        public Category AddCategory(Category category)
        {
            comm.CommandText = $"insert into Category(Name, Description, Image, Status, Position) values ('{category.Name}','{category.Description}','{category.Image}',{category.Status}, {category.Position})";

            comm.Connection = conn;
            conn.Open();
            int row = comm.ExecuteNonQuery();
            conn.Close();
            if (row > 0)
            {
                return category;
            }
            else
            {
                return null;
            }


        }

        public void DeleteCategory(int catId)
        {
            comm.CommandText = "delete from Category where CategoryId = " + catId;
            comm.Connection = conn;
            conn.Open();
            int row = comm.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateCategory(Category category)
        {
            comm.CommandText = $"update category set Name = '{category.Name}',Description='{category.Description}',Image = '{category.Image}',Status={category.Status},Position={category.Position} where CategoryId = {category.CatId}";
            comm.Connection = conn;
            conn.Open();
            int row = comm.ExecuteNonQuery();
            conn.Close();
        }
    }
}

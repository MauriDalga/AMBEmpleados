

namespace AMBEmpleados.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data.SqlClient;
    using Models;

    public class SqlRepository : IRepository
    {
        private string _connectionString;

        public SqlRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        }

        public void Add(Employee newEmployee)
        {
            using(var cn = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO empleados (codigo,nombre_completo,nacimiento,contratacion," +
                    "salario_hora) VALUES (@codigo,@nombre,@nacimiento,@contratacion,@salarioH)";
                cn.Open();
                SqlCommand cmd = new SqlCommand {
                    Connection = cn,
                    CommandText = query
                };
                cmd.Parameters.AddWithValue("@codigo", newEmployee.Code);
                cmd.Parameters.AddWithValue("@nombre", newEmployee.CompleteName);
                cmd.Parameters.AddWithValue("@nacimiento", newEmployee.Born.Date);
                cmd.Parameters.AddWithValue("@contratacion", newEmployee.Hiring.Date);
                cmd.Parameters.AddWithValue("@salarioH", newEmployee.SalaryPerHour);
                cmd.ExecuteNonQuery();
            }
        }

        public Employee Get(int code)
        {
            Employee founded = null;
            using (var cn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM empleados WHERE codigo = @codigo";
                cn.Open();
                SqlCommand cmd = new SqlCommand
                {
                    Connection = cn,
                    CommandText = query
                };
                cmd.Parameters.AddWithValue("@codigo", code);
                SqlDataReader result = cmd.ExecuteReader();
                if (result.Read())
                {
                    founded = new Employee(code)
                    {
                        CompleteName = result["nombre_completo"].ToString(),
                        Born = result.GetDateTime(result.GetOrdinal("nacimiento")),
                        Hiring = result.GetDateTime(result.GetOrdinal("contratacion")),
                        SalaryPerHour = result.GetDecimal(result.GetOrdinal("salario_hora")),
                        Unsubscribe = Convert.ToInt32(result["baja_logica"].ToString()) != 0
                    };
                }
            }
            return founded;
        }

        public IEnumerable<Employee> GetAll()
        {
            List<Employee> foundeds = new List<Employee>();
            using (var cn = new SqlConnection(_connectionString))
            {
                Employee founded = null;
                string query = "SELECT * FROM empleados";
                cn.Open();
                SqlCommand cmd = new SqlCommand
                {
                    Connection = cn,
                    CommandText = query
                };
                SqlDataReader result = cmd.ExecuteReader();
                while (result.Read())
                {
                    founded = new Employee(result.GetInt32(result.GetOrdinal("codigo")))
                    {
                        CompleteName = result["nombre_completo"].ToString(),
                        Born = result.GetDateTime(result.GetOrdinal("nacimiento")),
                        Hiring = result.GetDateTime(result.GetOrdinal("contratacion")),
                        SalaryPerHour = result.GetDecimal(result.GetOrdinal("salario_hora")),
                        Unsubscribe = Convert.ToInt32(result["baja_logica"].ToString()) != 0
                    };
                    foundeds.Add(founded);
                }
            }
            return foundeds;
        }

        public void Remove(int code)
        {
            using (var cn = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM empleados WHERE codigo = @codigo";
                cn.Open();
                SqlCommand cmd = new SqlCommand
                {
                    Connection = cn,
                    CommandText = query
                };
                cmd.Parameters.AddWithValue("@codigo", code);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(int code, Employee updated)
        {
            using (var cn = new SqlConnection(_connectionString))
            {
                string query = "UPDATE empleados SET nombre_completo = @nombre,nacimiento = @nacimiento," +
                    "contratacion = @contratacion, salario_hora = @salarioH," +
                    "baja_logica = @baja WHERE codigo = @codigo";
                cn.Open();
                SqlCommand cmd = new SqlCommand
                {
                    Connection = cn,
                    CommandText = query
                };
                cmd.Parameters.AddWithValue("@nombre", updated.CompleteName);
                cmd.Parameters.AddWithValue("@nacimiento", updated.Born.Date);
                cmd.Parameters.AddWithValue("@contratacion", updated.Hiring.Date);
                cmd.Parameters.AddWithValue("@salarioH", updated.SalaryPerHour);
                cmd.Parameters.AddWithValue("@baja", updated.Unsubscribe);
                cmd.Parameters.AddWithValue("@codigo", code);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

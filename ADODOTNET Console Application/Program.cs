



using Microsoft.Data.SqlClient;

SqlConnection con = null;
con = new SqlConnection("server=(LocalDb)\\AL5260;database=MyLearnings;integrated security=SSPI;TrustedServerConnection=True;");
SqlCommand sc = new SqlCommand("insert into Student(id,name,email,date_of_joining)values('101','Shanmukha Sai Kiran Pithani','saikiran@gmail.com','10/17/2022')", con);
con.Open();
sc.ExecuteNonQuery();
con.Close();
Console.WriteLine("Insert Query Executed with successfully ");

using EmployeeService;
//
// var builder = Host.CreateApplicationBuilder(args);
// builder.Services.AddHostedService<Worker>();
//
// var host = builder.Build();
// static void GetEmployee()
// {
//     // Connection string to your SQL Server database
//     string connectionString = "Server=tcp:database-study.database.windows.net,1433; " +
//                               "Initial Catalog=EmployWorktime; " + 
//                               "Encrypt=True;" +
//                               "TrustServerCertificate=False;" +
//                               "Connection Timeout=30;" +
//                               "Authentication=Active Directory Default;";
//
//     using (SqlConnection connection = new SqlConnection(connectionString))
//     {
//         try
//         {
//             connection.Open();
//             Console.WriteLine("Connection Opened.");
//
//             // Example SQL query
//             string sqlQuery = "SELECT * FROM " + "dbo.Employees";
//
//             using (SqlCommand command = new SqlCommand(sqlQuery, connection))
//             {
//                 // Execute the command and read the data
//                 using (SqlDataReader reader = command.ExecuteReader())
//                 {
//                     while (reader.Read())
//                     {
//                         // Assuming the first column is an integer and the second column is a string
//                         int id = reader.GetInt32(0);
//                         string name = reader.GetString(1);
//                         Console.WriteLine($"ID: {id}, Name: {name}");
//                     }
//                 }
//             }
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine($"An error occurred: {ex.Message}");
//         }
//         finally
//         {
//             connection.Close();
//             Console.WriteLine("Connection Closed.");
//         }
//     }
// }
// }
//
// host.Run();

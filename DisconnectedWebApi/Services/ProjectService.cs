using System.Data;
using MySql.Data.MySqlClient;
using TFLPortal.Models;
using TFLPortal.Services;

namespace TFLPortal.Services;
public class ProjectService : IProjectService
{

  public readonly IConfiguration configuration;
  private readonly string _connectionString;
  public ProjectService(IConfiguration _configuration)
  {
    _connectionString = _configuration.GetConnectionString("DefaultConnection") ?? throw new ArgumentNullException("connectionString");

    configuration = _configuration;
  }
  public bool Update(Project project)
  {
    // List<Project> projects = new List<Project>();
    //   Project project =new Project{
    //     Id = 1,
    //     Title="PMS",
    //     StartDate= new DateTime(2023,01,01),
    //     EndDate=new DateTime(2023,01,01),
    //     Description="Project Management Sercice"
    //    };
    //   projects.Add(project);
    bool status = false;
    MySqlConnection connection = new MySqlConnection();
    connection.ConnectionString = _connectionString;
    try
    {

      string query = "select * from projects";
      MySqlCommand command = new MySqlCommand(query, connection);
      MySqlDataAdapter adapter = new MySqlDataAdapter(command);
      DataSet dataSet = new DataSet();
      MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
      adapter.Fill(dataSet);
      DataTable dataTable = dataSet.Tables[0];

      DataColumn[] keyColum = new DataColumn[1];
      keyColum[0] = dataTable.Columns["id"];
      dataTable.PrimaryKey = keyColum;

      DataRow row = dataTable.Rows.Find(project.Id);
      row["title"] = project.Title;
      adapter.Update(dataSet);
      status = true;


    }
    catch (Exception e)
    {
      Console.WriteLine(e.Message);
      throw e;
    }
    return status;
  }

}
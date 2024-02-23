using TFLPortal.Models;

namespace TFLPortal.Services;
public interface IProjectService{

    public  bool Update(Project project);

    public  List<Project> GetProjects();

    public bool Insert(Project project);
}
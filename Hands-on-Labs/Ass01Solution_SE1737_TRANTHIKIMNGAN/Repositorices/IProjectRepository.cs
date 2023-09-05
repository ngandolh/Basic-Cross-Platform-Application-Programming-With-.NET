using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccessObjects;

namespace Repositorices
{
    public interface IProjectRepository
    {
        IEnumerable<ProjectObject> GetProjectObjects();
        ProjectObject GetCarByID(int ProjectID);
        void InsertProject(ProjectObject pro);
        void DeleteProject(int ProjectID);
        void UpdateProject(ProjectObject pro);
    }
}

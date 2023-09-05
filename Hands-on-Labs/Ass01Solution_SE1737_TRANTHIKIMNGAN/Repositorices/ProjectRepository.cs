using System;
using System.Collections.Generic;
using BusinessObject;
using DataAccessObjects;

namespace Repositorices
{
    public class ProjectRepository : IProjectRepository
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public void DeleteCar(int ProjectID) => ProjectDAO.Instance.Remove(ProjectID);
        

        public ProjectObject GetCarByID(int ProjectID) => ProjectDAO.Instance.GetProjectByID(ProjectID);

        public IEnumerable<ProjectObject> GetProjectObjects() => ProjectDAO.Instance.GetProjectList;

        public void InsertCar(ProjectObject pro) => ProjectDAO.Instance.AddNew(pro);

        public void UpdateCar(ProjectObject pro) => ProjectDAO.Instance.Update(pro);

    }
}

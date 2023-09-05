using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using BusinessObject;

namespace DataAccessObjects
{
    public class ProjectDAO
    {
        //-----------------------------------------------
        //Initialize project list
        private static List<ProjectObject> ProjectList = new List<ProjectObject>()
        {

            //new ProjectObject{ ProjectID=1, ProjectName="Lab 1", EstimatedStartDate=, EstimatedEndDate=, ProjectAddress="/C", ProjectCity="HCM", ProjectDescription="PRN211" },
            //new ProjectObject{ ProjectID=2, ProjectName="Lab 2", EstimatedStartDate=(2023,06,10), EstimatedEndDate=, ProjectAddress="/C", ProjectCity="HCM", ProjectDescription="PRN211" },
        };

        private static ProjectDAO instance = null;
        private static readonly object instanceLock = new object();
        private ProjectDAO() { }
        public static ProjectDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProjectDAO();
                    }
                    return instance;
                }
            }
        }
        public List<ProjectObject> GetProjectList => ProjectList;
        public ProjectObject GetProjectByID(int projectID)
        {
            ProjectObject project = ProjectList.SingleOrDefault(pro => pro.ProjectID == projectID);
            return project;
        }
        //---------------------------------------------------
        //Add new project
        public void AddNew(ProjectObject project)
        {
            ProjectObject  pro = GetProjectByID(project.ProjectID);
            if (pro == null)
            {
                ProjectList.Add(project);
            } else
            {
                throw new Exception("Project is already exists.");
            }
        }
        //Update a project
        public void Update(ProjectObject project)
        {
            ProjectObject pro = GetProjectByID(project.ProjectID);
            if (pro != null)
            {
                var index = ProjectList.IndexOf(pro);
                ProjectList[index] = project;
            }
            else
            {
                throw new Exception("Project does not already exists.");
            }
        }
        //-------------------------------------------
        //Remove a project
        public void Remove(int ProjectID)
        {
            ProjectObject p = GetProjectByID(ProjectID);
            if (p != null)
            {
                ProjectList.Remove(p);
            }
            else
            {
                throw new Exception("Project does not already exists.");
            }
        }//end Remove
    }//end class
}

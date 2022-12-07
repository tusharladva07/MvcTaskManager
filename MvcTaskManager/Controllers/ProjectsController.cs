using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using MvcTaskManager.Identity;
using MvcTaskManager.Models;
using System.Collections.Generic;
using System.Linq;
using Project = MvcTaskManager.Models.Project;

namespace MvcTaskManager.Controllers
{
    [Authorize]
    public class ProjectsController : Controller
    {
        private ApplicationDbContext db;
        public ProjectsController(ApplicationDbContext applicationDbContext)
        {
            this.db = applicationDbContext;
        }
        [HttpGet]
        [Route("api/projects")]
        public List<Project> Get()
        {
            List<Project> projects = db.Projects.ToList();
            return projects;
        }

        [HttpPost]
        [Route("api/projects")]
        public Project Post([FromBody] Project project)
        {
            db.Projects.Add(project);
            db.SaveChanges();
            return project;
        }

        [HttpPut]
        [Route("api/projects")]
        public Project Put([FromBody] Project project)
        {
            Project existingProject = db.Projects.Where(temp => temp.ProjectID == project.ProjectID).FirstOrDefault();

            if (existingProject != null)
            {
                existingProject.ProjectName = project.ProjectName;
                existingProject.DateOfStart = project.DateOfStart;
                existingProject.Teamsize = project.Teamsize;
                db.SaveChanges();
                return existingProject;
            }
            else
            {
                return null;
            }

        }

        [HttpDelete]
        [Route("api/projects")]
        public int Delete(int projectId)
        {
            Project deleteProject = db.Projects.Where(temp => temp.ProjectID == projectId).FirstOrDefault();

            if (deleteProject != null)
            {
                db.Projects.Remove(deleteProject);
                db.SaveChanges();
                return projectId;
            }
            else
            {
                return -1;
            }
        }

        [HttpGet]
        [Route("api/projects/search/{searchby}/{searchtext}")]
        public List<Project> Search(string searchBy, string searchText)
        {
            List<Project> projects = null;
            if (searchBy == "ProjectID")
            {
                projects = db.Projects.Where(temp => temp.ProjectID.ToString().Contains(searchText)).ToList();
            }
            else if (searchBy == "ProjectName")
            {
                projects = db.Projects.Where(temp => temp.ProjectName.ToString().Contains(searchText)).ToList();
            }

            if (searchBy == "DateOfStart")
            {
                projects = db.Projects.Where(temp => temp.DateOfStart.ToString().Contains(searchText)).ToList();
            }

            if (searchBy == "TeamSize")
            {
                projects = db.Projects.Where(temp => temp.Teamsize.ToString().Contains(searchText)).ToList();
            }
            return projects;

        }

    }
}

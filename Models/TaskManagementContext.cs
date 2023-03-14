using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagement.Models
{
    public class TaskManagementContext : DbContext
    {
        public TaskManagementContext(DbContextOptions<TaskManagementContext> options) : base(options) { }
        //mapping model class
        public DbSet<Mission> Mission { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<AssignedTask> AssignedTasks { get; set; }
        public DbSet<Status> Statuses { get; set; }
    }
}
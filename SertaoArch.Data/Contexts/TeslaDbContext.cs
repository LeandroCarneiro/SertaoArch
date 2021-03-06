﻿using $ext_projectname$.Domain.Entities;
using $ext_projectname$.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace $safeprojectname$.Contexts
{
    public class TeslaDbContext : BaseContext, IDbContext 
    {
        public virtual DbSet<Survey> tblSurveis { get; set; }
        public virtual DbSet<Question> tblQuestions { get; set; }
        public virtual DbSet<Answer> tblAnswers { get; set; }
        public virtual DbSet<UserApp> tblUsers { get; set; }
        public virtual DbSet<SurveyVersion> tblSurveyVersions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_configuration.GetConnectionString("TeslaDB"));
            base.OnConfiguring(options);

            options.UseLoggerFactory(_loggerFactory);
        }
    }
}

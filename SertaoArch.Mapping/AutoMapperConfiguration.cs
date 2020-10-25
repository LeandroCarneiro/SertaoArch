﻿using AutoMapper;
using $safeprojectname$.Profiles;

namespace $safeprojectname$
{
    public static class AutoMapperConfiguration
    {
        public static MapperConfiguration _config;

        public static void Register()
        {
            _config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new TeslaDomainProfile());
            });
        }
    }
}
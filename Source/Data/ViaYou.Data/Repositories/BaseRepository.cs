﻿using Microsoft.Practices.Unity;

namespace ViaYou.Data.Repositories
{
    public class BaseRepository
    {
        [Dependency]
        public ViaYouDataContext Context { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cloudscribe.SimpleContent.Models
{
    public class NotImplementedPageService : IPageService
    {
        public void ClearNavigationCache()
        {
            
        }

        public Task DeletePage(string blogId, string pageId)
        {
            throw new NotImplementedException();
        }

        public Task<List<IPage>> GetAllPages(string blogId)
        {
            throw new NotImplementedException();
        }

        public Task<List<IPage>> GetAllPages(string projectId, string userName, string password)
        {
            throw new NotImplementedException();
        }

        public Task<List<IPage>> GetChildPages(string pageId)
        {
            throw new NotImplementedException();
        }

        public Task<IPage> GetPage(string pageId)
        {
            throw new NotImplementedException();
        }

        public Task<IPage> GetPage(string projectId, string pageId, string userName, string password)
        {
            throw new NotImplementedException();
        }

        public Task<IPage> GetPageBySlug(string blogId, string slug)
        {
            throw new NotImplementedException();
        }

        public Task<List<IPage>> GetRootPages()
        {
            throw new NotImplementedException();
        }

        public Task<bool> PageSlugIsAvailable(string slug)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PageSlugIsAvailable(string blogId, string slug)
        {
            throw new NotImplementedException();
        }

        public Task<string> ResolvePageUrl(IPage page)
        {
            throw new NotImplementedException();
        }

        public Task Create(IPage page, bool publish)
        {
            throw new NotImplementedException();
        }

        public Task Update(IPage page, bool publish)
        {
            throw new NotImplementedException();
        }

        public Task Create(string projectId, string userName, string password, IPage page, bool publish)
        {
            throw new NotImplementedException();
        }

        public Task Update(string projectId, string userName, string password, IPage page, bool publish)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SlugIsAvailable(string projectId, string slug)
        {
            throw new NotImplementedException();
        }
    }
}

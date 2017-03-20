using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FakeBlog.DAL
{
    public class BlogRepository : IRepository
    {
        public void AddDraft()
        {
            throw new NotImplementedException();
        }

        public bool EditDraft(int DraftId)
        {
            throw new NotImplementedException();
        }

        public void GetDraft()
        {
            throw new NotImplementedException();
        }

        public bool PublishDraft(int DraftId)
        {
            throw new NotImplementedException();
        }

        public bool RemoveDraft(int DraftId)
        {
            throw new NotImplementedException();
        }

        public bool RemovePost(int BlogPostId)
        {
            throw new NotImplementedException();
        }
    }
}
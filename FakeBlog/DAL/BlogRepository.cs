using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeBlog.DAL
{
    interface BlogRepository
    {
        //CREATE
        void AddDraft();
        

        //READ
        

        //UPDATE
        bool PublishDraft(int DraftId);
        bool EditDraft(int DraftId);

        //DELETE
        bool RemovePost(int BlogPostId);
        bool RemoveDraft(int DraftId);

    }
}

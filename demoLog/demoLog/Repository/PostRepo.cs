using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using demoLog.DAL;
using demoLog.Models;

namespace demoLog.Repository
{
    public class PostRepo
    {
        SchoolContext m_db = new SchoolContext();
        public IEnumerable<PostItem> GetAllPosts()
        {
            var result = (from n in m_db.Posts
                          orderby n.DateCreated descending
                          select n).Take(10);
            return result;
        }
        public PostItem GetPostsById(int? id)
        {
            var result = (from n in m_db.Posts
                          where n.Id == id
                          select n).SingleOrDefault();
            return result;
        }

        public void AddPost(PostItem n)
        {
            m_db.Posts.Add(n);
            m_db.SaveChanges();
        }

        public void UpdatePosts(PostItem n)
        {
            PostItem p = GetPostsById(n.Id);
            if (p != null)
            {
                p.Title = n.Title;
                p.Text = n.Text;
                p.Category = n.Category;
                m_db.SaveChanges();
            }
        }

        public void DeletePost(PostItem n)
        {
            m_db.Posts.Remove(n);
            m_db.SaveChanges();
        }
    }
}
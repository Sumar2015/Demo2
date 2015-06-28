using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using demoLog.DAL;
using demoLog.Models;
using demoLog.Repository;

namespace demoLog.Controllers
{
    public class PostItemsController : Controller
    {
        private SchoolContext db = new SchoolContext();
        private PostRepo postRepo = new PostRepo();

        // GET: PostItems
        public ActionResult Index()
        {
            var result = postRepo.GetAllPosts();
            return View(result);
        }

        // GET: PostItems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PostItem postItem = postRepo.GetPostsById(id);
            if (postItem == null)
            {
                return HttpNotFound();
            }
            return View(postItem);
        }

        // GET: PostItems/Create
        public ActionResult Create()
        {
            PostViewModel postViewModel = new PostViewModel();
            postViewModel.DateCreated = DateTime.Now;
            return View(postViewModel);
        }

        // POST: PostItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Text,DateCreated,Category")] PostItem postItem)
        {
            if (ModelState.IsValid)
            {
                postRepo.AddPost(postItem);
                return RedirectToAction("Index");
            }

            return View(postItem);
        }

        // GET: PostItems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PostItem postItem = postRepo.GetPostsById(id);
            if (postItem == null)
            {
                return HttpNotFound();
            }
            return View(postItem);
        }

        // POST: PostItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Text,DateCreated,Category")] PostItem postItem)
        {
            if (ModelState.IsValid)
            {
                postRepo.UpdatePosts(postItem);
                return RedirectToAction("Index");
            }
            return View(postItem);
        }

        // GET: PostItems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PostItem postItem = postRepo.GetPostsById(id);
            if (postItem == null)
            {
                return HttpNotFound();
            }
            return View(postItem);
        }

        // POST: PostItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PostItem postItem = postRepo.GetPostsById(id);
            postRepo.DeletePost(postItem);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

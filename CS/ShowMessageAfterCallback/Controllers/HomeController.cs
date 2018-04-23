using System;
using System.Web.Mvc;

namespace ShowMessageAfterCallback.Controllers {
    public class HomeController: Controller {
        public const string EditResultKey = "EditResult";
        public const string EditErrorKey = "EditError";

        Repository repository = new Repository();

        public ActionResult Index() {
            return View();
        }
        public ActionResult GridViewPartial() {
            return PartialView(repository.GetItems());
        }
        public ActionResult GridViewPartialAddNew(DataEntry entry) {
            if (ModelState.IsValid) {
                try {
                    repository.Add(entry);
                    ViewData[EditResultKey] = string.Format("ADDED WITH KEY: '{0}'", entry.ID);
                } catch (Exception e) {
                    ViewData[EditErrorKey] = e.Message;
                }
            } else
                ViewData[EditErrorKey] = "Please, correct all errors.";
            return PartialView("GridViewPartial", repository.GetItems());
        }
        public ActionResult GridViewPartialUpdate(DataEntry entry) {
            if (ModelState.IsValid) {
                try {
                    repository.Update(entry);
                    ViewData[EditResultKey] = string.Format("UPDATED WITH KEY: '{0}'", entry.ID);
                } catch (Exception e) {
                    ViewData[EditErrorKey] = e.Message;
                }
            } else
                ViewData[EditErrorKey] = "Please, correct all errors.";
            return PartialView("GridViewPartial", repository.GetItems());
        }
        public ActionResult GridViewPartialDelete(int id) {
            if (id >= 0) {
                try {
                    repository.Delete(id);
                    ViewData[EditResultKey] = string.Format("DELETED WITH KEY: '{0}'", id);
                } catch (Exception e) {
                    ViewData[EditErrorKey] = e.Message;
                }
            }
            return PartialView("GridViewPartial", repository.GetItems());
        }
    }
}
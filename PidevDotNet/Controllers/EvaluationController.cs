using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;

using PidevDotNet.ViewModel;
using PidevDotNet.Models;
using System.Net.Http.Headers;

namespace PidevDotNet.Controllers
{
    public class EvaluationController : Controller
    {
        // GET: Evaluation
        public ActionResult Index()
        {

            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:9080/UserManager-web/");
            Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = Client.GetAsync("api/evaluations").Result;

            if (response.IsSuccessStatusCode)
            {  //Evaluation

                //    ViewBag.result = response.Content.ReadAsAsync<IEnumerable<Evaluation>>().Result;
                ViewBag.result = response.Content.ReadAsAsync<IEnumerable<EvaluationModel>>().Result;
            }

            else
            {
                ViewBag.result = "error";
            }



            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {

            return View("Create");
        }
        [HttpPost]
        public ActionResult Create(EvaluationModel eval)
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:9080/UserManager-web/");

            var result = client.PostAsJsonAsync<EvaluationModel>("api/evaluations", eval).Result;

            return RedirectToAction("Index");
        }


        // POST: Objectives/Edit/5
        /* [HttpPost]
         public ActionResult Edit(Evaluation obj)
         {

             HttpClient Client = new HttpClient();
             Client.BaseAddress = new Uri("http://localhost:9080/UserManager-web/");
             Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
             HttpResponseMessage response = Client.GetAsync("api/evaluations").Result;
             Evaluation project = new Evaluation();
             if (response.IsSuccessStatusCode)
             {

                 ViewBag.result = response.Content.ReadAsAsync<IEnumerable<Evaluation>>().Result;

             }

             else
             {
                 ViewBag.result = "error";
             }
             return RedirectToAction("index");
         }

     }*/


        //[HttpGet]
        //public ActionResult Edit(int id)
        //{

        //    HttpClient client = new HttpClient();
        //    client.BaseAddress = new Uri("http://localhost:9080/UserManager-web/");
        //    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        //    HttpResponseMessage response = client.GetAsync("api/evaluations/" + id).Result;
        //    Evaluation project = new Evaluation();
        //    if (response.IsSuccessStatusCode)
        //    {

        //        project = response.Content.ReadAsAsync<Evaluation>().Result;

        //    }
        //    else
        //    {
        //        ViewBag.project = "erreur";
        //    }

        //    return View(project);
        //}


        //// POST: Project/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{

        //    EvaluationModel project = new EvaluationModel();

        //    HttpClient client = new HttpClient();
        //    client.BaseAddress = new Uri("http://localhost:9080/UserManager-web/");
        //    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        //    //houni essta3mlt service GetProjectById 
        //    HttpResponseMessage response = client.GetAsync("api/evaluations/" + id).Result;

        //    if (response.IsSuccessStatusCode)
        //    {
        //        project = response.Content.ReadAsAsync<EvaluationModel>().Result;
        //        UpdateModel(project, collection);

        //        // TODO: Add insert logic here

        //        HttpClient client2 = new HttpClient();
        //        client2.BaseAddress = new Uri("http://localhost:9080/UserManager-web/");
        //        client2.PutAsJsonAsync<EvaluationModel>("api/evaluations", project).ContinueWith((postTask) => postTask.Result.IsSuccessStatusCode);
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        return View();
        //    }

        //}




        [HttpGet]
        public ActionResult Edit(int id)
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:9080/");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("UserManager-web/api/evaluations/" + id).Result;
            EvaluationModel evaluation = new EvaluationModel();
            if (response.IsSuccessStatusCode)
            {

                evaluation = response.Content.ReadAsAsync<EvaluationModel>().Result;

            }
            else
            {
                ViewBag.project = "erreur";
            }

            return View(evaluation);
        }

        [HttpPost]
        public ActionResult Edit(EvaluationModel evaluation)
        {

            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:9080/UserManager-web/");
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
           // EvaluationModel eval = evaluation;
            HttpResponseMessage result = Client.PutAsJsonAsync<EvaluationModel>("api/evaluations/"+evaluation.id, evaluation).Result;
            
            
            return RedirectToAction("Index");
        }



        //// POST: Project/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{

        // //  Evaluation evaluation = new Evaluation();
        //    EvaluationModel evaluation = new EvaluationModel();


        //    HttpClient client = new HttpClient();
        //    client.BaseAddress = new Uri("http://localhost:9080/");
        //    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        //    //houni essta3mlt service GetProjectById 
        //    HttpResponseMessage response = client.GetAsync("UserManager-web/api/evaluations/" + id).Result;

        //    if (response.IsSuccessStatusCode)
        //    {  //evalMode..
        //        evaluation = response.Content.ReadAsAsync<EvaluationModel>().Result;
        //        UpdateModel(evaluation, collection);

        //        // TODO: Add insert logic here
        //        try
        //        {


                
        //        HttpClient client2 = new HttpClient();
        //        client2.BaseAddress = new Uri("http://localhost:9080/");
        //        client2.PutAsJsonAsync<EvaluationModel>("UserManager-web/api/evaluations", evaluation).ContinueWith((postTask) => postTask.Result.IsSuccessStatusCode);
        //           // return RedirectToAction("Index");
        //            Console.Write(evaluation);
                  
        //        }
        //        catch { }
        //        return RedirectToAction("Index");

        //        }
        //    else
        //    {
        //        return View();
        //    }

        //}



        // GET: Project/Delete/5
        public ActionResult Delete(int id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:9080/UserManager-web/");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("api/evaluations/" + id).Result;
            EvaluationModel project = new EvaluationModel();
            if (response.IsSuccessStatusCode)
            {

                project = response.Content.ReadAsAsync<EvaluationModel>().Result;

            }
            else
            {
                ViewBag.project = "erreur";
            }

            return View(project);
        }

        // POST: Project/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:9080/UserManager-web/");

                // TODO: Add insert logic here
                client.DeleteAsync("api/evaluations/" + id)
                        .ContinueWith((postTask) => postTask.Result.IsSuccessStatusCode);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }







}








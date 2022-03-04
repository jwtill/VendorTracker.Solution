using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers
{
  public class CategoriesController : Controller
  {
    [HttpGet("/Categories")] //Display all Categories
    public ActionResult Index()
    {
      List<Category> allCategories = Category.GetAll();
      return View(allCategories);
    }
    [HttpGet("/Categories/new")] //Navigate to 'new' page to create new category
    public ActionResult New()
    {
        return View();
    }
    [HttpPost("/categories")] 
    public ActionResult Create(string categoryName) //Path is to 'create.cshtml'passing in categoryName from form from New.cshtml
    {
      Category newCategory = new Category(categoryName); //creates new Category using categoryName, which is passed in through form
      return RedirectToAction("Index"); //Sends us back to the index afterward
    }
    [HttpGet("/categories/{id}")]
    public ActionResult Show(int id)//will display on the show.cshtml page
    {
      Dictionary<string, object> model = new Dictionary<string, object>();//Create dictionary to hold both Category name and Item objects in key value pairs
      Category selectedCategory = Category.Find(id);//find the category with given Id
      List<Item> categoryItems = selectedCategory.Items; //get the items of that category
      model.Add("category", selectedCategory); //add selected category
      model.Add("items", categoryItems); //add the items from that category
      return View(model); //pass the model dictionary into the View()
    }
    
    // This one creates new Items within a given Category, not new Categories:
    [HttpPost("/categories/{categoryId}/items")]
    public ActionResult Create(int categoryId, string itemDescription)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();//create an empty dictionary
      Category foundCategory = Category.Find(categoryId); //
      Item newItem = new Item(itemDescription);
      foundCategory.AddItem(newItem);
      List<Item> categoryItems = foundCategory.Items;
      model.Add("items", categoryItems);
      model.Add("category", foundCategory);
      return View("Show", model);
    }
    
  }
}
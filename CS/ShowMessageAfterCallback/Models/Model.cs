using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class DataEntry {
    public int ID { get; set; }
    public string Text { get; set; }
}

public class Repository {
    public List<DataEntry> GetItems() {
        if (HttpContext.Current.Session["Items"] == null) {
            List<DataEntry> list = Enumerable.Range(0, 100).Select(i => new DataEntry { ID = i, Text = "Text - " + i }).ToList();
            HttpContext.Current.Session["Items"] = list;
        }
        return (List<DataEntry>)HttpContext.Current.Session["Items"];
    }

    public void Add(DataEntry entry) {
        List<DataEntry> list = GetItems();
        entry.ID = list.Count + 1;
        list.Add(entry);
    }

    public void Update(DataEntry entryInfo) {
        DataEntry editedEntry = GetItems().Where(m => m.ID == entryInfo.ID).First();
        editedEntry.Text = entryInfo.Text;
    }

    public void Delete(int id) {
        List<DataEntry> list = GetItems();
        list.Remove(list.Where(m => m.ID == id).First());
    }
}
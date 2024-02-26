using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    class Tarea
    {
        public string Category;
        public string Title;
        public string? Description;
        public DateTime? DueDate;
        public bool IsCompleted, Highlighted;

        public Tarea(string categoria, string title, string? description = null, bool highlighted = false, DateTime? dueDate = null)
        {
            Category = categoria;
            Title = title;
            Description = description;
            Highlighted = highlighted;
            DueDate = dueDate;
            IsCompleted = false;
        }

        public void MarkAsCompleted()
        {
            IsCompleted = true;
        }
        public void SetDate(DateTime date)
        {
            DueDate = date;
        }
        public string ShowDetails(int index)
        {
            string details = @$"------------------------------------------------------------------------
    {Title}.
{index + 1}   {((Description?.Length > 0) ? Description : "La tarea no tiene descripción")}
    {((DueDate != null) ? DueDate : "No tiene fecha de vencimiento")}
------------------------------------------------------------------------";
            return details;
        }

    }
}
